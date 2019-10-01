// <snippetlicense>


using System;
using System.Linq;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to issue the RetrieveDeploymentLicenseTypeRequest and
    /// RetrieveLicenseInfoRequest.
    /// </summary>
    /// <param name="serverConfig">Contains server connection information.</param>
    /// <param name="promptforDelete">When True, the user will be prompted to delete all
    /// created entities.</param>
    public class License
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first executes a RetrieveDeploymentLicenseTypeRequest and 
        /// displays the type of license for this deployment to the console, then 
        /// executes a RetrieveLicenseInfoRequest and displays the number of used 
        /// and available Read-Write licenses there are.
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

                    #region RetrieveDeploymentLicenseTypeRequest

                    // Create the request
                    var deploymentTypeRequest = new RetrieveDeploymentLicenseTypeRequest();
                    
                    // Execute the request
                    Console.WriteLine("  Fetching the license type for this deployment");
                    var deploymentTypeResponse = 
                        (RetrieveDeploymentLicenseTypeResponse)_serviceProxy.Execute(deploymentTypeRequest);

                    // Validate results
                    if (String.IsNullOrEmpty(deploymentTypeResponse.licenseType))
                        throw new Exception("The request did not return any results");

                    string licenseId = 
                        new Guid(deploymentTypeResponse.licenseType).ToString().ToUpper();
                    switch (licenseId)
                    {
                        case "9436EA66-8262-4168-9B6C-21DF47D1D121":
                            Console.WriteLine("  License type: SmallBusiness");
                            break;
                        case "5BEEA2E8-8F82-40E8-AE0F-6D8C135E1397":
                            Console.WriteLine("  License type: Professional");
                            break;
                        case "CB96BDD5-5F74-4EA5-8323-9D7E20079002":
                            Console.WriteLine("  License type: Enterprise");
                            break;
                        case "66AE2919-DD58-40CA-A980-AEF7330B2745":
                            Console.WriteLine("  License type: Live");
                            break;
                        case "722E9E15-62DC-48A7-95CF-93131BE27273":
                            Console.WriteLine("  License type: SPLA (Service Provider)");
                            break;
                        default:
                            Console.WriteLine("  Unknown license type with id {0}", licenseId);
                            break;
                    }

                    #endregion

                    #region RetrieveLicenseInfoRequest

                    // create the request
                    var licenseInfoRequest = new RetrieveLicenseInfoRequest();

                    // execute the request
                    Console.WriteLine("  Fetching license info");
                    var licenseInfoResponse =
                        (RetrieveLicenseInfoResponse)_serviceProxy.Execute(licenseInfoRequest);

                    // output the results
                    Console.WriteLine("  Number of licenses available: {0}", 
                        licenseInfoResponse.AvailableCount);
                    Console.WriteLine("  Number of licenses used: {0}", 
                        licenseInfoResponse.GrantedLicenseCount);

                    #endregion
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

                License app = new License();
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

// </snippetlicense>