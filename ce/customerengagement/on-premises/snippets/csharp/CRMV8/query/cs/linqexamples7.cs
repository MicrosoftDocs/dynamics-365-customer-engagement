// <snippetlinqexamples7>


 using (OrganizationServiceContext orgSvcContext = new OrganizationServiceContext(_serviceProxy))
 {
  var query_join3 = from c in orgSvcContext.CreateQuery("contact")
                    join a in orgSvcContext.CreateQuery("account")
                    on c["contactid"] equals (Guid)((EntityReference)a["primarycontactid"]).Id
                    select new
                    {
                     contact_name = c["fullname"],
                     account_name = a["name"]
                    };

  foreach (var c in query_join3)
  {
   System.Console.WriteLine(c.contact_name + "  " + c.account_name);
  }
 }

// </snippetlinqexamples7>