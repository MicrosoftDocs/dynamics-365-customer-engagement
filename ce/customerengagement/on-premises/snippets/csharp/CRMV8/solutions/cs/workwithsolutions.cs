// <snippetworkwithsolutions>


using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.IO;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;


namespace Microsoft.Crm.Sdk.Samples
{

    /// <summary>
    /// Demonstrates common tasks performed using Microsoft Dynamics CRM Solutions
    /// </summary>
    public class WorkWithSolutions
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        OrganizationServiceProxy _serviceProxy;

        private Guid _crmSdkPublisherId;
        private System.String _customizationPrefix;
        private Guid _solutionsSampleSolutionId;        
        System.String ManagedSolutionLocation = @"C:\temp\ManagedSolutionForImportExample.zip";
        String outputDir = @"C:\temp\";


        // Specify which language code to use in the sample. If you are using a language
        // other than US English, you will need to modify this value accordingly.
        // See https://msdn.microsoft.com/library/0h88fahh.aspx
        private const int _languageCode = 1033;


        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Shows how to perform the following tasks with solutions:
        /// - Create a Publisher
        /// - Retrieve the Default Publisher
        /// - Create a Solution
        /// - Retrieve a Solution
        /// - Add an existing Solution Component
        /// - Remove a Solution Component
        /// - Export or Package a Solution
        /// - Install or Upgrade a solution
        /// - Delete a Solution
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
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();


                    //Define a new publisher
                    Publisher _crmSdkPublisher = new Publisher
                    {
                        UniqueName = "sdksamples",
                        FriendlyName = "Microsoft CRM SDK Samples",
                        SupportingWebsiteUrl = "https://msdn.microsoft.com/dynamics/crm/default.aspx",
                        CustomizationPrefix = "sample",
                        EMailAddress = "someone@microsoft.com",
                        Description = "This publisher was created with samples from the Microsoft Dynamics CRM SDK"
                    };

                    //Does publisher already exist?
                    QueryExpression querySDKSamplePublisher = new QueryExpression
                    {
                        EntityName = Publisher.EntityLogicalName,
                        ColumnSet = new ColumnSet("publisherid", "customizationprefix"),
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
                    }
                    //If it doesn't exist, create it
                    if (SDKSamplePublisherResults == null)
                    {
                        _crmSdkPublisherId = _serviceProxy.Create(_crmSdkPublisher);
                        Console.WriteLine(String.Format("Created publisher: {0}.", _crmSdkPublisher.FriendlyName));
                        _customizationPrefix = _crmSdkPublisher.CustomizationPrefix;
                    }




                    // Retrieve the Default Publisher

                    //The default publisher has a constant GUID value;
                    Guid DefaultPublisherId = new Guid("{d21aab71-79e7-11dd-8874-00188b01e34f}");

                    Publisher DefaultPublisher = (Publisher)_serviceProxy.Retrieve(Publisher.EntityLogicalName, DefaultPublisherId, new ColumnSet(new string[] {"friendlyname" }));

                    EntityReference DefaultPublisherReference = new EntityReference
                    {
                        Id = DefaultPublisher.Id,
                        LogicalName = Publisher.EntityLogicalName,
                        Name = DefaultPublisher.FriendlyName
                    };
                    Console.WriteLine("Retrieved the {0}.", DefaultPublisherReference.Name);

                    // Create a Solution
                    //Define a solution
                    Solution solution = new Solution
                    {
                        UniqueName = "samplesolution",
                        FriendlyName = "Sample Solution",
                        PublisherId = new EntityReference(Publisher.EntityLogicalName, _crmSdkPublisherId),
                        Description = "This solution was created by the WorkWithSolutions sample code in the Microsoft Dynamics CRM SDK samples.",
                        Version = "1.0"
                    };

