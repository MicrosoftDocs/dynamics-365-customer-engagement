' <snippetworkwithrelationships1>



 Dim eligibleCreateOneToManyRelationship As Boolean =
  Me.EligibleCreateOneToManyRelationship("account", "campaign")

 If eligibleCreateOneToManyRelationship Then
  Dim createOneToManyRelationshipRequest As CreateOneToManyRequest =
   New CreateOneToManyRequest With {
    .OneToManyRelationship = New OneToManyRelationshipMetadata With {
     .ReferencedEntity = "account",
     .ReferencingEntity = "campaign",
     .SchemaName = "new_account_campaign",
     .AssociatedMenuConfiguration =
     New AssociatedMenuConfiguration With {
      .Behavior = AssociatedMenuBehavior.UseLabel,
      .Group = AssociatedMenuGroup.Details,
      .Label = New Label("Account", 1033),
      .Order = 10000},
     .CascadeConfiguration =
     New CascadeConfiguration With {
      .Assign = CascadeType.Cascade,
      .Delete = CascadeType.Cascade,
      .Merge = CascadeType.Cascade,
      .Reparent = CascadeType.Cascade,
      .Share = CascadeType.Cascade,
      .Unshare = CascadeType.Cascade
     }
    },
    .Lookup = New LookupAttributeMetadata With {
     .SchemaName = "new_parent_accountid",
     .DisplayName = New Label("Account Lookup", 1033),
     .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
     .Description = New Label("Sample Lookup", 1033)
    }
   }


  Dim createOneToManyRelationshipResponse As CreateOneToManyResponse =
   CType(_serviceProxy.Execute(createOneToManyRelationshipRequest), CreateOneToManyResponse)

  _oneToManyRelationshipId = createOneToManyRelationshipResponse.RelationshipId
  _oneToManyRelationshipName = createOneToManyRelationshipRequest.OneToManyRelationship.SchemaName

  Console.WriteLine("The one-to-many relationship has been created between {0} and {1}.", "account", "campaign")
 End If

' </snippetworkwithrelationships1>