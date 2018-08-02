// <snippetaddroletouser>


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
    public class AddRoleToUser
    {
        #region Class Level Members

        // Define the IDs needed for this sample.
        private Guid _userId;
        private Guid _roleId;
        private String _givenRole = "salesperson";
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// creates/retrieves a system user,
        /// updates the system user to associate with the salesperson role. 
        /// Note: Creating a user is only supported
        /// in an on-premises/active directory environment.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user is prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy is properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                                     serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();

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

                        Console.WriteLine("Role {0} is retrieved for the role assignment.", _givenRole);

                        _roleId = salesRole.Id;

                        // Associate the user with the role.
                        if (_roleId != Guid.Empty && _userId != Guid.Empty)
                        {
                            _serviceProxy.Associate(
                                        "systemuser",
                                        _userId,
                                        new Relationship("systemuserroles_association"),
                                        new EntityReferenceCollection() { new EntityReference(Role.EntityLogicalName, _roleId) });

                            Console.WriteLine("Role is associated with the user.");
                        }
                    }

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

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // For this sample, all required entities are created in the Run() method.
            // Create/retrieve a user for role assignment.
            _userId = SystemUserProvider.RetrieveAUserWithoutAnyRoleAssigned(_serviceProxy);

            if (_userId != Guid.Empty)
                Console.WriteLine("{0} user retrieved.", _userId);
        }

        /// <summary>
        /// Deletes/reverts any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete/revert the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.Write("\nDo you want these entity records deleted/reverted? (y/n) [y]: ");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
            }

            if (deleteRecords)
            {
                _serviceProxy.Disassociate("systemuser", 
                    _userId, 
                    new Relationship("systemuserroles_association"), 
                    new EntityReferenceCollection() { new EntityReference("role", _roleId) });
                Console.WriteLine("Entity records have been deleted/reverted.");
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

                AddRoleToUser app = new AddRoleToUser();
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

// </snippetaddroletouser>