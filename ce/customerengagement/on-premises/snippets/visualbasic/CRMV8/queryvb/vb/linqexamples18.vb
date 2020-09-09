' <snippetlinqexamples18>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim methodResults = svcContext.ContactSet _
                      .Where(Function(a) a.LastName.Equals("Smith"))
  Dim methodResults2 = svcContext.ContactSet _
                       .Where(Function(a) a.LastName.StartsWith("Smi"))
  Console.WriteLine()
  Console.WriteLine("Method query using Lambda expression")
  Console.WriteLine("---------------------------------------")
  For Each a In methodResults
   Console.WriteLine("Name: " &amp; a.FirstName &amp; " " &amp; a.LastName)
  Next a
  Console.WriteLine("---------------------------------------")
  Console.WriteLine("Method query 2 using Lambda expression")
  Console.WriteLine("---------------------------------------")
  For Each a In methodResults2
   Console.WriteLine("Name: " &amp; a.Attributes("firstname").ToString() _
                     &amp; " " &amp; a.Attributes("lastname").ToString())
  Next a
 End Using

' </snippetlinqexamples18>