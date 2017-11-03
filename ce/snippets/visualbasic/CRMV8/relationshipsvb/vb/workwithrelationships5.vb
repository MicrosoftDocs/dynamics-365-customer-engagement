' <snippetworkwithrelationships5>


 Dim deleteOneToManyRelationshipRequest As DeleteRelationshipRequest =
  New DeleteRelationshipRequest With {
   .Name = "new_account_campaign"
  }

 _serviceProxy.Execute(deleteOneToManyRelationshipRequest)

 Dim deleteManyToManyRelationshipRequest As DeleteRelationshipRequest =
  New DeleteRelationshipRequest With {
   .Name = "new_accounts_campaigns"
  }

 _serviceProxy.Execute(deleteManyToManyRelationshipRequest)

 Console.WriteLine("Entity Relationships have been deleted.")

' </snippetworkwithrelationships5>