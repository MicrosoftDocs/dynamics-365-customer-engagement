' <snippetlinqexamples38>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_orderbylookup = From a In svcContext.AccountSet _
                            Where a.Address1_Name.Equals("Contoso Pharmaceuticals") _
                            Order By a.PrimaryContactId _
                            Select New With {Key a.Name,
                                             Key a.Address1_City}
  For Each a In query_orderbylookup
   Console.WriteLine(a.Name &amp; " " &amp; a.Address1_City)
  Next a
 End Using

' </snippetlinqexamples38>