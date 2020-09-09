// <snippetlinqexamples10>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_join6 = from c in svcContext.ContactSet
                    join a in svcContext.AccountSet
                    on c.ContactId equals a.PrimaryContactId.Id
                    join a2 in svcContext.AccountSet
                    on a.ParentAccountId.Id equals a2.AccountId
                    select new
                    {
                     contact_name = c.FullName,
                     account_name = a.Name
                    };
  foreach (var c in query_join6)
  {
   System.Console.WriteLine(c.contact_name + "  " + c.account_name);
  }
 }

// </snippetlinqexamples10>