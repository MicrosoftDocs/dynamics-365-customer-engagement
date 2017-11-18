' <snippetbookappointment1>



 ' Get the current user information
 Dim userRequest As New WhoAmIRequest()
 Dim userResponse As WhoAmIResponse = CType(_serviceProxy.Execute(userRequest), WhoAmIResponse)

 ' Create the ActivityParty instance.
 Dim party As ActivityParty = New ActivityParty With { _
     .PartyId = New EntityReference(SystemUser.EntityLogicalName, userResponse.UserId)}

 ' Create the appointment instance.
 Dim appointment As Appointment = New Appointment With { _
     .Subject = "Test Appointment", .Description = "Test Appointment created using the BookRequest Message.", _
     .ScheduledStart = Date.Now.AddHours(1), .ScheduledEnd = Date.Now.AddHours(2), .Location = "Office", _
     .RequiredAttendees = New ActivityParty() {party}, .Organizer = New ActivityParty() {party}}

 ' Use the Book request message.
 Dim book As BookRequest = New BookRequest With {.Target = appointment}
 Dim booked As BookResponse = CType(_serviceProxy.Execute(book), BookResponse)
 _appointmentId = booked.ValidationResult.ActivityId

 ' Verify that the appointment has been scheduled.
 If _appointmentId <> Guid.Empty Then
     Console.WriteLine("Succesfully booked {0}.", appointment.Subject)
 End If

' </snippetbookappointment1>