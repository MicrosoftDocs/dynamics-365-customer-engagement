' <snippetlinqexamples29>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_orderby1 = From c In svcContext.ContactSet _
                       Where (Not c.CreditLimit.Equals(Nothing)) _
                       Order By c.CreditLimit Descending _
                       Select New With {Key .limit = c.CreditLimit,
                                        Key .first = c.FirstName,
                                        Key .last = c.LastName}
  For Each c In query_orderby1
   Console.WriteLine(c.limit.Value &amp; " " &amp; c.last &amp; ", " _
                     &amp; c.first)
  Next c
 End Using

' </snippetlinqexamples29>