' <snippetdumprelationshipinfo1>


 Dim request As New RetrieveAllEntitiesRequest() With {
  .EntityFilters = EntityFilters.Relationships,
  .RetrieveAsIfPublished = True
 }

 ' Retrieve the MetaData.
 Dim response As RetrieveAllEntitiesResponse =
  CType(_serviceProxy.Execute(request), RetrieveAllEntitiesResponse)


 ' Create an instance of StreamWriter to write text to a file.
 ' The using statement also closes the StreamWriter.
 ' To view this file, right click the file and choose open with Excel. 
 ' Excel will figure out the schema and display the information in columns.

 Dim filename As String = String.Concat("RelationshipInfo.xml")
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

    ' Start OneToManyRelationships Node
    metadataWriter.WriteStartElement("OneToManyRelationships")

    For Each currentRelationship As OneToManyRelationshipMetadata In currentEntity.OneToManyRelationships
     ' Start  Node
     metadataWriter.WriteStartElement("Relationship")

     metadataWriter.WriteElementString("OtoM_SchemaName", currentRelationship.SchemaName)
     metadataWriter.WriteElementString("OtoM_ReferencingEntity", currentRelationship.ReferencingEntity)
     metadataWriter.WriteElementString("OtoM_ReferencedEntity", currentRelationship.ReferencedEntity)
     ' End  Node
     metadataWriter.WriteEndElement()

    Next currentRelationship

    ' End OneToManyRelationships Node
    metadataWriter.WriteEndElement()

    ' Start ManyToManyRelationships Node
    metadataWriter.WriteStartElement("ManyToManyRelationships")


    For Each currentRelationship As ManyToManyRelationshipMetadata In currentEntity.ManyToManyRelationships
     ' Start  Node
     metadataWriter.WriteStartElement("Relationship")

     metadataWriter.WriteElementString("MtoM_SchemaName", currentRelationship.SchemaName)
     metadataWriter.WriteElementString("MtoM_Entity1", currentRelationship.Entity1LogicalName)
     metadataWriter.WriteElementString("MtoM_Entity2", currentRelationship.Entity2LogicalName)
     metadataWriter.WriteElementString("IntersectEntity", currentRelationship.IntersectEntityName)
     ' End  Node
     metadataWriter.WriteEndElement()

    Next currentRelationship

    ' End ManyToManyRelationships Node
    metadataWriter.WriteEndElement()

    ' Start ManyToOneRelationships Node
    metadataWriter.WriteStartElement("ManyToOneRelationships")


    For Each currentRelationship As OneToManyRelationshipMetadata In currentEntity.ManyToOneRelationships
     ' Start  Node
     metadataWriter.WriteStartElement("Relationship")

     metadataWriter.WriteElementString("MtoO_SchemaName", currentRelationship.SchemaName)
     metadataWriter.WriteElementString("MtoO_ReferencingEntity", currentRelationship.ReferencingEntity)
     metadataWriter.WriteElementString("MtoO_ReferencedEntity", currentRelationship.ReferencedEntity)
     ' End  Node
     metadataWriter.WriteEndElement()

    Next currentRelationship

    ' End ManyToOneRelationships Node
    metadataWriter.WriteEndElement()

    ' End Relationships Node
    ' metadataWriter.WriteEndElement();



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

' </snippetdumprelationshipinfo1>