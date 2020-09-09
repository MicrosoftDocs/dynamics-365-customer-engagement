' <snippetcreatequeue1>


 ' Define some anonymous types to define the range of possible 
 ' queue property values.
 Dim IncomingEmailDeliveryMethods = New With {Key .None = 0, Key .EmailRouter = 2, Key .ForwardMailbox = 3}

 Dim IncomingEmailFilteringMethods = New With {Key .AllEmailMessages = 0, Key .EmailMessagesInResponseToCrmEmail = 1, _
                                               Key .EmailMessagesFromCrmLeadsContactsAndAccounts = 2}

 Dim OutgoingEmailDeliveryMethods = New With {Key .None = 0, Key .EmailRouter = 2}

 ' Create a queue instance and set its property values.
 Dim newQueue As New Queue() With {.Name = "Example Queue.", .Description = "This is an example queue.", _
                     .IncomingEmailDeliveryMethod = New OptionSetValue(IncomingEmailDeliveryMethods.None), _
                     .IncomingEmailFilteringMethod = New OptionSetValue(IncomingEmailFilteringMethods.AllEmailMessages), _
                                   .OutgoingEmailDeliveryMethod = New OptionSetValue(OutgoingEmailDeliveryMethods.None)}

 ' Create a new queue instance.
 _queueId = _serviceProxy.Create(newQueue)

' </snippetcreatequeue1>