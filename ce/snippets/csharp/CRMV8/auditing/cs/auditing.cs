// <snippetauditing>


using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;

// These namespaces are found in the Microsoft.Crm.Sdk.Proxy.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    public class Auditing
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

        private Guid _newAccountId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the organization service. Next, auditing 
        /// is enabled on the organization and an account entity. The account record
        /// is updated and the audit history printed out.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri, serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                // Enable early-bound type support.
                _serviceProxy.EnableProxyTypes();

                // You can access the service through the proxy, but this sample uses the interface instead.
                _service = _serviceProxy;

                #region Enable Auditing for an Account
                Console.WriteLine("Enabling auditing on the organization and account entities.");

                // Enable auditing on the organization.
                // First, get the organization's ID from the system user record.
                Guid orgId = ((WhoAmIResponse)_service.Execute(new WhoAmIRequest())).OrganizationId;

                // Next, retrieve the organization's record.
                Organization org = _service.Retrieve(Organization.EntityLogicalName, orgId,
                    new ColumnSet(new string[] { "organizationid", "isauditenabled" })) as Organization;

                // Finally, enable auditing on the organization.
                bool organizationAuditingFlag = org.IsAuditEnabled.Value;
                org.IsAuditEnabled = true;
                _service.Update(org);

                // Enable auditing on account entities.
                bool accountAuditingFlag = EnableEntityAuditing(Account.EntityLogicalName, true);
                #endregion Enable Auditing for an Account

                CreateRequiredRecords();

                #region Retrieve the Record Change History
                Console.WriteLine("Retrieving the account change history.\n");
                // Retrieve the audit history for the account and display it.
                RetrieveRecordChangeHistoryRequest changeRequest = new RetrieveRecordChangeHistoryRequest();
                changeRequest.Target = new EntityReference(Account.EntityLogicalName, _newAccountId);

                RetrieveRecordChangeHistoryResponse changeResponse =
                    (RetrieveRecordChangeHistoryResponse)_service.Execute(changeRequest);

                AuditDetailCollection details = changeResponse.AuditDetailCollection;

                foreach (AttributeAuditDetail detail in details.AuditDetails)
                {
                    // Display some of the detail information in each audit record. 
                    DisplayAuditDetails(detail);
                }
                #endregion Retrieve the Record Change History

                #region Retrieve the Attribute Change History

                // Update the Telephone1 attribute in the Account entity record.
                Account accountToUpdate = new Account();
                accountToUpdate.AccountId = _newAccountId;
                accountToUpdate.Telephone1 = "123-555-5555";
                _serviceProxy.Update(accountToUpdate);
                Console.WriteLine("Updated the Telephone1 field in the Account entity.");

                // Retrieve the attribute change history.
                Console.WriteLine("Retrieving the attribute change history for Telephone1.");

                var attributeChangeHistoryRequest = new RetrieveAttributeChangeHistoryRequest
                {
                    Target = new EntityReference(
                        Account.EntityLogicalName, _newAccountId),
                    AttributeLogicalName = "telephone1"
                };

                var attributeChangeHistoryResponse =
                    (RetrieveAttributeChangeHistoryResponse)_service.Execute(attributeChangeHistoryRequest);

                // Display the attribute change history.
                details = attributeChangeHistoryResponse.AuditDetailCollection;

                foreach (var detail in details.AuditDetails)
                {
                    DisplayAuditDetails(detail);
                }

                // Save an Audit record ID for later use.
                Guid auditSampleId = details.AuditDetails.First().AuditRecord.Id;
                #endregion Retrieve the Attribute Change History

                #region Retrieve the Audit Details
                Console.WriteLine("Retrieving audit details for an audit record.");

                // Retrieve the audit details and display them.
                var auditDetailsRequest = new RetrieveAuditDetailsRequest
                {
                    AuditId = auditSampleId
                };

                var auditDetailsResponse =
                    (RetrieveAuditDetailsResponse)_service.Execute(auditDetailsRequest);
                DisplayAuditDetails(auditDetailsResponse.AuditDetail);

                #endregion Retrieve the Audit Details

                #region Revert Auditing
                // Set the organization and account auditing flags back to the old values
                org.IsAuditEnabled = organizationAuditingFlag;
                _service.Update(org);

                EnableEntityAuditing(Account.EntityLogicalName, accountAuditingFlag);

                #endregion Revert Auditing

                DeleteRequiredRecords(promptforDelete);
            }
        }

        #endregion How To Sample Code

        #region Class methods
        /// <summary>
        /// Displays audit change history details on the console.
        /// </summary>
        /// <param name="detail"></param>
        private static void DisplayAuditDetails(AuditDetail detail)
        {
            // Write out some of the change history information in the audit record. 
            Audit record = (Audit)detail.AuditRecord;

            Console.WriteLine("\nAudit record created on: {0}", record.CreatedOn.Value.ToLocalTime());
            Console.WriteLine("Entity: {0}, Action: {1}, Operation: {2}",
                record.ObjectId.LogicalName, record.FormattedValues["action"],
                record.FormattedValues["operation"]);

            // Show additional details for certain AuditDetail sub-types.
            var detailType = detail.GetType();
            if (detailType == typeof(AttributeAuditDetail))
            {
                var attributeDetail = (AttributeAuditDetail)detail;

                // Display the old and new attribute values.
                foreach (KeyValuePair<String, object> attribute in attributeDetail.NewValue.Attributes)
                {
                    String oldValue = "(no value)", newValue = "(no value)";

                    //TODO Display the lookup values of those attributes that do not contain strings.
                    if (attributeDetail.OldValue.Contains(attribute.Key))
                        oldValue = attributeDetail.OldValue[attribute.Key].ToString();

                    newValue = attributeDetail.NewValue[attribute.Key].ToString();

                    Console.WriteLine("Attribute: {0}, old value: {1}, new value: {2}",
                        attribute.Key, oldValue, newValue);
                }

                foreach (KeyValuePair<String, object> attribute in attributeDetail.OldValue.Attributes)
                {
                    if (!attributeDetail.NewValue.Contains(attribute.Key))
                    {
                        String newValue = "(no value)";

                        //TODO Display the lookup values of those attributes that do not contain strings.
                        String oldValue = attributeDetail.OldValue[attribute.Key].ToString();

                        Console.WriteLine("Attribute: {0}, old value: {1}, new value: {2}",
                            attribute.Key, oldValue, newValue);
                    }
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Enable auditing on an entity.
        /// </summary>
        /// <param name="entityLogicalName">The logical name of the entity.</param>
        /// <param name="flag">True to enable auditing, otherwise false.</param>
        /// <returns>The previous value of the IsAuditEnabled attribute.</returns>
        private bool EnableEntityAuditing(string entityLogicalName, bool flag)
        {
            // Retrieve the entity metadata.
            RetrieveEntityRequest entityRequest = new RetrieveEntityRequest
            {
                LogicalName = entityLogicalName,
                EntityFilters = EntityFilters.Attributes
            };

            RetrieveEntityResponse entityResponse =
                (RetrieveEntityResponse)_service.Execute(entityRequest);

            // Enable auditing on the entity. By default, this also enables auditing
            // on all the entity's attributes.
            EntityMetadata entityMetadata = entityResponse.EntityMetadata;

            bool oldValue = entityMetadata.IsAuditEnabled.Value;
            entityMetadata.IsAuditEnabled = new BooleanManagedProperty(flag);

            UpdateEntityRequest updateEntityRequest = new UpdateEntityRequest { Entity = entityMetadata };

            UpdateEntityResponse updateEntityResponse =
                (UpdateEntityResponse)_service.Execute(updateEntityRequest);

            return oldValue;
        }

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            Console.Write("Creating an account, ");

            // Account entity category codes.
            var Categories = new { PreferredCustomer = 1, Standard = 2 };

            // Create a new account entity. 
            Account newAccount = new Account { Name = "Example Account" };
            _newAccountId = _service.Create(newAccount);

            Console.WriteLine("then updating the account.");

            // Set the values of some other attributes.
            newAccount.AccountId = _newAccountId;
            newAccount.AccountNumber = "1-A";
            newAccount.AccountCategoryCode = new OptionSetValue(Categories.PreferredCustomer);
            newAccount.Telephone1 = "555-555-5555";

            _service.Update(newAccount);
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
                _service.Delete(Account.EntityLogicalName, _newAccountId);
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
                    (RetrieveAuditPartitionListResponse)_service.Execute(new RetrieveAuditPartitionListRequest());
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
                // partition with the oldest end date is at index 0.
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
                    _service.Execute(deleteRequest);
                    Console.WriteLine("Audit records have been deleted.");
                }
                else
                    Console.WriteLine("There were no audit records that could be deleted.");
            }
        }
        #endregion Class methods

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

                Auditing app = new Auditing();
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

// </snippetauditing>