// <snippetgetsolutiondependencies2>


 Solution primarySolution = new Solution
 {
     Version = "1.0",
     FriendlyName = "Primary Solution",
     PublisherId = new EntityReference(Publisher.EntityLogicalName, _publisherId),
     UniqueName = _primarySolutionName
 };
 _primarySolutionId = _serviceProxy.Create(primarySolution);

// </snippetgetsolutiondependencies2>