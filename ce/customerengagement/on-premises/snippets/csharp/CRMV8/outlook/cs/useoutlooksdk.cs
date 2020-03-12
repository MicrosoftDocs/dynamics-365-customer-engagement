// <snippetuseoutlooksdk>


using System;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk.Client;

// This namespace is found in Microsoft.Crm.Outlook.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Outlook.Sdk;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Shows how to use the methods of the CrmOutlookService located in the
    /// Microsoft.Crm.Outlook.Sdk.dll assembly.</summary>
    /// <remarks>
    /// NOTE: Before running this sample, you should start the Outlook client.</remarks>
    public class UseOutlookSdk
    {
        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Outlook service. Afterwards,
        /// client information is retrieved and the client state is changed.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
                // Set up the CRM Service.  
                CrmOutlookService outlookService = new CrmOutlookService();

                // Determine if the Outlook client is running
                if (outlookService.IsCrmClientLoaded)
                {
                    if (outlookService.IsCrmDesktopClient)
                    {
                        // The desktop client cannot go offline
                        Console.WriteLine("CRM Client Desktop URL: " +
                            outlookService.ServerUri.AbsoluteUri);
                        Console.WriteLine("CRM Client state: " +
                            outlookService.State.ToString());
                    }
                    else
                    {
                        // See if laptop client is offline
                        if (outlookService.IsCrmClientOffline)
                        {
                            Console.WriteLine("CRM Client Offline URL: " +
                                outlookService.ServerUri.AbsoluteUri);
                            Console.WriteLine("CRM Client state: " +
                                outlookService.State.ToString());

                            // Take client online
                            // NOTE: GoOnline() will automatically Sync up with CRM
                            // database, no need to call Sync() manually
                            Console.WriteLine("Going Online...");
                            outlookService.GoOnline();

                            Console.WriteLine("CRM Client state: " +
                                outlookService.State.ToString());
                        }
                        else
                        {
                            Console.WriteLine("CRM Client Online URL: " +
                                outlookService.ServerUri.AbsoluteUri);
                            Console.WriteLine("CRM Client state: " +
                                outlookService.State.ToString());

                            // Take client offline 
                            // NOTE: GoOffline triggers a synchronization of the
                            // offline database with the online server.
                            // If a sync is not required, you can use SetOffline().
                            Console.WriteLine("Going Offline...");
                            outlookService.GoOffline();

                            Console.WriteLine("CRM Client state: " +
                                outlookService.State.ToString());
                        }
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
                ServerConnection.Configuration config =
                    serverConnect.GetServerConfiguration();

                UseOutlookSdk app = new UseOutlookSdk();
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

// </snippetuseoutlooksdk>