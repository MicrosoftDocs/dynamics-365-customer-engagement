' <snippetassignqueuetoteamde1>


 ' The queue ID would typically be passed in as an argument or determined by a query.
 ' The team ID would typically be passed in as an argument or determined by a query.
 ' Assign the queue to a team.
 Dim assignRequest As New AssignRequest() With {.Assignee = New EntityReference With { _
         .LogicalName = "team", .Id = _teamId}, .Target = New EntityReference("queue", _queueId)}

 _service.Execute(assignRequest)

' </snippetassignqueuetoteamde1>