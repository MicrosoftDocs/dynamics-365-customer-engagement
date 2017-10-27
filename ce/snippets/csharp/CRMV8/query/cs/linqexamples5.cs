// <snippetlinqexamples5>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_join1 = from c in svcContext.ContactSet
                    join a in svcContext.AccountSet
                   on c.ContactId equals a.PrimaryContactId.Id
                    select new
                    {
                     c.FullName,
                     c.Address1_City,
                     a.Name,
                     a.Address1_Name
                    };
  foreach (var c in query_join1)
  {
   System.Console.WriteLine("acct: " +
    c.Name +
    "\t\t\t" +
    "contact: " +
    c.FullName);
  }
 }

// </snippetlinqexamples5>