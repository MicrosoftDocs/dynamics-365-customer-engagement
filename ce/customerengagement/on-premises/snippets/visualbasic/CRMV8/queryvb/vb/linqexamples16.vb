' <snippetlinqexamples16>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_ne1 = From c In svcContext.ContactSet _
                  Where c.Address1_City IsNot "Redmond" _
                  Select New With {Key c.FirstName,
                                   Key c.LastName,
                                   Key c.Address1_City}
  For Each c In query_ne1
   Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName _
                     &amp; " " &amp; c.Address1_City)
  Next c
 End Using

' </snippetlinqexamples16>