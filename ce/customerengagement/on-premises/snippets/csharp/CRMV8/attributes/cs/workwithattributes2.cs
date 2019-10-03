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