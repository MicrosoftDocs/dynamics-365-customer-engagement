' <snippetlinqexamples7>


 Using orgSvcContext As New OrganizationServiceContext(_serviceProxy)
  Dim query_join3 = From c In orgSvcContext.CreateQuery("contact") _
                    Join a In orgSvcContext.CreateQuery("account") _
                    On c("contactid") Equals a("primarycontactid") _
                    Select New With {Key .contact_name = c("fullname"),
                                     Key .account_name = a("name")}

  For Each c In query_join3
   Console.WriteLine(c.contact_name.ToString() &amp; "  " _
                     &amp; c.account_name.ToString())
  Next c
 End Using

' </snippetlinqexamples7>