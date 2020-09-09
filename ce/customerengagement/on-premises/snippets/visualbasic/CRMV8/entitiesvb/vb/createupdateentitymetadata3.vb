' <snippetcreateupdateentitymetadata3>


 Dim createBalanceAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With {
  .EntityName = _customEntityName,
  .Attribute = New MoneyAttributeMetadata With {
   .SchemaName = "new_balance",
   .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
   .PrecisionSource = 2,
   .DisplayName = New Label("Balance", 1033),
   .Description = New Label("Account Balance at the last known date", 1033)
  }
 }

 _serviceProxy.Execute(createBalanceAttributeRequest)

' </snippetcreateupdateentitymetadata3>