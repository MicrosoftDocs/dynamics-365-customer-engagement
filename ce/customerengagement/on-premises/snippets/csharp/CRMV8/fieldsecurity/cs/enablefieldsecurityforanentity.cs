// <snippetenablefieldsecurityforanentity>


using System;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;


namespace Microsoft.Crm.Sdk.Samples

{
    /// <summary>
    /// Demonstrates how to create enable field security for an entity.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class EnableFieldSecurityForAnEntity
    {

        #region Class Level Members

        private Guid _teamId;
        private Guid _profileId;
        private Guid _identityId;
        private Guid _messageId;
        private Guid _identityPermissionId;
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How-To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// a FieldSecurityProfile object is created and tied to an existing team. Then a
        /// custom entity and several attributes are created and FieldPermission is 
        /// assigned to the Identity attribute of the new entity.
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
                    
                    CreateRequiredRecords();

                    // Create Field Security Profile.
                    FieldSecurityProfile managersProfile = new FieldSecurityProfile();
                    managersProfile.Name = "Managers";
                    _profileId = _serviceProxy.Create(managersProfile);
                    Console.Write("Created Profile, ");

                    // Create the request object and set the monikers with the
                    // teamprofiles_association relationship.
                    AssociateRequest teamToProfile = new AssociateRequest
                    {
                        Target = new EntityReference(FieldSecurityProfile.EntityLogicalName, _profileId),
                        RelatedEntities = new EntityReferenceCollection
                        {
                            new EntityReference(Team.EntityLogicalName, _teamId)
                        },
                        Relationship = new Relationship("teamprofiles_association")
                    };

                    // Execute the request.
                    _serviceProxy.Execute(teamToProfile);

                    // Create custom activity entity.
                    CreateEntityRequest req = new CreateEntityRequest()
                    {
                        Entity = new EntityMetadata
                        {
                            LogicalName = "new_tweet",
                            DisplayName = new Label("Tweet", 1033),
                            DisplayCollectionName = new Label("Tweet", 1033),
                            OwnershipType = OwnershipTypes.UserOwned,
                            SchemaName = "New_Tweet",
                            IsActivity = true,
                            IsAvailableOffline = true,
                            IsAuditEnabled = new BooleanManagedProperty(true),
                            IsMailMergeEnabled = new BooleanManagedProperty(false)
                        },
                        HasActivities = false,
                        HasNotes = true,
                        PrimaryAttribute = new StringAttributeMetadata()
                        {
                            SchemaName = "Subject",
                            LogicalName = "subject",
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                            MaxLength = 100,
                            DisplayName = new Label("Subject", 1033)
                        }
                    };

                    // Execute the request.
                    _serviceProxy.Execute(req);
                    Console.Write("Entity Created, ");

                    // Create custom attributes.
                    CreateAttributeRequest attrReq = new CreateAttributeRequest()
                    {
                        Attribute = new StringAttributeMetadata()
                        {
                            LogicalName = "new_identity",
                            DisplayName = new Label("Identity", 1033),
                            SchemaName = "New_Identity",
                            MaxLength = 500,
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
                            IsSecured = true
                        },
                        EntityName = "new_tweet"
                    };

                    // Execute the request.
                    CreateAttributeResponse identityAttributeResponse = (CreateAttributeResponse)_serviceProxy.Execute(attrReq);
                    _identityId = identityAttributeResponse.AttributeId;
                    Console.Write("Identity Created, ");

                    attrReq = new CreateAttributeRequest()
                    {
                        Attribute = new StringAttributeMetadata()
                        {
                            LogicalName = "new_message",
                            DisplayName = new Label("Message", 1033),
                            SchemaName = "New_Message",
                            MaxLength = 140,
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
                            IsSecured = true
                        },
                        EntityName = "new_tweet"
                    };

                    // Execute the request.
                    CreateAttributeResponse messageAttributeResponse = (CreateAttributeResponse)_serviceProxy.Execute(attrReq);
                    _messageId = messageAttributeResponse.AttributeId;
                    Console.Write("Message Created, ");

                    // Create the field permission for the Identity attribute.
                    FieldPermission identityPermission = new FieldPermission()
                    {
                        AttributeLogicalName = "new_identity",
                        EntityName = "new_tweet",
                        CanRead = new OptionSetValue(FieldPermissionType.Allowed),
                        FieldSecurityProfileId = new EntityReference(FieldSecurityProfile.EntityLogicalName, _profileId)
                    };

                    // Execute the request
                    _identityPermissionId = _serviceProxy.Create(identityPermission);
                    Console.Write("Permission Created. ");

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
            // Retrieve the default business unit needed to create the team.
            QueryExpression queryDefaultBusinessUnit = new QueryExpression
            {
                EntityName = BusinessUnit.EntityLogicalName,
                ColumnSet = new ColumnSet("businessunitid"),
                Criteria =
                {
                    Conditions =
                    {
                        new ConditionExpression("parentbusinessunitid", 
                            ConditionOperator.Null)
                    }
                }
            };

            BusinessUnit defaultBusinessUnit = (BusinessUnit)_serviceProxy.RetrieveMultiple(
                queryDefaultBusinessUnit).Entities[0];

            // Instantiate a team entity record and set its property values.
            // See the Entity Metadata topic in the SDK documentation to determine
            // which attributes must be set for each entity.
            Team setupTeam = new Team
            {
                Name = "ABC Management Team",
                BusinessUnitId = new EntityReference(BusinessUnit.EntityLogicalName,
                    defaultBusinessUnit.Id)
            };
            
            //Create a team record.
            _teamId = _serviceProxy.Create(setupTeam);
            Console.Write("Created Team, ");
        }

        /// <summary>
        /// Deletes any entity records and files that were created for this sample.
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

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
            }

            if (deleteRecords)
            {
                _serviceProxy.Delete(FieldSecurityProfile.EntityLogicalName, _profileId);
                _serviceProxy.Delete(Team.EntityLogicalName, _teamId);
                DeleteEntityRequest del = new DeleteEntityRequest()
                {
                    LogicalName = "new_tweet",
                };
                _serviceProxy.Execute(del);
                Console.WriteLine("Entity records have been deleted.");
            }
        }

        #endregion How-To Sample Code

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

                EnableFieldSecurityForAnEntity app = new EnableFieldSecurityForAnEntity();
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

// </snippetenablefieldsecurityforanentity>