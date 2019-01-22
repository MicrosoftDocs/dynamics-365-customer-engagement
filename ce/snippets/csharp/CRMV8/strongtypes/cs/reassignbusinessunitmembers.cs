// <snippetreassignbusinessunitmembers>


using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to use the ReassignObjectsOwnerRequest and
    /// ReassignObjectsSystemUserRequest objects, as well as how to reassign
    /// business unit members and teams to other business units and teams and
    /// then delete those business units and teams.
    /// </summary>
    /// <param name="serverConfig">Contains server connection information.</param>
    /// <param name="promptforDelete">When True, the user will be prompted to delete all
    /// created entities.</param>
    public class ReassignBusinessUnitMembers
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;
        private ServiceContext _context;

        private List<Guid> _users;
        private Team _team;
        private Lead[] _leads = new Lead[4];
        private BusinessUnit _businessUnit;
        private BusinessUnit _rootBusinessUnit;
        private List<Guid> _originalRolesIds;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first creates 3 users, a team, 4 leads and a business unit. 
        /// It assigns two users to the team, and gives each user and the team a lead. 
        /// Then it reassigns all the leads from one of the users to another user using 
        /// the ReassignObjectsSystemUserRequest. Next, it reassigns all the leads from
        /// the team to a user using the ReassignObjectsOwnerRequest. Third, it reassigns
        /// one user from the root business unit to the created business unit, using the
        /// SetBusinessSystemUserRequest message. Fourth, it reassigns all users from 
        /// the created business unit to the root business unit and deletes the created 
        /// business unit. Finally, it removes all users from the created team and 
        /// deletes the team.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>

        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly 
                // disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                // Using the ServiceContext class provides access to the LINQ provider
                using (_context = new ServiceContext(_serviceProxy))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();

                    Console.WriteLine();
                    PrintLeads();

                    var users = from user in _context.SystemUserSet
                                    select new { user.FullName, user.Id };
                    Dictionary<Guid, String> userMapping = new Dictionary<Guid,String>();
                    foreach (var user in users)
                        userMapping.Add(user.Id, user.FullName);

                    #region ReassignObjectsSystemUserRequest
                    
                    // create the request
                    ReassignObjectsSystemUserRequest reassignRequest = 
                        new ReassignObjectsSystemUserRequest()
                    {
                        ReassignPrincipal = 
                            new EntityReference(SystemUser.EntityLogicalName, _users[1]),
                        UserId = _users[2]
                    };

                    // execute the request
                    Console.WriteLine();
                    Console.WriteLine(
                        "  Reassigning leads from {0} to {1}", 
                        userMapping[_users[2]],
                        userMapping[_users[1]]);
                    _serviceProxy.Execute(reassignRequest);
                    
                    // check results
                    PrintLeads();

                    #endregion

                    #region ReassignObjectsOwnerRequest

                    // create the request
                    ReassignObjectsOwnerRequest request = 
                        new ReassignObjectsOwnerRequest()
                    {
                        FromPrincipal = _team.ToEntityReference(),
                        ToPrincipal = 
                            new EntityReference(SystemUser.EntityLogicalName, _users[0])
                    };

                    // execute the request
                    Console.WriteLine();
                    Console.WriteLine(
                        "  Reassigning leads from {0} to {1}", 
                        _team.Name, userMapping[_users[0]]);
                    _serviceProxy.Execute(request);

                    // check results
                    PrintLeads();

                    #endregion

                    #region reassign business unit members

                    Console.WriteLine();
                    Console.WriteLine("  Adding a user to the created business unit");
                    // track what permissions the user had before reassigning to the new
                    // business unit so that the permissions can be restored when the
                    // user is assigned back to the business unit
                    _originalRolesIds = new List<Guid>();
                    var roleIds = from user in _context.SystemUserSet
                                  join systemuserrole in _context.SystemUserRolesSet 
                                    on user.SystemUserId equals systemuserrole.SystemUserId
                                  join role in _context.RoleSet 
                                    on systemuserrole.RoleId equals role.RoleId
                                  where user.SystemUserId.Value == _users[2]
                                  select role.RoleId.Value;

                    foreach (var roleId in roleIds)
                        _originalRolesIds.Add(roleId);

                    // add user to the created business unit
                    _serviceProxy.Execute(new SetBusinessSystemUserRequest()
                    {
                        BusinessId = _businessUnit.Id,
                        ReassignPrincipal = new EntityReference(
                            SystemUser.EntityLogicalName,
                            _users[2]),
                        UserId = _users[2]
                    });

                    #endregion

                    #region delete business unit

                    Console.WriteLine();
                    Console.WriteLine("  Deleting created business unit");

                    // remove all users from the business unit, moving them back to the
                    // parent business unit
                    _serviceProxy.Execute(new SetBusinessSystemUserRequest()
                    {
                        BusinessId = _rootBusinessUnit.Id,
                        ReassignPrincipal = new EntityReference(
                            SystemUser.EntityLogicalName, _users[2]),
                        UserId = _users[2]
                    });

                    // give the user back their original security roles
                    foreach (var roleId in roleIds)
                    {
                        _serviceProxy.Associate(
                             SystemUser.EntityLogicalName,
                             _users[2],
                             new Relationship("systemuserroles_association"),
                             new EntityReferenceCollection() { 
                                new EntityReference(
                                    Role.EntityLogicalName,
                                    roleId
                                )
                            }
                         );
                    }

                    // deactivate business unit before deleting it
                    _serviceProxy.Execute(new SetStateRequest()
                    {
                        EntityMoniker = _businessUnit.ToEntityReference(),
                        // mark the state as inactive (value 1)
                        State = new OptionSetValue(1),
                        Status = new OptionSetValue(-1)
                    });

                    // delete business unit
                    _serviceProxy.Delete(BusinessUnit.EntityLogicalName,
                        _businessUnit.Id);

                    #endregion

                    #region remove users from team

                    var teamMembers = from team in _context.TeamSet
                                      join membership in _context.TeamMembershipSet
                                      on team.TeamId equals membership.TeamId
                                      where team.TeamId == _team.Id
                                      select membership.SystemUserId.Value;

                    _serviceProxy.Execute(new RemoveMembersTeamRequest()
                    {
                        MemberIds = teamMembers.ToArray(),
                        TeamId = _team.Id
                    });

                    #endregion

                    #region delete team

                    Console.WriteLine();
                    Console.WriteLine("  Deleting the team");

                    // Delete the team
                    _serviceProxy.Delete(Team.EntityLogicalName, _team.Id);

                    #endregion

                    DeleteRequiredRecords(promptforDelete);
                }
           }

            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
            {
                // You can handle an exception here or pass it back to the calling method.
                throw;
            }
        }

        private void PrintLeads()
        {
            Console.WriteLine("  Fetching leads from CRM");
            var leads = from lead in _context.LeadSet
                        join user in _context.SystemUserSet 
                          on lead.OwningUser.Id equals user.Id
                        select new
                        {
                            LeadName = lead.FullName,
                            OwningUserName = user.FullName
                        };
            foreach (var lead in leads)
                Console.WriteLine(
                    "  Lead {0} is owned by user {1}", 
                    lead.LeadName, 
                    lead.OwningUserName);
            leads = from lead in _context.LeadSet
                    join team in _context.TeamSet 
                      on lead.OwnerId.Id equals team.Id
                    select new
                    {
                        LeadName = lead.FullName,
                        OwningUserName = team.Name
                    };
            foreach (var lead in leads)
                Console.WriteLine(
                    "  Lead {0} is owned by user {1}", 
                    lead.LeadName, 
                    lead.OwningUserName);
        }

        #region Public methods

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            #region create users

            Console.WriteLine("  Creating users");
            var ldapPath = "";
            _users = 
                SystemUserProvider.RetrieveSalespersons(_serviceProxy, ref ldapPath);
            _users.Add(SystemUserProvider.RetrieveSystemUser(
                "dparker", "Darren", "Parker", "Salesperson", 
                _serviceProxy, ref ldapPath));

            #endregion

            #region fetch root business unit

            // Retrieve the root business unit to use for creating the team for the
            // sample.
            var businessUnitQuery = new QueryExpression
            {
                EntityName = BusinessUnit.EntityLogicalName,
                ColumnSet = new ColumnSet("businessunitid"),
                Criteria = new FilterExpression()
            };

            businessUnitQuery.Criteria.AddCondition("parentbusinessunitid",
                ConditionOperator.Null);
            var businessUnitResult = _serviceProxy.RetrieveMultiple(businessUnitQuery);
            _rootBusinessUnit = businessUnitResult.Entities[0].ToEntity<BusinessUnit>();

            #endregion

            #region create new business unit

            Console.WriteLine("  Creating new business unit");
            _businessUnit = new BusinessUnit()
            {
                Name = "A Sample Business Unit",
                ParentBusinessUnitId = _rootBusinessUnit.ToEntityReference()
            };
            _businessUnit.Id = _serviceProxy.Create(_businessUnit);

            #endregion

            #region create team

            Console.WriteLine("  Creating a user team");
            _team = new Team
            {
                AdministratorId = 
                    new EntityReference(SystemUser.EntityLogicalName, _users[0]),
                Name = "Sample team",
                BusinessUnitId = _rootBusinessUnit.ToEntityReference()
            };
            _team.Id = _serviceProxy.Create(_team);

            var salespersonRole = (from role in _context.RoleSet
                                   where role.Name == "Salesperson" 
                                   && role.BusinessUnitId.Id == _rootBusinessUnit.Id
                                   select role).First();

            // assign role to the team
            _serviceProxy.Associate(
                Team.EntityLogicalName,
                _team.Id,
                new Relationship("teamroles_association"),
                new EntityReferenceCollection() { 
                    salespersonRole.ToEntityReference()
                }
            );

            // wait for the async job to finish
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("  Checking to see if the async job has finished {0}/30", i);
                var teamPrivileges = (RetrieveTeamPrivilegesResponse)
                    _serviceProxy.Execute(new RetrieveTeamPrivilegesRequest
                    {
                        TeamId = _team.Id
                    });
                if (teamPrivileges.RolePrivileges.Any((rp) =>
                    rp.PrivilegeId == 
                        new Guid("A8ECAC53-09E8-4A13-B598-8D8C87BC3D33"))) // prvReadLead
                {
                    break;
                }
                System.Threading.Thread.Sleep(1000);
            }
            #endregion

            #region add users to team

            Console.WriteLine("  Adding users to the team");
            AddMembersTeamRequest addMembers = new AddMembersTeamRequest()
            {
                TeamId = _team.Id,
                MemberIds = new Guid[] { _users[0], _users[1] }
            };
            _serviceProxy.Execute(addMembers);

            #endregion

            #region create leads

            Console.WriteLine("  Creating leads");
            _leads[0] = new Lead
            {
                CompanyName = "A. Datum Corporation",
                FirstName = "Joe",
                LastName = "Andreshak",
            };
            _leads[0].Id = _serviceProxy.Create(_leads[0]);

            _leads[1] = new Lead
            {
                CompanyName = "Wingtip Toys",
                FirstName = "Diogo",
                LastName = "Andrade"
            };
            _leads[1].Id = _serviceProxy.Create(_leads[1]);

            _leads[2] = new Lead
            {
                CompanyName = "The Phone Company",
                FirstName = "Ronaldo",
                LastName = "Smith Jr."
            };
            _leads[2].Id = _serviceProxy.Create(_leads[2]);

            _leads[3] = new Lead
            {
                CompanyName = "Tailspin Toys",
                FirstName = "Andrew",
                LastName = "Sullivan",
            };
            _leads[3].Id = _serviceProxy.Create(_leads[3]);

            #endregion

            #region assign leads

            Console.WriteLine("  Assigning leads to users and teams");
            _serviceProxy.Execute(new AssignRequest()
            {
                Assignee = new EntityReference(SystemUser.EntityLogicalName, _users[0]),
                Target = _leads[0].ToEntityReference()
            });

            _serviceProxy.Execute(new AssignRequest()
            {
                Assignee = new EntityReference(SystemUser.EntityLogicalName, _users[1]),
                Target = _leads[1].ToEntityReference()
            });

            _serviceProxy.Execute(new AssignRequest()
            {
                Assignee = new EntityReference(SystemUser.EntityLogicalName, _users[2]),
                Target = _leads[2].ToEntityReference()
            });

            // give the team access to the record so that it can be assigned to it
            _serviceProxy.Execute(new GrantAccessRequest()
            {
                Target = _leads[3].ToEntityReference(),
                PrincipalAccess = new PrincipalAccess()
                {
                    AccessMask = AccessRights.ReadAccess|AccessRights.WriteAccess,
                    Principal = _team.ToEntityReference()
                }
            });

            // assign the lead to the team
            _serviceProxy.Execute(new AssignRequest()
            {
                Assignee = _team.ToEntityReference(),
                Target = _leads[3].ToEntityReference()
            });

            #endregion
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool toBeDeleted = true;

            if (prompt)
            {
                // Ask the user if the created entities should be deleted.
                Console.Write("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();
                if (answer.StartsWith("y") ||
                    answer.StartsWith("Y") ||
                    answer == String.Empty)
                {
                    toBeDeleted = true;
                }
                else
                {
                    toBeDeleted = false;
                }
            }

            if (toBeDeleted)
            {
                // Delete the leads
                foreach (Lead lead in _leads)
                    _serviceProxy.Delete(Lead.EntityLogicalName, lead.Id);
                Console.WriteLine("Entity records have been deleted.");
            }
        }
        #endregion Public Methods

        #endregion How To Sample Code

        #region Main method

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

                ReassignBusinessUnitMembers app = new ReassignBusinessUnitMembers();
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

        #endregion Main method
    }
}

// </snippetreassignbusinessunitmembers>