// <snippetbookappointment1>



 // Get the current user information
 WhoAmIRequest userRequest = new WhoAmIRequest();
 WhoAmIResponse userResponse = (WhoAmIResponse)_serviceProxy.Execute(userRequest);

 // Create the ActivityParty instance.
 ActivityParty party = new ActivityParty
 {
     PartyId = new EntityReference(SystemUser.EntityLogicalName, userResponse.UserId)
 };
 
 // Create the appointment instance.
 Appointment appointment = new Appointment
 {
     Subject = "Test Appointment",
     Description = "Test Appointment created using the BookRequest Message.",
     ScheduledStart = DateTime.Now.AddHours(1),
     ScheduledEnd = DateTime.Now.AddHours(2),
     Location = "Office",
     RequiredAttendees = new ActivityParty[] { party },
     Organizer = new ActivityParty[] { party }                        
 };                    
 
 // Use the Book request message.
 BookRequest book = new BookRequest
 {
     Target = appointment
 };
 BookResponse booked = (BookResponse)_serviceProxy.Execute(book);
 _appointmentId = booked.ValidationResult.ActivityId;
 
 // Verify that the appointment has been scheduled.
 if (_appointmentId != Guid.Empty)
 {
     Console.WriteLine("Succesfully booked {0}.", appointment.Subject) ;
 }

// </snippetbookappointment1>