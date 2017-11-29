// <snippetlinqexamples42>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_pagingsort2 = (from c in svcContext.ContactSet
                           where c.LastName != "Parker"
                           orderby c.FirstName descending
                           select new { c.FirstName }).Skip(2).Take(2);
  foreach (var c in query_pagingsort2)
  {
   System.Console.WriteLine(c.FirstName);
  }
 }

// </snippetlinqexamples42>