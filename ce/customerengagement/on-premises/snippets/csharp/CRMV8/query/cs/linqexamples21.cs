// <snippetlinqexamples21>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_gt2 = from c in svcContext.ContactSet
                  where c.CreditLimit.Value > 20000
                  select new
                  {
                   c.FirstName,
                   c.LastName,
                   c.Address1_City
                  };
  foreach (var c in query_gt2)
  {
   System.Console.WriteLine(c.FirstName + " " +
    c.LastName + " " + c.Address1_City);
  }
 }

// </snippetlinqexamples21>