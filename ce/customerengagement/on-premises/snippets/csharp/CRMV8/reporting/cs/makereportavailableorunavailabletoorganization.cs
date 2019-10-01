// <snippetmakereportavailableorunavailabletoorganization>


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

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to make a report available and 
    /// unavailable to the organization.
    /// </summary>
    public class MakeReportAvailableOrUnavailableToOrganization
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        private Guid _reportId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.        
        /// Set the report to be available and then unavailable for the organization.        
        /// Optionally delete any entity records that were created for this sample.
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

                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();

                    // Retrieve existing personal report.
                    Report existingPersonalReport = 
                        (Report)_serviceProxy.Retrieve(Report.EntityLogicalName, 
                        _reportId,                         
                        new ColumnSet("ispersonal"));

                    // Set IsPersonal property to false. 
                    existingPersonalReport.IsPersonal = false;

                    // Make the report available to the organization.
                    _serviceProxy.Update(existingPersonalReport);

                    // Retrieve the report and verify that the report is available to the organization
                    ColumnSet Cols1 = new ColumnSet("ispersonal");
                    Report retrieveAvailableReport = 
                        (Report)_serviceProxy.Retrieve(Report.EntityLogicalName, 
                        _reportId, Cols1);
                    if (retrieveAvailableReport.IsPersonal.Value == false)
                    {
                        Console.WriteLine("Report is available to the organization.");
                    }

                    // Now make the retrieved report unavailable to the organization
                    retrieveAvailableReport.IsPersonal = true;
                    _serviceProxy.Update(retrieveAvailableReport);
                    
                    // Retrieve the report, and verify that the report is unavailable to the organization
                    ColumnSet Cols2 = new ColumnSet("ispersonal");
                    Report retrieveUnavailableReport = 
                        (Report)_serviceProxy.Retrieve(Report.EntityLogicalName, 
                        _reportId, Cols2);
                    if (retrieveUnavailableReport.IsPersonal.Value == true)
                    {
                        Console.WriteLine("Report is unavailable to the organization.");
                    }


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
        /// This method creates any entity records that this sample requires.        
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Define an anonymous type to define the possible values for
            // report type
            var ReportTypeCode = new
            {
                ReportingServicesReport = 1,
                OtherReport = 2,
                LinkedReport = 3
            };
            
            // Create a report 
            Report newReport = new Report
            {
                Name = "Sample Report",
                Description = "Report created by the SDK code sample.",
                ReportTypeCode = new OptionSetValue((int)ReportTypeCode.OtherReport),

                //Base64-encoded "Hello, I am a text file."
                BodyBinary = "SGVsbG8sIEkgYW0gYSB0ZXh0IGZpbGUu", 
                FileName = "textfile.txt",
                IsPersonal = true
            };
            _reportId = _serviceProxy.Create(newReport);
            Console.WriteLine("Created {0}.", newReport.Name);            
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete 
        /// the records created in this sample.</param>
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
                // Delete all records created in this sample.
                _serviceProxy.Delete(Report.EntityLogicalName, _reportId);
                Console.WriteLine("Entity record(s) have been deleted.");
            }
        }

        #endregion How To Sample Code

        #region Main method
        /// <summary>
        /// Main. Runs the sample and provides error output.
        /// <param name="args">Array of arguments to Main method.</param>
        /// </summary>
        static public void Main(string[] args)
        {
            try
            {
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                MakeReportAvailableOrUnavailableToOrganization app = 
                    new MakeReportAvailableOrUnavailableToOrganization();
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
            // Additonal exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
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

// </snippetmakereportavailableorunavailabletoorganization>