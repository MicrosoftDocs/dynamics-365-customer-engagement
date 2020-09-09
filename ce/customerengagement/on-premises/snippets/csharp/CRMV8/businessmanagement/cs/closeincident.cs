// <snippetcloseincident>


 // First close the Incident

 // Create resolution for the closing incident
 IncidentResolution resolution = new IncidentResolution
 {
     Subject = "Case Closed",
 };

 resolution.IncidentId = caseReference;

 // Create the request to close the incident, and set its resolution to the 
 // resolution created above
 CloseIncidentRequest closeRequest = new CloseIncidentRequest();
 closeRequest.IncidentResolution = resolution;

 // Set the requested new status for the closed Incident
 closeRequest.Status = 
     new OptionSetValue((int)incident_statuscode.ProblemSolved);

 // Execute the close request
 CloseIncidentResponse closeResponse = 
     (CloseIncidentResponse)_serviceProxy.Execute(closeRequest);

 //Check if the incident was successfully closed
 Incident incident = _serviceProxy.Retrieve(Incident.EntityLogicalName, 
     _caseIncidentId, new ColumnSet(allColumns: true)).ToEntity<Incident>();

 if (incident.StateCode.HasValue && 
     incident.StateCode == IncidentState.Resolved)
 {
     Console.WriteLine("The incident was closed out as Resolved.");
 }
 else
 {
     Console.WriteLine("The incident's state was not changed.");
 }

// </snippetcloseincident>