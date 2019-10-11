// <snippetimportmappingsimportmap>


 // Create the import mapping from the XML
 var request = new ImportMappingsImportMapRequest
 {
     MappingsXml = _mappingXml,
     
     ReplaceIds = true,
 };

 Console.WriteLine(String.Concat("\nCreating mapping based on XML:\n", 
     _mappingXml));

 var response = (ImportMappingsImportMapResponse)
     _serviceProxy.Execute(request);

 _newImportMapId = response.ImportMapId;

 Console.WriteLine(String.Concat("\nNew import mapping created: ", 
     _newImportMapId.Value));

// </snippetimportmappingsimportmap>