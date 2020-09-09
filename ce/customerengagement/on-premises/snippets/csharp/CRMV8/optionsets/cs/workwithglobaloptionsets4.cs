// <snippetworkwithglobaloptionsets4>


 // Use UpdateOptionSetRequest to update the basic information of an option
 // set. Updating option set values requires different messages (see below).
 UpdateOptionSetRequest updateOptionSetRequest = new UpdateOptionSetRequest
 {
     OptionSet = new OptionSetMetadata
     {
         DisplayName = new Label("Updated Option Set", _languageCode),
         Name = _globalOptionSetName,
         IsGlobal = true
     }
 };

 _serviceProxy.Execute(updateOptionSetRequest);

 //Publish the OptionSet
 PublishXmlRequest pxReq1 = new PublishXmlRequest { ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName) };
 _serviceProxy.Execute(pxReq1);

// </snippetworkwithglobaloptionsets4>