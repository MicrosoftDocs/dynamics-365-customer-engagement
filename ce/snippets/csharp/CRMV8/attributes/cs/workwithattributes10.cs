// <snippetworkwithattributes10>


 // Delete the newly inserted status value.
 // Create the request object
 DeleteOptionValueRequest deleteRequest = new DeleteOptionValueRequest
 {
     AttributeLogicalName = "statuscode",
     EntityLogicalName = Contact.EntityLogicalName,
     Value = _insertedStatusValue
 };

 // Execute the request
 _serviceProxy.Execute(deleteRequest);
 
 Console.WriteLine("Deleted all attributes created for this sample.");

// </snippetworkwithattributes10>