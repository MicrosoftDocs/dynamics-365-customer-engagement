// <snippetuselinqwithdotnetdataservicesde3>


 var orderedAccounts = from a in orgContext.CreateQuery("account")
                       orderby a["name"]
                       select a["name"];
 System.Console.WriteLine("Display accounts ordered by name");
 System.Console.WriteLine("================================");
 foreach (var name in orderedAccounts)
 {
  System.Console.WriteLine(name);
 }

// </snippetuselinqwithdotnetdataservicesde3>