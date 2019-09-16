// <snippetusedeploymentservicemessages>


using System;
using System.Net;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;

// These namespaces are found in the Microsoft.Xrm.Sdk.Deployment.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk.Deployment;
using Deployment = Microsoft.Xrm.Sdk.Deployment;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to retrieve deployment information programmatically.</summary>
    /// <remarks>
    /// NOTE: The deployment service only supports Active Directory, so the user running
    /// this sample must have a valid Active Directory account.
    /// </remarks>
    public class UseDeploymentServiceMessages
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Deployment service. Then,
        /// a variety of messages are used to retrieve deployment information.
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

                    // Instantiate DeploymentServiceClient for calling the service.
                    DeploymentServiceClient serviceClient = 
                        Deployment.Proxy.ProxyClientHelper.CreateClient(
                        new Uri(serverConfig.DiscoveryUri.ToString()
                            .Replace("Services", "Deployment")
                            .Replace("Discovery", "Deployment")));

                    // Setting credentials from the current security context. 
                    if (serverConfig.Credentials == null)
                    {
                        serviceClient.ClientCredentials.Windows.ClientCredential =
                            CredentialCache.DefaultNetworkCredentials; 
                    }
                    else
                    {
                        serviceClient.ClientCredentials.Windows.ClientCredential =
                            serverConfig.Credentials.Windows.ClientCredential;
                    }

                    // Retrieve all deployed instances of Microsoft Dynamics CRM.
                    var organizations =
                        serviceClient.RetrieveAll(DeploymentEntityType.Organization);

                    // Print list of all retrieved organizations.
                    Console.WriteLine("Organizations in your deployment");
                    Console.WriteLine("================================");
                    foreach (var organization in organizations)
                    {
                        Console.WriteLine(organization.Name);
                    }
                    Console.WriteLine("<End of Listing>");
                    Console.WriteLine();


                    // Retrieve details of first organization from previous call.
                    Deployment.Organization deployment =
                        (Deployment.Organization)serviceClient.Retrieve(
                            DeploymentEntityType.Organization,
                            organizations[0]);

                    // Print out retrieved details about your organization.
                    Console.WriteLine(String.Format(
                        "Selected deployment details for {0}",
                        serverConfig.OrganizationName));
                    Console.WriteLine("=========================================");
                    Console.Write("Friendly Name: ");
                    Console.WriteLine(deployment.FriendlyName);
                    Console.Write("Unique Name: ");
                    Console.WriteLine(deployment.UniqueName);
                    Console.Write("Organization Version: ");
                    Console.WriteLine(deployment.Version);
                    Console.Write("SQL Server Name: ");
                    Console.WriteLine(deployment.SqlServerName);
                    Console.Write("SRS URL: ");
                    Console.WriteLine(deployment.SrsUrl);
                    Console.WriteLine("<End of Listing>");
                    Console.WriteLine();

                    // Retrieve license and user information for your organization.
                    TrackLicenseRequest licenseRequest = new TrackLicenseRequest();
                    TrackLicenseResponse licenseResponse =
                        (TrackLicenseResponse)serviceClient.Execute(licenseRequest);

                    // Print out the number of servers and the user list.
                    Console.WriteLine(String.Format(
                        "License and user information for {0}",
                        serverConfig.OrganizationName));
                    Console.WriteLine("=========================================");
                    Console.Write("Number of servers: ");
                    Console.WriteLine(licenseResponse.Servers != null
                        ? licenseResponse.Servers.Count.ToString()
                        : "null");
                    Console.WriteLine("Users:");
                    foreach (OrganizationUserInfo user in licenseResponse.Users.ToArray())
                    {
                        Console.WriteLine(user.FullName);
                    }
                    Console.WriteLine("<End of Listing>");
                    Console.WriteLine();

                    // Retrieve advanced settings for your organization.
                    // Note that the columnset must contain at least one column. Setting
                    // AllColumns to true results in an error.
                    RetrieveAdvancedSettingsRequest request =
                        new RetrieveAdvancedSettingsRequest
                        {
                            ConfigurationEntityName = "Server",
                            ColumnSet = new ColumnSet(
                                new string[] { "Id", "FullName", "Name", "Roles", "State", "Version" })
                        };
                    ConfigurationEntity configuration =
                        ((RetrieveAdvancedSettingsResponse)serviceClient.Execute(request)).Entity;

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
                    Console.WriteLine("<End of Listing>");
                    Console.WriteLine();

                }
            }

            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
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

                UseDeploymentServiceMessages app = new UseDeploymentServiceMessages();
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

// </snippetusedeploymentservicemessages>