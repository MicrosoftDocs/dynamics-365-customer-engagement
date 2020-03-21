// <snippetsetstate>


 // Create the Request Object
 SetStateRequest state = new SetStateRequest();

 // Set the Request Object's Properties
 state.State = new OptionSetValue((int)IncidentState.Active);
 state.Status = 
     new OptionSetValue((int)incident_statuscode.WaitingforDetails);

 // Point the Request to the case whose state is being changed
 state.EntityMoniker = caseReference;

 // Execute the Request
 SetStateResponse stateSet = (SetStateResponse)_serviceProxy.Execute(state);

 // Check if the state was successfully set
 Incident incident = _serviceProxy.Retrieve(Incident.EntityLogicalName, 
     _caseIncidentId, new ColumnSet(allColumns: true)).ToEntity<Incident>();

 if (incident.StatusCode.Value == (int)incident_statuscode.WaitingforDetails)
 {
     Console.WriteLine("Record state set successfully.");
 }
 else
 {
     Console.WriteLine("The request to set the record state failed.");
 }

// </snippetsetstate>