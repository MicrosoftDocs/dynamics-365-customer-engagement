// <snippetfulfillsalesorder>


using System;
using System.Linq;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample creates a SalesOrder record and demonstrates how to use the
    /// FulfillSalesOrderRequest to deactivate the record.
    /// </summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.
    /// </remarks>
    public class FulfillSalesOrder
    {
        #region Class Level Members
        private OrganizationServiceProxy _serviceProxy;
        private Guid? _salesOrderId;
        private Guid? _accountId;
        #endregion

        #region How To Sample Code

        /// <summary>
        /// Creates a sales order and shows how to close using the FulfillSalesOrderRequest 
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig,
           bool promptforDelete)
        {
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                // This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes();

                CreateCustomer();
                CreateSalesOrder();
                CloseSalesOrder();
                DeleteRequiredRecords(promptforDelete);
            }
        }

        /// <summary>
        /// Creates a customer for the sales order
        /// </summary>
        private void CreateCustomer()
        {
            // Create an account to be used with the sales account.
            _accountId = _serviceProxy.Create(new Account
            {
                Name = "Microsoft"
            });

            Console.WriteLine(String.Concat("Created account for sales order: ",
                _accountId.Value));
        }

        /// <summary>
        /// Creates the sales order to close 
        /// </summary>
        private void CreateSalesOrder()
        {
            // Create a sales order with an account
            _salesOrderId = _serviceProxy.Create(new SalesOrder
            {
                CustomerId = new EntityReference
                {
                    LogicalName = Account.EntityLogicalName, 
                    Id = _accountId.Value
                },
                Description = "Sales Order Description",  
            });

            Console.WriteLine(String.Concat("Created sales order: ",
                _salesOrderId.Value));
        }

        /// <summary>
        /// Calls the FulfillSalesOrderRequest and closes it as completed
        /// </summary>
        private void CloseSalesOrder()
        {
            if (!_salesOrderId.HasValue)
                return;
          
            // Close the sales order with a status of Complete
            int newStatus = (int)salesorder_statuscode.Complete;
            var request = new FulfillSalesOrderRequest
            {
                OrderClose = new OrderClose
                {
                    SalesOrderId = new EntityReference 
                        { LogicalName = SalesOrder.EntityLogicalName, Id = _salesOrderId.Value }
                    
                },
                Status = new OptionSetValue(newStatus)
            };

            Console.WriteLine(String.Concat("Executing FullfillSalesOrderRequest on sales order: ",
                _salesOrderId.Value, ",\n\t new status: ", 
                GetLabelForStatus(SalesOrder.EntityLogicalName, "statuscode", newStatus))); 
            
            _serviceProxy.Execute(request);

            // Validate that the sales order is complete
            var salesOrder = _serviceProxy.Retrieve(SalesOrder.EntityLogicalName, _salesOrderId.Value,
                new ColumnSet("statuscode")).ToEntity<SalesOrder>();

            Console.WriteLine(String.Concat("Validation of closed sales order: ", _salesOrderId.Value,
                ",\n\t status: ", salesOrder.FormattedValues["statuscode"]));
        }

        /// <summary>
        /// Returns the label for a status option
        /// </summary>
        /// <param name="entity">entity logical name</param>
        /// <param name="attribute">statuscode </param>
        /// <param name="value">numeric value</param>
        /// <returns>user label</returns>
        private string GetLabelForStatus(string entity, string attribute, int value)
        {
            // Retrieve the attribute metadata
            var attributeMD = ((RetrieveAttributeResponse) _serviceProxy.Execute(
                new RetrieveAttributeRequest
                {
                    EntityLogicalName = entity, 
                    LogicalName = attribute, 
                    RetrieveAsIfPublished = true,
                })).AttributeMetadata;

            // find the option based on the numeric value and return the label
            if (attributeMD.AttributeType == AttributeTypeCode.Status)
            {
                var options = ((StatusAttributeMetadata)attributeMD).OptionSet.Options;

                var crmOption = options.FirstOrDefault(x => x.Value == value);
                if (crmOption != null)
                    return crmOption.Label.UserLocalizedLabel.Label;
            }

            return string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="prompt"></param>
        private void DeleteRequiredRecords(bool prompt)
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
                // Delete records created in this sample.  Delete the sales order first
                // or there will be an error due to restrict delete.
                if (_salesOrderId.HasValue)
                {
                    Console.WriteLine(String.Concat("Deleting sales order: ", _salesOrderId.Value));
                    _serviceProxy.Delete(SalesOrder.EntityLogicalName, _salesOrderId.Value);
                }
                if (_accountId.HasValue)
                {
                    Console.WriteLine(String.Concat("Deleting account: ", _accountId.Value));
                    _serviceProxy.Delete(Account.EntityLogicalName, _accountId.Value);
                }
              
                Console.WriteLine("Entity records have been deleted.");
            }
        }

        #endregion

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

                var app = new FulfillSalesOrder();
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
        #endregion
    }
}

// </snippetfulfillsalesorder>