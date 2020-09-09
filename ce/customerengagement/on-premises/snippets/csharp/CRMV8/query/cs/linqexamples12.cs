// <snippetlinqexamples12>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_join8 = from a in svcContext.AccountSet
                    join c in svcContext.ContactSet
                    on a.PrimaryContactId.Id equals c.ContactId
                    into gr
                    from c_joined in gr.DefaultIfEmpty()
                    select new
                    {
                     contact_name = c_joined.FullName,
                     account_name = a.Name
                    };
  foreach (var c in query_join8)
  {
   System.Console.WriteLine(c.contact_name + "  " + c.account_name);
  }
 }

// </snippetlinqexamples12>