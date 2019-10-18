' <snippetqueryworkinghoursofmultipleusers1>



 ' Retrieve the working hours of the current and the other user.                                              
 Dim scheduleRequest As New QueryMultipleSchedulesRequest()
 scheduleRequest.ResourceIds = New Guid(1) {}
 scheduleRequest.ResourceIds(0) = _currentUserId
 scheduleRequest.ResourceIds(1) = _otherUserId
 scheduleRequest.Start = Date.Now
 scheduleRequest.End = Date.Today.AddDays(7)
 scheduleRequest.TimeCodes = New TimeCode() {TimeCode.Available}

 Dim scheduleResponse As QueryMultipleSchedulesResponse =
     CType(_serviceProxy.Execute(scheduleRequest), 
         QueryMultipleSchedulesResponse)

 ' Verify if some data is returned for the availability of the users
 If scheduleResponse.TimeInfos.Length > 0 Then
     Console.WriteLine(
         "Successfully queried the working hours of multiple users.")
 End If

' </snippetqueryworkinghoursofmultipleusers1>