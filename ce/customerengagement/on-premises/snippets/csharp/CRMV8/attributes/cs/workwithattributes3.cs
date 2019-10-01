// <snippetworkwithattributes3>


 // Use InsertStatusValueRequest message to insert a new status 
 // in an existing status attribute. 
 // Create the request.
 InsertStatusValueRequest insertStatusValueRequest =
     new InsertStatusValueRequest
 {
     AttributeLogicalName = "statuscode",
     EntityLogicalName = Contact.EntityLogicalName,
     Label = new Label("Dormant", _languageCode),
     StateCode = 0
 };

 // Execute the request and store newly inserted value 
 // for cleanup, used later part of this sample. 
 _insertedStatusValue = ((InsertStatusValueResponse)_serviceProxy.Execute(
     insertStatusValueRequest)).NewOptionValue;

 Console.WriteLine("Created {0} with the value of {1}.",
     insertStatusValueRequest.Label.LocalizedLabels[0].Label,
     _insertedStatusValue);

// </snippetworkwithattributes3>