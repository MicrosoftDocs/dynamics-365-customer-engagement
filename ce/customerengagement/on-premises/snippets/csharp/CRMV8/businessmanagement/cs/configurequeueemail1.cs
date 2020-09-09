// <snippetconfigurequeueemail1>


 // Define some anonymous types to define the range 
 // of possible queue property values.
 var IncomingEmailDeliveryMethods = new
 {
     None = 0,
     EmailRouter = 2,
     ForwardMailbox = 3
 };

 var IncomingEmailFilteringMethods = new
 {
     AllEmailMessages = 0,
     EmailMessagesInResponseToCrmEmail = 1,
     EmailMessagesFromCrmLeadsContactsAndAccounts = 2
 };

 var OutgoingEmailDeliveryMethods = new
 {
     None = 0,
     EmailRouter = 2
 };

 // Update a queue instance and set its email property values.
 Queue configureQueue = new Queue()
 {
     QueueId = _queueId,
     IncomingEmailDeliveryMethod = new OptionSetValue(
         IncomingEmailDeliveryMethods.EmailRouter),
     IncomingEmailFilteringMethod = new OptionSetValue(
         IncomingEmailFilteringMethods.EmailMessagesInResponseToCrmEmail),
     OutgoingEmailDeliveryMethod = new OptionSetValue(
         OutgoingEmailDeliveryMethods.None),

     // TODO: Update with appropriate address 
     // for accessing the e-mail router. 
     EMailAddress = "someone@example.com",                        
 };

 _serviceProxy.Update(configureQueue);

// </snippetconfigurequeueemail1>