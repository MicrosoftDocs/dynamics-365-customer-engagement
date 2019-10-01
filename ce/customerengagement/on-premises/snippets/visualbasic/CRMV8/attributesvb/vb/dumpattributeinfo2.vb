' <snippetdumpattributeinfo2>


 Dim request As New RetrieveAllEntitiesRequest() With {
     .EntityFilters = EntityFilters.Attributes,
     .RetrieveAsIfPublished = True}

 ' Retrieve the MetaData.
 Dim response As RetrieveAllEntitiesResponse = CType(_serviceProxy.Execute(request), RetrieveAllEntitiesResponse)

 ' Create an instance of StreamWriter to write text to a file.
 ' The using statement also closes the StreamWriter.
 ' To view this file, right click the file and choose open with Excel. 
 ' Excel will figure out the schema and display the information in columns.
 Dim filename As String = String.Concat("AllAttributeDesc.xml")
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
    If currentEntity.IsCustomizable.Value = True Then
     metadataWriter.WriteElementString("IsCustomizable", "yes")
    Else
     metadataWriter.WriteElementString("IsCustomizable", "no")
    End If
    If currentEntity.IsIntersect.Value = True Then
     metadataWriter.WriteElementString("IsIntersect", "yes")
    Else
     metadataWriter.WriteElementString("IsIntersect", "no")
    End If



    '#Region "Attributes"


    ' Write Entity's Attributes.
    metadataWriter.WriteStartElement("Attributes")

    For Each currentAttribute As AttributeMetadata In currentEntity.Attributes
     ' Only write out main attributes.
     If currentAttribute.AttributeOf Is Nothing Then

      ' Start Attribute Node
      metadataWriter.WriteStartElement("Attribute")

      ' Write Attribute's information.
      metadataWriter.WriteElementString("LogicalName", currentAttribute.LogicalName)
      ' Write the Description if it is set.
      If currentAttribute.Description.UserLocalizedLabel IsNot Nothing Then
       metadataWriter.WriteElementString("Description", currentAttribute.Description.UserLocalizedLabel.Label.ToString())
      End If

      metadataWriter.WriteElementString("Type", currentAttribute.AttributeType.Value.ToString())
      If currentAttribute.DisplayName.UserLocalizedLabel IsNot Nothing Then
       metadataWriter.WriteElementString("DisplayName", currentAttribute.DisplayName.UserLocalizedLabel.Label.ToString())
      End If
      If currentAttribute.SchemaName IsNot Nothing Then
       metadataWriter.WriteElementString("SchemaName", currentAttribute.SchemaName.ToString())
      End If
      If currentAttribute.DeprecatedVersion IsNot Nothing Then
       metadataWriter.WriteElementString("DeprecatedVersion", currentAttribute.DeprecatedVersion.ToString())
      End If
      metadataWriter.WriteElementString("IsCustomAttribute", currentAttribute.IsCustomAttribute.Value.ToString())
      metadataWriter.WriteElementString("IsCustomizable", currentAttribute.IsCustomizable.Value.ToString())
      metadataWriter.WriteElementString("RequiredLevel", currentAttribute.RequiredLevel.Value.ToString())
      metadataWriter.WriteElementString("IsValidForCreate", currentAttribute.IsValidForCreate.Value.ToString())
      metadataWriter.WriteElementString("IsValidForRead", currentAttribute.IsValidForRead.Value.ToString())
      metadataWriter.WriteElementString("IsValidForUpdate", currentAttribute.IsValidForUpdate.Value.ToString())
      metadataWriter.WriteElementString("CanBeSecuredForCreate", currentAttribute.CanBeSecuredForCreate.Value.ToString())
      metadataWriter.WriteElementString("CanBeSecuredForRead", currentAttribute.CanBeSecuredForRead.Value.ToString())
      metadataWriter.WriteElementString("CanBeSecuredForUpdate", currentAttribute.CanBeSecuredForUpdate.Value.ToString())
      metadataWriter.WriteElementString("IsAuditEnabled", currentAttribute.IsAuditEnabled.Value.ToString())
      metadataWriter.WriteElementString("IsManaged", currentAttribute.IsManaged.Value.ToString())
      metadataWriter.WriteElementString("IsPrimaryId", currentAttribute.IsPrimaryId.Value.ToString())
      metadataWriter.WriteElementString("IsPrimaryName", currentAttribute.IsPrimaryName.Value.ToString())
      metadataWriter.WriteElementString("IsRenameable", currentAttribute.IsRenameable.Value.ToString())
      metadataWriter.WriteElementString("IsSecured", currentAttribute.IsSecured.Value.ToString())
      metadataWriter.WriteElementString("IsValidForAdvancedFind", currentAttribute.IsValidForAdvancedFind.Value.ToString())

      ' End Attribute Node
      metadataWriter.WriteEndElement()
     End If
    Next currentAttribute
    ' End Attributes Node
    metadataWriter.WriteEndElement()

    '#End Region

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

' </snippetdumpattributeinfo2>