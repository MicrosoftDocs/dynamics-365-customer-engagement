' <snippetattributequeryexpression>


 'A condition expresson to return optionset attributes
                   Dim optionsetAttributeTypes() As MetadataConditionExpression =
                       {
                           New MetadataConditionExpression("AttributeType",
                                                           MetadataConditionOperator.Equals,
                                                           AttributeTypeCode.Picklist),
                           New MetadataConditionExpression("AttributeType",
                                                           MetadataConditionOperator.Equals,
                                                           AttributeTypeCode.State),
                           New MetadataConditionExpression("AttributeType",
                                                           MetadataConditionOperator.Equals,
                                                           AttributeTypeCode.Status),
                           New MetadataConditionExpression("AttributeType",
                                                           MetadataConditionOperator.Equals,
                                                           AttributeTypeCode.Boolean)
                       }

 'A filter expression to apply the optionsetAttributeTypes condition expression
 Dim AttributeFilter As New MetadataFilterExpression(LogicalOperator.Or)
 AttributeFilter.Conditions.AddRange(optionsetAttributeTypes)

 'A Properties expression to limit the properties to be included with attributes
 Dim AttributeProperties As New MetadataPropertiesExpression() With {.AllProperties = False}
 AttributeProperties.PropertyNames.Add("OptionSet")
 AttributeProperties.PropertyNames.Add("AttributeType")

' </snippetattributequeryexpression>