' <snippetworkwithattributes8>


 ' Use the RetrieveAttributeRequest message to retrieve  
 ' a attribute by it's logical name.
 Dim retrieveAttributeRequest As RetrieveAttributeRequest = New RetrieveAttributeRequest With {
  .EntityLogicalName = Contact.EntityLogicalName,
  .LogicalName = "new_picklist",
  .RetrieveAsIfPublished = True}

 ' Execute the request.
 Dim retrieveAttributeResponse As RetrieveAttributeResponse = CType(_serviceProxy.Execute(retrieveAttributeRequest), RetrieveAttributeResponse)

 ' Access the retrieved attribute.
 Dim retrievedPicklistAttributeMetadata As PicklistAttributeMetadata = CType(retrieveAttributeResponse.AttributeMetadata, PicklistAttributeMetadata)

 ' Get the current options list for the retrieved attribute.
 Dim optionList() As OptionMetadata = retrievedPicklistAttributeMetadata.OptionSet.Options.ToArray()

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
 Dim orderOptionRequest As OrderOptionRequest = New OrderOptionRequest With {
  .AttributeLogicalName = "new_picklist",
  .EntityLogicalName = Contact.EntityLogicalName,
  .Values = updateOptionList.Select(Function(x) x.Value.Value).ToArray()}
 ' Set the properties for the request.
 ' Set the changed order using Select linq function 
 ' to get only values in an array from the changed option list.

 ' Execute the request
 _serviceProxy.Execute(orderOptionRequest)

 Console.WriteLine("Option Set option order changed")

' </snippetworkwithattributes8>