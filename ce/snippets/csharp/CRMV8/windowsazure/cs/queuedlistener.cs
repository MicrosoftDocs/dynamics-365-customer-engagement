// <snippetqueuedlistener>


using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Collections.Generic;
using System.Text;

using Microsoft.ServiceBus;
using Microsoft.Xrm.Sdk;

namespace Microsoft.Crm.Sdk.Samples
{
    class Program
    {
        public static void Main(string[] args)
        {
            Consumer consumer = new Consumer();

            consumer.CreateMessageBuffer();
            consumer.ProcessMessages();
            consumer.DeleteMessageBuffer();
        }
    }

    internal class Consumer
    {
        private MessageBufferClient client;
        private MessageBufferPolicy policy;
        private TransportClientEndpointBehavior credential;
        private Uri uri;

        public Consumer()
        {
            Console.Write("Your Service Namespace: ");
            string serviceNamespace = Console.ReadLine();
            Console.Write("Your Issuer Name: ");
            string issuerName = Console.ReadLine();
            Console.Write("Your Issuer Secret: ");
            string issuerSecret = Console.ReadLine();

            // Create the policy for the message buffer.
            this.policy = new MessageBufferPolicy();
            this.policy.Authorization = AuthorizationPolicy.Required;
            this.policy.MaxMessageCount = 10;
            // Messages in the message buffer expire after 5 minutes.
            this.policy.ExpiresAfter = TimeSpan.FromMinutes(5);
            this.policy.OverflowPolicy = OverflowPolicy.RejectIncomingMessage;
            this.policy.TransportProtection = TransportProtectionPolicy.AllPaths;

            // Create the credentials object for the endpoint.
            this.credential = new TransportClientEndpointBehavior();
            this.credential.CredentialType = TransportClientCredentialType.SharedSecret;
            this.credential.Credentials.SharedSecret.IssuerName = issuerName;
            this.credential.Credentials.SharedSecret.IssuerSecret = issuerSecret;

            // Create the URI for the message buffer.
            this.uri = ServiceBusEnvironment.CreateServiceUri(Uri.UriSchemeHttps, serviceNamespace, "MessageBuffer");
            Console.WriteLine("Message buffer address '{0}'", this.uri.AbsoluteUri);
        }

        public void CreateMessageBuffer()
        {
            Console.Write("Press [Enter] to create the message buffer: ");
            Console.ReadLine();

            // Create the client for the message buffer.
            this.client = GetOrCreateQueue(this.credential, this.uri, ref this.policy);
        }

        public void ProcessMessages()
        {
            while (true)
            {
                Console.Write("Press [Enter] to retrieve a message from the message buffer (type quit to exit): ");
                string line = Console.ReadLine();

                if (!string.IsNullOrEmpty(line) && string.Equals(line, "quit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                try
                {
                    // Retrieve a message from the message buffer.
                    Console.WriteLine("Waiting fom a message from the message buffer... ");
                    Message retrievedMessage = this.client.PeekLock();

                    // Check if the message was sent from Microsoft Dynamics CRM.
                    if (retrievedMessage.Headers.Action ==
                        "https://schemas.microsoft.com/xrm/2011/Contracts/IServiceEndpointPlugin/Execute")
                    {
                        Utility.Print(retrievedMessage.GetBody<RemoteExecutionContext>());
                        this.client.DeleteLockedMessage(retrievedMessage);
                    }
                    else
                        // The message did not originate from Microsoft Dynamics CRM.
                        this.client.ReleaseLock(retrievedMessage);
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

        public void DeleteMessageBuffer()
        {
            // Delete the message buffer.
            Console.Write("Deleting Message buffer at {0} ...", this.uri.AbsoluteUri);
            this.client.DeleteMessageBuffer();
            Console.WriteLine(" done.");
        }

        private MessageBufferClient GetOrCreateQueue(TransportClientEndpointBehavior sharedSecredServiceBusCredential,
                   Uri queueUri, ref MessageBufferPolicy queuePolicy)
        {
            MessageBufferClient client;

            try
            {
                client = MessageBufferClient.GetMessageBuffer(sharedSecredServiceBusCredential, queueUri);
                queuePolicy = client.GetPolicy();
                Console.WriteLine("Message buffer already exists at '{0}'.", client.MessageBufferUri);

                return client;
            }
            catch (FaultException e)
            {
                // Not found. Ignore and make a new queue below. 
                // Other exceptions get bubbled up.
            }

            client = MessageBufferClient.CreateMessageBuffer(sharedSecredServiceBusCredential, queueUri, queuePolicy);
            queuePolicy = client.GetPolicy();
            Console.WriteLine("Message buffer created at '{0}'.", client.MessageBufferUri);
            return client;
        }
    }

    internal static class Utility
    {
        public static void Print(RemoteExecutionContext context)
        {
            Console.WriteLine("----------");
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
            Console.WriteLine("----------");
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
    }
}

// </snippetqueuedlistener>