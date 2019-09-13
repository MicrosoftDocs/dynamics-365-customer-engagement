// <snippetcreatequeue1>


 // Define some anonymous types to define the range of possible 
 // queue property values.
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

 var QueueViewType = new
 {
     Public = 0,
     Private = 1
 };
 // Create a queue instance and set its property values.
 Queue newQueue = new Queue()
 {
     Name = "Example Queue.",
     Description = "This is an example queue.",
     IncomingEmailDeliveryMethod = new OptionSetValue(
         IncomingEmailDeliveryMethods.None),
     IncomingEmailFilteringMethod = new OptionSetValue(
         IncomingEmailFilteringMethods.AllEmailMessages),
     OutgoingEmailDeliveryMethod = new OptionSetValue(
         OutgoingEmailDeliveryMethods.None),
     QueueViewType = new OptionSetValue(
         QueueViewType.Private)
 };

 // Create a new queue instance.
 _queueId = _serviceProxy.Create(newQueue);

// </snippetcreatequeue1>