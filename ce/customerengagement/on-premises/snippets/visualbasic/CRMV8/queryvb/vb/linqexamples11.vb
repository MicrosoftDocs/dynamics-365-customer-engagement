' <snippetlinqexamples11>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim list_join = ( _
      From a In svcContext.AccountSet _
      Join c In svcContext.ContactSet _
      On a.PrimaryContactId.Id Equals c.ContactId _
      Where a.Name.Equals("Contoso Ltd") _
      And a.Address1_Name.Equals("Contoso Pharmaceuticals") _
      Select a).ToList()
  For Each c In list_join
   Console.WriteLine("Account " &amp; list_join(0).Name _
                     &amp; " and it's primary contact " _
                     &amp; list_join(0).PrimaryContactId.Id.ToString())
  Next c
 End Using

' </snippetlinqexamples11>