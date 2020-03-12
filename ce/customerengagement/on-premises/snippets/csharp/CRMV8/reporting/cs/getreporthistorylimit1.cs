// <snippetgetreporthistorylimit1>



 // Query for an existing report: Account Overview. This is a default report in Microsoft Dynamics CRM.				    
 QueryByAttribute reportQuery = new QueryByAttribute(Report.EntityLogicalName);
 reportQuery.AddAttributeValue("name", "Account Overview");
 reportQuery.ColumnSet = new ColumnSet("reportid");

 // Get the report.
 EntityCollection retrieveReports = _serviceProxy.RetrieveMultiple(reportQuery);

 // Convert retrieved Entity to a report
 Report retrievedReport = (Report)retrieveReports.Entities[0];
 Console.WriteLine("Retrieved the 'Account Overview' report.");

 // Use the Download Report Definition message.
 GetReportHistoryLimitRequest reportHistoryRequest = new GetReportHistoryLimitRequest
 {
     ReportId = retrievedReport.ReportId.Value
 };

 GetReportHistoryLimitResponse reportHistoryResponse = (GetReportHistoryLimitResponse)_serviceProxy.Execute(reportHistoryRequest);

 // Access the history limit data
 int historyLimit = reportHistoryResponse.HistoryLimit;

 Console.WriteLine("The report history limit is {0}.", historyLimit);

// </snippetgetreporthistorylimit1>