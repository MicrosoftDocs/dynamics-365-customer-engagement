// <snippetsharequeue1>


 // Grant the team Read and AppendTo access to the queue.  
 // Having Read and AppendTo privileges gives a team a full access 
 // to the queue items, but only read access to the queue. For 
 // example, team members can’t change the queue name, but they 
 // can make any modifications to the queue items.
 GrantAccessRequest grantAccessRequest = new GrantAccessRequest
 {
     PrincipalAccess = new PrincipalAccess
     {
         Principal = new EntityReference(Team.EntityLogicalName, _teamId),
         AccessMask = AccessRights.ReadAccess
         | AccessRights.AppendToAccess
     },
     Target = new EntityReference(Queue.EntityLogicalName, _queueId)
 };

 _serviceProxy.Execute(grantAccessRequest);

// </snippetsharequeue1>