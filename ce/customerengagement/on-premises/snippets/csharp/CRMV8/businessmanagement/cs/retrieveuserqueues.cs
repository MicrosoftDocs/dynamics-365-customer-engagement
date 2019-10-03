// <snippetretrieveuserqueues>


 // Get known private queues for the user 
 // by using RetrieveUserQueuesRequest message.
 RetrieveUserQueuesRequest retrieveUserQueuesRequest = new RetrieveUserQueuesRequest
 {
     UserId = CurrentUserId,
     IncludePublic = true
 };
 RetrieveUserQueuesResponse retrieveUserQueuesResponse =
     (RetrieveUserQueuesResponse)_serviceProxy.Execute(retrieveUserQueuesRequest);
 EntityCollection queues = (EntityCollection)retrieveUserQueuesResponse.EntityCollection;

 Guid sourceQueueId = new Guid();
 Guid destinationQueueId = new Guid();

 foreach (Entity entity in queues.Entities)
 {
     Queue queue = (Queue)entity;
     switch (queue.Name)
     {
         case "Source Queue":
             sourceQueueId = queue.Id;
             break;
         case "Destination Queue":
             destinationQueueId = queue.Id;
             break;
     }
 }

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

 Console.WriteLine(@"The letter record has been moved to a new queue.");

// </snippetretrieveuserqueues>