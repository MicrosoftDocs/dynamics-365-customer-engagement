// <snippetenabledocumentmanagement>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;

// This namespace is found in the Microsoft.Crm.Sdk.Proxy.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to enable document management
    /// for an entity.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to revert
    /// the changes done by this program.</remarks>
    public class EnableDocumentManagement
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How-To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// retrieves the Contact entity record, and then enables the document management 
        /// for the entity.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforRevert">When True, the user will be prompted to revert all
        /// the changes done in this sample.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforRevert)
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

                    // Retrieve an entity for which you want to enable document management.
                    // In this sample, we will retrieve and enable document management
                    // for the Contact entity because by default, document management is
                    // not enabled for this entity.                    
                    
                    RetrieveEntityRequest entityRequest = new RetrieveEntityRequest
                    {
                        EntityFilters = EntityFilters.All,
                        LogicalName = Contact.EntityLogicalName,

                        // Retrieve only the currently published changes, ignoring the changes 
                        // that have not been published.
                        RetrieveAsIfPublished = false
                    };
                    RetrieveEntityResponse entityResponse = (RetrieveEntityResponse)_serviceProxy.Execute(entityRequest);
                    Console.WriteLine("Retrieved the contact entity.");

                    // Get the entity from the response.
                    EntityMetadata contactEntity = entityResponse.EntityMetadata;

                    // Enable document management for the retrieved entity.
                    contactEntity.IsDocumentManagementEnabled = true;

                    // Create an update request.                    
                    UpdateEntityRequest updateRequest = new UpdateEntityRequest
                    {
                        Entity = contactEntity                        
                    };
                    _serviceProxy.Execute(updateRequest);

                    // Publish the entity.
                    // All customizations must be published before they can be used.
                    PublishAllXmlRequest enableRequest = new PublishAllXmlRequest();
                    _serviceProxy.Execute(enableRequest);                    

                    // Retrieve the contact entity, and verify that document management is enabled.
                    entityResponse = (RetrieveEntityResponse)_serviceProxy.Execute(entityRequest);
                    contactEntity = entityResponse.EntityMetadata;
                    if (contactEntity.IsDocumentManagementEnabled.Value == true)
                    {
                        Console.WriteLine("Enabled document management for the contact entity.");
                    }                    

                    RevertChanges(promptforRevert);
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
            // For this sample, no entities are created.
        }

        /// <summary>
        /// Reverts any changes that were done by this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to revert the changes done by this sample.</param>
        /// </summary>
        public void RevertChanges(bool prompt)
        {
            bool revertChanges = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these changes reverted? (y/n) [y]: ");
                String answer = Console.ReadLine();

                revertChanges = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
            }

            if (revertChanges)
            {
                RetrieveEntityRequest entityRequest = new RetrieveEntityRequest
                {
                    EntityFilters = EntityFilters.All,
                    LogicalName = Contact.EntityLogicalName,                    
                    RetrieveAsIfPublished = false
                };
                RetrieveEntityResponse entityResponse = (RetrieveEntityResponse)_serviceProxy.Execute(entityRequest);
                
                EntityMetadata contactEntity = entityResponse.EntityMetadata;

                // Disable document management for the retrieved entity.
                contactEntity.IsDocumentManagementEnabled = false;

                UpdateEntityRequest updateRequest = new UpdateEntityRequest
                {
                    Entity = contactEntity
                };
                _serviceProxy.Execute(updateRequest);

                // Publish the customizations to the entity.                
                PublishAllXmlRequest disableRequest = new PublishAllXmlRequest();
                _serviceProxy.Execute(disableRequest);
                
                Console.WriteLine("Changes have been reverted.");
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

                EnableDocumentManagement app = new EnableDocumentManagement();
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
            finally
            {
                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }
        }
        #endregion Main method
    }
}

// </snippetenabledocumentmanagement>