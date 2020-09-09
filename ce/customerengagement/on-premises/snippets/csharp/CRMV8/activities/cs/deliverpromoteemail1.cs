// <snippetdeliverpromoteemail1>



 // Create the request.
 DeliverPromoteEmailRequest deliverEmailRequest = new DeliverPromoteEmailRequest
 {
     Subject = "SDK Sample Email",
     To = emailContact.EMailAddress1,
     From = emailSender.InternalEMailAddress,
     Bcc = String.Empty,
     Cc = String.Empty,
     Importance = "high",
     Body = "This message will create an email activity.",
     MessageId = Guid.NewGuid().ToString(),
     SubmittedBy = "",
     ReceivedOn = DateTime.Now
 };                    

 // We won't attach a file to the email, but the Attachments property is required.
 deliverEmailRequest.Attachments = new EntityCollection(new ActivityMimeAttachment[0]);
 deliverEmailRequest.Attachments.EntityName = ActivityMimeAttachment.EntityLogicalName;                    

 // Execute the request.
 DeliverPromoteEmailResponse deliverEmailResponse = (DeliverPromoteEmailResponse)_serviceProxy.Execute(deliverEmailRequest);

 // Verify the success.
 
 // Define an anonymous type to define the possible values for
 // email status
 var EmailStatus = new
 {
     Draft = 1,
     Completed = 2,
     Sent = 3,
     Received = 3,
     Canceled = 5,
     PendingSend = 6,
     Sending = 7,
     Failed = 8,
 };

 // Query for the delivered email, and verify the status code is "Sent".
 ColumnSet deliveredMailColumns = new ColumnSet("statuscode");
 Email deliveredEmail = (Email)_serviceProxy.Retrieve(Email.EntityLogicalName, deliverEmailResponse.EmailId, deliveredMailColumns);

 _emailId = deliveredEmail.ActivityId.Value;
 
 if (deliveredEmail.StatusCode.Value == EmailStatus.Sent)
 {
     Console.WriteLine("Successfully created and delivered the e-mail message.");
 }

// </snippetdeliverpromoteemail1>