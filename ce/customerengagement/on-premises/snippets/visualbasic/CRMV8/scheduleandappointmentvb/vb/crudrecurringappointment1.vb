' <snippetcrudrecurringappointment1>


 ' Define an anonymous type to define the possible recurrence pattern values.
 Dim RecurrencePatternTypes = New With {Key .Daily = 0, Key .Weekly = 1, Key .Monthly = 2, Key .Yearly = 3}

 ' Define an anonymous type to define the possible values for days 
 ' of the week
 Dim DayOfWeek = New With {Key .Sunday = &amp;H1, Key .Monday = &amp;H2, Key .Tuesday = &amp;H4, Key .Wednesday = &amp;H8, _
                           Key .Thursday = &amp;H10, Key .Friday = &amp;H20, Key .Saturday = &amp;H40}

 ' Define an anonymous type to define the possible values  
 ' for the recurrence rule pattern end type.
 Dim RecurrenceRulePatternEndType = New With {Key .NoEndDate = 1, Key .Occurrences = 2, Key .PatternEndDate = 3}

 ' Create a recurring appointment
 Dim newRecurringAppointment As RecurringAppointmentMaster = New RecurringAppointmentMaster With { _
     .Subject = "Sample Recurring Appointment", .StartTime = Date.Now.AddHours(1), .EndTime = Date.Now.AddHours(2), _
     .RecurrencePatternType = New OptionSetValue(RecurrencePatternTypes.Weekly), .Interval = 1, _
     .DaysOfWeekMask = DayOfWeek.Thursday, .PatternStartDate = Date.Today, .Occurrences = 10, _
     .PatternEndType = New OptionSetValue(RecurrenceRulePatternEndType.Occurrences)}

 _recurringAppointmentMasterId = _serviceProxy.Create(newRecurringAppointment)
 Console.WriteLine("Created {0}.", newRecurringAppointment.Subject)

 ' Retrieve the newly created recurring appointment
 Dim recurringAppointmentQuery As QueryExpression = New QueryExpression With { _
     .EntityName = RecurringAppointmentMaster.EntityLogicalName, .ColumnSet = New ColumnSet("subject"), _
     .PageInfo = New PagingInfo With {.Count = 1, .PageNumber = 1}}
 recurringAppointmentQuery.Criteria = New FilterExpression()
 recurringAppointmentQuery.Criteria.AddCondition("subject", ConditionOperator.Equal, {"Sample Recurring Appointment"})
 recurringAppointmentQuery.Criteria.AddCondition("interval", ConditionOperator.Equal, {1})

 Dim retrievedRecurringAppointment As RecurringAppointmentMaster = _
     _serviceProxy.RetrieveMultiple(recurringAppointmentQuery).Entities.Select(Function(x) _
                                                               CType(x, RecurringAppointmentMaster)).FirstOrDefault()

 Console.WriteLine("Retrieved the recurring appointment.")

 ' Update the recurring appointment.
 ' Update the following for the retrieved recurring appointment series:
 ' 1. Update the subject.
 ' 2. Update the number of occurences to 5.
 ' 3. Update the appointment interval to 2.

 retrievedRecurringAppointment.Subject = "Updated Recurring Appointment"
 retrievedRecurringAppointment.Occurrences = 5
 retrievedRecurringAppointment.Interval = 2
 _serviceProxy.Update(retrievedRecurringAppointment)

 Console.WriteLine("Updated the subject, occurrences, and interval of the recurring appointment.")

' </snippetcrudrecurringappointment1>