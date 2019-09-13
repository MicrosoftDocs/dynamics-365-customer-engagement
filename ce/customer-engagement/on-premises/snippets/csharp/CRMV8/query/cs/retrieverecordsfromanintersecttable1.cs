// <snippetretrieverecordsfromanintersecttable1>


 #region Retrieve records from an intersect table via QueryExpression

 //Create Query Expression.
 QueryExpression query = new QueryExpression()
 {
     EntityName = "role",
     ColumnSet = new ColumnSet("name"),
     LinkEntities = 
     {
         new LinkEntity
         {
             LinkFromEntityName = Role.EntityLogicalName,
             LinkFromAttributeName = "roleid",
             LinkToEntityName = SystemUserRoles.EntityLogicalName,
             LinkToAttributeName = "roleid",
             LinkCriteria = new FilterExpression
             {
                 FilterOperator = LogicalOperator.And,
                 Conditions = 
                 {
                     new ConditionExpression
                     {
                         AttributeName = "systemuserid",
                         Operator = ConditionOperator.Equal,
                         Values = { _userId }
                     }
                 }
             }
         }
     }
 };

 // Obtain results from the query expression.
 EntityCollection ec = _serviceProxy.RetrieveMultiple(query);

 // Display results.
 for (int i = 0; i < ec.Entities.Count; i++)
 {
     Console.WriteLine("Query Expression Retrieved: {0}", ((Role)ec.Entities[i]).Name);
 }

 #endregion

// </snippetretrieverecordsfromanintersecttable1>