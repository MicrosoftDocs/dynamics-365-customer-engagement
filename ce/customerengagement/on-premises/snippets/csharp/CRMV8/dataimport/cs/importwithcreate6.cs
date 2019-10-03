// <snippetimportwithcreate6>


 // Upload the records.
 ImportRecordsImportRequest importRequest = new ImportRecordsImportRequest()
 {
     ImportId = importId
 };
 ImportRecordsImportResponse importResponse =
     (ImportRecordsImportResponse)_serviceProxy.Execute(importRequest);
 Console.WriteLine("Waiting for ImportRecords async job to complete");

// </snippetimportwithcreate6>