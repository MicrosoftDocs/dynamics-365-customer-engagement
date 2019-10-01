// <snippetgetsolutiondependencies3>


 OptionSetMetadata optionSetMetadata = new OptionSetMetadata()
 {
     Name = _globalOptionSetName,
     DisplayName = new Label("Example Option Set", _languageCode),
     IsGlobal = true,
     OptionSetType = OptionSetType.Picklist,
     Options =
 {
     new OptionMetadata(new Label("Option 1", _languageCode), 1),
     new OptionMetadata(new Label("Option 2", _languageCode), 2)
 }
 };
 CreateOptionSetRequest createOptionSetRequest = new CreateOptionSetRequest
 {
     OptionSet = optionSetMetadata                
 };

 createOptionSetRequest.SolutionUniqueName = _primarySolutionName;
 _serviceProxy.Execute(createOptionSetRequest);

// </snippetgetsolutiondependencies3>