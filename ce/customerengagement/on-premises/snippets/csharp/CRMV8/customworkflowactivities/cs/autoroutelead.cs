// <snippetautoroutelead>


using System;
using System.Activities;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
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
    /// Assigns the lead to the user with the fewest lead records assigned.
    /// Input arguments:
    ///   "Lead". Type: EntityReference. Is the lead entity.
    /// Output argument:
    ///   None.
    /// </summary>
    public sealed partial class AutoRouteLead : CodeActivity
    {
        /// <summary>
        /// This method first retrieves the lead. Afterwards, it checks the value of
        /// the new_autoroute field, and if it is True, it retrieves all the users 
        /// with 'Customer Service Representative' role, and assigns this lead to
        /// the user with the fewest lead records assigned.
        /// </summary>
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = 
                executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = 
                serviceFactory.CreateOrganizationService(context.UserId);

            #region Retrieve the lead
            
            // Get the lead ID
            Guid leadId = this.lead_input.Get(executionContext).Id;
            
            //Request for Entity
            RetrieveRequest request = new RetrieveRequest();
            request.ColumnSet = new ColumnSet(true);
            request.Target = new EntityReference("lead", leadId);
            
            //Execute request
            Entity targetRequest = 
                (Entity)((RetrieveResponse)service.Execute(request)).Entity;

            #endregion Retrieve the lead

            bool autoroute = false;
            autoroute = (bool)targetRequest.Attributes["new_autoroute"];

            if (autoroute)
            {
                // Get user's BusinessUnit
                RetrieveRequest userrequest = new RetrieveRequest();
                userrequest.ColumnSet = new ColumnSet("businessunitid");
                userrequest.Target = new EntityReference("systemuser", context.UserId);

                Entity userEntity = 
                    (Entity)((RetrieveResponse)service.Execute(userrequest)).Entity;
                EntityReference bu = (EntityReference)userEntity["businessunitid"];
                
                // Get roleid for 'Customer Service Representative' with that BU
                QueryExpression queryRole = new QueryExpression();
                queryRole.ColumnSet = new ColumnSet("roleid");
                queryRole.EntityName = "role";
                queryRole.Criteria.AddCondition(new ConditionExpression
                {
                    AttributeName = "name",
                    Operator = ConditionOperator.Equal,
                    Values = { "Customer Service Representative" }
                });
                queryRole.Criteria.AddCondition(new ConditionExpression
                {
                    AttributeName = "businessunitid",
                    Operator = ConditionOperator.Equal,
                    Values = { bu.Id }
                });

                var roles = service.RetrieveMultiple(queryRole);

                if (roles.Entities.Count > 0)
                {
                    Guid roleId = (Guid)roles.Entities[0]["roleid"];

                    // Create the query to get all the users with that role
                    QueryExpression queryUsers = new QueryExpression();

                    // Set the properties of the query.
                    queryUsers.EntityName = "systemuserroles";
                    queryUsers.ColumnSet = new ColumnSet("systemuserid");
                    queryUsers.Criteria.AddCondition
                        ("roleid", ConditionOperator.Equal, roleId);

                    // Get the list of users.
                    var users = service.RetrieveMultiple(queryUsers);

                    if (users.Entities.Count > 0)
                    {
                        #region Get User with lowest number of leads assigned

                        // Initialize variables
                        int lowLeadCount = -1;
                        int currentLeadCount = 0;
                        Guid lowUserId = new Guid();

                        // Create the query to find out how many leads 
                        // each retrieved user has
                        QueryExpression queryUsersLeads = new QueryExpression();

                        // Set the properties of the query.
                        queryUsersLeads.EntityName = "lead";
                        queryUsersLeads.ColumnSet = new ColumnSet("leadid", "ownerid");
                        
                        foreach (var user in users.Entities)
                        {
                            queryUsersLeads.Criteria.AddCondition
                                ("ownerid", ConditionOperator.Equal, user["systemuserid"]);
                            EntityCollection currentUserLeads = 
                                service.RetrieveMultiple(queryUsersLeads);
                            currentLeadCount = currentUserLeads.Entities.Count;

                            // If is the first time or the number of leads is lowest, 
                            // the current User is marked lowest.
                            if ((lowLeadCount == -1) || (currentLeadCount < lowLeadCount))
                            {
                                lowLeadCount = currentLeadCount;
                                lowUserId = (Guid)user["systemuserid"];
                            }
                            
                        }
                        #endregion Get User with Lowest Number of leads assigned

                        #region Assign new lead to identified user

                        // Assign the lead to the user 
                        // with the fewest lead records assigned
                        AssignRequest assignRequest = new AssignRequest()
                        {
                            Target = new EntityReference("lead", leadId),
                            Assignee = new EntityReference("systemuser", lowUserId)
                        };
                        service.Execute(assignRequest);
                        
                        #endregion Assign new lead to identified user
                    }
                }
            }
        }
        
        [RequiredArgument]
        [Input("Lead")]
        [ReferenceTarget("lead")]
        public InArgument<EntityReference> lead_input { get; set; }
    }
}

// </snippetautoroutelead>