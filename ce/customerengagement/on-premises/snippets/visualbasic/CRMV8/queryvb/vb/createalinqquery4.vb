' <snippetcreatealinqquery4>


 Dim statesWithAccounts As Integer = ( _
     From a In svcContext.AccountSet _
     Where (a.Address1_StateOrProvince IsNot Nothing) _
     Select a.Address1_StateOrProvince).Distinct().ToArray().Count()
 Console.Write("Number of unique states that contain accounts: ")
 Console.WriteLine(statesWithAccounts)

' </snippetcreatealinqquery4>