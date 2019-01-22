// <snippetcreatealinqquery5>


 var queryContacts = from c in svcContext.ContactSet
                     where (c.Address1_City == "Redmond") &&
                           (c.FirstName.Equals("Joe") ||
                            c.FirstName.Equals("John"))
                     select new Contact
                     {
                      FirstName = c.FirstName,
                      LastName = c.LastName,
                      Address1_City = c.Address1_City
                     };
 System.Console.WriteLine("Contacts in Redmond named Joe OR John");
 System.Console.WriteLine("=====================================");
 foreach (var c in queryContacts)
 {
  System.Console.WriteLine(c.FirstName + " " +
      c.LastName + " " + c.Address1_City);
 }

// </snippetcreatealinqquery5>