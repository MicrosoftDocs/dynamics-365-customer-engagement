' <snippetworkwithattributes3>


 ' Use InsertStatusValueRequest message to insert a new status 
 ' in an existing status attribute. 
 ' Create the request.
 Dim insertStatusValueRequest As InsertStatusValueRequest = New InsertStatusValueRequest With {
  .AttributeLogicalName = "statuscode",
  .EntityLogicalName = Contact.EntityLogicalName,
  .Label = New Label("Dormant", _languageCode),
  .StateCode = 0}

 ' Execute the request and store newly inserted value 
 ' for cleanup, used later part of this sample. 
 _insertedStatusValue = (CType(_serviceProxy.Execute(insertStatusValueRequest), InsertStatusValueResponse)).NewOptionValue

 Console.WriteLine("Created {0} with the value of {1}.", insertStatusValueRequest.Label.LocalizedLabels(0).Label, _insertedStatusValue)

' </snippetworkwithattributes3>