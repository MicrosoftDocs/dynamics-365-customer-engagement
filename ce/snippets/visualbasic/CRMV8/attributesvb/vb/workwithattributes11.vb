' <snippetworkwithattributes11>


 ' Revert the state value label from Open to Active.
 ' Create the request.
 Dim revertStateValue As UpdateStateValueRequest = New UpdateStateValueRequest With {
  .AttributeLogicalName = "statecode",
  .EntityLogicalName = Contact.EntityLogicalName,
  .Value = 1, .Label = New Label("Active", _languageCode)}

 ' Execute the request.
 _serviceProxy.Execute(revertStateValue)

 ' NOTE: All customizations must be published before they can be used.
 _serviceProxy.Execute(New PublishAllXmlRequest())

 Console.WriteLine("Reverted {0} state attribute of {1} entity from 'Open' to '{2}'.",
                   revertStateValue.AttributeLogicalName,
                   revertStateValue.EntityLogicalName,
                   revertStateValue.Label.LocalizedLabels(0).Label)

' </snippetworkwithattributes11>