' <snippetlinqexamples19>


 Using orgSvcContext As New OrganizationServiceContext(_serviceProxy)
  Dim query_ne3 = From c In orgSvcContext.CreateQuery("contact") _
                  Where (Not c("address1_city").Equals(Nothing)) _
                  Select New With {Key .FirstName = c("firstname"),
                                   Key .LastName = c("lastname"),
                                   Key .Address1_City =
                                   c("address1_city")}
  For Each c In query_ne3
   Console.WriteLine(c.FirstName.ToString() &amp; " " _
                     &amp; c.LastName.ToString() &amp; " " _
                     &amp; c.Address1_City.ToString())
  Next c
 End Using

' </snippetlinqexamples19>