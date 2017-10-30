// <snippetworkwithattributes1>


 #region How to create attributes
 // Create storage for new attributes being created
 addedAttributes = new List<AttributeMetadata>();

 // Create a boolean attribute
 BooleanAttributeMetadata boolAttribute = new BooleanAttributeMetadata
 {
     // Set base properties
     SchemaName = "new_boolean",
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
     SchemaName = "new_datetime",
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
     SchemaName = "new_decimal",
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
     SchemaName = "new_integer",
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
     SchemaName = "new_memo",
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
     SchemaName = "new_money",
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
     SchemaName = "new_picklist",
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
     SchemaName = "new_string",
     DisplayName = new Label("Sample String", _languageCode),
     RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
     Description = new Label("String Attribute", _languageCode),
     // Set extended properties
     MaxLength = 100
 };

 // Add to list
 addedAttributes.Add(stringAttribute);

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
 #endregion How to create attributes

 #region How to insert status
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

 Console.WriteLine("Created {0} with the value of {1}.",
     insertStatusValueRequest.Label.LocalizedLabels[0].Label,
     _insertedStatusValue);
 #endregion How to insert status

 #region How to retrieve attribute
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
 #endregion How to retrieve attribute
 
 #region How to update attribute
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
 #endregion How to update attribute

 #region How to update state value
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
 #endregion How to update state value

 #region How to insert a new option item in a local option set
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
 #endregion How to insert a new option item in a local option set

 #region How to change the order of options of a local option set
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
 #endregion How to change the order of options of a global option set

 // NOTE: All customizations must be published before they can be used.
 _serviceProxy.Execute(new PublishAllXmlRequest());
 Console.WriteLine("Published all customizations.");

// </snippetworkwithattributes1>