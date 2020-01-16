// <snippetsimplifiedconnection>


using System;
using System.Configuration;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Crm.Sdk.Proxy.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Crm.Sdk.Messages;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;

// These namespaces are found in the Microsoft.Xrm.Client.dll assembly
// located in the SDK\bin folder of the SDK download.
using System.Collections.Generic;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample uses the CrmConnection class found in the Microsoft.Xrm.Client
    /// namespace to connect to and authenticate with the organization web service.
    /// 
    /// Next, the sample demonstrates how to do basic entity operations like create,
    /// retrieve, update, and delete.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the database
    /// records created by this program.
    /// 
    /// No helper code from CrmServiceHelpers.cs is used in this sample.</remarks>
    /// <see cref="http://msdn.microsoft.com/library/gg695810.aspx"/>
    public class SimplifiedConnection
    {
        #region Class Level Members

        private Guid _accountId;
        private IOrganizationService _orgService;
        
        #endregion Class Level Members

         /// <summary>
        /// The Run() method first connects to the Organization service. Afterwards,
        /// basic create, retrieve, update, and delete entity operations are performed.
        /// </summary>
        /// <param name="connectionString">Provides service connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(String connectionString, bool promptforDelete)
        {
            try
            {
                // Connect to the CRM web service using a connection string.
                CrmServiceClient _orgService  = new Xrm.Tooling.Connector.CrmServiceClient(connectionString);
 
                //Create any entity records this sample requires.
                CreateRequiredRecords();

                // Obtain information about the logged on user from the web service.
                Guid userid = ((WhoAmIResponse)_orgService.Execute(new WhoAmIRequest())).UserId;
                SystemUser systemUser = (SystemUser)_orgService.Retrieve("systemuser", userid,
                    new ColumnSet(new string[] { "firstname", "lastname" }));
                Console.WriteLine("Logged on user is {0} {1}.", systemUser.FirstName, systemUser.LastName);

                // Retrieve the version of Microsoft Dynamics CRM.
                RetrieveVersionRequest versionRequest = new RetrieveVersionRequest();
                RetrieveVersionResponse versionResponse =
                    (RetrieveVersionResponse)_orgService.Execute(versionRequest);
                Console.WriteLine("Microsoft Dynamics CRM version {0}.", versionResponse.Version);

                // Instantiate an account object. Note the use of option set enumerations defined in OptionSets.cs.
                // Refer to the Entity Metadata topic in the SDK documentation to determine which attributes must
                // be set for each entity.
                Account account = new Account { Name = "Fourth Coffee" };
                account.AccountCategoryCode = new OptionSetValue((int)AccountAccountCategoryCode.PreferredCustomer);
                account.CustomerTypeCode = new OptionSetValue((int)AccountCustomerTypeCode.Investor);

                // Create an account record named Fourth Coffee.
                _accountId = _orgService.Create(account);

                Console.Write("{0} {1} created, ", account.LogicalName, account.Name);

                // Retrieve the several attributes from the new account.
                ColumnSet cols = new ColumnSet(
                    new String[] { "name", "address1_postalcode", "lastusedincampaign" });

                Account retrievedAccount = (Account)_orgService.Retrieve("account", _accountId, cols);
                Console.Write("retrieved, ");

                // Update the postal code attribute.
                retrievedAccount.Address1_PostalCode = "98052";

                // The address 2 postal code was set accidentally, so set it to null.
                retrievedAccount.Address2_PostalCode = null;

                // Shows use of a Money value.
                retrievedAccount.Revenue = new Money(5000000);

                // Shows use of a Boolean value.
                retrievedAccount.CreditOnHold = false;

                // Update the account record.
                _orgService.Update(retrievedAccount);
                Console.WriteLine("and updated.");

                // Delete any entity records this sample created.
                DeleteRequiredRecords(promptforDelete);
            }

            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
            {
                // You can handle an exception here or pass it back to the calling method.
                throw;
            }
        }

        #region Public Methods
        /// <summary>
        /// Creates any entity records this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // For this sample, all required entities are created in the Run() method.
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

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
            }

            if (deleteRecords)
            {
                _orgService.Delete(Account.EntityLogicalName, _accountId);
                Console.WriteLine("Entity records have been deleted.");
            }
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Gets web service connection information from the app.config file.
        /// If there is more than one available, the user is prompted to select
        /// the desired connection configuration by name.
        /// </summary>
        /// <returns>A string containing web service connection configuration information.</returns>
        private static String GetServiceConfiguration()
        {
            // Get available connection strings from app.config.
            int count = ConfigurationManager.ConnectionStrings.Count;

            // Create a filter list of connection strings so that we have a list of valid
            // connection strings for Microsoft Dynamics CRM only.
            List<KeyValuePair<String, String>> filteredConnectionStrings = 
                new List<KeyValuePair<String, String>>();

            for (int a = 0; a < count; a++)
            {
                if (isValidConnectionString(ConfigurationManager.ConnectionStrings[a].ConnectionString))
                    filteredConnectionStrings.Add
                        (new KeyValuePair<string, string>
                            (ConfigurationManager.ConnectionStrings[a].Name,
                            ConfigurationManager.ConnectionStrings[a].ConnectionString));
            }

            // No valid connections strings found. Write out and error message.
            if (filteredConnectionStrings.Count == 0)
            {
                Console.WriteLine("An app.config file containing at least one valid Microsoft Dynamics CRM " +
                    "connection string configuration must exist in the run-time folder.");
                Console.WriteLine("\nThere are several commented out example connection strings in " +
                    "the provided app.config file. Uncomment one of them and modify the string according " +
                    "to your Microsoft Dynamics CRM installation. Then re-run the sample.");
                return null;
            }

            // If one valid connection string is found, use that.
            if (filteredConnectionStrings.Count == 1)
            {
                return filteredConnectionStrings[0].Value;
            }

            // If more than one valid connection string is found, let the user decide which to use.
            if (filteredConnectionStrings.Count > 1)
            {
                Console.WriteLine("The following connections are available:");
                Console.WriteLine("------------------------------------------------");

                for (int i = 0; i < filteredConnectionStrings.Count; i++)
                {
                    Console.Write("\n({0}) {1}\t",
                    i + 1, filteredConnectionStrings[i].Key);
                }

                Console.WriteLine();

                Console.Write("\nType the number of the connection to use (1-{0}) [{0}] : ", 
                    filteredConnectionStrings.Count);
                String input = Console.ReadLine();
                int configNumber;
                if (input == String.Empty) input = filteredConnectionStrings.Count.ToString();
                if (!Int32.TryParse(input, out configNumber) || configNumber > count || 
                    configNumber == 0)
                {
                    Console.WriteLine("Option not valid.");
                    return null;
                }

                return filteredConnectionStrings[configNumber - 1].Value;

            }
            return null;
            
        }


        /// <summary>
        /// Verifies if a connection string is valid for Microsoft Dynamics CRM.
        /// </summary>
        /// <returns>True for a valid string, otherwise False.</returns>
        private static Boolean isValidConnectionString(String connectionString)
        {
            // At a minimum, a connection string must contain one of these arguments.
            if (connectionString.Contains("Url=") ||
                connectionString.Contains("Server=") ||
                connectionString.Contains("ServiceUri="))
                return true;

            return false;
        }
        
        #endregion Private Methods

        #region Main method

        /// <summary>
        /// Standard Main() method used by most SDK samples.
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            try
            {
                // Obtain connection configuration information for the Microsoft Dynamics
                // CRM organization web service.
                String connectionString = GetServiceConfiguration();

                if (connectionString != null)
                {
                    SimplifiedConnection app = new SimplifiedConnection();
                    app.Run(connectionString, true);
                }
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

// </snippetsimplifiedconnection>
