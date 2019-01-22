// <snippetworkwithrelationships>


using System;
using System.Linq;
using System.Xml.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to create one to many, many to many relationship.
    /// </summary>
    public class WorkWithRelationships
    {
        #region Class Level Members
        
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        private Guid _oneToManyRelationshipId;
        private System.String _oneToManyRelationshipName;

        private Guid _manyToManyRelationshipId;
        private System.String _manyToManyRelationshipName;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Create one-to-many relationship.
        /// Create many-to-many relationship.
        /// Optionally delete any entity records that were created for this sample.
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
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();


                    bool eligibleCreateOneToManyRelationship =
                        EligibleCreateOneToManyRelationship("account", "campaign");

                    if (eligibleCreateOneToManyRelationship)
                    {
                        CreateOneToManyRequest createOneToManyRelationshipRequest =
                            new CreateOneToManyRequest
                        {
                            OneToManyRelationship =
                            new OneToManyRelationshipMetadata
                            {
                                ReferencedEntity = "account",
                                ReferencingEntity = "campaign",
                                SchemaName = "new_account_campaign",
                                AssociatedMenuConfiguration = new AssociatedMenuConfiguration
                                {
                                    Behavior = AssociatedMenuBehavior.UseLabel,
                                    Group = AssociatedMenuGroup.Details,
                                    Label = new Label("Account", 1033),
                                    Order = 10000
                                },
                                CascadeConfiguration = new CascadeConfiguration
                                {
                                    Assign = CascadeType.NoCascade,
                                    Delete = CascadeType.RemoveLink,
                                    Merge = CascadeType.NoCascade,
                                    Reparent = CascadeType.NoCascade,
                                    Share = CascadeType.NoCascade,
                                    Unshare = CascadeType.NoCascade
                                }
                            },
                            Lookup = new LookupAttributeMetadata
                            {
                                SchemaName = "new_parent_accountid",
                                DisplayName = new Label("Account Lookup", 1033),
                                RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                                Description = new Label("Sample Lookup", 1033)
                            }
                        };


                        CreateOneToManyResponse createOneToManyRelationshipResponse =
                            (CreateOneToManyResponse)_serviceProxy.Execute(
                            createOneToManyRelationshipRequest);

                        _oneToManyRelationshipId =
                            createOneToManyRelationshipResponse.RelationshipId;
                        _oneToManyRelationshipName = 
                            createOneToManyRelationshipRequest.OneToManyRelationship.SchemaName;

                        Console.WriteLine(
                            "The one-to-many relationship has been created between {0} and {1}.",
                            "account", "campaign");
                    }



                    bool accountEligibleParticipate =
                        EligibleCreateManyToManyRelationship("account");
                    bool campaignEligibleParticipate =
                        EligibleCreateManyToManyRelationship("campaign");

                    if (accountEligibleParticipate && campaignEligibleParticipate)
                    {

                        CreateManyToManyRequest createManyToManyRelationshipRequest =
                            new CreateManyToManyRequest
                        {
                            IntersectEntitySchemaName = "new_accounts_campaigns",
                            ManyToManyRelationship = new ManyToManyRelationshipMetadata
                            {
                                SchemaName = "new_accounts_campaigns",
                                Entity1LogicalName = "account",
                                Entity1AssociatedMenuConfiguration =
                                new AssociatedMenuConfiguration
                                {
                                    Behavior = AssociatedMenuBehavior.UseLabel,
                                    Group = AssociatedMenuGroup.Details,
                                    Label = new Label("Account", 1033),
                                    Order = 10000
                                },
                                Entity2LogicalName = "campaign",
                                Entity2AssociatedMenuConfiguration =
                                new AssociatedMenuConfiguration
                                {
                                    Behavior = AssociatedMenuBehavior.UseLabel,
                                    Group = AssociatedMenuGroup.Details,
                                    Label = new Label("Campaign", 1033),
                                    Order = 10000
                                }
                            }
                        };

                        CreateManyToManyResponse createManytoManyRelationshipResponse =
                            (CreateManyToManyResponse)_serviceProxy.Execute(
                            createManyToManyRelationshipRequest);


                        _manyToManyRelationshipId =
                            createManytoManyRelationshipResponse.ManyToManyRelationshipId;
                        _manyToManyRelationshipName =
                            createManyToManyRelationshipRequest.ManyToManyRelationship.SchemaName;

                        Console.WriteLine(
                            "The many-to-many relationship has been created between {0} and {1}.",
                            "account", "campaign");
                    }


                    // Publish the customization changes.
                    _serviceProxy.Execute(new PublishAllXmlRequest());



                    //You can use either the Name or the MetadataId of the relationship.

                    //Retrieve the One-to-many relationship using the MetadataId.
                    RetrieveRelationshipRequest retrieveOneToManyRequest =
                        new RetrieveRelationshipRequest { MetadataId = _oneToManyRelationshipId };
                    RetrieveRelationshipResponse retrieveOneToManyResponse =
                        (RetrieveRelationshipResponse)_serviceProxy.Execute(retrieveOneToManyRequest);

                    Console.WriteLine("Retrieved {0} One-to-many relationship by id", retrieveOneToManyResponse.RelationshipMetadata.SchemaName);

                    //Retrieve the Many-to-many relationship using the Name.
                    RetrieveRelationshipRequest retrieveManyToManyRequest =
                        new RetrieveRelationshipRequest { Name = _manyToManyRelationshipName};
                    RetrieveRelationshipResponse retrieveManyToManyResponse =
                        (RetrieveRelationshipResponse)_serviceProxy.Execute(retrieveManyToManyRequest);

                    Console.WriteLine("Retrieved {0} Many-to-Many relationship by Name", retrieveManyToManyResponse.RelationshipMetadata.MetadataId);


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
        /// Determines whether the entity can participate in a many-to-many relationship.
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns></returns>
        public bool EligibleCreateManyToManyRelationship(string entity)
        {
            CanManyToManyRequest canManyToManyRequest = new CanManyToManyRequest
            {
                EntityName = entity
            };

            CanManyToManyResponse canManyToManyResponse =
                (CanManyToManyResponse)_serviceProxy.Execute(canManyToManyRequest);

            if (!canManyToManyResponse.CanManyToMany)
            {
                Console.WriteLine(
                    "Entity {0} can't participate in a many-to-many relationship.", 
                    entity);
            }

            return canManyToManyResponse.CanManyToMany;
        }
        /// <summary>
        /// Determines whether two entities are eligible to participate in a relationship
        /// </summary>
        /// <param name="referencedEntity">Primary Entity</param>
        /// <param name="referencingEntity">Referencing Entity</param>
        /// <returns></returns>
        public bool EligibleCreateOneToManyRelationship(string referencedEntity, 
            string referencingEntity)
        {
            //Checks whether the specified entity can be the primary entity in one-to-many
            //relationship.
            CanBeReferencedRequest canBeReferencedRequest = new CanBeReferencedRequest
            {
                EntityName = referencedEntity
            };

            CanBeReferencedResponse canBeReferencedResponse =
                (CanBeReferencedResponse)_serviceProxy.Execute(canBeReferencedRequest);

            if (!canBeReferencedResponse.CanBeReferenced)
            {
                Console.WriteLine(
                    "Entity {0} can't be the primary entity in this one-to-many relationship", 
                    referencedEntity);
            }

            //Checks whether the specified entity can be the referencing entity in one-to-many
            //relationship.
            CanBeReferencingRequest canBereferencingRequest = new CanBeReferencingRequest
            {
                EntityName = referencingEntity
            };

            CanBeReferencingResponse canBeReferencingResponse =
                (CanBeReferencingResponse)_serviceProxy.Execute(canBereferencingRequest);

            if (!canBeReferencingResponse.CanBeReferencing)
            {
                Console.WriteLine(
                    "Entity {0} can't be the referencing entity in this one-to-many relationship", 
                    referencingEntity);
            }


            if (canBeReferencedResponse.CanBeReferenced == true
                && canBeReferencingResponse.CanBeReferencing == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Deletes the relationships that was created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete 
        /// the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity relationships to be deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                DeleteRelationshipRequest deleteOneToManyRelationshipRequest = 
                    new DeleteRelationshipRequest
                {                    
                    Name = "new_account_campaign"
                };

                _serviceProxy.Execute(deleteOneToManyRelationshipRequest);

                DeleteRelationshipRequest deleteManyToManyRelationshipRequest = 
                    new DeleteRelationshipRequest
                {
                    Name = "new_accounts_campaigns"
                };

                _serviceProxy.Execute(deleteManyToManyRelationshipRequest);

                Console.WriteLine("Entity Relationships have been deleted.");
            }
        }

        #endregion How To Sample Code

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

                WorkWithRelationships app = new WorkWithRelationships();
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

// </snippetworkwithrelationships>