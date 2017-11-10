// <snippetsendbulkemailandmonitor>


using System;
using System.ServiceModel;
using System.Collections.Generic;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;

// These namespaces are found in the Microsoft.Crm.Sdk.Proxy.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    public class SendBulkEmailAndMonitor
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;
        private List<Guid> _contactsIds = new List<Guid>();
        private const int ARBITRARY_MAX_POLLING_TIME = 60;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This sample shows how to send a bulk email and monitor its progress.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user is prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy is properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();

                    #region Create and send SendBulkEmail

                    Console.WriteLine();
                    Console.WriteLine("Creating and sending SendBulkEmail.");

                    // Get a system user to use as the sender.
                    WhoAmIRequest emailSenderRequest = new WhoAmIRequest();
                    WhoAmIResponse emailSenderResponse =
                        _serviceProxy.Execute(emailSenderRequest) as WhoAmIResponse;

                    // Set trackingId for bulk mail request.
                    Guid trackingId = Guid.NewGuid();

                    SendBulkMailRequest bulkMailRequest = new SendBulkMailRequest()
                    {
                        // Create a query expression for the bulk operation to use to retrieve 
                        // the contacts in the email list.
                        Query = new QueryExpression()
                        {
                            EntityName = Contact.EntityLogicalName,
                            ColumnSet = new ColumnSet(new String[] { "contactid" }),
                            Criteria = new FilterExpression()
                            {
                                Conditions = 
                            {
                                new ConditionExpression("contactid",ConditionOperator.In, _contactsIds)
                            }
                            }
                        },
                        // Set the Sender.
                        Sender = new EntityReference(SystemUser.EntityLogicalName, emailSenderResponse.UserId),
                        // Set the RegardingId - this field is required.
                        RegardingId = Guid.Empty,
                        RegardingType = SystemUser.EntityLogicalName,
                        // Use a built-in Microsoft Dynamics CRM email template.
                        // NOTE: The email template's "template type" must match the type of 
                        // customers in the email list.  Our list contains contacts, so our 
                        // template must be for contacts.
                        TemplateId = new Guid("07B94C1D-C85F-492F-B120-F0A743C540E6"),
                        RequestId = trackingId
                    };

                    // Execute the async bulk email request
                    SendBulkMailResponse resp = (SendBulkMailResponse)
                        _serviceProxy.Execute(bulkMailRequest);

                    Console.WriteLine("  Sent Bulk Email.");
                    #endregion

                    #region Monitoring SendBulkEmail

                    Console.WriteLine();
                    Console.WriteLine("Starting monitoring process..");

                    // Now that we've executed the bulk operation, we need to retrieve it 
                    // using our tracking Id.

                    QueryByAttribute bulkQuery = new QueryByAttribute()
                    {
                        EntityName = AsyncOperation.EntityLogicalName,
                        ColumnSet = new ColumnSet(new string[] { "requestid", "statecode" }),
                        Attributes = { "requestid" },
                        Values = { trackingId }
                    };

                    // Retrieve the bulk email async operation.
                    EntityCollection aResponse = _serviceProxy.RetrieveMultiple(bulkQuery);

                    Console.WriteLine("  Retrieved Bulk Email Async Operation.");

                    // Monitor the async operation via polling.
                    int secondsTicker = ARBITRARY_MAX_POLLING_TIME;

                    AsyncOperation createdBulkMailOperation = null;

                    Console.WriteLine("  Checking operation's state for " + ARBITRARY_MAX_POLLING_TIME + " seconds.");
                    Console.WriteLine();

                    while (secondsTicker > 0)
                    {
                        // Make sure the async operation was retrieved.
                        if (aResponse.Entities.Count > 0)
                        {
                            // Grab the one bulk operation that has been created.
                            createdBulkMailOperation = (AsyncOperation)aResponse.Entities[0];

                            // Check the operation's state.
                            if (createdBulkMailOperation.StateCode.Value !=
                                AsyncOperationState.Completed)
                            {
                                // The operation has not yet completed. 
                                // Wait a second for the status to change.
                                System.Threading.Thread.Sleep(1000);
                                secondsTicker--;

                                // Retrieve a fresh version the bulk delete operation.
                                aResponse = _serviceProxy.RetrieveMultiple(bulkQuery);
                            }
                            else
                            {
                                // Stop polling because the operation's state is now complete.
                                secondsTicker = 0;
                            }
                        }
                        else
                        {
                            // Wait a second for the async operation to activate.
                            System.Threading.Thread.Sleep(1000);
                            secondsTicker--;

                            // Retrieve the entity again
                            aResponse = _serviceProxy.RetrieveMultiple(bulkQuery);
                        }
                    }

                    // When the bulk email operation has completed, all sent emails will 
                    // have a status of "Pending Send" and will be picked up by your email 
                    // router.  Alternatively, you can then use BackgroundSendEmail to download
                    // all the emails created with the SendBulkEmail message. 
                    // See the BackgroundSendEmail sample for an example.
                    #endregion

                    #region Check success

                    // Validate async operation succeeded
                    if (createdBulkMailOperation.StateCode.Value == AsyncOperationState.Completed)
                    {
                        Console.WriteLine("Operation Completed.");
                    }
                    else
                    {
                        Console.WriteLine("Operation not completed yet.");
                    }

                    #endregion

                    DeleteRequiredRecords(promptforDelete);
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
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            Console.WriteLine("Creating contacts records...");

            Contact emailContact1 = new Contact()
            {
                FirstName = "Adam",
                LastName = "Carter",
                EMailAddress1 = "someone@example.com"
            };

            // Create the contact1.
            _contactsIds.Add(_serviceProxy.Create(emailContact1));
            Console.WriteLine("Contact1 created.");

            Contact emailContact2 = new Contact()
            {
                FirstName = "Adina",
                LastName = "Hagege",
                EMailAddress1 = "someone@example.com"
            };

            // Create the contact2.
            _contactsIds.Add(_serviceProxy.Create(emailContact2));
            Console.WriteLine("Contact2 created.");

        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
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
                // Delete the contacts.
                foreach (var contactId in _contactsIds)
                {
                    _serviceProxy.Delete(Contact.EntityLogicalName, contactId);
                }
                Console.WriteLine("Contacts have been deleted.");
            }
        }
        #endregion How To Sample Code

        #region Main method

        /// <summary>
        /// Standard Main() method used by most SDK samples.
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            try
            {
                // Obtain the target organization's web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                SendBulkEmailAndMonitor app = new SendBulkEmailAndMonitor();
                app.Run(config, true);
            }

            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
                Console.WriteLine("Trace: {0}", ex.Detail.TraceText);
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

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe = ex.InnerException
                        as FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>;
                    if (fe != null)
                    {
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp);
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode);
                        Console.WriteLine("Message: {0}", fe.Detail.Message);
                        Console.WriteLine("Trace: {0}", fe.Detail.TraceText);
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
        #endregion Main method
    }
}

// </snippetsendbulkemailandmonitor>