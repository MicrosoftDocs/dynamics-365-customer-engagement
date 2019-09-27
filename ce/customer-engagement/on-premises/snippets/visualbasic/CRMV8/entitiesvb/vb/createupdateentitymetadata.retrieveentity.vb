' <snippetcreateupdateentitymetadata.retrieveentity>


 Dim retrieveBankAccountEntityRequest As RetrieveEntityRequest = New RetrieveEntityRequest With {
  .EntityFilters = EntityFilters.Entity,
  .LogicalName = _customEntityName
 }
 Dim retrieveBankAccountEntityResponse As RetrieveEntityResponse = CType(_serviceProxy.Execute(retrieveBankAccountEntityRequest), RetrieveEntityResponse)

' </snippetcreateupdateentitymetadata.retrieveentity>