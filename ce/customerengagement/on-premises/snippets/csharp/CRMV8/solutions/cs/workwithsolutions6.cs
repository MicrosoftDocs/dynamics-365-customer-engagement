// <snippetworkwithsolutions6>


 // Remove a Solution Component
 //Remove the Account entity from the solution
 RetrieveEntityRequest retrieveForRemoveAccountRequest = new RetrieveEntityRequest()
 {
     LogicalName = Account.EntityLogicalName
 };
 RetrieveEntityResponse retrieveForRemoveAccountResponse = (RetrieveEntityResponse)_serviceProxy.Execute(retrieveForRemoveAccountRequest);

 RemoveSolutionComponentRequest removeReq = new RemoveSolutionComponentRequest()
 {
     ComponentId = (Guid)retrieveForRemoveAccountResponse.EntityMetadata.MetadataId,
     ComponentType = (int)componenttype.Entity,
     SolutionUniqueName = solution.UniqueName
 };
 _serviceProxy.Execute(removeReq);

// </snippetworkwithsolutions6>