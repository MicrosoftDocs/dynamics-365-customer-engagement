// <snippetimportwithcreate1>


 // Retrieve the header columns used in the import file.
 GetHeaderColumnsImportFileRequest headerColumnsRequest = new GetHeaderColumnsImportFileRequest()
 {
     ImportFileId = importFileId
 };
 GetHeaderColumnsImportFileResponse headerColumnsResponse =
     (GetHeaderColumnsImportFileResponse)_serviceProxy.Execute(headerColumnsRequest);

 // Output the header columns.
 int columnNum = 1;
 foreach (string headerName in headerColumnsResponse.Columns)
 {
     Console.WriteLine("Column[" + columnNum.ToString() + "] = " + headerName);
     columnNum++;
 }

// </snippetimportwithcreate1>