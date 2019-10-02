// <snippetworkwithglobaloptionsets9>


 // Use RetrieveAllOptionSetsRequest to retrieve all global option sets.
 // Create the request.
 RetrieveAllOptionSetsRequest retrieveAllOptionSetsRequest =
     new RetrieveAllOptionSetsRequest();

 // Execute the request
 RetrieveAllOptionSetsResponse retrieveAllOptionSetsResponse =
     (RetrieveAllOptionSetsResponse)_serviceProxy.Execute(
     retrieveAllOptionSetsRequest);

 // Now you can use RetrieveAllOptionSetsResponse.OptionSetMetadata property to 
 // work with all retrieved option sets.
 if (retrieveAllOptionSetsResponse.OptionSetMetadata.Count() > 0)
 {
     Console.WriteLine("All the global option sets retrieved as below:");
     int count = 1;
     foreach (OptionSetMetadataBase optionSetMetadata in
         retrieveAllOptionSetsResponse.OptionSetMetadata)
     {
         Console.WriteLine("{0} {1}", count++,
             (optionSetMetadata.DisplayName.LocalizedLabels.Count >0)? optionSetMetadata.DisplayName.LocalizedLabels[0].Label : String.Empty);
     }
 }

// </snippetworkwithglobaloptionsets9>