// <snippetlinqexamples19>


 using (OrganizationServiceContext orgSvcContext = new OrganizationServiceContext(_serviceProxy))
 {
  var query_ne3 = from c in orgSvcContext.CreateQuery("contact")
                  where !c["address1_city"].Equals(null)
                  select new
                  {
                   FirstName = c["firstname"],
                   LastName = c["lastname"],
                   Address1_City = c["address1_city"]
                  };
  foreach (var c in query_ne3)
  {
   System.Console.WriteLine(c.FirstName + " " + 
    c.LastName + " " + c.Address1_City);
  }
 }

// </snippetlinqexamples19>