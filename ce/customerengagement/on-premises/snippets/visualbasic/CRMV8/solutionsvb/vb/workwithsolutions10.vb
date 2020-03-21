' <snippetworkwithsolutions10>


 ' Delete a solution

 Dim queryImportedSolution As QueryExpression =
  New QueryExpression With {
   .EntityName = solution.EntityLogicalName,
   .ColumnSet = New ColumnSet(New String() {"solutionid", "friendlyname"}),
   .Criteria = New FilterExpression()
  }


 queryImportedSolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, ImportedSolutionName)

 Dim ImportedSolution As Solution =
  CType(_serviceProxy.RetrieveMultiple(queryImportedSolution).Entities(0), Solution)

 _serviceProxy.Delete(solution.EntityLogicalName, CType(ImportedSolution.SolutionId, Guid))

 Console.WriteLine("Deleted the {0} solution.", ImportedSolution.FriendlyName)

' </snippetworkwithsolutions10>