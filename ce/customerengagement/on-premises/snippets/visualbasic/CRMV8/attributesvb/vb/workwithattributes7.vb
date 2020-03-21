' <snippetworkwithattributes7>


 ' Create a request.
 Dim insertOptionValueRequest As InsertOptionValueRequest = New InsertOptionValueRequest With {
  .AttributeLogicalName = "new_picklist",
  .EntityLogicalName = Contact.EntityLogicalName,
  .Label = New Label("New Picklist Label", _languageCode)}

 ' Execute the request.
 Dim insertOptionValue As Integer = (CType(_serviceProxy.Execute(insertOptionValueRequest), InsertOptionValueResponse)).NewOptionValue

 Console.WriteLine("Created {0} with the value of {1}.", insertOptionValueRequest.Label.LocalizedLabels(0).Label, insertOptionValue)

' </snippetworkwithattributes7>