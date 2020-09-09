' <snippetimportwithcreate2>


 ' Parse the import file.
 Dim parseImportRequest As New ParseImportRequest() With {.ImportId = importId}
 Dim parseImportResponse As ParseImportResponse =
     CType(_serviceProxy.Execute(parseImportRequest), ParseImportResponse)
 Console.WriteLine("Waiting for Parse async job to complete")

' </snippetimportwithcreate2>