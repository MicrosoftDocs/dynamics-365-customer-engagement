' <snippetsendemail1>



 ' Use the SendEmail message to send an e-mail message.
 Dim sendEmailreq As SendEmailRequest = New SendEmailRequest With {.EmailId = _emailId, .TrackingToken = "", .IssueSend = True}

 Dim sendEmailresp As SendEmailResponse = CType(_serviceProxy.Execute(sendEmailreq), SendEmailResponse)
 Console.WriteLine("Sent the e-mail message.")

' </snippetsendemail1>