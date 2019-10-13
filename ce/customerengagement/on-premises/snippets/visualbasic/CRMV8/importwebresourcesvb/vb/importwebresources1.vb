' <snippetimportwebresources1>



 'Read the descriptive data from the XML file
 Dim xmlDoc As XDocument = XDocument.Load("../../ImportJob.xml")

 'Create a collection of anonymous type references to each of the Web Resources
 Dim webResources =
     From webResource In xmlDoc.Descendants("webResource") _
     Select New With
            {
                Key .path = webResource.Element("path").Value,
                Key .displayName =
                webResource.Element("displayName").Value,
                Key .description =
                webResource.Element("description").Value,
                Key .name = webResource.Element("name").Value,
                Key .type = webResource.Element("type").Value
            }

 ' Loop through the collection creating Web Resources
 Dim counter As Integer = 0
 For Each awebResource In webResources
     'Set the Web Resource properties
     Dim wr As WebResource =
         New WebResource With
         {
             .Content = getEncodedFileContents("../../" _
                                               &amp; awebResource.path),
             .DisplayName = awebResource.displayName,
             .Description = awebResource.description,
             .Name = _customizationPrefix &amp; awebResource.name,
             .LogicalName = WebResource.EntityLogicalName,
             .WebResourceType =
             New OptionSetValue(Int32.Parse(awebResource.type))
         }

     ' Using CreateRequest because we want to add an optional parameter
     Dim cr As CreateRequest = New CreateRequest With {.Target = wr}
     'Set the SolutionUniqueName optional parameter so the Web Resources will be
     ' created in the context of a specific solution.
     cr.Parameters.Add("SolutionUniqueName",
                       _ImportWebResourcesSolutionUniqueName)

     Dim cresp As CreateResponse = CType(_serviceProxy.Execute(cr), 
         CreateResponse)
     ' Capture the id values for the Web Resources so the sample can delete them.
     _webResourceIds(counter) = cresp.id
     counter += 1
     Console.WriteLine("Created Web Resource: {0}",
                       awebResource.displayName)
 Next awebResource

' </snippetimportwebresources1>