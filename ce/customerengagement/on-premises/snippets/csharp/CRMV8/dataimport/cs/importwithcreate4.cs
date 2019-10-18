// <snippetimportwithcreate4>


 // Retrieve data from the parse table.
 // NOTE: You must create the parse table first using the ParseImport message.
 // The parse table is not accessible after ImportRecordsImportResponse is called.
 RetrieveParsedDataImportFileRequest parsedDataRequest = new RetrieveParsedDataImportFileRequest()
 {
     ImportFileId = importFileId,
     PagingInfo = new PagingInfo()
     {
         // Specify the number of entity instances returned per page.
         Count = 2,
         // Specify the number of pages returned from the query.
         PageNumber = 1,
         // Specify a total number of entity instances returned.
         PagingCookie = "1"
     }
 };

 RetrieveParsedDataImportFileResponse parsedDataResponse =
     (RetrieveParsedDataImportFileResponse)_serviceProxy.Execute(parsedDataRequest);

 // Output the first two rows retrieved.
 int rowCount = 1;
 foreach (string[] rows in parsedDataResponse.Values)
 {
     int colCount = 1;
     foreach (string column in rows)
     {
         Console.WriteLine("(" + rowCount.ToString() + "," + colCount.ToString() + ") = " + column);
         colCount++;
     }
     rowCount++;
 }

// </snippetimportwithcreate4>