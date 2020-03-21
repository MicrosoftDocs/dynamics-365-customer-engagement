// <snippetlinqexamples20>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_gt1 = from c in svcContext.ContactSet
                  where c.Anniversary > new DateTime(2010, 2, 5)
                  select new
                  {
                   c.FirstName,
                   c.LastName,
                   c.Address1_City
                  };

  foreach (var c in query_gt1)
  {
   System.Console.WriteLine(c.FirstName + " " +
    c.LastName + " " + c.Address1_City);
  }
 }

// </snippetlinqexamples20>