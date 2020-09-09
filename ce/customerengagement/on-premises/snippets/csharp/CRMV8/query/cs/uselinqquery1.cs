// <snippetuselinqquery1>


 int pageSize = 5;

 var accountsByPage = (from a in svcContext.AccountSet
                       select new Account
                       {
                        Name = a.Name,
                       });
 System.Console.WriteLine("Skip 10 accounts, then Take 5 accounts");
 System.Console.WriteLine("======================================");
 foreach (var a in accountsByPage.Skip(2 * pageSize).Take(pageSize))
 {
  System.Console.WriteLine(a.Name);
 }

// </snippetuselinqquery1>