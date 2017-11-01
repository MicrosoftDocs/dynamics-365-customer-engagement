// <snippetlinqexamples14>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_equals1 = from c in svcContext.ContactSet
                      where c.FirstName.Equals("Colin")
                      select new
                      {
                       c.FirstName,
                       c.LastName,
                       c.Address1_City
                      };
  foreach (var c in query_equals1)
  {
   System.Console.WriteLine(c.FirstName +
    " " + c.LastName +
    " " + c.Address1_City);
  }
 }

// </snippetlinqexamples14>