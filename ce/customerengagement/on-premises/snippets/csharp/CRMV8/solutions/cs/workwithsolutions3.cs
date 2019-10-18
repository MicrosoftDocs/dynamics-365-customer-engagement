// <snippetworkwithsolutions3>


 // Create a Solution
 //Define a solution
 Solution solution = new Solution
 {
     UniqueName = "samplesolution",
     FriendlyName = "Sample Solution",
     PublisherId = new EntityReference(Publisher.EntityLogicalName, _crmSdkPublisherId),
     Description = "This solution was created by the WorkWithSolutions sample code in the Microsoft Dynamics CRM SDK samples.",
     Version = "1.0"
 };

 //Check whether it already exists
 QueryExpression queryCheckForSampleSolution = new QueryExpression
 {
     EntityName = Solution.EntityLogicalName,
     ColumnSet = new ColumnSet(),
     Criteria = new FilterExpression()
 };
 queryCheckForSampleSolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, solution.UniqueName);

 //Create the solution if it does not already exist.
 EntityCollection querySampleSolutionResults = _serviceProxy.RetrieveMultiple(queryCheckForSampleSolution);
 Solution SampleSolutionResults = null;
 if (querySampleSolutionResults.Entities.Count > 0)
 {
     SampleSolutionResults = (Solution)querySampleSolutionResults.Entities[0];
     _solutionsSampleSolutionId = (Guid)SampleSolutionResults.SolutionId;
 }
 if (SampleSolutionResults == null)
 {
     _solutionsSampleSolutionId = _serviceProxy.Create(solution);
 }

// </snippetworkwithsolutions3>