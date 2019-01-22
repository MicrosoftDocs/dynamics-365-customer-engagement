// <snippetworkwithrelationships2>



 bool accountEligibleParticipate =
     EligibleCreateManyToManyRelationship("account");
 bool campaignEligibleParticipate =
     EligibleCreateManyToManyRelationship("campaign");

 if (accountEligibleParticipate && campaignEligibleParticipate)
 {

     CreateManyToManyRequest createManyToManyRelationshipRequest =
         new CreateManyToManyRequest
     {
         IntersectEntitySchemaName = "new_accounts_campaigns",
         ManyToManyRelationship = new ManyToManyRelationshipMetadata
         {
             SchemaName = "new_accounts_campaigns",
             Entity1LogicalName = "account",
             Entity1AssociatedMenuConfiguration =
             new AssociatedMenuConfiguration
             {
                 Behavior = AssociatedMenuBehavior.UseLabel,
                 Group = AssociatedMenuGroup.Details,
                 Label = new Label("Account", 1033),
                 Order = 10000
             },
             Entity2LogicalName = "campaign",
             Entity2AssociatedMenuConfiguration =
             new AssociatedMenuConfiguration
             {
                 Behavior = AssociatedMenuBehavior.UseLabel,
                 Group = AssociatedMenuGroup.Details,
                 Label = new Label("Campaign", 1033),
                 Order = 10000
             }
         }
     };

     CreateManyToManyResponse createManytoManyRelationshipResponse =
         (CreateManyToManyResponse)_serviceProxy.Execute(
         createManyToManyRelationshipRequest);


     _manyToManyRelationshipId =
         createManytoManyRelationshipResponse.ManyToManyRelationshipId;
     _manyToManyRelationshipName =
         createManyToManyRelationshipRequest.ManyToManyRelationship.SchemaName;

     Console.WriteLine(
         "The many-to-many relationship has been created between {0} and {1}.",
         "account", "campaign");
 }

// </snippetworkwithrelationships2>