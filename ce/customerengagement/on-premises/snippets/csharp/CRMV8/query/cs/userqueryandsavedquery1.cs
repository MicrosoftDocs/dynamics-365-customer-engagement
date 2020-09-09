// <snippetuserqueryandsavedquery1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     CreateRequiredRecords();

     #region Validate saved query
     
     // Create the request
     ValidateSavedQueryRequest validateRequest = new ValidateSavedQueryRequest()
     {
         FetchXml = _savedQuery.FetchXml,
         QueryType = _savedQuery.QueryType.Value
     };
     
     // Send the request
     Console.WriteLine("  Validating Saved Query");
     try
     {
         // executing the request will throw an exception if the fetch xml is invalid
         var validateResponse = (ValidateSavedQueryResponse)_serviceProxy.Execute(validateRequest);
         Console.WriteLine("  Saved Query validated successfully");
     }
     catch (Exception)
     {
         Console.WriteLine("  Invalid Saved Query");
         throw;
     }
     
     #endregion

     #region Execute saved query

     // Create the request
     ExecuteByIdSavedQueryRequest executeSavedQueryRequest = new ExecuteByIdSavedQueryRequest()
     {
         EntityId = _savedQuery.Id
     };

     // Execute the request
     Console.WriteLine("  Executing Saved Query");
     ExecuteByIdSavedQueryResponse executeSavedQueryResponse =
         (ExecuteByIdSavedQueryResponse)_serviceProxy.Execute(executeSavedQueryRequest);

     // Check results
     if (String.IsNullOrEmpty(executeSavedQueryResponse.String))
         throw new Exception("Saved Query did not return any results");

     PrintResults(executeSavedQueryResponse.String);
     #endregion

     #region Execute user query

     // Create the request
     ExecuteByIdUserQueryRequest executeUserQuery = new ExecuteByIdUserQueryRequest()
     {
         EntityId = _userQuery.ToEntityReference()
     };

     // Send the request
     Console.WriteLine("  Executing User Query");
     ExecuteByIdUserQueryResponse executeUserQueryResponse =
         (ExecuteByIdUserQueryResponse)_serviceProxy.Execute(executeUserQuery);
     if (String.IsNullOrEmpty(executeUserQueryResponse.String))
         throw new Exception("User Query did not return any results");

     // validate results
     PrintResults(executeUserQueryResponse.String);

     #endregion

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetuserqueryandsavedquery1>