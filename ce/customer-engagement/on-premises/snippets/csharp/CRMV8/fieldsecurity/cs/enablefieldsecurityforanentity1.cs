// <snippetenablefieldsecurityforanentity1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();
     
     CreateRequiredRecords();

     // Create Field Security Profile.
     FieldSecurityProfile managersProfile = new FieldSecurityProfile();
     managersProfile.Name = "Managers";
     _profileId = _serviceProxy.Create(managersProfile);
     Console.Write("Created Profile, ");

     // Create the request object and set the monikers with the
     // teamprofiles_association relationship.
     AssociateRequest teamToProfile = new AssociateRequest
     {
         Target = new EntityReference(FieldSecurityProfile.EntityLogicalName, _profileId),
         RelatedEntities = new EntityReferenceCollection
         {
             new EntityReference(Team.EntityLogicalName, _teamId)
         },
         Relationship = new Relationship("teamprofiles_association")
     };

     // Execute the request.
     _serviceProxy.Execute(teamToProfile);

     // Create custom activity entity.
     CreateEntityRequest req = new CreateEntityRequest()
     {
         Entity = new EntityMetadata
         {
             LogicalName = "new_tweet",
             DisplayName = new Label("Tweet", 1033),
             DisplayCollectionName = new Label("Tweet", 1033),
             OwnershipType = OwnershipTypes.UserOwned,
             SchemaName = "New_Tweet",
             IsActivity = true,
             IsAvailableOffline = true,
             IsAuditEnabled = new BooleanManagedProperty(true),
             IsMailMergeEnabled = new BooleanManagedProperty(false)
         },
         HasActivities = false,
         HasNotes = true,
         PrimaryAttribute = new StringAttributeMetadata()
         {
             SchemaName = "Subject",
             LogicalName = "subject",
             RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
             MaxLength = 100,
             DisplayName = new Label("Subject", 1033)
         }
     };

     // Execute the request.
     _serviceProxy.Execute(req);
     Console.Write("Entity Created, ");

     // Create custom attributes.
     CreateAttributeRequest attrReq = new CreateAttributeRequest()
     {
         Attribute = new StringAttributeMetadata()
         {
             LogicalName = "new_identity",
             DisplayName = new Label("Identity", 1033),
             SchemaName = "New_Identity",
             MaxLength = 500,
             RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
             IsSecured = true
         },
         EntityName = "new_tweet"
     };

     // Execute the request.
     CreateAttributeResponse identityAttributeResponse = (CreateAttributeResponse)_serviceProxy.Execute(attrReq);
     _identityId = identityAttributeResponse.AttributeId;
     Console.Write("Identity Created, ");

     attrReq = new CreateAttributeRequest()
     {
         Attribute = new StringAttributeMetadata()
         {
             LogicalName = "new_message",
             DisplayName = new Label("Message", 1033),
             SchemaName = "New_Message",
             MaxLength = 140,
             RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended),
             IsSecured = true
         },
         EntityName = "new_tweet"
     };

     // Execute the request.
     CreateAttributeResponse messageAttributeResponse = (CreateAttributeResponse)_serviceProxy.Execute(attrReq);
     _messageId = messageAttributeResponse.AttributeId;
     Console.Write("Message Created, ");

     // Create the field permission for the Identity attribute.
     FieldPermission identityPermission = new FieldPermission()
     {
         AttributeLogicalName = "new_identity",
         EntityName = "new_tweet",
         CanRead = new OptionSetValue(FieldPermissionType.Allowed),
         FieldSecurityProfileId = new EntityReference(FieldSecurityProfile.EntityLogicalName, _profileId)
     };

     // Execute the request
     _identityPermissionId = _serviceProxy.Create(identityPermission);
     Console.Write("Permission Created. ");

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetenablefieldsecurityforanentity1>