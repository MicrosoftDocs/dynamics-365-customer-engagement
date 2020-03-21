// <snippetentityimages4>


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

// </snippetentityimages4>