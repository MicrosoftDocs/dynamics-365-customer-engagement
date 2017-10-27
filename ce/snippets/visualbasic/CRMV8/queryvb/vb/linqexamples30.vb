' <snippetlinqexamples30>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_orderby2 = From c In svcContext.ContactSet _
                       Order By c.LastName Descending, _
                       c.FirstName Ascending _
                       Select New With {Key .first = c.FirstName,
                                        Key .last = c.LastName}

  For Each c In query_orderby2
   Console.WriteLine(c.last &amp; ", " &amp; c.first)
  Next c
 End Using

' </snippetlinqexamples30>