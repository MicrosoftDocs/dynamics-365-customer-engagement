// <snippetlinqexamples37>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_wheretrans = from c in svcContext.ContactSet
                         where c.ContactId == _contactId1 &&
                         c.Anniversary > DateTime.Parse("1/1/2010")
                         select new
                         {
                          c.FirstName,
                          c.LastName
                         };
  foreach (var c in query_wheretrans)
  {
   System.Console.WriteLine(c.FirstName + " " + c.LastName);
  }
 }

// </snippetlinqexamples37>