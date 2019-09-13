// <snippetcustomactivity>


using System;
using System.Activities;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;

// These namespaces are found in the Microsoft.Xrm.Sdk.Workflow.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk.Workflow;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Creates a task with a subject equal to the ID of the input entity.
    /// Input arguments:
    ///   "Input Entity". Type: EntityReference. Is the account entity.
    /// Output argument:
    ///   "Task Created". Type: EntityReference. Is the task created.
    /// </summary>
    public sealed partial class CustomActivity : CodeActivity
    {
        /// <summary>
        /// Creates a task with a subject equal to the ID of the input EntityReference
        /// </summary>
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory =
                executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service =
                serviceFactory.CreateOrganizationService(context.UserId);

            // Retrieve the id
            Guid accountId = this.inputEntity.Get(executionContext).Id;
            
            // Create a task entity
            Entity task = new Entity();
            task.LogicalName = "task";
            task["subject"] = accountId.ToString();
            task["regardingobjectid"] = new EntityReference("account", accountId);
            Guid taskId = service.Create(task);
            this.taskCreated.Set(executionContext, 
                new EntityReference("task", taskId));
        }

        // Define Input/Output Arguments
        [RequiredArgument]
        [Input("InputEntity")]
        [ReferenceTarget("account")]
        public InArgument<EntityReference> inputEntity { get; set; }

        [Output("TaskCreated")]
        [ReferenceTarget("task")]
        public OutArgument<EntityReference> taskCreated { get; set; }
    }
}

// </snippetcustomactivity>