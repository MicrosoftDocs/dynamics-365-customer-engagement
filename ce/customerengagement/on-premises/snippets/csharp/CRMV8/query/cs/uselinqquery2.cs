// <snippetuselinqquery2>


 var orderedAccounts = from a in svcContext.AccountSet
                       orderby a.Name
                       select new Account
                       {
                        Name = a.Name,
                       };
 System.Console.WriteLine("Display accounts ordered by name");
 System.Console.WriteLine("================================");
 foreach (var a in orderedAccounts)
 {
  System.Console.WriteLine(a.Name);
 }

// </snippetuselinqquery2>