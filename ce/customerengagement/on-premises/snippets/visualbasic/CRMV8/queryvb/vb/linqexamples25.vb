' <snippetlinqexamples25>


 Using orgSvcContext As New OrganizationServiceContext(_serviceProxy)
  Dim query_contains3 = From c In orgSvcContext.CreateQuery("contact") _
                        Where (CStr(c("description"))).Contains("Coho") _
                        Select New With
                              {Key .firstname = c.Attributes("firstname"),
                              Key .lastname = c.Attributes("lastname")}

  For Each c In query_contains3
   Console.WriteLine(c.firstname.ToString() &amp; " " _
                     &amp; c.lastname.ToString())
  Next c
 End Using

' </snippetlinqexamples25>