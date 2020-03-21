' <snippetlinqexamples36>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_joincond = From a1 In svcContext.AccountSet _
                       Join a2 In svcContext.AccountSet _
                       On a1.ParentAccountId.Id Equals a2.AccountId _
                       Where a2.AccountId.Value.Equals(_accountId1) _
                       Select New With {Key .Account = a1,
                                        Key .Parent = a2}
  For Each a In query_joincond
   Console.WriteLine(a.Account.Name &amp; " " &amp; a.Parent.Name)
  Next a
 End Using

' </snippetlinqexamples36>