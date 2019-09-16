' <snippetconvertfaxtotask1>



 ' Retrieve the fax.
 Dim retrievedFax As Fax = CType(_serviceProxy.Retrieve(Fax.EntityLogicalName, _faxId, New ColumnSet(True)), Fax)

 ' Create a task.
 Dim task As New Task() With {.Subject = "Follow Up: " &amp; retrievedFax.Subject, _
                              .ScheduledEnd = retrievedFax.CreatedOn.Value.AddDays(7)}
 _taskId = _serviceProxy.Create(task)

 ' Verify that the task has been created                    
 If _taskId <> Guid.Empty Then
     Console.WriteLine("Created a task for the fax: '{0}'.", task.Subject)
 End If

' </snippetconvertfaxtotask1>