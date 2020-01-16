// <snippetworkwithglobaloptionsets>


using System;
using System.Linq;
using System.Xml.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;


namespace Microsoft.Crm.Sdk.Samples
{

    /// <summary>
    /// Create a global option set.
    /// Set the options for that option set.
    /// Create a new reference to that option set on an entity.
    /// Update the option set's properties.
    /// Check the global option set for dependencies.
    /// Delete the option set.
    /// </summary>
    public class WorkwithGlobalOptionSets
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;
        
        // Specify which language code to use in the sample. If you are using a language
        // other than US English, you will need to modify this value accordingly.
        // See http://msdn.microsoft.com/library/0h88fahh.aspx
        private const int _languageCode = 1033;

        // Specify the option set's schema name is used in many operations related to
        // global option sets.
        private const string _globalOptionSetName = "sample_exampleoptionset";

        // Define the IDs needed for this sample.
        private Guid _optionSetId;
        private int _insertedOptionValue;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create a global option set.
        /// Set the options for that option set.
        /// Create a new reference to that option set on an entity.
        /// Update the option set's properties.
        /// Check the global option set for dependencies.
        /// Delete the option set.
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

                    #region How to create global option set
                    // Define the request object and pass to the service.
                    CreateOptionSetRequest createOptionSetRequest = new CreateOptionSetRequest
                    {
                        // Create a global option set (OptionSetMetadata).
                        OptionSet = new OptionSetMetadata
                        {
                            Name = _globalOptionSetName,
                            DisplayName = new Label("Example Option Set", _languageCode),
                            IsGlobal = true,
                            OptionSetType = OptionSetType.Picklist,
                            Options = 
                        {
                            new OptionMetadata(new Label("Open", _languageCode), null),
                            new OptionMetadata(new Label("Suspended", _languageCode), null),
                            new OptionMetadata(new Label("Cancelled", _languageCode), null),
                            new OptionMetadata(new Label("Closed", _languageCode), null)
                        }
                        }
                    };

                    // Execute the request.
                    CreateOptionSetResponse optionsResp =
                        (CreateOptionSetResponse)_serviceProxy.Execute(createOptionSetRequest);

                    #endregion How to create global option set

                    // Store the option set's id as it will be needed to find all the
                    // dependent components.
                    _optionSetId = optionsResp.OptionSetId;
                    Console.WriteLine("The global option set has been created.");

