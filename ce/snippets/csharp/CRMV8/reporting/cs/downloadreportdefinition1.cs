// <snippetdownloadreportdefinition1>



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
	    DownloadReportDefinitionRequest rdlRequest = new DownloadReportDefinitionRequest
	    {
                     ReportId = retrievedReport.ReportId.Value
                 };

	    DownloadReportDefinitionResponse rdlResponse = (DownloadReportDefinitionResponse)_serviceProxy.Execute(rdlRequest);

                 // Get the current directory path.
                 _currentDirectoryPath = Directory.GetCurrentDirectory();

	    // Access the xml data and save to disk
	    XmlTextWriter reportDefinitionFile = new XmlTextWriter( _currentDirectoryPath + "\\NewReport.rdl", System.Text.Encoding.UTF8);
	    reportDefinitionFile.WriteRaw(rdlResponse.BodyText);
	    reportDefinitionFile.Close();

                 if (File.Exists(_currentDirectoryPath + "\\NewReport.rdl"))
	    {
                     Console.WriteLine("Downloaded the report definition (NewReport.rdl) to '{0}'.", _currentDirectoryPath.ToString());
	    }

// </snippetdownloadreportdefinition1>