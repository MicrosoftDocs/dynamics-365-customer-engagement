// <snippetmoredeploymentservicemessages>


using System;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel;
using System.Linq;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;

// These namespaces are found in the Microsoft.Xrm.Sdk.Deployment.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk.Deployment;
using Microsoft.Xrm.Sdk.Deployment.Proxy;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to use the following DeploymentServiceMessages:
    /// RetrieveRequest, UpdateRequest and UpdateAdvancedSettingsRequest
    /// </summary>
    /// <remarks>
    /// NOTE: The deployment service only supports Active Directory, so the user running
    /// this sample must have a valid Active Directory account.
    /// This sample demonstrates its full functionality in a multi-server environment. 
    /// During execution it can disable one of the server for demonstration.
    /// </remarks>
    public class MoreDeploymentServiceMessages
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Deployment service. Then,
        /// uses RetrieveRequest, UpdateRequest and UpdateAdvancedSettingsRequest.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete
        /// all created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {

                    // Instantiate DeploymentServiceClient for calling the service.
                    DeploymentServiceClient serviceClient =
                        ProxyClientHelper.CreateClient(
                        new Uri(serverConfig.DiscoveryUri.ToString()
                            .Replace("Services", "Deployment")
                            .Replace("Discovery", "Deployment")));

                    // Setting credentials from the current security context. 
                    if (serverConfig.Credentials != null)
                    {
                        serviceClient.ClientCredentials.Windows.ClientCredential =
                            serverConfig.Credentials.Windows.ClientCredential;
                    }
                    else
                    {
                        serviceClient.ClientCredentials.Windows.ClientCredential =
                            CredentialCache.DefaultNetworkCredentials;
                    }

                    #region RetrieveRequest
                    
                    // Retrieve all servers available in the deployment
                    Console.WriteLine("\nRetrieving list of servers...\n");
                    var servers =
                        serviceClient.RetrieveAll(DeploymentEntityType.Server);
                    
                    // Print list of all retrieved servers.
                    Console.WriteLine("Servers in your deployment");
                    Console.WriteLine("================================");
                    foreach (var server in servers)
                    {
                        Console.WriteLine(server.Name);
                    }
                    Console.WriteLine("<End of Listing>");
                    Console.WriteLine();                    

                    // Retrieve details of first (other than current server) or default server from previous call.
                    var serverId = servers.FirstOrDefault(x => x.Name.ToLowerInvariant() != serverConfig.ServerAddress.ToLowerInvariant());
                    // If no other server exists then default to existing one.
                    if (serverId == null)
                        serverId = servers.FirstOrDefault();

                    Console.WriteLine("\nRetrieving details of one server...\n");
                    RetrieveRequest retrieveReqServer = new RetrieveRequest();
                    retrieveReqServer.EntityType = DeploymentEntityType.Server;
                    retrieveReqServer.InstanceTag = serverId;
                    RetrieveResponse retrieveRespServer = 
                        (RetrieveResponse)serviceClient.Execute(retrieveReqServer);
                    Server serverToUpdate = 
                        (Server)retrieveRespServer.Entity;

                    Console.WriteLine("================================");
                    Console.WriteLine("Name: " + serverToUpdate.Name);
                    Console.WriteLine("State: " + serverToUpdate.State);
                    Console.WriteLine();

                    #endregion RetrieveRequest

                    #region UpdateRequest
                    // Avoid updating current server as it would disrupt the further sample execution.
                    if (servers.Count > 1)
                    {
                        // Modified the property we want to update
                        serverToUpdate.State = ServerState.Disabled;

                        // Update the deployment record
                        Console.WriteLine("\nUpdating server...\n");
                        UpdateRequest updateReq = new UpdateRequest();
                        updateReq.Entity = serverToUpdate;
                        UpdateResponse uptRes =
                            (UpdateResponse)serviceClient.Execute(updateReq);

                        // Retrieve server details again to check if it is updated
                        RetrieveResponse retrieveRespServerUpdated =
                            (RetrieveResponse)serviceClient.Execute(retrieveReqServer);
                        Server serverUpdated =
                            (Server)retrieveRespServerUpdated.Entity;

                        Console.WriteLine("Server Updated");
                        Console.WriteLine("================================");
                        Console.WriteLine("Name: " + serverUpdated.Name);
                        Console.WriteLine("State: " + serverUpdated.State);
                        Console.WriteLine();

                        // Revert change
                        serverUpdated.State = ServerState.Enabled;

                        Console.WriteLine("\nReverting change made in server...\n");
                        UpdateRequest updateReqRevert = new UpdateRequest();
                        updateReqRevert.Entity = serverUpdated;
                        UpdateResponse uptResRev =
                            (UpdateResponse)serviceClient.Execute(updateReqRevert);

                        RetrieveResponse retrieveRespServerReverted =
                            (RetrieveResponse)serviceClient.Execute(retrieveReqServer);
                        Server serverReverted =
                            (Server)retrieveRespServerReverted.Entity;

                        Console.WriteLine("Server Reverted");
                        Console.WriteLine("================================");
                        Console.WriteLine("Name: " + serverReverted.Name);
                        Console.WriteLine("State: " + serverReverted.State);
                        Console.WriteLine();
                    }
                    else
                        Console.WriteLine("\nMulti-server environment missing." 
                            + "\nSkipping server update request to avoid disruption in the sample execution.");
                    #endregion UpdateRequest

                    #region UpdateAdvanceRequest
                    
                    // Retrieve Advanced Settings for your organization.
                    Console.WriteLine("\nRetrieving Advanced Settings...\n");
                    RetrieveAdvancedSettingsRequest requestAdvSettings =
                        new RetrieveAdvancedSettingsRequest
                        {
                            ConfigurationEntityName = "Deployment",
                            ColumnSet = new ColumnSet("Id")
                        };
                    ConfigurationEntity configuration =
                        ((RetrieveAdvancedSettingsResponse)
                        serviceClient.Execute(requestAdvSettings)).Entity;

                    // Print out all advanced settings where IsWritable==true.
                    Console.WriteLine("Advanced deployment settings that can be updated");
                    Console.WriteLine("================================================");
                    foreach (var setting in configuration.Attributes)
                    {
                        if (setting.Key != "Id")
                        {
                            Console.WriteLine(
                                String.Format("{0}: {1}",
                                    setting.Key,
                                    setting.Value));
                        }
                    }
                    Console.WriteLine();

                    // Create the Configuration Entity with the values to update
                    ConfigurationEntity configEntity = new ConfigurationEntity();
                    configEntity.LogicalName = "Deployment";
                    configEntity.Attributes = new AttributeCollection();
                    configEntity.Attributes.Add
                        (new KeyValuePair<string, object>
                            ("AutomaticallyInstallDatabaseUpdates", true));

                    // Update Advanced Settings
                    Console.WriteLine("\nUpdating Advanced Settings...\n");
                    UpdateAdvancedSettingsRequest updateAdvanceReq = 
                        new UpdateAdvancedSettingsRequest();
                    updateAdvanceReq.Entity = configEntity;
                    serviceClient.Execute(updateAdvanceReq);

                    // Retrieve Advanced Settings to check if they have been updated
                    ConfigurationEntity configurationUpdated =
                        ((RetrieveAdvancedSettingsResponse)
                        serviceClient.Execute(requestAdvSettings)).Entity;

                    Console.WriteLine("Advanced deployment settings updated");
                    Console.WriteLine("================================================");
                    foreach (var setting in configurationUpdated.Attributes)
                    {
                        if (setting.Key != "Id")
                        {
                            Console.WriteLine(
                                String.Format("{0}: {1}",
                                    setting.Key,
                                    setting.Value));
                        }
                    }
                    Console.WriteLine();

                    // Revert change
                    ConfigurationEntity entityRevert = new ConfigurationEntity();
                    entityRevert.LogicalName = "Deployment";
                    entityRevert.Attributes = new AttributeCollection();
                    entityRevert.Attributes.Add
                        (new KeyValuePair<string, object>
                            ("AutomaticallyInstallDatabaseUpdates", false));

                    Console.WriteLine("\nReverting Advanced Settings...\n");
                    UpdateAdvancedSettingsRequest requestRevert = 
                        new UpdateAdvancedSettingsRequest();
                    requestRevert.Entity = entityRevert;
                    serviceClient.Execute(requestRevert);

                    ConfigurationEntity configurationReverted =
                        ((RetrieveAdvancedSettingsResponse)
                        serviceClient.Execute(requestAdvSettings)).Entity;
                    Console.WriteLine("Advanced deployment settings reverted");
                    Console.WriteLine("================================================");
                    foreach (var setting in configurationReverted.Attributes)
                    {
                        if (setting.Key != "Id")
                        {
                            Console.WriteLine(
                                String.Format("{0}: {1}",
                                    setting.Key,
                                    setting.Value));
                        }
                    }
                    Console.WriteLine();
                    #endregion UpdateAdvanceRequest
                }
            }
            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<DeploymentServiceFault>)
            {
                // You can handle an exception here or pass it back to the calling method.
                throw;
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

                MoreDeploymentServiceMessages app = new MoreDeploymentServiceMessages();
                app.Run(config, true);
            }
            catch (FaultException<DeploymentServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
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

                    FaultException<DeploymentServiceFault> fe = ex.InnerException
                        as FaultException<DeploymentServiceFault>;
                    if (fe != null)
                    {
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp);
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode);
                        Console.WriteLine("Message: {0}", fe.Detail.Message);
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

// </snippetmoredeploymentservicemessages>