// <snippetsharequeue>


using System;
using System.Linq;
using System.Threading;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Collections.Generic;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Client;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This Sample shows how to share a queue to the team.
    /// </summary>
	public class ShareQueue
	{

        #region Class Level Members
        

        // Define the IDs needed for this sample.
        private Guid _queueId;
        private Guid _teamId;
        private Guid _roleId;
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Initiate the method to create any data that this sample requires.
        /// Share a queue to the team.
        /// Optionally delete any entity records that were created for this sample.
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        /// </summary>

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

                    CreateRequiredRecords();


                    // Grant the team Read and AppendTo access to the queue.  
                    // Having Read and AppendTo privileges gives a team a full access 
                    // to the queue items, but only read access to the queue. For 
                    // example, team members can’t change the queue name, but they 
                    // can make any modifications to the queue items.
                    GrantAccessRequest grantAccessRequest = new GrantAccessRequest
                    {
                        PrincipalAccess = new PrincipalAccess
                        {
                            Principal = new EntityReference(Team.EntityLogicalName, _teamId),
                            AccessMask = AccessRights.ReadAccess
                            | AccessRights.AppendToAccess
                        },
                        Target = new EntityReference(Queue.EntityLogicalName, _queueId)
                    };

                    _serviceProxy.Execute(grantAccessRequest);


                    Console.WriteLine("Queue has been shared to the team.");

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
        /// Create a queue record.
        /// Create a team record.
        /// Create a role and add queue privileges.
        /// Assign role to team.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Create a queue instance and set its property values.
            Queue newQueue = new Queue
            {
                Name = "Example Queue",
                Description = "This is an example queue."
            };

            // Create a new queue and store its returned GUID in a variable for later use.
            _queueId = _serviceProxy.Create(newQueue);
            Console.WriteLine("Created {0}", newQueue.Name);

            // Retrieve the default business unit for the creation of the team and role.
            QueryExpression queryDefaultBusinessUnit = new QueryExpression
            {
                EntityName = BusinessUnit.EntityLogicalName,
                ColumnSet = new ColumnSet("businessunitid"),
                Criteria = new FilterExpression
                {
                    Conditions = 
                        {
                            new ConditionExpression 
                            { 
                                AttributeName = "parentbusinessunitid", 
                                Operator = ConditionOperator.Null 
                            }
                        }
                }
            };

            BusinessUnit defaultBusinessUnit = 
                (BusinessUnit)_serviceProxy.RetrieveMultiple(
                queryDefaultBusinessUnit).Entities[0];

            // Create a new example team.
            Team setupTeam = new Team
            {
                Name = "Example Team",
                BusinessUnitId = new EntityReference(BusinessUnit.EntityLogicalName, 
                    defaultBusinessUnit.BusinessUnitId.Value)
            };

            _teamId = _serviceProxy.Create(setupTeam);
            Console.WriteLine("Created {0}", setupTeam.Name);

            // Create a new example role.
            Role setupRole = new Role
            {
                Name = "Example Role",
                BusinessUnitId = new EntityReference(BusinessUnit.EntityLogicalName, 
                    defaultBusinessUnit.BusinessUnitId.Value)
            };
            
            _roleId = _serviceProxy.Create(setupRole);
            Console.WriteLine("Created {0}", setupRole.Name);

            // Retrieve the prvReadQueue and prvAppendToQueue privileges.
            QueryExpression queryQueuePrivileges = new QueryExpression
            {
                EntityName = Privilege.EntityLogicalName,
                ColumnSet = new ColumnSet("privilegeid", "name"),
                Criteria = new FilterExpression
                {
                    Conditions = 
                        {
                            new ConditionExpression
                            { 
                                AttributeName = "name", 
                                Operator = ConditionOperator.In,
                                Values = { "prvReadQueue", "prvAppendToQueue" }
                            }
                        }
                }
            };
                 
            DataCollection<Entity> retrievedQueuePrivileges = 
                _serviceProxy.RetrieveMultiple(queryQueuePrivileges).Entities;

            Console.WriteLine("Retrieved prvReadQueue and prvAppendToQueue privileges.");

            // Define a list to hold the RolePrivileges we'll need to add
            List<RolePrivilege> rolePrivileges = new List<RolePrivilege>();

            foreach (Privilege privilege in retrievedQueuePrivileges)
            {
                RolePrivilege rolePrivilege = new RolePrivilege(
                    (int)PrivilegeDepth.Local, privilege.PrivilegeId.Value);
                rolePrivileges.Add(rolePrivilege);
            }

            // Add the prvReadQueue and prvAppendToQueue privileges to the example role.
            AddPrivilegesRoleRequest addPrivilegesRequest = new AddPrivilegesRoleRequest
            {
                RoleId = _roleId,
                Privileges = rolePrivileges.ToArray()
            };
            _serviceProxy.Execute(addPrivilegesRequest);
            Console.WriteLine("Retrieved privileges are added to {0}.", setupRole.Name);


            // Add the example role to the example team.
            _serviceProxy.Associate(
                       Team.EntityLogicalName,
                       _teamId,
                       new Relationship("teamroles_association"),
                       new EntityReferenceCollection() { new EntityReference(Role.EntityLogicalName, _roleId) });
            
            // It takes some time for the privileges to propogate to the team.  
            // Verify this is complete before continuing.

            bool teamLacksPrivilege = true;
            while (teamLacksPrivilege)
            {
                RetrieveTeamPrivilegesRequest retrieveTeamPrivilegesRequest =
                    new RetrieveTeamPrivilegesRequest
                {
                    TeamId = _teamId
                };

                RetrieveTeamPrivilegesResponse retrieveTeamPrivilegesResponse =
                    (RetrieveTeamPrivilegesResponse)_serviceProxy.Execute(
                    retrieveTeamPrivilegesRequest);

                if (retrieveTeamPrivilegesResponse.RolePrivileges.Any(
                    rp => rp.PrivilegeId == rolePrivileges[0].PrivilegeId) &&
                    retrieveTeamPrivilegesResponse.RolePrivileges.Any(
                    rp => rp.PrivilegeId == rolePrivileges[1].PrivilegeId))
                {
                    teamLacksPrivilege = false;
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }

            Console.WriteLine("{0} has been added to {1}",
               setupRole.Name, setupTeam.Name);
            return;
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to 
        /// delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                _serviceProxy.Delete(Queue.EntityLogicalName, _queueId);
                _serviceProxy.Delete(Team.EntityLogicalName, _teamId);
                _serviceProxy.Delete(Role.EntityLogicalName, _roleId);

                Console.WriteLine("Entity records have been deleted.");
            }
        }        
        #endregion How To Sample Code

        #region Main
        /// <summary>
        /// Main. Runs the sample and provides error output.
        /// <param name="args">Array of arguments to Main method.</param>
        /// </summary>
        static public void Main(string[] args)
        {
            try
            {
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                ShareQueue  app = new ShareQueue();
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

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe 
                        = ex.InnerException 
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

// </snippetsharequeue>