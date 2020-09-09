' <snippetcreatealinqquery5>


 Dim queryContacts = From c In svcContext.ContactSet _
                                    Where (c.Address1_City.Equals("Redmond")) _
                                    And (c.FirstName.Equals("Joe") _
                                            Or c.FirstName.Equals("John")) _
                                        Select New Contact With _
                                               {
                                                   .FirstName = c.FirstName,
                                                   .LastName = c.LastName,
                                                   .Address1_City = c.Address1_City
                                               }
 Console.WriteLine("Contacts in Redmond named Joe OR John")
 Console.WriteLine("=====================================")
 For Each c In queryContacts
  Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName &amp; " " &amp; c.Address1_City)
 Next c

' </snippetcreatealinqquery5>