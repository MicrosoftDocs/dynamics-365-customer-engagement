// <snippetdoesuserbelongtorole>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to check a role association with the system user.
    /// </summary>
    /// <remarks>
    /// At run-time, you will be given the option to revert the role 
    /// association created by this program.</remarks>
    public class DoesUserBelongToRole
    {
        #region Class Level Members

        // Define the IDs needed for this sample.
        private Guid _userId;
        private OrganizationServiceProxy _serviceProxy;
        private String _givenRole = "salesperson";
        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// creates/retrieve a system user,
        /// retrieve a system user to check if it is associate with the salesperson role. 
        /// Note: Creating a user is only supported
        /// in on-premises/active directory environment.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();

                    
                    // Retrieve a user.
                    SystemUser user = _serviceProxy.Retrieve(SystemUser.EntityLogicalName,
                        _userId, new ColumnSet(new String [] {"systemuserid", "firstname", "lastname"})).ToEntity<SystemUser>();

                    if (user != null)
                    {
                        Console.WriteLine("{1} {0} user account is retrieved.", user.LastName, user.FirstName);
                        // Find a role.
                        QueryExpression query = new QueryExpression
                        {
                            EntityName = Role.EntityLogicalName,
                            ColumnSet = new ColumnSet("roleid"),
                            Criteria = new FilterExpression
                            {
                                Conditions =
                                {
    
                                    new ConditionExpression
                                    {
                                        AttributeName = "name",
                                        Operator = ConditionOperator.Equal,
                                        Values = {_givenRole}
                                    }
                                }
                            }
                        };

                        // Get the role.
                        EntityCollection givenRoles = _serviceProxy.RetrieveMultiple(query);

                        if (givenRoles.Entities.Count > 0)
                        {
                            Role givenRole = givenRoles.Entities[0].ToEntity<Role>();

                            Console.WriteLine("Role {0} is retrieved.", _givenRole);

                            Console.WriteLine("Checking association between user and role.");
                            // Establish a SystemUser link for a query.
                            LinkEntity systemUserLink = new LinkEntity()
                            {
                                LinkFromEntityName = SystemUserRoles.EntityLogicalName,
                                LinkFromAttributeName = "systemuserid",
                                LinkToEntityName = SystemUser.EntityLogicalName,
                                LinkToAttributeName = "systemuserid",
                                LinkCriteria =
                                {
                                    Conditions =
                                    {
                                        new ConditionExpression(
                                            "systemuserid", ConditionOperator.Equal, user.Id)
                                    }
                                }
                            };

                            // Build the query.
                            QueryExpression linkQuery = new QueryExpression()
                            {
                                EntityName = Role.EntityLogicalName,
                                ColumnSet = new ColumnSet("roleid"),
                                LinkEntities =
                                {
                                    new LinkEntity()
                                    {
                                        LinkFromEntityName = Role.EntityLogicalName,
                                        LinkFromAttributeName = "roleid",
                                        LinkToEntityName = SystemUserRoles.EntityLogicalName,
                                        LinkToAttributeName = "roleid",
                                        LinkEntities = {systemUserLink}
                                    }
                                },
                                Criteria =
                                {
                                    Conditions =
                                    {
                                        new ConditionExpression("roleid", ConditionOperator.Equal, givenRole.Id)
                                    }
                                }
                            };
                            
                            // Retrieve matching roles.
                            EntityCollection matchEntities = _serviceProxy.RetrieveMultiple(linkQuery);

                            // if an entity is returned then the user is a member
                            // of the role
                            Boolean isUserInRole = (matchEntities.Entities.Count > 0);

                            if(isUserInRole)
                                Console.WriteLine("User do not belong to the role.");
                            else
                                Console.WriteLine("User belong to this role.");

                        }
                    }
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
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // For this sample, all required entities are created in the Run() method.
            // Create/Retrieve a user.
            _userId = SystemUserProvider.RetrieveAUserWithoutAnyRoleAssigned(_serviceProxy);

            if (_userId != Guid.Empty)
                Console.WriteLine("{0} user retrieved.", _userId);
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
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                DoesUserBelongToRole app = new DoesUserBelongToRole();
                app.Run(config, true);
            }
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
                Console.WriteLine("Trace: {0}", ex.Detail.TraceText);
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
                        Console.WriteLine("Trace: {0}", fe.Detail.TraceText);
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

// </snippetdoesuserbelongtorole>