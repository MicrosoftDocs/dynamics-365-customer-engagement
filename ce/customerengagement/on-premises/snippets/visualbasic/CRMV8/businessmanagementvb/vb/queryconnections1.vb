' <snippetqueryconnections1>


 ' This query retrieves all connections this contact is part of.
 Dim query As QueryExpression = New QueryExpression With {.EntityName = Connection.EntityLogicalName, _
                                                          .ColumnSet = New ColumnSet("connectionid")}
 query.Criteria = New FilterExpression()
 query.Criteria.AddCondition("record1id", ConditionOperator.Equal, {_contactId})
 query.Criteria.FilterOperator = LogicalOperator.And
         ' You can safely query against only record1id or
         ' record2id - CRM will find all connections this 
         ' entity is a part of either way.

 Dim results As EntityCollection = _serviceProxy.RetrieveMultiple(query)

 ' TODO: Here you could do a variety of tasks with the 
 ' connections retrieved, such as listing the connected entities,
 ' finding reciprocal connections, etc.

' </snippetqueryconnections1>