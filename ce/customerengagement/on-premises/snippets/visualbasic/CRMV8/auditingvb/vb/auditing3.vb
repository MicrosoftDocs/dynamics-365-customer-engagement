' <snippetauditing3>


 Private Function EnableEntityAuditing(ByVal entityLogicalName As String, ByVal flag As Boolean) As Boolean
     ' Retrieve the entity metadata.
     Dim entityRequest As RetrieveEntityRequest = New RetrieveEntityRequest With {.LogicalName = entityLogicalName, .EntityFilters = EntityFilters.Attributes}

     Dim entityResponse As RetrieveEntityResponse = CType(_service.Execute(entityRequest), RetrieveEntityResponse)

     ' Enable auditing on the entity. By default, this also enables auditing
     ' on all the entity's attributes.
     Dim entityMetadata As EntityMetadata = entityResponse.EntityMetadata

     Dim oldValue As Boolean = entityMetadata.IsAuditEnabled.Value
     entityMetadata.IsAuditEnabled = New BooleanManagedProperty(flag)

     Dim updateEntityRequest As UpdateEntityRequest = New UpdateEntityRequest With {.Entity = entityMetadata}

     Dim updateEntityResponse As UpdateEntityResponse = CType(_service.Execute(updateEntityRequest), UpdateEntityResponse)

     Return oldValue
 End Function

' </snippetauditing3>