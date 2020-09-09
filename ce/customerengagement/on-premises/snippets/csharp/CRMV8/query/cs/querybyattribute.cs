// <snippetquerybyattribute>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Collections.Generic;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to do basic entity operations like create, retrieve,
    /// update, and delete.</summary>
    
    public class QueryByAttributeSample
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;
        private List<Guid> _accountIds = new List<Guid>();

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// basic create, retrieve, update, and delete entity operations are performed.
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

                    _service = (IOrganizationService)_serviceProxy;

                    CreateRequiredRecords();

                    //  Create query using QueryByAttribute.
                    QueryByAttribute querybyattribute = new QueryByAttribute("account");
                    querybyattribute.ColumnSet = new ColumnSet("name", "address1_city", "emailaddress1");

                    //  Attribute to query.
                    querybyattribute.Attributes.AddRange("address1_city");

                    //  Value of queried attribute to return.
                    querybyattribute.Values.AddRange("Redmond");

                    //  Query passed to service proxy.
                    EntityCollection retrieved = _service.RetrieveMultiple(querybyattribute);

                    System.Console.WriteLine("Query Using QueryByAttribute");
                    System.Console.WriteLine("===============================");

                    //  Iterate through returned collection.
                    foreach (var c in retrieved.Entities)
                    {
                        System.Console.WriteLine("Name: " + c.Attributes["name"]);
                        
                        if( c.Attributes.Contains("address1_city") )
                            System.Console.WriteLine("Address: " + c.Attributes["address1_city"]);

                        if( c.Attributes.Contains("emailaddress1") )
                            System.Console.WriteLine("E-mail: " + c.Attributes["emailaddress1"]);
                    }
                    System.Console.WriteLine("===============================");

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
            // Create two accounts.
            Account account = new Account
            {
                Name = "A. Datum Corporation",
                Address1_StateOrProvince = "Colorado",
                Address1_Telephone1 = "(206)555-5555",
                EMailAddress1 = "info@datum.com"
            };
            _accountIds.Add(_service.Create(account));

            account = new Account
            {
                Name = "Adventure Works Cycle",
                Address1_StateOrProvince = "Washington",
                Address1_City = "Redmond",
                Address1_Telephone1 = "(206)555-5555",
                EMailAddress1 = "contactus@adventureworkscycle.com"
            };
            _accountIds.Add(_service.Create(account));
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
                if (answer.StartsWith("y") || answer.StartsWith("Y") ||
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
                foreach (Guid accountId in _accountIds)
                {
                    _service.Delete(Account.EntityLogicalName, accountId);
                }
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

                QueryByAttributeSample app = new QueryByAttributeSample();
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

// </snippetquerybyattribute>