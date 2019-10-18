// <snippetlinqexamples43>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_pagingsort3 = (from c in svcContext.ContactSet
                           where c.LastName.StartsWith("W")
                           orderby c.MiddleName ascending,
                           c.FirstName descending
                           select new
                           {
                            c.FirstName,
                            c.MiddleName,
                            c.LastName
                           }).Take(10);
  foreach (var c in query_pagingsort3)
  {
   System.Console.WriteLine(c.FirstName + " " +
    c.MiddleName + " " + c.LastName);
  }
 }

// </snippetlinqexamples43>