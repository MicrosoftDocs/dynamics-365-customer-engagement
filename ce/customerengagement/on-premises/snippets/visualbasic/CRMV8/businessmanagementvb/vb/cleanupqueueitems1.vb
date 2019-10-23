' <snippetcleanupqueueitems1>


 ' Retrieve all queueitems with inactive phone calls from a queue.
 Dim retrieveItemsForDeletion As QueryExpression = New QueryExpression With { _
     .EntityName = QueueItem.EntityLogicalName, .ColumnSet = New ColumnSet("queueitemid")}
 retrieveItemsForDeletion.Criteria = New FilterExpression()
 retrieveItemsForDeletion.Criteria.AddCondition("queueid", ConditionOperator.Equal, {_queueId})
 retrieveItemsForDeletion.Criteria.FilterOperator = LogicalOperator.And
 retrieveItemsForDeletion.AddLink(PhoneCall.EntityLogicalName, "objectid", "activityid", JoinOperator.Inner).LinkCriteria() = _
     New FilterExpression()
 retrieveItemsForDeletion.LinkEntities(0).LinkCriteria().AddCondition("statecode", ConditionOperator.NotEqual, _
                                                                      {CInt(Fix(PhoneCallState.Open))})
     ' Only include queueitems for this queue.
     ' Join to the related phonecall entities.
         ' Only include phone calls if their state is not Open.

 Dim itemCollection As EntityCollection = _serviceProxy.RetrieveMultiple(retrieveItemsForDeletion)

 ' Loop through the results and delete each queueitem.
 For Each entity As Entity In itemCollection.Entities
     Dim item As QueueItem = CType(entity, QueueItem)
     _serviceProxy.Delete(QueueItem.EntityLogicalName, item.QueueItemId.Value)
 Next entity

' </snippetcleanupqueueitems1>