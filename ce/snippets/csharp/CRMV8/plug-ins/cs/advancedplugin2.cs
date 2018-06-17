// <snippetadvancedplugin2>


 //Extract the tracing service for use in debugging sandboxed plug-ins.
 ITracingService tracingService =
     (ITracingService)serviceProvider.GetService(typeof(ITracingService));

 // Obtain the execution context from the service provider.
 IPluginExecutionContext context = (IPluginExecutionContext)
     serviceProvider.GetService(typeof(IPluginExecutionContext));

 // For this sample, execute the plug-in code only while the client is online. 
 tracingService.Trace("AdvancedPlugin: Verifying the client is not offline.");
 if (context.IsExecutingOffline || context.IsOfflinePlayback)
     return;

 // The InputParameters collection contains all the data passed 
 // in the message request.
 if (context.InputParameters.Contains("Target") &&
     context.InputParameters["Target"] is Entity)
 {
     // Obtain the target entity from the Input Parameters.
     tracingService.Trace
         ("AdvancedPlugin: Getting the target entity from Input Parameters.");
     Entity entity = (Entity)context.InputParameters["Target"];

     // Obtain the image entity from the Pre Entity Images.
     tracingService.Trace
         ("AdvancedPlugin: Getting image entity from PreEntityImages.");
     Entity image = (Entity)context.PreEntityImages["Target"];

// </snippetadvancedplugin2>