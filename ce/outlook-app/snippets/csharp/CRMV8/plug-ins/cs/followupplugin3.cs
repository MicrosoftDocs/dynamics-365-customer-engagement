// <snippetfollowupplugin3>


 catch (FaultException<OrganizationServiceFault> ex)
 {
     throw new InvalidPluginExecutionException("An error occurred in the FollowupPlugin plug-in.", ex);
 }

// </snippetfollowupplugin3>