// <snippetworkingwithnegativeprices1>


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

// </snippetworkingwithnegativeprices1>