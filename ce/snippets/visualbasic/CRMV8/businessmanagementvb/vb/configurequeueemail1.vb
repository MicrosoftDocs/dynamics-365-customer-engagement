' <snippetconfigurequeueemail1>


 ' Define some anonymous types to define the range 
 ' of possible queue property values.
 Dim IncomingEmailDeliveryMethods = New With {Key .None = 0, Key .EmailRouter = 2, Key .ForwardMailbox = 3}

 Dim IncomingEmailFilteringMethods = New With {Key .AllEmailMessages = 0, Key .EmailMessagesInResponseToCrmEmail = 1, _
                                               Key .EmailMessagesFromCrmLeadsContactsAndAccounts = 2}

 Dim OutgoingEmailDeliveryMethods = New With {Key .None = 0, Key .EmailRouter = 2}

 ' Update a queue instance and set its email property values.
 Dim configureQueue As New Queue() With { _
     .QueueId = _queueId, .IncomingEmailDeliveryMethod = New OptionSetValue(IncomingEmailDeliveryMethods.EmailRouter), _
     .IncomingEmailFilteringMethod = New OptionSetValue(IncomingEmailFilteringMethods.EmailMessagesInResponseToCrmEmail), _
     .OutgoingEmailDeliveryMethod = New OptionSetValue(OutgoingEmailDeliveryMethods.None), _
     .EMailAddress = "someone@example.com", .EmailUsername = "exampleuser", .EmailPassword = "examplepassword"}
     ' TODO: Update with appropriate credentials 
     ' for accessing the e-mail router. 

 _serviceProxy.Update(configureQueue)

' </snippetconfigurequeueemail1>