' <snippetworkwithattributes4>


 ' Create the request
 Dim attributeRequest As RetrieveAttributeRequest = New RetrieveAttributeRequest With {
  .EntityLogicalName = Contact.EntityLogicalName,
  .LogicalName = "new_string",
  .RetrieveAsIfPublished = True}

 ' Execute the request
 Dim attributeResponse As RetrieveAttributeResponse = CType(_serviceProxy.Execute(attributeRequest), RetrieveAttributeResponse)

 Console.WriteLine("Retrieved the attribute {0}.", attributeResponse.AttributeMetadata.SchemaName)

' </snippetworkwithattributes4>