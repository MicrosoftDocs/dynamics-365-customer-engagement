// <snippetqueryworkinghoursofmultipleusers1>



 // Retrieve the working hours of the current and the other user.                                              
 QueryMultipleSchedulesRequest scheduleRequest = new QueryMultipleSchedulesRequest();
 scheduleRequest.ResourceIds = new Guid[2];
 scheduleRequest.ResourceIds[0] = _currentUserId;
 scheduleRequest.ResourceIds[1] = _otherUserId;
 scheduleRequest.Start = DateTime.Now;
 scheduleRequest.End = DateTime.Today.AddDays(7);
 scheduleRequest.TimeCodes = new TimeCode[] { TimeCode.Available };

 QueryMultipleSchedulesResponse scheduleResponse = (QueryMultipleSchedulesResponse)_serviceProxy.Execute(scheduleRequest);

 // Verify if some data is returned for the availability of the users
 if (scheduleResponse.TimeInfos.Length > 0)
 {
     Console.WriteLine("Successfully queried the working hours of multiple users.");
 }

// </snippetqueryworkinghoursofmultipleusers1>