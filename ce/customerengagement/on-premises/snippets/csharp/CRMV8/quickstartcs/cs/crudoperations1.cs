// <snippetcrudoperations1>


 /// <summary>
 /// This method performs entity create, retrieve, and update operations.
 /// The delete operation is handled in the DeleteRequiredrecords() method.
 /// </summary>
 /// <param name="serviceProxy">An established connection to the Organization web service.</param>
 /// <param name="records">A collection of entity records created by this sample.</param>
 public void Run(OrganizationServiceProxy serviceProxy, EntityReferenceCollection records)
 {
     // Enable early-bound entity types. This enables use of IntelliSense in Visual Studio
     // and avoids spelling errors in attribute names when using the Entity property bag.
     serviceProxy.EnableProxyTypes();

     // Here we will use the interface instead of the proxy object.
     IOrganizationService service = (IOrganizationService)serviceProxy;

     // Display information about the logged on user.
     Guid userid = ((WhoAmIResponse)service.Execute(new WhoAmIRequest())).UserId;
     SystemUser systemUser = (SystemUser)service.Retrieve("systemuser", userid,
         new ColumnSet(new string[] { "firstname", "lastname" }));
     Console.WriteLine("Logged on user is {0} {1}.", systemUser.FirstName, systemUser.LastName);

     // Retrieve the version of Microsoft Dynamics CRM.
     RetrieveVersionRequest versionRequest = new RetrieveVersionRequest();
     RetrieveVersionResponse versionResponse =
         (RetrieveVersionResponse)service.Execute(versionRequest);
     Console.WriteLine("Microsoft Dynamics CRM version {0}.", versionResponse.Version);

     // Instantiate an account object. Note the use of the option set enumerations defined
     // in OptionSets.cs.
     Account account = new Account { Name = "Fourth Coffee" };
     account.AccountCategoryCode = new OptionSetValue((int)AccountAccountCategoryCode.PreferredCustomer);
     account.CustomerTypeCode = new OptionSetValue((int)AccountCustomerTypeCode.Investor);

     // Create an account record named Fourth Coffee.
     // Save the record reference so we can delete it during cleanup later.
     Guid accountId = service.Create(account);
     var eref = new EntityReference(Account.EntityLogicalName, accountId);
     eref.Name = account.Name;
     records.Add(eref);

     Console.Write("{0} {1} created, ", account.LogicalName, account.Name);

     // Retrieve the account containing several of its attributes. This results in
     // better performance compared to retrieving all attributes.
     ColumnSet cols = new ColumnSet(
         new String[] { "name", "address1_postalcode", "lastusedincampaign" });

     Account retrievedAccount = (Account)service.Retrieve("account", accountId, cols);
     Console.Write("retrieved, ");

     // Update the postal code attribute.
     retrievedAccount.Address1_PostalCode = "98052";

     // There is no address 2 postal code needed.
     retrievedAccount.Address2_PostalCode = null;

     // Shows use of a Money value.
     retrievedAccount.Revenue = new Money(5000000);

     // Shows use of a Boolean value.
     retrievedAccount.CreditOnHold = false;

     // Update the account record.
     service.Update(retrievedAccount);
     Console.WriteLine("and updated.");
 }

// </snippetcrudoperations1>