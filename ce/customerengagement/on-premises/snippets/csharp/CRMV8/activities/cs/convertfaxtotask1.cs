// <snippetconvertfaxtotask1>



 // Retrieve the fax.
 Fax retrievedFax = (Fax)_serviceProxy.Retrieve(Fax.EntityLogicalName, _faxId, new ColumnSet(true));

 // Create a task.
 Task task = new Task()
 {
     Subject = "Follow Up: " + retrievedFax.Subject,
     ScheduledEnd = retrievedFax.CreatedOn.Value.AddDays(7),
 };
 _taskId = _serviceProxy.Create(task);

 // Verify that the task has been created                    
 if (_taskId != Guid.Empty)
 {
     Console.WriteLine("Created a task for the fax: '{0}'.", task.Subject);
 }

// </snippetconvertfaxtotask1>