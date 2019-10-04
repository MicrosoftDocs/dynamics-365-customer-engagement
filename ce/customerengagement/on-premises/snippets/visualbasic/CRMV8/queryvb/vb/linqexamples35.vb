' <snippetlinqexamples35>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim firstorcontact As Contact =
      svcContext.ContactSet.FirstOrDefault()
  Console.WriteLine(firstorcontact.FullName &amp; " is the first contact")

  Console.WriteLine("==========================")
  Dim singleorcontact As Contact =
      svcContext.ContactSet _
      .SingleOrDefault(Function(c) c.ContactId.Value.Equals(_contactId1))
  Console.WriteLine(singleorcontact.FullName &amp; " is the single contact")
 End Using

' </snippetlinqexamples35>