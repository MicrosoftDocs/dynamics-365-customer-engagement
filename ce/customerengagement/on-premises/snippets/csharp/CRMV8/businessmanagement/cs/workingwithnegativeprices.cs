// <snippetworkingwithnegativeprices>


using System;
using System.Collections.Generic;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    ///  Show how to set negative values for amount and number attributes in 
    ///  opportunities, quotes, sales orders.
    /// </summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class WorkingWithNegativePrices
    {
        #region Class Level Members

        private Guid _salesManagerId;
        private Guid _unitGroupId;
        private Guid _defaultUnitId;
        private Guid _product1Id;
        private Guid _product2Id;
        private Guid _priceListId;
        private Guid _priceListItem1Id;
        private Guid _priceListItem2Id;
        private Guid _catalogProductId;
        private Guid _quoteId;
        private Guid _quoteDetailId;
        private Guid _orderId;
        private Guid _orderDetailId;
        private Guid _opportunityId;
        private Guid _accountId;
        private List<Guid> _salesRepresentativeIds = new List<Guid>();
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards, an 
        /// opportunity is created to demonstrate a negative estimated value. This is
        /// followed by the creation of a quote with a negative product quantity. 
        /// Finally, a sales order with a negative product price is shown.
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

                    #region Opportunity with negative estimated value

                    // Create a new opportunity with user-specified negative 
                    // estimated value.
                    Opportunity opportunity = new Opportunity
                    {
                        Name = "Example Opportunity",
                        CustomerId = new EntityReference(Account.EntityLogicalName,
                            _accountId),
                        PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName,
                            _priceListId),
                        IsRevenueSystemCalculated = false,
                        EstimatedValue = new Money(-400.00m),
                        FreightAmount = new Money(10.00m),
                        ActualValue = new Money(-390.00m),
                        OwnerId = new EntityReference
                        {
                            Id = _salesRepresentativeIds[0],
                            LogicalName = SystemUser.EntityLogicalName
                        }
                    };
                    _opportunityId = _serviceProxy.Create(opportunity);
                    opportunity.Id = _opportunityId;

                    // Create a catalog product for the opportunity.
                    OpportunityProduct catalogProduct = new OpportunityProduct
                    {
                        OpportunityId = opportunity.ToEntityReference(),
                        ProductId = new EntityReference(Product.EntityLogicalName,
                            _product1Id),
                        UoMId = new EntityReference(UoM.EntityLogicalName,
                            _defaultUnitId),
                        Quantity = 8,
                        Tax = new Money(12.42m),
                    };
                    _catalogProductId = _serviceProxy.Create(catalogProduct);

                    Console.WriteLine("Created opportunity with negative estimated value.");

                    #endregion

                    #region Quote with negative quantity

                    // Create the quote.
                    Quote quote = new Quote()
                    {
                        CustomerId = new EntityReference(Account.EntityLogicalName, 
                            _accountId),
                        Name = "Sample Quote",
                        PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName,
                            _priceListId)
                    };
                    _quoteId = _serviceProxy.Create(quote);
                    quote.Id = _quoteId;

                    // Set the quote's product quantity to a negative value.
                    QuoteDetail quoteDetail = new QuoteDetail()
                    {
                        ProductId = new EntityReference(Product.EntityLogicalName,
                            _product1Id),
                        Quantity = -4,
                        QuoteId = quote.ToEntityReference(),
                        UoMId = new EntityReference(UoM.EntityLogicalName, 
                            _defaultUnitId)
                    };
                    _quoteDetailId = _serviceProxy.Create(quoteDetail);

                    Console.WriteLine("Created quote with negative quantity.");

                    #endregion

                    #region Sales Order with negative price

                    // Create the sales order.
                    SalesOrder order = new SalesOrder()
                    {
                        Name = "Faux Order",
                        DateFulfilled = new DateTime(2010, 8, 1),
                        PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName,
                            _priceListId),
                        CustomerId = new EntityReference(Account.EntityLogicalName,
                            _accountId),
                        FreightAmount = new Money(20.0M)
                    };
                    _orderId = _serviceProxy.Create(order);
                    order.Id = _orderId;

                    // Add the product to the order with the price overriden with a
                    // negative value.
                    SalesOrderDetail orderDetail = new SalesOrderDetail()
                    {
                        ProductId = new EntityReference(Product.EntityLogicalName, 
                            _product1Id),
                        Quantity = 4,
                        SalesOrderId = order.ToEntityReference(),
                        IsPriceOverridden = true,
                        PricePerUnit = new Money(-40.0M),
                        UoMId = new EntityReference(UoM.EntityLogicalName, 
                            _defaultUnitId)
                    };
                    _orderDetailId = _serviceProxy.Create(orderDetail);

                    Console.WriteLine("Created order with negative price per unit.");

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

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
           #region Create or Retrieve the necessary system users

            // Retrieve the ldapPath
            String ldapPath = String.Empty;
            // Retrieve the sales team - 1 sales manager and 2 sales representatives.
            _salesManagerId =
                SystemUserProvider.RetrieveSalesManager(_serviceProxy, ref ldapPath);
            _salesRepresentativeIds = 
                SystemUserProvider.RetrieveSalespersons(_serviceProxy, ref ldapPath);

            #endregion

            #region Create records to support Opportunity records
            // Create a unit group
            UoMSchedule newUnitGroup = new UoMSchedule
            {
                Name = "Example Unit Group",
                BaseUoMName = "Example Primary Unit"
            };
            _unitGroupId = _serviceProxy.Create(newUnitGroup);

            // Retrieve the default unit id that was automatically created
            // when we created the Unit Group
            QueryExpression unitQuery = new QueryExpression
            {
                EntityName = UoM.EntityLogicalName,
                ColumnSet = new ColumnSet("uomid", "name"),
                Criteria = new FilterExpression
                {
                    Conditions = 
                        {
                            new ConditionExpression 
                            {
                                AttributeName = "uomscheduleid",
                                Operator = ConditionOperator.Equal,
                                Values = { _unitGroupId }
                            }
                        }
                },
                PageInfo = new PagingInfo
                {
                    PageNumber = 1,
                    Count = 1
                }
            };

            // Retrieve the unit.
            UoM unit = (UoM)_serviceProxy.RetrieveMultiple(unitQuery).Entities[0];
            _defaultUnitId = unit.UoMId.Value;

            // Create a few products
            Product newProduct1 = new Product
            {
                ProductNumber = "1",
                Name = "Example Product 1",
                ProductStructure = new OptionSetValue(1),
                QuantityDecimal = 2,
                DefaultUoMScheduleId = new EntityReference(UoMSchedule.EntityLogicalName,
                    _unitGroupId),
                DefaultUoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId)
            };
            _product1Id = _serviceProxy.Create(newProduct1);
            Console.WriteLine("Created {0}", newProduct1.Name);

            Product newProduct2 = new Product
            {
                ProductNumber = "2",
                Name = "Example Product 2",
                ProductStructure = new OptionSetValue(1),
                QuantityDecimal = 3,
                DefaultUoMScheduleId = new EntityReference(UoMSchedule.EntityLogicalName,
                    _unitGroupId),
                DefaultUoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId)
            };
            _product2Id = _serviceProxy.Create(newProduct2);
            Console.WriteLine("Created {0}", newProduct2.Name);

            // Create a price list
            PriceLevel newPriceList = new PriceLevel
            {
                Name = "Example Price List"
            };
            _priceListId = _serviceProxy.Create(newPriceList);

            // Create a price list item for the first product and apply volume discount
            ProductPriceLevel newPriceListItem1 = new ProductPriceLevel
            {
                PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName, _priceListId),
                ProductId = new EntityReference(Product.EntityLogicalName, _product1Id),
                UoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId),
                Amount = new Money(20)
            };
            _priceListItem1Id = _serviceProxy.Create(newPriceListItem1);

            // Create a price list item for the second product
            ProductPriceLevel newPriceListItem2 = new ProductPriceLevel
            {
                PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName, _priceListId),
                ProductId = new EntityReference(Product.EntityLogicalName, _product2Id),
                UoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId),
                Amount = new Money(15)
            };
            _priceListItem2Id = _serviceProxy.Create(newPriceListItem2);

            //Publish Product1
            SetStateRequest publishRequest1 = new SetStateRequest
            {
                EntityMoniker = new EntityReference(Product.EntityLogicalName, _product1Id),
                State = new OptionSetValue((int)ProductState.Active),
                Status = new OptionSetValue(1)
            };
            _serviceProxy.Execute(publishRequest1);

            //Publish Product2
            SetStateRequest publishRequest2 = new SetStateRequest
            {
                EntityMoniker = new EntityReference(Product.EntityLogicalName, _product2Id),
                State = new OptionSetValue((int)ProductState.Active),
                Status = new OptionSetValue(1)
            };
            _serviceProxy.Execute(publishRequest2);
            Console.WriteLine("Published both the products");

            // Create an account record for the opportunity's potential customerid
            Account newAccount = new Account
            {
                Name = "Margie's Travel",
                Address1_PostalCode = "99999"
            };
            _accountId = (_serviceProxy.Create(newAccount));

            #endregion Create records to support Opportunity records

        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            // Two of the contracts, their associated account and the contract template
            // records that were created and used in this sample will continue to exist 
            // on your system because contracts that have been invoiced cannot be deleted 
            // in Microsoft Dynamics CRM. They can only be put on hold or canceled.

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
                _serviceProxy.Delete(SalesOrderDetail.EntityLogicalName, _orderDetailId);
                _serviceProxy.Delete(SalesOrder.EntityLogicalName, _orderId);
                _serviceProxy.Delete(QuoteDetail.EntityLogicalName, _quoteDetailId);
                _serviceProxy.Delete(Quote.EntityLogicalName, _quoteId);
                _serviceProxy.Delete(Opportunity.EntityLogicalName, _opportunityId);
                _serviceProxy.Delete(ProductPriceLevel.EntityLogicalName, _priceListItem1Id);
                _serviceProxy.Delete(ProductPriceLevel.EntityLogicalName, _priceListItem2Id);
                _serviceProxy.Delete(PriceLevel.EntityLogicalName, _priceListId);
                _serviceProxy.Delete(Product.EntityLogicalName, _product1Id);
                _serviceProxy.Delete(Product.EntityLogicalName, _product2Id);
                _serviceProxy.Delete(UoMSchedule.EntityLogicalName, _unitGroupId);
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

                WorkingWithNegativePrices app = new WorkingWithNegativePrices();
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

// </snippetworkingwithnegativeprices>