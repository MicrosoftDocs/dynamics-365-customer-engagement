// <snippetinvokeduplicatedetectionforcreateandupdate>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;

using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to do basic entity operations like create, and
    /// update, using Duplicate Detection attribute.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class InvokeDuplicateDetectionForCreateAndUpdate
    {
        #region Class Level Members

        private Guid _accountId;
        private Guid _ruleId;
        private Guid _dupAccountId;
        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// basic create, retrieve, update, and delete entity operations are performed.
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
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    _service = (IOrganizationService)_serviceProxy;

                    CreateRequiredRecords();

                    // Create and account record with the named Proseware, Inc. and already existing Account Number.
                    Account account = new Account 
                    {
                        Name = "Proseware, Inc.",
                        AccountNumber = "ACC005"
                    };

                    // Create operation by suppressing duplicate detection
                    CreateRequest reqCreate = new CreateRequest();
                    reqCreate.Target = account;
                    reqCreate.Parameters.Add("SuppressDuplicateDetection", true); // Change to false to activate the duplicate detection.
                    CreateResponse createResponse = (CreateResponse)_service.Execute(reqCreate);
                    _dupAccountId = createResponse.id;
                    Console.Write("Account: {0} {1} created with SuppressDuplicateDetection to true, ", 
                        account.Name, account.AccountNumber);
                    
                    // Retrieve the account containing with its few attributes.
                    ColumnSet cols = new ColumnSet(
                        new String[] { "name", "accountnumber"});

                    Account retrievedAccount = (Account)_service.Retrieve("account", _dupAccountId, cols);
                    Console.Write("retrieved, ");

                    // Update the existing account with new account number.
                    retrievedAccount.AccountNumber = "ACC006";                   

                    // Update operation – update record, if a duplicate is not found.
                    UpdateRequest reqUpdate = new UpdateRequest();
                    reqUpdate.Target = retrievedAccount;
                    reqUpdate["SuppressDuplicateDetection"] = false; // Duplicate detection is activated.

                    // Update the account record.
                    UpdateResponse updateResponse = (UpdateResponse)_service.Execute(reqUpdate);
                    Console.WriteLine("and updated.");

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
            // Create an account record named Fourth Coffee.
            Account account = new Account 
            { 
                Name = "Fourth Coffee",
                AccountNumber = "ACC005"
            };            
            _accountId = _service.Create(account);
            Console.Write("Account {0} {1} created, ", account.Name, account.AccountNumber);

            // Create a duplicate detection rule
            DuplicateRule accountDuplicateRule = new DuplicateRule
            {
                Name = "DuplicateRule: Accounts with the same Account Number",
                BaseEntityName = "account",
                MatchingEntityName = "account"                               
            };
            _ruleId = _service.Create(accountDuplicateRule);            

            // Create a duplicate detection rule condition
            DuplicateRuleCondition accountDupCondition = new DuplicateRuleCondition
            {
                BaseAttributeName = "accountnumber",
                MatchingAttributeName = "accountnumber",
                OperatorCode = new OptionSetValue(0), // Exact Match.
                RegardingObjectId = new EntityReference(DuplicateRule.EntityLogicalName, _ruleId)
            };
            Guid conditionId = _service.Create(accountDupCondition);

            Console.Write("'{0}' created, ", accountDuplicateRule.Name);

            // Execute the publish request.
            PublishDuplicateRuleResponse response = 
                (PublishDuplicateRuleResponse)_service.Execute(new PublishDuplicateRuleRequest() { DuplicateRuleId = _ruleId });

            // When the publishDuplicateRule request returns, the state of the rule will still be "Publishing" (StatusCode = 1).
            // we need to wait for the publishing operation to complete, so we keep polling the state of the
            // rule until it becomes "Published" (StatusCode = 2).
            int i = 0;
            DuplicateRule retrievedRule = 
                (DuplicateRule)_service.Retrieve(DuplicateRule.EntityLogicalName, _ruleId, new ColumnSet(new String[] { "statuscode" }));
            while (retrievedRule.StatusCode.Value == 1 && i < 20)
            {
                i++;
                System.Threading.Thread.Sleep(1000);
                retrievedRule = 
                    (DuplicateRule)_service.Retrieve(DuplicateRule.EntityLogicalName, _ruleId, new ColumnSet(new String[] { "statuscode" }));
            }

            Console.Write("published.\n");
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
                Console.WriteLine("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") ||
                                answer.StartsWith("Y") ||
                                answer == String.Empty);
            }

            if (deleteRecords)
            {
                _service.Delete(Account.EntityLogicalName, _accountId);
                UnpublishDuplicateRuleRequest unpublishRequest = new UnpublishDuplicateRuleRequest
                {
                    DuplicateRuleId = _ruleId
                };
                _service.Execute(unpublishRequest);
                _service.Delete(DuplicateRule.EntityLogicalName, _ruleId);
                _service.Delete(Account.EntityLogicalName, _dupAccountId);
                Console.WriteLine("Entity records have been deleted.");
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
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                InvokeDuplicateDetectionForCreateAndUpdate app = new InvokeDuplicateDetectionForCreateAndUpdate();
                app.Run(config, true);
            }
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
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

// </snippetinvokeduplicatedetectionforcreateandupdate>