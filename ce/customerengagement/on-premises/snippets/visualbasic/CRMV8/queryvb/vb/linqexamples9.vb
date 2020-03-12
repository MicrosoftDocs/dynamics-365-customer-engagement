' <snippetlinqexamples9>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_join5 = From a In svcContext.AccountSet _
                    Join a2 In svcContext.AccountSet _
                    On a.ParentAccountId.Id Equals a2.AccountId _
                    Select New With {
                          Key .account_name = a.Name,
                          Key .account_city = a.Address1_City
                          }
  For Each c In query_join5
   Console.WriteLine(c.account_name &amp; "  " &amp; c.account_city)
  Next c
 End Using

' </snippetlinqexamples9>