' <snippetcrudoperationsde1>


 ' Instaniate an account object.
 Dim account As New Entity("account")

 ' Set the required attributes. For account, only the name is required. 
 ' See the Entity Metadata topic in the SDK documentatio to determine 
 ' which attributes must be set for each entity.
 account("name") = "Fourth Coffee"

 ' Create an account record named Fourth Coffee.
 _accountId = _service.Create(account)

 Console.Write("{0} {1} created, ", account.LogicalName, account.Attributes("name"))

 ' Create a column set to define which attributes should be retrieved.
 Dim attributes As New ColumnSet(New String() { "name", "ownerid" })

 ' Retrieve the account and its name and ownerid attributes.
 account = _service.Retrieve(account.LogicalName, _accountId, attributes)
 Console.Write("retrieved, ")

 ' Update the postal code attribute.
 account("address1_postalcode") = "98052"

 ' The address 2 postal code was set accidentally, so set it to null.
 account("address2_postalcode") = Nothing

 ' Shows use of Money.
 account("revenue") = New Money(5000000)

 ' Shows use of boolean.
 account("creditonhold") = False

 ' Update the account.
 _service.Update(account)
 Console.WriteLine("and updated.")

 ' Delete the account.
 Dim deleteRecords As Boolean = True

 If promptForDelete Then
             Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
     Dim answer As String = Console.ReadLine()

             deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty)
 End If

 If deleteRecords Then
     _service.Delete("account", _accountId)

     Console.WriteLine("Entity record(s) have been deleted.")
 End If

' </snippetcrudoperationsde1>