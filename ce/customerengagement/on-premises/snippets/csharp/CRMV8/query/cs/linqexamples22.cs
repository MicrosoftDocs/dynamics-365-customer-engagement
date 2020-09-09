// <snippetlinqexamples22>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_gele1 = from c in svcContext.ContactSet
                    where c.CreditLimit.Value >= 200 &&
                    c.CreditLimit.Value <= 400
                    select new
                    {
                     c.FirstName,
                     c.LastName
                    };
  foreach (var c in query_gele1)
  {
   System.Console.WriteLine(c.FirstName + " " + c.LastName);
  }
 }

// </snippetlinqexamples22>