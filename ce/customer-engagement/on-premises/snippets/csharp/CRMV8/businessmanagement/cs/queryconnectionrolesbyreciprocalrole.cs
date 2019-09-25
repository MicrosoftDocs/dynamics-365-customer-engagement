// <snippetqueryconnectionrolesbyreciprocalrole>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to find connection roles by a reciprocal connectionrole.
    /// </summary>
    public class QueryConnectionRolesByReciprocalRole
    {
        #region Class Level Members
        
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        public Guid _primaryConnectionRoleId;
        public Guid _reciprocalConnectionRoleId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Call the method to create any data that this sample requires.
        /// Query all connection roles that have this role listed as a reciprocal role.
        /// Optionally delete any entity records that were created for this sample.
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

                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();

                    // This query retrieves all connection roles that have this role
                    // listed as a reciprocal role.
                    QueryExpression query = new QueryExpression
                    {
                        EntityName = ConnectionRole.EntityLogicalName,
                        ColumnSet = new ColumnSet("connectionroleid"),
                        LinkEntities = 
                    {
                        new LinkEntity
                        {
                            JoinOperator = JoinOperator.Inner,
                            LinkFromEntityName =  ConnectionRole.EntityLogicalName,
                            LinkFromAttributeName = "connectionroleid",
                            LinkToEntityName = "connectionroleassociation",
                            LinkToAttributeName = "connectionroleid",
                            LinkCriteria = new FilterExpression
                            {
                                FilterOperator = LogicalOperator.And,
                                Conditions = 
                                {
                                    new ConditionExpression
                                    {
                                        AttributeName = "associatedconnectionroleid",
                                        Operator = ConditionOperator.Equal,
                                        Values = { _reciprocalConnectionRoleId }                                        
                                    }
                                }
                            }
                        }
                    }
                    };

                    EntityCollection results = _serviceProxy.RetrieveMultiple(query);

                    // TODO: Here you would perform some operation on the retrieved
                    // roles. 

                    Console.WriteLine("Retrieved {0} connectionrole instance.", results.Entities.Count);

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
        /// Create a primary connection role instance. 
        /// Create a reciprocal connection role instance.
        /// Associate the connection roles.
        /// </summary>
        public void CreateRequiredRecords()
        {
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

            // Create the Connection Roles. 
            // Create the primary connection Role instance.
            ConnectionRole setupPrimaryConnectionRole = new ConnectionRole
            {
                Name = "Example Primary Connection Role",
                Category = new OptionSetValue(Categories.Business),
            };

            _primaryConnectionRoleId = _serviceProxy.Create(setupPrimaryConnectionRole);
            Console.WriteLine("Created {0}.", setupPrimaryConnectionRole.Name);

            // Create a related Connection Role Object Type Code record for Account
            // on the primary role.
            ConnectionRoleObjectTypeCode accountPrimaryConnectionRoleTypeCode
                = new ConnectionRoleObjectTypeCode
                {
                    ConnectionRoleId = new EntityReference(
                        ConnectionRole.EntityLogicalName, _primaryConnectionRoleId),
                    AssociatedObjectTypeCode = Account.EntityLogicalName
                };

            _serviceProxy.Create(accountPrimaryConnectionRoleTypeCode);
            Console.WriteLine(@"Created a related Connection Role Object Type Code 
                                record for Account on the primary role.");
            
            // Create another Connection Role.
            ConnectionRole setupReciprocalConnectionRole = new ConnectionRole
            {
                Name = "Example Reciprocal Connection Role",
                Category = new OptionSetValue(Categories.Business),
            };

            _reciprocalConnectionRoleId = _serviceProxy.Create(setupReciprocalConnectionRole);
            Console.WriteLine("Created {0}.", setupReciprocalConnectionRole.Name);

            // Create a related Connection Role Object Type Code record for Account
            // on the related role.
            ConnectionRoleObjectTypeCode accountReciprocalConnectionRoleTypeCode
                = new ConnectionRoleObjectTypeCode
                {
                    ConnectionRoleId = new EntityReference(
                        ConnectionRole.EntityLogicalName, _reciprocalConnectionRoleId),
                    AssociatedObjectTypeCode = Account.EntityLogicalName
                };

            _serviceProxy.Create(accountReciprocalConnectionRoleTypeCode);
            Console.WriteLine(@"Created a related Connection Role Object Type Code 
                                record for Account on the related role.");

            // Associate the connection roles.
            AssociateRequest associateConnectionRoles =
                new AssociateRequest
                {
                    Target = new EntityReference(ConnectionRole.EntityLogicalName,
                        _primaryConnectionRoleId),
                    RelatedEntities = new EntityReferenceCollection()
                    {
                        new EntityReference(ConnectionRole.EntityLogicalName,
                        _reciprocalConnectionRoleId)
                    },
                    // The name of the relationship connection role association 
                    // relationship in MS CRM
                    Relationship = new Relationship()
                    {
                        PrimaryEntityRole = EntityRole.Referencing, // Referencing or Referenced based on N:1 or 1:N reflexive relationship.
                        SchemaName = "connectionroleassociation_association"
                    }
                };

            _serviceProxy.Execute(associateConnectionRoles);

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
                _serviceProxy.Delete(ConnectionRole.EntityLogicalName, _primaryConnectionRoleId);
                _serviceProxy.Delete(ConnectionRole.EntityLogicalName, _reciprocalConnectionRoleId);

                Console.WriteLine("Entity records have been deleted.");
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

                QueryConnectionRolesByReciprocalRole app = new QueryConnectionRolesByReciprocalRole();
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

// </snippetqueryconnectionrolesbyreciprocalrole>