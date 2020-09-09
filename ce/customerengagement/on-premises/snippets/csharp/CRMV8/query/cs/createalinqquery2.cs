// <snippetcreatealinqquery2>


 var queryAccounts = from a in svcContext.AccountSet
                     join owner in svcContext.SystemUserSet
                       on a.OwnerId.Id equals owner.SystemUserId
                     where owner.LastName != "Cannon"
                     select new Account
                     {
                      Name = a.Name,
                      Address1_City = a.Address1_City
                     };
 System.Console.WriteLine("Accounts not owned by user w/ last name 'Cannon'");
 System.Console.WriteLine("================================================");
 foreach (var a in queryAccounts)
 {
  System.Console.WriteLine(a.Name + " " + a.Address1_County);
 }

// </snippetcreatealinqquery2>