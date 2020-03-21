// <snippetcloseanincident2>


 // Close the incident with the resolution.
 var closeIncidentRequest = new CloseIncidentRequest
 {
     IncidentResolution = incidentResolution,
     Status = new OptionSetValue((int)incident_statuscode.ProblemSolved)
 };

 _serviceProxy.Execute(closeIncidentRequest);

 Console.WriteLine("  Incident closed.");

// </snippetcloseanincident2>