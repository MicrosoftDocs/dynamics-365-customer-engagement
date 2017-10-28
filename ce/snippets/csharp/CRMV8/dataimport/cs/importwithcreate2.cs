// <snippetimportwithcreate2>


 // Parse the import file.
 ParseImportRequest parseImportRequest = new ParseImportRequest()
 {
     ImportId = importId
 };
 ParseImportResponse parseImportResponse =
     (ParseImportResponse)_serviceProxy.Execute(parseImportRequest);
 Console.WriteLine("Waiting for Parse async job to complete");

// </snippetimportwithcreate2>