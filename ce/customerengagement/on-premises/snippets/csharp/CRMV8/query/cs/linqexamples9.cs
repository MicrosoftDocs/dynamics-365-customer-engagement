// <snippetlinqexamples9>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_join5 = from a in svcContext.AccountSet
                    join a2 in svcContext.AccountSet
                    on a.ParentAccountId.Id equals a2.AccountId

                    select new
                    {
                     account_name = a.Name,
                     account_city = a.Address1_City
                    };
  foreach (var c in query_join5)
  {
   System.Console.WriteLine(c.account_name + "  " + c.account_city);
  }
 }

// </snippetlinqexamples9>