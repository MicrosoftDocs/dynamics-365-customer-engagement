// <snippetcreateoptionset1>



 // Define the option set to create.
 OptionSetMetadata setupOptionSetMetadata = new OptionSetMetadata()
 {
     // The name will be used to uniquely identify the option set.
     // Normally you should generate this identifier using the publisher's
     // prefix and double-check that the name is not in use.
     Name = _optionSetName,
     DisplayName = new Label("Example Option Set", _languageCode),
     Description = new Label("An Example Option Set", _languageCode),
     IsGlobal = true,
     OptionSetType = OptionSetType.Picklist,

     // Define the list of options that populate the option set
     // The order here determines the order shown in the option set.
     Options = 
 {
     // Options accepts any number of OptionMetadata instances, which
     // are simply pairs of Labels and integer values.
     new OptionMetadata(new Label("Option 1", _languageCode), null ),
     new OptionMetadata(new Label("Option 2", _languageCode), null )
 }
 };

 // Wrap the OptionSetMetadata in the appropriate request.
 CreateOptionSetRequest createOptionSetRequest = new CreateOptionSetRequest
 {
     OptionSet = setupOptionSetMetadata
 };

 // Pass the execute statement to the CRM service.
 _serviceProxy.Execute(createOptionSetRequest);
 Console.WriteLine("Option Set created");

// </snippetcreateoptionset1>