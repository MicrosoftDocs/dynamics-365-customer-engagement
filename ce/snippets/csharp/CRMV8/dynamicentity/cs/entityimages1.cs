// <snippetentityimages1>


    // Connect to the Organization service. 
    // The using statement assures that the service proxy will be properly disposed.
    using (_serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig))
    {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     Console.WriteLine("Please wait while the custom Image Attribute Demo entity used by this sample is created.");
     //Creates the Image Attribute Demo entity used in this sample
     CreateImageAttributeDemoEntity();

     //Create 5 records using different sized images.
     /*
      
      This sample uses late-binding because the entity was just created and is
      not included in the 'MyOrganizationsCrmSdkTypes.cs' file created by the 
      code generation tool (CrmSvcUtil.exe)
      
     */
     //Use a 144x144 pixel image
     Entity imageEntity1 = new Entity(_customEntityName.ToLower());
     imageEntity1["sample_name"] = "144x144.png";
     imageEntity1["entityimage"] = File.ReadAllBytes("Images\\144x144.png");
     Guid imageEntity1Id = _serviceProxy.Create(imageEntity1);
     ShowEntityFormInBrowser(promptforDelete, "144x144.png", imageEntity1Id);
     
     //Use a 144x400 pixel image
     Entity imageEntity2 = new Entity(_customEntityName.ToLower());
     imageEntity2["sample_name"] = "144x400.png";
     imageEntity2["entityimage"] = File.ReadAllBytes("Images\\144x400.png");
     Guid imageEntity2Id = _serviceProxy.Create(imageEntity2);     
     ShowEntityFormInBrowser(promptforDelete, "144x400.png", imageEntity2Id);
     
     //Use a 400x144 pixel image
     Entity imageEntity3 = new Entity(_customEntityName.ToLower());
     imageEntity3["sample_name"] = "400x144.png";
     imageEntity3["entityimage"] = File.ReadAllBytes("Images\\400x144.png");
     Guid imageEntity3Id = _serviceProxy.Create(imageEntity3);
     ShowEntityFormInBrowser(promptforDelete, "400x144.png", imageEntity3Id);

     //Use a 400x500 pixel image
     Entity imageEntity4 = new Entity(_customEntityName.ToLower());
     imageEntity4["sample_name"] = "400x500.png";
     imageEntity4["entityimage"] = File.ReadAllBytes("Images\\400x500.png");
     Guid imageEntity4Id = _serviceProxy.Create(imageEntity4);
     ShowEntityFormInBrowser(promptforDelete, "400x500.png", imageEntity4Id);

     //Use a 60x80 pixel image
     Entity imageEntity5 = new Entity(_customEntityName.ToLower());
     imageEntity5["sample_name"] = "60x80.png";
     imageEntity5["entityimage"] = File.ReadAllBytes("Images\\60x80.png");
     Guid imageEntity5Id = _serviceProxy.Create(imageEntity5);
     ShowEntityFormInBrowser(promptforDelete, "60x80.png", imageEntity5Id);
     Console.WriteLine();
     //Retrieve and download the binary images
     string binaryImageQuery =
String.Format(@"<fetch mapping='logical'>
  <entity name='{0}'>
    <attribute name='sample_name' />
    <attribute name='entityimage' />
  </entity>
</fetch>",_customEntityName.ToLower());

     EntityCollection binaryImageResults = _serviceProxy.RetrieveMultiple(new FetchExpression(binaryImageQuery));


     Console.WriteLine("Records retrieved and image files saved to: {0}", Directory.GetCurrentDirectory());
     foreach (Entity record in binaryImageResults.Entities)
     {
      String recordName = record["sample_name"] as String;
      String downloadedFileName = String.Format("Downloaded_{0}", recordName);
      byte[] imageBytes = record["entityimage"] as byte[];
      var fs = new BinaryWriter(new FileStream(downloadedFileName, FileMode.Append, FileAccess.Write));
      fs.Write(imageBytes);
      fs.Close();
      Console.WriteLine(downloadedFileName);
     }
     Console.WriteLine();
     //Retrieve and the records with just the url
     string imageUrlQuery =
String.Format(@"<fetch mapping='logical'>
  <entity name='{0}'>
    <attribute name='sample_name' />
    <attribute name='entityimage_url' />
  </entity>
</fetch>", _customEntityName.ToLower());

     EntityCollection imageUrlResults = _serviceProxy.RetrieveMultiple(new FetchExpression(imageUrlQuery));


     Console.WriteLine("These are the relative URLs for the images retrieved:");
     foreach (Entity record in imageUrlResults.Entities)
     {
      String imageUrl = record["entityimage_url"] as String;
      Console.WriteLine(imageUrl);
     }


     DeleteImageAttributeDemoEntity(promptforDelete);
    }

// </snippetentityimages1>