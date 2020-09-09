// <snippetcreateupdateentitymetadata2>


 CreateAttributeRequest createBankNameAttributeRequest = new CreateAttributeRequest
 {
  EntityName = _customEntityName,
  Attribute = new StringAttributeMetadata
  {
   SchemaName = "new_bankname",
   RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
   MaxLength = 100,
   FormatName = StringFormatName.Text,
   DisplayName = new Label("Bank Name", 1033),
   Description = new Label("The name of the bank.", 1033)
  }
 };

 _serviceProxy.Execute(createBankNameAttributeRequest);

// </snippetcreateupdateentitymetadata2>