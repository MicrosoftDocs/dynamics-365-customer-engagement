// <snippetexecutetransaction1>


 // Create an ExecuteTransactionRequest object.
 requestToCreateRecords = new ExecuteTransactionRequest()
 {
     // Create an empty organization request collection.
     Requests = new OrganizationRequestCollection(),
     ReturnResponses = true
 };

 // Create several (local, in memory) entities in a collection. 
 EntityCollection input = GetCollectionOfEntitiesToCreate();

 // Add a CreateRequest for each entity to the request collection.
 foreach (var entity in input.Entities)
 {
     CreateRequest createRequest = new CreateRequest { Target = entity };
     requestToCreateRecords.Requests.Add(createRequest);
 }

 // Execute all the requests in the request collection using a single web method call.
 try
 {
     var responseForCreateRecords =
         (ExecuteTransactionResponse)_serviceProxy.Execute(requestToCreateRecords);

     int i = 0;
     // Display the results returned in the responses.
     foreach (var responseItem in responseForCreateRecords.Responses)
     {
         if (responseItem != null)
             DisplayResponse(requestToCreateRecords.Requests[i], responseItem);
         i++;
     }
 }
 catch (FaultException<OrganizationServiceFault> ex)
 {
     Console.WriteLine("Create request failed for the account{0} and the reason being: {1}",
         ((ExecuteTransactionFault)(ex.Detail)).FaultedRequestIndex + 1, ex.Detail.Message);
     throw;
 }

// </snippetexecutetransaction1>