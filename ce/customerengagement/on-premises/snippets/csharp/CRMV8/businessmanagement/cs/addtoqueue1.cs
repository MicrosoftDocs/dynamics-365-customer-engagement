// <snippetaddtoqueue1>


 // Move a record from a source queue to a destination queue
 // by using the AddToQueue request message.
 AddToQueueRequest routeRequest = new AddToQueueRequest
 {
     SourceQueueId = sourceQueueId,
     Target = new EntityReference(Letter.EntityLogicalName, _letterId),
     DestinationQueueId = destinationQueueId
 };

 // Execute the Request
 _serviceProxy.Execute(routeRequest);

// </snippetaddtoqueue1>