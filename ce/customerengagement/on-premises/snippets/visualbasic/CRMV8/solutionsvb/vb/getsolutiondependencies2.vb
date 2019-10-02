' <snippetgetsolutiondependencies2>


 Dim primarySolution As Solution =
  New Solution With {
   .Version = "1.0",
   .FriendlyName = "Primary Solution",
   .PublisherId =
   New EntityReference(publisher.EntityLogicalName, _publisherId),
   .UniqueName = _primarySolutionName
  }
 _primarySolutionId = _serviceProxy.Create(primarySolution)

' </snippetgetsolutiondependencies2>