// <snippetcreateupdateentitymetadata4>


 CreateAttributeRequest createCheckedDateRequest = new CreateAttributeRequest
 {
  EntityName = _customEntityName,
  Attribute = new DateTimeAttributeMetadata
  {
   SchemaName = "new_checkeddate",
   RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
   Format = DateTimeFormat.DateOnly,
   DisplayName = new Label("Date", 1033),
   Description = new Label("The date the account balance was last confirmed", 1033)

  }
 };

 _serviceProxy.Execute(createCheckedDateRequest);
 Console.WriteLine("An date attribute has been added to the bank account entity.");

// </snippetcreateupdateentitymetadata4>