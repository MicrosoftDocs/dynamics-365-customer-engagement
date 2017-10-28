' <snippetworkwithsolutions4>


 ' Retrieve a solution
 Dim solutionUniqueName As String = "samplesolution"
 Dim querySampleSolution As QueryExpression =
  New QueryExpression With {
   .EntityName = solution.EntityLogicalName,
   .ColumnSet = New ColumnSet(New String() {"publisherid",
                                            "installedon",
                                            "version",
                                            "versionnumber",
                                            "friendlyname"}),
   .Criteria = New FilterExpression()
  }

 querySampleSolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, solutionUniqueName)
 Dim SampleSolution As Solution =
  CType(_serviceProxy.RetrieveMultiple(querySampleSolution).Entities(0), Solution)

' </snippetworkwithsolutions4>