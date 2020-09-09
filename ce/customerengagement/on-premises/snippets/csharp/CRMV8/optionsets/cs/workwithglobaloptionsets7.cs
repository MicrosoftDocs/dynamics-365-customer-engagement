// <snippetworkwithglobaloptionsets7>


 // In order to change labels on option set values (or delete) option set
 // values, you must use UpdateOptionValueRequest 
 // (or DeleteOptionValueRequest).
 UpdateOptionValueRequest updateOptionValueRequest =
     new UpdateOptionValueRequest
     {
         OptionSetName = _globalOptionSetName,
         // Update the second option value.
         Value = optionList[1].Value.Value,
         Label = new Label("Updated Option 1", _languageCode)
     };

 _serviceProxy.Execute(updateOptionValueRequest);

 //Publish the OptionSet
 PublishXmlRequest pxReq3 = new PublishXmlRequest { ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName) };
 _serviceProxy.Execute(pxReq3);

// </snippetworkwithglobaloptionsets7>