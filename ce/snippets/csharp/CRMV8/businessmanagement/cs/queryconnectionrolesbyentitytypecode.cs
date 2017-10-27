// <snippetqueryconnectionrolesbyentitytypecode>


using System;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to find connection roles by object type code.
    /// </summary>
    public class QueryConnectionRolesByEntityTypeCode
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        private Guid _connectionRoleId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This sample creates a role that is not linked to any entity type. All
        /// connection roles that apply to all are found and shown. Then the role is
        /// linked to the account entity and it is demonstrated that the role only works
        /// for accounts at this point, not for all. Subsequently the link to the account
        /// entity is removed and it is shown that the role is now applicable to all 
        /// entities again.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    // Define some anonymous types to define the range 
                    // of possible connection property values.
                    var Categories = new
                    {
                        Business = 1,
                        Family = 2,
                        Social = 3,
                        Sales = 4,
                        Other = 5
                    };

                    // Create a Connection Role.
                    ConnectionRole setupConnectionRole = new ConnectionRole
                    {
                        Name = "Example Connection Role",
                        Category = new OptionSetValue(Categories.Business),
                    };

                    _connectionRoleId = _serviceProxy.Create(setupConnectionRole);
                    setupConnectionRole.Id = _connectionRoleId;

                    Console.WriteLine("Created {0}.", setupConnectionRole.Name);

                    // Query for all Connection Roles.
                    QueryExpression allQuery = new QueryExpression
                    {
                        EntityName = ConnectionRole.EntityLogicalName,
                        ColumnSet = new ColumnSet("connectionroleid", "name"),
                        Distinct = true,
                        LinkEntities = 
                        {
                            new LinkEntity
                            {
                                LinkToEntityName = 
                                ConnectionRoleObjectTypeCode.EntityLogicalName,
                                LinkToAttributeName = "connectionroleid",
                                LinkFromEntityName = ConnectionRole.EntityLogicalName,
                                LinkFromAttributeName = "connectionroleid",
                                LinkCriteria = new FilterExpression
                                {
                                    FilterOperator = LogicalOperator.And,
                                    // Set a condition to only get connection roles  
                                    // related to all entities (object type code = 0).
                                    Conditions = 
                                    {
                                        new ConditionExpression 
                                        {
                                             AttributeName = "associatedobjecttypecode",
                                             Operator = ConditionOperator.Equal,
                                             Values = { 0 }
                                        }
                                    }
                                }
                            }
                        }
                    };

                    EntityCollection results = _serviceProxy.RetrieveMultiple(allQuery);

                    // Here you could perform operations on all of 
                    // the connectionroles found by the query.

                    Console.WriteLine("Retrieved {0} unassociated connectionrole instance(s).",
                        results.Entities.Count);

                    // Query to find roles which apply only to accounts.
                    QueryExpression accountQuery = new QueryExpression
                    {
                        EntityName = ConnectionRole.EntityLogicalName,
                        ColumnSet = new ColumnSet("connectionroleid", "name"),
                        Distinct = true,
                        LinkEntities = 
                        {
                            new LinkEntity
                            {
                                LinkToEntityName = 
                                ConnectionRoleObjectTypeCode.EntityLogicalName,
                                LinkToAttributeName = "connectionroleid",
                                LinkFromEntityName = ConnectionRole.EntityLogicalName,
                                LinkFromAttributeName = "connectionroleid",
                                LinkCriteria = new FilterExpression
                                {
                                    FilterOperator = LogicalOperator.And,
                                    // Set a condition to only get connection roles  
                                    // related to accounts (object type code = 1).
                                    Conditions = 
                                    {
                                        new ConditionExpression 
                                        {
                                             AttributeName = "associatedobjecttypecode",
                                             Operator = ConditionOperator.In,
                                             Values = { Account.EntityLogicalName }
                                        }
                                    }
                                }
                            }
                        }
                    };

                    results = _serviceProxy.RetrieveMultiple(accountQuery);

                    Console.WriteLine("Retrieved {0} account-only connectionrole instance(s).",
                        results.Entities.Count);

                    // Create a related Connection Role Object Type Code record for 
                    // Account.
                    ConnectionRoleObjectTypeCode setupAccountConnectionRoleTypeCode
                        = new ConnectionRoleObjectTypeCode
                        {
                            ConnectionRoleId = new EntityReference(
                                ConnectionRole.EntityLogicalName, _connectionRoleId),
                            AssociatedObjectTypeCode = Account.EntityLogicalName
                        };

                    setupAccountConnectionRoleTypeCode.Id = 
                        _serviceProxy.Create(setupAccountConnectionRoleTypeCode);

                    Console.Write("Created a related Connection Role Object Type Code");
                    Console.Write(" record for Account.");

                    // Run the query to find unassociated connectionroles again.
                    results = _serviceProxy.RetrieveMultiple(allQuery);
                    
                    Console.WriteLine(@"Retrieved {0} unassociated connectionrole instance(s).",
                        results.Entities.Count);

                    // Run the account-only query again.
                    results = _serviceProxy.RetrieveMultiple(accountQuery);

                    Console.WriteLine("Retrieved {0} account-only connectionrole instance(s).",
                        results.Entities.Count);

                    // Remove the link from account entity.
                    _serviceProxy.Delete(ConnectionRoleObjectTypeCode.EntityLogicalName, 
                        setupAccountConnectionRoleTypeCode.Id);

                    Console.WriteLine("Removed link from connectionrole to account entity.");

                    // Run the query to find unassociated connectionroles again.
                    results = _serviceProxy.RetrieveMultiple(allQuery);

                    Console.WriteLine("Retrieved {0} unassociated connectionrole instance(s).",
                        results.Entities.Count);

                    // Run the account-only query again.
                    results = _serviceProxy.RetrieveMultiple(accountQuery);

                    Console.WriteLine("Retrieved {0} account-only connectionrole instance(s).",
                        results.Entities.Count);

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
                // Delete all records created in this sample.
                _serviceProxy.Delete(ConnectionRole.EntityLogicalName, _connectionRoleId);

                Console.WriteLine("Entity record(s) have been deleted.");
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

                QueryConnectionRolesByEntityTypeCode app = new QueryConnectionRolesByEntityTypeCode();
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

// </snippetqueryconnectionrolesbyentitytypecode>