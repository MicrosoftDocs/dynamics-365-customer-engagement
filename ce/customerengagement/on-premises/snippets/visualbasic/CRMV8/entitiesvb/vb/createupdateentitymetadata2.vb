' <snippetcreateupdateentitymetadata2>


 Dim createBankNameAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With {
  .EntityName = _customEntityName,
  .Attribute = New StringAttributeMetadata With {
   .SchemaName = "new_bankname",
   .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
   .MaxLength = 100,
   .Format = StringFormat.Text,
   .DisplayName = New Label("Bank Name", 1033),
   .Description = New Label("The name of the bank.", 1033)
  }
 }

 _serviceProxy.Execute(createBankNameAttributeRequest)

' </snippetcreateupdateentitymetadata2>