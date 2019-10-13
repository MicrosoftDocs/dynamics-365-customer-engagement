// <snippetdumpsdkmessagetofilede2>


 // Write out SDK messages to an XML file.
 // Create an instance of StreamWriter to write text to a file.
 // The using statement also closes the StreamWriter.

 String filename = "sdkmessages.xml";
 using (StreamWriter sw = new StreamWriter(filename))
 {
     // Create Xml Writer.
     XmlTextWriter metadataWriter = new XmlTextWriter(sw);

     // Start Xml File.
     metadataWriter.WriteStartDocument();

     // Metadata Xml Node.
     metadataWriter.WriteStartElement("Messages");

     for (int j = 0; j < sdkMessages.Entities.Count; j++)
     {

         Entity currentRecord = sdkMessages[j];

         metadataWriter.WriteStartElement("Message");

         // Write the message information.
         metadataWriter.WriteElementString("message-name",
             (String)currentRecord.Attributes["name"]);
         metadataWriter.WriteElementString("categoryname",
             (String)currentRecord.Attributes["categoryname"]);
         if ((bool)currentRecord.Attributes["isprivate"])
             metadataWriter.WriteElementString("isprivate", "Yes");
         metadataWriter.WriteElementString("message-availability",
             currentRecord.Attributes["availability"].ToString());
         if ((bool)currentRecord.Attributes["expand"])
             metadataWriter.WriteElementString("expand", "Yes");
         if ((bool)currentRecord.Attributes["template"])
             metadataWriter.WriteElementString("template", "Yes");


         #region filters

         // Retrieve all SDK Message filter records for that entity.
         QueryByAttribute sdkMessageFilterQuery = new QueryByAttribute
         {
             EntityName = "sdkmessagefilter",
             ColumnSet = new ColumnSet(
                 "iscustomprocessingstepallowed", "availability",
                 "primaryobjecttypecode", "secondaryobjecttypecode"),
         };
         sdkMessageFilterQuery.AddAttributeValue("sdkmessageid",
             currentRecord.Attributes["sdkmessageid"]);
         EntityCollection sdkFilters = _service.RetrieveMultiple(
             sdkMessageFilterQuery);
         metadataWriter.WriteStartElement("Filters");

         for (int i = 0; i < sdkFilters.Entities.Count; i++)
         {

             Entity currentFilter = sdkFilters[i];

             metadataWriter.WriteStartElement("Filter");

             // Write the message information.
             metadataWriter.WriteElementString("filter-availability",
                 currentFilter.Attributes["availability"].ToString());
             metadataWriter.WriteElementString("primaryobjecttypecode",
                 currentFilter.Attributes["primaryobjecttypecode"].ToString());
             metadataWriter.WriteElementString("secondaryobjecttypecode",
                 currentFilter.Attributes["secondaryobjecttypecode"].ToString());
             metadataWriter.WriteEndElement();

         }
         metadataWriter.WriteEndElement();


         #endregion filters

         metadataWriter.WriteEndElement();
     }


     // End Metadata Xml Node
     metadataWriter.WriteEndElement();
     metadataWriter.WriteEndDocument();

     // Close xml writer.
     metadataWriter.Close();
 }

// </snippetdumpsdkmessagetofilede2>