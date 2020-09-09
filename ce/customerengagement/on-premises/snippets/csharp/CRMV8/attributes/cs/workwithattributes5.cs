// <snippetworkwithattributes5>


 // Modify the retrieved attribute
 AttributeMetadata retrievedAttributeMetadata =
     attributeResponse.AttributeMetadata;
 retrievedAttributeMetadata.DisplayName =
     new Label("Update String Attribute", _languageCode);

 // Update an attribute retrieved via RetrieveAttributeRequest
 UpdateAttributeRequest updateRequest = new UpdateAttributeRequest
 {
     Attribute = retrievedAttributeMetadata,
     EntityName = Contact.EntityLogicalName,
     MergeLabels = false
 };

 // Execute the request
 _serviceProxy.Execute(updateRequest);

 Console.WriteLine("Updated the attribute {0}.",
     retrievedAttributeMetadata.SchemaName);

// </snippetworkwithattributes5>