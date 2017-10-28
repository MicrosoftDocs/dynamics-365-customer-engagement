' <snippetcreateupdateentitymetadata1>


 Dim createrequest As CreateEntityRequest = New CreateEntityRequest With {
  .Entity = New EntityMetadata With {
   .SchemaName = _customEntityName,
   .DisplayName = New Label("Bank Account", 1033),
   .DisplayCollectionName = New Label("Bank Accounts", 1033),
   .Description = New Label("An entity to store information about customer bank accounts", 1033),
   .OwnershipType = OwnershipTypes.UserOwned,
   .IsActivity = False},
  .PrimaryAttribute = New StringAttributeMetadata With {
   .SchemaName = "new_accountname",
   .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
   .MaxLength = 100,
   .Format = StringFormat.Text,
   .DisplayName = New Label("Account Name", 1033),
   .Description = New Label("The primary attribute for the Bank Account entity.", 1033)
  }
 }
 'Define the entity
 ' Define the primary attribute for the entity
 _serviceProxy.Execute(createrequest)
 Console.WriteLine("The bank account entity has been created.")

' </snippetcreateupdateentitymetadata1>