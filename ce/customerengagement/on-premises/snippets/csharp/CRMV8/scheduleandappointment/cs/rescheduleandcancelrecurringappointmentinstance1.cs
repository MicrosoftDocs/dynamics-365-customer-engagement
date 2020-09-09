// <snippetrescheduleandcancelrecurringappointmentinstance1>


 // Retrieve the individual appointment instance that falls on or after
 // 10 days from today. Basically this will be the second instance in the
 // recurring appointment series.                                          

 QueryExpression instanceQuery = new QueryExpression
 {
     EntityName = Appointment.EntityLogicalName,
     ColumnSet = new ColumnSet
     {
         Columns = { "activityid", "scheduledstart", "scheduledend" }
     },
     Criteria = new FilterExpression
     {
         Conditions = 
     {
         new ConditionExpression 
         {
             AttributeName = "seriesid",
             Operator = ConditionOperator.Equal,
             Values = { _recurringAppointmentMasterId }
         },
         new ConditionExpression 
         {
              AttributeName = "scheduledstart",
              Operator = ConditionOperator.OnOrAfter,
              Values = { DateTime.Today.AddDays(10) }
         }
     }
     }
 };

 EntityCollection individualAppointments = _serviceProxy.RetrieveMultiple(instanceQuery);


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

// </snippetrescheduleandcancelrecurringappointmentinstance1>