// <snippetassignqueuetoteam1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();



     // Call the method to create any data that this sample requires.
     CreateRequiredRecords();

     
     // Assign the queue to a team.
     _serviceProxy.Associate(
        Queue.EntityLogicalName, _queueId,
        new Relationship("queue_team"),
        new EntityReferenceCollection() { new EntityReference(Team.EntityLogicalName, _teamId) });

// </snippetassignqueuetoteam1>