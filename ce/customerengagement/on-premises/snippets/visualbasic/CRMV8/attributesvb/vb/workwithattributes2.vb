' <snippetworkwithattributes2>


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

' </snippetworkwithattributes2>