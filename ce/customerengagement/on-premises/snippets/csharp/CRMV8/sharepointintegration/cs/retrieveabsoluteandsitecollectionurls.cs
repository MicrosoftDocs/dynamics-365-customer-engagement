// <snippetretrieveabsoluteandsitecollectionurls>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;

// This namespace is found in the Microsoft.Crm.Sdk.Proxy.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to retrieve the absolute URL and the parent
    /// site collection URL of a SharePoint location record.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class RetrieveAbsoluteAndSiteCollectionURLs
    {
        #region Class Level Members

        private Guid _spSiteId;
        private Guid _spDocLocId;        
        private OrganizationServiceProxy _serviceProxy;

        // TODO: Appropriately change the absolute URL of the SharePoint site
        // record.
        private String _siteAbsoluteURL = "https://www.example.com";

        #endregion Class Level Members

        #region How-To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// retrieves the absolute URL and the parent site collection URL of a 
        /// SharePoint document location record.
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

                    CreateRequiredRecords();
                    // Retrieve the absolute URL and the Site Collection URL
                    // of the SharePoint document location record.
                    RetrieveAbsoluteAndSiteCollectionUrlRequest retrieveRequest = new RetrieveAbsoluteAndSiteCollectionUrlRequest
                    {
                        Target = new EntityReference(SharePointDocumentLocation.EntityLogicalName, _spDocLocId)
                    };
                    RetrieveAbsoluteAndSiteCollectionUrlResponse retriveResponse = (RetrieveAbsoluteAndSiteCollectionUrlResponse)_serviceProxy.Execute(retrieveRequest);

                    Console.WriteLine("Absolute URL of document location record is '{0}'.", retriveResponse.AbsoluteUrl.ToString());
                    Console.WriteLine("Site Collection URL of document location record is '{0}'.", retriveResponse.SiteCollectionUrl.ToString());
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
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Instantiate a SharePoint site object.
            // See the Entity Metadata topic in the SDK documentation to determine 
            // which attributes must be set for each entity.
            SharePointSite spSite = new SharePointSite
            {
                Name = "Sample SharePoint Site",
                Description = "Sample SharePoint Site Location record",                                        
                AbsoluteURL = _siteAbsoluteURL,
                IsGridPresent = true
            };

            // Create a SharePoint site record named Sample SharePoint Site.
            _spSiteId = _serviceProxy.Create(spSite);
            Console.WriteLine("{0} created.", spSite.Name);

            // Instantiate a SharePoint document location object.
            // See the Entity Metadata topic in the SDK documentation to determine 
            // which attributes must be set for each entity.
            SharePointDocumentLocation spDocLoc = new SharePointDocumentLocation
            {
                Name = "Sample SharePoint Document Location",
                Description = "Sample SharePoint Document Location record",

                // Set the Sample SharePoint Site created earlier as the parent site.
                ParentSiteOrLocation = new EntityReference(SharePointSite.EntityLogicalName, _spSiteId),
                RelativeUrl = "spdocloc"                
            };

            // Create a SharePoint document location record named Sample SharePoint Document Location.
            _spDocLocId = _serviceProxy.Create(spDocLoc);
            Console.WriteLine("{0} created.", spDocLoc.Name);
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
            }

            if (deleteRecords)
            {
                _serviceProxy.Delete(SharePointDocumentLocation.EntityLogicalName, _spDocLocId);
                _serviceProxy.Delete(SharePointSite.EntityLogicalName, _spSiteId);                
                Console.WriteLine("Entity records have been deleted.");
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

                RetrieveAbsoluteAndSiteCollectionURLs app = new RetrieveAbsoluteAndSiteCollectionURLs();
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

// </snippetretrieveabsoluteandsitecollectionurls>