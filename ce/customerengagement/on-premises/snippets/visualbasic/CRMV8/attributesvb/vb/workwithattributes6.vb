' <snippetworkwithattributes6>


 ' Modify the state value label from Active to Open.
 ' Create the request.
 Dim updateStateValue As UpdateStateValueRequest = New UpdateStateValueRequest With {
  .AttributeLogicalName = "statecode",
  .EntityLogicalName = Contact.EntityLogicalName,
  .Value = 1,
  .Label = New Label("Open", _languageCode)}

 ' Execute the request.
 _serviceProxy.Execute(updateStateValue)

 Console.WriteLine("Updated {0} state attribute of {1} entity from 'Active' to '{2}'.",
                   updateStateValue.AttributeLogicalName,
                   updateStateValue.EntityLogicalName,
                   updateStateValue.Label.LocalizedLabels(0).Label)

' </snippetworkwithattributes6>