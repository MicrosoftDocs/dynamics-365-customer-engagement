// <snippetlinqexamples29>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_orderby1 = from c in svcContext.ContactSet
                       where !c.CreditLimit.Equals(null)
                       orderby c.CreditLimit descending
                       select new
                       {
                        limit = c.CreditLimit,
                        first = c.FirstName,
                        last = c.LastName
                       };
  foreach (var c in query_orderby1)
  {
   System.Console.WriteLine(c.limit.Value + " " +
    c.last + ", " + c.first);
  }
 }

// </snippetlinqexamples29>