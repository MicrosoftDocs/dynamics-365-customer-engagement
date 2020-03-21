// <snippetlinqexamples32>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var list_retrieve1 = from c in svcContext.ContactSet
                       where c.ContactId == _contactId1
                       select new { StatusReason = c.FormattedValues["statuscode"] };
  foreach (var c in list_retrieve1)
  {
   System.Console.WriteLine("Status: " + c.StatusReason);
  }
 }

// </snippetlinqexamples32>