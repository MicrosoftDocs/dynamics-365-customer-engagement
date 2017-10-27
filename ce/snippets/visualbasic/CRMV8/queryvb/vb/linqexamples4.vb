' <snippetlinqexamples4>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_distinct = ( _
      From c In svcContext.ContactSet _
      Select c.LastName).Distinct()
  For Each c In query_distinct
   Console.WriteLine(c)
  Next c
 End Using

' </snippetlinqexamples4>