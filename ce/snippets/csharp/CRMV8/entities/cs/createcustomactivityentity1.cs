// <snippetcreatecustomactivityentity1>


  // The custom prefix would typically be passed in as an argument or 
  // determined by the publisher of the custom solution.
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

  // Add few attributes to the custom activity entity.
  CreateAttributeRequest fontFamilyAttributeRequest =
      new CreateAttributeRequest
 {
     EntityName = customEntityName,
     Attribute = new StringAttributeMetadata
     {
         SchemaName = prefix + "fontfamily",
         DisplayName = new Label("Font Family", 1033),
         MaxLength = 100
     }
 };
  CreateAttributeResponse fontFamilyAttributeResponse =
      (CreateAttributeResponse)_serviceProxy.Execute(
      fontFamilyAttributeRequest);

  CreateAttributeRequest fontColorAttributeRequest =
      new CreateAttributeRequest
  {
      EntityName = customEntityName,
      Attribute = new StringAttributeMetadata
      {
          SchemaName = prefix + "fontcolor",
          DisplayName = new Label("Font Color", 1033),
          MaxLength = 50
      }
  };
  CreateAttributeResponse fontColorAttributeResponse =
      (CreateAttributeResponse)_serviceProxy.Execute(
      fontColorAttributeRequest);

  CreateAttributeRequest fontSizeAttributeRequest =
      new CreateAttributeRequest
  {
      EntityName = customEntityName,
      Attribute = new IntegerAttributeMetadata
      {
          SchemaName = prefix + "fontSize",
          DisplayName = new Label("Font Size", 1033)
      }
  };
  CreateAttributeResponse fontSizeAttributeResponse =
      (CreateAttributeResponse)_serviceProxy.Execute(
      fontSizeAttributeRequest);

// </snippetcreatecustomactivityentity1>