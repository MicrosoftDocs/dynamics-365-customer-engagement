// <snippetadvancedplugin>


using System;

// Microsoft Dynamics CRM namespace(s)
using Microsoft.Xrm.Sdk;

namespace Microsoft.Crm.Sdk.Samples
{
    public class AdvancedPlugin : IPlugin
    {
        private readonly string _unsecureString;
        private readonly string _secureString;

        public AdvancedPlugin(string unsecureString, string secureString)
        {
            if (String.IsNullOrWhiteSpace(unsecureString) ||
                String.IsNullOrWhiteSpace(secureString))
            {
                throw new InvalidOperationException
                    ("Unsecure and secure strings are required by the Advanced Plug-in, but not provided.");
            }

            _unsecureString = unsecureString;
            _secureString = secureString;
        }
        /// <summary>
        /// A plug-in that updates the description field with values 
        /// from the unsecure and secure constructor parameters.
        /// </summary>
        /// <remarks>Register this plug-in on the Update message, contact entity,
        /// pre-Operation and synchronous mode. See the Readme for more information.
        /// </remarks>
        public void Execute(IServiceProvider serviceProvider)
        {
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

                // Verify that the target entity represents a contact.
                // If not, this plug-in was not registered correctly.
                tracingService.Trace
                    ("AdvancedPlugin: Verifying that the target entity represents a contact.");
                if (entity.LogicalName != "contact")
                    return;

                tracingService.Trace("AdvancedPlugin: Creating the description.");
                String descriptionMessage = "Old full name: " +
                    image["fullname"] + " -- Unsecured: " + _unsecureString +
                    ", Secured: " + _secureString;

                tracingService.Trace
                    ("AdvancedPlugin: Checking if the target entity doesn't have a description attribute.");
                if (entity.Attributes.Contains("description") == false)
                {
                    tracingService.Trace
                        ("AdvancedPlugin: Adding a description attribute with the new value.");
                    entity.Attributes.Add("description", descriptionMessage);
                }
            }
        }
    }
}

// </snippetadvancedplugin>