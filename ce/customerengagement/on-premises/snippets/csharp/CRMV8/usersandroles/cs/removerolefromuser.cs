// <snippetremoverolefromuser>


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
    /// Demonstrates how to do basic role association with the system user.
    /// </summary>
    /// <remarks>
    /// At run-time, you will be given the option to revert the role 
    /// association created by this program.</remarks>
    public class RemoveRoleFromUser
    {
        #region Class Level Members

        // Define the IDs needed for this sample.
        private Guid _userId;
        private String _givenRole = "salesperson";
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards, it
        /// creates/retrieves a system user, and
        /// updates the system user to associate with the salesperson role. 
        /// Note: Creating a user is only supported
        /// in an on-premises/active directory environment.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy is properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();

                    // Retrieve a user.
                    SystemUser user = _serviceProxy.Retrieve(SystemUser.EntityLogicalName,
                        _userId, new ColumnSet(new String[] { "systemuserid", "firstname", "lastname" })).ToEntity<SystemUser>();

                    if (user != null)
                    {
                        Console.WriteLine("{1} {0} user account is retrieved.", user.FirstName, user.LastName);
                        // Find the role.
                        QueryExpression query = new QueryExpression
                        {
                            EntityName = "role",
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
                        EntityCollection roles = _serviceProxy.RetrieveMultiple(query);

                        // Disassociate the role.
                        if (roles.Entities.Count > 0)
                        {
                            Role salesRole = _serviceProxy.RetrieveMultiple(query).Entities[0].ToEntity<Role>();

                            Console.WriteLine("Role {0} is retrieved.", _givenRole);

                            _serviceProxy.Disassociate(
                                        "systemuser",
                                        user.Id,
                                        new Relationship("systemuserroles_association"),
                                        new EntityReferenceCollection() { new EntityReference("role", salesRole.Id) });
                            Console.WriteLine("Role {0} is disassociated from user {1} {2}.", _givenRole, user.FirstName, user.LastName);
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
            // Create/retrieve a user and associate a role.

            _userId = SystemUserProvider.RetrieveAUserWithoutAnyRoleAssigned(_serviceProxy);
            // Find the role.
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
            EntityCollection roles = _serviceProxy.RetrieveMultiple(query);
            if (roles.Entities.Count > 0)
            {
                Role salesRole = _serviceProxy.RetrieveMultiple(query).Entities[0].ToEntity<Role>();

                // Associate the user with the role for this sample.
                if (salesRole != null && _userId != Guid.Empty)
                {
                    _serviceProxy.Associate(
                                "systemuser",
                                _userId,
                                new Relationship("systemuserroles_association"),
                                new EntityReferenceCollection() { new EntityReference(Role.EntityLogicalName, salesRole.Id) });
                }
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
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                RemoveRoleFromUser app = new RemoveRoleFromUser();
                app.Run( config, true );
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

// </snippetremoverolefromuser>