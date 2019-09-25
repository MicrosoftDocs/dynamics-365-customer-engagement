' <snippetsendemailusingtemplate1>



 ' Create the 'From:' activity party for the email
 Dim fromParty As ActivityParty = New ActivityParty With {.PartyId = New EntityReference(SystemUser.EntityLogicalName, _userId)}

 ' Create the 'To:' activity party for the email
 Dim toParty As ActivityParty = New ActivityParty With {.PartyId = New EntityReference(Contact.EntityLogicalName, _contactId)}

 Console.WriteLine("Created activity parties.")

 ' Create an e-mail message.
 Dim email As Email = New Email With {.To = New ActivityParty() {toParty}, .From = New ActivityParty() {fromParty}, _
                 .Subject = "SDK Sample e-mail", .Description = "SDK Sample for SendEmailFromTemplate Message.", _
                 .DirectionCode = True}

 ' Create the request
 Dim emailUsingTemplateReq As SendEmailFromTemplateRequest = New SendEmailFromTemplateRequest With {.Target = email, _
                 .TemplateId = New Guid("07B94C1D-C85F-492F-B120-F0A743C540E6"), .RegardingId = _contactId, _
                 .RegardingType = Contact.EntityLogicalName}
 ' Use a built-in Email Template of type "contact".
 ' The regarding Id is required, and must be of the same type as the Email Template.

 Dim emailUsingTemplateResp As SendEmailFromTemplateResponse = CType(_serviceProxy.Execute(emailUsingTemplateReq),  _
                 SendEmailFromTemplateResponse)

 ' Verify that the e-mail has been created
 _emailId = emailUsingTemplateResp.Id
 If Not _emailId.Equals(Guid.Empty) Then
     Console.WriteLine("Successfully sent an e-mail message using the template.")
 End If

' </snippetsendemailusingtemplate1>