// <snippetworkwithattributes7>


 // Create a request.
 InsertOptionValueRequest insertOptionValueRequest =
     new InsertOptionValueRequest
 {
     AttributeLogicalName = "new_picklist",
     EntityLogicalName = Contact.EntityLogicalName,
     Label = new Label("New Picklist Label", _languageCode)
 };

 // Execute the request.
 int insertOptionValue = ((InsertOptionValueResponse)_serviceProxy.Execute(
     insertOptionValueRequest)).NewOptionValue;

 Console.WriteLine("Created {0} with the value of {1}.",
     insertOptionValueRequest.Label.LocalizedLabels[0].Label,
     insertOptionValue);

// </snippetworkwithattributes7>