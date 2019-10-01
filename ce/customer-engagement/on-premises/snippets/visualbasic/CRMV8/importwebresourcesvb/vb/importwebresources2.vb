' <snippetimportwebresources2>


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

' </snippetimportwebresources2>