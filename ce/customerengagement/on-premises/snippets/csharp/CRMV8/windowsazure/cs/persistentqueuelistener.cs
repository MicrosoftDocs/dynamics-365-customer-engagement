// <snippetpersistentqueuelistener>


using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Collections.Generic;
using System.Text;

using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Microsoft.Xrm.Sdk;

namespace Microsoft.Crm.Sdk.Samples
{
    class Program
    {
        public static void Main(string[] args)
        {
            Consumer consumer = new Consumer();

            consumer.CreateQueueClient();
            consumer.ProcessMessages();
            consumer.DeleteQueue();
        }
    }

    internal class Consumer
    {
        private const String MyQueuePath = "MyQueue";
        private QueueDescription queueDescription;
        private QueueClient queueClient;
        private Uri namespaceUri;
        private TransportClientEndpointBehavior credential;
        
        public Consumer()
        {
            Console.Write("Your Service Namespace: ");
            string serviceNamespace = Console.ReadLine();
            Console.Write("Your Issuer Name: ");
            string issuerName = Console.ReadLine();
            Console.Write("Your Issuer Secret: ");
            string issuerSecret = Console.ReadLine();

            // Configure queue settings.
            this.queueDescription = new QueueDescription(MyQueuePath);
            // Setting Max Size and TTL for demonstration purpose
            // but can be changed per user discretion to suite their system needs.
            // Refer service bus documentation to understand the limitations.
            // Setting Queue max size to 1GB where as default Max Size is 5GB.
            this.queueDescription.MaxSizeInMegabytes = 1024;
            // Setting message TTL to 5 days where as default TTL is 14 days.
            this.queueDescription.DefaultMessageTimeToLive = TimeSpan.FromDays(5);
            
            // Create management credentials.
            this.credential = new TransportClientEndpointBehavior() 
            {
                TokenProvider = TokenProvider.CreateSharedSecretTokenProvider(issuerName, issuerSecret)
            };
 
            // Create the URI for the queue.
            this.namespaceUri = ServiceBusEnvironment.CreateServiceUri("sb", serviceNamespace, String.Empty);
            Console.WriteLine("Service Bus Namespace Uri address '{0}'", this.namespaceUri.AbsoluteUri);
        }

        public void CreateQueueClient()
        {
            // get the existing queue or create a new queue if it doesn't exist.
            this.queueClient = GetOrCreateQueue(namespaceUri, this.credential.TokenProvider);
        }

