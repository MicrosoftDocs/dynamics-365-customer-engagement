// <snippettransactioncurrencyexchangerate>


using System;
using System.Linq;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Discovery;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to retrieve a currency's exchange rates.
    /// </summary>
    /// <param name="serverConfig">Contains server connection information.</param>
    /// <param name="promptforDelete">When True, the user will be prompted to delete all
    /// created entities.</param>
    public class TransactionCurrencyExchangeRate
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;
        private ServiceContext _context;

        private TransactionCurrency _currency;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first creates a new currency within the system, setting its 
        /// exchange rate to a pre-defined value. It then issues a 
        /// RetrieveExchangeRateRequest to get the exchange rate from the created 
        /// currency to the organization's base currency. Finally, it retrieves the 
        /// organization's base currency and displays the conversion rate.
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
                // using the service context makes retrieving entities easier
                using (_context = new ServiceContext(_serviceProxy))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    String currentOrganizatoinUniqueName = GetCurrentOrganizationName(serverConfig);

                    CreateRequiredRecords();

                    RetrieveExchangeRateRequest request = new RetrieveExchangeRateRequest()
                    {
                        TransactionCurrencyId = _currency.Id
                    };
                    RetrieveExchangeRateResponse response = 
                        (RetrieveExchangeRateResponse)_serviceProxy.Execute(request);
                    Console.WriteLine("  Retrieved exchange rate for created currency");

                    // get the base currency for the current org
                    var baseCurrencyName = 
                        (from currency in _context.TransactionCurrencySet
                         join org in _context.OrganizationSet 
                         on currency.Id equals org.BaseCurrencyId.Id
                         where org.Name == currentOrganizatoinUniqueName
                         select currency.CurrencyName).FirstOrDefault();
                    Console.WriteLine("  This organization's base currency is {0}",
                        baseCurrencyName);

                    Console.WriteLine(
                        "  The conversion from {0} -> {1} is {2}",
                        _currency.CurrencyName,
                        baseCurrencyName,
                        response.ExchangeRate);

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

        private string GetCurrentOrganizationName(ServerConnection.Configuration serverConfig)
        {
            using (DiscoveryServiceProxy _discoveryProxy = new DiscoveryServiceProxy(serverConfig.DiscoveryUri,
                        serverConfig.HomeRealmUri, serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                RetrieveOrganizationsRequest orgsRequest =
                new RetrieveOrganizationsRequest()
                {
                    AccessType = EndpointAccessType.Default,
                    Release = OrganizationRelease.Current
                };
                RetrieveOrganizationsResponse organizations =
                    (RetrieveOrganizationsResponse)_discoveryProxy.Execute(orgsRequest);

                foreach (OrganizationDetail organization in organizations.Details)
                {
                    foreach (var endpoint in organization.Endpoints)
                    {
                        if (endpoint.Value.ToLowerInvariant() == serverConfig.OrganizationUri.ToString().ToLowerInvariant())
                            return organization.FriendlyName;
                    }
                }
            }
            return String.Empty;
        }

        #region Public Methods

        public void CreateRequiredRecords()
        {
            Console.WriteLine("  Creating currency 'Canadian Dollar'");
            // Create another currency
            _currency = new TransactionCurrency()
            {
                CurrencyName = "Canadian Dollar",
                CurrencyPrecision = 2,
                ExchangeRate = (decimal)0.9755,
                ISOCurrencyCode = "CAD", // Canadian Dollar currency code
                CurrencySymbol = "$"
            };
            _currency.Id = _serviceProxy.Create(_currency);
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
                _serviceProxy.Delete(TransactionCurrency.EntityLogicalName,
                    _currency.Id);
                Console.WriteLine("Entity records have been deleted.");
            }
        }

        #endregion

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

                TransactionCurrencyExchangeRate app = new TransactionCurrencyExchangeRate();
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

// </snippettransactioncurrencyexchangerate>