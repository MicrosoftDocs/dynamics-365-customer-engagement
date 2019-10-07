// <snippetuseraccess>


using System;
using System.Collections.Generic;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    public class UserAccess
    {
        #region Class Level Members
        private OrganizationServiceProxy _serviceProxy;
        private Guid _currentUserId;
        private List<Guid> _systemUserIds;
        private Guid _teamId;
        private Guid _leadId;
        private Guid _taskId;
        #endregion

        #region How To Sample Code
        public void Run(ServerConnection.Configuration serverConfig,
            bool promptforDelete)
        {
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                // This statement is required to enable early bound type support.
                _serviceProxy.EnableProxyTypes();
                CreateRequiredRecords();

                // Retrieve and display the access that the calling user has to the
                // created lead.
                var leadReference = new EntityReference(Lead.EntityLogicalName, _leadId);
                var currentUserReference = new EntityReference(
                    SystemUser.EntityLogicalName, _currentUserId);
                RetrieveAndDisplayPrincipalAccess(leadReference, currentUserReference,
                    "Current User");

                // Retrieve and display the access that the first user has to the
                // created lead.
                var systemUser1Ref = new EntityReference(SystemUser.EntityLogicalName,
                    _systemUserIds[0]);
                RetrieveAndDisplayPrincipalAccess(leadReference, systemUser1Ref,
                    "System User 1");

                // Grant the first user read access to the created lead.
                var grantAccessRequest1 = new GrantAccessRequest
                {
                    PrincipalAccess = new PrincipalAccess
                    {
                        AccessMask = AccessRights.ReadAccess,
                        Principal = systemUser1Ref
                    },
                    Target = leadReference
                };

                Console.WriteLine("Granting {0} to {1} ({2}) on the lead...\r\n",
                    AccessRights.ReadAccess, GetEntityReferenceString(systemUser1Ref), "System User 1");
                _serviceProxy.Execute(grantAccessRequest1);


                // Retrieve and display access information for the lead.
                RetrieveAndDisplayPrincipalAccess(leadReference, systemUser1Ref,
                    "System User 1");
                RetrieveAndDisplayLeadAccess(leadReference);

                // Grant the team read/write access to the lead.
                var teamReference = new EntityReference(Team.EntityLogicalName, _teamId);
                var grantAccessRequest = new GrantAccessRequest
                {
                    PrincipalAccess = new PrincipalAccess
                    {
                        AccessMask = AccessRights.ReadAccess | AccessRights.WriteAccess,
                        Principal = teamReference
                    },
                    Target = leadReference
                };

                Console.WriteLine("Granting {0} to {1} ({2}) on the lead...\r\n",
                    AccessRights.ReadAccess | AccessRights.WriteAccess, GetEntityReferenceString(teamReference), "Team");
                _serviceProxy.Execute(grantAccessRequest);

                var systemUser2Ref = new EntityReference(SystemUser.EntityLogicalName,
                    _systemUserIds[1]);

               
                // Retrieve and display access information for the lead and system user 2.
                RetrieveAndDisplayPrincipalAccess(leadReference, systemUser2Ref,
                    "System User 2");
                RetrieveAndDisplayLeadAccess(leadReference);


                // Grant the first user delete access to the lead.
                var modifyUser1AccessReq = new ModifyAccessRequest
                {
                    PrincipalAccess = new PrincipalAccess
                    {
                        AccessMask = AccessRights.DeleteAccess,
                        Principal = systemUser1Ref
                    },
                    Target = leadReference
                };

                Console.WriteLine("Granting delete access to {0} on the lead...\r\n",
                    GetEntityReferenceString(systemUser1Ref));
                _serviceProxy.Execute(modifyUser1AccessReq);

                // Retrieve and display access information for the lead.
                RetrieveAndDisplayLeadAccess(leadReference);


                // Revoke access to the lead for the second user.
                var revokeUser2AccessReq = new RevokeAccessRequest
                {
                    Revokee = systemUser2Ref,
                    Target = leadReference
                };

                Console.WriteLine("Revoking access to the lead for {0}...\r\n",
                    GetEntityReferenceString(systemUser2Ref));
                _serviceProxy.Execute(revokeUser2AccessReq);

                // Retrieve and display access information for the lead.
                RetrieveAndDisplayPrincipalAccess(leadReference, systemUser2Ref,
                    "System User 2");

                RetrieveAndDisplayLeadAccess(leadReference);

                DeleteRequiredRecords(promptforDelete);
            }
        }

        private void RetrieveAndDisplayPrincipalAccess(EntityReference leadReference,
            EntityReference principal, String additionalIdentifier)
        {
            var principalAccessReq = new RetrievePrincipalAccessRequest
            {
                Principal = principal,
                Target = leadReference
            };
            var principalAccessRes = (RetrievePrincipalAccessResponse)
                _serviceProxy.Execute(principalAccessReq);
            Console.WriteLine("Access rights of {0} ({1}) on the lead: {2}\r\n",
                GetEntityReferenceString(principal),
                additionalIdentifier,
                principalAccessRes.AccessRights);
        }

        private void RetrieveAndDisplayLeadAccess(EntityReference leadReference)
        {
            var accessRequest = new RetrieveSharedPrincipalsAndAccessRequest
            {
                Target = leadReference
            };
            
            // The RetrieveSharedPrincipalsAndAccessResponse returns an entity reference
            // that has a LogicalName of "user" when returning access information for a
            // "team."
            var accessResponse = (RetrieveSharedPrincipalsAndAccessResponse)
                _serviceProxy.Execute(accessRequest);
            Console.WriteLine("The following have the specified granted access to the lead.");
            foreach (var principalAccess in accessResponse.PrincipalAccesses)
            {
                Console.WriteLine("\t{0}:\r\n\t\t{1}",
                    GetEntityReferenceString(principalAccess.Principal),
                    principalAccess.AccessMask);
            }
            Console.WriteLine();

        }

        private String GetEntityReferenceString(EntityReference entityReference)
        {
            return String.Format("{0} with GUID {1}", entityReference.LogicalName,
                entityReference.Id);
        }

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Create a unique identifier for this sample for preventing name conflicts.
            var sampleIdentifier = Guid.NewGuid();

            // Retrieve/create the system users to use for the sample.
            var ldapPath = String.Empty;
            _systemUserIds = SystemUserProvider.RetrieveDelegates(
                _serviceProxy, ref ldapPath);

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
            var businessUnit = businessUnitResult.Entities[0].ToEntity<BusinessUnit>();

            // Get the GUID of the current user.
            var who = new WhoAmIRequest();
            var whoResponse = (WhoAmIResponse)_serviceProxy.Execute(who);
            _currentUserId = whoResponse.UserId;

            // Create a team for use in the sample.
            var team = new Team
            {
                AdministratorId = new EntityReference(
                    "systemuser", _currentUserId),
                Name = String.Format("User Access Sample Team {0}", sampleIdentifier),
                BusinessUnitId = businessUnit.ToEntityReference()
            };
            _teamId = _serviceProxy.Create(team);

            // Add the second user to the newly created team.
            var addToTeamRequest = new AddMembersTeamRequest
            {
                TeamId = _teamId,
                MemberIds = new[] { _systemUserIds[1] }
            };
            _serviceProxy.Execute(addToTeamRequest);

            // Create a lead for use in the sample.
            var lead = new Lead
            {
                CompanyName = "User Access Sample Company",
                FirstName = "Sample",
                LastName = "Lead",
                Subject = "User Access Sample Lead",
            };
            _leadId = _serviceProxy.Create(lead);

            // Create a task to associate to the lead.
            var leadReference = new EntityReference(Lead.EntityLogicalName, _leadId);
            var task = new Task
            {
                Subject = "User Access Sample Task",
                RegardingObjectId = leadReference
            };
            _taskId = _serviceProxy.Create(task);

            // Create a letter to associate to the lead.
            var letter = new Letter
            {
                Subject = "User Access Sample Letter",
                RegardingObjectId = leadReference
            };
            _serviceProxy.Create(letter);
        }

        private void DeleteRequiredRecords(bool prompt)
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
                // Delete records created in this sample.
                _serviceProxy.Delete(Team.EntityLogicalName, _teamId);
                // Deleting the lead will delete its associated activities.
                _serviceProxy.Delete(Lead.EntityLogicalName, _leadId);

                Console.WriteLine("Entity record(s) have been deleted.");
            }
        }
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
                // Obtain the target organization's web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                var app = new UserAccess();
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

// </snippetuseraccess>