        public void ProcessMessages()
        {
            // Get receive mode (PeekLock or ReceiveAndDelete) from queueClient.
            ReceiveMode mode = this.queueClient.Mode;
            while (true)
            {
                Console.Write("Press [Enter] to retrieve a message from the queue (type quit to exit): ");
                string line = Console.ReadLine();

                if (!string.IsNullOrEmpty(line) && string.Equals(line, "quit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                // Retrieve a message from the queue.
                Console.WriteLine("Waiting for a message from the queue... ");
                BrokeredMessage message;
                try
                {
                    message = this.queueClient.Receive();
                    // Check if the message received.
                    if (message != null)
                    {
                        try
                        {
                            // Verify EntityLogicalName and RequestName message properties 
                            // to only process specific message sent from Microsoft Dynamics CRM. 
                            string keyRoot = "https://schemas.microsoft.com/xrm/2011/Claims/";
                            string entityLogicalNameKey = "EntityLogicalName";
                            string requestNameKey = "RequestName";
                            object entityLogicalNameValue;
                            object requestNameValue;
                            message.Properties.TryGetValue(keyRoot + entityLogicalNameKey, out entityLogicalNameValue);
                            message.Properties.TryGetValue(keyRoot + requestNameKey, out requestNameValue);

                            // Filter message with specific message properties. i.e. EntityLogicalName=letter and RequestName=Create
                            if (entityLogicalNameValue != null && requestNameValue != null)
                            {
                                if (entityLogicalNameValue.ToString() == "letter" && requestNameValue.ToString() == "Create")
                                {
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine(string.Format("Message received: Id = {0}", message.MessageId));
                                    // Display message properties that are set on the brokered message.
                                    Utility.PrintMessageProperties(message.Properties);
                                    // Display body details.
                                    Utility.Print(message.GetBody<RemoteExecutionContext>());
                                    Console.WriteLine("--------------------------------");
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                            // If receive mode is PeekLock then set message complete to remove message from queue.
                            if (mode == ReceiveMode.PeekLock)
                            {
                                message.Complete();
                            }
                        }
                        catch (System.Exception ex)
                        {
                            // Indicate a problem, unlock message in queue.
                            if (mode == ReceiveMode.PeekLock)
                            {
                                message.Abandon();
                            }
                            Console.WriteLine(ex.Message);
                            continue;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                catch (System.TimeoutException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (System.ServiceModel.FaultException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
        }

        public void DeleteQueue()
        {
            DeleteQueueInternal(namespaceUri, MyQueuePath, credential.TokenProvider);
        }

        private void DeleteQueueInternal(Uri address, string path, TokenProvider tokenProvider)
        {
            var settings = new NamespaceManagerSettings() { TokenProvider = tokenProvider };
            var namespaceClient = new ServiceBus.NamespaceManager(address, settings);
            try
            {
                namespaceClient.DeleteQueue(path);
                Console.WriteLine("Queue deleted successfully.");
            }
            catch (FaultException e)
            {
                Console.WriteLine("Exception when deleting queue.. {0}", e);
            }
        }

        private QueueClient GetOrCreateQueue(Uri namespaceUri, TokenProvider tokenProvider)
        {
            NamespaceManager namespaceClient = new NamespaceManager(namespaceUri, tokenProvider);

            // Create queue if not already exist.
            if (!namespaceClient.QueueExists(MyQueuePath))
            {
                namespaceClient.CreateQueue(this.queueDescription);
                Console.WriteLine("Queue created.");
            }
            else
            {
                Console.WriteLine("Queue already exists.");
            }

            MessagingFactory factory = MessagingFactory.Create(namespaceUri, tokenProvider);
            Console.WriteLine("Creating queue client...");
            return factory.CreateQueueClient(MyQueuePath, ReceiveMode.PeekLock);            
        }
    }

    internal static class Utility
    {
        public static void Print(RemoteExecutionContext context)
        {   
            if (context == null)
            {
                Console.WriteLine("Context is null.");
                return;
            }

            Console.WriteLine("UserId: {0}", context.UserId);
            Console.WriteLine("OrganizationId: {0}", context.OrganizationId);
            Console.WriteLine("OrganizationName: {0}", context.OrganizationName);
            Console.WriteLine("MessageName: {0}", context.MessageName);
            Console.WriteLine("Stage: {0}", context.Stage);
            Console.WriteLine("Mode: {0}", context.Mode);
            Console.WriteLine("PrimaryEntityName: {0}", context.PrimaryEntityName);
            Console.WriteLine("SecondaryEntityName: {0}", context.SecondaryEntityName);

            Console.WriteLine("BusinessUnitId: {0}", context.BusinessUnitId);
            Console.WriteLine("CorrelationId: {0}", context.CorrelationId);
            Console.WriteLine("Depth: {0}", context.Depth);
            Console.WriteLine("InitiatingUserId: {0}", context.InitiatingUserId);
            Console.WriteLine("IsExecutingOffline: {0}", context.IsExecutingOffline);
            Console.WriteLine("IsInTransaction: {0}", context.IsInTransaction);
            Console.WriteLine("IsolationMode: {0}", context.IsolationMode);
            Console.WriteLine("Mode: {0}", context.Mode);
            Console.WriteLine("OperationCreatedOn: {0}", context.OperationCreatedOn.ToString());
            Console.WriteLine("OperationId: {0}", context.OperationId);
            Console.WriteLine("PrimaryEntityId: {0}", context.PrimaryEntityId);
            Console.WriteLine("OwningExtension LogicalName: {0}", context.OwningExtension.LogicalName);
            Console.WriteLine("OwningExtension Name: {0}", context.OwningExtension.Name);
            Console.WriteLine("OwningExtension Id: {0}", context.OwningExtension.Id);
            Console.WriteLine("SharedVariables: {0}", (context.SharedVariables == null ? "NULL" :
                SerializeParameterCollection(context.SharedVariables)));
            Console.WriteLine("InputParameters: {0}", (context.InputParameters == null ? "NULL" :
                SerializeParameterCollection(context.InputParameters)));
            Console.WriteLine("OutputParameters: {0}", (context.OutputParameters == null ? "NULL" :
                SerializeParameterCollection(context.OutputParameters)));
            Console.WriteLine("PreEntityImages: {0}", (context.PreEntityImages == null ? "NULL" :
                SerializeEntityImageCollection(context.PreEntityImages)));
            Console.WriteLine("PostEntityImages: {0}", (context.PostEntityImages == null ? "NULL" :
                SerializeEntityImageCollection(context.PostEntityImages)));
        }

        #region Private methods.
        private static string SerializeEntity(Entity e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            sb.Append(" LogicalName: " + e.LogicalName);
            sb.Append(Environment.NewLine);
            sb.Append(" EntityId: " + e.Id);
            sb.Append(Environment.NewLine);
            sb.Append(" Attributes: [");
            foreach (KeyValuePair<string, object> parameter in e.Attributes)
            {
                sb.Append(parameter.Key + ": " + parameter.Value + "; ");
            }
            sb.Append("]");
            return sb.ToString();
        }

        private static string SerializeParameterCollection(ParameterCollection parameterCollection)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, object> parameter in parameterCollection)
            {
                if (parameter.Value != null && parameter.Value.GetType() == typeof(Entity))
                {
                    Entity e = (Entity)parameter.Value;
                    sb.Append(parameter.Key + ": " + SerializeEntity(e));
                }
                else
                {
                    sb.Append(parameter.Key + ": " + parameter.Value + "; ");
                }
            }
            return sb.ToString();
        }
        private static string SerializeEntityImageCollection(EntityImageCollection entityImageCollection)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, Entity> entityImage in entityImageCollection)
            {
                sb.Append(Environment.NewLine);
                sb.Append(entityImage.Key + ": " + SerializeEntity(entityImage.Value));
            }
            return sb.ToString();
        }
        #endregion

        internal static void PrintMessageProperties(IDictionary<string, object> iDictionary)
        {
            if (iDictionary.Count == 0)
            {
                Console.WriteLine("No Message properties found.");
                return;
            }
            foreach (var item in iDictionary)
            {
                String key = (item.Key != null) ? item.Key.ToString() : "";
                String value = (item.Value != null)? item.Value.ToString() : "";
                Console.WriteLine( key + " " + value);
            }
        }
    }
}

// </snippetpersistentqueuelistener>