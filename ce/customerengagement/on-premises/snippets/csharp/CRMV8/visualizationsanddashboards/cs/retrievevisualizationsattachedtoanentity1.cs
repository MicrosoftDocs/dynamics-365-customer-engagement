// <snippetretrievevisualizationsattachedtoanentity1>


 // Create a query for retrieving all organization-owned visualizations 
 // that are attached to the account entity.
 QueryExpression mySavedQuery = new QueryExpression
 {
     EntityName = SavedQueryVisualization.EntityLogicalName,
     ColumnSet = new ColumnSet("name"),
     Criteria = new FilterExpression
     {
         Conditions = 
      {
         new ConditionExpression
            {
               AttributeName = "primaryentitytypecode",
               Operator = ConditionOperator.Equal,
               Values =  {Account.EntityLogicalName}
            }
      }
     }
 };

 // Retrieve a collection of organization-owned visualizations that are attached to the account entity.
 DataCollection<Entity> results = _serviceProxy.RetrieveMultiple(mySavedQuery).Entities;

 // Display the names of the retrieved organization-owned visualizations.
 Console.WriteLine("Retrieved the following visualizations for the Account entity:");
 foreach (Entity entity in results)
 {
     SavedQueryVisualization orgVisualization = (SavedQueryVisualization)entity;
     Console.WriteLine("{0}", orgVisualization.Name);
 }

// </snippetretrievevisualizationsattachedtoanentity1>