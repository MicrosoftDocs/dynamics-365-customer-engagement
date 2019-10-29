// <snippetcreateupdateentitymetadata.retrieveentity>


 RetrieveEntityRequest retrieveBankAccountEntityRequest = new RetrieveEntityRequest
 {
  EntityFilters = EntityFilters.Entity,
  LogicalName = _customEntityName
 };
 RetrieveEntityResponse retrieveBankAccountEntityResponse = (RetrieveEntityResponse)_serviceProxy.Execute(retrieveBankAccountEntityRequest);

// </snippetcreateupdateentitymetadata.retrieveentity>