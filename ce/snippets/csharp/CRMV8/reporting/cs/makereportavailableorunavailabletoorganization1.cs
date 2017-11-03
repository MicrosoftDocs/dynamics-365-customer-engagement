// <snippetmakereportavailableorunavailabletoorganization1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     // Call the method to create any data that this sample requires.
     CreateRequiredRecords();

     // Retrieve existing personal report.
     Report existingPersonalReport = 
         (Report)_serviceProxy.Retrieve(Report.EntityLogicalName, 
         _reportId,                         
         new ColumnSet("ispersonal"));

     // Set IsPersonal property to false. 
     existingPersonalReport.IsPersonal = false;

     // Make the report available to the organization.
     _serviceProxy.Update(existingPersonalReport);

     // Retrieve the report and verify that the report is available to the organization
     ColumnSet Cols1 = new ColumnSet("ispersonal");
     Report retrieveAvailableReport = 
         (Report)_serviceProxy.Retrieve(Report.EntityLogicalName, 
         _reportId, Cols1);
     if (retrieveAvailableReport.IsPersonal.Value == false)
     {
         Console.WriteLine("Report is available to the organization.");
     }

     // Now make the retrieved report unavailable to the organization
     retrieveAvailableReport.IsPersonal = true;
     _serviceProxy.Update(retrieveAvailableReport);
     
     // Retrieve the report, and verify that the report is unavailable to the organization
     ColumnSet Cols2 = new ColumnSet("ispersonal");
     Report retrieveUnavailableReport = 
         (Report)_serviceProxy.Retrieve(Report.EntityLogicalName, 
         _reportId, Cols2);
     if (retrieveUnavailableReport.IsPersonal.Value == true)
     {
         Console.WriteLine("Report is unavailable to the organization.");
     }


     DeleteRequiredRecords(promptforDelete);
 }

// </snippetmakereportavailableorunavailabletoorganization1>