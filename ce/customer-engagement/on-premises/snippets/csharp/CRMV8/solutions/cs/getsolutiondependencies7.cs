// <snippetgetsolutiondependencies7>


    /// <summary>
    /// Shows how to get a more friendly message based on information within the dependency
    /// <param name="dependency">A Dependency returned from the RetrieveDependentComponents message</param>
    /// </summary> 
 public void DependencyReport(Dependency dependency)
    {
  //These strings represent parameters for the message.
     String dependentComponentName = "";
     String dependentComponentTypeName = "";
     String dependentComponentSolutionName = "";
     String requiredComponentName = "";
     String requiredComponentTypeName = "";
     String requiredComponentSolutionName = "";

  //The ComponentType global Option Set contains options for each possible component.
     RetrieveOptionSetRequest componentTypeRequest = new RetrieveOptionSetRequest
     {
      Name = "componenttype"
     };

     RetrieveOptionSetResponse componentTypeResponse = (RetrieveOptionSetResponse)_serviceProxy.Execute(componentTypeRequest);
     OptionSetMetadata componentTypeOptionSet = (OptionSetMetadata)componentTypeResponse.OptionSetMetadata;
  // Match the Component type with the option value and get the label value of the option.
     foreach (OptionMetadata opt in componentTypeOptionSet.Options)
     {
      if (dependency.DependentComponentType.Value == opt.Value)
      {
       dependentComponentTypeName = opt.Label.UserLocalizedLabel.Label;
      }
      if (dependency.RequiredComponentType.Value == opt.Value)
      {
       requiredComponentTypeName = opt.Label.UserLocalizedLabel.Label;
      }
     }
  //The name or display name of the compoent is retrieved in different ways depending on the component type
     dependentComponentName = getComponentName(dependency.DependentComponentType.Value, (Guid)dependency.DependentComponentObjectId);
     requiredComponentName = getComponentName(dependency.RequiredComponentType.Value, (Guid)dependency.RequiredComponentObjectId);

  // Retrieve the friendly name for the dependent solution.
     Solution dependentSolution = (Solution)_serviceProxy.Retrieve
      (
       Solution.EntityLogicalName,
       (Guid)dependency.DependentComponentBaseSolutionId,
       new ColumnSet("friendlyname")
      );
     dependentComponentSolutionName = dependentSolution.FriendlyName;
     
  // Retrieve the friendly name for the required solution.
     Solution requiredSolution = (Solution)_serviceProxy.Retrieve
       (
        Solution.EntityLogicalName,
        (Guid)dependency.RequiredComponentBaseSolutionId,
        new ColumnSet("friendlyname")
       );
     requiredComponentSolutionName = requiredSolution.FriendlyName;

  //Display the message
      Console.WriteLine("The {0} {1} in the {2} depends on the {3} {4} in the {5} solution.",
      dependentComponentName,
      dependentComponentTypeName,
      dependentComponentSolutionName,
      requiredComponentName,
      requiredComponentTypeName,
      requiredComponentSolutionName);
    }

// </snippetgetsolutiondependencies7>