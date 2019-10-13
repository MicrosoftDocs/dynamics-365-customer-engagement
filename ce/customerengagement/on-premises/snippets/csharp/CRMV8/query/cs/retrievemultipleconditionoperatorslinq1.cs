// <snippetretrievemultipleconditionoperatorslinq1>


 var contacts = (from c in svcContext.ContactSet
                 join a in svcContext.AccountSet on c.ParentCustomerId.Id equals a.AccountId
                 where (a.Name == "Litware, Inc.")
                 where (c.Address1_StateOrProvince == "WA"
                 && (c.Address1_Telephone1.StartsWith("(206)") ||
                     c.Address1_Telephone1.StartsWith("(425)"))
                 && (c.Address1_City == "Redmond" ||
                     c.Address1_City == "Bellevue" ||
                     c.Address1_City == "Kirkland" ||
                     c.Address1_City == "Seattle")
                 && (c.EMailAddress1 != null && c.EMailAddress1 != ""))
                 select new Contact
                 {
                  ContactId = c.ContactId,
                  FirstName = c.FirstName,
                  LastName = c.LastName,
                  Address1_Telephone1 = c.Address1_Telephone1
                 });

 // Display the results.
 Console.WriteLine("List all contacts matching specified parameters");
 Console.WriteLine("===============================================");
 foreach (Contact contact in contacts)
 {
  Console.WriteLine("Contact ID: {0}", contact.Id);
  Console.WriteLine("Contact Name: {0}", contact.FullName);
  Console.WriteLine("Contact Phone: {0}", contact.Address1_Telephone1);
 }
 Console.WriteLine("<End of Listing>");
 Console.WriteLine();
 #endregion

// </snippetretrievemultipleconditionoperatorslinq1>