' <snippetremovequeueitemworker1>


 ' Remove worker from queue item to release queued object
 ' from worker's queue.
 Dim queueItem As QueueItem = New QueueItem With {.QueueItemId = _queueItemId, .WorkerId = Nothing}
 _serviceProxy.Update(queueItem)

 Console.WriteLine("Released the queued object from worker queue.")

' </snippetremovequeueitemworker1>