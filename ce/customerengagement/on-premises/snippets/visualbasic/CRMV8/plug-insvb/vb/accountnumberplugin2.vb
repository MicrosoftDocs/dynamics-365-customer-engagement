' <snippetaccountnumberplugin2>


 Public Sub Execute(ByVal serviceProvider As IServiceProvider) _
     Implements IPlugin.Execute

     ' Obtain the execution context from the service provider.
     Dim context As Microsoft.Xrm.Sdk.IPluginExecutionContext =
         CType(serviceProvider.GetService(
                 GetType(Microsoft.Xrm.Sdk.IPluginExecutionContext)), 
             Microsoft.Xrm.Sdk.IPluginExecutionContext)

     ' The InputParameters collection contains all the data passed in the message request.
     If context.InputParameters.Contains("Target") AndAlso
         TypeOf context.InputParameters("Target") Is Entity Then

         ' Obtain the target entity from the input parameters.
         Dim entity As Entity = CType(context.InputParameters("Target"), Entity)

' </snippetaccountnumberplugin2>