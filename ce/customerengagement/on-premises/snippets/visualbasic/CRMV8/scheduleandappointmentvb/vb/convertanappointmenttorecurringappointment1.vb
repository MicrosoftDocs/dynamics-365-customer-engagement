' <snippetconvertanappointmenttorecurringappointment1>



 ' Specify the recurrence information that needs to be added to the
 ' existing appointment.
 ' 1.  Define an anonymous type to define the possible recurrence pattern values.
 Dim RecurrencePatternTypes = New With {Key .Daily = 0, Key .Weekly = 1, Key .Monthly = 2, Key .Yearly = 3}

 ' 2.  Define an anonymous type to define the possible values for days 
 ' of the week
 Dim DayOfWeek = New With {Key .Sunday = &amp;H1, Key .Monday = &amp;H2, Key .Tuesday = &amp;H4, Key .Wednesday = &amp;H8, _
                           Key .Thursday = &amp;H10, Key .Friday = &amp;H20, Key .Saturday = &amp;H40}

 ' 3.  Define an anonymous type to define the possible values  
 ' for the recurrence rule pattern end type.
 Dim RecurrenceRulePatternEndType = New With {Key .NoEndDate = 1, Key .Occurrences = 2, Key .PatternEndDate = 3}

 ' 4.  Finally, use a recurring appointment master object to specify
 '     the recurrence information. Other appointment details such as
 '     'subject' and 'location' are copied from the existing appointment
 '     to the recurring appointment master object.

 Dim newRecurringAppointmentInfo As RecurringAppointmentMaster = New RecurringAppointmentMaster With { _
     .StartTime = Date.Now.AddHours(2), .EndTime = Date.Now.AddHours(3), .RecurrencePatternType = _
     New OptionSetValue(RecurrencePatternTypes.Weekly), .Interval = 1, .DaysOfWeekMask = DayOfWeek.Thursday, _
     .PatternStartDate = Date.Today, .PatternEndType = _
     New OptionSetValue(RecurrenceRulePatternEndType.Occurrences), .Occurrences = 5}


 ' Use the AddRecurrence message to convert the existing appointment
 ' object to a recurring appointment master object. The existing
 ' appointment object is deleted thereafter.

 Dim recurringInfoRequest As AddRecurrenceRequest = New AddRecurrenceRequest With { _
     .Target = newRecurringAppointmentInfo, .AppointmentId = _appointmentId}

 Dim recurringInfoResponse As AddRecurrenceResponse = _
     CType(_serviceProxy.Execute(recurringInfoRequest), AddRecurrenceResponse)
 __recurringAppointmentMasterId = recurringInfoResponse.id

 ' Verify that the newly created recurring appointment master has same 'subject' 
 ' as the existing appointment.

 Dim retrievedMasterAppointment As RecurringAppointmentMaster = _
     CType(_serviceProxy.Retrieve(RecurringAppointmentMaster.EntityLogicalName, __recurringAppointmentMasterId, _
                                  New ColumnSet(True)), RecurringAppointmentMaster)
 If retrievedMasterAppointment.Subject = "Sample Appointment" Then
     Console.WriteLine("Sample Appointment is converted to a recurring appointment.")
 End If

' </snippetconvertanappointmenttorecurringappointment1>