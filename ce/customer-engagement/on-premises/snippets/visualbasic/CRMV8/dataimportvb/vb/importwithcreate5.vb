' <snippetimportwithcreate5>


 ' Transform the import.
 Dim transformImportRequest As New TransformImportRequest() With
     {.ImportId = importId}
 Dim transformImportResponse As TransformImportResponse =
     CType(_serviceProxy.Execute(transformImportRequest), TransformImportResponse)
 Console.WriteLine("Waiting for Transform async job to complete")

' </snippetimportwithcreate5>