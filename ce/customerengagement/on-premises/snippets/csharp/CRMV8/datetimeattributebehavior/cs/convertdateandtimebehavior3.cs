// <snippetconvertdateandtimebehavior3>


 // Retrieve the attribute to update its behavior and format
 RetrieveAttributeRequest attributeRequest = new RetrieveAttributeRequest
 {
     EntityLogicalName = Account.EntityLogicalName,
     LogicalName = "new_sampledatetimeattribute",
     RetrieveAsIfPublished = false
 };
 // Execute the request
 RetrieveAttributeResponse attributeResponse =
                 (RetrieveAttributeResponse)_serviceProxy.Execute(attributeRequest);

 Console.WriteLine("Retrieved the attribute '{0}'.",
                 attributeResponse.AttributeMetadata.SchemaName);

 // Modify the values of the retrieved attribute
 DateTimeAttributeMetadata retrievedAttributeMetadata =
                 (DateTimeAttributeMetadata)attributeResponse.AttributeMetadata;
 retrievedAttributeMetadata.DateTimeBehavior = DateTimeBehavior.DateOnly;
 retrievedAttributeMetadata.Format = DateTimeFormat.DateOnly;

 // Update the attribute with the modified value
 UpdateAttributeRequest updateRequest = new UpdateAttributeRequest
 {
     Attribute = retrievedAttributeMetadata,
     EntityName = Account.EntityLogicalName,
     MergeLabels = false
 };
 _serviceProxy.Execute(updateRequest);
 Console.WriteLine("Updated the behavior and format of '{0}' to DateOnly.",
     retrievedAttributeMetadata.SchemaName);

 // Publish customizations to the account entity
 PublishXmlRequest pxReq = new PublishXmlRequest
 {
     ParameterXml = String.Format("<importexportxml><entities><entity>account</entity></entities></importexportxml>")
 };
 _serviceProxy.Execute(pxReq);
 Console.WriteLine("Published customizations to the Account entity.\n");

// </snippetconvertdateandtimebehavior3>