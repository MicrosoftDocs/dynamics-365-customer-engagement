// <snippetcreateandassociatekbrecordtoincident3>


 RetrieveEntityRequest entityRequest = new RetrieveEntityRequest
 {
     EntityFilters = EntityFilters.All,
     LogicalName = Incident.EntityLogicalName,

     // Retrieve only the currently published changes, ignoring the changes 
     // that have not been published.
     RetrieveAsIfPublished = false
 };
 RetrieveEntityResponse entityResponse = (RetrieveEntityResponse)_serviceProxy.Execute(entityRequest);

 if (entityResponse.EntityMetadata.IsKnowledgeManagementEnabled == true)
 {
     Console.WriteLine("Verified that knowledge management is enabled for Incident entity.\n");
     return;
 }
 else
 {
     // Enable knolwledge management for the Incident entity.
     Console.WriteLine("Knowledge management is not enabled for the Incident entity.");
     entityResponse.EntityMetadata.IsKnowledgeManagementEnabled = true;

     // Create an update request.                    
     UpdateEntityRequest updateRequest = new UpdateEntityRequest
     {
         Entity = entityResponse.EntityMetadata
     };
     _serviceProxy.Execute(updateRequest);

     // Publish the entity.
     // All customizations must be published before they can be used.
     PublishAllXmlRequest enableRequest = new PublishAllXmlRequest();
     _serviceProxy.Execute(enableRequest);
     Console.WriteLine("Enabled Knowledge management for the Incident entity.");
 }

// </snippetcreateandassociatekbrecordtoincident3>