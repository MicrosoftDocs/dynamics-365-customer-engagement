// <snippetdumpentityinfo1>


               RetrieveAllEntitiesRequest request = new RetrieveAllEntitiesRequest()
               {
                   EntityFilters = EntityFilters.Entity,
                   RetrieveAsIfPublished = true
               };

               // Retrieve the MetaData.
               RetrieveAllEntitiesResponse response = (RetrieveAllEntitiesResponse)_serviceProxy.Execute(request);
               

               // Create an instance of StreamWriter to write text to a file.
               // The using statement also closes the StreamWriter.
 // To view this file, right click the file and choose open with Excel. 
 // Excel will figure out the schema and display the information in columns.

               String filename = String.Concat("EntityInfo.xml");
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
                           metadataWriter.WriteElementString("OTC", currentEntity.ObjectTypeCode.ToString());
                           metadataWriter.WriteElementString("OwnershipType", currentEntity.OwnershipType.Value.ToString());
                           if (currentEntity.DisplayName.UserLocalizedLabel != null)
                               metadataWriter.WriteElementString("DisplayName", currentEntity.DisplayName.UserLocalizedLabel.Label);
                           if (currentEntity.DisplayCollectionName.UserLocalizedLabel != null)
                               metadataWriter.WriteElementString("DisplayCollectionName", currentEntity.DisplayCollectionName.UserLocalizedLabel.Label);
                           metadataWriter.WriteElementString("IntroducedVersion", currentEntity.IntroducedVersion.ToString());
                           metadataWriter.WriteElementString("AutoRouteToOwnerQueue", currentEntity.AutoRouteToOwnerQueue.ToString());
                           metadataWriter.WriteElementString("CanBeInManyToMany", currentEntity.CanBeInManyToMany.Value.ToString());
                           metadataWriter.WriteElementString("CanBePrimaryEntityInRelationship", currentEntity.CanBePrimaryEntityInRelationship.Value.ToString());
                           metadataWriter.WriteElementString("CanBeRelatedEntityInRelationship", currentEntity.CanBeRelatedEntityInRelationship.Value.ToString());
                           metadataWriter.WriteElementString("CanCreateAttributes", currentEntity.CanCreateAttributes.Value.ToString());
                           metadataWriter.WriteElementString("CanCreateCharts", currentEntity.CanCreateCharts.Value.ToString());
                           metadataWriter.WriteElementString("CanCreateForms", currentEntity.CanCreateForms.Value.ToString());
                           metadataWriter.WriteElementString("CanCreateViews", currentEntity.CanCreateViews.Value.ToString());
                           metadataWriter.WriteElementString("CanModifyAdditionalSettings", currentEntity.CanModifyAdditionalSettings.Value.ToString());
                           metadataWriter.WriteElementString("CanTriggerWorkflow", currentEntity.CanTriggerWorkflow.Value.ToString());

                           metadataWriter.WriteElementString("IsActivity", currentEntity.IsActivity.Value.ToString());
                           //metadataWriter.WriteElementString("ActivityTypeMask", currentEntity.ActivityTypeMask.ToString());

                           metadataWriter.WriteElementString("IsActivityParty", currentEntity.IsActivityParty.Value.ToString());

                           metadataWriter.WriteElementString("IsAuditEnabled", currentEntity.IsAuditEnabled.Value.ToString());
                           metadataWriter.WriteElementString("IsAvailableOffline", currentEntity.IsAvailableOffline.ToString());
                           metadataWriter.WriteElementString("IsChildEntity", currentEntity.IsChildEntity.ToString());
                           metadataWriter.WriteElementString("IsConnectionsEnabled", currentEntity.IsConnectionsEnabled.ManagedPropertyLogicalName.ToString());
                           metadataWriter.WriteElementString("IsCustomEntity", currentEntity.IsCustomEntity.Value.ToString());
                           metadataWriter.WriteElementString("IsCustomizable", currentEntity.IsCustomizable.Value.ToString());

                           metadataWriter.WriteElementString("IsDocumentManagementEnabled", currentEntity.IsDocumentManagementEnabled.Value.ToString());
                           metadataWriter.WriteElementString("IsDuplicateDetectionEnabled", currentEntity.IsDuplicateDetectionEnabled.Value.ToString());
                           if (currentEntity.IsEnabledForCharts != null)
                               metadataWriter.WriteElementString("IsEnabledForCharts", currentEntity.IsEnabledForCharts.Value.ToString());
                           metadataWriter.WriteElementString("IsImportable", currentEntity.IsImportable.Value.ToString());
                           metadataWriter.WriteElementString("IsIntersect", currentEntity.IsIntersect.Value.ToString());

                           metadataWriter.WriteElementString("IsMailMergeEnabled", currentEntity.IsMailMergeEnabled.Value.ToString());
                           metadataWriter.WriteElementString("IsManaged", currentEntity.IsManaged.Value.ToString());
                           metadataWriter.WriteElementString("IsMappable", currentEntity.IsMappable.Value.ToString());

                           metadataWriter.WriteElementString("IsReadingPaneEnabled", currentEntity.IsReadingPaneEnabled.Value.ToString());
                           metadataWriter.WriteElementString("IsRenameable", currentEntity.IsRenameable.Value.ToString()); 
                           metadataWriter.WriteElementString("IsValidForAdvancedFind", currentEntity.IsValidForAdvancedFind.Value.ToString());
                           metadataWriter.WriteElementString("IsValidForQueue", currentEntity.IsValidForQueue.Value.ToString());
                           metadataWriter.WriteElementString("IsVisibleInMobile", currentEntity.IsVisibleInMobile.Value.ToString());

                           metadataWriter.WriteElementString("PrimaryIdAttribute", currentEntity.PrimaryIdAttribute);
                           metadataWriter.WriteElementString("PrimaryNameAttribute", currentEntity.PrimaryNameAttribute);
                           metadataWriter.WriteElementString("ReportViewName", currentEntity.ReportViewName);
                           metadataWriter.WriteElementString("RecurrenceBaseEntityLogicalName", currentEntity.RecurrenceBaseEntityLogicalName);
                           if (currentEntity.Description.UserLocalizedLabel != null)
                               metadataWriter.WriteElementString("Description", currentEntity.Description.UserLocalizedLabel.Label);



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




              Console.WriteLine("Done.");

// </snippetdumpentityinfo1>