// <snippetlinqexamples13>


 using (OrganizationServiceContext orgSvcContext = new OrganizationServiceContext(_serviceProxy))
 {
  var query_join9 = from a in orgSvcContext.CreateQuery("account")
                    join c in orgSvcContext.CreateQuery("contact") 
                    on a["primarycontactid"] equals c["contactid"] into gr
                    from c_joined in gr.DefaultIfEmpty()
                    select new
                    {
                     account_name = a.Attributes["name"]
                    };
  foreach (var c in query_join9)
  {
   System.Console.WriteLine(c.account_name);
  }
 }

// </snippetlinqexamples13>