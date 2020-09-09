' <snippetcreateupdateentitymetadata4>


 Dim createCheckedDateRequest As CreateAttributeRequest = New CreateAttributeRequest With {
  .EntityName = _customEntityName,
  .Attribute = New DateTimeAttributeMetadata With {
   .SchemaName = "new_checkeddate",
   .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
   .Format = DateTimeFormat.DateOnly,
   .DisplayName = New Label("Date", 1033),
   .Description = New Label("The date the account balance was last confirmed", 1033)
  }
 }

 _serviceProxy.Execute(createCheckedDateRequest)
 Console.WriteLine("An date attribute has been added to the bank account entity.")

' </snippetcreateupdateentitymetadata4>