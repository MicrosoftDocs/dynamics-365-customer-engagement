// <snippetassignsecurityroletoteam>


using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Client;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;



namespace Microsoft.Crm.Sdk.Samples
{

    /// <summary>
    /// Demonstrates how to assign a security role to a team.
    /// </summary>
    public class AssignSecurityRoleToTeam
    {
        #region Class Level Members


        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

        // Define the IDs needed for this sample.
        private Guid _teamId;
        private Guid _roleId;
        public const String _roleName = "An Example Role";

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Retrieve a role from CRM.
        /// Assign that role to a team.
        /// <param name="organizationFriendlyName">The friendly name of 
        /// the target organization.</param>
        /// <param name="discoveryServer">The name of the discovery server.</param>
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


                    // Retrieve a role from CRM.
                    QueryExpression query = new QueryExpression
                    {
                        EntityName = Role.EntityLogicalName,
                        ColumnSet = new ColumnSet("roleid"),
                        Criteria = new FilterExpression
                        {
                            Conditions =
                        {
                            // You would replace the condition below with an actual role
                            // name, or skip this query if you had a role id.
                            new ConditionExpression
                            {
                                AttributeName = "name",
                                Operator = ConditionOperator.Equal,
                                Values = {_roleName}
                            }
                        }
                        }
                    };

                    Role role = _service.RetrieveMultiple(query).Entities.
                        Cast<Role>().First();


                    // Add the role to the team.
                    _service.Associate(
                           Team.EntityLogicalName,
                           _teamId,
                           new Relationship("teamroles_association"),
                           new EntityReferenceCollection() { new EntityReference(Role.EntityLogicalName, _roleId) });

                    Console.WriteLine("Assigned role to team");

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
        /// Creates a team and a role.
        /// </summary>
        public void CreateRequiredRecords()
        {

            // Retrieve the default business unit needed to create the team and role.
            QueryExpression query = new QueryExpression
            {
                EntityName = BusinessUnit.EntityLogicalName,
                ColumnSet = new ColumnSet("businessunitid"),
                Criteria =
                {
                    Conditions =
                    {
                        new ConditionExpression("parentbusinessunitid", 
                            ConditionOperator.Null)
                    }
                }
            };

            BusinessUnit defaultBusinessUnit = _service.RetrieveMultiple(query)
                .Entities.Cast<BusinessUnit>().FirstOrDefault();

            // Instantiate a team entity record and set its property values.
            // See the Entity Metadata topic in the SDK documentation  
            // to determine which attributes must be set for each entity.
            Team setupTeam = new Team
            {
                Name = "An Example Team",
                BusinessUnitId = new EntityReference(BusinessUnit.EntityLogicalName,
                    defaultBusinessUnit.Id)
            };

            // Create a team record.
            _teamId = _service.Create(setupTeam);
            Console.WriteLine("Created team '{0}'", setupTeam.Name);

            // Instantiate a role entity record and set its property values.
            // See the Entity Metadata topic in the SDK documentation  
            // to determine which attributes must be set for each entity.
            Role setupRole = new Role
            {
                Name = _roleName,
                BusinessUnitId = new EntityReference(BusinessUnit.EntityLogicalName,
                    defaultBusinessUnit.Id)
            };

            // Create the role record. 
            _roleId = _service.Create(setupRole);
            Console.WriteLine("Created role '{0}'", setupRole.Name);

            // Define an array listing the privileges that we want to add to the role
            String[] privilegesToAdd = new string[] { "prvReadContact", 
                "prvCreateContact", "prvReadAccount", "prvCreateAccount" };

            // Query for the privileges we want to add to the role
            QueryExpression queryPrivileges = new QueryExpression
            {
                EntityName = Privilege.EntityLogicalName,
                ColumnSet = new ColumnSet("privilegeid", "name"),
                Criteria = new FilterExpression()
            };
            queryPrivileges.Criteria.AddCondition("name", ConditionOperator.In,
                privilegesToAdd);

            DataCollection<Entity> returnedPrivileges = _service.RetrieveMultiple(
                queryPrivileges).Entities;
            Console.WriteLine("Retrieved privileges to add to role");

            // Define a list to hold the RolePrivileges we'll need to add
            List<RolePrivilege> rolePrivileges = new List<RolePrivilege>();

            foreach (Privilege privilege in returnedPrivileges)
            {
                RolePrivilege rolePrivilege = new RolePrivilege(
                    (int)PrivilegeDepth.Local, privilege.PrivilegeId.Value);
                rolePrivileges.Add(rolePrivilege);
            }

            // Add the retrieved privileges to the example role.
            AddPrivilegesRoleRequest addPrivilegesRequest = new AddPrivilegesRoleRequest
            {
                RoleId = _roleId,
                Privileges = rolePrivileges.ToArray()
            };
            _service.Execute(addPrivilegesRequest);
            Console.WriteLine("Added privileges to role");
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
                _service.Delete(Team.EntityLogicalName, _teamId);
                _service.Delete(Role.EntityLogicalName, _roleId);

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

                AssignSecurityRoleToTeam app = new AssignSecurityRoleToTeam();
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

// </snippetassignsecurityroletoteam>