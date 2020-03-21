// <snippetisvalidstatetransition>


 // Create an EntityReference to represent an open case
 EntityReference caseReference = new EntityReference()
 {
     LogicalName = Incident.EntityLogicalName,
     Id = _caseIncidentId
 };

 IsValidStateTransitionRequest checkState = 
     new IsValidStateTransitionRequest();

 // Set the transition request to an open case
 checkState.Entity = caseReference;

 // Check to see if a new state of "resolved" and 
 // a new status of "problem solved" are valid
 checkState.NewState = IncidentState.Resolved.ToString();
 checkState.NewStatus = (int)incident_statuscode.ProblemSolved;

 // Execute the request
 IsValidStateTransitionResponse checkStateResponse = 
     (IsValidStateTransitionResponse)_serviceProxy.Execute(checkState);

// </snippetisvalidstatetransition>