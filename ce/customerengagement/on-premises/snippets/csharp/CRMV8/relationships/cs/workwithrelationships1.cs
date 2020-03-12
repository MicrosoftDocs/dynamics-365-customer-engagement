// <snippetworkwithrelationships1>



 bool eligibleCreateOneToManyRelationship =
     EligibleCreateOneToManyRelationship("account", "campaign");

 if (eligibleCreateOneToManyRelationship)
 {
     CreateOneToManyRequest createOneToManyRelationshipRequest =
         new CreateOneToManyRequest
     {
         OneToManyRelationship =
         new OneToManyRelationshipMetadata
         {
             ReferencedEntity = "account",
             ReferencingEntity = "campaign",
             SchemaName = "new_account_campaign",
             AssociatedMenuConfiguration = new AssociatedMenuConfiguration
             {
                 Behavior = AssociatedMenuBehavior.UseLabel,
                 Group = AssociatedMenuGroup.Details,
                 Label = new Label("Account", 1033),
                 Order = 10000
             },
             CascadeConfiguration = new CascadeConfiguration
             {
                 Assign = CascadeType.NoCascade,
                 Delete = CascadeType.RemoveLink,
                 Merge = CascadeType.NoCascade,
                 Reparent = CascadeType.NoCascade,
                 Share = CascadeType.NoCascade,
                 Unshare = CascadeType.NoCascade
             }
         },
         Lookup = new LookupAttributeMetadata
         {
             SchemaName = "new_parent_accountid",
             DisplayName = new Label("Account Lookup", 1033),
             RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
             Description = new Label("Sample Lookup", 1033)
         }
     };


     CreateOneToManyResponse createOneToManyRelationshipResponse =
         (CreateOneToManyResponse)_serviceProxy.Execute(
         createOneToManyRelationshipRequest);

     _oneToManyRelationshipId =
         createOneToManyRelationshipResponse.RelationshipId;
     _oneToManyRelationshipName = 
         createOneToManyRelationshipRequest.OneToManyRelationship.SchemaName;

     Console.WriteLine(
         "The one-to-many relationship has been created between {0} and {1}.",
         "account", "campaign");
 }

// </snippetworkwithrelationships1>