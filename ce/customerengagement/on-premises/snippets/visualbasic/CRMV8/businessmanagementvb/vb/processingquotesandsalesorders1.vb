' <snippetprocessingquotesandsalesorders1>


                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    CreateRequiredRecords()

'					#Region "Create Opportunities"

					' Create an opportunity
                    Dim crmOpportunity = New Opportunity With
                                         {
                                             .CustomerId =
                                             New EntityReference(Account.EntityLogicalName,
                                                                 _accountId),
                                             .Name = "Sample",
                                             .PriceLevelId =
                                             New EntityReference(PriceLevel.EntityLogicalName,
                                                                 _priceListId)
                                         }
					_opportunityId = _serviceProxy.Create(crmOpportunity)

                    crmOpportunity = New Opportunity With
                                     {
                                         .CustomerId = New EntityReference(Account.EntityLogicalName,
                                                                           _accountId),
                                         .Name = "Another Sample",
                                         .PriceLevelId = New EntityReference(PriceLevel.EntityLogicalName,
                                                                             _priceListId)
                                     }
					_loseOpportunityId = _serviceProxy.Create(crmOpportunity)

					Console.WriteLine("Opportunities created.")

'					#End Region

'					#Region "Win Opportunity"

                    ' Close the opportunity as won
                    Dim winOppRequest = New WinOpportunityRequest With
                                        {
                                            .OpportunityClose =
                                            New OpportunityClose With
                                            {
                                                .OpportunityId =
                                                New EntityReference(Opportunity.EntityLogicalName,
                                                                    _opportunityId)},
                                            .Status =
                                            New OptionSetValue(
                                                CInt(Fix(opportunity_statuscode.Won)))
                                        }

                    _serviceProxy.Execute(winOppRequest)

                    Console.WriteLine("Opportunity closed as Won.")

                    '					#End Region

                    '					#Region "Lose Opportunity"

                    Dim loseOppRequest = New LoseOpportunityRequest With
                                         {
                                             .OpportunityClose =
                                             New OpportunityClose With
                                             {
                                                 .OpportunityId = New EntityReference(Opportunity.EntityLogicalName,
                                                                                      _loseOpportunityId)},
                                             .Status = New OptionSetValue(CInt(Fix(opportunity_statuscode.Canceled)))
                                         }

                    _serviceProxy.Execute(loseOppRequest)

                    Console.WriteLine("Opportunity closed as Lost.")

                    '					#End Region

                    '					#Region "Convert Opportunity to a Quote"

                    ' Convert the opportunity to a quote
                    Dim genQuoteFromOppRequest =
                        New GenerateQuoteFromOpportunityRequest With
                        {
                            .OpportunityId = _opportunityId,
                            .ColumnSet = New ColumnSet("quoteid", "name")
                        }

                    Dim genQuoteFromOppResponse = CType(
                        _serviceProxy.Execute(genQuoteFromOppRequest), 
                        GenerateQuoteFromOpportunityResponse)

                    Dim quote_Renamed As Quote = genQuoteFromOppResponse.Entity.ToEntity(Of Quote)()
                    _quoteId = quote_Renamed.Id

                    Console.WriteLine("Quote generated from the Opportunity.")

                    '					#End Region

                    '					#Region "Close Quote"
                    ' convert the opportunity to a quote
                    genQuoteFromOppRequest =
                        New GenerateQuoteFromOpportunityRequest With
                        {
                            .OpportunityId = _opportunityId,
                            .ColumnSet = New ColumnSet("quoteid", "name")
                        }
                    genQuoteFromOppResponse = CType(_serviceProxy.Execute(genQuoteFromOppRequest), 
                        GenerateQuoteFromOpportunityResponse)

                    Dim closeQuote As Quote = genQuoteFromOppResponse.Entity.ToEntity(Of Quote)()
                    _closeQuoteId = closeQuote.Id

                    ' Activate the quote
                    Dim activateQuote As New SetStateRequest() With
                        {
                            .EntityMoniker = closeQuote.ToEntityReference(),
                            .State = New OptionSetValue(CInt(Fix(QuoteState.Active))),
                            .Status = New OptionSetValue(CInt(Fix(quote_statuscode.InProgress)))
                        }
                    _serviceProxy.Execute(activateQuote)

                    ' Close the quote
                    Dim closeQuoteRequest_Renamed As New CloseQuoteRequest() With
                        {
                            .QuoteClose = New QuoteClose() With
                                          {
                                              .QuoteId = closeQuote.ToEntityReference(),
                                              .Subject = "Quote Close " &amp; Date.Now.ToString()
                                          },
                            .Status = New OptionSetValue(-1)
                        }
                    _serviceProxy.Execute(closeQuoteRequest_Renamed)

                    Console.WriteLine("Quote Closed")

                    '					#End Region

                    '					#Region "Create Quote's Product"

                    ' Set the quote's product
                    Dim quoteDetail_Renamed As New QuoteDetail() With
                        {
                            .ProductId = New EntityReference(Product.EntityLogicalName,
                                                             _productId),
                            .Quantity = 1,
                            .QuoteId = quote_Renamed.ToEntityReference(),
                            .UoMId = New EntityReference(UoM.EntityLogicalName,
                                                         _defaultUnitId)
                        }
                    _quoteDetailId = _serviceProxy.Create(quoteDetail_Renamed)

                    Console.WriteLine("Quote Product created.")

                    ' Activate the quote
                    activateQuote = New SetStateRequest() With
                                    {
                                        .EntityMoniker = quote_Renamed.ToEntityReference(),
                                        .State = New OptionSetValue(CInt(Fix(QuoteState.Active))),
                                        .Status = New OptionSetValue(CInt(Fix(quote_statuscode.InProgress)))
                                    }
                    _serviceProxy.Execute(activateQuote)

                    Console.WriteLine("Quote activated.")

                    ' Mark the quote as won
                    ' Note: this is necessary in order to convert a quote into a 
                    ' SalesOrder.
                    Dim winQuoteRequest_Renamed As New WinQuoteRequest() With
                        {
                            .QuoteClose =
                            New QuoteClose() With
                            {
                                .Subject = "Quote Close" &amp; Date.Now.ToString(),
                                .QuoteId = quote_Renamed.ToEntityReference()
                            },
                            .Status = New OptionSetValue(-1)
                        }
                    _serviceProxy.Execute(winQuoteRequest_Renamed)

                    Console.WriteLine("Quote won.")

                    '					#End Region

                    '					#Region "Convert Quote to SalesOrder"

                    ' Define columns to be retrieved after creating the order
                    Dim salesOrderColumns As New ColumnSet("salesorderid", "totalamount")

                    ' Convert the quote to a sales order
                    Dim convertQuoteRequest As New ConvertQuoteToSalesOrderRequest() With
                        {
                            .QuoteId = _quoteId,
                            .ColumnSet = salesOrderColumns
                        }
                    Dim convertQuoteResponse As ConvertQuoteToSalesOrderResponse =
                        CType(_serviceProxy.Execute(convertQuoteRequest), 
                            ConvertQuoteToSalesOrderResponse)
                    Dim salesOrder_Renamed As SalesOrder = CType(convertQuoteResponse.Entity, 
                        SalesOrder)
                    _salesOrderId = salesOrder_Renamed.Id

                    Console.WriteLine("Converted Quote to SalesOrder.")

                    '                    #End Region

                    '					#Region "Cancel Sales Order"

                    ' Define columns to be retrieved after creating the order
                    salesOrderColumns = New ColumnSet("salesorderid", "totalamount")

                    ' Convert the quote to a sales order
                    convertQuoteRequest = New ConvertQuoteToSalesOrderRequest() With
                                          {
                                              .QuoteId = _quoteId,
                                              .ColumnSet = salesOrderColumns
                                          }
                    convertQuoteResponse = CType(_serviceProxy.Execute(convertQuoteRequest), 
                        ConvertQuoteToSalesOrderResponse)
                    Dim closeSalesOrder As SalesOrder = CType(convertQuoteResponse.Entity, 
                        SalesOrder)
                    _closeSalesOrderId = closeSalesOrder.Id

                    Dim cancelRequest As New CancelSalesOrderRequest() With
                        {
                            .OrderClose = New OrderClose() With
                                          {
                                              .SalesOrderId = closeSalesOrder.ToEntityReference(),
                                              .Subject = "Close Sales Order " &amp; Date.Now
                                          },
                            .Status = New OptionSetValue(-1)
                        }
                    _serviceProxy.Execute(cancelRequest)

                    Console.WriteLine("Canceled sales order")

                    '					#End Region

                    '                    #Region "Lock pricing on SalesOrder"

                    ' Note: after converting a won quote to an order, the pricing of 
                    ' the order is locked by default.

                    ' Retrieve current price list
                    Dim priceListItem As ProductPriceLevel =
                        CType(_serviceProxy.Retrieve(ProductPriceLevel.EntityLogicalName,
                                                     _priceListItemId,
                                                     New ColumnSet("productpricelevelid", "amount")), 
                                                 ProductPriceLevel)

                    Console.WriteLine("Current price list retrieved.")
                    Console.WriteLine()

                    Console.WriteLine("Details before update:")
                    Console.WriteLine("----------------")
                    Console.WriteLine("Current order total: {0}",
                                      salesOrder_Renamed.TotalAmount.Value)
                    Console.WriteLine("Current price per item: {0}",
                                      priceListItem.Amount.Value)
                    Console.WriteLine("</End of Listing>")
                    Console.WriteLine()

                    ' Update the price list
                    priceListItem.Amount = New Money(30D)

                    Dim updatePriceListItem As New UpdateRequest() With {.Target = priceListItem}
                    _serviceProxy.Execute(updatePriceListItem)

                    Console.WriteLine("Price list updated.")

                    ' Retrieve the order
                    Dim updatedSalesOrder As SalesOrder =
                        CType(_serviceProxy.Retrieve(SalesOrder.EntityLogicalName,
                                                     _salesOrderId,
                                                     New ColumnSet("salesorderid", "totalamount")), 
                                                 SalesOrder)

                    Console.WriteLine("Updated order retrieved.")
                    Console.WriteLine()

					Console.WriteLine("Details after update:")
					Console.WriteLine("----------------")
                    Console.WriteLine("Current order total: {0}",
                                      updatedSalesOrder.TotalAmount.Value)
                    Console.WriteLine("Current price per item: {0}",
                                      priceListItem.Amount.Value)
                    Console.WriteLine("</End of Listing>")
                    Console.WriteLine()

                    ' Unlock the order pricing
                    Dim unlockOrderRequest As New UnlockSalesOrderPricingRequest() With
                        {.SalesOrderId = _salesOrderId}
                    _serviceProxy.Execute(unlockOrderRequest)

                    Console.WriteLine("Order pricing unlocked.")

                    ' Retrieve the order
                    updatedSalesOrder =
                        CType(_serviceProxy.Retrieve(SalesOrder.EntityLogicalName,
                                                     _salesOrderId,
                                                     New ColumnSet("salesorderid", "totalamount")), 
                                                 SalesOrder)

                    Console.WriteLine("Updated order retrieved.")
                    Console.WriteLine()

                    Console.WriteLine("Details after update and unlock:")
                    Console.WriteLine("----------------")
                    Console.WriteLine("Current order total: {0}",
                                      updatedSalesOrder.TotalAmount.Value)
                    Console.WriteLine("Current price per item: {0}",
                                      priceListItem.Amount.Value)
                    Console.WriteLine("</End of Listing>")
                    Console.WriteLine()

                    ' Relock the order pricing
                    Dim lockOrderRequest As New LockSalesOrderPricingRequest() With
                        {
                            .SalesOrderId = _salesOrderId
                        }
                    _serviceProxy.Execute(lockOrderRequest)


                    Console.WriteLine("Order pricing relocked.")

