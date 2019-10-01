// <snippetscheduleresource1>


 // Create the van required resource object.
 RequiredResource vanReq = new RequiredResource
 {
     ResourceId = _vanId,
     ResourceSpecId = _specId
 };

 // Create the appointment request.
 AppointmentRequest appointmentReq = new AppointmentRequest
 {
     RequiredResources = new RequiredResource[] { vanReq },
     Direction = SearchDirection.Backward,
     Duration = 60,
     NumberOfResults = 10,
     ServiceId = _plumberServiceId,
     // The search window describes the time when the resouce can be scheduled.
     // It must be set.
     SearchWindowStart = DateTime.Now.ToUniversalTime(),
     SearchWindowEnd = DateTime.Now.AddDays(7).ToUniversalTime(),
     UserTimeZoneCode = 1
 };

 // Verify whether there are openings available to schedule the appointment using this resource              
 SearchRequest search = new SearchRequest
 {
     AppointmentRequest = appointmentReq
 };
 SearchResponse searched = (SearchResponse)_serviceProxy.Execute(search);

 if (searched.SearchResults.Proposals.Length > 0)
 {
     Console.WriteLine("Openings are available to schedule the resource.");
 }

// </snippetscheduleresource1>