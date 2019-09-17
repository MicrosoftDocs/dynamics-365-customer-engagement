' <snippetlinqexamples46>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_projections = From c In svcContext.ContactSet _
                          Where c.ContactId.Value.Equals(_contactId1) _
                          And Not c.NumberOfChildren.Equals(Nothing) _
                          And Not c.Anniversary.Equals(Nothing) _
         Select New With
                {Key .Contact =
                    New Contact With
                    {.LastName = c.LastName,
                     .NumberOfChildren = c.NumberOfChildren},
                 Key .NumberOfChildren = CDbl(c.NumberOfChildren),
                 Key .Anniversary = c.Anniversary.Value.AddYears(1)}
  For Each c In query_projections
   Console.WriteLine(c.Contact.LastName &amp; " " &amp; c.NumberOfChildren _
                     &amp; " " &amp; c.Anniversary)
  Next c
 End Using

' </snippetlinqexamples46>