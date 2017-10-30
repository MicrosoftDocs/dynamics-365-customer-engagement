' <snippetworkwithsolutions6>


 ' Remove a Solution Component
 'Remove the Account entity from the solution
 Dim retrieveForRemoveAccountRequest As New RetrieveEntityRequest() With {
  .LogicalName = Account.EntityLogicalName
 }
 Dim retrieveForRemoveAccountResponse As RetrieveEntityResponse =
  CType(_serviceProxy.Execute(retrieveForRemoveAccountRequest), RetrieveEntityResponse)

 Dim removeReq As New RemoveSolutionComponentRequest() With {
  .ComponentId = CType(retrieveForRemoveAccountResponse.EntityMetadata.MetadataId, Guid),
  .ComponentType = componenttype.Entity,
  .SolutionUniqueName = solution.UniqueName
 }
 _serviceProxy.Execute(removeReq)

' </snippetworkwithsolutions6>