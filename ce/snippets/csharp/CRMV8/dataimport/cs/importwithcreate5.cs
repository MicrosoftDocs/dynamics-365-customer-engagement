// <snippetimportwithcreate5>


 // Transform the import
 TransformImportRequest transformImportRequest = new TransformImportRequest()
 {
     ImportId = importId
 };
 TransformImportResponse transformImportResponse =
     (TransformImportResponse)_serviceProxy.Execute(transformImportRequest);
 Console.WriteLine("Waiting for Transform async job to complete");

// </snippetimportwithcreate5>