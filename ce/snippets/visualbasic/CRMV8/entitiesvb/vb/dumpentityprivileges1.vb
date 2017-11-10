' <snippetdumpentityprivileges1>


 Dim request As New RetrieveAllEntitiesRequest() With {
  .EntityFilters = EntityFilters.Privileges,
  .RetrieveAsIfPublished = True
 }

 ' Retrieve the MetaData.
 Dim response As RetrieveAllEntitiesResponse = CType(_serviceProxy.Execute(request), RetrieveAllEntitiesResponse)


 ' Create an instance of StreamWriter to write text to a file.
 ' The using statement also closes the StreamWriter.
 ' To view this file, right click the file and choose open with Excel. 
 ' Excel will figure out the schema and display the information in columns.

 Dim filename As String = String.Concat("EntityPrivileges.xml")
 Using sw As New StreamWriter(filename)
  ' Create Xml Writer.
  Dim metadataWriter As New XmlTextWriter(sw)

  ' Start Xml File.
  metadataWriter.WriteStartDocument()

  ' Metadata Xml Node.
  metadataWriter.WriteStartElement("Metadata")

  For Each currentEntity As EntityMetadata In response.EntityMetadata
   If currentEntity.IsIntersect.Value = False Then
    ' Start Entity Node
    metadataWriter.WriteStartElement("Entity")

    ' Write the Entity's Information.
    metadataWriter.WriteElementString("EntityLogicalName", currentEntity.LogicalName)
    metadataWriter.WriteElementString("OTC", currentEntity.ObjectTypeCode.ToString())


    metadataWriter.WriteStartElement("Privileges")

    For Each privilege As SecurityPrivilegeMetadata In currentEntity.Privileges
     metadataWriter.WriteStartElement("Privilege")
     metadataWriter.WriteElementString("PrivilegeName", privilege.Name.ToString())
     metadataWriter.WriteElementString("Id", privilege.PrivilegeId.ToString())
     metadataWriter.WriteElementString("Type", privilege.PrivilegeType.ToString())
     metadataWriter.WriteElementString("CanBeBasic", privilege.CanBeBasic.ToString())
     metadataWriter.WriteElementString("CanBeDeep", privilege.CanBeDeep.ToString())
     metadataWriter.WriteElementString("CanBeGlobal", privilege.CanBeGlobal.ToString())
     metadataWriter.WriteElementString("CanBeLocal", privilege.CanBeLocal.ToString())

     metadataWriter.WriteEndElement()


    Next privilege

    metadataWriter.WriteEndElement()


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

' </snippetdumpentityprivileges1>