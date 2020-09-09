// <snippetworkwithglobaloptionsets11>


 // Use the DeleteOptionValueRequest message 
 // to remove the newly inserted label.
 DeleteOptionValueRequest deleteOptionValueRequest =
     new DeleteOptionValueRequest
 {
     OptionSetName = _globalOptionSetName,
     Value = _insertedOptionValue
 };

 // Execute the request.
 _serviceProxy.Execute(deleteOptionValueRequest);

// </snippetworkwithglobaloptionsets11>