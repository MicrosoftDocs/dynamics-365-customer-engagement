' <snippetgetsolutiondependencies1>



 ' Grab all Solution Components for a solution.
 Dim componentQuery As QueryByAttribute =
  New QueryByAttribute With {
   .EntityName = SolutionComponent.EntityLogicalName,
   .ColumnSet = New ColumnSet("componenttype", "objectid",
                              "solutioncomponentid", "solutionid")
  }
 componentQuery.Attributes.Add("solutionid")
 componentQuery.Values.Add(_primarySolutionId)
 ' In your code, this value would probably come from another query.

 Dim allComponents As IEnumerable(Of SolutionComponent) =
  _serviceProxy.RetrieveMultiple(componentQuery).Entities.Cast(Of SolutionComponent)()

 For Each component As SolutionComponent In allComponents
     ' For each solution component, retrieve all dependencies for the component.
     Dim dependentComponentsRequest As RetrieveDependentComponentsRequest =
      New RetrieveDependentComponentsRequest With {
       .ComponentType = component.ComponentType.Value,
       .ObjectId = component.ObjectId.Value
      }
     Dim dependentComponentsResponse As RetrieveDependentComponentsResponse =
      CType(_serviceProxy.Execute(dependentComponentsRequest), 
          RetrieveDependentComponentsResponse)

     ' If there are no dependent components, we can ignore this component.
     If dependentComponentsResponse.EntityCollection.Entities.Any() = False Then
         Continue For
     End If

     ' If there are dependencies upon this solution component, and the solution
     ' itself is managed, then you will be unable to delete the solution.
     Console.WriteLine("Found {0} dependencies for Component {1} of type {2}",
                       dependentComponentsResponse.EntityCollection.Entities.Count,
                       component.ObjectId.Value,
                       component.ComponentType.Value)
     'A more complete report requires more code
     For Each d As Dependency In dependentComponentsResponse.EntityCollection.Entities
         DependencyReport(d)
     Next d
 Next component

' </snippetgetsolutiondependencies1>