// <snippetrollupbyobject>


using System;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to roll up opportunities by their parent account.</summary>
    /// </summary>
    public class RollupByObject
    {
        #region Class Level Members

        private Guid _accountId;
        private Guid _opportunityId;
        private OrganizationServiceProxy _serviceProxy;
        
        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This sample demonstrates how to roll up opportunities by their parent account.
        /// The sample first creates the Rollup Request. Next, it executes that request.
        /// Finally, the sample displays the results of the Rollup Response.
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
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();

                    #region Create QueryExpression
                    // Create QueryExpression
                    QueryExpression query = new QueryExpression()
                    {
                        EntityName = Opportunity.EntityLogicalName,
                        ColumnSet = new ColumnSet("name", "accountid"),
                        Criteria =
                        {
                            Filters = 
                            {
                                new FilterExpression
                                {
                                    FilterOperator = LogicalOperator.And,
                                    Conditions = 
                                    {
                                        new ConditionExpression("name", ConditionOperator.Equal, "Opportunity 1")
                                    },
                                }
                            }
                        },
                    };
                    Console.WriteLine("Created QueryExpression.");
                    #endregion Create QueryExpression
                    
                    #region Create RollupRequest
                    // Create RollupRequest
                    RollupRequest rollupRequest = new RollupRequest();
                    rollupRequest.Query = query;
                    rollupRequest.Target = new EntityReference("account", _accountId);
                    rollupRequest.RollupType = RollupType.Extended;
                    Console.WriteLine("Created RollupRequest.");
                    #endregion Create RollupRequest

                    #region Execute RollupRequest
                    // Execute RollupRequest
                    RollupResponse rollupResponse = (RollupResponse)_serviceProxy.Execute(rollupRequest);
                    Console.WriteLine("Executed RollupRequest.");
                    #endregion Execute RollupRequest

                    #region Show RollupResponse results
                    // Show RollupResponse results
                    Console.WriteLine("RollupResponse Results:");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Count: " + rollupResponse.Results.Count);
                    for (int i = 0; i < rollupResponse.Results.Count; i++ )
                    {
                        Console.WriteLine();
                        Console.WriteLine("LogicalName: " + rollupResponse.EntityCollection.Entities[i].LogicalName);
                        Console.WriteLine("Id: " + rollupResponse.EntityCollection.Entities[i].Id);
                    }
                    #endregion Show RollupResponse results

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

        public void CreateRequiredRecords()
        {
            // Create an account
            Account account = new Account
            {
                Name = "Fourth Coffee"
            };
            _accountId = _serviceProxy.Create(account);

            // Create an opportunity
            Opportunity newOpportunity = new Opportunity
            {
                Name = "Opportunity 1",
                CustomerId = new EntityReference
                {
                    Id = _accountId,
                    LogicalName = account.LogicalName
                }                
            };
            _opportunityId = _serviceProxy.Create(newOpportunity);
        }

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
                _serviceProxy.Delete(Account.EntityLogicalName, _accountId);

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
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                RollupByObject app = new RollupByObject();
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

// </snippetrollupbyobject>