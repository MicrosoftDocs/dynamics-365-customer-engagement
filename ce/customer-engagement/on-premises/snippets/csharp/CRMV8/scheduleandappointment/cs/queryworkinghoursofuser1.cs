// <snippetqueryworkinghoursofuser1>


 // Get the current user's information.
 WhoAmIRequest userRequest = new WhoAmIRequest();
 WhoAmIResponse userResponse = (WhoAmIResponse)_serviceProxy.Execute(userRequest);

 // Retrieve the working hours of the current user.                                              
 QueryScheduleRequest scheduleRequest = new QueryScheduleRequest
 {
     ResourceId = userResponse.UserId,
     Start = DateTime.Now,
     End = DateTime.Today.AddDays(7),
     TimeCodes = new TimeCode[] { TimeCode.Available }
 };
 QueryScheduleResponse scheduleResponse = (QueryScheduleResponse)_serviceProxy.Execute(scheduleRequest);

 // Verify if some data is returned for the availability of the current user
 if (scheduleResponse.TimeInfos.Length > 0)
 {
     Console.WriteLine("Successfully queried the working hours of the current user.");
 }

// </snippetqueryworkinghoursofuser1>