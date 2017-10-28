' <snippetworkwithsolutions5>


 ' Add an existing Solution Component
 'Add the Account entity to the solution
 Dim retrieveForAddAccountRequest As New RetrieveEntityRequest() With {
  .LogicalName = Account.EntityLogicalName
 }
 Dim retrieveForAddAccountResponse As RetrieveEntityResponse =
  CType(_serviceProxy.Execute(retrieveForAddAccountRequest), 
   RetrieveEntityResponse)
 Dim addReq As New AddSolutionComponentRequest() With {
  .ComponentType = componenttype.Entity,
  .ComponentId = CType(retrieveForAddAccountResponse.EntityMetadata.MetadataId, Guid),
  .SolutionUniqueName = solution.UniqueName
 }
 _serviceProxy.Execute(addReq)

' </snippetworkwithsolutions5>