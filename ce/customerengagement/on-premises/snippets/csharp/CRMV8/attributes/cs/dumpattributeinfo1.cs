// <snippetdumpattributeinfo1>


               #region How to dump attribute info
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
               String filename = String.Concat("AllAttributeDesc.xml");
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

                       //if (currentEntity.IsIntersect.Value == false)
                       if (true)
                       {
                           // Start Entity Node
                           metadataWriter.WriteStartElement("Entity");

                           // Write the Entity's Information.
                           metadataWriter.WriteElementString("EntitySchemaName", currentEntity.SchemaName);
                           if (currentEntity.IsCustomizable.Value == true)
                               metadataWriter.WriteElementString("IsCustomizable", "yes");
                           else
                               metadataWriter.WriteElementString("IsCustomizable", "no");
                           if (currentEntity.IsIntersect.Value == true)
                               metadataWriter.WriteElementString("IsIntersect", "yes");
                           else
                               metadataWriter.WriteElementString("IsIntersect", "no");



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
                                   metadataWriter.WriteElementString("LogicalName", currentAttribute.LogicalName);
                                   // Write the Description if it is set.
                                   if (currentAttribute.Description.UserLocalizedLabel != null)
                                   {
                                       metadataWriter.WriteElementString("Description", currentAttribute.Description.UserLocalizedLabel.Label.ToString());
                                   }

                                   metadataWriter.WriteElementString("Type", currentAttribute.AttributeType.Value.ToString());
                                   if (currentAttribute.DisplayName.UserLocalizedLabel != null)
                                       metadataWriter.WriteElementString("DisplayName", currentAttribute.DisplayName.UserLocalizedLabel.Label.ToString());
                                   if (currentAttribute.SchemaName != null)
                                       metadataWriter.WriteElementString("SchemaName", currentAttribute.SchemaName.ToString());
                                   if (currentAttribute.IntroducedVersion != null)
                                       metadataWriter.WriteElementString("IntroducedVersion", currentAttribute.IntroducedVersion.ToString());
                                   if (currentAttribute.DeprecatedVersion != null)
                                       metadataWriter.WriteElementString("DeprecatedVersion", currentAttribute.DeprecatedVersion.ToString());
                                   if (currentAttribute.IsCustomAttribute != null)
                                       metadataWriter.WriteElementString("IsCustomAttribute", currentAttribute.IsCustomAttribute.Value.ToString());
                                   if (currentAttribute.IsCustomizable != null)
                                       metadataWriter.WriteElementString("IsCustomizable", currentAttribute.IsCustomizable.Value.ToString());
                                   if (currentAttribute.RequiredLevel != null)
                                       metadataWriter.WriteElementString("RequiredLevel", currentAttribute.RequiredLevel.Value.ToString());
                                   if (currentAttribute.IsValidForCreate != null)
                                       metadataWriter.WriteElementString("IsValidForCreate", currentAttribute.IsValidForCreate.Value.ToString());
                                   if (currentAttribute.IsValidForRead != null)
                                       metadataWriter.WriteElementString("IsValidForRead", currentAttribute.IsValidForRead.Value.ToString());
                                   if (currentAttribute.IsValidForUpdate != null)
                                       metadataWriter.WriteElementString("IsValidForUpdate", currentAttribute.IsValidForUpdate.Value.ToString());
                                   if (currentAttribute.CanBeSecuredForCreate != null)
                                       metadataWriter.WriteElementString("CanBeSecuredForCreate", currentAttribute.CanBeSecuredForCreate.Value.ToString());
                                   if (currentAttribute.CanBeSecuredForRead != null)
                                       metadataWriter.WriteElementString("CanBeSecuredForRead", currentAttribute.CanBeSecuredForRead.Value.ToString());
                                   if (currentAttribute.CanBeSecuredForUpdate != null)
                                       metadataWriter.WriteElementString("CanBeSecuredForUpdate", currentAttribute.CanBeSecuredForUpdate.Value.ToString());
                                   if (currentAttribute.IsAuditEnabled != null)
                                       metadataWriter.WriteElementString("IsAuditEnabled", currentAttribute.IsAuditEnabled.Value.ToString());
                                   if (currentAttribute.IsManaged != null)
                                       metadataWriter.WriteElementString("IsManaged", currentAttribute.IsManaged.Value.ToString());
                                   if (currentAttribute.IsPrimaryId != null)
                                       metadataWriter.WriteElementString("IsPrimaryId", currentAttribute.IsPrimaryId.Value.ToString());
                                   if (currentAttribute.IsPrimaryName != null) 
                                       metadataWriter.WriteElementString("IsPrimaryName", currentAttribute.IsPrimaryName.Value.ToString());
                                   if (currentAttribute.IsRenameable != null)
                                       metadataWriter.WriteElementString("IsRenameable", currentAttribute.IsRenameable.Value.ToString());
                                   if (currentAttribute.IsSecured != null)
                                       metadataWriter.WriteElementString("IsSecured", currentAttribute.IsSecured.Value.ToString());
                                   if (currentAttribute.IsValidForAdvancedFind != null) 
                                       metadataWriter.WriteElementString("IsValidForAdvancedFind", currentAttribute.IsValidForAdvancedFind.Value.ToString());

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

               #endregion How to dump attribute info



              Console.WriteLine("Done.");

// </snippetdumpattributeinfo1>