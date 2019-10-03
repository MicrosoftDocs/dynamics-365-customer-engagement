' <snippetinvokeduplicatedetectionforcreateandupdate1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     _service = CType(_serviceProxy, IOrganizationService)

     CreateRequiredRecords()

     ' Create and account record with the named Proseware, Inc. and already existing Account Number.
     Dim account As Account = New Account With {.Name = "Proseware, Inc.", .AccountNumber = "ACC005"}

     ' Create operation by suppressing duplicate detection
     Dim reqCreate As New CreateRequest()
     reqCreate.Target = account
     reqCreate.Parameters.Add("SuppressDuplicateDetection", True) ' Change to false to activate the duplicate detection.
     Dim createResponse As CreateResponse = CType(_service.Execute(reqCreate), CreateResponse)
     _dupAccountId = createResponse.id
     Console.Write("Account: {0} {1} created with SuppressDuplicateDetection to true, ", account.Name, account.AccountNumber)

     ' Retrieve the account containing with its few attributes.
     Dim cols As New ColumnSet(New String() { "name", "accountnumber"})

     Dim retrievedAccount As Account = CType(_service.Retrieve("account", _dupAccountId, cols), Account)
     Console.Write("retrieved, ")

     ' Update the existing account with new account number.
     retrievedAccount.AccountNumber = "ACC006"

     ' Update operation – update record, if a duplicate is not found.
     Dim reqUpdate As New UpdateRequest()
     reqUpdate.Target = retrievedAccount
     reqUpdate("SuppressDuplicateDetection") = False ' Duplicate detection is activated.

     ' Update the account record.
     Dim updateResponse As UpdateResponse = CType(_service.Execute(reqUpdate), UpdateResponse)
     Console.WriteLine("and updated.")

     DeleteRequiredRecords(promptforDelete)
 End Using

' </snippetinvokeduplicatedetectionforcreateandupdate1>