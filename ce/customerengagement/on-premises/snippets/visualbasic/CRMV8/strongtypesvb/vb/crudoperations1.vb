' <snippetcrudoperations1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()


     CreateRequiredRecords()

     ' Instantiate an account object.
     ' See the Entity Metadata topic in the SDK documentation to determine 
     ' which attributes must be set for each entity.
     Dim account_Renamed As Account = New Account With {.Name = "Fourth Coffee"}

     ' Create an account record named Fourth Coffee.
     _accountId = _serviceProxy.Create(account_Renamed)
     Console.Write("{0} {1} created, ", account_Renamed.LogicalName, account_Renamed.Name)

     ' Retrieve the account containing several of its attributes.
     Dim cols As New ColumnSet(New String() {"name", "address1_postalcode", "lastusedincampaign", "versionnumber"})

     Dim retrievedAccount As Account = CType(_serviceProxy.Retrieve("account", _accountId, cols), Account)
     Console.Write("retrieved ")

     ' Retrieve version number of the account. Shows BigInt attribute usage.
     Dim versionNumber? As Long = retrievedAccount.VersionNumber

     If versionNumber IsNot Nothing Then
         Console.WriteLine("version # {0}, ", versionNumber)
     End If

     ' Update the postal code attribute.
     retrievedAccount.Address1_PostalCode = "98052"

     ' The address 2 postal code was set accidentally, so set it to null.
     retrievedAccount.Address2_PostalCode = Nothing

     ' Shows usage of option set (picklist) enumerations defined in OptionSets.cs.
     retrievedAccount.Address1_AddressTypeCode = New OptionSetValue(CInt(Fix(AccountAddress1_AddressTypeCode.Primary)))
     retrievedAccount.Address1_ShippingMethodCode = New OptionSetValue(CInt(Fix(AccountAddress1_ShippingMethodCode.DHL)))
     retrievedAccount.IndustryCode = New OptionSetValue(CInt(Fix(AccountIndustryCode.AgricultureandNonpetrolNaturalResourceExtraction)))

     ' Shows use of a Money value.
     retrievedAccount.Revenue = New Money(5000000)

     ' Shows use of a Boolean value.
     retrievedAccount.CreditOnHold = False

     ' Shows use of EntityReference.
     retrievedAccount.ParentAccountId = New EntityReference(Account.EntityLogicalName, _parentAccountId)

     ' Shows use of Memo attribute.
     retrievedAccount.Description = "Account for Fourth Coffee."

     ' Update the account record.
     _serviceProxy.Update(retrievedAccount)
     Console.WriteLine("and updated.")

     DeleteRequiredRecords(promptforDelete)
 End Using

' </snippetcrudoperations1>