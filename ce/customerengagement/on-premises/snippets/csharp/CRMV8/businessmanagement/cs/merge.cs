// <snippetmerge>



using System;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to merge two entity records.
    /// </summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.
    /// </remarks>
    public class Merge
    {
        #region Class Level Members
        private OrganizationServiceProxy _serviceProxy;
        private Guid _account1Id;
        private Guid _account2Id;
        #endregion

        #region How To Sample Code
        /// <summary>
        /// This method shows how to merge two entity records with the Merge message.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptForDelete">When True, the user will be prompted to delete
        /// all created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig,bool promptForDelete)
        {
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                // This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes();

                //Create the Contact and Incident required for this sample.
                CreateRequiredRecords();
 
                // Create the target for the request.
			    EntityReference target = new EntityReference();

			    // Id is the GUID of the account that is being merged into.
                // LogicalName is the type of the entity being merged to, as a string
			    target.Id = _account1Id;
                target.LogicalName = Account.EntityLogicalName;

                // Create the request.
                MergeRequest merge = new MergeRequest();
                // SubordinateId is the GUID of the account merging.
                merge.SubordinateId = _account2Id;
                merge.Target = target;
                merge.PerformParentingChecks = false;

                Console.WriteLine("\nMerging account2 into account1 and adding " +
                    "\"test\" as Address 1 Line 1");

                // Create another account to hold new data to merge into the entity.
                // If you use the subordinate account object, its data will be merged.
                Account updateContent = new Account();
                updateContent.Address1_Line1 = "test";

                // Set the content you want updated on the merged account
                merge.UpdateContent = updateContent;

                // Execute the request.
                MergeResponse merged = (MergeResponse)_serviceProxy.Execute(merge);

                Account mergeeAccount = 
                    (Account)_serviceProxy.Retrieve(Account.EntityLogicalName, 
                    _account2Id, new ColumnSet(allColumns:true));

                if(mergeeAccount.Merged == true)
                {
                    Account mergedAccount =
                        (Account)_serviceProxy.Retrieve(Account.EntityLogicalName,
                        _account1Id, new ColumnSet(allColumns: true));

                    Console.WriteLine("\nAccounts merged successfully into account1");
                    Console.WriteLine("  Name: {0}", mergedAccount.Name);
                    Console.WriteLine("  Description: {0}", mergedAccount.Description);
                    Console.WriteLine("  Number of Employees: {0}", 
                        mergedAccount.NumberOfEmployees);
                    Console.WriteLine("  Address 1 Line 1: {0}", 
                        mergedAccount.Address1_Line1);
                }

                DeleteRequiredRecords(promptForDelete);
            }
        }

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Create the first account, which will be merged into
            Account account1 = new Account();
            account1.Name = "Fourth Coffee";
            account1.Description = "Coffee House";

            _account1Id = _serviceProxy.Create(account1);
            Console.WriteLine("Account 1 created with GUID {{{0}}}", _account1Id);
            Console.WriteLine("  Name: {0}", account1.Name);
            Console.WriteLine("  Description: {0}", account1.Description);

            // Create the second account, which will be merged from
            Account account2 = new Account();

            account2.Name = "Fourth Coffee";
            account2.NumberOfEmployees = 55;

            _account2Id = _serviceProxy.Create(account2);
            Console.WriteLine("Account 2 created with GUID {{{0}}}", _account2Id);
            Console.WriteLine("  Name: {0}", account2.Name);
            Console.WriteLine("  Number of Employees: {0}", account2.NumberOfEmployees);
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
                Console.Write("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();
                Console.WriteLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || 
                    answer == String.Empty);
            }

            if (deleteRecords)
            {
                _serviceProxy.Delete(Account.EntityLogicalName, _account1Id);
                _serviceProxy.Delete(Account.EntityLogicalName, _account2Id);
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
                ServerConnection.Configuration config = 
                    serverConnect.GetServerConfiguration();

                var app = new Merge();
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
            // Additional exceptions to catch: SecurityTokenValidationException, 
            // ExpiredSecurityTokenException, SecurityAccessDeniedException, 
            // MessageSecurityException, and SecurityNegotiationException.

            finally
            {
                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }
        }
        #endregion Main method
    }
}

// </snippetmerge>