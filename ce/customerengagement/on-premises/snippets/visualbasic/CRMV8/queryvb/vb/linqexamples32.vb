' <snippetlinqexamples32>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim list_retrieve1 = From c In svcContext.ContactSet _
                       Where c.ContactId.Value.Equals(_contactId1) _
                       Select New With
                              {Key .StatusReason =
                                  c.FormattedValues("statuscode")}
  For Each c In list_retrieve1
   Console.WriteLine("Status: " &amp; c.StatusReason)
  Next c
 End Using

' </snippetlinqexamples32>