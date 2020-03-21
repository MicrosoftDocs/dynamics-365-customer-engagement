// <snippetprocessingquotesandsalesorders1>


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

// </snippetprocessingquotesandsalesorders1>