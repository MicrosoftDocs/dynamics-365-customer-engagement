// <snippetaddtoqueue>


using System;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Client;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This Sample shows how to move a record from one queue to another.
    /// </summary>
    public class AddToQueue
    {
        #region Class Level Members

        // Define the IDs needed for this sample.
        private Guid _sourceQueueId;
        private Guid _destinationQueueId;
        private Guid _letterId;
        private Guid _userId;
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Initiate the method to create any data that this sample requires.
        /// Move a record from a source queue to a destination queue.
        /// Optionally delete any entity records that were created for this sample.
        /// <para name="organizationFriendlyName">The friendly name of the target 
        /// organization.</para>
        /// <para name="discoveryServer">The name of the discovery server.</para>
        /// <param name="promptForDelete">Indicates whether to prompt the user to 
        /// delete the records created in this sample.</param>
        /// </summary>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri, serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();

                    Guid CurrentUserId = ((WhoAmIResponse)_serviceProxy.Execute(new WhoAmIRequest())).UserId;



                    // Get known private queues for the user 
                    // by using RetrieveUserQueuesRequest message.
                    RetrieveUserQueuesRequest retrieveUserQueuesRequest = new RetrieveUserQueuesRequest
                    {
                        UserId = CurrentUserId,
                        IncludePublic = true
                    };
                    RetrieveUserQueuesResponse retrieveUserQueuesResponse =
                        (RetrieveUserQueuesResponse)_serviceProxy.Execute(retrieveUserQueuesRequest);
                    EntityCollection queues = (EntityCollection)retrieveUserQueuesResponse.EntityCollection;

                    Guid sourceQueueId = new Guid();
                    Guid destinationQueueId = new Guid();

                    foreach (Entity entity in queues.Entities)
                    {
                        Queue queue = (Queue)entity;
                        switch (queue.Name)
                        {
                            case "Source Queue":
                                sourceQueueId = queue.Id;
                                break;
                            case "Destination Queue":
                                destinationQueueId = queue.Id;
                                break;
                        }
                    }

                    // Move a record from a source queue to a destination queue
                    // by using the AddToQueue request message.
                    AddToQueueRequest routeRequest = new AddToQueueRequest
                    {
                        SourceQueueId = sourceQueueId,
                        Target = new EntityReference(Letter.EntityLogicalName, _letterId),
                        DestinationQueueId = destinationQueueId
                    };

                    // Execute the Request
                    _serviceProxy.Execute(routeRequest);

                    Console.WriteLine(@"The letter record has been moved to a new queue.");

                    DeleteRequiredRecords(promptForDelete);

                }
            }
            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
            {
                // You can handle an exception here or pass it back to the calling method.
                throw;
            }
        }

        /// <summary>
        /// This method creates any entity records that this sample requires.
        /// Create source queue and destination queue.
        /// Create a letter  entity.
        /// Add letter  entity to source queue.
        /// </summary>
        public void CreateRequiredRecords()
        {
            var QueueViewType = new
            {
                Public = 0,
                Private = 1
            };
            //Create new queues and store their returned GUIDs in variables for later use.
            Queue sourceQueue = new Queue
                {
                    Name = "Source Queue",
                    Description = "This is an example queue.",
                    QueueViewType = new OptionSetValue(QueueViewType.Private)
                };

            _sourceQueueId = _serviceProxy.Create(sourceQueue);
            Console.WriteLine("Created {0}", sourceQueue.Name);

            Queue destinationQueue = new Queue
                {
                    Name = "Destination Queue",
                    Description = "This is an example queue.",
                    QueueViewType = new OptionSetValue(QueueViewType.Private)
                };

            _destinationQueueId = _serviceProxy.Create(destinationQueue);
            Console.WriteLine("Created {0}", destinationQueue.Name);


            // Create a letter  entity.
            Letter newLetter = new Letter
            {
                Description = "Example Letter"
            };

            _letterId = _serviceProxy.Create(newLetter);
            Console.WriteLine("Created {0}", newLetter.Description);

            // Use AddToQueue message to add an  entity into a queue, which will associate
            // the letter with the first queue.
            AddToQueueRequest addToSourceQueue = new AddToQueueRequest
            {
                DestinationQueueId = _sourceQueueId,
                Target = new EntityReference(Letter.EntityLogicalName, _letterId)
            };

            _serviceProxy.Execute(addToSourceQueue);
            Console.WriteLine("Added letter record to {0}", sourceQueue.Name);

            // Retrieve/create a user record for assigning the queue item to the user's
            // queue.
            _userId = SystemUserProvider.RetrieveSalesManager(_serviceProxy);

            return;
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete 
        /// the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool toBeDeleted = true;

            if (prompt)
            {
                // Ask the user if the created entities should be deleted.
                Console.Write("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();
                if (answer.StartsWith("y") ||
                    answer.StartsWith("Y") ||
                    answer == String.Empty)
                {
                    toBeDeleted = true;
                }
                else
                {
                    toBeDeleted = false;
                }
            }

            if (toBeDeleted)
            {
                _serviceProxy.Delete(Letter.EntityLogicalName, _letterId);
                _serviceProxy.Delete(Queue.EntityLogicalName, _sourceQueueId);
                _serviceProxy.Delete(Queue.EntityLogicalName, _destinationQueueId);

                Console.WriteLine("Entity records have been deleted.");
            }
        }

        #endregion How To Sample Code

        #region Main
        /// <summary>
        /// Main. Runs the sample and provides error output.
        /// <param name="args">Array of arguments to Main method.</param>
        /// </summary>
        static public void Main(string[] args)
        {
            try
            {
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                AddToQueue app = new AddToQueue();
                app.Run(config, true);
            }

            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
            }
            catch (System.TimeoutException ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.InnerException.Message ? "No Inner Fault" : ex.InnerException.Message);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine(ex.Message);

                // Display the details of the inner exception.
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe
                        = ex.InnerException
                        as FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>;
                    if (fe != null)
                    {
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp);
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode);
                        Console.WriteLine("Message: {0}", fe.Detail.Message);
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText);
                        Console.WriteLine("Inner Fault: {0}",
                            null == fe.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
                    }
                }
            }
            // Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            // SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            finally
            {
                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }

        }
        #endregion Main
    }
}

// </snippetaddtoqueue>