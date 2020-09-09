// <snippetcreatealinqquery1>


 var accounts = from a in svcContext.AccountSet
                select new Account
                {
                 Name = a.Name,
                 Address1_County = a.Address1_County
                };
 System.Console.WriteLine("List all accounts in CRM");
 System.Console.WriteLine("========================");
 foreach (var a in accounts)
 {
  System.Console.WriteLine(a.Name + " " + a.Address1_County);
 }

// </snippetcreatealinqquery1>