// <snippetlinqexamples35>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {

  Contact firstorcontact = svcContext.ContactSet.FirstOrDefault();

  Contact singleorcontact = svcContext.ContactSet
   .SingleOrDefault(c => c.ContactId == _contactId1);


  System.Console.WriteLine(firstorcontact.FullName +
   " is the first contact");
  System.Console.WriteLine("==========================");
  System.Console.WriteLine(singleorcontact.FullName +
   " is the single contact");
 }

// </snippetlinqexamples35>