' <snippetworkwithrelationships2>



 Dim accountEligibleParticipate As Boolean = EligibleCreateManyToManyRelationship("account")
 Dim campaignEligibleParticipate As Boolean = EligibleCreateManyToManyRelationship("campaign")

 If accountEligibleParticipate AndAlso campaignEligibleParticipate Then

  Dim createManyToManyRelationshipRequest As CreateManyToManyRequest =
   New CreateManyToManyRequest With {
    .IntersectEntitySchemaName = "new_accounts_campaigns",
    .ManyToManyRelationship = New ManyToManyRelationshipMetadata With {
     .SchemaName = "new_accounts_campaigns",
     .Entity1LogicalName = "account",
     .Entity1AssociatedMenuConfiguration =
     New AssociatedMenuConfiguration With {
      .Behavior = AssociatedMenuBehavior.UseLabel,
      .Group = AssociatedMenuGroup.Details,
      .Label = New Label("Account", 1033),
      .Order = 10000
     },
     .Entity2LogicalName = "campaign",
     .Entity2AssociatedMenuConfiguration =
     New AssociatedMenuConfiguration With {
      .Behavior = AssociatedMenuBehavior.UseLabel,
      .Group = AssociatedMenuGroup.Details,
      .Label = New Label("Campaign", 1033),
      .Order = 10000
     }
    }
   }

  Dim createManytoManyRelationshipResponse As CreateManyToManyResponse =
   CType(_serviceProxy.Execute(createManyToManyRelationshipRequest), CreateManyToManyResponse)


  _manyToManyRelationshipId = createManytoManyRelationshipResponse.ManyToManyRelationshipId
  _manyToManyRelationshipName = createManyToManyRelationshipRequest.ManyToManyRelationship.SchemaName

  Console.WriteLine("The many-to-many relationship has been created between {0} and {1}.", "account", "campaign")
 End If

' </snippetworkwithrelationships2>