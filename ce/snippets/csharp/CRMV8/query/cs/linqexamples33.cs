// <snippetlinqexamples33>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {

  var query_skip = (from c in svcContext.ContactSet
                    where c.LastName != "Parker"
                    orderby c.FirstName
                    select new
                        {
                         last = c.LastName,
                         first = c.FirstName
                        }).Skip(2).Take(2);
  foreach (var c in query_skip)
  {
   System.Console.WriteLine(c.first + " " + c.last);
  }
 }

// </snippetlinqexamples33>