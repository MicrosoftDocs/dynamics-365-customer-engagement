' <snippetimportwithcreate4>


 ' Retrieve data from the parse table.
 ' NOTE: You must create the parse table first using the ParseImport message.
 ' The parse table is not accessible after ImportRecordsImportResponse is called.
 Dim parsedDataRequest As New RetrieveParsedDataImportFileRequest() With
     {
         .ImportFileId = importFileId,
         .PagingInfo = New PagingInfo() With
                       {
                           .Count = 2,
                           .PageNumber = 1,
                           .PagingCookie = "1"
                       }
     }
 ' Specify the number of entity instances returned per page.
 ' Specify the number of pages returned from the query.
 ' Specify a total number of entity instances returned.

 Dim parsedDataResponse As RetrieveParsedDataImportFileResponse =
     CType(_serviceProxy.Execute(parsedDataRequest), 
         RetrieveParsedDataImportFileResponse)

 ' Output the first two rows retrieved.
 Dim rowCount As Integer = 1
 For Each rows As String() In parsedDataResponse.Values
     Dim colCount As Integer = 1
     For Each column As String In rows
         Console.WriteLine("(" &amp; rowCount.ToString() &amp; "," _
                           &amp; colCount.ToString() &amp; ") = " &amp; column)
         colCount += 1
     Next column
     rowCount += 1
 Next rows

' </snippetimportwithcreate4>