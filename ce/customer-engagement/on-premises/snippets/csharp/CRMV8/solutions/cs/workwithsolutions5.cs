// <snippetworkwithsolutions5>


 // Add an existing Solution Component
 //Add the Account entity to the solution
 RetrieveEntityRequest retrieveForAddAccountRequest = new RetrieveEntityRequest()
 {
     LogicalName = Account.EntityLogicalName
 };
 RetrieveEntityResponse retrieveForAddAccountResponse = (RetrieveEntityResponse)_serviceProxy.Execute(retrieveForAddAccountRequest);
 AddSolutionComponentRequest addReq = new AddSolutionComponentRequest()
 {
     ComponentType = (int)componenttype.Entity,
     ComponentId = (Guid)retrieveForAddAccountResponse.EntityMetadata.MetadataId,
     SolutionUniqueName = solution.UniqueName
 };
 _serviceProxy.Execute(addReq);

// </snippetworkwithsolutions5>