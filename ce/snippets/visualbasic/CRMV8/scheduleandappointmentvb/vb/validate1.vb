' <snippetvalidate1>



 ' Retrieve the appointment to be validated
 Dim cols As New ColumnSet("scheduledstart", "scheduledend", "statecode", "statuscode")
 Dim retrievedAppointment As Appointment = _
     CType(_serviceProxy.Retrieve(Appointment.EntityLogicalName, _appointmentId, cols), Appointment)

 ' Use the Validate message
 Dim validatedReq As New ValidateRequest()
 validatedReq.Activities = New EntityCollection()
 validatedReq.Activities.Entities.Add(retrievedAppointment)
 validatedReq.Activities.MoreRecords = False
 validatedReq.Activities.PagingCookie = ""
 validatedReq.Activities.EntityName = Appointment.EntityLogicalName

 Dim validateResp As ValidateResponse = CType(_serviceProxy.Execute(validatedReq), ValidateResponse)

 ' Verify success
 If (validateResp.Result IsNot Nothing) AndAlso (validateResp.Result.Length > 0) Then
     Console.WriteLine("Validated the appointment.")
 End If

' </snippetvalidate1>