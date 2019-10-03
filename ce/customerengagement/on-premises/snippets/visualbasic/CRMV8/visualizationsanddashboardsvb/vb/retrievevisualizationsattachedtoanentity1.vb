' <snippetretrievevisualizationsattachedtoanentity1>


 ' Create a query for retrieving all organization-owned visualizations 
 ' that are attached to the account entity.
 Dim mySavedQuery As QueryExpression =
  New QueryExpression With {
   .EntityName = SavedQueryVisualization.EntityLogicalName,
   .ColumnSet = New ColumnSet("name")
  }
 mySavedQuery.Criteria = New FilterExpression()
 mySavedQuery.Criteria.AddCondition("primaryentitytypecode", ConditionOperator.Equal, {Account.EntityLogicalName})

 ' Retrieve a collection of organization-owned visualizations that are attached to the account entity.
 Dim results As DataCollection(Of Entity) =
  _serviceProxy.RetrieveMultiple(mySavedQuery).Entities

 ' Display the names of the retrieved organization-owned visualizations.
 Console.WriteLine("Retrieved the following visualizations for the Account entity:")
 For Each entity As Entity In results
  Dim orgVisualization As SavedQueryVisualization = CType(entity, SavedQueryVisualization)
  Console.WriteLine("{0}", orgVisualization.Name)
 Next entity

' </snippetretrievevisualizationsattachedtoanentity1>