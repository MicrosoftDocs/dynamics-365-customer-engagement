' <snippetlinqexamples33>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_skip = ( _
      From c In svcContext.ContactSet _
      Where c.LastName IsNot "Parker" _
      Order By c.FirstName _
      Select New With {Key .last = c.LastName,
                       Key .first = c.FirstName}).Skip(2).Take(2)
  For Each c In query_skip
   Console.WriteLine(c.first &amp; " " &amp; c.last)
  Next c
 End Using

' </snippetlinqexamples33>