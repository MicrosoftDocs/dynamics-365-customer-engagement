// <snippetuploadanddownloadattachment1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     #region Create and Upload annotation attachment

     // Instantiate an Annotation object.
     // See the Entity Metadata topic in the SDK documentation to determine
     // which attributes must be set for each entity.
     Annotation setupAnnotation = new Annotation()
     {
         Subject = "Example Annotation",
         FileName = "ExampleAnnotationAttachment.txt",
         DocumentBody = Convert.ToBase64String(
             new UnicodeEncoding().GetBytes("Sample Annotation Text")),
         MimeType = "text/plain"
     };

     // Create the Annotation object.
     _annotationId = _serviceProxy.Create(setupAnnotation);

     Console.Write("{0} created with an attachment", setupAnnotation.Subject);

     #endregion Create and Upload annotation attachment

     #region Download attachment from annotation record

     // Define columns to retrieve from the annotation record.
     ColumnSet cols = new ColumnSet("filename", "documentbody");
    

     // Retrieve the annotation record.
     Annotation retrievedAnnotation = 
         (Annotation)_serviceProxy.Retrieve("annotation", _annotationId, cols);
     Console.WriteLine(", and retrieved.");
     _fileName = retrievedAnnotation.FileName;

     // Download the attachment in the current execution folder.
     using (FileStream fileStream = new FileStream(retrievedAnnotation.FileName, FileMode.OpenOrCreate))
     {
         byte[] fileContent = Convert.FromBase64String(retrievedAnnotation.DocumentBody);
         fileStream.Write(fileContent, 0, fileContent.Length);
     }

     Console.WriteLine("Attachment downloaded.");

     #endregion Download attachment from annotation record

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetuploadanddownloadattachment1>