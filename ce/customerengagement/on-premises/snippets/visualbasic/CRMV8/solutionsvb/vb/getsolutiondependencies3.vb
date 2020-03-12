' <snippetgetsolutiondependencies3>


 Dim optionSetMetadata As New OptionSetMetadata() With {
  .Name = _globalOptionSetName,
  .DisplayName = New Label("Example Option Set", _languageCode),
  .IsGlobal = True,
  .OptionSetType = OptionSetType.Picklist
 }
 optionSetMetadata.Options.AddRange(
  {
   New OptionMetadata(New Label("Option 1", _languageCode), 1),
   New OptionMetadata(New Label("Option 2", _languageCode), 2)
  }
 )
 Dim createOptionSetRequest As CreateOptionSetRequest =
  New CreateOptionSetRequest With {
   .OptionSet = optionSetMetadata
  }

 createOptionSetRequest.SolutionUniqueName = _primarySolutionName
 _serviceProxy.Execute(createOptionSetRequest)

' </snippetgetsolutiondependencies3>