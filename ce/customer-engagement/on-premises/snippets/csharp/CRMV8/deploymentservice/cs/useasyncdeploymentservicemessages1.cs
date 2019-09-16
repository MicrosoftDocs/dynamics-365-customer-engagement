// <snippetuseasyncdeploymentservicemessages1>


 // Instantiate DeploymentServiceClient for calling the service.
 client =
     ProxyClientHelper.CreateClient(
     new Uri(serverConfig.DiscoveryUri.ToString()
         .Replace("Services", "Deployment")
         .Replace("Discovery", "Deployment")));

 // Setting credentials from the current security context. 
 if (serverConfig.Credentials == null)
 {
     client.ClientCredentials.Windows.ClientCredential =
         CredentialCache.DefaultNetworkCredentials;
 }
 else
 {
     client.ClientCredentials.Windows.ClientCredential =
         serverConfig.Credentials.Windows.ClientCredential;
 }

 using (client)
 {
     // Set properties for the new organization
     Microsoft.Xrm.Sdk.Deployment.Organization organization = 
         new Microsoft.Xrm.Sdk.Deployment.Organization
     {
         BaseCurrencyCode = "USD",
         BaseCurrencyName = "US Dollar",
         BaseCurrencyPrecision = 2,
         BaseCurrencySymbol = "$",
         BaseLanguageCode = 1033,
         FriendlyName = _friendlyName,
         UniqueName = _uniqueName,
         SqlCollation = "Latin1_General_CI_AI",
         SqlServerName = _sqlServerName,
         SrsUrl = _srsUrl,
         SqmIsEnabled = false
     };

     // Create a request for the deployment web service
     // CRM server app pool must have permissions on SQL server
     BeginCreateOrganizationRequest request = 
         new BeginCreateOrganizationRequest
     {
         Organization = organization,
         SysAdminName = _sysAdminName
     };

     // Execute the request
     BeginCreateOrganizationResponse response = 
         (BeginCreateOrganizationResponse)client.Execute(request);

     // The operation is asynchronous, so the response object contains
     // a unique identifier for the operation
     Guid operationId = response.OperationId;

     // Retrieve the Operation using the OperationId
     RetrieveRequest retrieveOperationStatus = new RetrieveRequest();
     retrieveOperationStatus.EntityType = 
         DeploymentEntityType.DeferredOperationStatus;
     retrieveOperationStatus.InstanceTag = 
         new EntityInstanceId { Id = operationId };

     RetrieveResponse retrieveResponse;
     DeferredOperationStatus deferredOperationStatus;

     Console.WriteLine("Retrieving state of the job...");

     // Retrieve the Operation State until Organization is created
     do
     {
         // Wait 3 secs to not overload server
         Thread.Sleep(3000);

         retrieveResponse =
         (RetrieveResponse)client.Execute(retrieveOperationStatus);

         deferredOperationStatus = 
             ((DeferredOperationStatus)retrieveResponse.Entity);
     }
     while (deferredOperationStatus.State != 
         DeferredOperationState.Processing &&
         deferredOperationStatus.State != 
         DeferredOperationState.Completed);

     // Poll OrganizationStatusRequest
     RetrieveRequest retrieveReqServer = new RetrieveRequest();
     retrieveReqServer.EntityType = DeploymentEntityType.Organization;
     retrieveReqServer.InstanceTag = new EntityInstanceId();
     retrieveReqServer.InstanceTag.Name = organization.UniqueName;

     RetrieveResponse retrieveRespServer;
     OrganizationState orgState;

     Console.WriteLine("Retrieving state of the organization...");

     // Retrieve and check the Organization State until is enabled
     do
     {
         retrieveRespServer =
             (RetrieveResponse)client.Execute(retrieveReqServer);
         _organizationID = 
             ((Microsoft.Xrm.Sdk.Deployment.Organization)retrieveRespServer.Entity).Id;
         orgState =
             ((Microsoft.Xrm.Sdk.Deployment.Organization)retrieveRespServer.Entity).State;

         // Wait 5 secs to not overload server
         Thread.Sleep(5000);
     }
     while (orgState != OrganizationState.Enabled);

     Console.WriteLine("Organization has been created!");

// </snippetuseasyncdeploymentservicemessages1>