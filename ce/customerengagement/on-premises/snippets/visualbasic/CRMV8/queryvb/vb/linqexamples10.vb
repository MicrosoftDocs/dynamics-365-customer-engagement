' <snippetlinqexamples10>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_join6 = From c In svcContext.ContactSet _
                    Join a In svcContext.AccountSet _
                    On c.ContactId Equals a.PrimaryContactId.Id _
                    Join a2 In svcContext.AccountSet _
                    On a.ParentAccountId.Id Equals a2.AccountId _
                    Select New With {Key .contact_name = c.FullName,
                                     Key .account_name = a.Name}
  For Each c In query_join6
   Console.WriteLine(c.contact_name &amp; "  " &amp; c.account_name)
  Next c
 End Using

' </snippetlinqexamples10>