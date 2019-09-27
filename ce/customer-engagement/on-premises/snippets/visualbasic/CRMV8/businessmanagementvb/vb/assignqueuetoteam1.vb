' <snippetassignqueuetoteam1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()



     ' Call the method to create any data that this sample requires.
     CreateRequiredRecords()


     ' Assign the queue to a team.
     _serviceProxy.Associate(Queue.EntityLogicalName, _queueId, New Relationship("queue_team"), _
                             New EntityReferenceCollection() From {New EntityReference(Team.EntityLogicalName, _teamId)})

' </snippetassignqueuetoteam1>