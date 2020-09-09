// <snippetgetsolutiondependencies1>



 // Grab all Solution Components for a solution.
 QueryByAttribute componentQuery = new QueryByAttribute
 {
     EntityName = SolutionComponent.EntityLogicalName,
     ColumnSet = new ColumnSet("componenttype", "objectid", "solutioncomponentid", "solutionid"),
     Attributes = { "solutionid" },

     // In your code, this value would probably come from another query.
     Values = { _primarySolutionId }
 };

 IEnumerable<SolutionComponent> allComponents =
     _serviceProxy.RetrieveMultiple(componentQuery).Entities.Cast<SolutionComponent>();

 foreach (SolutionComponent component in allComponents)
 {
     // For each solution component, retrieve all dependencies for the component.
     RetrieveDependentComponentsRequest dependentComponentsRequest =
         new RetrieveDependentComponentsRequest
         {
             ComponentType = component.ComponentType.Value,
             ObjectId = component.ObjectId.Value
         };
     RetrieveDependentComponentsResponse dependentComponentsResponse =
         (RetrieveDependentComponentsResponse)_serviceProxy.Execute(dependentComponentsRequest);

     // If there are no dependent components, we can ignore this component.
     if (dependentComponentsResponse.EntityCollection.Entities.Any() == false)
         continue;

     // If there are dependencies upon this solution component, and the solution
     // itself is managed, then you will be unable to delete the solution.
     Console.WriteLine("Found {0} dependencies for Component {1} of type {2}",
         dependentComponentsResponse.EntityCollection.Entities.Count,
         component.ObjectId.Value,
         component.ComponentType.Value
         );
     //A more complete report requires more code
     foreach (Dependency d in dependentComponentsResponse.EntityCollection.Entities)
     {
         DependencyReport(d);
     }
 }

// </snippetgetsolutiondependencies1>