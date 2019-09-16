// <snippetlinqexamples40>


 using (OrganizationServiceContext orgSvcContext = new OrganizationServiceContext(_serviceProxy))
 {
  var query_dejoin = from c in orgSvcContext.CreateQuery("contact")
                     join a in orgSvcContext.CreateQuery("account") 
                     on c["contactid"] equals a["primarycontactid"]
                     join l in orgSvcContext.CreateQuery("lead") 
                     on a["originatingleadid"] equals l["leadid"]
                     where (string)c["lastname"] != "Parker"
                     select new { Contact = c, Account = a, Lead = l };
  foreach (var c in query_dejoin)
  {
   System.Console.WriteLine(c.Account.Attributes["name"] + " " + 
    c.Contact.Attributes["fullname"] + " " + c.Lead.Attributes["leadid"]);
  }
 }

// </snippetlinqexamples40>