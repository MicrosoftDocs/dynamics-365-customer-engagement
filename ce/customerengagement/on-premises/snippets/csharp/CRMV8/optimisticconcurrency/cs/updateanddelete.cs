// <snippetupdateanddelete>


using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.ServiceModel;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to use the optimistic concurrecny feature introduced in
    /// CRM Online 2015 Update 1.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    /// <see cref="https://msdn.microsoft.com/library/dn932125.aspx"/>
    public class UpdateAndDelete
    {
        #region Class Level Members

        private Guid _accountId;
        private string _accountRowVersion;
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method demonstrates the optimistic concurrency feature.
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
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                    serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    CreateRequiredRecords();

                    // Retrieve an account.
                    var account = _serviceProxy.Retrieve("account", _accountId, new ColumnSet("name","creditlimit"));
                    Console.WriteLine("\tThe row version of the created account is {0}", account.RowVersion);

                    if (account != null)
                    {
                        // Create an in-memory account object from the retrieved account.
                        Entity updatedAccount = new Entity()
                        {
                            LogicalName = account.LogicalName,
                            Id = account.Id,
                            RowVersion = account.RowVersion
                        };

                        // Update just the credit limit.
                        updatedAccount["creditlimit"] = new Money(1000000);

                        // Set the request's concurrency behavour to check for a row version match.
                        UpdateRequest accountUpdate = new UpdateRequest()
                        {
                            Target = updatedAccount,
                            ConcurrencyBehavior = ConcurrencyBehavior.IfRowVersionMatches
                        };

                        // Do the update.
                        UpdateResponse accountUpdateResponse = (UpdateResponse) _serviceProxy.Execute(accountUpdate);
                        Console.WriteLine("Account '{0}' updated with a credit limit of {1}.", account["name"], 
                            ((Money)updatedAccount["creditlimit"]).Value);

                        account = _serviceProxy.Retrieve("account", updatedAccount.Id, new ColumnSet());
                        Console.WriteLine("\tThe row version of the updated account is {0}", account.RowVersion);
                        _accountRowVersion = account.RowVersion;
                    }

                    DeleteRequiredRecords(promptforDelete);
                }
            }

            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> e)
            {
                if (e.Detail.ErrorCode == CrmSdk.ErrorCodes.ConcurrencyVersionMismatch)
                {
                    var account = _serviceProxy.Retrieve("account", _accountId, new ColumnSet());
                    throw new Exception(String.Format("A mismatched row version ({0}) caused the request to fail.", account.RowVersion), e);
                }
                else
                    throw e;
            }
        }

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            Entity account = new Entity("account");
            account["name"] = "Fourth Coffee";
            account["creditlimit"] = new Money(50000);

            _accountId = _serviceProxy.Create(account);
            Console.WriteLine("Account '{0}' created with a credit limit of {1}.", account["name"], ((Money)account["creditlimit"]).Value);
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
                Console.WriteLine("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
            }

            if (deleteRecords)
            {
                // Delete the account record only if the row version matches.
                EntityReference accountToDelete = new EntityReference("account", _accountId);
                accountToDelete.RowVersion = _accountRowVersion;

                DeleteRequest request = new DeleteRequest()
                {
                    Target = accountToDelete,
                    ConcurrencyBehavior = ConcurrencyBehavior.IfRowVersionMatches
                };
                
                _serviceProxy.Execute(request);
                Console.WriteLine("Entity records have been deleted.");
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

                UpdateAndDelete app = new UpdateAndDelete();
                app.Run(config, true);
            }

             catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
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

// </snippetupdateanddelete>