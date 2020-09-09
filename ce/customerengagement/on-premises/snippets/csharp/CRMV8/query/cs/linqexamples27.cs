// <snippetlinqexamples27>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_endswith1 = from c in svcContext.ContactSet
                        where c.LastName.EndsWith("cox")
                        select new
                        {
                         c.FirstName,
                         c.LastName
                        };
  foreach (var c in query_endswith1)
  {
   System.Console.WriteLine(c.FirstName + " " + c.LastName);
  }
 }

// </snippetlinqexamples27>