// <snippetlinqexamples44>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_retrieve1 = from c in svcContext.ContactSet
                        join a in svcContext.AccountSet
                        on c.ContactId equals a.PrimaryContactId.Id
                        where c.ContactId != _contactId1
                        select new { Contact = c, Account = a };
  foreach (var c in query_retrieve1)
  {
   System.Console.WriteLine("Acct: " + c.Account.Name +
    "\t\t" + "Contact: " + c.Contact.FullName);
  }
 }

// </snippetlinqexamples44>