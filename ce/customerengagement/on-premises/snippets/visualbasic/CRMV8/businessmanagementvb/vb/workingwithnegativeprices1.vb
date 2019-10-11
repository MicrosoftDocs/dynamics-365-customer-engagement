' <snippetworkingwithnegativeprices1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     CreateRequiredRecords()

     '					#Region "Opportunity with negative estimated value"

     ' Create a new opportunity with user-specified negative 
     ' estimated value.
     Dim opportunity As Opportunity =
         New Opportunity With
         {
             .Name = "Example Opportunity",
             .CustomerId =
             New EntityReference(Account.EntityLogicalName,
                                 _accountId),
             .PriceLevelId =
             New EntityReference(PriceLevel.EntityLogicalName,
                                 _priceListId),
             .IsRevenueSystemCalculated = False,
             .EstimatedValue = New Money(-400D),
             .FreightAmount = New Money(10D),
             .ActualValue = New Money(-390D),
             .OwnerId =
             New EntityReference With
             {
                 .Id = _salesRepresentativeIds(0),
                 .LogicalName = SystemUser.EntityLogicalName
             }
         }
     _opportunityId = _serviceProxy.Create(opportunity)
     opportunity.Id = _opportunityId

     ' Create a catalog product for the opportunity.
     Dim catalogProduct As OpportunityProduct =
         New OpportunityProduct With
         {
             .OpportunityId = opportunity.ToEntityReference(),
             .ProductId =
             New EntityReference(Product.EntityLogicalName,
                                 _product1Id),
             .UoMId =
             New EntityReference(UoM.EntityLogicalName,
                                 _defaultUnitId),
             .Quantity = 8,
             .Tax = New Money(12.42D)
         }
     _catalogProductId = _serviceProxy.Create(catalogProduct)

     Console.WriteLine(
         "Created opportunity with negative estimated value.")

     '					#End Region

     '					#Region "Quote with negative quantity"

     ' Create the quote.
     Dim quote As New Quote() With
         {
             .CustomerId =
             New EntityReference(Account.EntityLogicalName,
                                 _accountId),
             .Name = "Sample Quote",
             .PriceLevelId =
             New EntityReference(PriceLevel.EntityLogicalName,
                                 _priceListId)
         }
     _quoteId = _serviceProxy.Create(quote)
     quote.Id = _quoteId

     ' Set the quote's product quantity to a negative value.
     Dim quoteDetail As New QuoteDetail() With
         {
             .ProductId =
             New EntityReference(Product.EntityLogicalName,
                                 _product1Id),
             .Quantity = -4,
             .QuoteId = quote.ToEntityReference(),
             .UoMId = New EntityReference(UoM.EntityLogicalName,
                                          _defaultUnitId)
         }
     _quoteDetailId = _serviceProxy.Create(quoteDetail)

     Console.WriteLine("Created quote with negative quantity.")

     '					#End Region

     '					#Region "Sales Order with negative price"

     ' Create the sales order.
     Dim order As New SalesOrder() With
         {
             .Name = "Faux Order",
             .DateFulfilled = New Date(2010, 8, 1),
             .PriceLevelId =
             New EntityReference(PriceLevel.EntityLogicalName,
                                 _priceListId),
             .CustomerId =
             New EntityReference(Account.EntityLogicalName,
                                 _accountId),
             .FreightAmount = New Money(20D)
         }
     _orderId = _serviceProxy.Create(order)
     order.Id = _orderId

     ' Add the product to the order with the price overriden with a
     ' negative value.
     Dim orderDetail As New SalesOrderDetail() With
         {
             .ProductId =
             New EntityReference(Product.EntityLogicalName,
                                 _product1Id),
             .Quantity = 4,
             .SalesOrderId = order.ToEntityReference(),
             .IsPriceOverridden = True,
             .PricePerUnit = New Money(-40D),
             .UoMId = New EntityReference(UoM.EntityLogicalName,
                                          _defaultUnitId)
         }
     _orderDetailId = _serviceProxy.Create(orderDetail)

     Console.WriteLine(
         "Created order with negative price per unit.")

     '					#End Region

     DeleteRequiredRecords(promptforDelete)
 End Using

' </snippetworkingwithnegativeprices1>