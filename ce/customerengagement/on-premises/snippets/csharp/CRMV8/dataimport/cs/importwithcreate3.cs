// <snippetimportwithcreate3>


 // Retrieve the first two distinct values for column 1 from the parse table.
 // NOTE: You must create the parse table first using the ParseImport message.
 // The parse table is not accessible after ImportRecordsImportResponse is called.
 GetDistinctValuesImportFileRequest distinctValuesRequest = new GetDistinctValuesImportFileRequest()
 {
     columnNumber = 1,
     ImportFileId = importFileId,
     pageNumber = 1,
     recordsPerPage = 2,
 };
 GetDistinctValuesImportFileResponse distinctValuesResponse =
     (GetDistinctValuesImportFileResponse)_serviceProxy.Execute(distinctValuesRequest);

 // Output the distinct values.  In this case: (column 1, row 1) and (column 1, row 2).
 int cellNum = 1;
 foreach (string cellValue in distinctValuesResponse.Values)
 {
     Console.WriteLine("(1, " + cellNum.ToString() + "): " + cellValue);
     Console.WriteLine(cellValue);
     cellNum++;
 }

// </snippetimportwithcreate3>