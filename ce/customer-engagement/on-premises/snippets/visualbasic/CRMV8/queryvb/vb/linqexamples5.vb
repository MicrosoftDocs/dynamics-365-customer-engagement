' <snippetlinqexamples5>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_join1 = From c In svcContext.ContactSet _
                    Join a In svcContext.AccountSet _
                    On c.ContactId Equals a.account_primary_contact.Id _
                    Select New With {Key c.FullName, Key c.Address1_City,
                                     Key a.Name, Key a.Address1_Name}
  For Each c In query_join1
   Console.WriteLine("acct: " &amp; c.Name &amp; vbTab &amp; vbTab _
                     &amp; vbTab &amp; "contact: " &amp; c.FullName)
  Next c
 End Using

' </snippetlinqexamples5>