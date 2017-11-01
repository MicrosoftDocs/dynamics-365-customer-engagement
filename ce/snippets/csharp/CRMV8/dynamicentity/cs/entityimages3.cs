// <snippetentityimages3>


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

// </snippetentityimages3>