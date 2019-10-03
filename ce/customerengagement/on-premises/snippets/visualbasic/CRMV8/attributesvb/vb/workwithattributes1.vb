' <snippetworkwithattributes1>


 '                    #Region "How to create attributes"
 ' Create storage for new attributes being created
 addedAttributes = New List(Of AttributeMetadata)()

 ' Create a boolean attribute
 Dim boolAttribute As BooleanAttributeMetadata = New BooleanAttributeMetadata With {
  .SchemaName = "new_boolean",
  .DisplayName = New Label("Sample Boolean", _languageCode),
  .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
  .Description = New Label("Boolean Attribute", _languageCode),
  .OptionSet = New BooleanOptionSetMetadata(
   New OptionMetadata(
    New Label("True", _languageCode), 1),
    New OptionMetadata(
    New Label("False", _languageCode), 0)
   )
 }
 ' Set base properties
 ' Set extended properties

 ' Add to list
 addedAttributes.Add(boolAttribute)

 ' Create a date time attribute
 Dim dtAttribute As DateTimeAttributeMetadata = New DateTimeAttributeMetadata With {
  .SchemaName = "new_datetime",
  .DisplayName = New Label("Sample DateTime", _languageCode),
  .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
  .Description = New Label("DateTime Attribute", _languageCode),
  .Format = DateTimeFormat.DateOnly,
  .ImeMode = ImeMode.Disabled}
 ' Set base properties
 ' Set extended properties

 ' Add to list
 addedAttributes.Add(dtAttribute)

 ' Create a decimal attribute    
 Dim decimalAttribute As DecimalAttributeMetadata = New DecimalAttributeMetadata With {
  .SchemaName = "new_decimal",
  .DisplayName = New Label("Sample Decimal", _languageCode),
  .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
  .Description = New Label("Decimal Attribute", _languageCode),
  .MaxValue = 100,
  .MinValue = 0,
  .Precision = 1}
 ' Set base properties
 ' Set extended properties

 ' Add to list
 addedAttributes.Add(decimalAttribute)

 ' Create a integer attribute    
 Dim integerAttribute As IntegerAttributeMetadata = New IntegerAttributeMetadata With {
  .SchemaName = "new_integer",
  .DisplayName = New Label("Sample Integer", _languageCode),
  .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
  .Description = New Label("Integer Attribute", _languageCode),
  .Format = IntegerFormat.None,
  .MaxValue = 100,
  .MinValue = 0}
 ' Set base properties
 ' Set extended properties

 ' Add to list
 addedAttributes.Add(integerAttribute)

 ' Create a memo attribute 
 Dim memoAttribute As MemoAttributeMetadata = New MemoAttributeMetadata With {
  .SchemaName = "new_memo",
  .DisplayName = New Label("Sample Memo", _languageCode),
  .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
  .Description = New Label("Memo Attribute", _languageCode),
  .Format = StringFormat.TextArea,
  .ImeMode = ImeMode.Disabled,
  .MaxLength = 500}
 ' Set base properties
 ' Set extended properties

 ' Add to list
 addedAttributes.Add(memoAttribute)

 ' Create a money attribute    
 Dim moneyAttribute As MoneyAttributeMetadata = New MoneyAttributeMetadata With {
  .SchemaName = "new_money",
  .DisplayName = New Label("Money Picklist", _languageCode),
  .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
  .Description = New Label("Money Attribue", _languageCode),
  .MaxValue = 1000.0,
  .MinValue = 0.0,
  .Precision = 1,
  .PrecisionSource = 1,
  .ImeMode = ImeMode.Disabled}
 ' Set base properties
 ' Set extended properties

 ' Add to list
 addedAttributes.Add(moneyAttribute)

 ' Create a picklist attribute    
 Dim pickListAttribute As PicklistAttributeMetadata = New PicklistAttributeMetadata With {
  .SchemaName = "new_picklist",
  .DisplayName = New Label("Sample Picklist", _languageCode),
  .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
  .Description = New Label("Picklist Attribute", _languageCode)}
 Dim pickListOptionSetMetadata As OptionSetMetadata = New OptionSetMetadata() With {
  .IsGlobal = False,
  .OptionSetType = OptionSetType.Picklist}
 pickListOptionSetMetadata.Options.Add(New OptionMetadata(New Label("Created", _languageCode), Nothing))
 pickListOptionSetMetadata.Options.Add(New OptionMetadata(New Label("Updated", _languageCode), Nothing))
 pickListOptionSetMetadata.Options.Add(New OptionMetadata(New Label("Deleted", _languageCode), Nothing))
 pickListAttribute.OptionSet = pickListOptionSetMetadata
 ' Set base properties
 ' Set extended properties
 ' Build local picklist options

 ' Add to list
 addedAttributes.Add(pickListAttribute)

 ' Create a string attribute
 Dim stringAttribute As StringAttributeMetadata = New StringAttributeMetadata With {
  .SchemaName = "new_string",
  .DisplayName = New Label("Sample String", _languageCode),
  .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
  .Description = New Label("String Attribute", _languageCode),
  .MaxLength = 100}
 ' Set base properties
 ' Set extended properties

 ' Add to list
 addedAttributes.Add(stringAttribute)

 ' NOTE: LookupAttributeMetadata cannot be created outside the context of a relationship.
 ' Refer to the WorkWithRelationships.cs reference SDK sample for an example of this attribute type.

 ' NOTE: StateAttributeMetadata and StatusAttributeMetadata cannot be created via the SDK.

 For Each anAttribute As AttributeMetadata In addedAttributes
  ' Create the request.
  Dim createAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With {
   .EntityName = Contact.EntityLogicalName,
   .Attribute = anAttribute}

  ' Execute the request.
  _serviceProxy.Execute(createAttributeRequest)

  Console.WriteLine("Created the attribute {0}.", anAttribute.SchemaName)
 Next anAttribute
 '                    #End Region ' How to create attributes

 '                    #Region "How to insert status"
 ' Use InsertStatusValueRequest message to insert a new status 
 ' in an existing status attribute. 
 ' Create the request.
 Dim insertStatusValueRequest As InsertStatusValueRequest = New InsertStatusValueRequest With {
  .AttributeLogicalName = "statuscode",
  .EntityLogicalName = Contact.EntityLogicalName,
  .Label = New Label("Dormant", _languageCode),
  .StateCode = 0}

 ' Execute the request and store newly inserted value 
 ' for cleanup, used later part of this sample. 
 _insertedStatusValue = (CType(_serviceProxy.Execute(insertStatusValueRequest), InsertStatusValueResponse)).NewOptionValue

 Console.WriteLine("Created {0} with the value of {1}.", insertStatusValueRequest.Label.LocalizedLabels(0).Label, _insertedStatusValue)
 '                    #End Region ' How to insert status

 '                    #Region "How to retrieve attribute"
 ' Create the request
 Dim attributeRequest As RetrieveAttributeRequest = New RetrieveAttributeRequest With {
  .EntityLogicalName = Contact.EntityLogicalName,
  .LogicalName = "new_string",
  .RetrieveAsIfPublished = True}

 ' Execute the request
 Dim attributeResponse As RetrieveAttributeResponse = CType(_serviceProxy.Execute(attributeRequest), RetrieveAttributeResponse)

 Console.WriteLine("Retrieved the attribute {0}.", attributeResponse.AttributeMetadata.SchemaName)
 '#End Region ' How to retrieve attribute

 '#Region "How to update attribute"
 ' Modify the retrieved attribute
 Dim retrievedAttributeMetadata As AttributeMetadata = attributeResponse.AttributeMetadata
 retrievedAttributeMetadata.DisplayName = New Label("Update String Attribute", _languageCode)

 ' Update an attribute retrieved via RetrieveAttributeRequest
 Dim updateRequest As UpdateAttributeRequest = New UpdateAttributeRequest With {
  .Attribute = retrievedAttributeMetadata,
  .EntityName = Contact.EntityLogicalName,
  .MergeLabels = False}

 ' Execute the request
 _serviceProxy.Execute(updateRequest)

 Console.WriteLine("Updated the attribute {0}.", retrievedAttributeMetadata.SchemaName)
 '                    #End Region ' How to update attribute

 '                    #Region "How to update state value"
 ' Modify the state value label from Active to Open.
 ' Create the request.
 Dim updateStateValue As UpdateStateValueRequest = New UpdateStateValueRequest With {
  .AttributeLogicalName = "statecode",
  .EntityLogicalName = Contact.EntityLogicalName,
  .Value = 1,
  .Label = New Label("Open", _languageCode)}

 ' Execute the request.
 _serviceProxy.Execute(updateStateValue)

 Console.WriteLine("Updated {0} state attribute of {1} entity from 'Active' to '{2}'.",
                   updateStateValue.AttributeLogicalName,
                   updateStateValue.EntityLogicalName,
                   updateStateValue.Label.LocalizedLabels(0).Label)
 '                    #End Region ' How to update state value

 '                    #Region "How to insert a new option item in a local option set"
 ' Create a request.
 Dim insertOptionValueRequest As InsertOptionValueRequest = New InsertOptionValueRequest With {
  .AttributeLogicalName = "new_picklist",
  .EntityLogicalName = Contact.EntityLogicalName,
  .Label = New Label("New Picklist Label", _languageCode)}

 ' Execute the request.
 Dim insertOptionValue As Integer = (CType(_serviceProxy.Execute(insertOptionValueRequest), InsertOptionValueResponse)).NewOptionValue

 Console.WriteLine("Created {0} with the value of {1}.", insertOptionValueRequest.Label.LocalizedLabels(0).Label, insertOptionValue)
 '#End Region ' How to insert a new option item in a local option set

 '#Region "How to change the order of options of a local option set"
 ' Use the RetrieveAttributeRequest message to retrieve  
 ' a attribute by it's logical name.
 Dim retrieveAttributeRequest As RetrieveAttributeRequest = New RetrieveAttributeRequest With {
  .EntityLogicalName = Contact.EntityLogicalName,
  .LogicalName = "new_picklist",
  .RetrieveAsIfPublished = True}

 ' Execute the request.
 Dim retrieveAttributeResponse As RetrieveAttributeResponse = CType(_serviceProxy.Execute(retrieveAttributeRequest), RetrieveAttributeResponse)

 ' Access the retrieved attribute.
 Dim retrievedPicklistAttributeMetadata As PicklistAttributeMetadata = CType(retrieveAttributeResponse.AttributeMetadata, PicklistAttributeMetadata)

 ' Get the current options list for the retrieved attribute.
 Dim optionList() As OptionMetadata = retrievedPicklistAttributeMetadata.OptionSet.Options.ToArray()

 ' Change the order of the original option's list.
 ' Use the OrderBy (OrderByDescending) linq function to sort options in  
 ' ascending (descending) order according to label text.
 ' For ascending order use this:
 Dim updateOptionList = optionList.OrderBy(Function(x) x.Label.LocalizedLabels(0).Label).ToList()

 ' For descending order use this:
 ' var updateOptionList =
 '      optionList.OrderByDescending(
 '      x => x.Label.LocalizedLabels[0].Label).ToList();

 ' Create the request.
 Dim orderOptionRequest As OrderOptionRequest = New OrderOptionRequest With {
  .AttributeLogicalName = "new_picklist",
  .EntityLogicalName = Contact.EntityLogicalName,
  .Values = updateOptionList.Select(Function(x) x.Value.Value).ToArray()}
 ' Set the properties for the request.
 ' Set the changed order using Select linq function 
 ' to get only values in an array from the changed option list.

 ' Execute the request
 _serviceProxy.Execute(orderOptionRequest)

 Console.WriteLine("Option Set option order changed")
 '#End Region ' How to change the order of options of a global option set

 ' NOTE: All customizations must be published before they can be used.
 _serviceProxy.Execute(New PublishAllXmlRequest())
 Console.WriteLine("Published all customizations.")

' </snippetworkwithattributes1>