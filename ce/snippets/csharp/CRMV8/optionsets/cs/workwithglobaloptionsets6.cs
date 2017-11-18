// <snippetworkwithglobaloptionsets6>


 // Use the RetrieveOptionSetRequest message to retrieve  
 // a global option set by it's name.
 RetrieveOptionSetRequest retrieveOptionSetRequest =
     new RetrieveOptionSetRequest
     {
         Name = _globalOptionSetName
     };

 // Execute the request.
 RetrieveOptionSetResponse retrieveOptionSetResponse =
     (RetrieveOptionSetResponse)_serviceProxy.Execute(
     retrieveOptionSetRequest);

 Console.WriteLine("Retrieved {0}.",
     retrieveOptionSetRequest.Name);

 // Access the retrieved OptionSetMetadata.
 OptionSetMetadata retrievedOptionSetMetadata =
     (OptionSetMetadata)retrieveOptionSetResponse.OptionSetMetadata;

 // Get the current options list for the retrieved attribute.
 OptionMetadata[] optionList =
     retrievedOptionSetMetadata.Options.ToArray();

// </snippetworkwithglobaloptionsets6>