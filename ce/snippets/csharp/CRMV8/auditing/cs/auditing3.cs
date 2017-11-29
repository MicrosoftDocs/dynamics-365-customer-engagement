// <snippetauditing3>


 private bool EnableEntityAuditing(string entityLogicalName, bool flag)
 {
     // Retrieve the entity metadata.
     RetrieveEntityRequest entityRequest = new RetrieveEntityRequest
     {
         LogicalName = entityLogicalName,
         EntityFilters = EntityFilters.Attributes
     };

     RetrieveEntityResponse entityResponse =
         (RetrieveEntityResponse)_service.Execute(entityRequest);

     // Enable auditing on the entity. By default, this also enables auditing
     // on all the entity's attributes.
     EntityMetadata entityMetadata = entityResponse.EntityMetadata;

     bool oldValue = entityMetadata.IsAuditEnabled.Value;
     entityMetadata.IsAuditEnabled = new BooleanManagedProperty(flag);

     UpdateEntityRequest updateEntityRequest = new UpdateEntityRequest { Entity = entityMetadata };

     UpdateEntityResponse updateEntityResponse =
         (UpdateEntityResponse)_service.Execute(updateEntityRequest);

     return oldValue;
 }

// </snippetauditing3>