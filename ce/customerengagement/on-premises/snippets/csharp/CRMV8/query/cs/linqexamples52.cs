// <snippetlinqexamples52>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_twowhere = from a in svcContext.AccountSet
                       join c in svcContext.ContactSet 
                       on a.PrimaryContactId.Id equals c.ContactId
                       where c.LastName == "Smith" && c.CreditOnHold != null
                       where a.Name == "Contoso Ltd"
                       orderby a.Name
                       select a;
  foreach (var c in query_twowhere)
  {
   System.Console.WriteLine(c.AccountId + " " + c.Name);
  }
 }

// </snippetlinqexamples52>