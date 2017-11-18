' <snippetlinqexamples50>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_selectmany =
      svcContext.ContactSet _
      .Where(Function(c) Not c.ContactId.Value.Equals(_contactId2)) _
      .SelectMany(Function(c) c.account_primary_contact) _
      .OrderBy(Function(a) a.Name)
  For Each c In query_selectmany
   Console.WriteLine(c.AccountId.ToString() &amp; " " &amp; c.Name)
  Next c
 End Using

' </snippetlinqexamples50>