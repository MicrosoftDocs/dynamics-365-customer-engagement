// <snippetcrudrecurringappointment1>


 // Define an anonymous type to define the possible recurrence pattern values.
 var RecurrencePatternTypes = new
 {
     Daily = 0,
     Weekly = 1,
     Monthly = 2,
     Yearly = 3
 };

 // Define an anonymous type to define the possible values for days 
 // of the week
 var DayOfWeek = new
 {
     Sunday = 0x01,
     Monday = 0x02,
     Tuesday = 0x04,
     Wednesday = 0x08,
     Thursday = 0x10,
     Friday = 0x20,
     Saturday = 0x40
 };

 // Define an anonymous type to define the possible values  
 // for the recurrence rule pattern end type.
 var RecurrenceRulePatternEndType = new
 {
     NoEndDate = 1,
     Occurrences = 2,
     PatternEndDate = 3
 };

 // Create a recurring appointment
 RecurringAppointmentMaster newRecurringAppointment = new RecurringAppointmentMaster
     {
         Subject = "Sample Recurring Appointment",
         StartTime = DateTime.Now.AddHours(1),
         EndTime = DateTime.Now.AddHours(2),
         RecurrencePatternType = new OptionSetValue(RecurrencePatternTypes.Weekly),
         Interval = 1,
         DaysOfWeekMask = DayOfWeek.Thursday,
         PatternStartDate = DateTime.Today,
         Occurrences = 10,
         PatternEndType = new OptionSetValue(RecurrenceRulePatternEndType.Occurrences)
     };

 _recurringAppointmentMasterId = _serviceProxy.Create(newRecurringAppointment);
 Console.WriteLine("Created {0}.", newRecurringAppointment.Subject);

 // Retrieve the newly created recurring appointment
 QueryExpression recurringAppointmentQuery = new QueryExpression
 {
     EntityName = RecurringAppointmentMaster.EntityLogicalName,
     ColumnSet = new ColumnSet("subject"),
     Criteria = new FilterExpression
     {
         Conditions =
     {
         new ConditionExpression
         {
             AttributeName = "subject",
             Operator = ConditionOperator.Equal,
             Values = { "Sample Recurring Appointment" }
         },
         new ConditionExpression
         {
             AttributeName = "interval",
             Operator = ConditionOperator.Equal,
             Values = { 1 }
         }
     }
     },
     PageInfo = new PagingInfo
     {
         Count = 1,
         PageNumber = 1
     }
 };

 RecurringAppointmentMaster retrievedRecurringAppointment =
     _serviceProxy.RetrieveMultiple(recurringAppointmentQuery).
     Entities.Select(x => (RecurringAppointmentMaster)x).FirstOrDefault();

 Console.WriteLine("Retrieved the recurring appointment.");

 // Update the recurring appointment.
 // Update the following for the retrieved recurring appointment series:
 // 1. Update the subject.
 // 2. Update the number of occurences to 5.
 // 3. Update the appointment interval to 2.

 retrievedRecurringAppointment.Subject = "Updated Recurring Appointment";
 retrievedRecurringAppointment.Occurrences = 5;
 retrievedRecurringAppointment.Interval = 2;
 _serviceProxy.Update(retrievedRecurringAppointment);

 Console.WriteLine("Updated the subject, occurrences, and interval of the recurring appointment.");

// </snippetcrudrecurringappointment1>