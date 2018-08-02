// <snippetassignqueuetoteamde>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;
using System.Collections.Generic;


namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to assign a queue to a team.
    /// If you want to run this sample repeatedly, you have the option to 
    /// delete all the records created at the end of execution.
    /// </summary>
    public class AssignQueueToTeamDE
    {
        #region Class Level Members
        
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

        // Define the IDs needed for this sample.
        private Guid _teamId;
        private Guid _queueId;
        private Guid _roleId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Create a team, a queue and a role.
        /// Add read queue privileges to the role.
        /// Assign the role to the team so that they can read the queue.
        /// Assign the queue to the team.
        /// Optionally delete any entity records that were created for this sample.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptForDelete">When True, the user will be prompted to delete
        /// all created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig))
                {

                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    _service = (IOrganizationService)_serviceProxy;

                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();

                    // The queue ID would typically be passed in as an argument or determined by a query.
                    // The team ID would typically be passed in as an argument or determined by a query.
                    // Assign the queue to a team.
                    AssignRequest assignRequest = new AssignRequest()
                    {
                        Assignee = new EntityReference
                        {
                            LogicalName = "team",
                            Id = _teamId
                        },

                        Target = new EntityReference("queue", _queueId)
                    };

                    _service.Execute(assignRequest);

                    Console.WriteLine("The queue is owned by the team.");

                    DeleteRequiredRecords(promptForDelete);
                }
            }

            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
            {
                // You can handle an exception here or pass it back to the calling method.
                throw;
            }
        }

        /// <summary>
        /// This method creates any entity records that this sample requires.
        /// Create a team, a queue and a role.
        /// Add read queue privileges to the role.
        /// Assign the role to the team so that they can read the queue.
        /// Assign the queue to the team.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Instantiate a dynamic entity and set its property values.
            // See the Entity Metadata topic in the SDK documentatio to determine 
            // which attributes must be set for each entity.
            Entity setupQueue = new Entity("queue");
            setupQueue["name"] = "Example Queue";
            setupQueue["description"] = "This is an example queue.";

            // Create the queue record.
            _queueId = _service.Create(setupQueue);
            Console.WriteLine("Created {0}", setupQueue["name"]);

            // Retrieve the default business unit needed to create the team and role.
            QueryExpression queryDefaultBusinessUnit = new QueryExpression("businessunit");
            queryDefaultBusinessUnit.ColumnSet = new ColumnSet("businessunitid");
            queryDefaultBusinessUnit.Criteria = new FilterExpression();
            queryDefaultBusinessUnit.Criteria.AddCondition("parentbusinessunitid", ConditionOperator.Null);

            Entity defaultBusinessUnit = _service.RetrieveMultiple(queryDefaultBusinessUnit).Entities[0];

            // Instantiate a dynamic entity and set its property values.
            // See the Entity Metadata topic in the SDK documentatio to determine 
            // which attributes must be set for each entity.
            Entity setupTeam = new Entity("team");
            setupTeam["name"] = "Example Team";
            setupTeam["businessunitid"] = new EntityReference("businessunit",
                defaultBusinessUnit.Id);

            // Create a team record.
            _teamId = _service.Create(setupTeam);
            Console.WriteLine("Created {0}", setupTeam["name"]);

            // Instantiate a dynamic entity and set its property values.
            // See the Entity Metadata topic in the SDK documentatio to determine 
            // which attributes must be set for each entity.
            Entity setupRole = new Entity("role");
            setupRole["name"] = "Example Role";
            setupRole["businessunitid"] = new EntityReference("businessunit",
                defaultBusinessUnit.Id);

            // Create a role record. Typically you would use an exisitng role that has the
            // the correct privileges. For this sample we need to be sure the role has
            // at least the privilege to read queue records.
            _roleId = _service.Create(setupRole);
            Console.WriteLine("Created {0}", setupRole["name"]);

            // Create a query expression to find the prvReadQueue Privilege and prvReadMailbox Privilege.
            QueryExpression queryReadQueuePrivilege = new QueryExpression
            {
                EntityName = "privilege",
                ColumnSet = new ColumnSet("privilegeid", "name"),
                Criteria = new FilterExpression()
            };
            queryReadQueuePrivilege.Criteria.AddCondition("name", ConditionOperator.In, "prvReadQueue", "prvReadMailbox");

            // Retrieve the prvReadQueue privilege and prvReadMailbox Privilege.
            DataCollection<Entity> readQueuePrivilege = _serviceProxy.RetrieveMultiple(queryReadQueuePrivilege).Entities;
            Console.WriteLine("Retrieved {0}", readQueuePrivilege.Count);

            // Define a list to hold the RolePrivileges we'll need to add
            List<RolePrivilege> rolePrivileges = new List<RolePrivilege>();

            foreach (Privilege privilege in readQueuePrivilege)
            {
                RolePrivilege rolePrivilege = new RolePrivilege(
                    (int)PrivilegeDepth.Local, privilege.PrivilegeId.Value);
                rolePrivileges.Add(rolePrivilege);
            }

            // Add the prvReadQueue and prvReadMailbox privilege to the example role.
            AddPrivilegesRoleRequest addPrivilegesRequest = new AddPrivilegesRoleRequest
            {
                RoleId = _roleId,
                Privileges = rolePrivileges.ToArray()
            };
            _service.Execute(addPrivilegesRequest);
            Console.WriteLine("Added privilege to role");

            // Add the role to the team.
            AssociateRequest associate = new AssociateRequest()
            {
                Target = new EntityReference(Team.EntityLogicalName, _teamId),
                RelatedEntities = new EntityReferenceCollection()
                {
                    new EntityReference(Role.EntityLogicalName, _roleId)
                },
                Relationship = new Relationship("teamroles_association")
            };
            _service.Execute(associate);

            Console.WriteLine("Assigned team to role");

            // It takes some time for the privileges to propogate to the team. Delay the
            // application until the privilege has been assigned.
            bool teamLacksPrivilege = true;
            while (teamLacksPrivilege)
            {
                RetrieveTeamPrivilegesRequest retrieveTeamPrivilegesRequest = new RetrieveTeamPrivilegesRequest
                {
                    TeamId = _teamId
                };

                RetrieveTeamPrivilegesResponse retrieveTeamPrivilegesResponse =
                    (RetrieveTeamPrivilegesResponse)_service.Execute(retrieveTeamPrivilegesRequest);

                foreach (Microsoft.Crm.Sdk.Messages.RolePrivilege rp in retrieveTeamPrivilegesResponse.RolePrivileges)
                {
                    if (retrieveTeamPrivilegesResponse.RolePrivileges[0].PrivilegeId == readQueuePrivilege[0].Id && retrieveTeamPrivilegesResponse.RolePrivileges[1].PrivilegeId == readQueuePrivilege[1].Id)
                    {
                        teamLacksPrivilege = false;
                        break;
                    }
                    else
                    {
                        System.Threading.Thread.CurrentThread.Join(500);
                    }
                }
            }

            return;
        }
        
        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
            }

            if (deleteRecords)
            {
                _service.Delete("queue", _queueId);
                _service.Delete("team", _teamId);
                _service.Delete("role", _roleId);

                Console.WriteLine("Entity records have been deleted.");
            }
        }

        #endregion How To Sample Code

        #region Main
        /// <summary>
        /// Standard Main() method used by most SDK samples.
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            try
            {
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                AssignQueueToTeamDE app = new AssignQueueToTeamDE();
                app.Run(config, true);
            }
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
            }
            catch (System.TimeoutException ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.InnerException.Message ? "No Inner Fault" : ex.InnerException.Message);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine(ex.Message);

                // Display the details of the inner exception.
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe = ex.InnerException
                        as FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>;
                    if (fe != null)
                    {
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp);
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode);
                        Console.WriteLine("Message: {0}", fe.Detail.Message);
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText);
                        Console.WriteLine("Inner Fault: {0}",
                            null == fe.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
                    }
                }
            }
            // Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            // SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            finally
            {
                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }

        }
        #endregion Main

    }
}

// </snippetassignqueuetoteamde>