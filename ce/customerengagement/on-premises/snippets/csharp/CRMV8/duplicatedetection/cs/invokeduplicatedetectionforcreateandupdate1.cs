// <snippetinvokeduplicatedetectionforcreateandupdate1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     _service = (IOrganizationService)_serviceProxy;

     CreateRequiredRecords();

     // Create and account record with the named Proseware, Inc. and already existing Account Number.
     Account account = new Account 
     {
         Name = "Proseware, Inc.",
         AccountNumber = "ACC005"
     };

     // Create operation by suppressing duplicate detection
     CreateRequest reqCreate = new CreateRequest();
     reqCreate.Target = account;
     reqCreate.Parameters.Add("SuppressDuplicateDetection", true); // Change to false to activate the duplicate detection.
     CreateResponse createResponse = (CreateResponse)_service.Execute(reqCreate);
     _dupAccountId = createResponse.id;
     Console.Write("Account: {0} {1} created with SuppressDuplicateDetection to true, ", 
         account.Name, account.AccountNumber);
     
     // Retrieve the account containing with its few attributes.
     ColumnSet cols = new ColumnSet(
         new String[] { "name", "accountnumber"});

     Account retrievedAccount = (Account)_service.Retrieve("account", _dupAccountId, cols);
     Console.Write("retrieved, ");

     // Update the existing account with new account number.
     retrievedAccount.AccountNumber = "ACC006";                   

     // Update operation – update record, if a duplicate is not found.
     UpdateRequest reqUpdate = new UpdateRequest();
     reqUpdate.Target = retrievedAccount;
     reqUpdate["SuppressDuplicateDetection"] = false; // Duplicate detection is activated.

     // Update the account record.
     UpdateResponse updateResponse = (UpdateResponse)_service.Execute(reqUpdate);
     Console.WriteLine("and updated.");

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetinvokeduplicatedetectionforcreateandupdate1>