' <snippetworkwithglobaloptionsets7>


 ' In order to change labels on option set values (or delete) option set
 ' values, you must use UpdateOptionValueRequest 
 ' (or DeleteOptionValueRequest).
 Dim updateOptionValueRequest As UpdateOptionValueRequest =
  New UpdateOptionValueRequest With {
   .OptionSetName = _globalOptionSetName,
   .Value = optionList(1).Value.Value,
   .Label = New Label("Updated Option 1", _languageCode)
  }
 ' Update the second option value.

 _serviceProxy.Execute(updateOptionValueRequest)

 'Publish the OptionSet
 Dim pxReq3 As PublishXmlRequest =
  New PublishXmlRequest With {
   .ParameterXml =
   String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>",
                 _globalOptionSetName)
  }
 _serviceProxy.Execute(pxReq3)

' </snippetworkwithglobaloptionsets7>