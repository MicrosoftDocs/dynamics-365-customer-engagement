// <snippetlinqexamples26>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_startswith1 = from c in svcContext.ContactSet
                          where c.FirstName.StartsWith("Bri")
                          select new
                          {
                           c.FirstName,
                           c.LastName
                          };
  foreach (var c in query_startswith1)
  {
   System.Console.WriteLine(c.FirstName + " " + c.LastName);
  }
 }

// </snippetlinqexamples26>