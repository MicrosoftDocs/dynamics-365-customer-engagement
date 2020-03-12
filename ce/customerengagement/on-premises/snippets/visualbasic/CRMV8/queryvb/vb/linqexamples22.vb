' <snippetlinqexamples22>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_gele1 = From c In svcContext.ContactSet _
                    Where c.CreditLimit.Value >= 200 _
                    AndAlso c.CreditLimit.Value <= 400 _
                    Select New With {Key c.FirstName,
                                     Key c.LastName}
  For Each c In query_gele1
   Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName)
  Next c
 End Using

' </snippetlinqexamples22>