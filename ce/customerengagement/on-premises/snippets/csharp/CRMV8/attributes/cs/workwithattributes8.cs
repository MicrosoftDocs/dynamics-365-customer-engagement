// <snippetworkwithattributes8>


 // Use the RetrieveAttributeRequest message to retrieve  
 // a attribute by it's logical name.
 RetrieveAttributeRequest retrieveAttributeRequest =
     new RetrieveAttributeRequest
 {
     EntityLogicalName = Contact.EntityLogicalName,
     LogicalName = "new_picklist",
     RetrieveAsIfPublished = true
 };

 // Execute the request.
 RetrieveAttributeResponse retrieveAttributeResponse =
     (RetrieveAttributeResponse)_serviceProxy.Execute(
     retrieveAttributeRequest);

 // Access the retrieved attribute.
 PicklistAttributeMetadata retrievedPicklistAttributeMetadata =
     (PicklistAttributeMetadata)
     retrieveAttributeResponse.AttributeMetadata;

 // Get the current options list for the retrieved attribute.
 OptionMetadata[] optionList =
     retrievedPicklistAttributeMetadata.OptionSet.Options.ToArray();

 // Change the order of the original option's list.
 // Use the OrderBy (OrderByDescending) linq function to sort options in  
 // ascending (descending) order according to label text.
 // For ascending order use this:
 var updateOptionList =
     optionList.OrderBy(x => x.Label.LocalizedLabels[0].Label).ToList();

 // For descending order use this:
 // var updateOptionList =
 //      optionList.OrderByDescending(
 //      x => x.Label.LocalizedLabels[0].Label).ToList();

 // Create the request.
 OrderOptionRequest orderOptionRequest = new OrderOptionRequest
 {
     // Set the properties for the request.
     AttributeLogicalName = "new_picklist",
     EntityLogicalName = Contact.EntityLogicalName,
     // Set the changed order using Select linq function 
     // to get only values in an array from the changed option list.
     Values = updateOptionList.Select(x => x.Value.Value).ToArray()
 };

 // Execute the request
 _serviceProxy.Execute(orderOptionRequest);

 Console.WriteLine("Option Set option order changed");

// </snippetworkwithattributes8>