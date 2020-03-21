// <snippetbulkdetectduplicates>


using System;
using System.Linq;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This samples shows how to issue a BulkDetectDuplicates request.
    /// </summary>
    /// <param name="serverConfig">Contains server connection information.</param>
    /// <param name="promptforDelete">When True, the user will be prompted to delete all
    /// created entities.</param>
    public class BulkDetectDuplicates
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;

        private Account[] _duplicateAccounts = new Account[2];
        private Account _account;
        private DuplicateRule _rule;
        private BulkDetectDuplicatesResponse _response;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first creates 3 accounts with the same name, then issues a BulkDetectDuplicates
        /// request to show the duplicate detection.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>

        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
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

                    // Create the BulkDetectDuplicatesRequest object
                    Console.WriteLine("  Creating the BulkDetectDuplicatesRequest object");
                    BulkDetectDuplicatesRequest request = new BulkDetectDuplicatesRequest()
                    {
                        JobName = "Detect Duplicate Accounts",
                        Query = new QueryExpression()
                        {
                            EntityName = Account.EntityLogicalName,
                            ColumnSet = new ColumnSet(true)
                        },
                        RecurrencePattern = String.Empty,
                        RecurrenceStartTime = DateTime.Now,
                        ToRecipients = new Guid[0],
                        CCRecipients = new Guid[0]
                    };

                    // Execute the request
                    Console.WriteLine("  Executing BulkDetectDuplicatesRequest");
                    _response = (BulkDetectDuplicatesResponse)_serviceProxy
                        .Execute(request);

                    #region check success

                    Console.WriteLine("  Waiting for job to complete...");
                    WaitForAsyncJobToFinish(_response.JobId, 120);

                    QueryByAttribute query = new QueryByAttribute()
                    {
                        ColumnSet = new ColumnSet(true),
                        EntityName = "duplicaterecord"
                    };
                    query.Attributes.Add("asyncoperationid");
                    query.Values.Add(_response.JobId);
                    EntityCollection results = _serviceProxy.RetrieveMultiple(query);

                    // check to make sure each id is found in the collection
                    var duplicateIds = results.Entities.Select((entity) => 
                        ((DuplicateRecord)entity).BaseRecordId.Id);
                    foreach (var id in _duplicateAccounts.Select((account) => account.Id))
                    {
                        if (!duplicateIds.Contains(id))
                        {
                            throw new Exception(String.Format(
                                "Account with ID {0} was not detected as a duplicate",
                                id));
                        }
                    }
                    Console.WriteLine("  All accounts detected as duplicates successfully");

                    #endregion

                    Console.WriteLine();

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

        #region Helper methods

        private void WaitForAsyncJobToFinish(Guid jobId, int maxTimeSeconds)
        {
            for (int i = 0; i < maxTimeSeconds; i++)
            {
                var asyncJob = _serviceProxy.Retrieve(AsyncOperation.EntityLogicalName,
                    jobId, new ColumnSet("statecode")).ToEntity<AsyncOperation>();
                if (asyncJob.StateCode.HasValue && asyncJob.StateCode.Value == AsyncOperationState.Completed)
                    return;
                System.Threading.Thread.Sleep(1000);
            }
            throw new Exception(String.Format(
                "  Exceeded maximum time of {0} seconds waiting for asynchronous job to complete", 
                maxTimeSeconds
            ));
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            #region Creating Accounts

            String accountName = "Contoso, Ltd";
            String websiteUrl = "https://www.contoso.com/";

            Console.WriteLine("  Creating duplicate records (Account name={0}, Website URL={1})", accountName, 
                websiteUrl);
            // Create some duplicate records
            for (int i = 0; i < 2; i++)
            {
                Account account = new Account()
                {
                    Name = accountName,
                    WebSiteURL = websiteUrl
                };
                account.Id = _serviceProxy.Create(account);
                _duplicateAccounts[i] = account;
            }

            accountName = "Contoso Pharmaceuticals";
            Console.WriteLine("  Creating a non-duplicate record (Account name={0}, Website URL={1})", 
                accountName, websiteUrl);
            // Create a record that is NOT a duplicate
            Account distinctAccount = new Account()
            {
                Name = accountName,
                WebSiteURL = websiteUrl
            };
            distinctAccount.Id = _serviceProxy.Create(distinctAccount);
            _account = distinctAccount;

            #endregion

            #region Create and Publish duplicate detection rule

            Console.WriteLine("  Creating a duplicate detection rule");
            // Create a duplicate detection rule
            _rule = new DuplicateRule()
            {
                Name = "Accounts with the same Account name and website url",
                BaseEntityName = Account.EntityLogicalName,
                MatchingEntityName = Account.EntityLogicalName
            };
            _rule.Id = _serviceProxy.Create(_rule);

            // Create a duplicate detection rule condition
            DuplicateRuleCondition nameCondition = new DuplicateRuleCondition()
            {
                BaseAttributeName = "name",
                MatchingAttributeName = "name",
                OperatorCode = new OptionSetValue(0), // value 0 = 'exact match'
                // set the regarding id to point to the rule created earlier,
                // associating this condition with that rule
                RegardingObjectId = _rule.ToEntityReference()
            };
            _serviceProxy.Create(nameCondition);

            DuplicateRuleCondition websiteCondition = new DuplicateRuleCondition()
            {
                BaseAttributeName = "websiteurl",
                MatchingAttributeName = "websiteurl",
                OperatorCode = new OptionSetValue(0),
                RegardingObjectId = _rule.ToEntityReference()
            };
            _serviceProxy.Create(websiteCondition);

            Console.WriteLine("  Publishing duplicate detection rule");
            // Publish the rule
            PublishDuplicateRuleRequest publishRequest = new PublishDuplicateRuleRequest()
            {
                DuplicateRuleId = _rule.Id
            };
            PublishDuplicateRuleResponse publishResponse = (PublishDuplicateRuleResponse)_serviceProxy.Execute(publishRequest);

            // The PublishDuplicateRule request returns before the publish is completed,
            // so we keep retrieving the async job state until it is "Completed"
            Console.WriteLine("  Checking to see if duplicate detection rule has finished publishing");
            WaitForAsyncJobToFinish(publishResponse.JobId, 60);

            #endregion
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
                // Delete the job
                Console.WriteLine("  Deleting the job");
                _serviceProxy.Delete(AsyncOperation.EntityLogicalName, _response.JobId);

                // Delete the duplicate detection rule
                Console.WriteLine("  Deleting the duplicate detection rule");
                _serviceProxy.Delete(DuplicateRule.EntityLogicalName, _rule.Id);

                // Delete the accounts
                Console.WriteLine("  Deleting the accounts");
                foreach (Account account in _duplicateAccounts)
                    _serviceProxy.Delete(Account.EntityLogicalName, account.Id);
                _serviceProxy.Delete(Account.EntityLogicalName, _account.Id);
                Console.WriteLine("Entity records have been deleted.");
            }
        }
        #endregion Public Methods

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
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                BulkDetectDuplicates app = new BulkDetectDuplicates();
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

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe = ex.InnerException
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

        #endregion Main method
    }
}

// </snippetbulkdetectduplicates>