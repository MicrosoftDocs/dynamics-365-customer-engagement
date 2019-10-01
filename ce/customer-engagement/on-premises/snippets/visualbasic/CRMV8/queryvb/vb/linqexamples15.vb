' <snippetlinqexamples15>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_equals2 = From c In svcContext.ContactSet _
                      Where c.FamilyStatusCode.Equals(3) _
                      Select New With {Key c.FirstName,
                                       Key c.LastName,
                                       Key c.Address1_City}
  For Each c In query_equals2
   Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName &amp; " " _
                     &amp; c.Address1_City)
  Next c
 End Using

' </snippetlinqexamples15>