' <snippetworkwithglobaloptionsets5>


 ' Use InsertOptionValueRequest to insert a new option into a 
 ' global option set.
 Dim insertOptionValueRequest As InsertOptionValueRequest = New InsertOptionValueRequest With {
  .OptionSetName = _globalOptionSetName,
  .Label = New Label("New Picklist Label", _languageCode)
 }

 ' Execute the request and store the newly inserted option value 
 ' for cleanup, used in the later part of this sample.
 _insertedOptionValue =
  (CType(_serviceProxy.Execute(insertOptionValueRequest), InsertOptionValueResponse)).NewOptionValue

 'Publish the OptionSet
 Dim pxReq2 As PublishXmlRequest = New PublishXmlRequest With {
  .ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName)
 }
 _serviceProxy.Execute(pxReq2)

' </snippetworkwithglobaloptionsets5>