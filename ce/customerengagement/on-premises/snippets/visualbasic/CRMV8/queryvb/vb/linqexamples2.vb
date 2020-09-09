' <snippetlinqexamples2>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_where2 = From c In svcContext.AccountSet _
                     Where c.Name.Contains("Contoso") _
                     Where c.Address1_City.Equals("Redmond") _
                     Select c

  For Each c In query_where2
   Console.WriteLine(c.Name &amp; " " &amp; c.Address1_City)
  Next c
 End Using

' </snippetlinqexamples2>