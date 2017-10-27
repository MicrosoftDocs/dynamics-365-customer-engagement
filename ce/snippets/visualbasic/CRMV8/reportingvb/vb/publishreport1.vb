' <snippetpublishreport1>



 ' Define an anonymous type to define the possible values for
 ' report type.
 Dim ReportTypeCode = New With {
      Key .ReportingServicesReport = 1,
      Key .OtherReport = 2,
      Key .LinkedReport = 3}

 ' Define an anonymous type to define the possible values for
 ' report category.
 Dim ReportCategoryCode = New With {
      Key .SalesReports = 1,
      Key .ServiceReports = 2,
      Key .MarketingReports = 3,
      Key .AdministrativeReports = 4}

 ' Define an anonymous type to define the possible values for
 ' report visibility
 Dim ReportVisibilityCode = New With {
      Key .ReportsGrid = 1,
      Key .Form = 2,
      Key .Grid = 3}

 ' Instantiate a report object.
 ' See the Entity Metadata topic in the SDK documentation to determine
 ' which attributes must be set for each entity.

 Dim sampleReport As Report =
  New Report With {
   .Name = "Sample Report",
   .BodyText = File.ReadAllText("SampleReport.rdl"),
   .FileName = "SampleReport.rdl",
   .LanguageCode = 1033,
   .ReportTypeCode = New OptionSetValue(ReportTypeCode.ReportingServicesReport)
  }
 ' Create a report record named Sample Report.
 _reportId = _serviceProxy.Create(sampleReport)


 ' Set the report category.
 Dim sampleReportCategory As ReportCategory =
  New ReportCategory With {
   .ReportId = New EntityReference(Report.EntityLogicalName, _reportId),
   .CategoryCode = New OptionSetValue(ReportCategoryCode.AdministrativeReports)
  }
 _reportCategoryId = _serviceProxy.Create(sampleReportCategory)

 ' Define which entity this report uses.
 Dim reportEntity As ReportEntity =
  New ReportEntity With {
   .ReportId = New EntityReference(Report.EntityLogicalName, _reportId),
   .ObjectTypeCode = Account.EntityLogicalName
  }
 _reportEntityId = _serviceProxy.Create(reportEntity)


 ' Set the report visibility.
 Dim rv As ReportVisibility =
  New ReportVisibility With {
   .ReportId = New EntityReference(Report.EntityLogicalName, _reportId),
   .VisibilityCode = New OptionSetValue(ReportVisibilityCode.Form)
  }
 _reportVisibilityId1 = _serviceProxy.Create(rv)

 rv = New ReportVisibility With {
  .ReportId = New EntityReference(Report.EntityLogicalName, _reportId),
  .VisibilityCode = New OptionSetValue(ReportVisibilityCode.Grid)
 }
 _reportVisibilityId2 = _serviceProxy.Create(rv)

 rv = New ReportVisibility With {
  .ReportId = New EntityReference(Report.EntityLogicalName, _reportId),
  .VisibilityCode = New OptionSetValue(ReportVisibilityCode.ReportsGrid)
 }
 _reportVisibilityId3 = _serviceProxy.Create(rv)

 Console.WriteLine("{0} published in Microsoft Dynamics CRM.", sampleReport.Name)

' </snippetpublishreport1>