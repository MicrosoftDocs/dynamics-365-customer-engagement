' <snippetfollowupplugin1>


 ' Obtain the execution context from the service provider.
 Dim context As IPluginExecutionContext =
     CType(serviceProvider.GetService(GetType(IPluginExecutionContext)), 
         IPluginExecutionContext)

' </snippetfollowupplugin1>