// <snippetauditreport>


using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

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
    public class AuditReport
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

        private Guid _newAccountId;
        private List<Guid> _auditExtensionRecordIds = new List<Guid>();
        private static DateTime _sampleStartTime;

        private static XmlTextWriter textWriter;

        #endregion Class Level Members

        /// <summary>
        /// This method first connects to the organization service. Afterwards,
        /// auditing is enabled on the organization, account entity, and a couple
        /// of attributes. Finally, display that information in Console, and creates
        /// an XML file.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            _sampleStartTime = DateTime.Now;
            using (_serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig))
            {
                // This statement is required to enable early-bound type support.
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
                bool usersAccessAuditingFlag = org.IsUserAccessAuditEnabled.HasValue ? 
                    org.IsUserAccessAuditEnabled.Value : false;

                org.IsAuditEnabled = true;
                org.IsUserAccessAuditEnabled = true;
                _service.Update(org);

                // Enable auditing on account entities.
                bool accountAuditingFlag = EnableEntityAuditing(Account.EntityLogicalName, true);

                #endregion Enable Auditing for an Account

                CreateRequiredRecords();

                #region Create and start XML file

                // Create the XML file
                String fileName ="auditReport.xml";
                textWriter = new XmlTextWriter(fileName, null);
                textWriter.WriteStartDocument();

                // Start Audit Node
                textWriter.WriteStartElement("auditReport", "");

                #endregion

                #region Retrieve user access audit records

                var query = new QueryExpression(Audit.EntityLogicalName)
                {
                    ColumnSet = new ColumnSet("createdon", "action", "operation", "objectid"),
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
                    // Only retrieve audit records for the current user.
                    var userFilter = new FilterExpression(LogicalOperator.Or);
                    userFilter.AddCondition(
                        "userid", ConditionOperator.Equal, _serviceProxy.CallerId);
                }
                // Only retrieve records for this sample run, so that we don't get too
                // many results if auditing was enabled previously.
                query.Criteria.AddCondition(
                    "createdon", ConditionOperator.GreaterEqual, _sampleStartTime);

                var results = _serviceProxy.RetrieveMultiple(query);
                foreach (Audit audit in results.Entities)
                {
                    // Display results
                    DisplayAndAddToXMLFileUserAccessDetails(audit);
                }

                #endregion

                #region Retrieve the Audit History
                Console.WriteLine("Retrieving the account change history.\n");

                DateTime startTime = DateTime.Now;

                // Retrieve the audit records for accounts.
                RetrieveRecordChangeHistoryRequest changeRequest = new RetrieveRecordChangeHistoryRequest();
                changeRequest.Target = new EntityReference(Account.EntityLogicalName, _newAccountId);

                RetrieveRecordChangeHistoryResponse changeResponse =
                    (RetrieveRecordChangeHistoryResponse)_service.Execute(changeRequest);

                AuditDetailCollection details = changeResponse.AuditDetailCollection;

                foreach (AttributeAuditDetail detail in details.AuditDetails)
                {
                    // Write out some of the information in each audit record. 
                    DisplayAndAddToXMLFileAuditDetails(detail);
                }
                #endregion Retrieve the Audit History

                #region RetrieveAttributeChangeHistoryRequest
                // How to use message: RetrieveAttributeChangeHistoryRequest

                // Update Telephone1 in account entity
                Account accountToUpdate = new Account();
                accountToUpdate.AccountId = _newAccountId;
                accountToUpdate.Telephone1 = "123-555-5555";
                _serviceProxy.Update(accountToUpdate);
                Console.WriteLine("Updated Telephone1 field in Account entity.");

                Console.WriteLine("Retrieving attribute change history for Telephone1.");
                // Create RetrieveAttributeChangeHistoryRequest
                var attributeChangeHistoryRequest = new RetrieveAttributeChangeHistoryRequest
                {
                    Target = new EntityReference(
                        Account.EntityLogicalName, _newAccountId),
                    AttributeLogicalName = "telephone1"
                };

                // Execute RetrieveAttributeChangeHistoryRequest
                var attributeChangeHistoryResponse =
                    (RetrieveAttributeChangeHistoryResponse)_service.Execute(attributeChangeHistoryRequest);

                // Set AuditDetailCollection and output to console
                details = attributeChangeHistoryResponse.AuditDetailCollection;

                foreach (var detail in details.AuditDetails)
                {
                    DisplayAndAddToXMLFileAuditDetails(detail);
                }

                // Create an Audit record
                // to store a sample for use with RetrieveAuditDetailsRequest
                Guid auditSampleId = details.AuditDetails.First().AuditRecord.Id;
                #endregion RetrieveAttributeChangeHistoryRequest

                #region RetrieveAuditDetailsRequest
                // How to use message: RetrieveAuditDetailsRequest

                Console.WriteLine("Retrieving audit details for an audit record.");
                // Create RetrieveAuditDetailsRequest
                var auditDetailsRequest = new RetrieveAuditDetailsRequest
                {
                    AuditId = auditSampleId
                };

                // Execute RetrieveAuditDetailsRequest
                var auditDetailsResponse =
                    (RetrieveAuditDetailsResponse)_service.Execute(auditDetailsRequest);

                // Display results
                DisplayAndAddToXMLFileAuditDetails(auditDetailsResponse.AuditDetail);
                
                #endregion RetrieveAuditDetailsRequest

                #region Retrieve AuditExtension details

                Console.WriteLine("Simulating a user reading records");
                _service.Retrieve(Account.EntityLogicalName, _newAccountId, new ColumnSet("accountid"));

                // creating read records is an async process - wait until the records have been created
                // wait a max of 30 seconds
                Console.WriteLine("Fetching read audit records for accounts");
                for (int i = 0; i < 30; i++)
                {
                    query = new QueryExpression
                    {
                        EntityName = "sample_auditextension",
                        ColumnSet = new ColumnSet("createdon", "sample_objectlogicalname", 
                            "sample_objectid", "sample_userid", "sample_action", "sample_operation"),
                        Criteria = new FilterExpression
                        {
                            Conditions =
                            {
                                new ConditionExpression("sample_objectlogicalname", ConditionOperator.Equal, Account.EntityLogicalName),
                                new ConditionExpression("sample_objectid", ConditionOperator.Equal, 
                                    _newAccountId.ToString().TrimStart('{').TrimEnd('}'))
                            }
                        }
                    };
                    results = _service.RetrieveMultiple(query);
                    if (results.Entities.Count > 0)
                        break;
                    else if (i == 29)
                        throw new Exception("Exceeded maximum wait time");
                    System.Threading.Thread.Sleep(1000);
                }

                foreach (var record in results.Entities)
                {
                    _auditExtensionRecordIds.Add(record.Id);
                    DisplayAndAddToXmlFileAuditExtension(record);
                }

                #endregion

                #region Finish and close XML file

                // End auditReport Xml Node
                textWriter.WriteEndElement();
                textWriter.WriteEndDocument();

                // Close xml writer.
                textWriter.Close();

                Console.WriteLine("File name: " + fileName);

                #endregion

                #region Revert auditing
                // Set the organization and account auditing flags back to the old values
                org.IsAuditEnabled = organizationAuditingFlag;
                org.IsUserAccessAuditEnabled = usersAccessAuditingFlag;
                _service.Update(org);

                EnableEntityAuditing(Account.EntityLogicalName, accountAuditingFlag);

                #endregion Revert auditing

                DeleteRequiredRecords(promptforDelete);
            }
        }

        private void DisplayAndAddToXmlFileAuditExtension(Entity record)
        {
            Console.WriteLine("\nAudit record created on: {0}", 
                ((DateTime)record["createdon"]).ToLocalTime());

            var user = _serviceProxy.Retrieve(SystemUser.EntityLogicalName,
                ((EntityReference)record["sample_userid"]).Id, new ColumnSet("fullname"));
            var account = _service.Retrieve(Account.EntityLogicalName, _newAccountId, 
                new ColumnSet("name"));

            Console.WriteLine("Entity: {0}, Name: {1}, Action: Read, Operation: Retrieve, User: {2}", 
                record["sample_objectlogicalname"], account["name"], user["fullname"]);

            #region Add Audit information to XML file

            // Start Audit XML Node
            textWriter.WriteStartElement("audit", "");

            // Start createdOn XML Node
            textWriter.WriteStartElement("createdOn", "");
            // Write createdOn's Information
            textWriter.WriteString(((DateTime)record["createdon"]).ToLocalTime().ToString());
            // End createdOn Node
            textWriter.WriteEndElement();

            // Add entity XML Node
            textWriter.WriteStartElement("entity", "");
            textWriter.WriteString("audit_extension");
            textWriter.WriteEndElement();

            // add attributes and attribute tag to ensure the schema is the same
            textWriter.WriteStartElement("attributes", "");
            textWriter.WriteStartElement("attribute", "");
            // Add name XML Node
            textWriter.WriteStartElement("name", "");
            textWriter.WriteString(account["name"].ToString());
            textWriter.WriteEndElement();

            // Add userName XML Node
            textWriter.WriteStartElement("userName", "");
            textWriter.WriteString(user["fullname"].ToString());
            textWriter.WriteEndElement();

            textWriter.WriteEndElement();
            textWriter.WriteEndElement();

            // Add action XML Node
            textWriter.WriteStartElement("action", "");
            textWriter.WriteString("Read");
            textWriter.WriteEndElement();

            // Add operation XML Node
            textWriter.WriteStartElement("operation", "");
            textWriter.WriteString("Retrieve");
            textWriter.WriteEndElement();

            textWriter.WriteEndElement();

            #endregion
        }

        private static void DisplayAndAddToXMLFileAudit(Audit record, bool writeEndElem = true)
        {
            Console.WriteLine("\nAudit record created on: {0}", record.CreatedOn.Value.ToLocalTime());
            Console.WriteLine("Entity: {0}, Action: {1}, Operation: {2}", 
                record.LogicalName, record.FormattedValues["action"], record.FormattedValues["operation"]);

            // Start Audit XML Node
            textWriter.WriteStartElement("audit", "");

            #region Add Audit information to XML file

            // Start createdOn XML Node
            textWriter.WriteStartElement("createdOn", "");
            // Write createdOn's Information
            textWriter.WriteString(record.CreatedOn.Value.ToLocalTime().ToString());
            // End createdOn Node
            textWriter.WriteEndElement();

            // Add entity XML Node
            textWriter.WriteStartElement("entity", "");
            textWriter.WriteString(record.LogicalName);
            textWriter.WriteEndElement();

            // Add action XML Node
            textWriter.WriteStartElement("action", "");
            textWriter.WriteString(record.FormattedValues["action"]);
            textWriter.WriteEndElement();

            // Add operation XML Node
            textWriter.WriteStartElement("operation", "");
            textWriter.WriteString(record.FormattedValues["operation"]);
            textWriter.WriteEndElement();

            #endregion

            if (writeEndElem)
                textWriter.WriteEndElement();
        }

        private void DisplayAndAddToXMLFileUserAccessDetails(Audit audit)
        {
            Console.WriteLine("\nAudit record created on: {0}", audit.CreatedOn.Value.ToLocalTime());
            Console.WriteLine("Entity: {0}, Action: {1}, Operation: {2}, User: {3}",
                audit.LogicalName, audit.FormattedValues["action"], audit.FormattedValues["operation"],
                audit.ObjectId.Name);

            DisplayAndAddToXMLFileAudit(audit, false);

            #region add extra info to XML file
            textWriter.WriteStartElement("attributes", "");
            textWriter.WriteStartElement("attribute", "");

            textWriter.WriteStartElement("userName", "");
            textWriter.WriteString(audit.ObjectId.Name);
            textWriter.WriteEndElement();

            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            #endregion

            // End audit XML Node
            textWriter.WriteEndElement();
        }

        private void DisplayAndAddToXMLFileAuditDetails(AuditDetail detail)
        {
            // Write out some of the information in each audit record. 
            // and add this information to the XML file
            Audit record = (Audit)detail.AuditRecord;
            DisplayAndAddToXMLFileAudit(record, false);

            var detailType = detail.GetType();
            if (detailType == typeof(AttributeAuditDetail))
            {
                var attributeDetail = (AttributeAuditDetail)detail;

                // Start attributes XML Node
                textWriter.WriteStartElement("attributes", "");

                // Display the old and new attribute values.
                foreach (KeyValuePair<String, object> attribute in attributeDetail.NewValue.Attributes)
                {
                    String oldValue = "(no value)", newValue = "(no value)", userName = "(no value)";

                    if (attributeDetail.OldValue.Contains(attribute.Key))
                        oldValue = attributeDetail.OldValue[attribute.Key].ToString();

                    if (attributeDetail.AuditRecord.Attributes.Contains("userid"))
                        userName = ((EntityReference)attributeDetail.AuditRecord.Attributes["userid"]).Name;

                    newValue = attributeDetail.NewValue.FormattedValues.Contains(attribute.Key) ? 
                        attributeDetail.NewValue.FormattedValues[attribute.Key].ToString() : 
                        attributeDetail.NewValue[attribute.Key].ToString();

                    if (oldValue == "Microsoft.Xrm.Sdk.EntityReference")
                    {
                        EntityReference temp = (EntityReference)attributeDetail.NewValue[attribute.Key];
                        oldValue = temp.Name;
                    }

                    if (newValue == "Microsoft.Xrm.Sdk.EntityReference")
                    {
                        EntityReference temp = (EntityReference)attributeDetail.NewValue[attribute.Key];
                        newValue = temp.Name;
                    }

                    Console.WriteLine("Attribute: {0}, old value: {1}, new value: {2}",
                        attribute.Key, oldValue, newValue);

                    #region Add Audit details for New Values to XML file

                    // Start attribute XML Node
                    textWriter.WriteStartElement("attribute", "");

                    // Add name XML Node
                    textWriter.WriteStartElement("name", "");
                    textWriter.WriteString(attribute.Key);
                    textWriter.WriteEndElement();

                    // Add oldValue XML Node
                    textWriter.WriteStartElement("oldValue", "");
                    textWriter.WriteString(oldValue);
                    textWriter.WriteEndElement();

                    // Add newValue XML Node
                    textWriter.WriteStartElement("newValue", "");
                    textWriter.WriteString(newValue);
                    textWriter.WriteEndElement();

                    // Add userName XML Node
                    textWriter.WriteStartElement("userName", "");
                    textWriter.WriteString(userName);
                    textWriter.WriteEndElement();

                    // End attribute XML Node
                    textWriter.WriteEndElement();

                    #endregion
                    
                }

                foreach (KeyValuePair<String, object> attribute in attributeDetail.OldValue.Attributes)
                {
                    if (!attributeDetail.NewValue.Contains(attribute.Key))
                    {
                        String newValue = "(no value)", userName = "(no value)";

                        String oldValue = attributeDetail.OldValue.FormattedValues.Contains(attribute.Key) ?
                        attributeDetail.OldValue.FormattedValues[attribute.Key].ToString() :
                        attributeDetail.OldValue[attribute.Key].ToString();

                        if (oldValue == "Microsoft.Xrm.Sdk.EntityReference")
                        {
                            EntityReference temp = (EntityReference)attributeDetail.OldValue[attribute.Key];
                            oldValue = temp.Name;
                        }

                        if (attributeDetail.AuditRecord.Attributes.Contains("userid"))
                            userName = ((EntityReference)attributeDetail.AuditRecord.Attributes["userid"]).Name;

                        Console.WriteLine("Attribute: {0}, old value: {1}, new value: {2}",
                            attribute.Key, oldValue, newValue);

                        #region Add Audit details for Old Values to XML file

                        // Start attribute XML Node
                        textWriter.WriteStartElement("attribute", "");

                        // Add name XML Node
                        textWriter.WriteStartElement("name", "");
                        textWriter.WriteString(attribute.Key);
                        textWriter.WriteEndElement();

                        // Add oldValue XML Node
                        textWriter.WriteStartElement("oldValue", "");
                        textWriter.WriteString(oldValue);
                        textWriter.WriteEndElement();

                        // Add newValue XML Node
                        textWriter.WriteStartElement("newValue", "");
                        textWriter.WriteString(newValue);
                        textWriter.WriteEndElement();

                        // Add userName XML Node
                        textWriter.WriteStartElement("userName", "");
                        textWriter.WriteString(userName);
                        textWriter.WriteEndElement();

                        // End attribute XML Node
                        textWriter.WriteEndElement();

                        #endregion
                        
                    }
                }

                // End attributes XML Node
                textWriter.WriteEndElement();
            }
            Console.WriteLine();

            // End audit XML Node
            textWriter.WriteEndElement();
        }

        #region Class methods
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
                // Delete the audit extension records
                foreach (var id in _auditExtensionRecordIds)
                    _serviceProxy.Delete("sample_auditextension", id);

                Console.WriteLine("Audit extension records have been deleted");

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

                AuditReport app = new AuditReport();
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

// </snippetauditreport>