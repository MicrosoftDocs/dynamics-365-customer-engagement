' <snippetdumpentityinfo1>


 Dim request As New RetrieveAllEntitiesRequest() With {
  .EntityFilters = EntityFilters.Entity,
  .RetrieveAsIfPublished = True
 }

 ' Retrieve the MetaData.
 Dim response As RetrieveAllEntitiesResponse = CType(_serviceProxy.Execute(request), RetrieveAllEntitiesResponse)


 ' Create an instance of StreamWriter to write text to a file.
 ' The using statement also closes the StreamWriter.
 ' To view this file, right click the file and choose open with Excel. 
 ' Excel will figure out the schema and display the information in columns.

 Dim filename As String = String.Concat("EntityInfo.xml")
 Using sw As New StreamWriter(filename)
  ' Create Xml Writer.
  Dim metadataWriter As New XmlTextWriter(sw)

  ' Start Xml File.
  metadataWriter.WriteStartDocument()

  ' Metadata Xml Node.
  metadataWriter.WriteStartElement("Metadata")

  For Each currentEntity As EntityMetadata In response.EntityMetadata
   'if (currentEntity.IsIntersect.Value == false)
   If True Then
    ' Start Entity Node
    metadataWriter.WriteStartElement("Entity")

    ' Write the Entity's Information.
    metadataWriter.WriteElementString("EntityLogicalName", currentEntity.LogicalName)
    metadataWriter.WriteElementString("OTC", currentEntity.ObjectTypeCode.ToString())
    metadataWriter.WriteElementString("OwnershipType", currentEntity.OwnershipType.Value.ToString())
    If currentEntity.DisplayName.UserLocalizedLabel IsNot Nothing Then
     metadataWriter.WriteElementString("DisplayName", currentEntity.DisplayName.UserLocalizedLabel.Label)
    End If
    If currentEntity.DisplayCollectionName.UserLocalizedLabel IsNot Nothing Then
     metadataWriter.WriteElementString("DisplayCollectionName", currentEntity.DisplayCollectionName.UserLocalizedLabel.Label)
    End If

    metadataWriter.WriteElementString("AutoRouteToOwnerQueue", currentEntity.AutoRouteToOwnerQueue.ToString())
    metadataWriter.WriteElementString("CanBeInManyToMany", currentEntity.CanBeInManyToMany.Value.ToString())
    metadataWriter.WriteElementString("CanBePrimaryEntityInRelationship", currentEntity.CanBePrimaryEntityInRelationship.Value.ToString())
    metadataWriter.WriteElementString("CanBeRelatedEntityInRelationship", currentEntity.CanBeRelatedEntityInRelationship.Value.ToString())
    metadataWriter.WriteElementString("CanCreateAttributes", currentEntity.CanCreateAttributes.Value.ToString())
    metadataWriter.WriteElementString("CanCreateCharts", currentEntity.CanCreateCharts.Value.ToString())
    metadataWriter.WriteElementString("CanCreateForms", currentEntity.CanCreateForms.Value.ToString())
    metadataWriter.WriteElementString("CanCreateViews", currentEntity.CanCreateViews.Value.ToString())
    metadataWriter.WriteElementString("CanModifyAdditionalSettings", currentEntity.CanModifyAdditionalSettings.Value.ToString())
    metadataWriter.WriteElementString("CanTriggerWorkflow", currentEntity.CanTriggerWorkflow.Value.ToString())

    metadataWriter.WriteElementString("IsActivity", currentEntity.IsActivity.Value.ToString())
    'metadataWriter.WriteElementString("ActivityTypeMask", currentEntity.ActivityTypeMask.ToString());

    metadataWriter.WriteElementString("IsActivityParty", currentEntity.IsActivityParty.Value.ToString())

    metadataWriter.WriteElementString("IsAuditEnabled", currentEntity.IsAuditEnabled.Value.ToString())
    metadataWriter.WriteElementString("IsAvailableOffline", currentEntity.IsAvailableOffline.ToString())
    metadataWriter.WriteElementString("IsChildEntity", currentEntity.IsChildEntity.ToString())
    metadataWriter.WriteElementString("IsConnectionsEnabled", currentEntity.IsConnectionsEnabled.ManagedPropertyLogicalName.ToString())
    metadataWriter.WriteElementString("IsCustomEntity", currentEntity.IsCustomEntity.Value.ToString())
    metadataWriter.WriteElementString("IsCustomizable", currentEntity.IsCustomizable.Value.ToString())

    metadataWriter.WriteElementString("IsDocumentManagementEnabled", currentEntity.IsDocumentManagementEnabled.Value.ToString())
    metadataWriter.WriteElementString("IsDuplicateDetectionEnabled", currentEntity.IsDuplicateDetectionEnabled.Value.ToString())
    If currentEntity.IsEnabledForCharts IsNot Nothing Then
     metadataWriter.WriteElementString("IsEnabledForCharts", currentEntity.IsEnabledForCharts.Value.ToString())
    End If
    metadataWriter.WriteElementString("IsImportable", currentEntity.IsImportable.Value.ToString())
    metadataWriter.WriteElementString("IsIntersect", currentEntity.IsIntersect.Value.ToString())

    metadataWriter.WriteElementString("IsMailMergeEnabled", currentEntity.IsMailMergeEnabled.Value.ToString())
    metadataWriter.WriteElementString("IsManaged", currentEntity.IsManaged.Value.ToString())
    metadataWriter.WriteElementString("IsMappable", currentEntity.IsMappable.Value.ToString())

    metadataWriter.WriteElementString("IsReadingPaneEnabled", currentEntity.IsReadingPaneEnabled.Value.ToString())
    metadataWriter.WriteElementString("IsRenameable", currentEntity.IsRenameable.Value.ToString())
    metadataWriter.WriteElementString("IsValidForAdvancedFind", currentEntity.IsValidForAdvancedFind.Value.ToString())
    metadataWriter.WriteElementString("IsValidForQueue", currentEntity.IsValidForQueue.Value.ToString())
    metadataWriter.WriteElementString("IsVisibleInMobile", currentEntity.IsVisibleInMobile.Value.ToString())

    metadataWriter.WriteElementString("PrimaryIdAttribute", currentEntity.PrimaryIdAttribute)
    metadataWriter.WriteElementString("PrimaryNameAttribute", currentEntity.PrimaryNameAttribute)
    metadataWriter.WriteElementString("ReportViewName", currentEntity.ReportViewName)
    metadataWriter.WriteElementString("RecurrenceBaseEntityLogicalName", currentEntity.RecurrenceBaseEntityLogicalName)
    If currentEntity.Description.UserLocalizedLabel IsNot Nothing Then
     metadataWriter.WriteElementString("Description", currentEntity.Description.UserLocalizedLabel.Label)
    End If



    ' End Entity Node
    metadataWriter.WriteEndElement()
   End If
  Next currentEntity

  ' End Metadata Xml Node
  metadataWriter.WriteEndElement()
  metadataWriter.WriteEndDocument()

  ' Close xml writer.
  metadataWriter.Close()
 End Using




 Console.WriteLine("Done.")

' </snippetdumpentityinfo1>