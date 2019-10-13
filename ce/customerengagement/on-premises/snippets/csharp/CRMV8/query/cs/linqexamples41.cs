// <snippetlinqexamples41>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_pagingsort1 = (from c in svcContext.ContactSet
                           where c.LastName != "Parker"
                           orderby c.LastName ascending,
                           c.FirstName descending
                           select new { c.FirstName, c.LastName })
                           .Skip(2).Take(2);
  foreach (var c in query_pagingsort1)
  {
   System.Console.WriteLine(c.FirstName + " " + c.LastName);
  }
 }

// </snippetlinqexamples41>