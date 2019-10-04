// <snippetworkwithglobaloptionsets8>


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
     OptionSetName = _globalOptionSetName,
     // Set the changed order using Select linq function 
     // to get only values in an array from the changed option list.
     Values = updateOptionList.Select(x => x.Value.Value).ToArray()
 };

 // Execute the request
 _serviceProxy.Execute(orderOptionRequest);

 //Publish the OptionSet
 PublishXmlRequest pxReq4 = new PublishXmlRequest { ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName) };
 _serviceProxy.Execute(pxReq4);

// </snippetworkwithglobaloptionsets8>