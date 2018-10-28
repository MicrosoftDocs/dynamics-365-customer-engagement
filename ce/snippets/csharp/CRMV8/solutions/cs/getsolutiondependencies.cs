// <snippetgetsolutiondependencies>


using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;

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
    /// Demonstrates how to detect any dependencies prior to deleting a 
    /// solution component.
    /// </summary>
    public class GetSolutionDependencies
    {
        #region Class Level Members
        
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        OrganizationServiceProxy _serviceProxy;

        private Guid _publisherId;
        private const string _primarySolutionName = "PrimarySolution";
        private Guid _primarySolutionId;
        private Guid _secondarySolutionId;
        private const String _prefix = "sample";
        private const String _globalOptionSetName = _prefix + "_exampleoptionset";
        private Guid? _globalOptionSetId;
        private const String _picklistName = _prefix + "_examplepicklist";


        // Specify which language code to use in the sample. If you are using a language
        // other than US English, you will need to modify this value accordingly.
        // See http://msdn.microsoft.com/library/0h88fahh.aspx
        private const int _languageCode = 1033;


        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Shows how to detect dependencies that may cause a managed solution to become
        /// un-deletable.
        /// 
        /// Get all solution components of a solution
        /// For each solution component, list the dependencies upon that component.
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

                    // Grab all Solution Components for a solution.
                    QueryByAttribute componentQuery = new QueryByAttribute
                    {
                        EntityName = SolutionComponent.EntityLogicalName,
                        ColumnSet = new ColumnSet("componenttype", "objectid", "solutioncomponentid", "solutionid"),
                        Attributes = { "solutionid" },

                        // In your code, this value would probably come from another query.
                        Values = { _primarySolutionId }
                    };

                    IEnumerable<SolutionComponent> allComponents =
                        _serviceProxy.RetrieveMultiple(componentQuery).Entities.Cast<SolutionComponent>();

                    foreach (SolutionComponent component in allComponents)
                    {
                        // For each solution component, retrieve all dependencies for the component.
                        RetrieveDependentComponentsRequest dependentComponentsRequest =
                            new RetrieveDependentComponentsRequest
                            {
                                ComponentType = component.ComponentType.Value,
                                ObjectId = component.ObjectId.Value
                            };
                        RetrieveDependentComponentsResponse dependentComponentsResponse =
                            (RetrieveDependentComponentsResponse)_serviceProxy.Execute(dependentComponentsRequest);

                        // If there are no dependent components, we can ignore this component.
                        if (dependentComponentsResponse.EntityCollection.Entities.Any() == false)
                            continue;

                        // If there are dependencies upon this solution component, and the solution
                        // itself is managed, then you will be unable to delete the solution.
                        Console.WriteLine("Found {0} dependencies for Component {1} of type {2}",
                            dependentComponentsResponse.EntityCollection.Entities.Count,
                            component.ObjectId.Value,
                            component.ComponentType.Value
                            );
                        //A more complete report requires more code
                        foreach (Dependency d in dependentComponentsResponse.EntityCollection.Entities)
                        {
                            DependencyReport(d);
                        }
                    }

                 //Find out if any dependencies on a  specific global option set would prevent it from being deleted
                    // Use the RetrieveOptionSetRequest message to retrieve  
                    // a global option set by it's name.
                    RetrieveOptionSetRequest retrieveOptionSetRequest =
                        new RetrieveOptionSetRequest
                        {
                         Name = _globalOptionSetName
                        };

                    // Execute the request.
                    RetrieveOptionSetResponse retrieveOptionSetResponse =
                        (RetrieveOptionSetResponse)_serviceProxy.Execute(
                        retrieveOptionSetRequest);
                    _globalOptionSetId = retrieveOptionSetResponse.OptionSetMetadata.MetadataId;
                    if (_globalOptionSetId != null)
                    { 
                     //Use the global OptionSet MetadataId with the appropriate componenttype
                     // to call RetrieveDependenciesForDeleteRequest
                     RetrieveDependenciesForDeleteRequest retrieveDependenciesForDeleteRequest = new RetrieveDependenciesForDeleteRequest 
                    { 
                     ComponentType = (int)componenttype.OptionSet,
                     ObjectId = (Guid)_globalOptionSetId
                    };

                     RetrieveDependenciesForDeleteResponse retrieveDependenciesForDeleteResponse =
                      (RetrieveDependenciesForDeleteResponse)_serviceProxy.Execute(retrieveDependenciesForDeleteRequest);
                     Console.WriteLine("");
                     foreach (Dependency d in retrieveDependenciesForDeleteResponse.EntityCollection.Entities)
                     {

                      if (d.DependentComponentType.Value == 2)//Just testing for Attributes
                      {
                       String attributeLabel = "";
                       RetrieveAttributeRequest retrieveAttributeRequest = new RetrieveAttributeRequest
                       {
                        MetadataId = (Guid)d.DependentComponentObjectId
                       };
                       RetrieveAttributeResponse retrieveAttributeResponse = (RetrieveAttributeResponse)_serviceProxy.Execute(retrieveAttributeRequest);

                       AttributeMetadata attmet = retrieveAttributeResponse.AttributeMetadata;

                       attributeLabel = attmet.DisplayName.UserLocalizedLabel.Label;
                      
                        Console.WriteLine("An {0} named {1} will prevent deleting the {2} global option set.", 
                       (componenttype)d.DependentComponentType.Value, 
                       attributeLabel, 
                       _globalOptionSetName);
                      }
                     }                 
                    }


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
        /// Shows how to get a more friendly message based on information within the dependency
        /// <param name="dependency">A Dependency returned from the RetrieveDependentComponents message</param>
        /// </summary> 
     public void DependencyReport(Dependency dependency)
        {
      //These strings represent parameters for the message.
         String dependentComponentName = "";
         String dependentComponentTypeName = "";
         String dependentComponentSolutionName = "";
         String requiredComponentName = "";
         String requiredComponentTypeName = "";
         String requiredComponentSolutionName = "";

      //The ComponentType global Option Set contains options for each possible component.
         RetrieveOptionSetRequest componentTypeRequest = new RetrieveOptionSetRequest
         {
          Name = "componenttype"
         };

         RetrieveOptionSetResponse componentTypeResponse = (RetrieveOptionSetResponse)_serviceProxy.Execute(componentTypeRequest);
         OptionSetMetadata componentTypeOptionSet = (OptionSetMetadata)componentTypeResponse.OptionSetMetadata;
      // Match the Component type with the option value and get the label value of the option.
         foreach (OptionMetadata opt in componentTypeOptionSet.Options)
         {
          if (dependency.DependentComponentType.Value == opt.Value)
          {
           dependentComponentTypeName = opt.Label.UserLocalizedLabel.Label;
          }
          if (dependency.RequiredComponentType.Value == opt.Value)
          {
           requiredComponentTypeName = opt.Label.UserLocalizedLabel.Label;
          }
         }
      //The name or display name of the compoent is retrieved in different ways depending on the component type
         dependentComponentName = getComponentName(dependency.DependentComponentType.Value, (Guid)dependency.DependentComponentObjectId);
         requiredComponentName = getComponentName(dependency.RequiredComponentType.Value, (Guid)dependency.RequiredComponentObjectId);

      // Retrieve the friendly name for the dependent solution.
         Solution dependentSolution = (Solution)_serviceProxy.Retrieve
          (
           Solution.EntityLogicalName,
           (Guid)dependency.DependentComponentBaseSolutionId,
           new ColumnSet("friendlyname")
          );
         dependentComponentSolutionName = dependentSolution.FriendlyName;
         
      // Retrieve the friendly name for the required solution.
         Solution requiredSolution = (Solution)_serviceProxy.Retrieve
           (
            Solution.EntityLogicalName,
            (Guid)dependency.RequiredComponentBaseSolutionId,
            new ColumnSet("friendlyname")
           );
         requiredComponentSolutionName = requiredSolution.FriendlyName;

      //Display the message
          Console.WriteLine("The {0} {1} in the {2} depends on the {3} {4} in the {5} solution.",
          dependentComponentName,
          dependentComponentTypeName,
          dependentComponentSolutionName,
          requiredComponentName,
          requiredComponentTypeName,
          requiredComponentSolutionName);
        }

     // The name or display name of the component depends on the type of component.
        public String getComponentName(int ComponentType, Guid ComponentId)
        {
         String name = "";

         switch (ComponentType)
         {
           // A separate method is required for each type of component
          case (int)componenttype.Attribute:
           name = getAttributeInformation(ComponentId);
           break;
          case (int)componenttype.OptionSet:
           name = getGlobalOptionSetName(ComponentId);
           break;
          default:
           name = "not implemented";
           break;
         }

         return name;
        
        }

     // Retrieve the display name and parent entity information about an attribute solution component.
        public string getAttributeInformation(Guid id)
        {
         String attributeInformation = "";
         RetrieveAttributeRequest req = new RetrieveAttributeRequest
         {
          MetadataId = id
         };
         RetrieveAttributeResponse resp = (RetrieveAttributeResponse)_serviceProxy.Execute(req);

         AttributeMetadata attmet = resp.AttributeMetadata;

         attributeInformation = attmet.EntityLogicalName + " : " + attmet.DisplayName.UserLocalizedLabel.Label;


         return attributeInformation;
        }
     //Retrieve the name of a global Option set
        public String getGlobalOptionSetName(Guid id)
        {
         String name = "";
          RetrieveOptionSetRequest req = new RetrieveOptionSetRequest
          {
           MetadataId = id
          };
          RetrieveOptionSetResponse resp = (RetrieveOptionSetResponse)_serviceProxy.Execute(req);
          OptionSetMetadataBase os = (OptionSetMetadataBase)resp.OptionSetMetadata;
          name = os.DisplayName.UserLocalizedLabel.Label;      
         return name;
        }

        /// <summary>
        /// This method creates any entity records that this sample requires.
        /// Create a publisher
        /// Create a new solution, "Primary"
        /// Create a Global Option Set in solution "Primary"
        /// Export the "Primary" solution, setting it to Protected
        /// Delete the option set and solution
        /// Import the "Primary" solution, creating a managed solution in CRM.
        /// Create a new solution, "Secondary"
        /// Create an attribute in "Secondary" that references the Global Option Set
        /// </summary>
        public void CreateRequiredRecords()
        {
            //Create the publisher that will "own" the two solutions
            Publisher publisher = new Publisher
            {
                UniqueName = "examplepublisher",
                FriendlyName = "An Example Publisher",
                Description = "This is an example publisher",
                CustomizationPrefix = _prefix
            };
            _publisherId = _serviceProxy.Create(publisher);
            //Create the primary solution - note that we are not creating it 
            //as a managed solution as that can only be done when exporting the solution.
            Solution primarySolution = new Solution
            {
                Version = "1.0",
                FriendlyName = "Primary Solution",
                PublisherId = new EntityReference(Publisher.EntityLogicalName, _publisherId),
                UniqueName = _primarySolutionName
            };
            _primarySolutionId = _serviceProxy.Create(primarySolution);
            //Now, create the Global Option Set and associate it to the solution.
            OptionSetMetadata optionSetMetadata = new OptionSetMetadata()
            {
                Name = _globalOptionSetName,
                DisplayName = new Label("Example Option Set", _languageCode),
                IsGlobal = true,
                OptionSetType = OptionSetType.Picklist,
                Options =
            {
                new OptionMetadata(new Label("Option 1", _languageCode), 1),
                new OptionMetadata(new Label("Option 2", _languageCode), 2)
            }
            };
            CreateOptionSetRequest createOptionSetRequest = new CreateOptionSetRequest
            {
                OptionSet = optionSetMetadata                
            };

            createOptionSetRequest.SolutionUniqueName = _primarySolutionName;
            _serviceProxy.Execute(createOptionSetRequest);
            //Export the solution as managed so that we can later import it.
            ExportSolutionRequest exportRequest = new ExportSolutionRequest
            {
                Managed = true,
                SolutionName = _primarySolutionName
            };
            ExportSolutionResponse exportResponse =
                (ExportSolutionResponse)_serviceProxy.Execute(exportRequest);
            // Delete the option set previous created, so it can be imported under the
            // managed solution.
            DeleteOptionSetRequest deleteOptionSetRequest = new DeleteOptionSetRequest
            {
                Name = _globalOptionSetName
            };
            _serviceProxy.Execute(deleteOptionSetRequest);
            // Delete the previous primary solution, so it can be imported as managed.
            _serviceProxy.Delete(Solution.EntityLogicalName, _primarySolutionId);
            _primarySolutionId = Guid.Empty;

            // Re-import the solution as managed.
            ImportSolutionRequest importRequest = new ImportSolutionRequest
            {
                CustomizationFile = exportResponse.ExportSolutionFile
            };
            _serviceProxy.Execute(importRequest);

            // Retrieve the solution from CRM in order to get the new id.
            QueryByAttribute primarySolutionQuery = new QueryByAttribute
            {
                EntityName = Solution.EntityLogicalName,
                ColumnSet = new ColumnSet("solutionid"),
                Attributes = { "uniquename" },
                Values = { _primarySolutionName }
            };
            _primarySolutionId = _serviceProxy.RetrieveMultiple(primarySolutionQuery).Entities
                .Cast<Solution>().FirstOrDefault().SolutionId.GetValueOrDefault();


            // Create a secondary solution.
            Solution secondarySolution = new Solution
            {
                Version = "1.0",
                FriendlyName = "Secondary Solution",
                PublisherId = new EntityReference(Publisher.EntityLogicalName, _publisherId),
                UniqueName = "SecondarySolution"
            };
            _secondarySolutionId = _serviceProxy.Create(secondarySolution);

            // Create a Picklist attribute in the secondary solution linked to the option set in the
            // primary - see WorkWithOptionSets.cs for more on option sets.
            PicklistAttributeMetadata picklistMetadata = new PicklistAttributeMetadata
            {
                SchemaName = _picklistName,
                LogicalName = _picklistName,
                DisplayName = new Label("Example Picklist", _languageCode),
				RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                OptionSet = new OptionSetMetadata
                {
                    IsGlobal = true,
                    Name = _globalOptionSetName
                }

            };

            CreateAttributeRequest createAttributeRequest = new CreateAttributeRequest
            {
                EntityName = Contact.EntityLogicalName,
                Attribute = picklistMetadata
            };
            createAttributeRequest["SolutionUniqueName"] = secondarySolution.UniqueName;
            _serviceProxy.Execute(createAttributeRequest);
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

                DeleteAttributeRequest deleteAttributeRequest = new DeleteAttributeRequest
                {
                    EntityLogicalName = Contact.EntityLogicalName,
                    LogicalName = _picklistName
                };
                _serviceProxy.Execute(deleteAttributeRequest);
                _serviceProxy.Delete(Solution.EntityLogicalName, _primarySolutionId);
                _serviceProxy.Delete(Solution.EntityLogicalName, _secondarySolutionId);
                _serviceProxy.Delete(Publisher.EntityLogicalName, _publisherId);


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

                GetSolutionDependencies app = new GetSolutionDependencies();
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

// </snippetgetsolutiondependencies>