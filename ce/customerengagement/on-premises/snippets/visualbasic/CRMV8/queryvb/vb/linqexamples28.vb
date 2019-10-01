' <snippetlinqexamples28>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_andor1 = From c In svcContext.ContactSet _
                     Where c.Address1_City.Equals("Redmond") _
                     OrElse c.Address1_City.Equals("Bellevue") _
                     AndAlso c.CreditLimit.Value >= 200 _
                     Select New With {Key c.FirstName,
                                      Key c.LastName,
                                      Key c.CreditLimit,
                                      Key c.Address1_City}
  For Each c In query_andor1
   Console.WriteLine(c.LastName.ToString() &amp; ", " _
                     &amp; c.FirstName.ToString() &amp; " " _
                     &amp; c.Address1_City.ToString() &amp; " " _
                     &amp; c.CreditLimit.Value.ToString())
  Next c
 End Using

' </snippetlinqexamples28>