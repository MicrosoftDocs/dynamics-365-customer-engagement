// <snippetenabledocumentmanagement1>


 // Retrieve an entity for which you want to enable document management.
 // In this sample, we will retrieve and enable document management
 // for the Contact entity because by default, document management is
 // not enabled for this entity.                    
 
 RetrieveEntityRequest entityRequest = new RetrieveEntityRequest
 {
     EntityFilters = EntityFilters.All,
     LogicalName = Contact.EntityLogicalName,

     // Retrieve only the currently published changes, ignoring the changes 
     // that have not been published.
     RetrieveAsIfPublished = false
 };
 RetrieveEntityResponse entityResponse = (RetrieveEntityResponse)_serviceProxy.Execute(entityRequest);
 Console.WriteLine("Retrieved the contact entity.");

 // Get the entity from the response.
 EntityMetadata contactEntity = entityResponse.EntityMetadata;

 // Enable document management for the retrieved entity.
 contactEntity.IsDocumentManagementEnabled = true;

 // Create an update request.                    
 UpdateEntityRequest updateRequest = new UpdateEntityRequest
 {
     Entity = contactEntity                        
 };
 _serviceProxy.Execute(updateRequest);

 // Publish the entity.
 // All customizations must be published before they can be used.
 PublishAllXmlRequest enableRequest = new PublishAllXmlRequest();
 _serviceProxy.Execute(enableRequest);                    

 // Retrieve the contact entity, and verify that document management is enabled.
 entityResponse = (RetrieveEntityResponse)_serviceProxy.Execute(entityRequest);
 contactEntity = entityResponse.EntityMetadata;
 if (contactEntity.IsDocumentManagementEnabled.Value == true)
 {
     Console.WriteLine("Enabled document management for the contact entity.");
 }                    

 RevertChanges(promptforRevert);

// </snippetenabledocumentmanagement1>