// <snippetuseraccessauditing>


using System;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    public class UserAccessAuditing
    {
        #region Class Level Members
        private OrganizationServiceProxy _serviceProxy;

        private Guid _newAccountId;
        private Guid _systemUserId;
        private static DateTime _sampleStartTime;

        #endregion

        #region How To Sample Code

        /// <summary>
        /// This sample demonstrates how to audit user access to Microsoft Dynamics CRM.
        /// The sample first enables user access auditing on an organization. Next, it
        /// creates and modifies an entity. Finally, the sample displays a report of the
        /// audited information.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            _sampleStartTime = DateTime.Now;
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                // This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes();

                #region Enable Auditing

                // Enable auditing on the organization and for user access by editing the
                // organization's settings.
                // First, get the organization's ID from the system user record.
                var whoAmIReq = new WhoAmIRequest();
                var whoAmIRes = (WhoAmIResponse)_serviceProxy.Execute(whoAmIReq);
                Guid orgId = whoAmIRes.OrganizationId;
                _systemUserId = whoAmIRes.UserId;

                // Next, retrieve the organization's record.
                var org = (Organization)_serviceProxy.Retrieve(
                    Organization.EntityLogicalName, orgId,
                    new ColumnSet("organizationid", "isauditenabled", "isuseraccessauditenabled", "useraccessauditinginterval"));

                // Finally, enable auditing on the organization, including auditing for
                // user access.
                bool organizationAuditingFlag = org.IsAuditEnabled.Value;
                bool userAccessAuditingFlag = org.IsUserAccessAuditEnabled.Value;
                if (!organizationAuditingFlag || !userAccessAuditingFlag)
                {
                    org.IsAuditEnabled = true;
                    org.IsUserAccessAuditEnabled = true;
                    _serviceProxy.Update(org);
                    Console.WriteLine("Enabled auditing for the organization and for user access.");
                    Console.WriteLine("Auditing interval is set to {0} hours.", org.UserAccessAuditingInterval);
                }
                else
                {
                    Console.WriteLine("Auditing was enabled before the sample began, so no auditing settings were changed.");
                }

                // Enable auditing on the account entity, since no audits will be created
                // when we create/update an account entity, otherwise.
                var oldAccountAuditing = EnableEntityAuditing(Account.EntityLogicalName, true);

                #endregion Enable Auditing

                #region Make Audited Service Calls

                CreateRequiredRecords();

                // Make an update request to the Account entity to be tracked by auditing.
                var newAccount = new Account();
                newAccount.AccountId = _newAccountId;
                newAccount.AccountNumber = "1-A";
                newAccount.AccountCategoryCode = new OptionSetValue(
                    (int)AccountAccountCategoryCode.PreferredCustomer);
                newAccount.Telephone1 = "555-555-5555";

                _serviceProxy.Update(newAccount);

                Console.WriteLine("Created an account and made updates which should be captured by auditing.");

                #endregion Make Audited Service Calls

                #region Revert auditing

                // Set the organization and account auditing flags back to the old values
                if (!organizationAuditingFlag || !userAccessAuditingFlag)
                {
                    // Only revert them if they were actually changed to begin with.
                    org.IsAuditEnabled = organizationAuditingFlag;
                    org.IsUserAccessAuditEnabled = userAccessAuditingFlag;
                    _serviceProxy.Update(org);
                    Console.WriteLine("Reverted organization and user access auditing to their previous values.");
                }
                else
                {
                    Console.WriteLine("Auditing was enabled before the sample began, so no auditing settings were reverted.");
                }

                // Revert the account entity auditing.
                EnableEntityAuditing(Account.EntityLogicalName, oldAccountAuditing);

                #endregion Revert auditing

                #region Show Audited Records

                // Select all columns for convenience.
                var query = new QueryExpression(Audit.EntityLogicalName)
                {
                    ColumnSet = new ColumnSet(true),
                    Criteria = new FilterExpression(LogicalOperator.And)
                };

                // Only retrieve audit records that track user access.
                query.Criteria.AddCondition("action", ConditionOperator.In,
                    (int)AuditAction.UserAccessAuditStarted,
                    (int)AuditAction.UserAccessAuditStopped,
                    (int)AuditAction.UserAccessviaWebServices,
                    (int)AuditAction.UserAccessviaWeb);

                // Change this to false in order to retrieve audit records for all users
                // when running the sample.
                var filterAuditsRetrievedByUser = true;
                if (filterAuditsRetrievedByUser)
                {
                    // Only retrieve audit records for the current user or the "SYSTEM"
                    // user.
                    var userFilter = new FilterExpression(LogicalOperator.Or);
                    userFilter.AddCondition(
                        "userid", ConditionOperator.Equal, _systemUserId);
                    userFilter.AddCondition(
                        "useridname", ConditionOperator.Equal, "SYSTEM");
                }
                // Only retrieve records for this sample run, so that we don't get too
                // many results if auditing was enabled previously.
                query.Criteria.AddCondition(
                    "createdon", ConditionOperator.GreaterEqual, _sampleStartTime);

                var results = _serviceProxy.RetrieveMultiple(query);
                Console.WriteLine("Retrieved audit records:");
                foreach (Audit audit in results.Entities)
                {
                    Console.Write("\r\n  Action: {0},  User: {1},"
                        + "\r\n    Created On: {2}, Operation: {3}",
                        (AuditAction)audit.Action.Value,
                        audit.UserId.Name,
                        audit.CreatedOn.Value.ToLocalTime(),
                        (AuditOperation)audit.Operation.Value);

                    // Display the name of the related object (which will be the user
                    // for audit records with Action UserAccessviaWebServices.
                    if (!String.IsNullOrEmpty(audit.ObjectId.Name))
                    {
                        Console.WriteLine(
                            ",\r\n    Related Record: {0}", audit.ObjectId.Name);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }

                #endregion Show Audited Records

                DeleteRequiredRecords(promptforDelete);
            }
        }

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Create a new account entity. 
            Account newAccount = new Account { Name = "Example Account" };
            _newAccountId = _serviceProxy.Create(newAccount);
        }

        private bool EnableEntityAuditing(String entityLogicalName, bool flag)
        {
            // Retrieve the entity metadata.
            RetrieveEntityRequest entityRequest = new RetrieveEntityRequest
            {
                LogicalName = entityLogicalName,
                EntityFilters = EntityFilters.Attributes
            };

            RetrieveEntityResponse entityResponse =
                (RetrieveEntityResponse)_serviceProxy.Execute(entityRequest);

            // Enable auditing on the entity. By default, this also enables auditing
            // on all the entity's attributes.
            EntityMetadata entityMetadata = entityResponse.EntityMetadata;

            bool oldValue = entityMetadata.IsAuditEnabled.Value;
            entityMetadata.IsAuditEnabled = new BooleanManagedProperty(flag);

            UpdateEntityRequest updateEntityRequest = new UpdateEntityRequest { Entity = entityMetadata };

            UpdateEntityResponse updateEntityResponse =
                (UpdateEntityResponse)_serviceProxy.Execute(updateEntityRequest);

            return oldValue;
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
                Console.WriteLine("\nDo you want to delete the account record? (y/n) [y]: ");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
            }

            if (deleteRecords)
            {
                _serviceProxy.Delete(Account.EntityLogicalName, _newAccountId);
                Console.WriteLine("The account record has been deleted.");
            }

            if (prompt)
            {
                Console.WriteLine("\nDo you want to delete ALL audit records? (y/n) [n]: ");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                // Get the list of audit partitions.
                RetrieveAuditPartitionListResponse partitionRequest =
                    (RetrieveAuditPartitionListResponse)_serviceProxy.Execute(new RetrieveAuditPartitionListRequest());
                AuditPartitionDetailCollection partitions = partitionRequest.AuditPartitionDetailCollection;

                // Create a delete request with an end date earlier than possible.
                DeleteAuditDataRequest deleteRequest = new DeleteAuditDataRequest();
                deleteRequest.EndDate = new DateTime(2000, 1, 1);

                // Check if partitions are not supported as is the case with SQL Server Standard edition.
                if (partitions.IsLogicalCollection)
                {
                    // Delete all audit records created up until now.
                    deleteRequest.EndDate = DateTime.Now;
                }

                // Otherwise, delete all partitions that are older than the current partition.
                // Hint: The partitions in the collection are returned in sorted order where the 
                // partition with the oldest end date is at index 0.  Also, if the partition's
                // end date is greater than the current date, neither the partition nor any
                // audit records contained in the partition can be deleted.
                else
                {
                    for (int n = partitions.Count - 1; n >= 0; --n)
                    {
                        if (partitions[n].EndDate <= DateTime.Now && partitions[n].EndDate > deleteRequest.EndDate)
                        {
                            deleteRequest.EndDate = (DateTime)partitions[n].EndDate;
                            break;
                        }
                    }
                }

                // Delete the audit records.
                if (deleteRequest.EndDate != new DateTime(2000, 1, 1))
                {
                    _serviceProxy.Execute(deleteRequest);
                    Console.WriteLine("Audit records have been deleted.");
                }
                else
                    Console.WriteLine("There were no audit records that could be deleted.");
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

                var app = new UserAccessAuditing();
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

// </snippetuseraccessauditing>