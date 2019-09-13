// <snippetworkwithrelationships5>


 DeleteRelationshipRequest deleteOneToManyRelationshipRequest = 
     new DeleteRelationshipRequest
 {                    
     Name = "new_account_campaign"
 };

 _serviceProxy.Execute(deleteOneToManyRelationshipRequest);

 DeleteRelationshipRequest deleteManyToManyRelationshipRequest = 
     new DeleteRelationshipRequest
 {
     Name = "new_accounts_campaigns"
 };

 _serviceProxy.Execute(deleteManyToManyRelationshipRequest);

 Console.WriteLine("Entity Relationships have been deleted.");

// </snippetworkwithrelationships5>