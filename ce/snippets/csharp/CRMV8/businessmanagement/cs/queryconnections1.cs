// <snippetqueryconnections1>


 // This query retrieves all connections this contact is part of.
 QueryExpression query = new QueryExpression
 {
     EntityName = Connection.EntityLogicalName,
     ColumnSet = new ColumnSet("connectionid"),
     Criteria = new FilterExpression
     {
         FilterOperator = LogicalOperator.And,
         Conditions = 
     {
         // You can safely query against only record1id or
         // record2id - CRM will find all connections this 
         // entity is a part of either way.
         new ConditionExpression
         {
             AttributeName = "record1id",
             Operator = ConditionOperator.Equal,
             Values = { _contactId }
         }
     }
     }
 };

 EntityCollection results = _serviceProxy.RetrieveMultiple(query);

 // TODO: Here you could do a variety of tasks with the 
 // connections retrieved, such as listing the connected entities,
 // finding reciprocal connections, etc.

// </snippetqueryconnections1>