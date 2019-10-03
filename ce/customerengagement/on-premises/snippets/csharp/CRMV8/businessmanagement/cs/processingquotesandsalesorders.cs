// <snippetprocessingquotesandsalesorders>


using System;
using System.ServiceModel;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to convert a "won" opportunity to a quote and then convert a quote
    /// to a sales order, and a sales order to an invoice. Also demonstrates 
    /// locking/unlocking prices on both sales orders and invoices.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class ProcessingQuotesAndSalesOrders
    {
        #region Class Level Members

        private Guid _opportunityId;
        private Guid _loseOpportunityId;
        private Guid _unitGroupId;
        private Guid _defaultUnitId;
        private Guid _productId;
        private Guid _priceListId;
        private Guid _priceListItemId;
        private Guid _accountId;
        private Guid _quoteId;
        private Guid _closeQuoteId;
        private Guid _quoteDetailId;
        private Guid _salesOrderId;
        private Guid _closeSalesOrderId;
        private Guid _invoiceId;

        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards, a 
        /// quote is created. This quote is then converted to an order, and the pricing
        /// is unlocked and relocked. This is followed by the order being converted
        /// to an invoice, and the pricing is locked then unlocked.
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

                    #region Create Opportunities

                    // Create an opportunity
                    var crmOpportunity = new Opportunity
                    {
                        CustomerId = new EntityReference(Account.EntityLogicalName, _accountId),
                        Name = "Sample",
                        PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName,
                            _priceListId)
                    };
                    _opportunityId = _serviceProxy.Create(crmOpportunity);

                    crmOpportunity = new Opportunity
                    {
                        CustomerId = new EntityReference(Account.EntityLogicalName, _accountId),
                        Name = "Another Sample",
                        PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName,
                            _priceListId)
                    };
                    _loseOpportunityId = _serviceProxy.Create(crmOpportunity);

                    Console.WriteLine("Opportunities created.");

                    #endregion

                    #region Win Opportunity

                    // Close the opportunity as won
                    var winOppRequest = new WinOpportunityRequest
                    {
                        OpportunityClose = new OpportunityClose
                        {
                            OpportunityId = new EntityReference
                                (Opportunity.EntityLogicalName, _opportunityId)
                        },
                        Status = new OptionSetValue((int)opportunity_statuscode.Won)
                    };

                    _serviceProxy.Execute(winOppRequest);

                    Console.WriteLine("Opportunity closed as Won.");

                    #endregion

                    #region Lose Opportunity
                    var loseOppRequest = new LoseOpportunityRequest
                    {
                        OpportunityClose = new OpportunityClose
                        {
                            OpportunityId = new EntityReference
                                (Opportunity.EntityLogicalName, _loseOpportunityId)
                        },
                        Status = new OptionSetValue((int)opportunity_statuscode.Canceled)
                    };

                    _serviceProxy.Execute(loseOppRequest);

                    Console.WriteLine("Opportunity closed as Lost.");

                    #endregion

                    #region Convert Opportunity to a Quote

                    // Convert the opportunity to a quote
                    var genQuoteFromOppRequest = new GenerateQuoteFromOpportunityRequest
                    {
                        OpportunityId = _opportunityId,
                        ColumnSet = new ColumnSet("quoteid", "name")
                    };

                    var genQuoteFromOppResponse = (GenerateQuoteFromOpportunityResponse)
                        _serviceProxy.Execute(genQuoteFromOppRequest);

                    Quote quote = genQuoteFromOppResponse.Entity.ToEntity<Quote>();
                    _quoteId = quote.Id;

                    Console.WriteLine("Quote generated from the Opportunity.");

                    #endregion

                    #region Close Quote

                    // convert the opportunity to a quote
                    genQuoteFromOppRequest = new GenerateQuoteFromOpportunityRequest
                    {
                        OpportunityId = _opportunityId,
                        ColumnSet = new ColumnSet("quoteid", "name")
                    };
                    genQuoteFromOppResponse = (GenerateQuoteFromOpportunityResponse)
                        _serviceProxy.Execute(genQuoteFromOppRequest);

                    Quote closeQuote = genQuoteFromOppResponse.Entity.ToEntity<Quote>();
                    _closeQuoteId = closeQuote.Id;

                    // Activate the quote
                    SetStateRequest activateQuote = new SetStateRequest()
                    {
                        EntityMoniker = closeQuote.ToEntityReference(),
                        State = new OptionSetValue((int)QuoteState.Active),
                        Status = new OptionSetValue((int)quote_statuscode.InProgress)
                    };
                    _serviceProxy.Execute(activateQuote);

                    // Close the quote
                    CloseQuoteRequest closeQuoteRequest = new CloseQuoteRequest()
                    {
                        QuoteClose = new QuoteClose()
                        {
                            QuoteId = closeQuote.ToEntityReference(),
                            Subject = "Quote Close " + DateTime.Now.ToString()
                        },
                        Status = new OptionSetValue(-1)
                    };
                    _serviceProxy.Execute(closeQuoteRequest);

                    Console.WriteLine("Quote Closed");

                    #endregion

                    #region Create Quote's Product

                    // Set the quote's product
                    QuoteDetail quoteDetail = new QuoteDetail()
                    {
                        ProductId = new EntityReference(Product.EntityLogicalName,
                            _productId),
                        Quantity = 1,
                        QuoteId = quote.ToEntityReference(),
                        UoMId = new EntityReference(UoM.EntityLogicalName,
                            _defaultUnitId)
                    };
                    _quoteDetailId = _serviceProxy.Create(quoteDetail);

                    Console.WriteLine("Quote Product created.");

                    // Activate the quote
                    activateQuote = new SetStateRequest()
                    {
                        EntityMoniker = quote.ToEntityReference(),
                        State = new OptionSetValue((int)QuoteState.Active),
                        Status = new OptionSetValue((int)quote_statuscode.InProgress)
                    };
                    _serviceProxy.Execute(activateQuote);

                    Console.WriteLine("Quote activated.");


                    // Mark the quote as won
                    // Note: this is necessary in order to convert a quote into a 
                    // SalesOrder.
                    WinQuoteRequest winQuoteRequest = new WinQuoteRequest()
                    {
                        QuoteClose = new QuoteClose()
                        {
                            Subject = "Quote Close" + DateTime.Now.ToString(),
                            QuoteId = quote.ToEntityReference()
                        },
                        Status = new OptionSetValue(-1)
                    };
                    _serviceProxy.Execute(winQuoteRequest);

                    Console.WriteLine("Quote won.");

                    #endregion

                    #region Convert Quote to SalesOrder


                    // Define columns to be retrieved after creating the order
                    ColumnSet salesOrderColumns =
                        new ColumnSet("salesorderid", "totalamount");

                    // Convert the quote to a sales order
                    ConvertQuoteToSalesOrderRequest convertQuoteRequest =
                        new ConvertQuoteToSalesOrderRequest()
                        {
                            QuoteId = _quoteId,
                            ColumnSet = salesOrderColumns
                        };
                    ConvertQuoteToSalesOrderResponse convertQuoteResponse =
                        (ConvertQuoteToSalesOrderResponse)_serviceProxy.Execute(convertQuoteRequest);
                    SalesOrder salesOrder = (SalesOrder)convertQuoteResponse.Entity;
                    _salesOrderId = salesOrder.Id;

                    Console.WriteLine("Converted Quote to SalesOrder.");

                    #endregion

                    #region Cancel Sales Order


                    // Define columns to be retrieved after creating the order
                    salesOrderColumns = new ColumnSet("salesorderid", "totalamount");

                    // Convert the quote to a sales order
                    convertQuoteRequest =
                        new ConvertQuoteToSalesOrderRequest()
                        {
                            QuoteId = _quoteId,
                            ColumnSet = salesOrderColumns
                        };
                    convertQuoteResponse =
                        (ConvertQuoteToSalesOrderResponse)_serviceProxy.Execute(convertQuoteRequest);
                    SalesOrder closeSalesOrder = (SalesOrder)convertQuoteResponse.Entity;
                    _closeSalesOrderId = closeSalesOrder.Id;

                    CancelSalesOrderRequest cancelRequest = new CancelSalesOrderRequest()
                    {
                        OrderClose = new OrderClose()
                        {
                            SalesOrderId = closeSalesOrder.ToEntityReference(),
                            Subject = "Close Sales Order " + DateTime.Now
                        },
                        Status = new OptionSetValue(-1)
                    };
                    _serviceProxy.Execute(cancelRequest);

                    Console.WriteLine("Canceled sales order");

                    #endregion

                    #region Lock pricing on SalesOrder

                    // Note: after converting a won quote to an order, the pricing of 
                    // the order is locked by default.


                    // Retrieve current price list
                    ProductPriceLevel priceListItem =
                        (ProductPriceLevel)_serviceProxy.Retrieve(
                            ProductPriceLevel.EntityLogicalName,
                            _priceListItemId,
                            new ColumnSet("productpricelevelid", "amount")
                        );

                    Console.WriteLine("Current price list retrieved.");
                    Console.WriteLine();

                    Console.WriteLine("Details before update:");
                    Console.WriteLine("----------------");
                    Console.WriteLine("Current order total: {0}",
                        salesOrder.TotalAmount.Value);
                    Console.WriteLine("Current price per item: {0}",
                        priceListItem.Amount.Value);
                    Console.WriteLine("</End of Listing>");
                    Console.WriteLine();

                    // Update the price list
                    priceListItem.Amount = new Money(30.0M);

                    UpdateRequest updatePriceListItem = new UpdateRequest()
                    {
                        Target = priceListItem,
                    };
                    _serviceProxy.Execute(updatePriceListItem);

                    Console.WriteLine("Price list updated.");

                    // Retrieve the order
                    SalesOrder updatedSalesOrder = (SalesOrder)_serviceProxy.Retrieve(
                            SalesOrder.EntityLogicalName,
                            _salesOrderId,
                            new ColumnSet("salesorderid", "totalamount")
                        );

                    Console.WriteLine("Updated order retrieved.");
                    Console.WriteLine();

                    Console.WriteLine("Details after update:");
                    Console.WriteLine("----------------");
                    Console.WriteLine("Current order total: {0}",
                        updatedSalesOrder.TotalAmount.Value);
                    Console.WriteLine("Current price per item: {0}",
                        priceListItem.Amount.Value);
                    Console.WriteLine("</End of Listing>");
                    Console.WriteLine();

                    // Unlock the order pricing
                    UnlockSalesOrderPricingRequest unlockOrderRequest =
                        new UnlockSalesOrderPricingRequest()
                        {
                            SalesOrderId = _salesOrderId
                        };
                    _serviceProxy.Execute(unlockOrderRequest);

                    Console.WriteLine("Order pricing unlocked.");

                    // Retrieve the order
                    updatedSalesOrder = (SalesOrder)_serviceProxy.Retrieve(
                            SalesOrder.EntityLogicalName,
                            _salesOrderId,
                            new ColumnSet("salesorderid", "totalamount")
                        );

                    Console.WriteLine("Updated order retrieved.");
                    Console.WriteLine();

                    Console.WriteLine("Details after update and unlock:");
                    Console.WriteLine("----------------");
                    Console.WriteLine("Current order total: {0}",
                        updatedSalesOrder.TotalAmount.Value);
                    Console.WriteLine("Current price per item: {0}",
                        priceListItem.Amount.Value);
                    Console.WriteLine("</End of Listing>");
                    Console.WriteLine();

                    // Relock the order pricing
                    LockSalesOrderPricingRequest lockOrderRequest =
                        new LockSalesOrderPricingRequest()
                        {
                            SalesOrderId = _salesOrderId
                        };
                    _serviceProxy.Execute(lockOrderRequest);


                    Console.WriteLine("Order pricing relocked.");

                    #endregion

                    #region Convert SalesOrder to Invoice

                    // Define columns to be retrieved after creating the invoice
                    ColumnSet invoiceColumns =
                        new ColumnSet("invoiceid", "totalamount");

                    // Convert the order to an invoice
                    ConvertSalesOrderToInvoiceRequest convertOrderRequest =
                        new ConvertSalesOrderToInvoiceRequest()
                        {
                            SalesOrderId = _salesOrderId,
                            ColumnSet = invoiceColumns
                        };
                    ConvertSalesOrderToInvoiceResponse convertOrderResponse =
                        (ConvertSalesOrderToInvoiceResponse)_serviceProxy.Execute(convertOrderRequest);
                    Invoice invoice = (Invoice)convertOrderResponse.Entity;
                    _invoiceId = invoice.Id;

                    Console.WriteLine("Converted SalesOrder to Invoice.");

                    #endregion

                    #region Lock pricing on Invoice

                    // Note: after converting a SalesOrder to Invoice, the pricing of 
                    // the Invoice is locked by default.

                    // Retrieve current price list
                    priceListItem = (ProductPriceLevel)_serviceProxy.Retrieve(
                            ProductPriceLevel.EntityLogicalName,
                            _priceListItemId,
                            new ColumnSet("productpricelevelid", "amount")
                        );

                    Console.WriteLine("Current price list retrieved.");
                    Console.WriteLine();

                    Console.WriteLine("Details before lock and update:");
                    Console.WriteLine("----------------");
                    Console.WriteLine("Current invoice total: {0}",
                        invoice.TotalAmount.Value);
                    Console.WriteLine("Current price per item: {0}",
                        priceListItem.Amount.Value);
                    Console.WriteLine("</End of Listing>");
                    Console.WriteLine();

                    // Update the price list
                    priceListItem.Amount = new Money(40.0M);

                    updatePriceListItem = new UpdateRequest()
                    {
                        Target = priceListItem
                    };
                    _serviceProxy.Execute(updatePriceListItem);

                    Console.WriteLine("Price list updated.");


                    // Retrieve the invoice
                    Invoice updatedInvoice = (Invoice)_serviceProxy.Retrieve(
                            Invoice.EntityLogicalName,
                            _invoiceId,
                            new ColumnSet("invoiceid", "totalamount")
                        );

                    Console.WriteLine("Updated invoice retrieved.");
                    Console.WriteLine();

                    Console.WriteLine("Details after lock and update:");
                    Console.WriteLine("----------------");
                    Console.WriteLine("Current invoice total: {0}",
                        updatedInvoice.TotalAmount.Value);
                    Console.WriteLine("Current price per item: {0}",
                        priceListItem.Amount.Value);
                    Console.WriteLine("</End of Listing>");
                    Console.WriteLine();

                    // Unlock the invoice pricing
                    UnlockInvoicePricingRequest unlockInvoiceRequest =
                        new UnlockInvoicePricingRequest()
                        {
                            InvoiceId = _invoiceId
                        };
                    _serviceProxy.Execute(unlockInvoiceRequest);

                    Console.WriteLine("Invoice pricing unlocked.");

                    // Retrieve the invoice
                    updatedInvoice = (Invoice)_serviceProxy.Retrieve(
                            Invoice.EntityLogicalName,
                            _invoiceId,
                            new ColumnSet("invoiceid", "totalamount")
                        );

                    Console.WriteLine("Updated invoice retrieved.");
                    Console.WriteLine();

                    Console.WriteLine("Details after update and unlock:");
                    Console.WriteLine("----------------");
                    Console.WriteLine("Current invoice total: {0}",
                        updatedInvoice.TotalAmount.Value);
                    Console.WriteLine("Current price per item: {0}",
                        priceListItem.Amount.Value);
                    Console.WriteLine("</End of Listing>");
                    Console.WriteLine();

                    // Relock the invoice pricing
                    LockInvoicePricingRequest lockInvoiceRequest =
                        new LockInvoicePricingRequest()
                        {
                            InvoiceId = _invoiceId
                        };
                    _serviceProxy.Execute(lockInvoiceRequest);

                    Console.WriteLine("Invoice pricing relocked.");

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
            // Create a unit group
            UoMSchedule newUnitGroup = new UoMSchedule
            {
                Name = "Example Unit Group",
                BaseUoMName = "Example Primary Unit"
            };
            _unitGroupId = _serviceProxy.Create(newUnitGroup);
            Console.WriteLine("Create {0}", newUnitGroup.Name);

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
            Product newProduct = new Product
            {
                ProductNumber = "1",
                Name = "Example Product",
                ProductStructure = new OptionSetValue(1),
                QuantityDecimal = 1,
                DefaultUoMScheduleId =
                    new EntityReference(UoMSchedule.EntityLogicalName, _unitGroupId),
                DefaultUoMId =
                    new EntityReference(UoM.EntityLogicalName, _defaultUnitId)
            };
            _productId = _serviceProxy.Create(newProduct);
            newProduct.Id = _productId;
            Console.WriteLine("Create {0}", newProduct.Name);

            // Create a price list
            PriceLevel newPriceList = new PriceLevel
            {
                Name = "Example Price List"
            };
            _priceListId = _serviceProxy.Create(newPriceList);

            // Create a price list item for the product and apply volume discount
            ProductPriceLevel newPriceListItem = new ProductPriceLevel
            {
                PriceLevelId =
                    new EntityReference(PriceLevel.EntityLogicalName, _priceListId),
                ProductId =
                    new EntityReference(Product.EntityLogicalName, _productId),
                UoMId =
                    new EntityReference(UoM.EntityLogicalName, _defaultUnitId),
                Amount = new Money(20.0M),
            };
            _priceListItemId = _serviceProxy.Create(newPriceListItem);

            // Publish the product
            SetStateRequest publishRequest = new SetStateRequest
            {
                EntityMoniker = new EntityReference(Product.EntityLogicalName, _productId),
                State = new OptionSetValue((int)ProductState.Active),
                Status = new OptionSetValue(1)
            };
            _serviceProxy.Execute(publishRequest);
            Console.WriteLine("Published {0}", newProduct.Name);

            // Create an account record for the opportunity's potential customerid 
            Account newAccount = new Account
            {
                Name = "Litware, Inc.",
                Address1_PostalCode = "60661"
            };
            _accountId = _serviceProxy.Create(newAccount);
            newAccount.Id = _accountId;

        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            // The three system users that were created by this sample will continue to 
            // exist on your system because system users cannot be deleted in Microsoft
            // Dynamics CRM.  They can only be enabled or disabled.

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
                _serviceProxy.Delete("invoice", _invoiceId);
                _serviceProxy.Delete("salesorder", _salesOrderId);
                _serviceProxy.Delete("salesorder", _closeSalesOrderId);
                _serviceProxy.Delete("quotedetail", _quoteDetailId);
                _serviceProxy.Delete("quote", _quoteId);
                _serviceProxy.Delete("quote", _closeQuoteId);
                _serviceProxy.Delete("opportunity", _opportunityId);
                _serviceProxy.Delete("opportunity", _loseOpportunityId);
                _serviceProxy.Delete("account", _accountId);
                _serviceProxy.Delete("productpricelevel", _priceListItemId);
                _serviceProxy.Delete("pricelevel", _priceListId);
                _serviceProxy.Delete("product", _productId);
                _serviceProxy.Delete("uomschedule", _unitGroupId);

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

                ProcessingQuotesAndSalesOrders app = new ProcessingQuotesAndSalesOrders();
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

// </snippetprocessingquotesandsalesorders>