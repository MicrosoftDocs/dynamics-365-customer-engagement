' <snippetenabledocumentmanagement1>



 ' Retrieve an entity for which you want to enable document management.
 ' In this sample, we will retrieve and enable document management
 ' for the Contact entity because by default, document management is
 ' not enabled for this entity.                    

 Dim entityRequest As RetrieveEntityRequest =
  New RetrieveEntityRequest With {
   .EntityFilters = EntityFilters.All,
   .LogicalName = Contact.EntityLogicalName,
   .RetrieveAsIfPublished = False
  }
 ' Retrieve only the currently published changes, ignoring the changes 
 ' that have not been published.
 Dim entityResponse As RetrieveEntityResponse =
  CType(_serviceProxy.Execute(entityRequest), RetrieveEntityResponse)
 Console.WriteLine("Retrieved the contact entity.")

 ' Get the entity from the response.
 Dim contactEntity As EntityMetadata = entityResponse.EntityMetadata

 ' Enable document management for the retrieved entity.
 contactEntity.IsDocumentManagementEnabled = True

 ' Create an update request.                    
 Dim updateRequest As UpdateEntityRequest =
  New UpdateEntityRequest With {
   .Entity = contactEntity
  }
 _serviceProxy.Execute(updateRequest)

 ' Publish the entity.
 ' All customizations must be published before they can be used.
 Dim enableRequest As New PublishAllXmlRequest()
 _serviceProxy.Execute(enableRequest)

 ' Retrieve the contact entity, and verify that document management is enabled.
 entityResponse = CType(_serviceProxy.Execute(entityRequest), RetrieveEntityResponse)
 contactEntity = entityResponse.EntityMetadata
 If contactEntity.IsDocumentManagementEnabled.Value = True Then
  Console.WriteLine("Enabled document management for the contact entity.")
 End If

 RevertChanges(promptforRevert)

' </snippetenabledocumentmanagement1>