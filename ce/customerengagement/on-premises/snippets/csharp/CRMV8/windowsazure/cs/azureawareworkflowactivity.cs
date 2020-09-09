// <snippetazureawareworkflowactivity>


// This namespace is found in the System.Activities.dll assembly.
using System.Activities;

// This namespace is found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;

// This namespace is found in the Microsoft.Xrm.Sdk.Workflow.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk.Workflow;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This class is able to post the execution context to the Windows Azure 
    /// Service Bus.
    /// </summary>
    public class AzureAwareWorkflowActivity : CodeActivity
    {
        /// <summary>
        /// This method is called when the workflow executes.
        /// </summary>
        /// <param name="executionContext">The data for the event triggering
        /// the workflow.</param>
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();

            IServiceEndpointNotificationService endpointService =
                     executionContext.GetExtension<IServiceEndpointNotificationService>();
            endpointService.Execute(ServiceEndpoint.Get(executionContext), context);
        }

        /// <summary>
        /// Enables the service endpoint to be provided when this activity is added as a 
        /// step in a workflow.
        /// </summary>
        [RequiredArgument]
        [ReferenceTarget("serviceendpoint")]
        [Input("Input id")]
        public InArgument<EntityReference> ServiceEndpoint { get; set; }
    }
}

// </snippetazureawareworkflowactivity>