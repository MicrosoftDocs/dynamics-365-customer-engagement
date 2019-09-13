// <snippetsharingrecords1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     _service = (IOrganizationService)_serviceProxy;

     CreateRequiredRecords();

     #region GrantAccess Message

     // Create the request object and set the target and principal access
     // object.
     GrantAccessRequest grantRequest = new GrantAccessRequest()
     {
         Target = new EntityReference(Account.EntityLogicalName, _accountId),
         PrincipalAccess = new PrincipalAccess()
         {
             Principal = new EntityReference(SystemUser.EntityLogicalName, _userId),
             AccessMask = AccessRights.WriteAccess | AccessRights.ReadAccess | AccessRights.ShareAccess
         }
     };

     // Execute the request.
     GrantAccessResponse grantResponse =
         (GrantAccessResponse)_service.Execute(grantRequest);

     Console.Write("Access Granted ");

     #endregion

     #region ModifyAccess Message

     // Create the request object and set the target and principal access
     // object.
     ModifyAccessRequest modifyRequest = new ModifyAccessRequest()
     {
         Target = new EntityReference(Account.EntityLogicalName, _accountId),
         PrincipalAccess = new PrincipalAccess()
         {
             Principal = new EntityReference(SystemUser.EntityLogicalName, _userId),
             AccessMask = AccessRights.ReadAccess | AccessRights.ShareAccess
         }
     };

     // Execute the request.
     ModifyAccessResponse modifyResponse =
         (ModifyAccessResponse)_service.Execute(modifyRequest);

     Console.Write("and Modified. ");

     #endregion

     #region RetrievePrincipalAccess Message

     // Create the request object and set the target and principal.
     RetrievePrincipalAccessRequest retrieveRequest = new RetrievePrincipalAccessRequest()
     {
         Target = new EntityReference(Account.EntityLogicalName, _accountId),
         Principal = new EntityReference(SystemUser.EntityLogicalName, _userId)
     };

     // Execute the request.
     RetrievePrincipalAccessResponse retrieveResponse = 
         (RetrievePrincipalAccessResponse)_service.Execute(retrieveRequest);

     Console.Write("Retrieved principal access. ");

     #endregion

     #region RetrieveSharedPrincipalsAndAccess Message

     // Create the request object and set the target.
     RetrieveSharedPrincipalsAndAccessRequest retrieveSharedRequest = 
         new RetrieveSharedPrincipalsAndAccessRequest()
     {
         Target = new EntityReference(Account.EntityLogicalName, _accountId)
     };

     // Execute the request.
     RetrieveSharedPrincipalsAndAccessResponse retrieveSharedResponse = 
         (RetrieveSharedPrincipalsAndAccessResponse)_service.Execute(retrieveSharedRequest);

     Console.Write("Retrieved principals and access. ");

     #endregion

     #region RevokeAccess Message

     // Create the request object and set the target and revokee.
     RevokeAccessRequest revokeRequest = new RevokeAccessRequest()
     {
         Target = new EntityReference(Account.EntityLogicalName, _accountId),
         Revokee = new EntityReference(SystemUser.EntityLogicalName, _userId)
     };

     // Execute the request.
     RevokeAccessResponse revokeResponse =
         (RevokeAccessResponse)_service.Execute(revokeRequest);

     Console.Write("Revoked Access.");

     #endregion

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetsharingrecords1>