// <snippetcleanupqueueitems>


using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Client;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This Sample shows how to delete inactive items in a queue.
    /// </summary>
    public class CleanUpQueueItems
    {
        #region Class Level Members

        // Define the IDs needed for this sample.
        private Guid _queueId;
        private Guid _phoneCallId;
        private Guid _queueItemId;
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Initiate the method to create any data that this sample requires.
        /// Retrieve all queueitems with inactive phone calls from a queue.
        /// Delete all inactive phone call entity instances.
        /// Optionally delete any entity records that were created for this sample.
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        /// </summary>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {

                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                                     serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();


                    // Retrieve the queueitem with inactive phone calls from a queue            
                    RemoveFromQueueRequest removeFromQueueRequest = new RemoveFromQueueRequest
                    {
                        QueueItemId = _queueItemId
                    };
                    _serviceProxy.Execute(removeFromQueueRequest);


                    Console.WriteLine("Inactive phonecalls have been deleted from the queue.");

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
        /// Create a queue instance. 
        /// Create a phone call activity instance.
        /// Add phone call entity instance in to queue.
        /// Mark phone call entity instance status as completed.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Create a queue instance and set its property values.
            Queue newQueue = new Queue()
            {
                Name = "Example Queue",
                Description = "This is an example queue.",
                QueueViewType = new OptionSetValue((int)QueueQueueViewType.Private)
            };

            _queueId = _serviceProxy.Create(newQueue);
            Console.WriteLine("Created {0}.", newQueue.Name);

            // Create a phone call activity instance.
            PhoneCall newPhoneCall = new PhoneCall
            {
                Description = "Example Phone Call"
            };

            _phoneCallId = _serviceProxy.Create(newPhoneCall);
            Console.WriteLine("Created {0}.", newPhoneCall.Description);

            // Create a new instance of a queueitem and initialize its 
            // properties.
            QueueItem item = new QueueItem
            {
                QueueId = new EntityReference(Queue.EntityLogicalName, _queueId),
                ObjectId = new EntityReference(PhoneCall.EntityLogicalName, _phoneCallId)
            };

            // Create the queueitem on the server, which will associate 
            // the phone call activity with the queue.
            _queueItemId = _serviceProxy.Create(item);

            Console.WriteLine("Added phone call entity instance to {0}", newQueue.Name);

            // Mark the phone call as completed.
            SetStateRequest setStatePhoneCall = new SetStateRequest
            {
                EntityMoniker = new EntityReference(PhoneCall.EntityLogicalName,
                    _phoneCallId),
                State = new OptionSetValue((int)PhoneCallState.Completed),
                Status = new OptionSetValue(-1)
            };

            _serviceProxy.Execute(setStatePhoneCall);
            Console.WriteLine("PhoneCall entity instance has been marked as completed.");

            return;
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                _serviceProxy.Delete(PhoneCall.EntityLogicalName, _phoneCallId);
                _serviceProxy.Delete(Queue.EntityLogicalName, _queueId);

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

                CleanUpQueueItems app = new CleanUpQueueItems();
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

// </snippetcleanupqueueitems>