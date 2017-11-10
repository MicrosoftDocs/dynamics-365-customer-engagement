' <snippetcreateupdateentitymetadata8>


 Dim BankAccountEntity As EntityMetadata = retrieveBankAccountEntityResponse.EntityMetadata

 ' Disable Mail merge
 BankAccountEntity.IsMailMergeEnabled = New BooleanManagedProperty(False)
 ' Enable Notes
 Dim updateBankAccountRequest As UpdateEntityRequest = New UpdateEntityRequest With {
  .Entity = BankAccountEntity,
  .HasNotes = True
 }
 _serviceProxy.Execute(updateBankAccountRequest)

' </snippetcreateupdateentitymetadata8>