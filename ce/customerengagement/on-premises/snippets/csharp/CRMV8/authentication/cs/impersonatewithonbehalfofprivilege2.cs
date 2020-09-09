// <snippetimpersonatewithonbehalfofprivilege2>


 // Connect to the Organization service. 
 // The using statement ensures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     CreateRequiredRecords();

     // Retrieve the system user ID of the user to impersonate.
     OrganizationServiceContext orgContext = new OrganizationServiceContext(_serviceProxy);
     _userId = (from user in orgContext.CreateQuery<SystemUser>()
               where user.FullName == "Kevin Cook"
               select user.SystemUserId.Value).FirstOrDefault();

     // To impersonate another user, set the OrganizationServiceProxy.CallerId
     // property to the ID of the other user.
     _serviceProxy.CallerId = _userId;

     // Instantiate an account object.
     // See the Entity Metadata topic in the SDK documentation to determine 
     // which attributes must be set for each entity.
     Account account = new Account { Name = "Fourth Coffee" };

     // Create an account record named Fourth Coffee.
     _accountId = _serviceProxy.Create(account);
     Console.Write("{0} {1} created, ", account.LogicalName, account.Name);

// </snippetimpersonatewithonbehalfofprivilege2>