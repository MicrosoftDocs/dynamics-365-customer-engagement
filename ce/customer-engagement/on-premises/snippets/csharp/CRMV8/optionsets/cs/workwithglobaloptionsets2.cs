// <snippetworkwithglobaloptionsets2>


 #region How to create global option set
 // Define the request object and pass to the service.
 CreateOptionSetRequest createOptionSetRequest = new CreateOptionSetRequest
 {
     // Create a global option set (OptionSetMetadata).
     OptionSet = new OptionSetMetadata
     {
         Name = _globalOptionSetName,
         DisplayName = new Label("Example Option Set", _languageCode),
         IsGlobal = true,
         OptionSetType = OptionSetType.Picklist,
         Options = 
     {
         new OptionMetadata(new Label("Open", _languageCode), null),
         new OptionMetadata(new Label("Suspended", _languageCode), null),
         new OptionMetadata(new Label("Cancelled", _languageCode), null),
         new OptionMetadata(new Label("Closed", _languageCode), null)
     }
     }
 };

 // Execute the request.
 CreateOptionSetResponse optionsResp =
     (CreateOptionSetResponse)_serviceProxy.Execute(createOptionSetRequest);

// </snippetworkwithglobaloptionsets2>