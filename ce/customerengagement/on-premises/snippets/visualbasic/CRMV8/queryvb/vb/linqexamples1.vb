' <snippetlinqexamples1>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_where1 = From c In svcContext.AccountSet _
                     Where c.Name.Contains("Contoso") _
                     Select c

  For Each c In query_where1
   Console.WriteLine(c.Name &amp; " " &amp; c.Address1_City)
  Next c
 End Using

' </snippetlinqexamples1>