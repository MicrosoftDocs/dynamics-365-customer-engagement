// <snippetattributequeryexpression>


 //A condition expresson to return optionset attributes
 MetadataConditionExpression[] optionsetAttributeTypes = new MetadataConditionExpression[] { 
 new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.Picklist),
 new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.State),
 new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.Status),
 new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.Boolean)
 };

 //A filter expression to apply the optionsetAttributeTypes condition expression
 MetadataFilterExpression AttributeFilter = new MetadataFilterExpression(LogicalOperator.Or);
 AttributeFilter.Conditions.AddRange(optionsetAttributeTypes);

 //A Properties expression to limit the properties to be included with attributes
 MetadataPropertiesExpression AttributeProperties = new MetadataPropertiesExpression() { AllProperties = false };
 AttributeProperties.PropertyNames.Add("OptionSet");
 AttributeProperties.PropertyNames.Add("AttributeType");

// </snippetattributequeryexpression>