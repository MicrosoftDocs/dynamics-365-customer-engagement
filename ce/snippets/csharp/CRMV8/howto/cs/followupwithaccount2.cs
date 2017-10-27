// <snippetfollowupwithaccount2>



 // Instantiate an account object. Note the use of the option set enumerations defined in OptionSets.cs.
 // See the Entity Metadata topic in the SDK documentation to determine 
 // which attributes must be set for each entity.
 Account account = new Account { Name = "Fourth Coffee" };
 account.AccountCategoryCode = new OptionSetValue((int)AccountAccountCategoryCode.PreferredCustomer);
 account.CustomerTypeCode = new OptionSetValue((int)AccountCustomerTypeCode.Investor);

 // Create an account record named Sample Fourth Coffee.
 _accountId = _serviceProxy.Create(account);

// </snippetfollowupwithaccount2>