' <snippetlinqexamples41>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_pagingsort1 = ( _
      From c In svcContext.ContactSet _
      Where c.LastName IsNot "Parker" _
      Order By c.LastName Ascending, c.FirstName Descending _
      Select New With {Key c.FirstName,
                       Key c.LastName}).Skip(2).Take(2)
  For Each c In query_pagingsort1
   Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName)
  Next c
 End Using

' </snippetlinqexamples41>