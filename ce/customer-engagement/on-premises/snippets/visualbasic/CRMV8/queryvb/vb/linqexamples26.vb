' <snippetlinqexamples26>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_startswith1 = From c In svcContext.ContactSet _
                          Where c.FirstName.StartsWith("Bri") _
                          Select New With {Key c.FirstName,
                                           Key c.LastName}
  For Each c In query_startswith1
   Console.WriteLine(c.FirstName.ToString() &amp; " " _
                     &amp; c.LastName.ToString())
  Next c
 End Using

' </snippetlinqexamples26>