// <snippetrescheduleandcancelrecurringappointmentinstance3>



 #region Cancel an instance of recurring appointment

 // Cancel the last instance of the appointment. The status of this appointment
 // instance is set to 'Canceled'. You can view this appoinyment instance under
 // the 'All Activities' view. 
 SetStateRequest appointmentRequest = new SetStateRequest
 {
     State = new OptionSetValue((int)AppointmentState.Canceled),
     Status = new OptionSetValue(4),
     EntityMoniker = new EntityReference(Appointment.EntityLogicalName,
         new Guid(individualAppointments.Entities.Select(x => (Appointment)x).Last().ActivityId.ToString()))
 };

 _serviceProxy.Execute(appointmentRequest);
 Console.WriteLine("Canceled the last instance of the recurring appointment.");

 #endregion Cancel an instance of recurring appointment

// </snippetrescheduleandcancelrecurringappointmentinstance3>