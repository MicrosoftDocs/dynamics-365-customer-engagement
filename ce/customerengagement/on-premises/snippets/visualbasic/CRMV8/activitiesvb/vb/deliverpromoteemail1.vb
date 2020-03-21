' <snippetdeliverpromoteemail1>



 ' Create the request.
 Dim deliverEmailRequest As DeliverPromoteEmailRequest = New DeliverPromoteEmailRequest With {.Subject = "SDK Sample Email", _
     .To = emailContact.EMailAddress1, .From = emailSender.InternalEMailAddress, .Bcc = String.Empty, .Cc = String.Empty, _
     .Importance = "high", .Body = "This message will create an email activity.", .MessageId = Guid.NewGuid().ToString(), _
     .SubmittedBy = "", .ReceivedOn = Date.Now}

 ' We won't attach a file to the email, but the Attachments property is required.
 deliverEmailRequest.Attachments = New EntityCollection(New ActivityMimeAttachment(){})
 deliverEmailRequest.Attachments.EntityName = ActivityMimeAttachment.EntityLogicalName

 ' Execute the request.
 Dim deliverEmailResponse As DeliverPromoteEmailResponse = CType(_serviceProxy.Execute(deliverEmailRequest),  _
                                                                 DeliverPromoteEmailResponse)

 ' Verify the success.

 ' Define an anonymous type to define the possible values for
 ' email status
 Dim EmailStatus = New With {Key .Draft = 1, Key .Completed = 2, Key .Sent = 3, Key .Received = 3, Key .Canceled = 5, _
                             Key .PendingSend = 6, Key .Sending = 7, Key .Failed = 8}

 ' Query for the delivered email, and verify the status code is "Sent".
 Dim deliveredMailColumns As New ColumnSet("statuscode")
 Dim deliveredEmail As Email = CType(_serviceProxy.Retrieve(Email.EntityLogicalName, deliverEmailResponse.EmailId, _
                                                            deliveredMailColumns), Email)

 _emailId = deliveredEmail.ActivityId.Value

 If deliveredEmail.StatusCode.Value = EmailStatus.Sent Then
     Console.WriteLine("Successfully created and delivered the e-mail message.")
 End If

' </snippetdeliverpromoteemail1>