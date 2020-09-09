' <snippetretrievesecuredfieldsforauser1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     CreateRequiredRecords()

     ' Create Field Security Profile.
     Dim managersProfile As New FieldSecurityProfile()
     managersProfile.Name = "Managers"
     _profileId = _serviceProxy.Create(managersProfile)
     Console.Write("Created Profile, ")

     ' Add team to profile.
     Dim teamToProfile As New AssociateRequest() With
         {
             .Target = New EntityReference(
                 FieldSecurityProfile.EntityLogicalName,
                 _profileId),
             .RelatedEntities = New EntityReferenceCollection() From
             {
                 New EntityReference(Team.EntityLogicalName, _teamId)
             },
             .Relationship = New Relationship("teamprofiles_association")}
     _serviceProxy.Execute(teamToProfile)

     ' Add user to the profile.
     Dim userToProfile As New AssociateRequest() With
         {
             .Target = New EntityReference(
                 FieldSecurityProfile.EntityLogicalName,
                 _profileId),
             .RelatedEntities = New EntityReferenceCollection() From
             {
                 New EntityReference(SystemUser.EntityLogicalName, _userId)
             },
             .Relationship =
             New Relationship("systemuserprofiles_association")
         }
     _serviceProxy.Execute(userToProfile)

     ' Create custom activity entity.
     Dim req As New CreateEntityRequest() With
         {
             .Entity = New EntityMetadata With
                       {
                           .LogicalName = "new_tweet",
                           .DisplayName = New Label("Tweet", 1033),
                           .DisplayCollectionName = New Label("Tweet",
                                                              1033),
                           .OwnershipType = OwnershipTypes.UserOwned,
                           .SchemaName = "New_Tweet",
                           .IsActivity = True,
                           .IsAvailableOffline = True,
                           .IsAuditEnabled =
                           New BooleanManagedProperty(True),
                           .IsMailMergeEnabled =
                           New BooleanManagedProperty(False)
                       },
             .HasActivities = False,
             .HasNotes = True,
             .PrimaryAttribute =
             New StringAttributeMetadata() With
             {
                 .SchemaName = "Subject",
                 .LogicalName = "subject",
                 .RequiredLevel =
                 New AttributeRequiredLevelManagedProperty(
                     AttributeRequiredLevel.None),
                 .MaxLength = 100,
                 .DisplayName = New Label("Subject", 1033)
             }
         }
     _serviceProxy.Execute(req)
     Console.Write("Entity Created, ")

     ' Add privileges for the Tweet entity to the Marketing Role.
     Dim privileges(2) As RolePrivilege

     ' SDK: prvCreateActivity
     privileges(0) = New RolePrivilege()
     privileges(0).PrivilegeId = New Guid(
         "{091DF793-FE5E-44D4-B4CA-7E3F580C4664}")
     privileges(0).Depth = PrivilegeDepth.Global

     ' SDK: prvReadActivity
     privileges(1) = New RolePrivilege()
     privileges(1).PrivilegeId = New Guid(
         "{650C14FE-3521-45FE-A000-84138688E45D}")
     privileges(1).Depth = PrivilegeDepth.Global

     ' SDK: prvWriteActivity
     privileges(2) = New RolePrivilege()
     privileges(2).PrivilegeId = New Guid(
         "{0DC8F72C-57D5-4B4D-8892-FE6AAC0E4B81}")
     privileges(2).Depth = PrivilegeDepth.Global

     ' Create and execute the request.
     Dim request As New AddPrivilegesRoleRequest() With
         {
             .RoleId = _roleId,
             .Privileges = privileges
         }
     Dim response As AddPrivilegesRoleResponse =
         CType(_serviceProxy.Execute(request), 
             AddPrivilegesRoleResponse)

     ' Create custom identity attribute.
     Dim attrReq As New CreateAttributeRequest() With
         {
             .Attribute = New StringAttributeMetadata() With
                          {
                              .LogicalName = "new_identity",
                              .DisplayName = New Label("Identity", 1033),
                              .SchemaName = "New_Identity",
                              .MaxLength = 500,
                              .RequiredLevel = New AttributeRequiredLevelManagedProperty(
                                  AttributeRequiredLevel.Recommended),
                              .IsSecured = True
                          },
             .EntityName = "new_tweet"
         }
     Dim identityAttributeResponse As CreateAttributeResponse =
         CType(_serviceProxy.Execute(attrReq), 
             CreateAttributeResponse)
     _identityId = identityAttributeResponse.AttributeId
     Console.Write("Identity Created, ")

     ' Create custom message attribute.
     attrReq = New CreateAttributeRequest() With
               {
                   .Attribute = New StringAttributeMetadata() With
                                {
                                    .LogicalName = "new_message",
                                    .DisplayName = New Label("Message",
                                                             1033),
                                    .SchemaName = "New_Message",
                                    .MaxLength = 140,
                                    .RequiredLevel =
                                    New AttributeRequiredLevelManagedProperty(
                                        AttributeRequiredLevel.Recommended),
                                    .IsSecured = True
                                },
                   .EntityName = "new_tweet"
               }
     Dim messageAttributeResponse As CreateAttributeResponse =
         CType(_serviceProxy.Execute(attrReq), CreateAttributeResponse)
     _messageId = messageAttributeResponse.AttributeId
     Console.Write("Message Created, ")

     ' Create field permission object for Identity.
     Dim identityPermission As New FieldPermission()
     identityPermission.AttributeLogicalName = "new_identity"
     identityPermission.EntityName = "new_tweet"
     identityPermission.CanRead =
         New OptionSetValue(FieldPermissionType.Allowed)
     identityPermission.FieldSecurityProfileId =
         New EntityReference(FieldSecurityProfile.EntityLogicalName,
                             _profileId)
     _identityPermissionId = _serviceProxy.Create(identityPermission)
     Console.Write("Permission Created, ")

     ' Create list for storing retrieved profiles.
     Dim profileIds As New List(Of Guid)()

     ' Build query to obtain the field security profiles.
     Dim qe As New QueryExpression() With
         {
             .EntityName = FieldSecurityProfile.EntityLogicalName,
             .ColumnSet = New ColumnSet("fieldsecurityprofileid")
         }
     Dim qeLink As New LinkEntity With
         {
             .LinkFromEntityName = FieldSecurityProfile.EntityLogicalName,
             .LinkToEntityName = SystemUser.EntityLogicalName
         }
     qeLink.LinkCriteria.AddCondition("systemuserid",
                                 ConditionOperator.Equal,
                                 _userId)
     qe.LinkEntities.Add(qeLink)
     
     ' Execute the query and obtain the results.
     Dim rmRequest As New RetrieveMultipleRequest() With {.Query = qe}

     Dim bec As EntityCollection =
         (CType(_serviceProxy.Execute(rmRequest), 
          RetrieveMultipleResponse)).EntityCollection

     ' Extract profiles from query result.
     For Each profileEnt As FieldSecurityProfile In bec.Entities
         profileIds.Add(profileEnt.FieldSecurityProfileId.Value)
     Next profileEnt
     Console.Write("Profiles Retrieved, ")

     ' Retrieve attribute permissions of a FieldSecurityProfile.
     Dim dc As DataCollection(Of Entity)

     ' Retrieve the attributes.
     Dim qba As New QueryByAttribute(FieldPermission.EntityLogicalName)
     qba.AddAttributeValue("fieldsecurityprofileid", _profileId)
     qba.ColumnSet = New ColumnSet("attributelogicalname")

     dc = _serviceProxy.RetrieveMultiple(qba).Entities
     Console.Write("Attributes Retrieved. ")

     DeleteRequiredRecords(promptforDelete)
 End Using

' </snippetretrievesecuredfieldsforauser1>