' <snippetlinqexamples8>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_join4 = From a In svcContext.AccountSet _
                    Join c In svcContext.ContactSet _
                    On a.PrimaryContactId.Id Equals c.ContactId _
                    Join l In svcContext.LeadSet _
                    On a.OriginatingLeadId.Id Equals l.LeadId _
                    Select New With {Key .contact_name = c.FullName,
                                     Key .account_name = a.Name,
                                     Key .lead_name = l.FullName}
  For Each c In query_join4
   Console.WriteLine(c.contact_name &amp; "  " &amp; c.account_name _
                     &amp; "  " &amp; c.lead_name)
  Next c
 End Using

' </snippetlinqexamples8>