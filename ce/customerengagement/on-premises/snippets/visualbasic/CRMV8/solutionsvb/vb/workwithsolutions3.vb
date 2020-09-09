' <snippetworkwithsolutions3>


 ' Create a Solution
 'Define a solution
 Dim solution As Solution =
  New Solution With {
   .UniqueName = "samplesolution",
   .FriendlyName = "Sample Solution",
   .PublisherId = New EntityReference(Publisher.EntityLogicalName, _crmSdkPublisherId),
   .Description = "This solution was created by the WorkWithSolutions sample code in the Microsoft Dynamics CRM SDK samples.",
   .Version = "1.0"
  }

 'Check whether it already exists
 Dim queryCheckForSampleSolution As QueryExpression =
  New QueryExpression With {
   .EntityName = solution.EntityLogicalName,
   .ColumnSet = New ColumnSet(),
   .Criteria = New FilterExpression()
  }
 queryCheckForSampleSolution.Criteria.AddCondition("uniquename",
                                                   ConditionOperator.Equal,
                                                   solution.UniqueName)

 'Create the solution if it does not already exist.
 Dim querySampleSolutionResults As EntityCollection =
  _serviceProxy.RetrieveMultiple(queryCheckForSampleSolution)
 Dim SampleSolutionResults As Solution = Nothing
 If querySampleSolutionResults.Entities.Count > 0 Then
  SampleSolutionResults = CType(querySampleSolutionResults.Entities(0), Solution)
  _solutionsSampleSolutionId = CType(SampleSolutionResults.SolutionId, Guid)
 End If
 If SampleSolutionResults Is Nothing Then
  _solutionsSampleSolutionId = _serviceProxy.Create(solution)
 End If

' </snippetworkwithsolutions3>