// <snippetexecutetransaction2>


 ExecuteTransactionRequest requestForUpdates = new ExecuteTransactionRequest()
 {
     Requests = new OrganizationRequestCollection()
 };

 // Update the entities that were previously created.
 EntityCollection update = GetCollectionOfEntitiesToUpdate();

 foreach (var entity in update.Entities)
 {
     UpdateRequest updateRequest = new UpdateRequest { Target = entity };
     requestForUpdates.Requests.Add(updateRequest);
 }

 try
 {
     ExecuteTransactionResponse responseForUpdates =
         (ExecuteTransactionResponse)_serviceProxy.Execute(requestForUpdates);
     Console.WriteLine("Entity records are updated.");
 }
 catch (FaultException<OrganizationServiceFault> ex)
 {
     Console.WriteLine("Update request failed for the account{0} and the reason being: {1}",
         ((ExecuteTransactionFault)(ex.Detail)).FaultedRequestIndex + 1, ex.Detail.Message);
 }

// </snippetexecutetransaction2>