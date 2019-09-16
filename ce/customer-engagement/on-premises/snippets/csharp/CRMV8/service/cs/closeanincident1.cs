// <snippetcloseanincident1>


 // Close the appointment.
 var setAppointmentStateReq = new SetStateRequest
 {
     EntityMoniker = new EntityReference(Appointment.EntityLogicalName,
         _appointmentId),
     State = new OptionSetValue((int)AppointmentState.Completed),
     Status = new OptionSetValue((int)appointment_statuscode.Completed)
 };

 _serviceProxy.Execute(setAppointmentStateReq);

 Console.WriteLine("  Appointment state set to completed.");

// </snippetcloseanincident1>