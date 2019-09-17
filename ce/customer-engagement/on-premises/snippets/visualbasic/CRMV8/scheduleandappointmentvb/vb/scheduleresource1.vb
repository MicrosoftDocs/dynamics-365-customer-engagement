' <snippetscheduleresource1>


 ' Create the van required resource object.
 Dim vanReq As RequiredResource = New RequiredResource With {.ResourceId = _vanId, .ResourceSpecId = _specId}

 ' Create the appointment request.
 Dim appointmentReq As AppointmentRequest = New AppointmentRequest With { _
     .RequiredResources = New RequiredResource() {vanReq}, .Direction = SearchDirection.Backward, _
     .Duration = 60, .NumberOfResults = 10, .ServiceId = _plumberServiceId, _
     .SearchWindowStart = Date.Now.ToUniversalTime(), .SearchWindowEnd = Date.Now.AddDays(7).ToUniversalTime(), _
     .UserTimeZoneCode = 1}
     ' The search window describes the time when the resouce can be scheduled.
     ' It must be set.

 ' Verify that the resources have been scheduled                
 Dim search As SearchRequest = New SearchRequest With {.AppointmentRequest = appointmentReq}
 Dim searched As SearchResponse = CType(_serviceProxy.Execute(search), SearchResponse)

 If searched.SearchResults.Proposals.Length > 0 Then
     Console.WriteLine("Scheduled the resources sucessfully.")
 End If

' </snippetscheduleresource1>