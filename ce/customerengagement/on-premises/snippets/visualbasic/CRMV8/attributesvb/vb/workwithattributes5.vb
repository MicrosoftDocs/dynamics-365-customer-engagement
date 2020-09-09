' <snippetworkwithattributes5>


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

' </snippetworkwithattributes5>