// <snippetvalidate1>


 
 // Retrieve the appointment to be validated
 ColumnSet cols = new ColumnSet("scheduledstart", "scheduledend", "statecode", "statuscode");
 Appointment retrievedAppointment = (Appointment)_serviceProxy.Retrieve(Appointment.EntityLogicalName,
                                            _appointmentId, cols);

 // Use the Validate message
 ValidateRequest validatedReq = new ValidateRequest();
 validatedReq.Activities = new EntityCollection();
 validatedReq.Activities.Entities.Add(retrievedAppointment);
 validatedReq.Activities.MoreRecords = false;
 validatedReq.Activities.PagingCookie = "";
 validatedReq.Activities.EntityName = Appointment.EntityLogicalName;

 ValidateResponse validateResp = (ValidateResponse)_serviceProxy.Execute(validatedReq);
 
 // Verify success
 if ((validateResp.Result != null) && (validateResp.Result.Length > 0))
 {
     Console.WriteLine("Validated the appointment.");                        
 }

// </snippetvalidate1>