// <snippetimportwebresources2>


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

// </snippetimportwebresources2>