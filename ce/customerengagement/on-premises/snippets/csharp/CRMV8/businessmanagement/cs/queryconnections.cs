// <snippetqueryconnections>


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
    /// This Sample shows how to query connections.
    /// </summary>
    public class QueryConnections
    {
        #region Class Level Members
        
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        public Guid _connectionRoleId;
        public Guid _account1Id;
        public Guid _account2Id;
        public Guid _contactId;
        public Guid _connection1Id;
        public Guid _connection2Id;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Call the method to create any data that this sample requires.
        /// Query the connections.
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

                    // This query retrieves all connections this contact is part of.
                    QueryExpression query = new QueryExpression
                    {
                        EntityName = Connection.EntityLogicalName,
                        ColumnSet = new ColumnSet("connectionid"),
                        Criteria = new FilterExpression
                        {
                            FilterOperator = LogicalOperator.And,
                            Conditions = 
                        {
                            // You can safely query against only record1id or
                            // record2id - CRM will find all connections this 
                            // entity is a part of either way.
                            new ConditionExpression
                            {
                                AttributeName = "record1id",
                                Operator = ConditionOperator.Equal,
                                Values = { _contactId }
                            }
                        }
                        }
                    };

                    EntityCollection results = _serviceProxy.RetrieveMultiple(query);

                    // TODO: Here you could do a variety of tasks with the 
                    // connections retrieved, such as listing the connected entities,
                    // finding reciprocal connections, etc.

                    Console.WriteLine("Retrieved {0} connectionrole instances.", results.Entities.Count);

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
        /// Create a new connectionrole instance. 
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

            // Create a Connection Role
            ConnectionRole setupConnectionRole = new ConnectionRole
            {
                Name = "Example Connection Role",
                Description = "This is an example one sided connection role.",
                Category = new OptionSetValue(Categories.Business),
            };

            _connectionRoleId = _serviceProxy.Create(setupConnectionRole);
            Console.WriteLine("Created {0}.", setupConnectionRole.Name);

            // Create a related Connection Role Object Type Code record for Account
            ConnectionRoleObjectTypeCode newAccountConnectionRoleTypeCode
                = new ConnectionRoleObjectTypeCode
                {
                    ConnectionRoleId = new EntityReference(
                        ConnectionRole.EntityLogicalName, _connectionRoleId),
                    AssociatedObjectTypeCode = Account.EntityLogicalName
                };

            _serviceProxy.Create(newAccountConnectionRoleTypeCode);
            Console.WriteLine(
                "Created a related Connection Role Object Type Code record for Account."
                );

            // Create a related Connection Role Object Type Code record for Contact
            ConnectionRoleObjectTypeCode newContactConnectionRoleTypeCode
                = new ConnectionRoleObjectTypeCode
                {
                    ConnectionRoleId = new EntityReference(
                        ConnectionRole.EntityLogicalName, _connectionRoleId),
                    AssociatedObjectTypeCode = Contact.EntityLogicalName
                };

            _serviceProxy.Create(newContactConnectionRoleTypeCode);
            Console.WriteLine(
                "Created a related Connection Role Object Type Code record for Contact."
                );

            //Create a few account records for use in the connections.
            Account setupAccount1 = new Account { Name = "Example Account 1" };
            _account1Id = _serviceProxy.Create(setupAccount1);
            Console.WriteLine("Created {0}.", setupAccount1.Name);

            Account setupAccount2 = new Account { Name = "Example Account 2" };
            _account2Id = _serviceProxy.Create(setupAccount2);
            Console.WriteLine("Created {0}.", setupAccount2.Name);

            //Creates a contact used in the connection.
            Contact setupContact = new Contact { LastName = "Example Contact" };
            _contactId = _serviceProxy.Create(setupContact);
            Console.WriteLine("Created {0}.", setupContact.LastName);

            // Create a new connection between Account 1 and the contact record.
            Connection newConnection1 = new Connection
            {
                Record1Id = new EntityReference(Account.EntityLogicalName,
                    _account1Id),
                Record1RoleId = new EntityReference(ConnectionRole.EntityLogicalName,
                    _connectionRoleId),
                Record2Id = new EntityReference(Contact.EntityLogicalName,
                    _contactId)
            };

            _connection1Id = _serviceProxy.Create(newConnection1);

            Console.WriteLine(
                    "Created a connection between the account 1 and the contact.");

            // Create a new connection between the contact and Account 2 record
            Connection newConnection2 = new Connection
            {
                Record1Id = new EntityReference(Contact.EntityLogicalName,
                    _contactId),
                Record1RoleId = new EntityReference(ConnectionRole.EntityLogicalName,
                    _connectionRoleId),
                Record2Id = new EntityReference(Account.EntityLogicalName,
                    _account2Id)
            };

            _connection2Id = _serviceProxy.Create(newConnection2);

            Console.WriteLine(
                    "Created a connection between the contact and the account 2.");

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
                _serviceProxy.Delete(Connection.EntityLogicalName, _connection1Id);
                _serviceProxy.Delete(Connection.EntityLogicalName, _connection2Id);
                _serviceProxy.Delete(Account.EntityLogicalName, _account1Id);
                _serviceProxy.Delete(Account.EntityLogicalName, _account2Id);
                _serviceProxy.Delete(Contact.EntityLogicalName, _contactId);
                _serviceProxy.Delete(ConnectionRole.EntityLogicalName, _connectionRoleId);

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

                QueryConnections app = new QueryConnections();
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

// </snippetqueryconnections>