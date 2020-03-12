// <snippetexportmappingsimportmap>


 // Retrieve the value for validation
 var exportRequest = new ExportMappingsImportMapRequest
 {
     ImportMapId = _newImportMapId.Value,
     ExportIds = true,
 };

 var exportResponse = (ExportMappingsImportMapResponse)_serviceProxy
     .Execute(exportRequest);

 var mappingXml = exportResponse.MappingsXml;

 Console.WriteLine(String.Concat("\nValidating mapping xml for : ", 
     _newImportMapId.Value, ",\nMappingsXml:\n", mappingXml));

// </snippetexportmappingsimportmap>