' <snippetcrudoperations2>



 ' Instantiate an account object. Note the use of the option set enumerations defined in OptionSets.vb.
 ' See the Entity Metadata topic in the SDK documentation to determine 
 ' which attributes must be set for each entity.
 Dim account_Renamed As Account = New Account With {.Name = "Fourth Coffee"}
 account_Renamed.AccountCategoryCode = New OptionSetValue(CInt(AccountAccountCategoryCode.PreferredCustomer))
 account_Renamed.CustomerTypeCode = New OptionSetValue(CInt(AccountCustomerTypeCode.Investor))

 ' Create an account record named Fourth Coffee.
 _accountId = _serviceProxy.Create(account_Renamed)

' </snippetcrudoperations2>