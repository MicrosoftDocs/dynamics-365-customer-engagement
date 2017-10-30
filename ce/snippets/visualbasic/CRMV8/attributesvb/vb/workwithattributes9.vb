' <snippetworkwithattributes9>


 ' Delete all attributes created for this sample.
 For Each anAttribute As AttributeMetadata In addedAttributes
  ' Create the request object
  Dim deleteAttribute As DeleteAttributeRequest = New DeleteAttributeRequest With {
   .EntityLogicalName = Contact.EntityLogicalName,
   .LogicalName = anAttribute.SchemaName}
  ' Set the request properties 
  ' Execute the request
  _serviceProxy.Execute(deleteAttribute)
 Next anAttribute

' </snippetworkwithattributes9>