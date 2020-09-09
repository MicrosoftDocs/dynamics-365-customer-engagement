// <snippetlinqexamples24>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_contains2 = from c in svcContext.ContactSet
                        where !c.Description.Contains("Coho")
                        select new
                        {
                         c.FirstName,
                         c.LastName
                        };
  foreach (var c in query_contains2)
  {
   System.Console.WriteLine(c.FirstName + " " + c.LastName);
  }
 }

// </snippetlinqexamples24>