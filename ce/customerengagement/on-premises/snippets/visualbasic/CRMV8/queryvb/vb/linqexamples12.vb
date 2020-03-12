' <snippetlinqexamples12>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_join8 = From a In svcContext.AccountSet _
                    Group Join c In svcContext.ContactSet _
                    On a.PrimaryContactId.Id Equals c.ContactId Into gr = _
                    Group From c_joined In gr.DefaultIfEmpty() _
                    Select New With {Key .contact_name = c_joined.FullName,
                                     Key .account_name = a.Name}
  For Each c In query_join8
   Console.WriteLine(c.contact_name &amp; "  " &amp; c.account_name)
  Next c
 End Using

' </snippetlinqexamples12>