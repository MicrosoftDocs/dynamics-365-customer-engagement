// <snippetupdateanddelete1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
     serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     CreateRequiredRecords();

     // Retrieve an account.
     var account = _serviceProxy.Retrieve("account", _accountId, new ColumnSet("name","creditlimit"));
     Console.WriteLine("\tThe row version of the created account is {0}", account.RowVersion);

     if (account != null)
     {
         // Create an in-memory account object from the retrieved account.
         Entity updatedAccount = new Entity()
         {
             LogicalName = account.LogicalName,
             Id = account.Id,
             RowVersion = account.RowVersion
         };

         // Update just the credit limit.
         updatedAccount["creditlimit"] = new Money(1000000);

         // Set the request's concurrency behavour to check for a row version match.
         UpdateRequest accountUpdate = new UpdateRequest()
         {
             Target = updatedAccount,
             ConcurrencyBehavior = ConcurrencyBehavior.IfRowVersionMatches
         };

         // Do the update.
         UpdateResponse accountUpdateResponse = (UpdateResponse) _serviceProxy.Execute(accountUpdate);
         Console.WriteLine("Account '{0}' updated with a credit limit of {1}.", account["name"], 
             ((Money)updatedAccount["creditlimit"]).Value);

         account = _serviceProxy.Retrieve("account", updatedAccount.Id, new ColumnSet());
         Console.WriteLine("\tThe row version of the updated account is {0}", account.RowVersion);
         _accountRowVersion = account.RowVersion;
     }

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetupdateanddelete1>