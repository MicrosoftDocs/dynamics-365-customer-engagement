' <snippetworkwithglobaloptionsets8>


 ' Change the order of the original option's list.
 ' Use the OrderBy (OrderByDescending) linq function to sort options in  
 ' ascending (descending) order according to label text.
 ' For ascending order use this:
 Dim updateOptionList = optionList.OrderBy(Function(x) x.Label.LocalizedLabels(0).Label).ToList()

 ' For descending order use this:
 ' var updateOptionList =
 '      optionList.OrderByDescending(
 '      x => x.Label.LocalizedLabels[0].Label).ToList();

 ' Create the request.
 Dim orderOptionRequest As OrderOptionRequest =
  New OrderOptionRequest With {
   .OptionSetName = _globalOptionSetName,
   .Values = updateOptionList.Select(Function(x) x.Value.Value).ToArray()
  }
 ' Set the properties for the request.
 ' Set the changed order using Select linq function 
 ' to get only values in an array from the changed option list.

 ' Execute the request
 _serviceProxy.Execute(orderOptionRequest)

 'Publish the OptionSet
 Dim pxReq4 As PublishXmlRequest =
  New PublishXmlRequest With {
   .ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>",
                                 _globalOptionSetName)
  }
 _serviceProxy.Execute(pxReq4)

' </snippetworkwithglobaloptionsets8>