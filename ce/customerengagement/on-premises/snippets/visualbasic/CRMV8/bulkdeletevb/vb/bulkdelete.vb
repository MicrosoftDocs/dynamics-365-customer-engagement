' <snippetbulkdelete>


             ' Create a condition for a bulk delete request.
	' NOTE: This sample uses very specific queries for deleting records
	' that have been manually exported in order to free space.
	Dim opportunitiesQuery As QueryExpression = BuildOpportunityQuery()

	' Create the bulk delete request.
	Dim bulkDeleteRequest As New BulkDeleteRequest()

	' Set the request properties.
	bulkDeleteRequest.JobName = "Backup Bulk Delete"

	' Querying activities
             bulkDeleteRequest.QuerySet = New QueryExpression() {
                 opportunitiesQuery,
                 BuildActivityQuery(Task.EntityLogicalName),
                 BuildActivityQuery(Fax.EntityLogicalName),
                 BuildActivityQuery(PhoneCall.EntityLogicalName),
                 BuildActivityQuery(Email.EntityLogicalName),
                 BuildActivityQuery(Letter.EntityLogicalName),
                 BuildActivityQuery(Appointment.EntityLogicalName),
                 BuildActivityQuery(ServiceAppointment.EntityLogicalName),
                 BuildActivityQuery(CampaignResponse.EntityLogicalName),
                 BuildActivityQuery(RecurringAppointmentMaster.EntityLogicalName)
             }

	' Set the start time for the bulk delete.
	bulkDeleteRequest.StartDateTime = Date.Now

	' Set the required recurrence pattern.
	bulkDeleteRequest.RecurrencePattern = String.Empty

	' Set email activity properties.
	bulkDeleteRequest.SendEmailNotification = False
	bulkDeleteRequest.ToRecipients = New Guid() { currentUserId }
	bulkDeleteRequest.CCRecipients = New Guid() { }

	' Submit the bulk delete job.
	' NOTE: Because this is an asynchronous operation, the response will be immediate.
             _bulkDeleteResponse = CType(_serviceProxy.Execute(bulkDeleteRequest), 
                 BulkDeleteResponse)
	Console.WriteLine("The bulk delete operation has been requested.")

' </snippetbulkdelete>