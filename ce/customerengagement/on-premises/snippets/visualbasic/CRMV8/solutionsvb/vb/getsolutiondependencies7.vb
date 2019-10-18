' <snippetgetsolutiondependencies7>


 ''' <summary>
 ''' Shows how to get a more friendly message based on information within the dependency
 ''' <param name="dependency">A Dependency returned from the RetrieveDependentComponents message</param>
 ''' </summary> 
 Public Sub DependencyReport(ByVal dependency As Dependency)
     'These strings represent parameters for the message.
     Dim dependentComponentName As String = ""
     Dim dependentComponentTypeName As String = ""
     Dim dependentComponentSolutionName As String = ""
     Dim requiredComponentName As String = ""
     Dim requiredComponentTypeName As String = ""
     Dim requiredComponentSolutionName As String = ""

     'The ComponentType global Option Set contains options for each possible component.
     Dim componentTypeRequest As RetrieveOptionSetRequest =
      New RetrieveOptionSetRequest With {
       .Name = "componenttype"
      }

     Dim componentTypeResponse As RetrieveOptionSetResponse =
      CType(_serviceProxy.Execute(componentTypeRequest), RetrieveOptionSetResponse)
     Dim componentTypeOptionSet As OptionSetMetadata =
      CType(componentTypeResponse.OptionSetMetadata, OptionSetMetadata)
     ' Match the Component type with the option value and get the label value of the option.
     For Each opt As OptionMetadata In componentTypeOptionSet.Options
         If dependency.DependentComponentType.Value = opt.Value Then
             dependentComponentTypeName = opt.Label.UserLocalizedLabel.Label
         End If
         If dependency.RequiredComponentType.Value = opt.Value Then
             requiredComponentTypeName = opt.Label.UserLocalizedLabel.Label
         End If
     Next opt
     'The name or display name of the compoent is retrieved in different ways depending on the component type
     dependentComponentName = getComponentName(dependency.DependentComponentType.Value,
                                               CType(dependency.DependentComponentObjectId, 
                                                Guid))
     requiredComponentName = getComponentName(dependency.RequiredComponentType.Value,
                                              CType(dependency.RequiredComponentObjectId, 
                                               Guid))

     ' Retrieve the friendly name for the dependent solution.
     Dim dependentSolution As Solution =
      CType(_serviceProxy.Retrieve(Solution.EntityLogicalName,
                                   CType(dependency.DependentComponentBaseSolutionId, Guid),
                                   New ColumnSet("friendlyname")), 
                                  Solution)
     dependentComponentSolutionName = dependentSolution.FriendlyName

     ' Retrieve the friendly name for the required solution.
     Dim requiredSolution As Solution =
      CType(_serviceProxy.Retrieve(Solution.EntityLogicalName,
                                   CType(dependency.RequiredComponentBaseSolutionId, 
                                    Guid),
                                   New ColumnSet("friendlyname")), 
                                  Solution)
     requiredComponentSolutionName = requiredSolution.FriendlyName

     'Display the message
     Console.WriteLine("The {0} {1} in the {2} depends on the {3} {4} in the {5} solution.",
                       dependentComponentName,
                       dependentComponentTypeName,
                       dependentComponentSolutionName,
                       requiredComponentName,
                       requiredComponentTypeName,
                       requiredComponentSolutionName)
 End Sub

' </snippetgetsolutiondependencies7>