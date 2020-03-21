// <snippetworkwithglobaloptionsets5>


 // Use InsertOptionValueRequest to insert a new option into a 
 // global option set.
 InsertOptionValueRequest insertOptionValueRequest =
     new InsertOptionValueRequest
     {
         OptionSetName = _globalOptionSetName,
         Label = new Label("New Picklist Label", _languageCode)
     };

 // Execute the request and store the newly inserted option value 
 // for cleanup, used in the later part of this sample.
 _insertedOptionValue = ((InsertOptionValueResponse)_serviceProxy.Execute(
     insertOptionValueRequest)).NewOptionValue;

 //Publish the OptionSet
 PublishXmlRequest pxReq2 = new PublishXmlRequest { ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName) };
 _serviceProxy.Execute(pxReq2);

// </snippetworkwithglobaloptionsets5>