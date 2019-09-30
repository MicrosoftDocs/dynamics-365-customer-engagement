' <snippetlinqexamples23>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_contains1 = From c In svcContext.ContactSet _
                        Where c.Description.Contains("Alpine") _
                        Select New With {Key c.FirstName,
                                         Key c.LastName}
  For Each c In query_contains1
   Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName)
  Next c
 End Using

' </snippetlinqexamples23>