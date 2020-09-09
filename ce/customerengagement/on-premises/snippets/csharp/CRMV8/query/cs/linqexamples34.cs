// <snippetlinqexamples34>


 using (OrganizationServiceContext orgSvcContext = new OrganizationServiceContext(_serviceProxy))
 {

  var list_getattrib1 = (from c in orgSvcContext.CreateQuery("contact")
                         where c.GetAttributeValue<Guid?>("contactid") != _contactId1
                         select new { 
                          FirstName = c.GetAttributeValue<string>("firstname"), 
                          LastName = c.GetAttributeValue<string>("lastname") 
                         }).ToList();
  foreach (var c in list_getattrib1)
  {
   System.Console.WriteLine(c.FirstName + " " + c.LastName);
  }
 }

// </snippetlinqexamples34>