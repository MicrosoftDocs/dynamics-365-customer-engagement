// <snippetlinqexamples25>


 using (OrganizationServiceContext orgSvcContext = new OrganizationServiceContext(_serviceProxy))
 {
  var query_contains3 = from c in orgSvcContext.CreateQuery("contact")
                        where ((string)c["description"]).Contains("Coho")
                        select new
                        {
                         firstname = c.Attributes["firstname"],
                         lastname = c.Attributes["lastname"]
                        };
  foreach (var c in query_contains3)
  {
   System.Console.WriteLine(c.firstname + " " + c.lastname);
  }
 }

// </snippetlinqexamples25>