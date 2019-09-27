// <snippetlinqexamples15>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_equals2 = from c in svcContext.ContactSet
                      where c.FamilyStatusCode.Equals(3)
                      select new
                      {
                       c.FirstName,
                       c.LastName,
                       c.Address1_City
                      };
  foreach (var c in query_equals2)
  {
   System.Console.WriteLine(c.FirstName +
    " " + c.LastName +
    " " + c.Address1_City);
  }
 }

// </snippetlinqexamples15>