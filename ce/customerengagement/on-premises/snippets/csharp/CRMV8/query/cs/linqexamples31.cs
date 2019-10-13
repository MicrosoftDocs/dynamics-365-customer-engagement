// <snippetlinqexamples31>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  Contact firstcontact = svcContext.ContactSet.First();

  Contact singlecontact = svcContext.ContactSet.Single(c => c.ContactId == _contactId1);
  System.Console.WriteLine(firstcontact.LastName + ", " +
   firstcontact.FirstName + " is the first contact");
  System.Console.WriteLine("==========================");
  System.Console.WriteLine(singlecontact.LastName + ", " +
   singlecontact.FirstName + " is the single contact");
 }

// </snippetlinqexamples31>