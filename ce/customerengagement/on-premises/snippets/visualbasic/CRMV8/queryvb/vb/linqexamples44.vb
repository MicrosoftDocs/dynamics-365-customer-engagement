' <snippetlinqexamples44>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_retrieve1 = From c In svcContext.ContactSet _
                        Join a In svcContext.AccountSet _
                        On c.ContactId Equals a.PrimaryContactId.Id _
                        Where Not c.ContactId.Value.Equals(_contactId1) _
                        Select New With {Key .Contact = c,
                                         Key .Account = a}
  For Each c In query_retrieve1
   Console.WriteLine("Acct: " &amp; c.Account.Name &amp; vbTab &amp; vbTab _
                     &amp; "Contact: " &amp; c.Contact.FullName)
  Next c
 End Using

' </snippetlinqexamples44>