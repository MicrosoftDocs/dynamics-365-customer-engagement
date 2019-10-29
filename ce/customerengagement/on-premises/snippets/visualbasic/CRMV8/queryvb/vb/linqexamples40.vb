' <snippetlinqexamples40>


 Using orgSvcContext As New OrganizationServiceContext(_serviceProxy)
  Dim query_dejoin = From c In orgSvcContext.CreateQuery("contact") _
                     Join a In orgSvcContext.CreateQuery("account")
                     On c("contactid") Equals a("primarycontactid") _
                     Join l In orgSvcContext.CreateQuery("lead") _
                     On a("originatingleadid") Equals l("leadid") _
                     Select New With {Key .Contact = c,
                                      Key .Account = a,
                                      Key .Lead = l}
  For Each c In query_dejoin
   Console.WriteLine(c.Account.Attributes("name").ToString() _
                     &amp; " " _
                     &amp; c.Contact.Attributes("fullname").ToString() _
                     &amp; " " _
                     &amp; c.Lead.Attributes("leadid").ToString())
  Next c
 End Using

' </snippetlinqexamples40>