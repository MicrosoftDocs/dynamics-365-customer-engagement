' <snippetdownloadreportdefinition1>



 ' Query for an existing report: Account Overview. This is a default report in Microsoft Dynamics CRM.                    
 Dim reportQuery As New QueryByAttribute(Report.EntityLogicalName)
 reportQuery.AddAttributeValue("name", "Account Overview")
 reportQuery.ColumnSet = New ColumnSet("reportid")

 ' Get the report.
 Dim retrieveReports As EntityCollection =
  _serviceProxy.RetrieveMultiple(reportQuery)

 ' Convert retrieved Entity to a report
 Dim retrievedReport As Report = CType(retrieveReports.Entities(0), Report)
 Console.WriteLine("Retrieved the 'Account Overview' report.")

 ' Use the Download Report Definition message.
 Dim rdlRequest As DownloadReportDefinitionRequest =
  New DownloadReportDefinitionRequest With {
   .ReportId = retrievedReport.ReportId.Value
  }

 Dim rdlResponse As DownloadReportDefinitionResponse =
  CType(_serviceProxy.Execute(rdlRequest), DownloadReportDefinitionResponse)

 ' Get the current directory path.
 _currentDirectoryPath = Directory.GetCurrentDirectory()

 ' Access the xml data and save to disk
 Dim reportDefinitionFile As New XmlTextWriter(_currentDirectoryPath &amp; "\NewReport.rdl", System.Text.Encoding.UTF8)
 reportDefinitionFile.WriteRaw(rdlResponse.BodyText)
 reportDefinitionFile.Close()

 If File.Exists(_currentDirectoryPath &amp; "\NewReport.rdl") Then
  Console.WriteLine("Downloaded the report definition (NewReport.rdl) to '{0}'.", _currentDirectoryPath.ToString())
 End If

' </snippetdownloadreportdefinition1>