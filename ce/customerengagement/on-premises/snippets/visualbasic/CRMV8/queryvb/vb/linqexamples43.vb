' <snippetlinqexamples43>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_pagingsort3 = ( _
      From c In svcContext.ContactSet _
      Where c.LastName.StartsWith("W") _
      Order By c.MiddleName Ascending, c.FirstName Descending _
      Select New With {Key c.FirstName,
                       Key c.MiddleName,
                       Key c.LastName}).Take(10)
  For Each c In query_pagingsort3
   Console.WriteLine(c.FirstName &amp; " " &amp; c.MiddleName &amp; " " &amp; c.LastName)
  Next c
 End Using

' </snippetlinqexamples43>