' <snippetimportwithcreate1>


 ' Retrieve the header columns used in the import file.
 Dim headerColumnsRequest As New GetHeaderColumnsImportFileRequest() With
     {.ImportFileId = importFileId}
 Dim headerColumnsResponse As GetHeaderColumnsImportFileResponse =
     CType(_serviceProxy.Execute(headerColumnsRequest), 
         GetHeaderColumnsImportFileResponse)

 ' Output the header columns.
 Dim columnNum As Integer = 1
 For Each headerName As String In headerColumnsResponse.Columns
     Console.WriteLine("Column[" &amp; columnNum.ToString() &amp; "] = " &amp; headerName)
     columnNum += 1
 Next headerName

' </snippetimportwithcreate1>