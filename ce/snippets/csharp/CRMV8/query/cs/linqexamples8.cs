// <snippetlinqexamples8>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_join4 = from a in svcContext.AccountSet
                    join c in svcContext.ContactSet
                    on a.PrimaryContactId.Id equals c.ContactId
                    join l in svcContext.LeadSet
                    on a.OriginatingLeadId.Id equals l.LeadId
                    select new
                    {
                     contact_name = c.FullName,
                     account_name = a.Name,
                     lead_name = l.FullName
                    };
  foreach (var c in query_join4)
  {
   System.Console.WriteLine(c.contact_name +
    "  " +
    c.account_name +
    "  " +
    c.lead_name);
  }
 }

// </snippetlinqexamples8>