                    //Check whether it already exists
                    QueryExpression queryCheckForSampleSolution = new QueryExpression
                    {
                        EntityName = Solution.EntityLogicalName,
                        ColumnSet = new ColumnSet(),
                        Criteria = new FilterExpression()
                    };
                    queryCheckForSampleSolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, solution.UniqueName);

                    //Create the solution if it does not already exist.
                    EntityCollection querySampleSolutionResults = _serviceProxy.RetrieveMultiple(queryCheckForSampleSolution);
                    Solution SampleSolutionResults = null;
                    if (querySampleSolutionResults.Entities.Count > 0)
                    {
                        SampleSolutionResults = (Solution)querySampleSolutionResults.Entities[0];
                        _solutionsSampleSolutionId = (Guid)SampleSolutionResults.SolutionId;
                    }
                    if (SampleSolutionResults == null)
                    {
                        _solutionsSampleSolutionId = _serviceProxy.Create(solution);
                    }

                    // Retrieve a solution
                    String solutionUniqueName = "samplesolution";
                    QueryExpression querySampleSolution = new QueryExpression
                    {
                        EntityName = Solution.EntityLogicalName,
                        ColumnSet = new ColumnSet(new string[] { "publisherid", "installedon", "version", "versionnumber", "friendlyname" }),
                        Criteria = new FilterExpression()
                    };

                    querySampleSolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, solutionUniqueName);
                    Solution SampleSolution = (Solution)_serviceProxy.RetrieveMultiple(querySampleSolution).Entities[0];

                    // Add an existing Solution Component
                    //Add the Account entity to the solution
                    RetrieveEntityRequest retrieveForAddAccountRequest = new RetrieveEntityRequest()
                    {
                        LogicalName = Account.EntityLogicalName
                    };
                    RetrieveEntityResponse retrieveForAddAccountResponse = (RetrieveEntityResponse)_serviceProxy.Execute(retrieveForAddAccountRequest);
                    AddSolutionComponentRequest addReq = new AddSolutionComponentRequest()
                    {
                        ComponentType = (int)componenttype.Entity,
                        ComponentId = (Guid)retrieveForAddAccountResponse.EntityMetadata.MetadataId,
                        SolutionUniqueName = solution.UniqueName
                    };
                    _serviceProxy.Execute(addReq);

                    // Remove a Solution Component
                    //Remove the Account entity from the solution
                    RetrieveEntityRequest retrieveForRemoveAccountRequest = new RetrieveEntityRequest()
                    {
                        LogicalName = Account.EntityLogicalName
                    };
                    RetrieveEntityResponse retrieveForRemoveAccountResponse = (RetrieveEntityResponse)_serviceProxy.Execute(retrieveForRemoveAccountRequest);

                    RemoveSolutionComponentRequest removeReq = new RemoveSolutionComponentRequest()
                    {
                        ComponentId = (Guid)retrieveForRemoveAccountResponse.EntityMetadata.MetadataId,
                        ComponentType = (int)componenttype.Entity,
                        SolutionUniqueName = solution.UniqueName
                    };
                    _serviceProxy.Execute(removeReq);

                    // Export or package a solution
                    //Export an a solution
                    
                    ExportSolutionRequest exportSolutionRequest = new ExportSolutionRequest();
                    exportSolutionRequest.Managed = false;
                    exportSolutionRequest.SolutionName = solution.UniqueName;

                    ExportSolutionResponse exportSolutionResponse = (ExportSolutionResponse)_serviceProxy.Execute(exportSolutionRequest);

                    byte[] exportXml = exportSolutionResponse.ExportSolutionFile;
                    string filename = solution.UniqueName + ".zip";
                    File.WriteAllBytes(outputDir + filename, exportXml);

                    Console.WriteLine("Solution exported to {0}.", outputDir + filename);

                    // Install or Upgrade a Solution                  
                    
                    byte[] fileBytes = File.ReadAllBytes(ManagedSolutionLocation);

                    ImportSolutionRequest impSolReq = new ImportSolutionRequest()
                    {
                        CustomizationFile = fileBytes
                    };

                    _serviceProxy.Execute(impSolReq);

                    Console.WriteLine("Imported Solution from {0}", ManagedSolutionLocation);

                  
                    // Monitor import success
                    byte[] fileBytesWithMonitoring = File.ReadAllBytes(ManagedSolutionLocation);

                    ImportSolutionRequest impSolReqWithMonitoring = new ImportSolutionRequest()
                    {
                        CustomizationFile = fileBytes,
                        ImportJobId = Guid.NewGuid()
                    };
                    
                    _serviceProxy.Execute(impSolReqWithMonitoring);
                    Console.WriteLine("Imported Solution with Monitoring from {0}", ManagedSolutionLocation);

                    ImportJob job = (ImportJob)_serviceProxy.Retrieve(ImportJob.EntityLogicalName, impSolReqWithMonitoring.ImportJobId, new ColumnSet(new System.String[] { "data", "solutionname" }));
                    

                    System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                    doc.LoadXml(job.Data);

                    String ImportedSolutionName = doc.SelectSingleNode("//solutionManifest/UniqueName").InnerText;
                    String SolutionImportResult = doc.SelectSingleNode("//solutionManifest/result/@result").Value;

                    Console.WriteLine("Report from the ImportJob data");
                    Console.WriteLine("Solution Unique name: {0}", ImportedSolutionName);
                    Console.WriteLine("Solution Import Result: {0}", SolutionImportResult);
                    Console.WriteLine("");

                    // This code displays the results for Global Option sets installed as part of a solution.

                    System.Xml.XmlNodeList optionSets = doc.SelectNodes("//optionSets/optionSet");
                    foreach (System.Xml.XmlNode node in optionSets)
                    {
                        string OptionSetName = node.Attributes["LocalizedName"].Value;
                        string result = node.FirstChild.Attributes["result"].Value;

                        if (result == "success")
                        {
                            Console.WriteLine("{0} result: {1}",OptionSetName, result);
                        }
                        else
                        {
                            string errorCode = node.FirstChild.Attributes["errorcode"].Value;
                            string errorText = node.FirstChild.Attributes["errortext"].Value;

                            Console.WriteLine("{0} result: {1} Code: {2} Description: {3}",OptionSetName, result, errorCode, errorText);
                        }
                    }


                    // Delete a solution

                    QueryExpression queryImportedSolution = new QueryExpression
                    {
                        EntityName = Solution.EntityLogicalName,
                        ColumnSet = new ColumnSet(new string[] { "solutionid", "friendlyname" }),
                        Criteria = new FilterExpression()
                    };


                    queryImportedSolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, ImportedSolutionName);

                    Solution ImportedSolution = (Solution)_serviceProxy.RetrieveMultiple(queryImportedSolution).Entities[0];

                    _serviceProxy.Delete(Solution.EntityLogicalName, (Guid)ImportedSolution.SolutionId);

                    Console.WriteLine("Deleted the {0} solution.", ImportedSolution.FriendlyName);




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
            // Create a managed solution for the Install or upgrade a solution sample

            Guid _tempPublisherId = new Guid();
            System.String _tempCustomizationPrefix = "new";
            Guid _tempSolutionsSampleSolutionId = new Guid();
            System.String _TempGlobalOptionSetName = "_TempSampleGlobalOptionSetName";
            Boolean _publisherCreated = false;
            Boolean _solutionCreated = false;


            //Define a new publisher
            Publisher _crmSdkPublisher = new Publisher
            {
                UniqueName = "sdksamples",
                FriendlyName = "Microsoft CRM SDK Samples",
                SupportingWebsiteUrl = "https://msdn.microsoft.com/dynamics/crm/default.aspx",
                CustomizationPrefix = "sample",
                EMailAddress = "someone@microsoft.com",
                Description = "This publisher was created with samples from the Microsoft Dynamics CRM SDK"
            };

            //Does publisher already exist?
            QueryExpression querySDKSamplePublisher = new QueryExpression
            {
                EntityName = Publisher.EntityLogicalName,
                ColumnSet = new ColumnSet("publisherid", "customizationprefix"),
                Criteria = new FilterExpression()
            };

            querySDKSamplePublisher.Criteria.AddCondition("uniquename", ConditionOperator.Equal, _crmSdkPublisher.UniqueName);
            EntityCollection querySDKSamplePublisherResults = _serviceProxy.RetrieveMultiple(querySDKSamplePublisher);
            Publisher SDKSamplePublisherResults = null;

            //If it already exists, use it
            if (querySDKSamplePublisherResults.Entities.Count > 0)
            {
                SDKSamplePublisherResults = (Publisher)querySDKSamplePublisherResults.Entities[0];
                _tempPublisherId = (Guid)SDKSamplePublisherResults.PublisherId;
                _tempCustomizationPrefix = SDKSamplePublisherResults.CustomizationPrefix;
            }
            //If it doesn't exist, create it
            if (SDKSamplePublisherResults == null)
            {
                _tempPublisherId = _serviceProxy.Create(_crmSdkPublisher);
                _tempCustomizationPrefix = _crmSdkPublisher.CustomizationPrefix;
                _publisherCreated = true;
            }

            //Create a Solution
            //Define a solution
            Solution solution = new Solution
            {
                UniqueName = "samplesolutionforImport",
                FriendlyName = "Sample Solution for Import",
                PublisherId = new EntityReference(Publisher.EntityLogicalName, _tempPublisherId),
                Description = "This solution was created by the WorkWithSolutions sample code in the Microsoft Dynamics CRM SDK samples.",
                Version = "1.0"
            };

            //Check whether it already exists
            QueryExpression querySampleSolution = new QueryExpression
            {
                EntityName = Solution.EntityLogicalName,
                ColumnSet = new ColumnSet(),
                Criteria = new FilterExpression()
            };
            querySampleSolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, solution.UniqueName);

            EntityCollection querySampleSolutionResults = _serviceProxy.RetrieveMultiple(querySampleSolution);
            Solution SampleSolutionResults = null;
            if (querySampleSolutionResults.Entities.Count > 0)
            {
                SampleSolutionResults = (Solution)querySampleSolutionResults.Entities[0];
                _tempSolutionsSampleSolutionId = (Guid)SampleSolutionResults.SolutionId;
            }
            if (SampleSolutionResults == null)
            {
                _tempSolutionsSampleSolutionId = _serviceProxy.Create(solution);
                _solutionCreated = true;
            }

            // Add a solution Component
            OptionSetMetadata optionSetMetadata = new OptionSetMetadata()
            {
                Name = _tempCustomizationPrefix + _TempGlobalOptionSetName,
                DisplayName = new Label("Example Option Set", _languageCode),
                IsGlobal = true,
                OptionSetType = OptionSetType.Picklist,
                Options =
                    {
                        new OptionMetadata(new Label("Option A", _languageCode), null),
                        new OptionMetadata(new Label("Option B", _languageCode), null )
                    }
            };
            CreateOptionSetRequest createOptionSetRequest = new CreateOptionSetRequest
            {
                OptionSet = optionSetMetadata,
                SolutionUniqueName = solution.UniqueName

            };


            _serviceProxy.Execute(createOptionSetRequest);

            //Export an a solution


            ExportSolutionRequest exportSolutionRequest = new ExportSolutionRequest();
            exportSolutionRequest.Managed = true;
            exportSolutionRequest.SolutionName = solution.UniqueName;

            ExportSolutionResponse exportSolutionResponse = (ExportSolutionResponse)_serviceProxy.Execute(exportSolutionRequest);

            byte[] exportXml = exportSolutionResponse.ExportSolutionFile;
            System.IO.Directory.CreateDirectory(outputDir);
            File.WriteAllBytes(ManagedSolutionLocation, exportXml);

            // Delete the solution and the components so it can be installed.

            DeleteOptionSetRequest delOptSetReq = new DeleteOptionSetRequest { Name = (_tempCustomizationPrefix + _TempGlobalOptionSetName).ToLower() };
            _serviceProxy.Execute(delOptSetReq);

            if (_solutionCreated)
            {
                _serviceProxy.Delete(Solution.EntityLogicalName, _tempSolutionsSampleSolutionId);
            }

            if (_publisherCreated)
            {
                _serviceProxy.Delete(Publisher.EntityLogicalName, _tempPublisherId);
            }

            Console.WriteLine("Managed Solution created and copied to {0}", ManagedSolutionLocation);

        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                _serviceProxy.Delete(Solution.EntityLogicalName, _solutionsSampleSolutionId);
                _serviceProxy.Delete(Publisher.EntityLogicalName, _crmSdkPublisherId);
                // Remove the managed solution created by the create required fields code.
                File.Delete(ManagedSolutionLocation);


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

                WorkWithSolutions app = new WorkWithSolutions();
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
        #endregion Main

    }
}

// </snippetworkwithsolutions>