// <snippetcreateupdateentitymetadata9>



 RetrieveEntityRequest retrieveBankAccountEntityRequest = new RetrieveEntityRequest
 {
  EntityFilters = EntityFilters.Entity,
  LogicalName = _customEntityName
 };
 RetrieveEntityResponse retrieveBankAccountEntityResponse = (RetrieveEntityResponse)_serviceProxy.Execute(retrieveBankAccountEntityRequest);
 EntityMetadata BankAccountEntity = retrieveBankAccountEntityResponse.EntityMetadata;

 // Disable Mail merge
 BankAccountEntity.IsMailMergeEnabled = new BooleanManagedProperty(false);
 // Enable Notes
 UpdateEntityRequest updateBankAccountRequest = new UpdateEntityRequest
 {
  Entity = BankAccountEntity,
  HasNotes = true
 };



 _serviceProxy.Execute(updateBankAccountRequest);

// </snippetcreateupdateentitymetadata9>