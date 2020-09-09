// <snippetuselinqwithdotnetdataservicesde2>


 int pageSize = 5;

 var accountsByPage = from a in orgContext.CreateQuery("account")
                      select a["name"];
 System.Console.WriteLine("Skip 10 accounts, then Take 5 accounts");
 System.Console.WriteLine("======================================");
 foreach (var name in accountsByPage.Skip(2 * pageSize).Take(pageSize))
 {
  System.Console.WriteLine(name);
 }

// </snippetuselinqwithdotnetdataservicesde2>