// <snippetimpersonatewithonbehalfofprivilege1>


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

     // Retrieve the account containing several of its attributes.
     // CreatedBy should reference the impersonated SystemUser.
     // CreatedOnBehalfBy should reference the running SystemUser.
     ColumnSet cols = new ColumnSet(
         "name",
         "createdby",
         "createdonbehalfby",
         "address1_postalcode",
         "lastusedincampaign");

     Account retrievedAccount =
         (Account)_serviceProxy.Retrieve(Account.EntityLogicalName,
             _accountId, cols);
     Console.Write("retrieved, ");

     // Update the postal code attribute.
     retrievedAccount.Address1_PostalCode = "98052";

     // The address 2 postal code was set accidentally, so set it to null.
     retrievedAccount.Address2_PostalCode = null;

     // Shows use of a Money value.
     retrievedAccount.Revenue = new Money(5000000);

     // Shows use of a boolean value.
     retrievedAccount.CreditOnHold = false;

     // Update the account record.
     _serviceProxy.Update(retrievedAccount);
     Console.Write("updated, ");

     // Delete the account record.
     _serviceProxy.Delete(Account.EntityLogicalName, _accountId);
     Console.WriteLine("and deleted.");

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetimpersonatewithonbehalfofprivilege1>