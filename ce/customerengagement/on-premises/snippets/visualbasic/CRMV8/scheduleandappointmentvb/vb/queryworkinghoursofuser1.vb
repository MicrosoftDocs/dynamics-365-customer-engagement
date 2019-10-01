' <snippetqueryworkinghoursofuser1>


 ' Get the current user's information.
 Dim userRequest As New WhoAmIRequest()
 Dim userResponse As WhoAmIResponse = CType(_serviceProxy.Execute(userRequest), WhoAmIResponse)

 ' Retrieve the working hours of the current user.                                              
 Dim scheduleRequest As QueryScheduleRequest = New QueryScheduleRequest With { _
     .ResourceId = userResponse.UserId, .Start = Date.Now, .End = Date.Today.AddDays(7), _
     .TimeCodes = New TimeCode() {TimeCode.Available}}
 Dim scheduleResponse As QueryScheduleResponse = CType(_serviceProxy.Execute(scheduleRequest), QueryScheduleResponse)

 ' Verify if some data is returned for the availability of the current user
 If scheduleResponse.TimeInfos.Length > 0 Then
     Console.WriteLine("Successfully queried the working hours of the current user.")
 End If

' </snippetqueryworkinghoursofuser1>