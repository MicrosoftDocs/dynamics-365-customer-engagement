' <snippetlinqexamples31>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim firstcontact As Contact = svcContext.ContactSet _
                                .First()
  Console.WriteLine(firstcontact.LastName &amp; ", " _
                    &amp; firstcontact.FirstName _
                    &amp; " is the first contact")
  Console.WriteLine("==========================")
  Dim singlecontact As Contact =
      svcContext.ContactSet _
      .Single(Function(c) c.ContactId.Value.Equals(_contactId1))
  Console.WriteLine(singlecontact.LastName &amp; ", " _
                    &amp; singlecontact.FirstName _
                    &amp; " is the single contact")
 End Using

' </snippetlinqexamples31>