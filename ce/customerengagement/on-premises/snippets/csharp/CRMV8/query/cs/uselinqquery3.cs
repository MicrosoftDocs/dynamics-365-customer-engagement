// <snippetuselinqquery3>


 var query = from c in svcContext.ContactSet
             join a in svcContext.AccountSet
                           on c.ContactId equals a.PrimaryContactId.Id
             where c.LastName == "Wilcox" || c.LastName == "Andrews"
             where a.Address1_Telephone1.Contains("(206)")
                 || a.Address1_Telephone1.Contains("(425)")
             select new
             {
              Contact = new Contact
              {
               FirstName = c.FirstName,
               LastName = c.LastName,
              },
              Account = new Account
              {
               Address1_Telephone1 = a.Address1_Telephone1
              }
             };

 Console.WriteLine("Join account and contact");
 Console.WriteLine("List all records matching specified parameters");
 Console.WriteLine("Contact name: Wilcox or Andrews");
 Console.WriteLine("Account area code: 206 or 425");
 Console.WriteLine("==============================================");
 foreach (var record in query)
 {
  Console.WriteLine("Contact Name: {0} {1}",
      record.Contact.FirstName, record.Contact.LastName);
  Console.WriteLine("Account Phone: {0}",
      record.Account.Address1_Telephone1);
 }

// </snippetuselinqquery3>