// <snippetretrievesecuredfieldsforauser1>


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

     // Add team to profile.
     AssociateRequest teamToProfile = new AssociateRequest()
     {
         Target = new EntityReference(FieldSecurityProfile.EntityLogicalName,
             _profileId),
         RelatedEntities = new EntityReferenceCollection()
         {
             new EntityReference(Team.EntityLogicalName, _teamId)
         },
         Relationship = new Relationship("teamprofiles_association")
     };
     _serviceProxy.Execute(teamToProfile);

     // Add user to the profile.
     AssociateRequest userToProfile = new AssociateRequest()
     {
         Target = new EntityReference(FieldSecurityProfile.EntityLogicalName,
             _profileId),
         RelatedEntities = new EntityReferenceCollection()
         {
             new EntityReference(SystemUser.EntityLogicalName, _userId)
         },
         Relationship = new Relationship("systemuserprofiles_association")
     };
     _serviceProxy.Execute(userToProfile);

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
             IsMailMergeEnabled = new BooleanManagedProperty(false),
         },
         HasActivities = false,
         HasNotes = true,
         PrimaryAttribute = new StringAttributeMetadata()
         {
             SchemaName = "Subject",
             LogicalName = "subject",
             RequiredLevel = new AttributeRequiredLevelManagedProperty(
                 AttributeRequiredLevel.None),
             MaxLength = 100,
             DisplayName = new Label("Subject", 1033)
         }
     };
     _serviceProxy.Execute(req);
     Console.Write("Entity Created, ");

     // Add privileges for the Tweet entity to the Marketing Role.
     RolePrivilege[] privileges = new RolePrivilege[3];

     // SDK: prvCreateActivity
     privileges[0] = new RolePrivilege();
     privileges[0].PrivilegeId = new Guid("{091DF793-FE5E-44D4-B4CA-7E3F580C4664}");
     privileges[0].Depth = PrivilegeDepth.Global;

     // SDK: prvReadActivity
     privileges[1] = new RolePrivilege();
     privileges[1].PrivilegeId = new Guid("{650C14FE-3521-45FE-A000-84138688E45D}");
     privileges[1].Depth = PrivilegeDepth.Global;

     // SDK: prvWriteActivity
     privileges[2] = new RolePrivilege();
     privileges[2].PrivilegeId = new Guid("{0DC8F72C-57D5-4B4D-8892-FE6AAC0E4B81}");
     privileges[2].Depth = PrivilegeDepth.Global;

     // Create and execute the request.
     AddPrivilegesRoleRequest request = new AddPrivilegesRoleRequest()
     {
         RoleId = _roleId,
         Privileges = privileges
     };
     AddPrivilegesRoleResponse response =
         (AddPrivilegesRoleResponse)_serviceProxy.Execute(request);

     // Create custom identity attribute.
     CreateAttributeRequest attrReq = new CreateAttributeRequest()
     {
         Attribute = new StringAttributeMetadata()
         {
             LogicalName = "new_identity",
             DisplayName = new Label("Identity", 1033),
             SchemaName = "New_Identity",
             MaxLength = 500,
             RequiredLevel = new AttributeRequiredLevelManagedProperty(
                 AttributeRequiredLevel.Recommended),
             IsSecured = true
         },
         EntityName = "new_tweet"
     };
     CreateAttributeResponse identityAttributeResponse =
         (CreateAttributeResponse)_serviceProxy.Execute(attrReq);
     _identityId = identityAttributeResponse.AttributeId;
     Console.Write("Identity Created, ");

     // Create custom message attribute.
     attrReq = new CreateAttributeRequest()
     {
         Attribute = new StringAttributeMetadata()
         {
             LogicalName = "new_message",
             DisplayName = new Label("Message", 1033),
             SchemaName = "New_Message",
             MaxLength = 140,
             RequiredLevel = new AttributeRequiredLevelManagedProperty(
                 AttributeRequiredLevel.Recommended),
             IsSecured = true
         },
         EntityName = "new_tweet"
     };
     CreateAttributeResponse messageAttributeResponse =
         (CreateAttributeResponse)_serviceProxy.Execute(attrReq);
     _messageId = messageAttributeResponse.AttributeId;
     Console.Write("Message Created, ");

     // Create field permission object for Identity.
     FieldPermission identityPermission = new FieldPermission();
     identityPermission.AttributeLogicalName = "new_identity";
     identityPermission.EntityName = "new_tweet";
     identityPermission.CanRead = new OptionSetValue(FieldPermissionType.Allowed);
     identityPermission.FieldSecurityProfileId = new EntityReference(
         FieldSecurityProfile.EntityLogicalName, _profileId);
     _identityPermissionId = _serviceProxy.Create(identityPermission);
     Console.Write("Permission Created, ");

     // Create list for storing retrieved profiles.
     List<Guid> profileIds = new List<Guid>();

     // Build query to obtain the field security profiles.
     QueryExpression qe = new QueryExpression()
     {
         EntityName = FieldSecurityProfile.EntityLogicalName,
         ColumnSet = new ColumnSet("fieldsecurityprofileid"),
         LinkEntities =
         {
             new LinkEntity
             {
                 LinkFromEntityName = FieldSecurityProfile.EntityLogicalName,
                 LinkToEntityName = SystemUser.EntityLogicalName,
                 LinkCriteria = 
                 {
                     Conditions = 
                     {
                         new ConditionExpression("systemuserid", ConditionOperator.Equal, _userId)
                     }
                 }
             }
         }
     };

     // Execute the query and obtain the results.
     RetrieveMultipleRequest rmRequest = new RetrieveMultipleRequest()
     {
         Query = qe
     };

     EntityCollection bec = ((RetrieveMultipleResponse)_serviceProxy.Execute(
         rmRequest)).EntityCollection;

     // Extract profiles from query result.
     foreach (FieldSecurityProfile profileEnt in bec.Entities)
     {
         profileIds.Add(profileEnt.FieldSecurityProfileId.Value);
     }
     Console.Write("Profiles Retrieved, ");

     // Retrieve attribute permissions of a FieldSecurityProfile.
     DataCollection<Entity> dc;

     // Retrieve the attributes.
     QueryByAttribute qba = new QueryByAttribute(FieldPermission.EntityLogicalName);
     qba.AddAttributeValue("fieldsecurityprofileid", _profileId);
     qba.ColumnSet = new ColumnSet("attributelogicalname");

     dc = _serviceProxy.RetrieveMultiple(qba).Entities;
     Console.Write("Attributes Retrieved. ");

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetretrievesecuredfieldsforauser1>