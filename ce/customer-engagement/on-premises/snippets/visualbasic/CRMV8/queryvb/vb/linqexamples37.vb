' <snippetlinqexamples37>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_wheretrans = From c In svcContext.ContactSet _
                         Where c.ContactId.Value.Equals(_contactId1) _
                         AndAlso c.Anniversary > Date.Parse("1/1/2010") _
                         Select New With {Key c.FirstName,
                                          Key c.LastName}
  For Each c In query_wheretrans
   Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName)
  Next c
 End Using

' </snippetlinqexamples37>