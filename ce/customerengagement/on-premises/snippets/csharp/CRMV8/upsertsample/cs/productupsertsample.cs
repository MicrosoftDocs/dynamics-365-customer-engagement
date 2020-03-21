// <snippetproductupsertsample>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Diagnostics;
using System.Xml.Linq;
using System.IO;
using System.Collections.Generic;
using System.Xml;
using System.Threading;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    public class ProductUpsertSample
    {
        #region Class Level Members
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>

        private OrganizationServiceProxy _serviceProxy;
        private const String _customProductsEntityName = "sample_product";
        System.String ManagedSolutionLocation = @".\\UpsertSample_1_0_0_0_managed.zip";

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Imports the UpsertSample solution if it is not already installed.
        /// Inserts the new records from newsampleproduct.xml to sample_product entity using Upsert.
        /// Updates records in sample_product with data from updatedsampleproduct.xml using Upsert.
        /// Optionally allows the user view the records in browser.
        /// Optionally deletes the UpsertSsample solution.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptForDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri, serverConfig.Credentials, serverConfig.DeviceCredentials))
                {

                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    // Check the version of CRM.
                    if(CheckCRMVersion())
                    {
                        // Imports the UpsertSample solution if it is not already installed.
                        ImportUpsertSampleSolution();

                        // Waits for the alternate key to be active.
                        WaitForEntityAndKeysToBeActive(_serviceProxy, _customProductsEntityName.ToLower());

                        // Processes the data in newsampleproduct.xml 
                        // to represent new products. Creates 13 records in sample_product entity.
                        // RecordCreated property returns true to indicate the records were created.

                        ProcessUpsert(".\\newsampleproduct.xml");

                        // Processes the data in updatedsampleproduct.xml 
                        // to represent updates to products previously created. 
                        // Updates 6 existing records in sample_product entity.
                        // RecordCreated property returns false to indicate the existing records were updated.
                        ProcessUpsert(".\\updatedsampleproduct.xml");

                        // Prompts to delete the UpsertSample managed solution.
                        DeleteUpsertSampleSolution(promptForDelete);
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

        /// <summary>
        /// Checks whether the UpsertSample solution is already installed.
        /// If it is not, the UpsertSample_1_0_0_0_managed.zip file is imported to install
        /// this solution.
        /// </summary>
        public void ImportUpsertSampleSolution()
        {
            try
            {

                Console.WriteLine("Checking whether the UpsertSample solution already exists.....");

                QueryByAttribute queryCheckForSampleSolution = new QueryByAttribute();
                queryCheckForSampleSolution.AddAttributeValue("uniquename", "UpsertSample");
                queryCheckForSampleSolution.EntityName = Solution.EntityLogicalName;

                EntityCollection querySampleSolutionResults = _serviceProxy.RetrieveMultiple(queryCheckForSampleSolution);
                Solution SampleSolutionResults = null;
                if (querySampleSolutionResults.Entities.Count > 0)
                {
                    Console.WriteLine("The {0} solution already exists....", "UpsertSample");
                    SampleSolutionResults = (Solution)querySampleSolutionResults.Entities[0];

                }
                else
                {
                    Console.WriteLine("The UpsertSample solution does not exist. Importing the solution....");
                    byte[] fileBytes = File.ReadAllBytes(ManagedSolutionLocation);
                    ImportSolutionRequest impSolReq = new ImportSolutionRequest()
                    {
                        CustomizationFile = fileBytes
                    };

                    _serviceProxy.Execute(impSolReq);

                    Console.WriteLine("Imported Solution from {0}", ManagedSolutionLocation);

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
        /// Checks the version of CRM instance.
        /// If it is less than version 7.1.0.0, prompt to upgrade to the latest version.
        /// </summary>
        private bool CheckCRMVersion()
        {

            RetrieveVersionRequest crmVersionReq = new RetrieveVersionRequest();
            RetrieveVersionResponse crmVersionResp = (RetrieveVersionResponse)_serviceProxy.Execute(crmVersionReq);

            if (String.CompareOrdinal("7.1.0.0", crmVersionResp.Version) < 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("This sample cannot be run against the current version of CRM.");
                Console.WriteLine("Upgrade your CRM instance to the latest version to run this sample.");
                return false;
            }
        }


        public void ProcessUpsert(String Filename)
        {
            Console.WriteLine("Executing upsert operation.....");
            XmlTextReader tr = new XmlTextReader(Filename);
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(tr);
            XmlNodeList xnlNodes = xdoc.DocumentElement.SelectNodes("/products/product");

            foreach (XmlNode xndNode in xnlNodes)
            {
                String productCode = xndNode.SelectSingleNode("Code").InnerText;
                String productName = xndNode.SelectSingleNode("Name").InnerText;
                String productCategory = xndNode.SelectSingleNode("Category").InnerText;
                String productMake = xndNode.SelectSingleNode("Make").InnerText;

                //use alternate key for product
                Entity productToCreate = new Entity("sample_product", "sample_productcode", productCode);

                productToCreate["sample_name"] = productName;
                productToCreate["sample_category"] = productCategory;
                productToCreate["sample_make"] = productMake;
                UpsertRequest request = new UpsertRequest()
                {
                    Target = productToCreate
                };

                try
                {
                    // Execute UpsertRequest and obtain UpsertResponse. 
                    UpsertResponse response = (UpsertResponse)_serviceProxy.Execute(request);
                    if (response.RecordCreated)
                        Console.WriteLine("New record {0} is created!", productName);
                    else
                        Console.WriteLine("Existing record {0} is updated!", productName);
                }

                // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
                catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
                {
                    throw;
                }

            }
            // Prompts to view the sample_product entity records.
            // If you choose "y", IE will be launched to display the new or updated records.
            if (PromptForView())
            {
                ViewEntityListInBrowser();
            }

        }
        /// <summary>
        /// Deletes the managed solution that was created for this sample.
        /// <param name="prompt"> Indicates whether to prompt the user to delete 
        /// the solution created in this sample.</param>
        /// If you choose "y", the managed solution will be deleted including the 
        /// sample_product entity and all the data in the entity. 
        /// If you choose "n", you must delete the solution manually to return 
        /// your organization to the original state.
        /// </summary>
        public void DeleteUpsertSampleSolution(bool prompt)
        {
            bool deleteSolution = true;
            if (prompt)
            {
                Console.WriteLine("\nDo you want to delete the Upsert Sample solution? (y/n)");
                String answer = Console.ReadLine();

                deleteSolution = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }
            if (deleteSolution)
            {
                Console.WriteLine("Deleting the {0} solution....", "Upsert Sample");
                QueryExpression queryImportedSolution = new QueryExpression
                {
                    EntityName = Solution.EntityLogicalName,
                    ColumnSet = new ColumnSet(new string[] { "solutionid", "friendlyname" }),
                    Criteria = new FilterExpression()
                };
                queryImportedSolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, "UpsertSample");

                Solution ImportedSolution = (Solution)_serviceProxy.RetrieveMultiple(queryImportedSolution).Entities[0];

                _serviceProxy.Delete(Solution.EntityLogicalName, (Guid)ImportedSolution.SolutionId);

                Console.WriteLine("Deleted the {0} solution.", ImportedSolution.FriendlyName);
            }


        }


        // Prompt to view the entity.
        private static bool PromptForView()
        {
            Console.WriteLine("\nDo you want to view the sample product entity records? (y/n)");
            String answer = Console.ReadLine();
            if (answer.StartsWith("y") || answer.StartsWith("Y"))
            { return true; }
            else
            { return false; }
        }

        /// <summary>
        /// Alternate keys may not be active immediately after the UpsertSample 
        /// solution is installed.This method polls the metadata for the sample_product
        /// entity to delay execution of the rest of the sample until the alternate keys are ready.
        /// </summary>
        /// <param name="service">Specifies the service to connect to.</param>
        /// <param name="entityLogicalName">The entity logical name, i.e. sample_product.</param>
        private static void WaitForEntityAndKeysToBeActive(IOrganizationService service, string entityLogicalName)
        {
            EntityQueryExpression entityQuery = new EntityQueryExpression();
            entityQuery.Criteria = new MetadataFilterExpression(LogicalOperator.And)
            {
                Conditions = { { new MetadataConditionExpression("LogicalName", MetadataConditionOperator.Equals, entityLogicalName) } }
            };

            entityQuery.Properties = new MetadataPropertiesExpression("Keys");

            RetrieveMetadataChangesRequest metadataRequest = new RetrieveMetadataChangesRequest() { Query = entityQuery };

            bool allKeysReady = false;
            do
            {
                System.Threading.Thread.Sleep(5000);

                Console.WriteLine("Check for Entity...");
                RetrieveMetadataChangesResponse metadataResponse = (RetrieveMetadataChangesResponse)service.Execute(metadataRequest);

                if (metadataResponse.EntityMetadata.Count > 0)
                {
                    EntityKeyMetadata[] keys = metadataResponse.EntityMetadata[0].Keys;

                    allKeysReady = true;
                    if (keys.Length == 0)
                    {
                        Console.WriteLine("No Keys Found!!!");
                        allKeysReady = false;
                    }
                    else
                    {
                        foreach (var key in keys)
                        {
                            Console.WriteLine("  Key {0} status {1}", key.SchemaName, key.EntityKeyIndexStatus);
                            allKeysReady = allKeysReady && (key.EntityKeyIndexStatus == EntityKeyIndexStatus.Active);
                        }
                    }

                }
            } while (!allKeysReady);

            Console.WriteLine("Waiting 30 seconds for metadata caches to all synchronize...");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(30));
        }

        // Displays the sample product entity records in the browser.
        public void ViewEntityListInBrowser()
        {

            try
            {
                // Get the view ID
                QueryByAttribute query = new QueryByAttribute("savedquery");
                query.AddAttributeValue("returnedtypecode", "sample_product");
                query.AddAttributeValue("name", "Active Sample Products");
                query.ColumnSet = new ColumnSet("savedqueryid", "name");
                query.AddOrder("name", OrderType.Ascending);
                RetrieveMultipleRequest req = new RetrieveMultipleRequest() { Query = query };
                RetrieveMultipleResponse resp = (RetrieveMultipleResponse)_serviceProxy.Execute(req);

                SavedQuery activeSampleProductsView = (SavedQuery)resp.EntityCollection[0];

                String webServiceURL = _serviceProxy.ServiceConfiguration.CurrentServiceEndpoint.Address.Uri.AbsoluteUri;
                String entityInDefaultSolutionUrl = webServiceURL.Replace("XRMServices/2011/Organization.svc",
                String.Format("main.aspx?etn={0}&amp;pagetype=entitylist&amp;viewid=%7b{1}%7d&amp;viewtype=1039", "sample_product", activeSampleProductsView.SavedQueryId));

                // View in IE
                ProcessStartInfo browserProcess = new ProcessStartInfo("iexplore.exe");
                browserProcess.Arguments = entityInDefaultSolutionUrl;
                Process.Start(browserProcess);

            }
            catch (SystemException)
            {
                Console.WriteLine("\nThere was a problem opening Internet Explorer.");
            }


        }
        #endregion How To Sample Code*

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

                ProductUpsertSample app = new ProductUpsertSample();
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
        #endregion Main

    }
}

// </snippetproductupsertsample>