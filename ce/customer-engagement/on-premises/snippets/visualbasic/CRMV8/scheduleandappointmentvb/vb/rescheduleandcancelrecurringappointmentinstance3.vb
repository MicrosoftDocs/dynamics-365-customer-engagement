' <snippetrescheduleandcancelrecurringappointmentinstance3>


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

' </snippetrescheduleandcancelrecurringappointmentinstance3>