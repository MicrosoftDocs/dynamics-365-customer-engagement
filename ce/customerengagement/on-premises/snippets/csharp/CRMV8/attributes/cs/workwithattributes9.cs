// <snippetworkwithattributes9>


 // Delete all attributes created for this sample.
 foreach (AttributeMetadata anAttribute in addedAttributes)
 {
     // Create the request object
     DeleteAttributeRequest deleteAttribute = new DeleteAttributeRequest
     {
         // Set the request properties 
         EntityLogicalName = Contact.EntityLogicalName,
         LogicalName = anAttribute.SchemaName
     };
     // Execute the request
     _serviceProxy.Execute(deleteAttribute);
 }

// </snippetworkwithattributes9>