                    #region How to create a picklist linked to the global option set
                    // Create a Picklist linked to the option set.
                    // Specify which entity will own the picklist, and create it.
                    CreateAttributeRequest createRequest = new CreateAttributeRequest
                    {
                        EntityName = Contact.EntityLogicalName,
                        Attribute = new PicklistAttributeMetadata
                        {
                            SchemaName = "sample_examplepicklist",
                            LogicalName = "sample_examplepicklist",
                            DisplayName = new Label("Example Picklist", _languageCode),
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),

                            // In order to relate the picklist to the global option set, be sure
                            // to specify the two attributes below appropriately.
                            // Failing to do so will lead to errors.
                            OptionSet = new OptionSetMetadata
                            {
                                IsGlobal = true,
                                Name = _globalOptionSetName
                            }
                        }
                    };

                    _serviceProxy.Execute(createRequest);
                    Console.WriteLine("Referring picklist attribute created.");
                    #endregion How to create a picklist linked to the global option set

                    #region How to update a global option set
                    // Use UpdateOptionSetRequest to update the basic information of an option
                    // set. Updating option set values requires different messages (see below).
                    UpdateOptionSetRequest updateOptionSetRequest = new UpdateOptionSetRequest
                    {
                        OptionSet = new OptionSetMetadata
                        {
                            DisplayName = new Label("Updated Option Set", _languageCode),
                            Name = _globalOptionSetName,
                            IsGlobal = true
                        }
                    };

                    _serviceProxy.Execute(updateOptionSetRequest);

                    //Publish the OptionSet
                    PublishXmlRequest pxReq1 = new PublishXmlRequest { ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName) };
                    _serviceProxy.Execute(pxReq1);
                    Console.WriteLine("Option Set display name changed.");
                    #endregion How to update a global option set properties

                    #region How to insert a new option item in a global option set
                    // Use InsertOptionValueRequest to insert a new option into a 
                    // global option set.
                    InsertOptionValueRequest insertOptionValueRequest =
                        new InsertOptionValueRequest
                        {
                            OptionSetName = _globalOptionSetName,
                            Label = new Label("New Picklist Label", _languageCode)
                        };

                    // Execute the request and store the newly inserted option value 
                    // for cleanup, used in the later part of this sample.
                    _insertedOptionValue = ((InsertOptionValueResponse)_serviceProxy.Execute(
                        insertOptionValueRequest)).NewOptionValue;

                    //Publish the OptionSet
                    PublishXmlRequest pxReq2 = new PublishXmlRequest { ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName) };
                    _serviceProxy.Execute(pxReq2);
                    Console.WriteLine("Created {0} with the value of {1}.",
                        insertOptionValueRequest.Label.LocalizedLabels[0].Label,
                        _insertedOptionValue);
                    #endregion How to insert a new option item in a global option set

                    #region How to retrieve a global option set by it's name
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

                    Console.WriteLine("Retrieved {0}.",
                        retrieveOptionSetRequest.Name);

                    // Access the retrieved OptionSetMetadata.
                    OptionSetMetadata retrievedOptionSetMetadata =
                        (OptionSetMetadata)retrieveOptionSetResponse.OptionSetMetadata;

                    // Get the current options list for the retrieved attribute.
                    OptionMetadata[] optionList =
                        retrievedOptionSetMetadata.Options.ToArray();
                    #endregion How to retrieve a global option set by it's name

                    #region How to update an option item in a picklist
                    // In order to change labels on option set values (or delete) option set
                    // values, you must use UpdateOptionValueRequest 
                    // (or DeleteOptionValueRequest).
                    UpdateOptionValueRequest updateOptionValueRequest =
                        new UpdateOptionValueRequest
                        {
                            OptionSetName = _globalOptionSetName,
                            // Update the second option value.
                            Value = optionList[1].Value.Value,
                            Label = new Label("Updated Option 1", _languageCode)
                        };

                    _serviceProxy.Execute(updateOptionValueRequest);

                    //Publish the OptionSet
                    PublishXmlRequest pxReq3 = new PublishXmlRequest { ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName) };
                    _serviceProxy.Execute(pxReq3);

                    

                    Console.WriteLine("Option Set option label changed.");
                    #endregion How to update an option item in a picklist

                    #region How to change the order of options of a global option set
                    // Change the order of the original option's list.
                    // Use the OrderBy (OrderByDescending) linq function to sort options in  
                    // ascending (descending) order according to label text.
                    // For ascending order use this:
                    var updateOptionList =
                        optionList.OrderBy(x => x.Label.LocalizedLabels[0].Label).ToList();

                    // For descending order use this:
                    // var updateOptionList =
                    //      optionList.OrderByDescending(
                    //      x => x.Label.LocalizedLabels[0].Label).ToList();

                    // Create the request.
                    OrderOptionRequest orderOptionRequest = new OrderOptionRequest
                    {
                        // Set the properties for the request.
                        OptionSetName = _globalOptionSetName,
                        // Set the changed order using Select linq function 
                        // to get only values in an array from the changed option list.
                        Values = updateOptionList.Select(x => x.Value.Value).ToArray()
                    };

                    // Execute the request
                    _serviceProxy.Execute(orderOptionRequest);

                    //Publish the OptionSet
                    PublishXmlRequest pxReq4 = new PublishXmlRequest { ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName) };
                    _serviceProxy.Execute(pxReq4);
                    Console.WriteLine("Option Set option order changed");
                    #endregion How to change the order of options of a global option set

                    #region How to retrieve all global option sets
                    // Use RetrieveAllOptionSetsRequest to retrieve all global option sets.
                    // Create the request.
                    RetrieveAllOptionSetsRequest retrieveAllOptionSetsRequest =
                        new RetrieveAllOptionSetsRequest();

                    // Execute the request
                    RetrieveAllOptionSetsResponse retrieveAllOptionSetsResponse =
                        (RetrieveAllOptionSetsResponse)_serviceProxy.Execute(
                        retrieveAllOptionSetsRequest);

                    // Now you can use RetrieveAllOptionSetsResponse.OptionSetMetadata property to 
                    // work with all retrieved option sets.
                    if (retrieveAllOptionSetsResponse.OptionSetMetadata.Count() > 0)
                    {
                        Console.WriteLine("All the global option sets retrieved as below:");
                        int count = 1;
                        foreach (OptionSetMetadataBase optionSetMetadata in
                            retrieveAllOptionSetsResponse.OptionSetMetadata)
                        {
                            Console.WriteLine("{0} {1}", count++,
                                (optionSetMetadata.DisplayName.LocalizedLabels.Count >0)? optionSetMetadata.DisplayName.LocalizedLabels[0].Label : String.Empty);
                        }
                    }
                    #endregion How to retrieve all global option sets



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
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to 
        /// delete the records created in this sample.</param>
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
                #region How to delete a option from a option set
                // Use the DeleteOptionValueRequest message 
                // to remove the newly inserted label.
                DeleteOptionValueRequest deleteOptionValueRequest =
                    new DeleteOptionValueRequest
                {
                    OptionSetName = _globalOptionSetName,
                    Value = _insertedOptionValue
                };

                // Execute the request.
                _serviceProxy.Execute(deleteOptionValueRequest);

                Console.WriteLine("Option Set option removed.");
                #endregion How to delete a option from a option set

                #region How to delete attribute
                // Create the request to see which components have a dependency on the
                // global option set.
                RetrieveDependentComponentsRequest dependencyRequest =
                    new RetrieveDependentComponentsRequest
                    {
                        ObjectId = _optionSetId,
                        ComponentType = (int)componenttype.OptionSet
                    };

                RetrieveDependentComponentsResponse dependencyResponse =
                    (RetrieveDependentComponentsResponse)_serviceProxy.Execute(
                    dependencyRequest);

                // Here you would check the dependencyResponse.EntityCollection property
                // and act as appropriate. However, we know there is exactly one 
                // dependency so this example deals with it directly and deletes 
                // the previously created attribute.
                DeleteAttributeRequest deleteAttributeRequest =
                    new DeleteAttributeRequest
                {
                    EntityLogicalName = Contact.EntityLogicalName,
                    LogicalName = "sample_examplepicklist"
                };

                _serviceProxy.Execute(deleteAttributeRequest);
              
                Console.WriteLine("Referring attribute deleted.");
                #endregion How to delete attribute

                #region How to delete global option set
                
                // Finally, delete the global option set. Attempting this before deleting
                // the picklist above will result in an exception being thrown.
                DeleteOptionSetRequest deleteRequest = new DeleteOptionSetRequest
                {
                    Name = _globalOptionSetName
                };

                _serviceProxy.Execute(deleteRequest);
                Console.WriteLine("Global Option Set deleted");
                #endregion How to delete global option set
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

                WorkwithGlobalOptionSets app = new WorkwithGlobalOptionSets();
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

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe = 
                        ex.InnerException
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

// </snippetworkwithglobaloptionsets>