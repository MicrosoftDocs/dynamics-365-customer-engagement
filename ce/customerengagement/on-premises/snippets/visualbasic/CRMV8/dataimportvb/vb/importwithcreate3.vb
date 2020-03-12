' <snippetimportwithcreate3>


 ' Retrieve the first two distinct values for column 1 from the parse table.
 ' NOTE: You must create the parse table first using the ParseImport message.
 ' The parse table is not accessible after ImportRecordsImportResponse is called.
 Dim distinctValuesRequest As New GetDistinctValuesImportFileRequest() With
     {
         .columnNumber = 1,
         .ImportFileId = importFileId,
         .pageNumber = 1,
         .recordsPerPage = 2
     }
 Dim distinctValuesResponse As GetDistinctValuesImportFileResponse =
     CType(_serviceProxy.Execute(distinctValuesRequest), 
         GetDistinctValuesImportFileResponse)

 ' Output the distinct values.  In this case: (column 1, row 1) and (column 1, row 2).
 Dim cellNum As Integer = 1
 For Each cellValue As String In distinctValuesResponse.Values
     Console.WriteLine("(1, " &amp; cellNum.ToString() &amp; "): " &amp; cellValue)
     Console.WriteLine(cellValue)
     cellNum += 1
 Next cellValue

' </snippetimportwithcreate3>