// <snippetassignrecordtoteam>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;


using Microsoft.Xrm.Sdk.Client;
using Microsoft.Crm.Sdk.Messages;



namespace Microsoft.Crm.Sdk.Samples
{

    /// <summary>
    /// Demonstrates how to assign a record to a team.
    /// If you want to run this sample repeatedly, you have the option to 
    /// delete all the records created at the end of execution.
    /// </summary>
    public class AssignRecordToTeam
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service interface.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

        // Define the IDs needed for this sample.
        public Guid _accountId;
        public Guid _teamId;        
        public Guid _roleId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Create a team, an account and a role.
        /// Add read account privileges to the role.
        /// Assign the role to the team so that they can read the account.
        /// Assign the account to the team.
        /// Optionally delete the account, team and role records.
        /// <para name="organizationFriendlyName">The friendly name of 
        /// the target organization.</para>
        /// <para name="discoveryServer">The name of the discovery server.</para>
        /// <param name="promptForDelete">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                                     serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    _service = (IOrganizationService)_serviceProxy;

                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();

                    // Assign the account to a team.                
                    AssignRequest assignRequest = new AssignRequest()
                    {
                        Assignee = new EntityReference
                        {
                            LogicalName = Team.EntityLogicalName,
                            Id = _teamId
                        },

                        Target = new EntityReference(Account.EntityLogicalName, _accountId)
                    };

                    _service.Execute(assignRequest);

                    Console.WriteLine("The account is owned by the team.");

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
        /// Create a team, an account and a role.
        /// Add read account privileges to the role.
        /// Assign the role to the team so that they can read the account.
        /// Assign the account to the team.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Instantiate an account entity record and set its property values.
            // See the Entity Metadata topic in the SDK documentation to determine 
            // which attributes must be set for each entity.
            Account setupAccount = new Account
            {
                Name = "Example Account"
            };

            // Create the account record.
            _accountId = _service.Create(setupAccount);
            Console.WriteLine("Created {0}", setupAccount.Name);

            // Retrieve the default business unit needed to create the team and role.
            QueryExpression queryDefaultBusinessUnit = new QueryExpression
            {
                EntityName = BusinessUnit.EntityLogicalName,
                ColumnSet = new ColumnSet("businessunitid" ),
                Criteria = new FilterExpression()
            };

            queryDefaultBusinessUnit.Criteria.AddCondition("parentbusinessunitid", 
                ConditionOperator.Null);

            BusinessUnit defaultBusinessUnit = (BusinessUnit)_service.RetrieveMultiple(
                queryDefaultBusinessUnit).Entities[0];

            // Instantiate a team entity record and set its property values.
            // See the Entity Metadata topic in the SDK documentation to determine 
            // which attributes must be set for each entity.
            Team setupTeam = new Team
            {
                Name = "Example Team",
                BusinessUnitId = new EntityReference(BusinessUnit.EntityLogicalName,
                    defaultBusinessUnit.Id)
            };

            // Create a team record.
            _teamId = _service.Create(setupTeam);
            Console.WriteLine("Created {0}", setupTeam.Name);

            // Instantiate a role entity record and set its property values.
            // See the Entity Metadata topic in the SDK documentation to determine 
            // which attributes must be set for each entity.
            Role setupRole = new Role
            {
                Name = "Example Role",
                BusinessUnitId = new EntityReference(BusinessUnit.EntityLogicalName,
                    defaultBusinessUnit.Id)
            };

            // Create a role record. Typically you would use an existing role that has the
            // the correct privileges. For this sample we need to be sure the role has
            // at least the privilege to read account records.
            _roleId = _service.Create(setupRole);
            Console.WriteLine("Created {0}", setupRole.Name);

            // Create a query expression to find the prvReadAccountPrivilege.
            QueryExpression queryReadAccountPrivilege = new QueryExpression
            {
                EntityName = Privilege.EntityLogicalName,
                ColumnSet = new ColumnSet("privilegeid", "name"),
                Criteria = new FilterExpression()
            };
            queryReadAccountPrivilege.Criteria.AddCondition("name", 
                ConditionOperator.Equal, "prvReadAccount");

            // Retrieve the prvReadAccount privilege.
            Entity readAccountPrivilege = _service.RetrieveMultiple(
                queryReadAccountPrivilege)[0];
            Console.WriteLine("Retrieved {0}", readAccountPrivilege.Attributes["name"]);

            // Add the prvReadAccount privilege to the example roles to assure the
            // team can read accounts.
            AddPrivilegesRoleRequest addPrivilegesRequest = new AddPrivilegesRoleRequest
            {
                RoleId = _roleId,
                Privileges = new[] 
                {
                    // Grant prvReadAccount privilege.
                    new RolePrivilege
                    { 
                        PrivilegeId = readAccountPrivilege.Id 
                    }
                }
            };
            _service.Execute(addPrivilegesRequest);

            Console.WriteLine("Added privilege to role");

            // Add the role to the team.
            _service.Associate(
                       Team.EntityLogicalName,
                       _teamId,
                       new Relationship("teamroles_association"),
                       new EntityReferenceCollection() { new EntityReference(Role.EntityLogicalName, _roleId) });

            Console.WriteLine("Assigned team to role");

            // It takes some time for the privileges to propagate to the team. Delay the
            // application until the privilege has been assigned.
            bool teamLacksPrivilege = true;
            while (teamLacksPrivilege)
            {
                RetrieveTeamPrivilegesRequest retrieveTeamPrivilegesRequest = 
                    new RetrieveTeamPrivilegesRequest
                {
                    TeamId = _teamId
                };

                RetrieveTeamPrivilegesResponse retrieveTeamPrivilegesResponse =
                    (RetrieveTeamPrivilegesResponse)_service.Execute(
                    retrieveTeamPrivilegesRequest);

                foreach (RolePrivilege rp in 
                    retrieveTeamPrivilegesResponse.RolePrivileges)
                {
                    if (rp.PrivilegeId == readAccountPrivilege.Id)
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
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
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
                _service.Delete("account", _accountId);
                _service.Delete("team", _teamId);
                _service.Delete("role", _roleId);


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
                
                AssignRecordToTeam app = new AssignRecordToTeam();
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

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe = 
                        ex.InnerException
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
            finally
            {
                
                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }

        }
        #endregion Main

    }
}

// </snippetassignrecordtoteam>