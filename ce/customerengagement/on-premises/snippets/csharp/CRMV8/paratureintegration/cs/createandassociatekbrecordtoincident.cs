// <snippetcreateandassociatekbrecordtoincident>


using System;
using System.Linq;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to associate and disassociate a
    /// knowledge base record instance with an Incident record 
    /// in CRM.
    /// </summary>
    public class CreateandAssociateKBRecordtoIncident
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.        
        public Guid _accountId;
        public Guid _incidentId;
        public Guid _kbRecordId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Verify if knowledge management is enabled for the
        /// Incident entity.
        /// Create sample records (account and incident). 
        /// Create a knowledge base record.
        /// Associate the knowledge base record to entity record.
        /// Dissociate the knowledge base record from entity record.
        /// Optionally delete/revert any records 
        /// that were created/changed for this sample.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptForDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
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

                    if (CheckCRMVersion() == true)
                    {
                        // Check if knowledge management is enabled 
                        // for the Incident entity.
                        CheckKnowledgeManagementStatus();

                        // Create required records for the sample.
                        CreateRequiredRecords();

                        // Create a knowledge base record instance        
                        KnowledgeBaseRecord kbRecord = new KnowledgeBaseRecord
                        {
                            // These are sample values. Replace them with
                            // appropriate values as per your integrated 
                            // Parature  instance.
                            PrivateUrl = "https://www.demo.parature.com/internal",
                            PublicUrl = "https://www.demo.parature.com",
                            Title = "How to track shipping?",
                            UniqueId = "8000/8467/Article/23782"
                        };
                        _kbRecordId = _serviceProxy.Create(kbRecord);
                        Console.WriteLine("Created knowledge base record with ID: '{0}'.\n", _kbRecordId.ToString());

                        // Associate the knowledge base record with an incident record

                        // Step 1: Create a collection of knowledge base record that will be 
                        // associated to the incident. In this case, we have only a single
                        // knowledge base record to be associated.
                        EntityReferenceCollection relatedEntities = new EntityReferenceCollection();
                        relatedEntities.Add(new EntityReference(KnowledgeBaseRecord.EntityLogicalName, _kbRecordId));

                        // Step 2: Create an object that defines the relationship between knowledge base record and incident.
                        // Use the many-to-many relationship name (KnowledgeBaseRecord_Incident) between knowledge base
                        // record and incident.
                        Relationship relationship = new Relationship("KnowledgeBaseRecord_Incident");

                        // Step 3: Associate the knowledge base record with the incident record.
                        _serviceProxy.Associate(Incident.EntityLogicalName, _incidentId, relationship,
                            relatedEntities);

                        // Check to see if the association record is created in the 
                        // IncidentKnowledgeBaseRecord intersect entity
                        QueryExpression associationQuery = new QueryExpression
                        {
                            EntityName = IncidentKnowledgeBaseRecord.EntityLogicalName,
                            ColumnSet = new ColumnSet("incidentid", "knowledgebaserecordid"),
                            Criteria = new FilterExpression
                            {
                                Conditions = 
                                {
                                    new ConditionExpression 
                                    {
                                        AttributeName = "incidentid",
                                        Operator = ConditionOperator.Equal,
                                        Values = { _incidentId }
                                    },
                                    new ConditionExpression
                                    {
                                        AttributeName = "knowledgebaserecordid",
                                        Operator = ConditionOperator.Equal,
                                        Values = { _kbRecordId }
                                    }
                                }
                            },
                            PageInfo = new PagingInfo
                            {
                                PageNumber = 1,
                                Count = 1
                            }
                        };

                        DataCollection<Entity> entityCollection = _serviceProxy.RetrieveMultiple(associationQuery).Entities;
                        if (entityCollection.Count() > 0)
                        {
                            Console.WriteLine("Associated knowledge base record with the incident record.");

                            // Disassociate the records.
                            _serviceProxy.Disassociate(Incident.EntityLogicalName, _incidentId, relationship,
                                relatedEntities);
                            Console.WriteLine("Disasociated knowledge base record from the incident record.\n");
                        }
                        else
                        {
                            Console.WriteLine("Could not associate knowledge base record with the incident record.\n");
                        }

                        // Prompt the user to delete the records and attribute created by the sample.
                        DeleteRequiredRecords(promptForDelete);
                    }
                    else
                    {
                        Console.WriteLine("Aborting the sample.");
                    }
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
        /// Checks if you are running the correct version of CRM.
        /// This sample requires that the CRM version be 7.1.0.xxxx or later. 
        /// </summary>
        private bool CheckCRMVersion()
        {

            RetrieveVersionRequest crmVersionReq = new RetrieveVersionRequest();
            RetrieveVersionResponse crmVersionResp = (RetrieveVersionResponse)_serviceProxy.Execute(crmVersionReq);

            if (String.CompareOrdinal("7.1.0.0", crmVersionResp.Version) < 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("This sample cannot be run against the current version of CRM.");
                Console.WriteLine("Upgrade your CRM instance to the latest version to run this sample.");
                return false;
            }
        }

        /// <summary>
        /// Checks if knowledge management is enabled for the Incident entity.  
        /// </summary>
        private void CheckKnowledgeManagementStatus()
        {
            RetrieveEntityRequest entityRequest = new RetrieveEntityRequest
            {
                EntityFilters = EntityFilters.All,
                LogicalName = Incident.EntityLogicalName,

                // Retrieve only the currently published changes, ignoring the changes 
                // that have not been published.
                RetrieveAsIfPublished = false
            };
            RetrieveEntityResponse entityResponse = (RetrieveEntityResponse)_serviceProxy.Execute(entityRequest);

            if (entityResponse.EntityMetadata.IsKnowledgeManagementEnabled == true)
            {
                Console.WriteLine("Verified that knowledge management is enabled for Incident entity.\n");
                return;
            }
            else
            {
                // Enable knolwledge management for the Incident entity.
                Console.WriteLine("Knowledge management is not enabled for the Incident entity.");
                entityResponse.EntityMetadata.IsKnowledgeManagementEnabled = true;

                // Create an update request.                    
                UpdateEntityRequest updateRequest = new UpdateEntityRequest
                {
                    Entity = entityResponse.EntityMetadata
                };
                _serviceProxy.Execute(updateRequest);

                // Publish the entity.
                // All customizations must be published before they can be used.
                PublishAllXmlRequest enableRequest = new PublishAllXmlRequest();
                _serviceProxy.Execute(enableRequest);
                Console.WriteLine("Enabled Knowledge management for the Incident entity.");
            }
        }

        /// <summary>
        /// Creates required records for this sample. 
        /// </summary>
        private void CreateRequiredRecords()
        {
            // Create an account to act as a customer for the incident.
            Account account = new Account
            {
                Name = "Sample Account 1",
                Address1_StateOrProvince = "Colorado"
            };
            _accountId = (_serviceProxy.Create(account));
            Console.WriteLine("Created account: '{0}'.", account.Name);

            // Create an incident.
            Incident incident = new Incident
            {
                CustomerId = new EntityReference(Account.EntityLogicalName, _accountId),
                Title = "Sample Incident 1"
            };
            _incidentId = _serviceProxy.Create(incident);
            Console.WriteLine("Created incident: '{0}'.\n", incident.Title);            
        }

        /// <summary>
        /// Deletes the record that was created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete 
        /// the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records to be deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                // Delete all records created for this sample.
                _serviceProxy.Delete(KnowledgeBaseRecord.EntityLogicalName, _kbRecordId);
                _serviceProxy.Delete(Incident.EntityLogicalName, _incidentId);
                _serviceProxy.Delete(Account.EntityLogicalName, _accountId);
                Console.WriteLine("Deleted all records created for this sample.");
            }
        }
        #endregion

        #region Main
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

                CreateandAssociateKBRecordtoIncident app = new CreateandAssociateKBRecordtoIncident();
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

// </snippetcreateandassociatekbrecordtoincident>