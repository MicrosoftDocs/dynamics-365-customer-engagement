// <snippetcloseanincident3>


 // Validate the state transition.  
 var isValidRequest = new IsValidStateTransitionRequest
 {
     Entity = new EntityReference(Incident.EntityLogicalName, _incidentId),
     NewState = IncidentState.Resolved.ToString(),
     NewStatus = (int)incident_statuscode.ProblemSolved
 };

 var response = 
     (IsValidStateTransitionResponse)_serviceProxy.Execute(isValidRequest);
 var isValidString = response.IsValid ? "is valid" : "is not valid";
 Console.WriteLine("  The transition to a completed status reason {0}.",
     isValidString);

// </snippetcloseanincident3>