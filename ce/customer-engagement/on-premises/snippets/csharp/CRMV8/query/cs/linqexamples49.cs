// <snippetlinqexamples49>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_multiselect = svcContext.IncidentSet
                         .Where(i => i.IncidentId != _incidentId1)
                         .Select(i => i.incident_customer_accounts)
                         .Where(a => a.AccountId != _accountId2)
                         .Select(a => a.account_primary_contact)
                         .OrderBy(c => c.FirstName)
                         .Select(c => c.ContactId);
  foreach (var c in query_multiselect)
  {
   System.Console.WriteLine(c.GetValueOrDefault());
  }
 }

// </snippetlinqexamples49>