' <snippetfollowupplugin3>


 Catch ex As FaultException(Of OrganizationServiceFault)

     Throw New InvalidPluginExecutionException(
         "An error occurred in the FollupupPlugin plug-in.", ex)

' </snippetfollowupplugin3>