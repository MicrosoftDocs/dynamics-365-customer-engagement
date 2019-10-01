' <snippetcrudoperations1>


             ' Connect to the Organization service. 
             ' The using statement assures that the service proxy will be properly disposed.
	_serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
             Using _serviceProxy
                 ' This statement is required to enable early-bound type support.
                 _serviceProxy.EnableProxyTypes()

                 CreateRequiredRecords()

                 ' Display information about the logged on user.
                 Dim userid As Guid = (CType(_serviceProxy.Execute(New WhoAmIRequest()), WhoAmIResponse)).UserId
                 Dim systemUser_Renamed As SystemUser = _
                     CType(_serviceProxy.Retrieve("systemuser", userid, New ColumnSet(New String() {"firstname", "lastname"})), SystemUser)
                 Console.WriteLine("Logged on user is {0} {1}.", systemUser_Renamed.FirstName, systemUser_Renamed.LastName)

                 ' Retrieve the version of Microsoft Dynamics CRM.
                 Dim versionRequest As New RetrieveVersionRequest()
                 Dim versionResponse As RetrieveVersionResponse = CType(_serviceProxy.Execute(versionRequest), RetrieveVersionResponse)
                 Console.WriteLine("Microsoft Dynamics CRM version {0}.", versionResponse.Version)


                 ' Instantiate an account object. Note the use of the option set enumerations defined in OptionSets.vb.
                 ' See the Entity Metadata topic in the SDK documentation to determine 
                 ' which attributes must be set for each entity.
                 Dim account_Renamed As Account = New Account With {.Name = "Fourth Coffee"}
                 account_Renamed.AccountCategoryCode = New OptionSetValue(CInt(AccountAccountCategoryCode.PreferredCustomer))
                 account_Renamed.CustomerTypeCode = New OptionSetValue(CInt(AccountCustomerTypeCode.Investor))

                 ' Create an account record named Fourth Coffee.
                 _accountId = _serviceProxy.Create(account_Renamed)


                 Console.Write("{0} {1} created, ", account_Renamed.LogicalName, account_Renamed.Name)

                 ' Retrieve the account containing several of its attributes.
                 Dim cols As New ColumnSet(New String() { "name", "address1_postalcode", "lastusedincampaign" })

                 Dim retrievedAccount As Account = CType(_serviceProxy.Retrieve("account", _accountId, cols), Account)
                 Console.Write("retrieved, ")

                 ' Update the postal code attribute.
                 retrievedAccount.Address1_PostalCode = "98052"

                 ' The address 2 postal code was set accidentally, so set it to null.
                 retrievedAccount.Address2_PostalCode = Nothing

                 ' Shows use of a Money value.
                 retrievedAccount.Revenue = New Money(5000000)

                 ' Shows use of a Boolean value.
                 retrievedAccount.CreditOnHold = False

                 ' Update the account record.
                 _serviceProxy.Update(retrievedAccount)
                 Console.WriteLine("and updated.")

                 DeleteRequiredRecords(promptforDelete)
             End Using

' </snippetcrudoperations1>