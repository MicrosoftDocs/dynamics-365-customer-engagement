' <snippetlinqexamples34>


 Using orgSvcContext As New OrganizationServiceContext(_serviceProxy)
  Dim list_getattrib1 = ( _
      From c In orgSvcContext.CreateQuery("contact") _
      Where Not c.GetAttributeValue(Of Guid?)("contactid") _
      .Value.Equals(_contactId1) _
      Select New With
             {
              Key .FirstName = c.GetAttributeValue(Of String)("firstname"),
              Key .LastName = c.GetAttributeValue(Of String)("lastname")}
          ).ToList()
  For Each c In list_getattrib1
   Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName)
  Next c
 End Using

' </snippetlinqexamples34>