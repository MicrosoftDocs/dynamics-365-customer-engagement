// <snippetdumppicklistinfo2>


               RetrieveAllEntitiesRequest request = new RetrieveAllEntitiesRequest()
               {
                   EntityFilters = EntityFilters.Attributes,
                   RetrieveAsIfPublished = true
               };

               // Retrieve the MetaData.
               RetrieveAllEntitiesResponse response = (RetrieveAllEntitiesResponse)_serviceProxy.Execute(request);
               
               // Create an instance of StreamWriter to write text to a file.
               // The using statement also closes the StreamWriter.
 // To view this file, right click the file and choose open with Excel. 
 // Excel will figure out the schema and display the information in columns.

               String filename = String.Concat("AttributePicklistValues.xml");
               using (StreamWriter sw = new StreamWriter(filename))
               {
                   // Create Xml Writer.
                   XmlTextWriter metadataWriter = new XmlTextWriter(sw);

                   // Start Xml File.
                   metadataWriter.WriteStartDocument();

                   // Metadata Xml Node.
                   metadataWriter.WriteStartElement("Metadata");

                   foreach (EntityMetadata currentEntity in response.EntityMetadata)
                   {
                       
                       if (currentEntity.IsIntersect.Value == false)
                       {
                           // Start Entity Node
                           metadataWriter.WriteStartElement("Entity");

                           // Write the Entity's Information.
                           metadataWriter.WriteElementString("EntitySchemaName", currentEntity.SchemaName);
                           if (currentEntity.IsCustomizable.Value == true)
                               metadataWriter.WriteElementString("IsCustomizable", "yes");
                           else
                               metadataWriter.WriteElementString("IsCustomizable", "no");

                           #region Attributes

                           // Write Entity's Attributes.
                           metadataWriter.WriteStartElement("Attributes");

                           foreach (AttributeMetadata currentAttribute in currentEntity.Attributes)
                           {
                               // Only write out main attributes.
                               if (currentAttribute.AttributeOf == null)
                               {

                                   // Start Attribute Node
                                   metadataWriter.WriteStartElement("Attribute");

                                   // Write Attribute's information.
                                   metadataWriter.WriteElementString("SchemaName", currentAttribute.SchemaName);
                                   metadataWriter.WriteElementString("Type", currentAttribute.AttributeType.Value.ToString());

                                   if (currentAttribute.GetType() == typeof(PicklistAttributeMetadata))
                                   {
                                       PicklistAttributeMetadata optionMetadata = (PicklistAttributeMetadata)currentAttribute;
                                       // Writes the picklist's options
                                       metadataWriter.WriteStartElement("Options");

                                       // Writes the attributes of each picklist option
                                       for (int c = 0; c < optionMetadata.OptionSet.Options.Count; c++)
                                       {
                                           metadataWriter.WriteStartElement("Option");
                                           metadataWriter.WriteElementString("OptionValue", optionMetadata.OptionSet.Options[c].Value.Value.ToString());
                                           metadataWriter.WriteElementString("OptionDescription", optionMetadata.OptionSet.Options[c].Label.UserLocalizedLabel.Label.ToString());
                                           metadataWriter.WriteEndElement();
                                       }

                                       metadataWriter.WriteEndElement();

                                   }
                                   else if (currentAttribute.GetType() == typeof(StateAttributeMetadata))
                                   {
                                       StateAttributeMetadata optionMetadata = (StateAttributeMetadata)currentAttribute;
                                       // Writes the picklist's options
                                       metadataWriter.WriteStartElement("Options");

                                       // Writes the attributes of each picklist option
                                       for (int c = 0; c < optionMetadata.OptionSet.Options.Count; c++)
                                       {
                                           metadataWriter.WriteStartElement("Option");
                                           metadataWriter.WriteElementString("OptionValue", optionMetadata.OptionSet.Options[c].Value.Value.ToString());
                                           metadataWriter.WriteElementString("OptionDescription", optionMetadata.OptionSet.Options[c].Label.UserLocalizedLabel.Label.ToString());
                                           metadataWriter.WriteEndElement();
                                       }

                                       metadataWriter.WriteEndElement();
                                   }
                                   else if (currentAttribute.GetType() == typeof(StatusAttributeMetadata))
                                   {
                                       StatusAttributeMetadata optionMetadata = (StatusAttributeMetadata)currentAttribute;
                                       // Writes the picklist's options
                                       metadataWriter.WriteStartElement("Options");

                                       // Writes the attributes of each picklist option
                                       for (int c = 0; c < optionMetadata.OptionSet.Options.Count; c++)
                                       {
                                           metadataWriter.WriteStartElement("Option");
                                           metadataWriter.WriteElementString("OptionValue", optionMetadata.OptionSet.Options[c].Value.Value.ToString());
                                           metadataWriter.WriteElementString("OptionDescription", optionMetadata.OptionSet.Options[c].Label.UserLocalizedLabel.Label.ToString());
                                           if (optionMetadata.OptionSet.Options[c] is StatusOptionMetadata)
                                               metadataWriter.WriteElementString("RelatedToState", ((StatusOptionMetadata)optionMetadata.OptionSet.Options[c]).State.ToString());
                                           metadataWriter.WriteEndElement();
                                       }

                                       metadataWriter.WriteEndElement();
                                   }

                                   // End Attribute Node
                                   metadataWriter.WriteEndElement();
                               }
                           }
                           // End Attributes Node
                           metadataWriter.WriteEndElement();

                           #endregion

                           // End Entity Node
                           metadataWriter.WriteEndElement();
                       }
                   }

                   // End Metadata Xml Node
                   metadataWriter.WriteEndElement();
                   metadataWriter.WriteEndDocument();

                   // Close xml writer.
                   metadataWriter.Close();
               }

// </snippetdumppicklistinfo2>