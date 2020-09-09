// <snippetentityproperties>


 //A properties expression to limit the properties to be included with entities
 MetadataPropertiesExpression EntityProperties = new MetadataPropertiesExpression()
 {
  AllProperties = false
 };
 EntityProperties.PropertyNames.AddRange(new string[] { "Attributes" });

// </snippetentityproperties>