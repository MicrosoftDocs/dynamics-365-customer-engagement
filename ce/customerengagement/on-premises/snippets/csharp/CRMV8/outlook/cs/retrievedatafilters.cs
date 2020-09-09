// <snippetretrievedatafilters>


using System;
using System.Linq;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

// This namespace is found in Microsoft.Crm.Outlook.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Shows how to use the advanced capabilities of the CrmOutlookService:
    /// filters and templates</summary>
    /// <remarks>
    /// NOTE: Before running this sample, you should start the Outlook client.</remarks>
    public class RetrieveDataFilters
    {
        #region Class Level Members

        private Guid _offlineFilter;
        private Guid _offlineTemplate;

        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

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

                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();


                    // Create and Retrieve Offline Filter
                    // In your Outlook client, this will appear in the System Filters tab
                    // under File | CRM | Synchronize | Outlook Filters.
                    Console.Write("Creating offline filter");
                    String contactName = String.Format("offlineFilteredContact {0}",
                        DateTime.Now.ToLongTimeString());
                    String fetchXml = String.Format("<fetch version=\"1.0\" output-format=\"xml-platform\" mapping=\"logical\"><entity name=\"contact\"><attribute name=\"contactid\" /><filter type=\"and\">" +
                        "<condition attribute=\"ownerid\" operator=\"eq-userid\" /><condition attribute=\"description\" operator=\"eq\" value=\"{0}\" />" +
                        "<condition attribute=\"statecode\" operator=\"eq\" value=\"0\" /></filter></entity></fetch>", contactName);
                    SavedQuery filter = new SavedQuery();
                    filter.FetchXml = fetchXml;
                    filter.IsQuickFindQuery = false;
                    filter.QueryType = SavedQueryQueryType.OfflineFilters;
                    filter.ReturnedTypeCode = Contact.EntityLogicalName;
                    filter.Name = "ReadOnlyFilter_" + contactName;
                    filter.Description = "Sample offline filter for Contact entity";
                    _offlineFilter = _serviceProxy.Create(filter);

                    Console.WriteLine(" and retrieving offline filter");
                    SavedQuery result = (SavedQuery)_serviceProxy.Retrieve(
                        SavedQuery.EntityLogicalName,
                        _offlineFilter,
                        new ColumnSet("name", "description"));
                    Console.WriteLine("Name: {0}", result.Name);
                    Console.WriteLine("Description: {0}", result.Description);
                    Console.WriteLine();

                    // Create and Retrieve Offline Template
                    // In your Outlook client, this will appear in the User Filters tab
                    // under File | CRM | Synchronize | Outlook Filters.
                    Console.Write("Creating offline template");
                    String accountName = String.Format("offlineFilteredAccount {0}",
                        DateTime.Now.ToLongTimeString());
                    fetchXml = String.Format("<fetch version=\"1.0\" output-format=\"xml-platform\" mapping=\"logical\"><entity name=\"account\"><attribute name=\"accountid\" /><filter type=\"and\">" +
                        "<condition attribute=\"ownerid\" operator=\"eq-userid\" /><condition attribute=\"name\" operator=\"eq\" value=\"{0}\" />" +
                        "<condition attribute=\"statecode\" operator=\"eq\" value=\"0\" /></filter></entity></fetch>", accountName);
                    SavedQuery template = new SavedQuery();
                    template.FetchXml = fetchXml;
                    template.IsQuickFindQuery = false;
                    template.QueryType = SavedQueryQueryType.OfflineTemplate;
                    template.ReturnedTypeCode = Account.EntityLogicalName;
                    template.Name = "ReadOnlyFilter_" + accountName;
                    template.Description = "Sample offline template for Account entity";
                    _offlineTemplate = _serviceProxy.Create(template);

                    Console.WriteLine(" and retrieving offline template");
                    result = (SavedQuery)_serviceProxy.Retrieve(
                        SavedQuery.EntityLogicalName,
                        _offlineTemplate,
                        new ColumnSet("name", "description"));
                    Console.WriteLine("Name: {0}", result.Name);
                    Console.WriteLine("Description: {0}", result.Description);
                    Console.WriteLine();


                    // Call InstantiateFiltersRequest
                    Console.WriteLine("Retrieving user's ID and creating the template collection");
                    WhoAmIRequest whoAmI = new WhoAmIRequest();
                    Guid id = ((WhoAmIResponse)_serviceProxy.Execute(whoAmI)).UserId;
                    EntityReferenceCollection templates = new EntityReferenceCollection();
                    templates.Add(new EntityReference(
                        SavedQuery.EntityLogicalName,
                        _offlineTemplate));

                    Console.WriteLine("Activating the selected offline templates for this user");
                    InstantiateFiltersRequest request = new InstantiateFiltersRequest
                    {
                        UserId = id,
                        TemplateCollection = templates                            
                    };
                    InstantiateFiltersResponse response =
                        (InstantiateFiltersResponse)_serviceProxy.Execute(request);
                    Console.WriteLine();

                    // Call ResetUserFiltersRequest
                    Console.WriteLine("Resetting the user's offline templates to the defaults");
                    ResetUserFiltersRequest resetRequest = new ResetUserFiltersRequest
                    {
                        QueryType = SavedQueryQueryType.OfflineFilters
                    };
                    ResetUserFiltersResponse resetResponse =
                        (ResetUserFiltersResponse)_serviceProxy.Execute(resetRequest);
                    Console.WriteLine();

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
                Console.WriteLine("Deleting the offline filter and offline template");
                _serviceProxy.Delete(SavedQuery.EntityLogicalName, _offlineFilter);
                _serviceProxy.Delete(SavedQuery.EntityLogicalName, _offlineTemplate);
                
                Console.WriteLine("Entity record(s) have been deleted.");
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

                RetrieveDataFilters app = new RetrieveDataFilters();
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

// </snippetretrievedatafilters>