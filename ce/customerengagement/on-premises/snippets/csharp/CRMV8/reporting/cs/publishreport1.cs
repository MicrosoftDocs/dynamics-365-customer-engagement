// <snippetpublishreport1>



 // Define an anonymous type to define the possible values for
 // report type.
 var ReportTypeCode = new
 {
     ReportingServicesReport = 1,
     OtherReport = 2,
     LinkedReport = 3
 };

 // Define an anonymous type to define the possible values for
 // report category.
 var ReportCategoryCode = new
 {
     SalesReports = 1,
     ServiceReports = 2,
     MarketingReports = 3,
     AdministrativeReports = 4
 };

 // Define an anonymous type to define the possible values for
 // report visibility
 var ReportVisibilityCode = new
 {
     ReportsGrid = 1,
     Form = 2,
     Grid = 3,
 };

 // Instantiate a report object.
 // See the Entity Metadata topic in the SDK documentation to determine
 // which attributes must be set for each entity.

 Report sampleReport = new Report
 {
     Name = "Sample Report",
     BodyText = File.ReadAllText("SampleReport.rdl"),
     FileName = "SampleReport.rdl",
     LanguageCode = 1033, // US English
     ReportTypeCode = new OptionSetValue(ReportTypeCode.ReportingServicesReport)
 };
 // Create a report record named Sample Report.
 _reportId = _serviceProxy.Create(sampleReport);


 // Set the report category.
 ReportCategory sampleReportCategory = new ReportCategory
 {
     ReportId = new EntityReference(Report.EntityLogicalName, _reportId),
     CategoryCode = new OptionSetValue(ReportCategoryCode.AdministrativeReports)
 };
 _reportCategoryId = _serviceProxy.Create(sampleReportCategory);

 // Define which entity this report uses.
 ReportEntity reportEntity = new ReportEntity
 {
     ReportId = new EntityReference(Report.EntityLogicalName, _reportId),
     ObjectTypeCode = Account.EntityLogicalName
 };
 _reportEntityId = _serviceProxy.Create(reportEntity);


 // Set the report visibility.
 ReportVisibility rv = new ReportVisibility
 {
     ReportId = new EntityReference(Report.EntityLogicalName, _reportId),
     VisibilityCode = new OptionSetValue(ReportVisibilityCode.Form)
 };
 _reportVisibilityId1 = _serviceProxy.Create(rv);

 rv = new ReportVisibility
 {
     ReportId = new EntityReference(Report.EntityLogicalName, _reportId),
     VisibilityCode = new OptionSetValue(ReportVisibilityCode.Grid)
 };
 _reportVisibilityId2 = _serviceProxy.Create(rv);

 rv = new ReportVisibility
 {
     ReportId = new EntityReference(Report.EntityLogicalName, _reportId),
     VisibilityCode = new OptionSetValue(ReportVisibilityCode.ReportsGrid)
 };
 _reportVisibilityId3 = _serviceProxy.Create(rv);

 Console.WriteLine("{0} published in Microsoft Dynamics CRM.", sampleReport.Name);

// </snippetpublishreport1>