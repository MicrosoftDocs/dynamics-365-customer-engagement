' <snippetuselinqwithdotnetdataservicesde2>


 Dim pageSize As Integer = 5

 Dim accountsByPage = From a In orgContext.CreateQuery("account") _
                      Select a("name")
 Console.WriteLine("Skip 10 accounts, then Take 5 accounts")
 Console.WriteLine("======================================")
 For Each name In accountsByPage.Skip(2 * pageSize).Take(pageSize)
  Console.WriteLine(name)
 Next name

' </snippetuselinqwithdotnetdataservicesde2>