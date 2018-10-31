' <snippetgetreporthistorylimit1>



 ' Query for an existing report: Account Overview. This is a default report in Microsoft Dynamics CRM.                    
 Dim reportQuery As New QueryByAttribute(Report.EntityLogicalName)
 reportQuery.AddAttributeValue("name", "Account Overview")
 reportQuery.ColumnSet = New ColumnSet("reportid")

 ' Get the report.
 Dim retrieveReports As EntityCollection = _serviceProxy.RetrieveMultiple(reportQuery)

 ' Convert retrieved Entity to a report
 Dim retrievedReport As Report = CType(retrieveReports.Entities(0), Report)
 Console.WriteLine("Retrieved the 'Account Overview' report.")

 ' Use the Download Report Definition message.
 Dim reportHistoryRequest As GetReportHistoryLimitRequest =
  New GetReportHistoryLimitRequest With {
  .ReportId = retrievedReport.ReportId.Value
 }

 Dim reportHistoryResponse As GetReportHistoryLimitResponse =
  CType(_serviceProxy.Execute(reportHistoryRequest), GetReportHistoryLimitResponse)

 ' Access the history limit data
 Dim historyLimit As Integer = reportHistoryResponse.HistoryLimit

 Console.WriteLine("The report history limit is {0}.", historyLimit)

' </snippetgetreporthistorylimit1>