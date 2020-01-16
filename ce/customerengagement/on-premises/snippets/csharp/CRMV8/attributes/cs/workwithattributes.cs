//<snippetWorkWithAttributes>
using System;
using System.Linq;
using System.Xml.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Collections.Generic;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to create, retrieve, update and delete attribute.
    /// </summary>
    public class WorkWithAttributes
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        OrganizationServiceProxy _serviceProxy;

        public Version _productVersion = null;

        // Create storage for new attributes being created
        public List<AttributeMetadata> addedAttributes;

        // Specify which language code to use in the sample. If you are using a language
        // other than US English, you will need to modify this value accordingly.
        // See https://msdn.microsoft.com/library/0h88fahh.aspx
        public const int _languageCode = 1033;

        // Define the IDs/variables needed for this sample.
        public int _insertedStatusValue;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Create few types of attributes.
        /// Insert status in the existing status list.
        /// Retrieve attribute.
        /// Update attribute.
        /// Update existing state value.
        /// Optionally delete/revert any attributes 
        /// that were created/changed for this sample.
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

                    _productVersion = Version.Parse(((RetrieveVersionResponse)_serviceProxy.Execute(new RetrieveVersionRequest())).Version);

                    //<snippetWorkWithAttributes1>
                    #region How to create attributes
                    //<snippetWorkWithAttributes2>
                    // Create storage for new attributes being created
                    addedAttributes = new List<AttributeMetadata>();

                    // Create a boolean attribute
                    BooleanAttributeMetadata boolAttribute = new BooleanAttributeMetadata
                    {
                        // Set base properties
                        SchemaName = "new_Boolean",
                        LogicalName = "new_boolean",
                        DisplayName = new Label("Sample Boolean", _languageCode),
                        RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                        Description = new Label("Boolean Attribute", _languageCode),
                        // Set extended properties
                        OptionSet = new BooleanOptionSetMetadata(
                            new OptionMetadata(new Label("True", _languageCode), 1),
                            new OptionMetadata(new Label("False", _languageCode), 0)
                            )
                    };

                    // Add to list
                    addedAttributes.Add(boolAttribute);

                    // Create a date time attribute
                    DateTimeAttributeMetadata dtAttribute = new DateTimeAttributeMetadata
                    {
                        // Set base properties
                        SchemaName = "new_Datetime",
                        LogicalName = "new_datetime",
                        DisplayName = new Label("Sample DateTime", _languageCode),
                        RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                        Description = new Label("DateTime Attribute", _languageCode),
                        // Set extended properties
                        Format = DateTimeFormat.DateOnly,
                        ImeMode = ImeMode.Disabled
                    };

                    // Add to list
                    addedAttributes.Add(dtAttribute);

                    // Create a decimal attribute	
                    DecimalAttributeMetadata decimalAttribute = new DecimalAttributeMetadata
                    {
                        // Set base properties
                        SchemaName = "new_Decimal",
                        LogicalName = "new_decimal",
                        DisplayName = new Label("Sample Decimal", _languageCode),
                        RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                        Description = new Label("Decimal Attribute", _languageCode),
                        // Set extended properties
                        MaxValue = 100,
                        MinValue = 0,
                        Precision = 1
                    };

                    // Add to list
                    addedAttributes.Add(decimalAttribute);

                    // Create a integer attribute	
                    IntegerAttributeMetadata integerAttribute = new IntegerAttributeMetadata
                    {
                        // Set base properties
                        SchemaName = "new_Integer",
                        LogicalName = "new_integer",
                        DisplayName = new Label("Sample Integer", _languageCode),
                        RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                        Description = new Label("Integer Attribute", _languageCode),
                        // Set extended properties
                        Format = IntegerFormat.None,
                        MaxValue = 100,
                        MinValue = 0
                    };

                    // Add to list
                    addedAttributes.Add(integerAttribute);

                    // Create a memo attribute 
                    MemoAttributeMetadata memoAttribute = new MemoAttributeMetadata
                    {
                        // Set base properties
                        SchemaName = "new_Memo",
                        LogicalName = "new_memo",
                        DisplayName = new Label("Sample Memo", _languageCode),
                        RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                        Description = new Label("Memo Attribute", _languageCode),
                        // Set extended properties
                        Format = StringFormat.TextArea,
                        ImeMode = ImeMode.Disabled,
                        MaxLength = 500
                    };

                    // Add to list
                    addedAttributes.Add(memoAttribute);

                    // Create a money attribute	
                    MoneyAttributeMetadata moneyAttribute = new MoneyAttributeMetadata
                    {
                        // Set base properties
                        SchemaName = "new_Money",
                        LogicalName = "new_money",
                        DisplayName = new Label("Money Picklist", _languageCode),
                        RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                        Description = new Label("Money Attribue", _languageCode),
                        // Set extended properties
                        MaxValue = 1000.00,
                        MinValue = 0.00,
                        Precision = 1,
                        PrecisionSource = 1,
                        ImeMode = ImeMode.Disabled
                    };

                    // Add to list
                    addedAttributes.Add(moneyAttribute);

                    // Create a picklist attribute	
                    PicklistAttributeMetadata pickListAttribute =
                        new PicklistAttributeMetadata
                        {
                            // Set base properties
                            SchemaName = "new_Picklist",
                            LogicalName = "new_picklist",
                            DisplayName = new Label("Sample Picklist", _languageCode),
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                            Description = new Label("Picklist Attribute", _languageCode),
                            // Set extended properties
                            // Build local picklist options
                            OptionSet = new OptionSetMetadata
                            {
                                IsGlobal = false,
                                OptionSetType = OptionSetType.Picklist,
                                Options =
                            {
                                new OptionMetadata(
                                    new Label("Created", _languageCode), null),
                                new OptionMetadata(
                                    new Label("Updated", _languageCode), null),
                                new OptionMetadata(
                                    new Label("Deleted", _languageCode), null)
                            }
                            }
                        };

                    // Add to list
                    addedAttributes.Add(pickListAttribute);

                    // Create a string attribute
                    StringAttributeMetadata stringAttribute = new StringAttributeMetadata
                    {
                        // Set base properties
                        SchemaName = "new_String",
                        LogicalName = "new_string",

                        DisplayName = new Label("Sample String", _languageCode),
                        RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                        Description = new Label("String Attribute", _languageCode),
                        // Set extended properties
                        MaxLength = 100
                    };

                    // Add to list
                    addedAttributes.Add(stringAttribute);

                    //Multi-select attribute requires version 9.0 or higher.
                    if (_productVersion > new Version("9.0"))
                    {

                        // Create a multi-select optionset
                        MultiSelectPicklistAttributeMetadata multiSelectOptionSetAttribute = new MultiSelectPicklistAttributeMetadata()
                        {
                            SchemaName = "new_MultiSelectOptionSet",
                            LogicalName = "new_multiselectoptionset",
                            DisplayName = new Label("Multi-Select OptionSet", _languageCode),
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                            Description = new Label("Multi-Select OptionSet description", _languageCode),
                            OptionSet = new OptionSetMetadata()
                            {
                                IsGlobal = false,
                                OptionSetType = OptionSetType.Picklist,
                                Options = {
                            new OptionMetadata(new Label("First Option",_languageCode),null),
                            new OptionMetadata(new Label("Second Option",_languageCode),null),
                            new OptionMetadata(new Label("Third Option",_languageCode),null)
                            }
                            }
                        };
                        // Add to list
                        addedAttributes.Add(multiSelectOptionSetAttribute);
                    }

                    // NOTE: LookupAttributeMetadata cannot be created outside the context of a relationship.
                    // Refer to the WorkWithRelationships.cs reference SDK sample for an example of this attribute type.

                    // NOTE: StateAttributeMetadata and StatusAttributeMetadata cannot be created via the SDK.

                    foreach (AttributeMetadata anAttribute in addedAttributes)
                    {
                        // Create the request.
                        CreateAttributeRequest createAttributeRequest = new CreateAttributeRequest
                        {
                            EntityName = Contact.EntityLogicalName,
                            Attribute = anAttribute
                        };

                        // Execute the request.
                        _serviceProxy.Execute(createAttributeRequest);

                        Console.WriteLine("Created the attribute {0}.", anAttribute.SchemaName);
                    }
                    //</snippetWorkWithAttributes2>
                    #endregion How to create attributes

                    #region How to insert status
                    //<snippetWorkWithAttributes3>
                    // Use InsertStatusValueRequest message to insert a new status 
                    // in an existing status attribute. 
                    // Create the request.
                    InsertStatusValueRequest insertStatusValueRequest =
                        new InsertStatusValueRequest
                        {
                            AttributeLogicalName = "statuscode",
                            EntityLogicalName = Contact.EntityLogicalName,
                            Label = new Label("Dormant", _languageCode),
                            StateCode = 0
                        };

                    // Execute the request and store newly inserted value 
                    // for cleanup, used later part of this sample. 
                    _insertedStatusValue = ((InsertStatusValueResponse)_serviceProxy.Execute(
                        insertStatusValueRequest)).NewOptionValue;

                    Console.WriteLine("Created status named '{0}' with the value of {1}.",
                        insertStatusValueRequest.Label.LocalizedLabels[0].Label,
                        _insertedStatusValue);
                    //</snippetWorkWithAttributes3>
                    #endregion How to insert status

                    #region How to retrieve attribute
                    //<snippetWorkWithAttributes4>
                    // Create the request
                    RetrieveAttributeRequest attributeRequest = new RetrieveAttributeRequest
                    {
                        EntityLogicalName = Contact.EntityLogicalName,
                        LogicalName = "new_string",
                        RetrieveAsIfPublished = true
                    };

                    // Execute the request
                    RetrieveAttributeResponse attributeResponse =
                        (RetrieveAttributeResponse)_serviceProxy.Execute(attributeRequest);

                    Console.WriteLine("Retrieved the attribute {0}.",
                        attributeResponse.AttributeMetadata.SchemaName);
                    //</snippetWorkWithAttributes4>
                    #endregion How to retrieve attribute

                    #region How to update attribute
                    //<snippetWorkWithAttributes5>
                    // Modify the retrieved attribute
                    AttributeMetadata retrievedAttributeMetadata =
                        attributeResponse.AttributeMetadata;
                    retrievedAttributeMetadata.DisplayName =
                        new Label("Update String Attribute", _languageCode);

                    // Update an attribute retrieved via RetrieveAttributeRequest
                    UpdateAttributeRequest updateRequest = new UpdateAttributeRequest
                    {
                        Attribute = retrievedAttributeMetadata,
                        EntityName = Contact.EntityLogicalName,
                        MergeLabels = false
                    };

                    // Execute the request
                    _serviceProxy.Execute(updateRequest);

                    Console.WriteLine("Updated the attribute {0}.",
                        retrievedAttributeMetadata.SchemaName);
                    //</snippetWorkWithAttributes5>
                    #endregion How to update attribute

                    #region How to update state value
                    //<snippetWorkWithAttributes6>
                    // Modify the state value label from Active to Open.
                    // Create the request.
                    UpdateStateValueRequest updateStateValue = new UpdateStateValueRequest
                    {
                        AttributeLogicalName = "statecode",
                        EntityLogicalName = Contact.EntityLogicalName,
                        Value = 1,
                        Label = new Label("Open", _languageCode)
                    };

                    // Execute the request.
                    _serviceProxy.Execute(updateStateValue);

                    Console.WriteLine(
                        "Updated {0} state attribute of {1} entity from 'Active' to '{2}'.",
                        updateStateValue.AttributeLogicalName,
                        updateStateValue.EntityLogicalName,
                        updateStateValue.Label.LocalizedLabels[0].Label
                        );
                    //</snippetWorkWithAttributes6>
                    #endregion How to update state value

                    #region How to insert a new option item in a local option set
                    //<snippetWorkWithAttributes7>
                    // Create a request.
                    InsertOptionValueRequest insertOptionValueRequest =
                        new InsertOptionValueRequest
                        {
                            AttributeLogicalName = "new_picklist",
                            EntityLogicalName = Contact.EntityLogicalName,
                            Label = new Label("New Picklist Label", _languageCode)
                        };

                    // Execute the request.
                    int insertOptionValue = ((InsertOptionValueResponse)_serviceProxy.Execute(
                        insertOptionValueRequest)).NewOptionValue;

                    Console.WriteLine("Created {0} with the value of {1}.",
                        insertOptionValueRequest.Label.LocalizedLabels[0].Label,
                        insertOptionValue);
                    //</snippetWorkWithAttributes7>
                    #endregion How to insert a new option item in a local option set

                    #region How to change the order of options of a local option set
                    //<snippetWorkWithAttributes8>
                    // Use the RetrieveAttributeRequest message to retrieve  
                    // a attribute by it's logical name.
                    RetrieveAttributeRequest retrieveAttributeRequest =
                        new RetrieveAttributeRequest
                        {
                            EntityLogicalName = Contact.EntityLogicalName,
                            LogicalName = "new_picklist",
                            RetrieveAsIfPublished = true
                        };

                    // Execute the request.
                    RetrieveAttributeResponse retrieveAttributeResponse =
                        (RetrieveAttributeResponse)_serviceProxy.Execute(
                        retrieveAttributeRequest);

                    // Access the retrieved attribute.
                    PicklistAttributeMetadata retrievedPicklistAttributeMetadata =
                        (PicklistAttributeMetadata)
                        retrieveAttributeResponse.AttributeMetadata;

                    // Get the current options list for the retrieved attribute.
                    OptionMetadata[] optionList =
                        retrievedPicklistAttributeMetadata.OptionSet.Options.ToArray();

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
                        AttributeLogicalName = "new_picklist",
                        EntityLogicalName = Contact.EntityLogicalName,
                        // Set the changed order using Select linq function 
                        // to get only values in an array from the changed option list.
                        Values = updateOptionList.Select(x => x.Value.Value).ToArray()
                    };

                    // Execute the request
                    _serviceProxy.Execute(orderOptionRequest);

                    Console.WriteLine("Option Set option order changed");
                    //</snippetWorkWithAttributes8>
                    #endregion How to change the order of options of a global option set

                    // NOTE: All customizations must be published before they can be used.
                    _serviceProxy.Execute(new PublishAllXmlRequest());
                    Console.WriteLine("Published all customizations.");
                    //</snippetWorkWithAttributes1>

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
        /// Deletes/Reverts the record that was created/changed for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete 
        /// the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine(
                    "\nDo you want these custom attributes to be deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                #region How to delete attribute
                //<snippetWorkWithAttributes9>
                // Delete all attributes created for this sample.
                foreach (AttributeMetadata anAttribute in addedAttributes)
                {
                    // Create the request object
                    DeleteAttributeRequest deleteAttribute = new DeleteAttributeRequest
                    {
                        // Set the request properties 
                        EntityLogicalName = Contact.EntityLogicalName,
                        LogicalName = anAttribute.LogicalName
                    };
                    // Execute the request
                    _serviceProxy.Execute(deleteAttribute);
                }
                //</snippetWorkWithAttributes9>
                #endregion How to delete attribute

                #region How to remove inserted status value
                //<snippetWorkWithAttributes10>
                // Delete the newly inserted status value.
                // Create the request object
                DeleteOptionValueRequest deleteRequest = new DeleteOptionValueRequest
                {
                    AttributeLogicalName = "statuscode",
                    EntityLogicalName = Contact.EntityLogicalName,
                    Value = _insertedStatusValue
                };

                // Execute the request
                _serviceProxy.Execute(deleteRequest);

                Console.WriteLine("Deleted all attributes created for this sample.");
                //</snippetWorkWithAttributes10>
                #endregion How to remove inserted status value

                #region Revert the changed state value
                //<snippetWorkWithAttributes11>
                // Revert the state value label from Open to Active.
                // Create the request.
                UpdateStateValueRequest revertStateValue = new UpdateStateValueRequest
                {
                    AttributeLogicalName = "statecode",
                    EntityLogicalName = Contact.EntityLogicalName,
                    Value = 1,
                    Label = new Label("Active", _languageCode)
                };

                // Execute the request.
                _serviceProxy.Execute(revertStateValue);

                // NOTE: All customizations must be published before they can be used.
                _serviceProxy.Execute(new PublishAllXmlRequest());

                Console.WriteLine(
                    "Reverted {0} state attribute of {1} entity from 'Open' to '{2}'.",
                    revertStateValue.AttributeLogicalName,
                    revertStateValue.EntityLogicalName,
                    revertStateValue.Label.LocalizedLabels[0].Label
                    );
                //</snippetWorkWithAttributes11>
                #endregion Revert the changed state value
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

                WorkWithAttributes app = new WorkWithAttributes();
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
//</snippetWorkWithAttributes>