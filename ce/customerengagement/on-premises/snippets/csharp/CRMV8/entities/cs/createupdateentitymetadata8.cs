// <snippetcreateupdateentitymetadata8>


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

// </snippetcreateupdateentitymetadata8>