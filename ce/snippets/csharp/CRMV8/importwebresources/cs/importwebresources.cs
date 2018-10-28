// <snippetimportwebresources>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Crm.Sdk.Messages;

//These references are required for this sample
using System.IO;
using System.Xml.Linq;
using System.Linq;


namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to import Web Resources.</summary>
    /// <remarks>
    /// The Web Resources will be defined in an XML document.</remarks>
    public class ImportWebResources
    {
        #region Class Level Members


        private OrganizationServiceProxy _serviceProxy;

        //Define Ids needed in this sample
        private Guid _crmSdkPublisherId;
        private System.String _customizationPrefix;
        private Boolean _createdPublisher = false;
        private Guid _importWebResourcesSampleSolutionId;
        private System.String _ImportWebResourcesSolutionUniqueName;
        private System.Guid[] _webResourceIds = new System.Guid[5];




        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// basic create, retrieve, update, and delete entity operations are performed.
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
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri, serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();


                    //Read the descriptive data from the XML file
                    XDocument xmlDoc = XDocument.Load("../../ImportJob.xml");

                    //Create a collection of anonymous type references to each of the Web Resources
                    var webResources = from webResource in xmlDoc.Descendants("webResource")
                                       select new
                                       {
                                           path = webResource.Element("path").Value,
                                           displayName = webResource.Element("displayName").Value,
                                           description = webResource.Element("description").Value,
                                           name = webResource.Element("name").Value,
                                           type = webResource.Element("type").Value
                                       };

                    // Loop through the collection creating Web Resources
                    int counter = 0;
                    foreach (var webResource in webResources)
                    {
                        //Set the Web Resource properties
                        WebResource wr = new WebResource
                        {
                            Content = getEncodedFileContents(@"../../" + webResource.path),
                            DisplayName = webResource.displayName,
                            Description = webResource.description,
                            Name = _customizationPrefix + webResource.name,
                            LogicalName = WebResource.EntityLogicalName,
                            WebResourceType = new OptionSetValue(Int32.Parse(webResource.type))
                        };

                        // Using CreateRequest because we want to add an optional parameter
                        CreateRequest cr = new CreateRequest
                        {
                            Target = wr
                        };
                        //Set the SolutionUniqueName optional parameter so the Web Resources will be
                        // created in the context of a specific solution.
                        cr.Parameters.Add("SolutionUniqueName", _ImportWebResourcesSolutionUniqueName);

                        CreateResponse cresp = (CreateResponse)_serviceProxy.Execute(cr);
                        // Capture the id values for the Web Resources so the sample can delete them.
                        _webResourceIds[counter] = cresp.id;
                        counter++;
                        Console.WriteLine("Created Web Resource: {0}", webResource.displayName);
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

        //Encodes the Web Resource File
        static public string getEncodedFileContents(String pathToFile)
        {
            FileStream fs = new FileStream(pathToFile, FileMode.Open, FileAccess.Read);
            byte[] binaryData = new byte[fs.Length];
            long bytesRead = fs.Read(binaryData, 0, (int)fs.Length);
            fs.Close();
            return System.Convert.ToBase64String(binaryData, 0, binaryData.Length);
        }

        /// <summary>
        /// This method creates a publisher and a solution to use when adding the Web resources.
        /// </summary>
        public void CreateRequiredRecords()
        {

            //Define a new publisher
            Publisher _crmSdkPublisher = new Publisher
            {
                UniqueName = "microsoftdynamicscrmsdksamplesimportwebresourcessample",
                FriendlyName = "Microsoft Dynamics CRM SDK Samples Import Web Resources Sample",
                SupportingWebsiteUrl = "http://msdn.microsoft.com/dynamics/crm/default.aspx",
                CustomizationPrefix = "sample",
                EMailAddress = "someone@microsoft.com",
                Description = "This publisher is used by the Import Web Resources sample from the Dynamics 365 developer documentation."
            };

            //Does publisher already exist?
            QueryExpression querySDKSamplePublisher = new QueryExpression
            {
                EntityName = Publisher.EntityLogicalName, 
                ColumnSet = new ColumnSet("publisherid", "customizationprefix", "friendlyname", "isreadonly"),
                Criteria = new FilterExpression()
            };

            querySDKSamplePublisher.Criteria.AddCondition("uniquename", ConditionOperator.Equal, _crmSdkPublisher.UniqueName);
            EntityCollection querySDKSamplePublisherResults = _serviceProxy.RetrieveMultiple(querySDKSamplePublisher);
            Publisher SDKSamplePublisherResults = null;

            //If it already exists, use it
            if (querySDKSamplePublisherResults.Entities.Count > 0)
            {
                SDKSamplePublisherResults = (Publisher)querySDKSamplePublisherResults.Entities[0];               
                _crmSdkPublisherId = (Guid)SDKSamplePublisherResults.PublisherId;
                _customizationPrefix = SDKSamplePublisherResults.CustomizationPrefix;

                Console.WriteLine("Using existing publisher: {0}", SDKSamplePublisherResults.FriendlyName);
            }
            //If it doesn't exist, create it
            if (SDKSamplePublisherResults == null)
            {
                _crmSdkPublisherId = _serviceProxy.Create(_crmSdkPublisher);
                Console.WriteLine(String.Format("Created publisher: {0}.", _crmSdkPublisher.FriendlyName));
                _customizationPrefix = _crmSdkPublisher.CustomizationPrefix;
                // Set this flag to delete the publisher if this sample created it.
                _createdPublisher = true;
                Console.WriteLine("Created new publisher: {0}", _crmSdkPublisher.FriendlyName);
            }

            // Create a Solution
            //Define a solution
            Solution solution = new Solution
            {
                UniqueName = "ImportWebResourcesSample",
                FriendlyName = "Import Web Resources Sample Solution",
                PublisherId = new EntityReference(Publisher.EntityLogicalName, _crmSdkPublisherId),
                Description = "This solution was created by the ImportWebResources sample code in the Microsoft Dynamics CRM SDK samples.",
                Version = "1.0"
            };
            // Save save this variable  to use when creating the Web resources in the context of this solution.
            _ImportWebResourcesSolutionUniqueName = solution.UniqueName;

            //Check whether it already exists
            QueryExpression queryCheckForSampleSolution = new QueryExpression
            {
                EntityName = Solution.EntityLogicalName,
                ColumnSet = new ColumnSet("friendlyname"),
                Criteria = new FilterExpression()
            };
            queryCheckForSampleSolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, solution.UniqueName);

            //Create the solution if it does not already exist.
            EntityCollection querySampleSolutionResults = _serviceProxy.RetrieveMultiple(queryCheckForSampleSolution);
            Solution SampleSolutionResults = null;
            if (querySampleSolutionResults.Entities.Count > 0)
            {
                SampleSolutionResults = (Solution)querySampleSolutionResults.Entities[0];
                _importWebResourcesSampleSolutionId = (Guid)SampleSolutionResults.SolutionId;
                Console.WriteLine("Using existing solution: {0}", SampleSolutionResults.FriendlyName);
            }
            if (SampleSolutionResults == null)
            {
                _importWebResourcesSampleSolutionId = _serviceProxy.Create(solution);
                Console.WriteLine("Created new solution: {0}", solution.FriendlyName);
            }



        }

        /// <summary>
        /// Deletes the custom entity record that was created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the entity created in this sample.</param>
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
                //delete Web Resources
                foreach (Guid id in _webResourceIds)
                {
                    _serviceProxy.Delete(WebResource.EntityLogicalName, id);
                }
                Console.WriteLine("Web Resource records have been deleted.");
                //Delete Solution

                _serviceProxy.Delete(Solution.EntityLogicalName, _importWebResourcesSampleSolutionId);
                Console.WriteLine("Solution has been deleted.");

                //
                if (_createdPublisher)
                {
                    // Delete the publisher
                    _serviceProxy.Delete(Publisher.EntityLogicalName, _crmSdkPublisherId);
                    Console.WriteLine("Publisher has been deleted.");
                }

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

                ImportWebResources app = new ImportWebResources();
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

// </snippetimportwebresources>