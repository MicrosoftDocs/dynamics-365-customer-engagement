// <snippetcrudoperations1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     CreateRequiredRecords();

     // Instantiate an account object.
     // See the Entity Metadata topic in the SDK documentation to determine 
     // which attributes must be set for each entity.
     Account account = new Account { Name = "Fourth Coffee" };

     // Create an account record named Fourth Coffee.
     _accountId = _serviceProxy.Create(account);
     Console.Write("{0} {1} created, ", account.LogicalName, account.Name);

     // Retrieve the account containing several of its attributes.
     ColumnSet cols = new ColumnSet(
         new String[] { "name", "address1_postalcode", "lastusedincampaign", "versionnumber" });

     Account retrievedAccount = (Account)_serviceProxy.Retrieve("account", _accountId, cols);
     Console.Write("retrieved ");

     // Retrieve version number of the account. Shows BigInt attribute usage.
     long? versionNumber = retrievedAccount.VersionNumber;

     if (versionNumber != null)
         Console.WriteLine("version # {0}, ", versionNumber);

     // Update the postal code attribute.
     retrievedAccount.Address1_PostalCode = "98052";

     // The address 2 postal code was set accidentally, so set it to null.
     retrievedAccount.Address2_PostalCode = null;

     // Shows usage of option set (picklist) enumerations defined in OptionSets.cs.
     retrievedAccount.Address1_AddressTypeCode = new OptionSetValue((int)AccountAddress1_AddressTypeCode.Primary);
     retrievedAccount.Address1_ShippingMethodCode = new OptionSetValue((int)AccountAddress1_ShippingMethodCode.DHL);
     retrievedAccount.IndustryCode = new OptionSetValue((int)AccountIndustryCode.AgricultureandNonpetrolNaturalResourceExtraction);

     // Shows use of a Money value.
     retrievedAccount.Revenue = new Money(5000000);

     // Shows use of a Boolean value.
     retrievedAccount.CreditOnHold = false;

     // Shows use of EntityReference.
     retrievedAccount.ParentAccountId = new EntityReference(Account.EntityLogicalName, _parentAccountId);

     // Shows use of Memo attribute.
     retrievedAccount.Description = "Account for Fourth Coffee.";

     // Update the account record.
     _serviceProxy.Update(retrievedAccount);
     Console.WriteLine("and updated.");                    

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetcrudoperations1>