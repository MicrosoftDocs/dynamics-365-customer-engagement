// <snippetimportwebresources1>



 //Read the descriptive data from the XML file
 XDocument xmlDoc = XDocument.Load("../../ImportJob.xml");

 //Create a collection of anonymous type references to each of the Web Resources
 var webResources = from webResource in xmlDoc.Descendants("webResource")
                    select new
                    {
                        path = webResource.Element("path").Value,
                        displayName = webResource.Element("displayName").Value,
                        description = webResource.Element("description").Value,
                        name = webResource.Element("name").Value,
                        type = webResource.Element("type").Value
                    };

 // Loop through the collection creating Web Resources
 int counter = 0;
 foreach (var webResource in webResources)
 {
     //Set the Web Resource properties
     WebResource wr = new WebResource
     {
         Content = getEncodedFileContents(@"../../" + webResource.path),
         DisplayName = webResource.displayName,
         Description = webResource.description,
         Name = _customizationPrefix + webResource.name,
         LogicalName = WebResource.EntityLogicalName,
         WebResourceType = new OptionSetValue(Int32.Parse(webResource.type))
     };

     // Using CreateRequest because we want to add an optional parameter
     CreateRequest cr = new CreateRequest
     {
         Target = wr
     };
     //Set the SolutionUniqueName optional parameter so the Web Resources will be
     // created in the context of a specific solution.
     cr.Parameters.Add("SolutionUniqueName", _ImportWebResourcesSolutionUniqueName);

     CreateResponse cresp = (CreateResponse)_serviceProxy.Execute(cr);
     // Capture the id values for the Web Resources so the sample can delete them.
     _webResourceIds[counter] = cresp.id;
     counter++;
     Console.WriteLine("Created Web Resource: {0}", webResource.displayName);
 }

// </snippetimportwebresources1>