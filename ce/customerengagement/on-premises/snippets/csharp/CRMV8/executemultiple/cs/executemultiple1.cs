// <snippetexecutemultiple1>


 // Get a reference to the organization service.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // Enable early-bound type support to add/update entity records required for this sample.
     _serviceProxy.EnableProxyTypes();
     
     #region Execute Multiple with Results
     // Create an ExecuteMultipleRequest object.
     requestWithResults = new ExecuteMultipleRequest()
     {
         // Assign settings that define execution behavior: continue on error, return responses. 
         Settings = new ExecuteMultipleSettings()
         {
             ContinueOnError = false,
             ReturnResponses = true
         },
         // Create an empty organization request collection.
         Requests = new OrganizationRequestCollection()
     };

     // Create several (local, in memory) entities in a collection. 
     EntityCollection input = GetCollectionOfEntitiesToCreate();

     // Add a CreateRequest for each entity to the request collection.
     foreach (var entity in input.Entities)
     {
         CreateRequest createRequest = new CreateRequest { Target = entity };
         requestWithResults.Requests.Add(createRequest);
     }

     // Execute all the requests in the request collection using a single web method call.
     ExecuteMultipleResponse responseWithResults =
         (ExecuteMultipleResponse)_serviceProxy.Execute(requestWithResults);

     // Display the results returned in the responses.
     foreach (var responseItem in responseWithResults.Responses)
     {
         // A valid response.
         if (responseItem.Response != null)
             DisplayResponse(requestWithResults.Requests[responseItem.RequestIndex], responseItem.Response);

         // An error has occurred.
         else if (responseItem.Fault != null)
             DisplayFault(requestWithResults.Requests[responseItem.RequestIndex], 
                 responseItem.RequestIndex, responseItem.Fault);
     }

// </snippetexecutemultiple1>