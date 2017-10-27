' <snippetaddtoqueue1>


 ' Move a record from a source queue to a destination queue
 ' by using the AddToQueue request message.
 Dim routeRequest As AddToQueueRequest =
     New AddToQueueRequest With
     {
         .SourceQueueId = _sourceQueueId,
         .Target = New EntityReference(Letter.EntityLogicalName,
                                       _letterId),
         .DestinationQueueId = _destinationQueueId
     }

 ' Set the WorkerId of the QueueItemProperties to indicate who is working
 ' on this particular queue item. If there were any custom attributes
 ' defined for the QueueItem Entity, it would be possible to set
 ' those here, as well.
 routeRequest.QueueItemProperties =
     New QueueItem With
     {
         .WorkerId = New EntityReference("systemuser", _userId)
     }

 ' Execute the Request
 _serviceProxy.Execute(routeRequest)

' </snippetaddtoqueue1>