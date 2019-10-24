' <snippetsharequeue1>


 ' Grant the team Read and AppendTo access to the queue.  
 ' Having Read and AppendTo privileges gives a team a full access 
 ' to the queue items, but only read access to the queue. For 
 ' example, team members can’t change the queue name, but they 
 ' can make any modifications to the queue items.
 Dim grantAccessRequest As GrantAccessRequest = New GrantAccessRequest With {.PrincipalAccess = _
     New PrincipalAccess With {.Principal = New EntityReference(Team.EntityLogicalName, _teamId), _
                               .AccessMask = AccessRights.ReadAccess Or AccessRights.AppendToAccess}, _
                               .Target = New EntityReference(Queue.EntityLogicalName, _queueId)}

 _serviceProxy.Execute(grantAccessRequest)

' </snippetsharequeue1>