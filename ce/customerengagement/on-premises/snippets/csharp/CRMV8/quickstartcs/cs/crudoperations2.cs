// <snippetcrudoperations2>


 // Instantiate an account object. Note the use of the option set enumerations defined
 // in OptionSets.cs.
 Account account = new Account { Name = "Fourth Coffee" };
 account.AccountCategoryCode = new OptionSetValue((int)AccountAccountCategoryCode.PreferredCustomer);
 account.CustomerTypeCode = new OptionSetValue((int)AccountCustomerTypeCode.Investor);

 // Create an account record named Fourth Coffee.
 // Save the record reference so we can delete it during cleanup later.
 Guid accountId = service.Create(account);

// </snippetcrudoperations2>