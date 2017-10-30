' <snippetenablefieldsecurityforanentity1>


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

     ' Create the request object and set the monikers with the
     ' teamprofiles_association relationship.
     Dim teamToProfile As AssociateRequest = New AssociateRequest With { _
         .Target = New EntityReference(FieldSecurityProfile.EntityLogicalName, _profileId), _
         .RelatedEntities = New EntityReferenceCollection From {New EntityReference(Team.EntityLogicalName, _teamId)}, _
         .Relationship = New Relationship("teamprofiles_association")}

     ' Execute the request.
     _serviceProxy.Execute(teamToProfile)


     ' Create custom activity entity.
     Dim req As New CreateEntityRequest() With {.Entity = New EntityMetadata With { _
             .LogicalName = "new_tweet", .DisplayName = New Label("Tweet", 1033), _
             .DisplayCollectionName = New Label("Tweet", 1033), .OwnershipType = OwnershipTypes.UserOwned, _
             .SchemaName = "New_Tweet", .IsActivity = True, .IsAvailableOffline = True, _
             .IsAuditEnabled = New BooleanManagedProperty(True), .IsMailMergeEnabled = New BooleanManagedProperty(False)}, _
             .HasActivities = False, .HasNotes = True, .PrimaryAttribute = New StringAttributeMetadata() With { _
                 .SchemaName = "Subject", .LogicalName = "subject", _
                 .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None), _
                 .MaxLength = 100, .DisplayName = New Label("Subject", 1033)}}

     ' Execute the request.
     _serviceProxy.Execute(req)
     Console.Write("Entity Created, ")

     ' Create custom attributes.
     Dim attrReq As New CreateAttributeRequest() With {.Attribute = New StringAttributeMetadata() With { _
             .LogicalName = "new_identity", .DisplayName = New Label("Identity", 1033), .SchemaName = "New_Identity", _
             .MaxLength = 500, .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended), _
             .IsSecured = True}, .EntityName = "new_tweet"}

     ' Execute the request.
     Dim identityAttributeResponse As CreateAttributeResponse = CType(_serviceProxy.Execute(attrReq), CreateAttributeResponse)
     _identityId = identityAttributeResponse.AttributeId
     Console.Write("Identity Created, ")

     attrReq = New CreateAttributeRequest() With {.Attribute = New StringAttributeMetadata() With { _
             .LogicalName = "new_message", .DisplayName = New Label("Message", 1033), .SchemaName = "New_Message", _
             .MaxLength = 140, .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended), _
             .IsSecured = True}, .EntityName = "new_tweet"}

     ' Execute the request.
     Dim messageAttributeResponse As CreateAttributeResponse = CType(_serviceProxy.Execute(attrReq), CreateAttributeResponse)
     _messageId = messageAttributeResponse.AttributeId
     Console.Write("Message Created, ")

     ' Create the field permission for the Identity attribute.
     Dim identityPermission As New FieldPermission() With {.AttributeLogicalName = "new_identity", .EntityName = "new_tweet", _
         .CanRead = New OptionSetValue(FieldPermissionType.Allowed), _
         .FieldSecurityProfileId = New EntityReference(FieldSecurityProfile.EntityLogicalName, _profileId)}

     ' Execute the request
     _identityPermissionId = _serviceProxy.Create(identityPermission)
     Console.Write("Permission Created. ")

     DeleteRequiredRecords(promptforDelete)
 End Using

' </snippetenablefieldsecurityforanentity1>