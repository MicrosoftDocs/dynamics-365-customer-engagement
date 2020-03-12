// <snippetqueryconnectionrolesbyreciprocalrole1>


 // This query retrieves all connection roles that have this role
 // listed as a reciprocal role.
 QueryExpression query = new QueryExpression
 {
     EntityName = ConnectionRole.EntityLogicalName,
     ColumnSet = new ColumnSet("connectionroleid"),
     LinkEntities = 
 {
     new LinkEntity
     {
         JoinOperator = JoinOperator.Inner,
         LinkFromEntityName =  ConnectionRole.EntityLogicalName,
         LinkFromAttributeName = "connectionroleid",
         LinkToEntityName = "connectionroleassociation",
         LinkToAttributeName = "connectionroleid",
         LinkCriteria = new FilterExpression
         {
             FilterOperator = LogicalOperator.And,
             Conditions = 
             {
                 new ConditionExpression
                 {
                     AttributeName = "associatedconnectionroleid",
                     Operator = ConditionOperator.Equal,
                     Values = { _reciprocalConnectionRoleId }                                        
                 }
             }
         }
     }
 }
 };

 EntityCollection results = _serviceProxy.RetrieveMultiple(query);

 // TODO: Here you would perform some operation on the retrieved
 // roles.

// </snippetqueryconnectionrolesbyreciprocalrole1>