// <snippetlinqexamples23>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_contains1 = from c in svcContext.ContactSet
                        where c.Description.Contains("Alpine")
                        select new
                        {
                         c.FirstName,
                         c.LastName
                        };
  foreach (var c in query_contains1)
  {
   System.Console.WriteLine(c.FirstName + " " + c.LastName);
  }
 }

// </snippetlinqexamples23>