// <snippetaccountnumberplugin2>


       public void Execute(IServiceProvider serviceProvider)
	{
           // Obtain the execution context from the service provider.
           Microsoft.Xrm.Sdk.IPluginExecutionContext context = (Microsoft.Xrm.Sdk.IPluginExecutionContext)
               serviceProvider.GetService(typeof(Microsoft.Xrm.Sdk.IPluginExecutionContext));

           // The InputParameters collection contains all the data passed in the message request.
		if (context.InputParameters.Contains("Target") &&
			context.InputParameters["Target"] is Entity)
           {
               // Obtain the target entity from the input parameters.
			Entity entity = (Entity)context.InputParameters["Target"];

// </snippetaccountnumberplugin2>