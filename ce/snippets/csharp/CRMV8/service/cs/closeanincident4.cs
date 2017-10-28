// <snippetcloseanincident4>


 // Calculate the total number of minutes spent on an incident. 
 var calculateRequestTime = new CalculateTotalTimeIncidentRequest
 {
     IncidentId = _incidentId
 };
 var response =
     (CalculateTotalTimeIncidentResponse)_serviceProxy.Execute(calculateRequestTime);

 Console.WriteLine("  {0} minutes have been spent on the incident.",
     response.TotalTime);

// </snippetcloseanincident4>