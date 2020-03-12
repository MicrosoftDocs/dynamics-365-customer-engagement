' <snippetlinqexamples42>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_pagingsort2 = ( _
      From c In svcContext.ContactSet _
      Where c.LastName IsNot "Parker" _
      Order By c.FirstName Descending _
      Select New With {Key c.FirstName}).Skip(2).Take(2)
  For Each c In query_pagingsort2
   Console.WriteLine(c.FirstName)
  Next c
 End Using

' </snippetlinqexamples42>