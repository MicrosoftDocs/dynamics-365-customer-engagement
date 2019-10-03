// <snippetrescheduleandcancelrecurringappointmentinstance2>



 #region Reschedule an instance of recurring appointment

 // Update the scheduled start and end dates of the appointment
 // to reschedule it.
 Appointment updateAppointment = new Appointment
 {
     ActivityId = individualAppointments.Entities.Select(x => (Appointment)x).First().ActivityId,
     ScheduledStart = individualAppointments.Entities.Select(x => (Appointment)x).First().ScheduledStart.Value.AddHours(1),
     ScheduledEnd = individualAppointments.Entities.Select(x => (Appointment)x).First().ScheduledEnd.Value.AddHours(2)
 };

 RescheduleRequest reschedule = new RescheduleRequest
 {
     Target = updateAppointment
 };

 RescheduleResponse rescheduled = (RescheduleResponse)_serviceProxy.Execute(reschedule);
 Console.WriteLine("Rescheduled the second instance of the recurring appointment.");

 #endregion Reschedule an instance of recurring appointment

// </snippetrescheduleandcancelrecurringappointmentinstance2>