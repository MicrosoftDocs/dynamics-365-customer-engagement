// <snippetcleanupqueueitems1>


 // Retrieve the queueitem with inactive phone calls from a queue            
 RemoveFromQueueRequest removeFromQueueRequest = new RemoveFromQueueRequest
 {
     QueueItemId = _queueItemId
 };
 _serviceProxy.Execute(removeFromQueueRequest);

// </snippetcleanupqueueitems1>