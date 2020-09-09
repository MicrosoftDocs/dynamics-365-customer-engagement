// <snippetlinqexamples3>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_where3 = from c in svcContext.ContactSet
                     join a in svcContext.AccountSet
                     on c.ContactId equals a.PrimaryContactId.Id
                     where a.Name.Contains("Contoso")
                     where c.LastName.Contains("Smith")
                     select new
                     {
                      account_name = a.Name,
                      contact_name = c.LastName
                     };

  foreach (var c in query_where3)
  {
   System.Console.WriteLine("acct: " +
    c.account_name +
    "\t\t\t" +
    "contact: " +
    c.contact_name);
  }
 }

// </snippetlinqexamples3>