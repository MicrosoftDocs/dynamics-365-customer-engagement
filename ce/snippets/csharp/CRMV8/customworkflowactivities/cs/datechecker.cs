// <snippetdatechecker>


using System;
using System.Activities;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

// These namespaces are found in the Microsoft.Xrm.Sdk.Workflow.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk.Workflow;

// These namespaces are found in the Microsoft.Crm.Sdk.Proxy.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Checks if the "Est. Close Date" is greater than 10 days. If it is,
    /// send an email to the administrator so that s/he can verify close date
    /// with the owner of the opportunity.
    /// Input arguments:
    ///   "Opportunity". Type: EntityReference. Is the opportunity entity.
    /// Output argument:
    ///   None.
    /// </summary>
    public sealed partial class DateChecker : CodeActivity
    {
        /// <summary>
        /// Checks if the "Est. Close Date" is greater than 10 days. If it is,
        /// send an email to the administrator so that s/he can verify close date
        /// with the owner of the opportunity.
        /// </summary>
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
                IOrganizationServiceFactory serviceFactory =
                    executionContext.GetExtension<IOrganizationServiceFactory>();
                IOrganizationService service =
                    serviceFactory.CreateOrganizationService(context.UserId);

            // Get opportunity entity
            Entity opportunity = service.Retrieve("opportunity", 
                this.inputOpportunity.Get(executionContext).Id, new ColumnSet("estimatedclosedate"));

            // Calulate 10 days from today
            DateTime todayPlusTen = DateTime.UtcNow.AddDays(10.0);

            // Check "Est. Close Date"
            if (opportunity.Contains("estimatedclosedate"))
            {
                DateTime estCloseDate = (DateTime)opportunity["estimatedclosedate"];
                if (DateTime.Compare(estCloseDate, todayPlusTen) > 0)
                {
                    // Need system user id for activity party
                    WhoAmIRequest systemUserRequest = new WhoAmIRequest();
                    WhoAmIResponse systemUser = 
                        (WhoAmIResponse)service.Execute(systemUserRequest);

                    // Create an activity party for the email
                    Entity[] activityParty = new Entity[1];
                    activityParty[0] = new Entity("activityparty");
                    activityParty[0]["partyid"] = 
                        new EntityReference("systemuser", systemUser.UserId);

                    // Create an email message
                    Entity email = new Entity("email");
                    email.LogicalName = "email";
                    email["subject"] = 
                        "Warning: Close date has been extended more than 10 days.";
                    email["description"] = "Verify close date is correct.";
                    email["to"] = activityParty;
                    email["from"] = activityParty;
                    email["regardingobjectid"] = opportunity.ToEntityReference();
                    Guid emailId = service.Create(email);

                    // Send email
                    SendEmailRequest sendEmailRequest = new SendEmailRequest();
                    sendEmailRequest.EmailId = emailId;
                    sendEmailRequest.IssueSend = true;
                    sendEmailRequest.TrackingToken = "";
                    SendEmailResponse sendEmailResponse = 
                        (SendEmailResponse)service.Execute(sendEmailRequest);
                }
            }
        }

        // Define Input/Output Arguments
        [RequiredArgument]
        [Input("Opportunity")]
        [ReferenceTarget("opportunity")]
        public InArgument<EntityReference> inputOpportunity { get; set; }
    }
}

// </snippetdatechecker>