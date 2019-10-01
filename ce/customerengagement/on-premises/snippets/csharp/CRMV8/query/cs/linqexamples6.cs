// <snippetlinqexamples6>


 using (OrganizationServiceContext orgSvcContext = new OrganizationServiceContext(_serviceProxy))
 {
  var query_join2 = from c in orgSvcContext.CreateQuery("contact")
                    join a in orgSvcContext.CreateQuery("account")
                    on c["contactid"] equals a["primarycontactid"]
                    select new
                    {
                     contact_name = c["fullname"],
                     account_name = a["name"]
                    };
  foreach (var c in query_join2)
  {
   System.Console.WriteLine(c.contact_name + "  " + c.account_name);
  }
 }

// </snippetlinqexamples6>