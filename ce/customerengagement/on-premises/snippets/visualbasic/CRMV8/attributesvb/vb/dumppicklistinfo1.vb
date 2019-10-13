' <snippetdumppicklistinfo1>


 '                    #Region "How to dump attribute info"
 Dim request As New RetrieveAllEntitiesRequest() With {
     .EntityFilters = EntityFilters.Attributes,
     .RetrieveAsIfPublished = True}

 ' Retrieve the MetaData.
 Dim response As RetrieveAllEntitiesResponse = CType(_serviceProxy.Execute(request), RetrieveAllEntitiesResponse)

 ' Create an instance of StreamWriter to write text to a file.
 ' The using statement also closes the StreamWriter.
 ' To view this file, right click the file and choose open with Excel. 
 ' Excel will figure out the schema and display the information in columns.

 Dim filename As String = String.Concat("AttributePicklistValues.xml")
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
    If currentEntity.IsCustomizable.Value = True Then
     metadataWriter.WriteElementString("IsCustomizable", "yes")
    Else
     metadataWriter.WriteElementString("IsCustomizable", "no")
    End If

    '                                #Region "Attributes"

    ' Write Entity's Attributes.
    metadataWriter.WriteStartElement("Attributes")

    For Each currentAttribute As AttributeMetadata In currentEntity.Attributes
     ' Only write out main attributes.
     If currentAttribute.AttributeOf Is Nothing Then

      ' Start Attribute Node
      metadataWriter.WriteStartElement("Attribute")

      ' Write Attribute's information.
      metadataWriter.WriteElementString("LogicalName", currentAttribute.LogicalName)
      metadataWriter.WriteElementString("Type", currentAttribute.AttributeType.Value.ToString())

      If currentAttribute.GetType() Is GetType(PicklistAttributeMetadata) Then
       Dim optionMetadata As PicklistAttributeMetadata = CType(currentAttribute, PicklistAttributeMetadata)
       ' Writes the picklist's options
       metadataWriter.WriteStartElement("Options")

       ' Writes the attributes of each picklist option
       For c As Integer = 0 To optionMetadata.OptionSet.Options.Count - 1
        metadataWriter.WriteStartElement("Option")
        metadataWriter.WriteElementString("OptionValue", optionMetadata.OptionSet.Options(c).Value.Value.ToString())
        metadataWriter.WriteElementString("OptionDescription", optionMetadata.OptionSet.Options(c).Label.UserLocalizedLabel.Label.ToString())
        metadataWriter.WriteEndElement()
       Next c

       metadataWriter.WriteEndElement()

      ElseIf currentAttribute.GetType() Is GetType(StateAttributeMetadata) Then
       Dim optionMetadata As StateAttributeMetadata = CType(currentAttribute, StateAttributeMetadata)
       ' Writes the picklist's options
       metadataWriter.WriteStartElement("Options")

       ' Writes the attributes of each picklist option
       For c As Integer = 0 To optionMetadata.OptionSet.Options.Count - 1
        metadataWriter.WriteStartElement("Option")
        metadataWriter.WriteElementString("OptionValue", optionMetadata.OptionSet.Options(c).Value.Value.ToString())
        metadataWriter.WriteElementString("OptionDescription", optionMetadata.OptionSet.Options(c).Label.UserLocalizedLabel.Label.ToString())
        metadataWriter.WriteEndElement()
       Next c

       metadataWriter.WriteEndElement()
      ElseIf currentAttribute.GetType() Is GetType(StatusAttributeMetadata) Then
       Dim optionMetadata As StatusAttributeMetadata = CType(currentAttribute, StatusAttributeMetadata)
       ' Writes the picklist's options
       metadataWriter.WriteStartElement("Options")

       ' Writes the attributes of each picklist option
       For c As Integer = 0 To optionMetadata.OptionSet.Options.Count - 1
        metadataWriter.WriteStartElement("Option")
        metadataWriter.WriteElementString("OptionValue", optionMetadata.OptionSet.Options(c).Value.Value.ToString())
                                            metadataWriter.WriteElementString("OptionDescription", optionMetadata.OptionSet.Options(c).Label.UserLocalizedLabel.Label.ToString())

                                            If optionMetadata.OptionSet.Options(c).GetType() Is GetType(StatusOptionMetadata) Then
                                                Dim statusOptionMetadata As StatusOptionMetadata = CType(optionMetadata.OptionSet.Options(c), StatusOptionMetadata)


                                                metadataWriter.WriteElementString("RelatedToState", (statusOptionMetadata.State.ToString()))
                                            End If

                                            metadataWriter.WriteEndElement()
                                        Next c

       metadataWriter.WriteEndElement()
      End If

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

 '#End Region ' How to dump attribute info



 Console.WriteLine("Done.")

' </snippetdumppicklistinfo1>