'                    #End Region

'                    #Region "Convert SalesOrder to Invoice"

                    ' Define columns to be retrieved after creating the invoice
                    Dim invoiceColumns As New ColumnSet("invoiceid", "totalamount")

                    ' Convert the order to an invoice
                    Dim convertOrderRequest As New ConvertSalesOrderToInvoiceRequest() With
                        {
                            .SalesOrderId = _salesOrderId,
                            .ColumnSet = invoiceColumns
                        }
                    Dim convertOrderResponse As ConvertSalesOrderToInvoiceResponse =
                        CType(_serviceProxy.Execute(convertOrderRequest), 
                            ConvertSalesOrderToInvoiceResponse)
					Dim invoice_Renamed As Invoice = CType(convertOrderResponse.Entity, Invoice)
					_invoiceId = invoice_Renamed.Id

                    Console.WriteLine("Converted SalesOrder to Invoice.")

'                    #End Region

'                    #Region "Lock pricing on Invoice"

                    ' Retrieve current price list
                    priceListItem = CType(_serviceProxy.Retrieve(ProductPriceLevel.EntityLogicalName,
                                                                 _priceListItemId,
                                                                 New ColumnSet("productpricelevelid",
                                                                               "amount")), 
                                                             ProductPriceLevel)

                    Console.WriteLine("Current price list retrieved.")
                    Console.WriteLine()

                    Console.WriteLine("Details before lock and update:")
                    Console.WriteLine("----------------")
					Console.WriteLine("Current invoice total: {0}", invoice_Renamed.TotalAmount.Value)
                    Console.WriteLine("Current price per item: {0}", priceListItem.Amount.Value)
                    Console.WriteLine("</End of Listing>")
                    Console.WriteLine()

                    ' Lock the invoice pricing
                    Dim lockInvoiceRequest As New LockInvoicePricingRequest() With {.InvoiceId = _invoiceId}
                    _serviceProxy.Execute(lockInvoiceRequest)

                    Console.WriteLine("Invoice pricing locked.")

                    ' Update the price list
                    priceListItem.Amount = New Money(40D)

                    updatePriceListItem = New UpdateRequest() With {.Target = priceListItem}
                    _serviceProxy.Execute(updatePriceListItem)

                    Console.WriteLine("Price list updated.")

                    ' Retrieve the invoice
                    Dim updatedInvoice As Invoice =
                        CType(_serviceProxy.Retrieve(Invoice.EntityLogicalName,
                                                     _invoiceId,
                                                     New ColumnSet("invoiceid",
                                                                   "totalamount")), 
                                                           Invoice)

                    Console.WriteLine("Updated invoice retrieved.")
                    Console.WriteLine()

                    Console.WriteLine("Details after lock and update:")
                    Console.WriteLine("----------------")
                    Console.WriteLine("Current invoice total: {0}", updatedInvoice.TotalAmount.Value)
                    Console.WriteLine("Current price per item: {0}", priceListItem.Amount.Value)
                    Console.WriteLine("</End of Listing>")
                    Console.WriteLine()

                    ' Unlock the invoice pricing
                    Dim unlockInvoiceRequest As New UnlockInvoicePricingRequest() With
                        {
                            .InvoiceId = _invoiceId
                        }
                    _serviceProxy.Execute(unlockInvoiceRequest)

                    Console.WriteLine("Invoice pricing unlocked.")

                    ' Retrieve the invoice
                    updatedInvoice =
                        CType(_serviceProxy.Retrieve(Invoice.EntityLogicalName,
                                                     _invoiceId,
                                                     New ColumnSet("invoiceid",
                                                                   "totalamount")), 
                                                 Invoice)

                    Console.WriteLine("Updated invoice retrieved.")
                    Console.WriteLine()

                    Console.WriteLine("Details after update and unlock:")
                    Console.WriteLine("----------------")
                    Console.WriteLine("Current invoice total: {0}", updatedInvoice.TotalAmount.Value)
                    Console.WriteLine("Current price per item: {0}", priceListItem.Amount.Value)
                    Console.WriteLine("</End of Listing>")
                    Console.WriteLine()

'                    #End Region

                    DeleteRequiredRecords(promptforDelete)

' </snippetprocessingquotesandsalesorders1>