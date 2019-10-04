// <snippetworkwithsolutions10>


 // Delete a solution

 QueryExpression queryImportedSolution = new QueryExpression
 {
     EntityName = Solution.EntityLogicalName,
     ColumnSet = new ColumnSet(new string[] { "solutionid", "friendlyname" }),
     Criteria = new FilterExpression()
 };


 queryImportedSolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, ImportedSolutionName);

 Solution ImportedSolution = (Solution)_serviceProxy.RetrieveMultiple(queryImportedSolution).Entities[0];

 _serviceProxy.Delete(Solution.EntityLogicalName, (Guid)ImportedSolution.SolutionId);

 Console.WriteLine("Deleted the {0} solution.", ImportedSolution.FriendlyName);

// </snippetworkwithsolutions10>