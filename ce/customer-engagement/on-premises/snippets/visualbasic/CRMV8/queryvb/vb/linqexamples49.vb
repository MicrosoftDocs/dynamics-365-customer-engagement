' <snippetlinqexamples49>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_multiselect =
      svcContext.IncidentSet _
      .Where(Function(i) Not i.IncidentId.Value.Equals(_incidentId1)) _
      .Select(Function(i) i.incident_customer_accounts) _
      .Where(Function(a) Not a.AccountId.Value.Equals(_accountId2)) _
      .Select(Function(a) a.account_primary_contact) _
      .OrderBy(Function(c) c.FirstName).Select(Function(c) c.ContactId)
  For Each c In query_multiselect
   Console.WriteLine(c.GetValueOrDefault())
  Next c
 End Using

' </snippetlinqexamples49>