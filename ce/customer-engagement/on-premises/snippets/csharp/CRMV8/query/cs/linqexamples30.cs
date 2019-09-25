// <snippetlinqexamples30>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_orderby2 = from c in svcContext.ContactSet
                       orderby c.LastName descending,
                       c.FirstName ascending
                       select new
                       {
                        first = c.FirstName,
                        last = c.LastName
                       };

  foreach (var c in query_orderby2)
  {
   System.Console.WriteLine(c.last + ", " + c.first);
  }
 }

// </snippetlinqexamples30>