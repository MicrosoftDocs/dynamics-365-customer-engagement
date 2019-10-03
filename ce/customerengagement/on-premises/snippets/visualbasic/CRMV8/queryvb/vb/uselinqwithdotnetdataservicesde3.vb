' <snippetuselinqwithdotnetdataservicesde3>


 Dim orderedAccounts = From a In orgContext.CreateQuery("account") _
                       Order By a("name") _
                       Select a("name")
 Console.WriteLine("Display accounts ordered by name")
 Console.WriteLine("================================")
 For Each name In orderedAccounts
  Console.WriteLine(name)
 Next name

' </snippetuselinqwithdotnetdataservicesde3>