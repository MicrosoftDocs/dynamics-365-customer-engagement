// <snippetuseasyncdeploymentservicemessages>


using System;
using System.ServiceModel;
using System.Threading;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Deployment;
using Microsoft.Xrm.Sdk.Deployment.Proxy;
using System.Net;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample demonstrates how to use the Deployment Web Service to create an 
    /// organization and poll the status of the job.
    /// </summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.
    /// </remarks>
    public class UseAsyncDeploymentServiceMessages
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;
        
        // Friendly Name for the organization database
        private String _friendlyName = "Alpine1";

        // Unique Name for the organization
        private String _uniqueName = "Alpine1";

        // Name of the SQL server on which the organization database is installed
        private String _sqlServerName = "sqlServerName";

        // URL of the Microsoft SQL Server on which the Microsoft Dynamics CRM Connector 
        // for SQL Server Reporting Services is installed:
        // Format: "https://reportServerName/reportserver"
        private String _srsUrl = "https://reportServerName/reportserver";

        // Name of the system administrator for the new organization
        // Format: "domain\\user"
        private String _sysAdminName = "domain\\user";

        private Guid _organizationID;
        private DeploymentServiceClient client;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Demonstrates how to use the Deployment Web Service to create an organization 
        /// and poll the status of the job.
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
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords(serverConfig, promptforDelete);

                    // Instantiate DeploymentServiceClient for calling the service.
                    client =
                        ProxyClientHelper.CreateClient(
                        new Uri(serverConfig.DiscoveryUri.ToString()
                            .Replace("Services", "Deployment")
                            .Replace("Discovery", "Deployment")));

                    // Setting credentials from the current security context. 
                    if (serverConfig.Credentials == null)
                    {
                        client.ClientCredentials.Windows.ClientCredential =
                            CredentialCache.DefaultNetworkCredentials;
                    }
                    else
                    {
                        client.ClientCredentials.Windows.ClientCredential =
                            serverConfig.Credentials.Windows.ClientCredential;
                    }

                    using (client)
                    {
                        // Set properties for the new organization
                        Microsoft.Xrm.Sdk.Deployment.Organization organization = 
                            new Microsoft.Xrm.Sdk.Deployment.Organization
                        {
                            BaseCurrencyCode = "USD",
                            BaseCurrencyName = "US Dollar",
                            BaseCurrencyPrecision = 2,
                            BaseCurrencySymbol = "$",
                            BaseLanguageCode = 1033,
                            FriendlyName = _friendlyName,
                            UniqueName = _uniqueName,
                            SqlCollation = "Latin1_General_CI_AI",
                            SqlServerName = _sqlServerName,
                            SrsUrl = _srsUrl,
                            SqmIsEnabled = false
                        };

                        // Create a request for the deployment web service
                        // CRM server app pool must have permissions on SQL server
                        BeginCreateOrganizationRequest request = 
                            new BeginCreateOrganizationRequest
                        {
                            Organization = organization,
                            SysAdminName = _sysAdminName
                        };

                        // Execute the request
                        BeginCreateOrganizationResponse response = 
                            (BeginCreateOrganizationResponse)client.Execute(request);

                        // The operation is asynchronous, so the response object contains
                        // a unique identifier for the operation
                        Guid operationId = response.OperationId;

                        // Retrieve the Operation using the OperationId
                        RetrieveRequest retrieveOperationStatus = new RetrieveRequest();
                        retrieveOperationStatus.EntityType = 
                            DeploymentEntityType.DeferredOperationStatus;
                        retrieveOperationStatus.InstanceTag = 
                            new EntityInstanceId { Id = operationId };

                        RetrieveResponse retrieveResponse;
                        DeferredOperationStatus deferredOperationStatus;

                        Console.WriteLine("Retrieving state of the job...");

                        // Retrieve the Operation State until Organization is created
                        do
                        {
                            // Wait 3 secs to not overload server
                            Thread.Sleep(3000);

                            retrieveResponse =
                            (RetrieveResponse)client.Execute(retrieveOperationStatus);

                            deferredOperationStatus = 
                                ((DeferredOperationStatus)retrieveResponse.Entity);
                        }
                        while (deferredOperationStatus.State != 
                            DeferredOperationState.Processing &&
                            deferredOperationStatus.State != 
                            DeferredOperationState.Completed);

                        // Poll OrganizationStatusRequest
                        RetrieveRequest retrieveReqServer = new RetrieveRequest();
                        retrieveReqServer.EntityType = DeploymentEntityType.Organization;
                        retrieveReqServer.InstanceTag = new EntityInstanceId();
                        retrieveReqServer.InstanceTag.Name = organization.UniqueName;

                        RetrieveResponse retrieveRespServer;
                        OrganizationState orgState;

                        Console.WriteLine("Retrieving state of the organization...");

                        // Retrieve and check the Organization State until is enabled
                        do
                        {
                            retrieveRespServer =
                                (RetrieveResponse)client.Execute(retrieveReqServer);
                            _organizationID = 
                                ((Microsoft.Xrm.Sdk.Deployment.Organization)retrieveRespServer.Entity).Id;
                            orgState =
                                ((Microsoft.Xrm.Sdk.Deployment.Organization)retrieveRespServer.Entity).State;

                            // Wait 5 secs to not overload server
                            Thread.Sleep(5000);
                        }
                        while (orgState != OrganizationState.Enabled);

                        Console.WriteLine("Organization has been created!");

                        DeleteRequiredRecords(promptforDelete);

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

        #region Public methods

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords(ServerConnection.Configuration config, Boolean prompt)
        {
            // For prompt and AD environment, pass current server details. 
            if (prompt &amp; config.EndpointType == AuthenticationProviderType.ActiveDirectory)
            {
                this._sqlServerName = config.ServerAddress;
                this._sysAdminName = config.ServerAddress + "dom\\administrator";
                this._srsUrl = "https://" + config.ServerAddress + "/reportserver";
            }
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool toBeDeleted = true;

            if (prompt)
            {
                // Ask the user if the created entities should be deleted.
                Console.Write("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();
                if (answer.StartsWith("y") ||
                    answer.StartsWith("Y") ||
                    answer == String.Empty)
                {
                    toBeDeleted = true;
                }
                else
                {
                    toBeDeleted = false;
                }
            }

            if (toBeDeleted)
            {
                // First disable the org
                EntityInstanceId organizationCreated = new EntityInstanceId();
                organizationCreated.Id = _organizationID;
                Microsoft.Xrm.Sdk.Deployment.Organization organization = 
                    (Microsoft.Xrm.Sdk.Deployment.Organization)client.Retrieve(
                    DeploymentEntityType.Organization, organizationCreated);
                
                // Update status to disabled
                organization.State = OrganizationState.Disabled;

                client.Update(organization);
                Console.WriteLine("Organization has been disabled.");
                
                // Second delete it
                client.Delete(DeploymentEntityType.Organization, organizationCreated);
                Console.WriteLine("Organization has been deleted.");
            }
        }
        #endregion Public Methods

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

                UseAsyncDeploymentServiceMessages app = new UseAsyncDeploymentServiceMessages();
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

// </snippetuseasyncdeploymentservicemessages>