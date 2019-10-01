// <snippetcreateupdateentitymetadata3>


 CreateAttributeRequest createBalanceAttributeRequest = new CreateAttributeRequest
 {
  EntityName = _customEntityName,
  Attribute = new MoneyAttributeMetadata
  {
   SchemaName = "new_balance",
   RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
   PrecisionSource = 2,
   DisplayName = new Label("Balance", 1033),
   Description = new Label("Account Balance at the last known date", 1033),

  }
 };

 _serviceProxy.Execute(createBalanceAttributeRequest);

// </snippetcreateupdateentitymetadata3>