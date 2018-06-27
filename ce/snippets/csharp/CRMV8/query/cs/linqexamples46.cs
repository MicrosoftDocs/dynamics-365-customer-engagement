// <snippetlinqexamples46>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_projections = from c in svcContext.ContactSet
                          where c.ContactId == _contactId1
                          && c.NumberOfChildren != null && 
                          c.Anniversary.Value != null
                          select new
                          {
                           Contact = new Contact { 
                            LastName = c.LastName, 
                            NumberOfChildren = c.NumberOfChildren 
                           },
                           NumberOfChildren = (double)c.NumberOfChildren,
                           Anniversary = c.Anniversary.Value.AddYears(1),
                          };
  foreach (var c in query_projections)
  {
   System.Console.WriteLine(c.Contact.LastName + " " + 
    c.NumberOfChildren + " " + c.Anniversary);
  }
 }

// </snippetlinqexamples46>