' <snippetdumpoptionsetinfo1>


 '                    #Region "How to dump option set info"


 Dim retrieveAllOptionSetsRequest As New RetrieveAllOptionSetsRequest()

 ' Execute the request
 Dim retrieveAllOptionSetsResponse As RetrieveAllOptionSetsResponse =
  CType(_serviceProxy.Execute(retrieveAllOptionSetsRequest), RetrieveAllOptionSetsResponse)

 ' Create an instance of StreamWriter to write text to a file.
 ' The using statement also closes the StreamWriter.
 ' To view this file, right click the file and choose open with Excel. 
 ' Excel will figure out the schema and display the information in columns.

 Dim filename As String = String.Concat("AllOptionSetValues.xml")
 Using sw As New StreamWriter(filename)
  ' Create Xml Writer.
  Dim metadataWriter As New XmlTextWriter(sw)

  ' Start Xml File.
  metadataWriter.WriteStartDocument()

  ' Metadata Xml Node.
  metadataWriter.WriteStartElement("Metadata")

                    If retrieveAllOptionSetsResponse.OptionSetMetadata.Count() > 0 Then
                        For Each optionSetMetadataBase As OptionSetMetadataBase In retrieveAllOptionSetsResponse.OptionSetMetadata
                            If optionSetMetadataBase.OptionSetType IsNot Nothing Then
                                If CType(optionSetMetadataBase.OptionSetType, OptionSetType) = OptionSetType.Picklist Then
                                    Dim optionSetMetadata As OptionSetMetadata = CType(optionSetMetadataBase, OptionSetMetadata)
                                    ' Start OptionSet Node
                                    metadataWriter.WriteStartElement("OptionSet")
                                    metadataWriter.WriteAttributeString("OptionSetType", OptionSetType.Picklist.ToString())
                                    metadataWriter.WriteElementString("OptionSetDisplayName",
                                                                      If(optionSetMetadata.DisplayName.LocalizedLabels.Count > 0, optionSetMetadata.DisplayName.LocalizedLabels(0).Label, String.Empty))

                                    ' Writes the options
                                    metadataWriter.WriteStartElement("Options")

                                    For Each [option] As OptionMetadata In optionSetMetadata.Options
                                        metadataWriter.WriteStartElement("Option")
                                        metadataWriter.WriteElementString("OptionValue", [option].Value.ToString())
                                        metadataWriter.WriteElementString("OptionDescription", [option].Label.UserLocalizedLabel.Label.ToString())
                                        metadataWriter.WriteEndElement()
                                    Next [option]
                                    metadataWriter.WriteEndElement()

                                    ' End OptionSet Node
                                    metadataWriter.WriteEndElement()
                                ElseIf CType(optionSetMetadataBase.OptionSetType, OptionSetType) = OptionSetType.Boolean Then
                                    Dim optionSetMetadata As BooleanOptionSetMetadata = CType(optionSetMetadataBase, BooleanOptionSetMetadata)
                                    ' Start OptionSet Node
                                    metadataWriter.WriteStartElement("OptionSet")
                                    metadataWriter.WriteAttributeString("OptionSetType", OptionSetType.Boolean.ToString())
                                    metadataWriter.WriteElementString("OptionSetDisplayName",
                                                                      If(optionSetMetadata.DisplayName.LocalizedLabels.Count > 0, optionSetMetadata.DisplayName.LocalizedLabels(0).Label, String.Empty))

                                    ' Writes the TrueOption
                                    metadataWriter.WriteStartElement("TrueOption")
                                    metadataWriter.WriteElementString("OptionValue", optionSetMetadata.TrueOption.Value.ToString())
                                    metadataWriter.WriteElementString("OptionDescription", optionSetMetadata.TrueOption.Label.UserLocalizedLabel.Label.ToString())
                                    metadataWriter.WriteEndElement()
                                    ' Writes the FalseOption
                                    metadataWriter.WriteStartElement("FalseOption")
                                    metadataWriter.WriteElementString("OptionValue", optionSetMetadata.FalseOption.Value.ToString())
                                    metadataWriter.WriteElementString("OptionDescription", optionSetMetadata.FalseOption.Label.UserLocalizedLabel.Label.ToString())
                                    metadataWriter.WriteEndElement()

                                    ' End OptionSet Node
                                    metadataWriter.WriteEndElement()
                                End If
                            End If

                        Next optionSetMetadataBase
                    End If

  ' End Metadata Xml Node
  metadataWriter.WriteEndElement()
  metadataWriter.WriteEndDocument()

  ' Close xml writer.
  metadataWriter.Close()
 End Using


 '#End Region ' How to dump option set info



 Console.WriteLine("Done.")

' </snippetdumpoptionsetinfo1>