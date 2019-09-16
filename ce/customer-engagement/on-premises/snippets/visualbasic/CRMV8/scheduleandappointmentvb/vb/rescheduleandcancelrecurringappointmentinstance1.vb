' <snippetrescheduleandcancelrecurringappointmentinstance1>


                    ' Retrieve the individual appointment instance that falls on or after
                    ' 10 days from today. Basically this will be the second instance in the
                    ' recurring appointment series.                                          

                    Dim instanceQuery As QueryExpression = New QueryExpression With { _
                        .EntityName = Appointment.EntityLogicalName, .ColumnSet = _
                        New ColumnSet({"activityid", "scheduledstart", "scheduledend"})}
                    instanceQuery.Criteria = New FilterExpression()
                    instanceQuery.Criteria.AddCondition("seriesid", ConditionOperator.Equal, {_recurringAppointmentMasterId})
                    instanceQuery.Criteria.AddCondition("scheduledstart", ConditionOperator.OnOrAfter, {Date.Today.AddDays(10)})

                    Dim individualAppointments As EntityCollection = _serviceProxy.RetrieveMultiple(instanceQuery)

'                    #Region "Reschedule an instance of recurring appointment"

                    ' Update the scheduled start and end dates of the appointment
                    ' to reschedule it.
                    Dim updateAppointment As Appointment = New Appointment With { _
                        .ActivityId = individualAppointments.Entities.Select(Function(x) CType(x, Appointment)).First().ActivityId, _
                        .ScheduledStart = individualAppointments.Entities.Select( _
                            Function(x) CType(x, Appointment)).First().ScheduledStart.Value.AddHours(1), _
                        .ScheduledEnd = individualAppointments.Entities.Select(Function(x) _
                                                                    CType(x, Appointment)).First().ScheduledEnd.Value.AddHours(2)}

                    Dim reschedule As RescheduleRequest = New RescheduleRequest With {.Target = updateAppointment}

                    Dim rescheduled As RescheduleResponse = CType(_serviceProxy.Execute(reschedule), RescheduleResponse)
                    Console.WriteLine("Rescheduled the second instance of the recurring appointment.")

'                    #End Region ' Reschedule an instance of recurring appointment

'                    #Region "Cancel an instance of recurring appointment"

                    ' Cancel the last instance of the appointment. The status of this appointment
                    ' instance is set to 'Canceled'. You can view this appoinyment instance under
                    ' the 'All Activities' view. 
                    Dim appointmentRequest As SetStateRequest = New SetStateRequest With { _
                        .State = New OptionSetValue(CInt(Fix(AppointmentState.Canceled))), .Status = New OptionSetValue(4), _
                        .EntityMoniker = New EntityReference(Appointment.EntityLogicalName, _
                            New Guid(individualAppointments.Entities.Select(Function(x) CType(x, Appointment)).Last().ActivityId.ToString()))}

                    _serviceProxy.Execute(appointmentRequest)
                    Console.WriteLine("Canceled the last instance of the recurring appointment.")

'                    #End Region ' Cancel an instance of recurring appointment

' </snippetrescheduleandcancelrecurringappointmentinstance1>