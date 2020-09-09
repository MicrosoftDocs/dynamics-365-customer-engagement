' <snippetcreateoptionset1>



 ' Define the option set to create.
 Dim setupOptionSetMetadata As New OptionSetMetadata() With {
  .Name = _optionSetName,
  .DisplayName = New Label("Example Option Set", _languageCode),
  .Description = New Label("An Example Option Set", _languageCode),
  .IsGlobal = True,
  .OptionSetType = OptionSetType.Picklist
 }
 setupOptionSetMetadata.Options.AddRange(
  {
   New OptionMetadata(New Label("Option 1", _languageCode), Nothing),
   New OptionMetadata(New Label("Option 2", _languageCode), Nothing)
  }
 )
 ' The name will be used to uniquely identify the option set.
 ' Normally you should generate this identifier using the publisher's
 ' prefix and double-check that the name is not in use.
 ' Define the list of options that populate the option set
 ' The order here determines the order shown in the option set.
 ' Options accepts any number of OptionMetadata instances, which
 ' are simply pairs of Labels and integer values.

 ' Wrap the OptionSetMetadata in the appropriate request.
 Dim createOptionSetRequest As CreateOptionSetRequest = New CreateOptionSetRequest With {
  .OptionSet = setupOptionSetMetadata
 }

 ' Pass the execute statement to the CRM service.
 _serviceProxy.Execute(createOptionSetRequest)
 Console.WriteLine("Option Set created")

' </snippetcreateoptionset1>