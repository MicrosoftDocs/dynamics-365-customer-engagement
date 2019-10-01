// <snippetsharedvariablesplugin>


using System;

// Microsoft Dynamics CRM namespace(s)
using Microsoft.Xrm.Sdk;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// A plug-in that sends data to another plug-in through the SharedVariables
    /// property of IPluginExecutionContext.
    /// </summary>
    /// <remarks>Register the PreEventPlugin for a pre-operation stage and the 
    /// PostEventPlugin plug-in on a post-operation stage.
    /// </remarks>
    public class PreEventPlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            // Obtain the execution context from the service provider.
            Microsoft.Xrm.Sdk.IPluginExecutionContext context = (Microsoft.Xrm.Sdk.IPluginExecutionContext)
                serviceProvider.GetService(typeof(Microsoft.Xrm.Sdk.IPluginExecutionContext));

            // Create or retrieve some data that will be needed by the post event
            // plug-in. You could run a query, create an entity, or perform a calculation.
            //In this sample, the data to be passed to the post plug-in is
            // represented by a GUID.
            Guid contact = new Guid("{74882D5C-381A-4863-A5B9-B8604615C2D0}");

            // Pass the data to the post event plug-in in an execution context shared
            // variable named PrimaryContact.
            context.SharedVariables.Add("PrimaryContact", (Object)contact.ToString());
        }
    }

    public class PostEventPlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            // Obtain the execution context from the service provider.
            Microsoft.Xrm.Sdk.IPluginExecutionContext context = (Microsoft.Xrm.Sdk.IPluginExecutionContext)
                serviceProvider.GetService(typeof(Microsoft.Xrm.Sdk.IPluginExecutionContext));

            // Obtain the contact from the execution context shared variables.
            if (context.SharedVariables.Contains("PrimaryContact"))
            {
                Guid contact =
                    new Guid((string)context.SharedVariables["PrimaryContact"]);

                // Do something with the contact.
            }
        }
    }
}

// </snippetsharedvariablesplugin>