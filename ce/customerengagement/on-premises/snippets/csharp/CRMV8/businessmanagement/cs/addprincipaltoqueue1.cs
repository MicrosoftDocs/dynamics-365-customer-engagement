// <snippetaddprincipaltoqueue1>


 ColumnSet columnSet = new ColumnSet("name");
 Entity team = _serviceProxy.Retrieve(Team.EntityLogicalName, _teamId, columnSet);
 AddPrincipalToQueueRequest addPrincipalToQueueRequest = new AddPrincipalToQueueRequest
 {
     Principal = team,
     QueueId = _queueId
 };

 _serviceProxy.Execute(addPrincipalToQueueRequest);

// </snippetaddprincipaltoqueue1>