// <snippetcreatecustomactivityentity>


using System;
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
    /// This sample shows how to create a custom activity.
    /// </summary>
    public class CreateCustomActivityEntity
    {        
        #region Class Level Members
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create the custom entity.
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
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                                     serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    // The custom prefix would typically be passed in as an argument or 
                    // determined by the publisher of the custom solution.
                    String prefix = "new_";

                    String customEntityName = prefix + "instantmessage";

                    // Create the custom activity entity.
                    CreateEntityRequest request = new CreateEntityRequest
                    {
                        HasNotes = true,
                        HasActivities = false,
                        PrimaryAttribute = new StringAttributeMetadata
                        {
                            SchemaName = "Subject",
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                            MaxLength = 100,
                            DisplayName = new Label("Subject", 1033)
                        },
                        Entity = new EntityMetadata
                        {
                            IsActivity = true,
                            SchemaName = customEntityName,
                            DisplayName = new Label("Instant Message", 1033),
                            DisplayCollectionName = new Label("Instant Messages", 1033),
                            OwnershipType = OwnershipTypes.UserOwned,
                            IsAvailableOffline = true,

                        }
                    };

                    _serviceProxy.Execute(request);

                    //Entity must be published

                    // Add few attributes to the custom activity entity.
                    CreateAttributeRequest fontFamilyAttributeRequest =
                        new CreateAttributeRequest
                   {
                       EntityName = customEntityName,
                       Attribute = new StringAttributeMetadata
                       {
                           SchemaName = prefix + "fontfamily",
                           DisplayName = new Label("Font Family", 1033),
                           MaxLength = 100
                       }
                   };
                    CreateAttributeResponse fontFamilyAttributeResponse =
                        (CreateAttributeResponse)_serviceProxy.Execute(
                        fontFamilyAttributeRequest);

                    CreateAttributeRequest fontColorAttributeRequest =
                        new CreateAttributeRequest
                    {
                        EntityName = customEntityName,
                        Attribute = new StringAttributeMetadata
                        {
                            SchemaName = prefix + "fontcolor",
                            DisplayName = new Label("Font Color", 1033),
                            MaxLength = 50
                        }
                    };
                    CreateAttributeResponse fontColorAttributeResponse =
                        (CreateAttributeResponse)_serviceProxy.Execute(
                        fontColorAttributeRequest);

                    CreateAttributeRequest fontSizeAttributeRequest =
                        new CreateAttributeRequest
                    {
                        EntityName = customEntityName,
                        Attribute = new IntegerAttributeMetadata
                        {
                            SchemaName = prefix + "fontSize",
                            DisplayName = new Label("Font Size", 1033)
                        }
                    };
                    CreateAttributeResponse fontSizeAttributeResponse =
                        (CreateAttributeResponse)_serviceProxy.Execute(
                        fontSizeAttributeRequest);

                    Console.WriteLine("The custom activity has been created.");

                    DeleteCustomEntity(prefix, promptForDelete);
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
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the entity created in this sample.</param>
        /// </summary>
        public void DeleteCustomEntity(String prefix, bool prompt)
        {
            bool deleteEntity = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want this custom entity deleted? (y/n)");
                char answer = Convert.ToChar(Console.ReadLine().Substring(0, 1));

                deleteEntity = (answer == 'y' || answer == 'Y');
            }

            if (deleteEntity)
            {
                DeleteEntityRequest request = new DeleteEntityRequest()
                {
                    LogicalName = prefix + "instantmessage",
                };
                _serviceProxy.Execute(request);

                Console.WriteLine("Entity has been deleted.");
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

                CreateCustomActivityEntity app = new CreateCustomActivityEntity();
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

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe = 
                        ex.InnerException
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

// </snippetcreatecustomactivityentity>