' <snippetlinqexamples21>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_gt2 = From c In svcContext.ContactSet _
                  Where c.CreditLimit.Value > 20000 _
                  Select New With {Key c.FirstName,
                                   Key c.LastName,
                                   Key c.Address1_City}
  For Each c In query_gt2
   Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName _
                     &amp; " " &amp; c.Address1_City)
  Next c
 End Using

' </snippetlinqexamples21>