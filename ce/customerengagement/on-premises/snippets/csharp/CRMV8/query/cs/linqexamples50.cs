// <snippetlinqexamples50>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_selectmany = svcContext.ContactSet
                         .Where(c => c.ContactId != _contactId2)
                         .SelectMany(c => c.account_primary_contact)
                         .OrderBy(a => a.Name);
  foreach (var c in query_selectmany)
  {
   System.Console.WriteLine(c.AccountId + " " + c.Name);
  }
 }

// </snippetlinqexamples50>