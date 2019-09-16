' <snippetlinqexamples3>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_where3 = From c In svcContext.ContactSet _
                     Join a In svcContext.AccountSet _
                     On c.ContactId Equals a.account_primary_contact.Id _
                     Where a.Name.Contains("Contoso") _
                     Where c.LastName.Contains("Smith") _
                     Select New With {Key .account_name = a.Name,
                                      Key .contact_name = c.LastName}

  For Each c In query_where3
   Console.WriteLine("acct: " &amp; c.account_name &amp; vbTab &amp; vbTab _
                     &amp; vbTab &amp; "contact: " &amp; c.contact_name)
  Next c
 End Using

' </snippetlinqexamples3>