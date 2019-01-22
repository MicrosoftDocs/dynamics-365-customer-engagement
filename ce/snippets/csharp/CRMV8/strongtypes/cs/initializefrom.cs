// <snippetinitializefrom>


using System;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk.Client;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to use the InitializeFrom message to create new records
    /// from existing records
    /// </summary>
    /// <param name="serverConfig">Contains server connection information.</param>
    /// <param name="promptforDelete">When True, the user will be prompted to delete all
    /// created entities.</param>
    public class InitializeFrom
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;

        private Account _initialAccount;
        private Lead _initialLead;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first creates an account and a lead, then initializes a new
        /// account from the already existing account and a new opportunity from the
        /// already existing lead.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>

        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly 
                // disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();


                    #region Initialize Account from Account
                    Console.WriteLine();
                    Console.WriteLine("  Initializing new Account from the initial Account");

                    // Create the request object
                    InitializeFromRequest initialize = new InitializeFromRequest();

                    // Set the properties of the request object
                    initialize.TargetEntityName = Account.EntityLogicalName.ToString();

                    // Create the EntityMoniker
                    initialize.EntityMoniker = _initialAccount.ToEntityReference();

                    // Execute the request
                    InitializeFromResponse initialized = 
                        (InitializeFromResponse)_serviceProxy.Execute(initialize);

                    if (initialized.Entity != null)
                        Console.WriteLine("  New Account initialized successfully");

                    Console.WriteLine();
                    #endregion

                    #region Initialize Opportunity from Lead
                    Console.WriteLine("  Initializing an Opportunity from the initial Lead");

                    // Create the request object
                    initialize.TargetEntityName = Opportunity.EntityLogicalName.ToString();

                    // Create the EntityMoniker
                    initialize.EntityMoniker = _initialLead.ToEntityReference();

                    // Execute the request
                    initialized =
                        (InitializeFromResponse)_serviceProxy.Execute(initialize);

                    if (initialized.Entity != null &&
                        initialized.Entity.LogicalName == Opportunity.EntityLogicalName)
                    {
                        var opportunity = (Opportunity)initialized.Entity;
                        Console.WriteLine("  New Opportunity initialized successfully (Name={0})",
                            opportunity.Name);
                    }
                    #endregion

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

        #region Public methods

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            _initialAccount = new Account()
            {
                Name = "Contoso, Ltd"
            };
            _initialAccount.Id = _serviceProxy.Create(_initialAccount);
            Console.WriteLine("  Created initial Account (Name={0})",
                _initialAccount.Name);

            _initialLead = new Lead()
            {
                Subject = "A Sample Lead",
                LastName = "Wilcox",
                FirstName = "Colin",
            };
            _initialLead.Id = _serviceProxy.Create(_initialLead);
            Console.WriteLine("  Created initial Lead (Subject={0}, Name={1} {2})",
                _initialLead.Subject,
                _initialLead.FirstName,
                _initialLead.LastName);
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
                _serviceProxy.Delete(Account.EntityLogicalName, _initialAccount.Id);
                _serviceProxy.Delete(Lead.EntityLogicalName, _initialLead.Id);
                Console.WriteLine("Entity records have been deleted.");
            }
        }
        #endregion Public Methods

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

                InitializeFrom app = new InitializeFrom();
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

// </snippetinitializefrom>