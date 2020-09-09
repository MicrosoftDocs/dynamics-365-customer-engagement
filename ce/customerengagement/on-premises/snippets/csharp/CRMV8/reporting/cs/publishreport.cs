// <snippetpublishreport>


using System;
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.IO;

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
    /// This sample shows how to retrieve the history limit of a report.
    /// </summary>
    public class PublishReport
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        Guid _reportId;
        Guid _reportCategoryId;
        Guid _reportVisibilityId1;
        Guid _reportVisibilityId2;
        Guid _reportVisibilityId3;
        Guid _reportEntityId;
        //Guid _reportLinkId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.        
        /// Retrieve the history limit of a report.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
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

                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();


                    // Define an anonymous type to define the possible values for
                    // report type.
                    var ReportTypeCode = new
                    {
                        ReportingServicesReport = 1,
                        OtherReport = 2,
                        LinkedReport = 3
                    };

                    // Define an anonymous type to define the possible values for
                    // report category.
                    var ReportCategoryCode = new
                    {
                        SalesReports = 1,
                        ServiceReports = 2,
                        MarketingReports = 3,
                        AdministrativeReports = 4
                    };

                    // Define an anonymous type to define the possible values for
                    // report visibility
                    var ReportVisibilityCode = new
                    {
                        ReportsGrid = 1,
                        Form = 2,
                        Grid = 3,
                    };

                    // Instantiate a report object.
                    // See the Entity Metadata topic in the SDK documentation to determine
                    // which attributes must be set for each entity.

                    Report sampleReport = new Report
                    {
                        Name = "Sample Report",
                        BodyText = File.ReadAllText("SampleReport.rdl"),
                        FileName = "SampleReport.rdl",
                        LanguageCode = 1033, // US English
                        ReportTypeCode = new OptionSetValue(ReportTypeCode.ReportingServicesReport)
                    };
                    // Create a report record named Sample Report.
                    _reportId = _serviceProxy.Create(sampleReport);


                    // Set the report category.
                    ReportCategory sampleReportCategory = new ReportCategory
                    {
                        ReportId = new EntityReference(Report.EntityLogicalName, _reportId),
                        CategoryCode = new OptionSetValue(ReportCategoryCode.AdministrativeReports)
                    };
                    _reportCategoryId = _serviceProxy.Create(sampleReportCategory);

                    // Define which entity this report uses.
                    ReportEntity reportEntity = new ReportEntity
                    {
                        ReportId = new EntityReference(Report.EntityLogicalName, _reportId),
                        ObjectTypeCode = Account.EntityLogicalName
                    };
                    _reportEntityId = _serviceProxy.Create(reportEntity);


                    // Set the report visibility.
                    ReportVisibility rv = new ReportVisibility
                    {
                        ReportId = new EntityReference(Report.EntityLogicalName, _reportId),
                        VisibilityCode = new OptionSetValue(ReportVisibilityCode.Form)
                    };
                    _reportVisibilityId1 = _serviceProxy.Create(rv);

                    rv = new ReportVisibility
                    {
                        ReportId = new EntityReference(Report.EntityLogicalName, _reportId),
                        VisibilityCode = new OptionSetValue(ReportVisibilityCode.Grid)
                    };
                    _reportVisibilityId2 = _serviceProxy.Create(rv);

                    rv = new ReportVisibility
                    {
                        ReportId = new EntityReference(Report.EntityLogicalName, _reportId),
                        VisibilityCode = new OptionSetValue(ReportVisibilityCode.ReportsGrid)
                    };
                    _reportVisibilityId3 = _serviceProxy.Create(rv);

                    Console.WriteLine("{0} published in Microsoft Dynamics CRM.", sampleReport.Name);



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
        /// This method creates any entity records that this sample requires.        
        /// </summary>
        public void CreateRequiredRecords()
        {
            // No entity records are required for this sample.
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete 
        /// the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want the records to be deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                _serviceProxy.Delete(Report.EntityLogicalName, _reportId);
                /* There is no need to delete these records because deleting the report will delete all related records.
                _serviceProxy.Delete(ReportCategory.EntityLogicalName, _reportCategoryId);
                _serviceProxy.Delete(ReportEntity.EntityLogicalName, _reportEntityId);
                _serviceProxy.Delete(ReportLink.EntityLogicalName, _reportLinkId);
                _serviceProxy.Delete(ReportVisibility.EntityLogicalName, _reportVisibilityId1);
                _serviceProxy.Delete(ReportVisibility.EntityLogicalName, _reportVisibilityId2);
                _serviceProxy.Delete(ReportVisibility.EntityLogicalName, _reportVisibilityId3);
                */
                Console.WriteLine("Entity records have been deleted.");
                
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

                PublishReport app = new PublishReport();
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

// </snippetpublishreport>