// <snippetworkwithattributes4>


 // Create the request
 RetrieveAttributeRequest attributeRequest = new RetrieveAttributeRequest
 {
     EntityLogicalName = Contact.EntityLogicalName,
     LogicalName = "new_string",
     RetrieveAsIfPublished = true
 };

 // Execute the request
 RetrieveAttributeResponse attributeResponse =
     (RetrieveAttributeResponse)_serviceProxy.Execute(attributeRequest);

 Console.WriteLine("Retrieved the attribute {0}.",
     attributeResponse.AttributeMetadata.SchemaName);

// </snippetworkwithattributes4>