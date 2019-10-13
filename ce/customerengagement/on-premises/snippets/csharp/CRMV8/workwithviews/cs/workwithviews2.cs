// <snippetworkwithviews2>


         QueryExpression mySavedQuery = new QueryExpression
         {
             ColumnSet = new ColumnSet("savedqueryid", "name", "querytype", "isdefault", "returnedtypecode", "isquickfindquery"),
             EntityName = SavedQuery.EntityLogicalName,
             Criteria = new FilterExpression
             {
                 Conditions =
 {
     new ConditionExpression
     {
         AttributeName = "querytype",
         Operator = ConditionOperator.Equal,
         Values = {0}
     },
     new ConditionExpression
     {
         AttributeName = "returnedtypecode",
         Operator = ConditionOperator.Equal,
         Values = {Opportunity.EntityTypeCode}
     }
 }
             }
         };
         RetrieveMultipleRequest retrieveSavedQueriesRequest = new RetrieveMultipleRequest { Query = mySavedQuery };

         RetrieveMultipleResponse retrieveSavedQueriesResponse = (RetrieveMultipleResponse)_serviceProxy.Execute(retrieveSavedQueriesRequest);

         DataCollection<Entity> savedQueries = retrieveSavedQueriesResponse.EntityCollection.Entities;

         //Display the Retrieved views
         foreach (Entity ent in savedQueries)
         {
             SavedQuery rsq = (SavedQuery)ent;
             Console.WriteLine("{0} : {1} : {2} : {3} : {4} : {5},", rsq.SavedQueryId, rsq.Name, rsq.QueryType, rsq.IsDefault, rsq.ReturnedTypeCode, rsq.IsQuickFindQuery);
         }

// </snippetworkwithviews2>