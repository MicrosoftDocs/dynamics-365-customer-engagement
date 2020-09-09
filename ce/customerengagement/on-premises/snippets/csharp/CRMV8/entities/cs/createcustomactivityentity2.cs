// <snippetcreatecustomactivityentity2>


 String prefix = "new_";

 String customEntityName = prefix + "instantmessage";

 // Create the custom activity entity.
 CreateEntityRequest request = new CreateEntityRequest
 {
     HasNotes = true,
     HasActivities = false,
     PrimaryAttribute = new StringAttributeMetadata
     {
         SchemaName = "Subject",
         RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
         MaxLength = 100,
         DisplayName = new Label("Subject", 1033)
     },
     Entity = new EntityMetadata
     {
         IsActivity = true,
         SchemaName = customEntityName,
         DisplayName = new Label("Instant Message", 1033),
         DisplayCollectionName = new Label("Instant Messages", 1033),
         OwnershipType = OwnershipTypes.UserOwned,
         IsAvailableOffline = true,

     }
 };

 _serviceProxy.Execute(request);

 //Entity must be published

// </snippetcreatecustomactivityentity2>