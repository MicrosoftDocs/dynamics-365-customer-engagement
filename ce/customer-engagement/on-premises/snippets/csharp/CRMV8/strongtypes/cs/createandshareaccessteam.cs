// <snippetcreateandshareaccessteam>


using System;
using System.Collections.Generic;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly.
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates creating an access team and granting that team privileges to
    /// access an account record. All members of that team receive access to that record.
    /// 
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.
    /// </summary>
    /// <remarks>Important messages used in this sample: 
    /// AddMembersTeam, RemoveMembersTeam, GrantAccessRequest.</remarks>
    public class CreateAndShareAccessTeam
    {
        #region Class Level Members
        /// <summary>
        /// Stores the organization service interface.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        private Guid _accountId;
        private Guid _teamId;
        private Guid _currentUserId;        

        // System users in the team.
        public List<Guid> salesPersons;       
        #endregion Class Level Members

        #region How To Sample Code
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                                     serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    String ldapPath = String.Empty;
                    Guid businessUnitId;

                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    // Call this method to create any data that this sample requires.
                    CreateRequiredRecords();

                    // Retrieve the sales people that will be added to the team.
                    salesPersons = SystemUserProvider.RetrieveSalespersons(_serviceProxy, ref ldapPath);

                    // Get the ID's of the current user and business unit.
                    var who = new WhoAmIRequest();
                    var whoResponse = (WhoAmIResponse)_serviceProxy.Execute(who);
                    _currentUserId = whoResponse.UserId;
                    businessUnitId = whoResponse.BusinessUnitId;

                    // Create a access team.
                    var team = new Team
                    {
                        AdministratorId = new EntityReference(
                            "systemuser", _currentUserId),
                        Name = "UserAccess Test Team",
                        BusinessUnitId = new EntityReference(
                            "businessunit", businessUnitId),
                        TeamType = new OptionSetValue((int)TeamTeamType.Access),
                    };

                    _teamId = _serviceProxy.Create(team);
                    Console.WriteLine("Created an access team named '{0}'.", team.Name);

                    // Add two sales people to the access team.
                    var addToTeamRequest = new AddMembersTeamRequest
                    {
                        TeamId = _teamId,
                        MemberIds = new[] { salesPersons[0], salesPersons[1] }
                    };
                    _serviceProxy.Execute(addToTeamRequest);
                    Console.WriteLine("Added two sales people to the team.");
                    
                    // Grant the team read/write access to an account.
                    var accountReference = new EntityReference(Account.EntityLogicalName, _accountId);
                    var teamReference = new EntityReference(Team.EntityLogicalName, _teamId);
                    var grantAccessRequest = new GrantAccessRequest
                    {
                        PrincipalAccess = new PrincipalAccess
                        {
                            AccessMask = AccessRights.ReadAccess | AccessRights.WriteAccess,
                            Principal = teamReference
                        },
                        Target = accountReference
                    };
                    _serviceProxy.Execute(grantAccessRequest);
                    Console.WriteLine("Granted read/write access on the account record to the team.");

                    // Retrieve and display access information for the account.
                    RetrieveAndDisplayEntityAccess(accountReference);

                    // Display the account access for the team and its members.
                    var currentUserReference = new EntityReference(
                        SystemUser.EntityLogicalName, _currentUserId);
                    RetrieveAndDisplayPrincipalAccess(accountReference, currentUserReference,
                        "Current User");
                    var firstSalesPersonReference = new EntityReference(
                        SystemUser.EntityLogicalName, salesPersons[0]);
                    RetrieveAndDisplayPrincipalAccess(accountReference, firstSalesPersonReference,
                        "Sales Person");
                    var secondSalesPersonReference = new EntityReference(
                        SystemUser.EntityLogicalName, salesPersons[1]);
                    RetrieveAndDisplayPrincipalAccess(accountReference, secondSalesPersonReference,
                        "Sales Person");
                    
                    // Delete all records created by this sample.
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
        /// Retrieve and display entity access information.
        /// </summary>
        /// <param name="entityReference"></param>
        private void RetrieveAndDisplayEntityAccess(EntityReference entityReference)
        {
            var accessRequest = new RetrieveSharedPrincipalsAndAccessRequest
            {
                Target = entityReference
            };

            // The RetrieveSharedPrincipalsAndAccessResponse returns an entity reference
            // that has a LogicalName of "user" when returning access information for a
            // team.
            var accessResponse = (RetrieveSharedPrincipalsAndAccessResponse)
                _serviceProxy.Execute(accessRequest);

            Console.WriteLine("The following have the specified granted access to the entity.");

            foreach (var principalAccess in accessResponse.PrincipalAccesses)
            {
                Console.WriteLine("\t{0}:\r\n\t\t{1}",
                    String.Format("{0} with GUID {1}", principalAccess.Principal.LogicalName,
                principalAccess.Principal.Id), principalAccess.AccessMask);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Retrieve and display principal access information.
        /// </summary>
        /// <param name="entityReference"></param>
        /// <param name="principal"></param>
        /// <param name="additionalIdentifier"></param>
        private void RetrieveAndDisplayPrincipalAccess(EntityReference entityReference,
            EntityReference principal, String additionalIdentifier)
        {
            var principalAccessReq = new RetrievePrincipalAccessRequest
            {
                Principal = principal,
                Target = entityReference
            };
            var principalAccessRes = (RetrievePrincipalAccessResponse)
                _serviceProxy.Execute(principalAccessReq);

            Console.WriteLine("Access rights of {0} ({1}) on the entity: {2}\r\n",
                String.Format("{0} with GUID {1}", principal.LogicalName,
                principal.Id), additionalIdentifier,
                principalAccessRes.AccessRights);
        }
                
        /// <summary>
        /// Create any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Create an account named Fourth Coffee.
            Account testAccount = new Account
            {
                Name = "Fourth Coffee"
            };

            _accountId = _serviceProxy.Create(testAccount);

            Console.WriteLine("Created an account named '{0}'.", testAccount.Name);
            return;
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
                // Remove all the users from the team before deleting the team.
                var deleteFromTeamRequest = new RemoveMembersTeamRequest
                {
                    TeamId = _teamId,
                    MemberIds = new[] { _currentUserId, salesPersons[0], salesPersons[1] }
                };
                _serviceProxy.Execute(deleteFromTeamRequest);

                // Delete records created in this sample.
                _serviceProxy.Delete(Account.EntityLogicalName, _accountId);
                _serviceProxy.Delete(Team.EntityLogicalName, _teamId);

                Console.WriteLine("Entity record(s) have been deleted.");
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

                CreateAndShareAccessTeam app = new CreateAndShareAccessTeam();
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

// </snippetcreateandshareaccessteam>