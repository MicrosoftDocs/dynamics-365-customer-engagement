' <snippetmakereportavailableorunavailabletoorganization1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     ' Call the method to create any data that this sample requires.
     CreateRequiredRecords()

     ' Retrieve existing personal report.
     Dim existingPersonalReport As Report =
         CType(_serviceProxy.Retrieve(Report.EntityLogicalName,
                                      _reportId,
                                      New ColumnSet("ispersonal")), 
                                  Report)

     ' Set IsPersonal property to false. 
     existingPersonalReport.IsPersonal = False

     ' Make the report available to the organization.
     _serviceProxy.Update(existingPersonalReport)

     ' Retrieve the report and verify that the report is available to the organization
     Dim Cols1 As New ColumnSet("ispersonal")
     Dim retrieveAvailableReport As Report =
         CType(_serviceProxy.Retrieve(Report.EntityLogicalName,
                                      _reportId, Cols1), 
                                  Report)
     If retrieveAvailableReport.IsPersonal.Value = False Then
         Console.WriteLine("Report is available to the organization.")
     End If

     ' Now make the retrieved report unavailable to the organization
     retrieveAvailableReport.IsPersonal = True
     _serviceProxy.Update(retrieveAvailableReport)

     ' Retrieve the report, and verify that the report is unavailable to the organization
     Dim Cols2 As New ColumnSet("ispersonal")
     Dim retrieveUnavailableReport As Report =
         CType(_serviceProxy.Retrieve(Report.EntityLogicalName,
                                      _reportId, Cols2), 
                                  Report)
     If retrieveUnavailableReport.IsPersonal.Value = True Then
         Console.WriteLine("Report is unavailable to the organization.")
     End If


     DeleteRequiredRecords(promptforDelete)
 End Using

' </snippetmakereportavailableorunavailabletoorganization1>