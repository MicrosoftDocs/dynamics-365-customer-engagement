' <snippetcreatealinqquery3>


 Dim accountsWithCounty As Integer = ( _
     From a In svcContext.AccountSet _
     Where (a.Address1_County IsNot Nothing) _
     Select New Account With
            {
                .Name = a.Name,
                .Address1_City = a.Address1_City
            }
        ).ToArray().Count()
 Console.Write("Number of accounts with a county specified: ")
 Console.WriteLine(accountsWithCounty)

' </snippetcreatealinqquery3>