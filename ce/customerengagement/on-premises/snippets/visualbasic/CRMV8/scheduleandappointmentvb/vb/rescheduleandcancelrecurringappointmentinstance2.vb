' <snippetrescheduleandcancelrecurringappointmentinstance2>


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

' </snippetrescheduleandcancelrecurringappointmentinstance2>