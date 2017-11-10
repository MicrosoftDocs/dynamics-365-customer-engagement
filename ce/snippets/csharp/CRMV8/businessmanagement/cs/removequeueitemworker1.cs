// <snippetremovequeueitemworker1>


 // Remove worker from queue item to release queued object
 // from worker's queue using ReleaseToQueueRequest

 ReleaseToQueueRequest releaseToQueueRequest = new ReleaseToQueueRequest
 {
     QueueItemId = _queueItemId
 };
 _serviceProxy.Execute(releaseToQueueRequest);

 Console.WriteLine("Released the queued object from worker queue.");

// </snippetremovequeueitemworker1>