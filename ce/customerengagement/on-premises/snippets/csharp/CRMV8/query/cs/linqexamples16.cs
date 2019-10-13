// <snippetlinqexamples16>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_ne1 = from c in svcContext.ContactSet
                  where c.Address1_City != "Redmond"
                  select new
                  {
                   c.FirstName,
                   c.LastName,
                   c.Address1_City
                  };
  foreach (var c in query_ne1)
  {
   System.Console.WriteLine(c.FirstName + " " +
    c.LastName + " " + c.Address1_City);
  }
 }

// </snippetlinqexamples16>