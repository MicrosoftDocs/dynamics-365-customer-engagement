// <snippetdumprelationshipinfo1>


       RetrieveAllEntitiesRequest request = new RetrieveAllEntitiesRequest()
       {
           EntityFilters = EntityFilters.Relationships,
           RetrieveAsIfPublished = true
       };

       // Retrieve the MetaData.
       RetrieveAllEntitiesResponse response = (RetrieveAllEntitiesResponse)_serviceProxy.Execute(request);
       

       // Create an instance of StreamWriter to write text to a file.
       // The using statement also closes the StreamWriter.
 // To view this file, right click the file and choose open with Excel. 
 // Excel will figure out the schema and display the information in columns.

       String filename = String.Concat("RelationshipInfo.xml");
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

                   // Start OneToManyRelationships Node
                   metadataWriter.WriteStartElement("OneToManyRelationships");

                   foreach (OneToManyRelationshipMetadata currentRelationship in currentEntity.OneToManyRelationships)
                   {
                       // Start  Node
                       metadataWriter.WriteStartElement("Relationship");

                       metadataWriter.WriteElementString("OtoM_SchemaName", currentRelationship.SchemaName);
                       metadataWriter.WriteElementString("OtoM_ReferencingEntity", currentRelationship.ReferencingEntity);
                       metadataWriter.WriteElementString("OtoM_ReferencedEntity", currentRelationship.ReferencedEntity);
                       // End  Node
                       metadataWriter.WriteEndElement();

                   }

                   // End OneToManyRelationships Node
                   metadataWriter.WriteEndElement();

                   // Start ManyToManyRelationships Node
                   metadataWriter.WriteStartElement("ManyToManyRelationships");


                   foreach (ManyToManyRelationshipMetadata currentRelationship in currentEntity.ManyToManyRelationships)
                   {
                       // Start  Node
                       metadataWriter.WriteStartElement("Relationship");
                       
                       metadataWriter.WriteElementString("MtoM_SchemaName", currentRelationship.SchemaName);
                       metadataWriter.WriteElementString("MtoM_Entity1", currentRelationship.Entity1LogicalName);
                       metadataWriter.WriteElementString("MtoM_Entity2", currentRelationship.Entity2LogicalName);
                       metadataWriter.WriteElementString("IntersectEntity", currentRelationship.IntersectEntityName);
                       // End  Node
                       metadataWriter.WriteEndElement();

                   }

                   // End ManyToManyRelationships Node
                   metadataWriter.WriteEndElement();

                   // Start ManyToOneRelationships Node
                   metadataWriter.WriteStartElement("ManyToOneRelationships");


                   foreach (OneToManyRelationshipMetadata currentRelationship in currentEntity.ManyToOneRelationships)
                   {
                       // Start  Node
                       metadataWriter.WriteStartElement("Relationship");

                       metadataWriter.WriteElementString("MtoO_SchemaName", currentRelationship.SchemaName);
                       metadataWriter.WriteElementString("MtoO_ReferencingEntity", currentRelationship.ReferencingEntity);
                       metadataWriter.WriteElementString("MtoO_ReferencedEntity", currentRelationship.ReferencedEntity);
                       // End  Node
                       metadataWriter.WriteEndElement();

                   }

                   // End ManyToOneRelationships Node
                   metadataWriter.WriteEndElement();

                   // End Relationships Node
                   // metadataWriter.WriteEndElement();



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

// </snippetdumprelationshipinfo1>