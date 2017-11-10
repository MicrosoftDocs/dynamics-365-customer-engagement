' <snippetdumpsdkmessagetofilede2>


                    ' Write out SDK messages to an XML file.
                    ' Create an instance of StreamWriter to write text to a file.
                    ' The using statement also closes the StreamWriter.

                    Dim filename As String = "sdkmessages.xml"
                    Using sw As New StreamWriter(filename)
                        ' Create Xml Writer.
                        Dim metadataWriter As New XmlTextWriter(sw)

                        ' Start Xml File.
                        metadataWriter.WriteStartDocument()

                        ' Metadata Xml Node.
                        metadataWriter.WriteStartElement("Messages")

                        For j As Integer = 0 To sdkMessages.Entities.Count - 1

                            Dim currentRecord As Entity = sdkMessages(j)

                            metadataWriter.WriteStartElement("Message")

                            ' Write the message information.
                            metadataWriter.WriteElementString("message-name", CType(currentRecord.Attributes("name"), String))
                            metadataWriter.WriteElementString("categoryname", CType(currentRecord.Attributes("categoryname"), String))
                            If CBool(currentRecord.Attributes("isprivate")) Then
                                metadataWriter.WriteElementString("isprivate", "Yes")
                            End If
                            metadataWriter.WriteElementString("message-availability", currentRecord.Attributes("availability").ToString())
                            If CBool(currentRecord.Attributes("expand")) Then
                                metadataWriter.WriteElementString("expand", "Yes")
                            End If
                            If CBool(currentRecord.Attributes("template")) Then
                                metadataWriter.WriteElementString("template", "Yes")
                            End If


'                            #Region "filters"

                            ' Retrieve all SDK Message filter records for that entity.
                            Dim sdkMessageFilterQuery As QueryByAttribute = New QueryByAttribute With { _
                                .EntityName = "sdkmessagefilter", _
                                .ColumnSet = New ColumnSet("iscustomprocessingstepallowed", "availability", "primaryobjecttypecode", _
                                                           "secondaryobjecttypecode")}
                            sdkMessageFilterQuery.AddAttributeValue("sdkmessageid", currentRecord.Attributes("sdkmessageid"))
                            Dim sdkFilters As EntityCollection = _service.RetrieveMultiple(sdkMessageFilterQuery)
                            metadataWriter.WriteStartElement("Filters")

                            For i As Integer = 0 To sdkFilters.Entities.Count - 1

                                Dim currentFilter As Entity = sdkFilters(i)

                                metadataWriter.WriteStartElement("Filter")

                                ' Write the message information.
                                metadataWriter.WriteElementString("filter-availability", _
                                                                  currentFilter.Attributes("availability").ToString())
                                metadataWriter.WriteElementString("primaryobjecttypecode", _
                                                                  currentFilter.Attributes("primaryobjecttypecode").ToString())
                                metadataWriter.WriteElementString("secondaryobjecttypecode", _
                                                                  currentFilter.Attributes("secondaryobjecttypecode").ToString())
                                metadataWriter.WriteEndElement()

                            Next i
                            metadataWriter.WriteEndElement()


'                            #End Region ' filters

                            metadataWriter.WriteEndElement()
                        Next j


                        ' End Metadata Xml Node
                        metadataWriter.WriteEndElement()
                        metadataWriter.WriteEndDocument()

                        ' Close xml writer.
                        metadataWriter.Close()
                    End Using

' </snippetdumpsdkmessagetofilede2>