' <snippetimportwithcreate6>


 ' Upload the records.
 Dim importRequest As New ImportRecordsImportRequest() With {.ImportId = importId}
 Dim importResponse As ImportRecordsImportResponse =
     CType(_serviceProxy.Execute(importRequest), ImportRecordsImportResponse)
 Console.WriteLine("Waiting for ImportRecords async job to complete")

' </snippetimportwithcreate6>