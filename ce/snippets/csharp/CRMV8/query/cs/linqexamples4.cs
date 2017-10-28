// <snippetlinqexamples4>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_distinct = (from c in svcContext.ContactSet
                        select c.LastName).Distinct();
  foreach (var c in query_distinct)
  {
   System.Console.WriteLine(c);
  }
 }

// </snippetlinqexamples4>