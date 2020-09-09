' <snippetlinqexamples13>


 Using orgSvcContext As New OrganizationServiceContext(_serviceProxy)
  Dim query_join9 = From a In orgSvcContext.CreateQuery("account") _
                    Group Join c In orgSvcContext.CreateQuery("contact") _
                    On a("primarycontactid") Equals c("contactid") Into gr = _
                    Group From c_joined In gr.DefaultIfEmpty() _
                    Select New With {Key .account_name = a.Attributes("name")}
  For Each c In query_join9
   Console.WriteLine(c.account_name)
  Next c
 End Using

' </snippetlinqexamples13>