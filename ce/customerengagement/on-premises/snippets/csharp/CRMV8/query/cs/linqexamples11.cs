// <snippetlinqexamples11>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var list_join = (from a in svcContext.AccountSet
                   join c in svcContext.ContactSet
                   on a.PrimaryContactId.Id equals c.ContactId
                   where a.Name == "Contoso Ltd" &&
                   a.Address1_Name == "Contoso Pharmaceuticals"
                   select a).ToList();
  foreach (var c in list_join)
  {
   System.Console.WriteLine("Account " + list_join[0].Name
       + " and it's primary contact "
       + list_join[0].PrimaryContactId.Id);
  }
 }

// </snippetlinqexamples11>