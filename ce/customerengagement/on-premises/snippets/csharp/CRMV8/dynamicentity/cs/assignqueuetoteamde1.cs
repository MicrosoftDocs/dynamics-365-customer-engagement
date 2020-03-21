// <snippetassignqueuetoteamde1>


 // The queue ID would typically be passed in as an argument or determined by a query.
 // The team ID would typically be passed in as an argument or determined by a query.
 // Assign the queue to a team.
 AssignRequest assignRequest = new AssignRequest()
 {
     Assignee = new EntityReference
     {
         LogicalName = "team",
         Id = _teamId
     },

     Target = new EntityReference("queue", _queueId)
 };

 _service.Execute(assignRequest);

// </snippetassignqueuetoteamde1>