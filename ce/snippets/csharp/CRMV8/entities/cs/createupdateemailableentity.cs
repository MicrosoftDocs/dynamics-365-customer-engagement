// <snippetcreateupdateemailableentity>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    public class CreateUpdateEmailableEntity
    {
        #region Class Level Members
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        private const String _customEntityName = "new_agent"; 

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create a custom entity that can be used in the To field of an email activity.
        /// Update the custom entity.
        /// Optionally delete the custom entity.
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



                    // Create the custom entity.
                    CreateEntityRequest createrequest = new CreateEntityRequest
                    {
                        // Define an entity to enable for emailing. In order to do so,
                        // IsActivityParty must be set.
                        Entity = new EntityMetadata
                        {
                            SchemaName = _customEntityName,
                            DisplayName = new Label("Agent", 1033),
                            DisplayCollectionName = new Label("Agents", 1033),
                            Description = new Label("Insurance Agents", 1033),
                            OwnershipType = OwnershipTypes.UserOwned,
                            IsActivity = false,

                            // Unless this flag is set, this entity cannot be party to an
                            // activity.
                            IsActivityParty = true
                        },

                        // As with built-in emailable entities, the Primary Attribute will
                        // be used in the activity party screens. Be sure to choose descriptive
                        // attributes.
                        PrimaryAttribute = new StringAttributeMetadata
                        {
                            SchemaName = "new_fullname",
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                            MaxLength = 100,
                            FormatName = StringFormatName.Text,
                            DisplayName = new Label("Agent Name", 1033),
                            Description = new Label("Agent Name", 1033)
                        }
                    };

                    _serviceProxy.Execute(createrequest);
                    Console.WriteLine("The emailable entity has been created.");

                    // The entity will not be selectable as an activity party until its customizations
                    // have been published. Otherwise, the e-mail activity dialog cannot find
                    // a correct default view.
                    PublishAllXmlRequest publishRequest = new PublishAllXmlRequest();
                    _serviceProxy.Execute(publishRequest);

                    // Before any emails can be created for this entity, an Email attribute
                    // must be defined.
                    CreateAttributeRequest createFirstEmailAttributeRequest = new CreateAttributeRequest
                    {
                        EntityName = _customEntityName,
                        Attribute = new StringAttributeMetadata
                        {
                            SchemaName = "new_emailaddress",
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                            MaxLength = 100,                            
                            FormatName = StringFormatName.Email,
                            DisplayName = new Label("Email Address", 1033),
                            Description = new Label("Email Address", 1033)
                        }
                    };

                    _serviceProxy.Execute(createFirstEmailAttributeRequest);
                    Console.WriteLine("An email attribute has been added to the emailable entity.");

                    // Create a second, alternate email address. Since there is already one 
                    // email attribute on the entity, this will never be used for emailing
                    // even if the first one is not populated.
                    CreateAttributeRequest createSecondEmailAttributeRequest = new CreateAttributeRequest
                    {
                        EntityName = _customEntityName,
                        Attribute = new StringAttributeMetadata
                        {
                            SchemaName = "new_secondaryaddress",
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                            MaxLength = 100,                            
                            FormatName = StringFormatName.Email,
                            DisplayName = new Label("Secondary Email Address", 1033),
                            Description = new Label("Secondary Email Address", 1033)
                        }
                    };

                    _serviceProxy.Execute(createSecondEmailAttributeRequest);

                    Console.WriteLine("A second email attribute has been added to the emailable entity.");

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
        /// Deletes the custom entity that was created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteEntity = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want this custom entity deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteEntity = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteEntity)
            {
                DeleteEntityRequest request = new DeleteEntityRequest()
                {
                    LogicalName = _customEntityName,
                };
                _serviceProxy.Execute(request);

                Console.WriteLine("The records have been deleted.");
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

                CreateUpdateEmailableEntity app = new CreateUpdateEmailableEntity();
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
        #endregion Main

    }
}

// </snippetcreateupdateemailableentity>