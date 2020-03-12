// <snippetlinqexamples17>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_ne2 = from c in svcContext.ContactSet
                  where !c.FirstName.Equals("Colin")
                  select new
                  {
                   c.FirstName,
                   c.LastName,
                   c.Address1_City
                  };

  foreach (var c in query_ne2)
  {
   System.Console.WriteLine(c.FirstName + " " +
    c.LastName + " " + c.Address1_City);
  }
 }

// </snippetlinqexamples17>