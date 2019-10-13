' <snippetcreateupdateentitymetadata9>



 Dim retrieveBankAccountEntityRequest As RetrieveEntityRequest = New RetrieveEntityRequest With {
  .EntityFilters = EntityFilters.Entity,
  .LogicalName = _customEntityName
 }
 Dim retrieveBankAccountEntityResponse As RetrieveEntityResponse = CType(_serviceProxy.Execute(retrieveBankAccountEntityRequest), RetrieveEntityResponse)
 Dim BankAccountEntity As EntityMetadata = retrieveBankAccountEntityResponse.EntityMetadata

 ' Disable Mail merge
 BankAccountEntity.IsMailMergeEnabled = New BooleanManagedProperty(False)
 ' Enable Notes
 Dim updateBankAccountRequest As UpdateEntityRequest = New UpdateEntityRequest With {
  .Entity = BankAccountEntity,
  .HasNotes = True
 }
 _serviceProxy.Execute(updateBankAccountRequest)

' </snippetcreateupdateentitymetadata9>