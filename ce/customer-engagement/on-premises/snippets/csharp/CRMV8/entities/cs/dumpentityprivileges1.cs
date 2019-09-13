// <snippetdumpentityprivileges1>


               RetrieveAllEntitiesRequest request = new RetrieveAllEntitiesRequest()
               {
                   EntityFilters = EntityFilters.Privileges,
                   RetrieveAsIfPublished = true
               };

               // Retrieve the MetaData.
               RetrieveAllEntitiesResponse response = (RetrieveAllEntitiesResponse)_serviceProxy.Execute(request);
               

               // Create an instance of StreamWriter to write text to a file.
               // The using statement also closes the StreamWriter.
 // To view this file, right click the file and choose open with Excel. 
 // Excel will figure out the schema and display the information in columns.

               String filename = String.Concat("EntityPrivileges.xml");
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
                           metadataWriter.WriteElementString("OTC", currentEntity.ObjectTypeCode.ToString());


                           metadataWriter.WriteStartElement("Privileges");

                           foreach (SecurityPrivilegeMetadata privilege in currentEntity.Privileges)
                           {
                               metadataWriter.WriteStartElement("Privilege");
                               metadataWriter.WriteElementString("PrivilegeName", privilege.Name.ToString());
                               metadataWriter.WriteElementString("Id", privilege.PrivilegeId.ToString());
                               metadataWriter.WriteElementString("Type", privilege.PrivilegeType.ToString());
                               metadataWriter.WriteElementString("CanBeBasic", privilege.CanBeBasic.ToString());
                               metadataWriter.WriteElementString("CanBeDeep", privilege.CanBeDeep.ToString());
                               metadataWriter.WriteElementString("CanBeGlobal", privilege.CanBeGlobal.ToString());
                               metadataWriter.WriteElementString("CanBeLocal", privilege.CanBeLocal.ToString());

                               metadataWriter.WriteEndElement();


                           }

                           metadataWriter.WriteEndElement();


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

// </snippetdumpentityprivileges1>