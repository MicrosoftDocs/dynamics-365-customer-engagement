// <snippetlinqexamples36>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_joincond = from a1 in svcContext.AccountSet
                       join a2 in svcContext.AccountSet
                       on a1.ParentAccountId.Id equals a2.AccountId
                       where a2.AccountId == _accountId1
                       select new { Account = a1, Parent = a2 };
  foreach (var a in query_joincond)
  {
   System.Console.WriteLine(a.Account.Name + " " + a.Parent.Name);
  }
 }

// </snippetlinqexamples36>