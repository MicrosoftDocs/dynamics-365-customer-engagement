' <snippetlinqexamples24>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_contains2 = From c In svcContext.ContactSet _
                        Where (Not c.Description.Contains("Coho")) _
                        Select New With {Key c.FirstName,
                                         Key c.LastName}
  For Each c In query_contains2
   Console.WriteLine(c.FirstName.ToString() &amp; " " _
                     &amp; c.LastName.ToString())
  Next c
 End Using

' </snippetlinqexamples24>