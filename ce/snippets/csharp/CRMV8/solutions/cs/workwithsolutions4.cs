// <snippetworkwithsolutions4>


 // Retrieve a solution
 String solutionUniqueName = "samplesolution";
 QueryExpression querySampleSolution = new QueryExpression
 {
     EntityName = Solution.EntityLogicalName,
     ColumnSet = new ColumnSet(new string[] { "publisherid", "installedon", "version", "versionnumber", "friendlyname" }),
     Criteria = new FilterExpression()
 };

 querySampleSolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, solutionUniqueName);
 Solution SampleSolution = (Solution)_serviceProxy.RetrieveMultiple(querySampleSolution).Entities[0];

// </snippetworkwithsolutions4>