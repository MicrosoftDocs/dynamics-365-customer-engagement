' <snippetentityproperties>


 'A properties expression to limit the properties to be included with entities
 Dim EntityProperties As New MetadataPropertiesExpression() With {.AllProperties = False}
 EntityProperties.PropertyNames.AddRange(New String() { "Attributes" })

' </snippetentityproperties>