// <snippetdumpoptionsetinfo1>


               #region How to dump option set info


               RetrieveAllOptionSetsRequest retrieveAllOptionSetsRequest =
                    new RetrieveAllOptionSetsRequest();

               // Execute the request
               RetrieveAllOptionSetsResponse retrieveAllOptionSetsResponse =
                   (RetrieveAllOptionSetsResponse)_serviceProxy.Execute(
                   retrieveAllOptionSetsRequest);

               // Create an instance of StreamWriter to write text to a file.
               // The using statement also closes the StreamWriter.
 // To view this file, right click the file and choose open with Excel. 
 // Excel will figure out the schema and display the information in columns.

               String filename = String.Concat("AllOptionSetValues.xml");
               using (StreamWriter sw = new StreamWriter(filename))
               {
                   // Create Xml Writer.
                   XmlTextWriter metadataWriter = new XmlTextWriter(sw);

                   // Start Xml File.
                   metadataWriter.WriteStartDocument();

                   // Metadata Xml Node.
                   metadataWriter.WriteStartElement("Metadata");

                   if (retrieveAllOptionSetsResponse.OptionSetMetadata.Count() > 0)
                   {
                       
                       foreach (OptionSetMetadataBase optionSetMetadataBase in
                           retrieveAllOptionSetsResponse.OptionSetMetadata)
                       {
                           if (optionSetMetadataBase.OptionSetType != null)
                           {
                               if ((OptionSetType)optionSetMetadataBase.OptionSetType == OptionSetType.Picklist)
                               {
                                   OptionSetMetadata optionSetMetadata = (OptionSetMetadata)optionSetMetadataBase;
                                   // Start OptionSet Node
                                   metadataWriter.WriteStartElement("OptionSet");
                                   metadataWriter.WriteAttributeString("OptionSetType", OptionSetType.Picklist.ToString());
                                   metadataWriter.WriteElementString("OptionSetDisplayName", 
                                       (optionSetMetadata.DisplayName.LocalizedLabels.Count > 0)? optionSetMetadata.DisplayName.LocalizedLabels[0].Label : String.Empty);

                                   // Writes the options
                                   metadataWriter.WriteStartElement("Options");

                                   foreach (OptionMetadata option in optionSetMetadata.Options)
                                   {
                                       metadataWriter.WriteStartElement("Option");
                                       metadataWriter.WriteElementString("OptionValue", option.Value.ToString());
                                       metadataWriter.WriteElementString("OptionDescription", option.Label.UserLocalizedLabel.Label.ToString());
                                       metadataWriter.WriteEndElement();
                                   }
                                   metadataWriter.WriteEndElement();

                                   // End OptionSet Node
                                   metadataWriter.WriteEndElement();
                               }
                               else if ((OptionSetType)optionSetMetadataBase.OptionSetType == OptionSetType.Boolean)
                               {
                                   BooleanOptionSetMetadata optionSetMetadata = (BooleanOptionSetMetadata)optionSetMetadataBase;
                                   // Start OptionSet Node
                                   metadataWriter.WriteStartElement("OptionSet");
                                   metadataWriter.WriteAttributeString("OptionSetType", OptionSetType.Boolean.ToString());
                                   if (optionSetMetadata.DisplayName.LocalizedLabels.Count != 0)
                                       metadataWriter.WriteElementString("OptionSetDisplayName", optionSetMetadata.DisplayName.LocalizedLabels[0].Label);
                                   else
                                       metadataWriter.WriteElementString("OptionSetDisplayName", "UNDEFINED");

                                   // Writes the TrueOption
                                   metadataWriter.WriteStartElement("TrueOption");
                                   metadataWriter.WriteElementString("OptionValue", optionSetMetadata.TrueOption.Value.ToString());
                                   metadataWriter.WriteElementString("OptionDescription", optionSetMetadata.TrueOption.Label.UserLocalizedLabel.Label.ToString());
                                   metadataWriter.WriteEndElement();
                                   // Writes the FalseOption
                                   metadataWriter.WriteStartElement("FalseOption");
                                   metadataWriter.WriteElementString("OptionValue", optionSetMetadata.FalseOption.Value.ToString());
                                   metadataWriter.WriteElementString("OptionDescription", optionSetMetadata.FalseOption.Label.UserLocalizedLabel.Label.ToString());
                                   metadataWriter.WriteEndElement();

                                   // End OptionSet Node
                                   metadataWriter.WriteEndElement();
                               }
                           }
                       }
                   }

                   // End Metadata Xml Node
                   metadataWriter.WriteEndElement();
                   metadataWriter.WriteEndDocument();

                   // Close xml writer.
                   metadataWriter.Close();
               }


               #endregion How to dump option set info



               Console.WriteLine("Done.");

// </snippetdumpoptionsetinfo1>