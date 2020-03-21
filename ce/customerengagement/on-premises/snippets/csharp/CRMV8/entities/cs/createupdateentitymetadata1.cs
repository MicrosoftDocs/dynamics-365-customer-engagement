// <snippetcreateupdateentitymetadata1>


 CreateEntityRequest createrequest = new CreateEntityRequest
 {

  //Define the entity
  Entity = new EntityMetadata
  {
   SchemaName = _customEntityName,
   DisplayName = new Label("Bank Account", 1033),
   DisplayCollectionName = new Label("Bank Accounts", 1033),
   Description = new Label("An entity to store information about customer bank accounts", 1033),
   OwnershipType = OwnershipTypes.UserOwned,
   IsActivity = false,

  },

  // Define the primary attribute for the entity
  PrimaryAttribute = new StringAttributeMetadata
  {
   SchemaName = "new_accountname",
   RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
   MaxLength = 100,
   FormatName = StringFormatName.Text,
   DisplayName = new Label("Account Name", 1033),
   Description = new Label("The primary attribute for the Bank Account entity.", 1033)
  }

 };
 _serviceProxy.Execute(createrequest);
 Console.WriteLine("The bank account entity has been created.");

// </snippetcreateupdateentitymetadata1>