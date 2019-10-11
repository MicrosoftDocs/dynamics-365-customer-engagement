// <snippetenableduplicatedetectionandretrieveduplicates>


using System;
using System.Collections.Generic;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to enable duplicate detection and retrieve duplicate
    /// records based on the active duplicate detection rule(s).
    /// </summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.
    /// </remarks>
    public class EnableDuplicateDetectionAndRetrieveDuplicates
    {
        #region Class Level Members
        private OrganizationServiceProxy _serviceProxy;
        private Guid? _accountId1;
        private Guid? _accountId2;
        #endregion

        #region How To Sample Code

        /// <summary>
        /// Enables dupe detection and retrieves duplicates. 
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig,bool promptforDelete)
        {
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                // This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes();
                EnableDuplicateDetectionForOrg();
                EnableDuplicateDetectionForEntity(Account.EntityLogicalName);
                PublishRulesForEntity(Account.EntityLogicalName);
                CreateAccountRecords();
                RetrieveDuplicates();
                DeleteRequiredRecords(promptforDelete);
            }
        }

        /// <summary>
        /// Create some account records to retrieve duplicates
        /// </summary>
        private void CreateAccountRecords()
        {
            var crmAccount = new Account { Name="Microsoft"};
             
            _accountId1 = _serviceProxy.Create(crmAccount);
            _accountId2 = _serviceProxy.Create(crmAccount);
            Console.WriteLine(String.Concat("Creating duplicate records:\n\taccount 1 - ",
                _accountId1.Value, "\n\taccount 2 - ", _accountId2.Value));
        }

        /// <summary>
        /// Call the method to retrieve duplicate records.  
        /// </summary>
        private void RetrieveDuplicates()
        {
            // PagingInfo is Required. 
            var request = new RetrieveDuplicatesRequest
            {
                BusinessEntity = new Account { Name = "Microsoft" }.ToEntity<Entity>(),
                MatchingEntityName = Account.EntityLogicalName,
                PagingInfo = new PagingInfo() { PageNumber = 1, Count = 50 }
            };

            Console.WriteLine("Retrieving duplicates");
            var response =(RetrieveDuplicatesResponse)_serviceProxy.Execute(request);

            for (int i = 0; i < response.DuplicateCollection.Entities.Count; i++)
            {
                var crmAccount = response.DuplicateCollection.Entities[i]
                    .ToEntity<Account>();
                Console.WriteLine(crmAccount.Name + ", " + crmAccount.AccountId.Value.ToString()); 
            }
        }

        /// <summary>
        /// Enables duplicate detection for the organization
        /// </summary>
        private void EnableDuplicateDetectionForOrg()
        {
            // Retrieve the org ID
            var orgId = RetrieveOrganizationId();
            if (!orgId.HasValue)
                return;

            Console.WriteLine(String.Concat("Enabling duplicate detection for organization: ", 
                orgId.Value));

            // Enable dupe detection for each type
            var crmOrganization = new Organization
            {
                Id = orgId.Value,
                IsDuplicateDetectionEnabled = true,
                IsDuplicateDetectionEnabledForImport = true,
                IsDuplicateDetectionEnabledForOfflineSync = true,
                IsDuplicateDetectionEnabledForOnlineCreateUpdate = true,
            };

            _serviceProxy.Update(crmOrganization);
        }

        /// <summary>
        /// Enabling the dupe detection unpublishes the rules.  
        /// This will publish them, and wait for them to complete publishing.
        /// </summary>
        /// <param name="entityName"></param>
        private void PublishRulesForEntity(string entityName)
        {
            // Retrieve all rules for the entity
            var rules = _serviceProxy.RetrieveMultiple(
                new QueryByAttribute(DuplicateRule.EntityLogicalName)
            {
                ColumnSet = new ColumnSet("duplicateruleid"),
                Attributes = { "matchingentityname" },
                Values = { entityName }
            });

            List<Guid> crmAsyncOperationIds = new List<Guid>();
            foreach (var item in rules.Entities)
            {
                Console.WriteLine(String.Concat("Publishing duplicate rule: ", item.Id));

                // Publish each rule and get the job id since it is async
                var response = (PublishDuplicateRuleResponse)_serviceProxy.Execute(
                        new PublishDuplicateRuleRequest { DuplicateRuleId = item.Id });

                crmAsyncOperationIds.Add(response.JobId);
            }

            // Wait until all the rules are published before testing the dupe detection
            WaitForAsyncJobCompletion(crmAsyncOperationIds);
        }

        /// <summary>
        /// Updates the entity customizations and publishes the entity 
        /// </summary>
        /// <param name="entityName"></param>
        private void EnableDuplicateDetectionForEntity(string entityName)
        {
            Console.WriteLine(String.Format("Retrieving entity metadata for {0}",
                entityName));

            // Retrieve the entity metadata
            var crmEntity = ((RetrieveEntityResponse)_serviceProxy.Execute(
                new RetrieveEntityRequest
                {
                    RetrieveAsIfPublished = true,
                    LogicalName = entityName
                })).EntityMetadata;

            Console.WriteLine(String.Concat("Enabling duplicate for ", entityName));

            // Update the duplicate detection flag
            crmEntity.IsDuplicateDetectionEnabled = 
                new BooleanManagedProperty(true);

            // Update the entity metadata
            _serviceProxy.Execute(new UpdateEntityRequest
            {
                Entity = crmEntity
            });

            Console.WriteLine(String.Concat("Publishing ", entityName, " entity"));

            // Publish the entity 
            var publishRequest = new PublishXmlRequest
            {              
                ParameterXml = String.Concat("<importexportxml><entities><entity>",
                    entityName, "</entity></entities></importexportxml>"),
            };

            _serviceProxy.Execute(publishRequest);
        }

        /// <summary>
        /// There should only be one organization record per Crm Org
        /// </summary>
        /// <returns></returns>
        private Guid? RetrieveOrganizationId()
        {   
            // Retrieve the first record in the organization table.  
            // There should only be one organization record. 
            var entities = _serviceProxy.RetrieveMultiple(
                new QueryExpression(Organization.EntityLogicalName)
                {
                    ColumnSet = new ColumnSet("organizationid"),
                    PageInfo = new PagingInfo { PageNumber = 1, Count = 1 },
                });

            if (entities != null && entities.Entities.Count > 0)
                return entities.Entities[0].Id;

            return null;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prompt"></param>
        private void DeleteRequiredRecords(bool prompt)
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
                // Delete records created in this sample.
                if (_accountId1.HasValue)
                {
                    Console.WriteLine(String.Concat("Deleting account: ", _accountId1.Value));
                    _serviceProxy.Delete(Account.EntityLogicalName, _accountId1.Value);
                }
                if (_accountId2.HasValue)
                {
                    Console.WriteLine(String.Concat("Deleting account: ", _accountId2.Value)); 
                    _serviceProxy.Delete(Account.EntityLogicalName, _accountId2.Value);
                }
                Console.WriteLine("Entity records have been deleted.");
            }
        }

        /// <summary>
        /// Waits for async job to complete
        /// </summary>
        /// <param name="asyncJobId"></param>
        public void WaitForAsyncJobCompletion(IEnumerable<Guid> asyncJobIds)
        {
            List<Guid> asyncJobList = new List<Guid>(asyncJobIds);
            ColumnSet cs = new ColumnSet("statecode", "asyncoperationid");
            int retryCount = 100;

            while (asyncJobList.Count != 0 && retryCount > 0)
            {
                // Retrieve the async operations based on the ids
                var crmAsyncJobs = _serviceProxy.RetrieveMultiple(
                    new QueryExpression("asyncoperation")
                    {
                        ColumnSet = cs,
                        Criteria = new FilterExpression
                        {
                            Conditions = 
                            {
                                new ConditionExpression("asyncoperationid",
                                    ConditionOperator.In, asyncJobList.ToArray())
                            }
                        }
                    });

                // Check to see if the operations are completed and if so remove them from the Async Guid list
                foreach (var item in crmAsyncJobs.Entities)
	            {
                    var crmAsyncJob = item.ToEntity<AsyncOperation>();
                    if (crmAsyncJob.StateCode.HasValue && 
                        crmAsyncJob.StateCode.Value == AsyncOperationState.Completed)
                        asyncJobList.Remove(crmAsyncJob.AsyncOperationId.Value);

                    Console.WriteLine(String.Concat("Async operation state is ",
                        crmAsyncJob.StateCode.Value.ToString(), 
                        ", async operation id: ", crmAsyncJob.AsyncOperationId.Value.ToString()));
	            }

                // If there are still jobs remaining, sleep the thread.
                if (asyncJobList.Count > 0)
                    System.Threading.Thread.Sleep(2000);
                
                retryCount--;           
            }

            if (retryCount == 0 && asyncJobList.Count > 0)
            {
                for (int i = 0; i < asyncJobList.Count; i++)
                {
                    Console.WriteLine(String.Concat(
                        "The following async operation has not completed: ",
                        asyncJobList[i].ToString()));
                }
            }
        }

        #endregion

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

                var app = new EnableDuplicateDetectionAndRetrieveDuplicates();
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
        #endregion
    }
}

// </snippetenableduplicatedetectionandretrieveduplicates>