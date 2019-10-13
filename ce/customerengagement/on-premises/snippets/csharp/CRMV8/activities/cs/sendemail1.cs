// <snippetsendemail1>



 // Use the SendEmail message to send an e-mail message.
 SendEmailRequest sendEmailreq = new SendEmailRequest
 {
     EmailId = _emailId,
     TrackingToken = "",
     IssueSend = true
 };

 SendEmailResponse sendEmailresp = (SendEmailResponse)_serviceProxy.Execute(sendEmailreq);
 Console.WriteLine("Sent the e-mail message.");

// </snippetsendemail1>