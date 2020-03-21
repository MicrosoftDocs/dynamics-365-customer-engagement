' <snippetworkwithglobaloptionsets4>


 ' Use UpdateOptionSetRequest to update the basic information of an option
 ' set. Updating option set values requires different messages (see below).
 Dim updateOptionSetRequest As UpdateOptionSetRequest = New UpdateOptionSetRequest With {
  .OptionSet = New OptionSetMetadata With {
   .DisplayName = New Label("Updated Option Set", _languageCode),
   .Name = _globalOptionSetName,
   .IsGlobal = True
  }
 }

 _serviceProxy.Execute(updateOptionSetRequest)

 'Publish the OptionSet
 Dim pxReq1 As PublishXmlRequest = New PublishXmlRequest With {
  .ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName)
 }
 _serviceProxy.Execute(pxReq1)

' </snippetworkwithglobaloptionsets4>