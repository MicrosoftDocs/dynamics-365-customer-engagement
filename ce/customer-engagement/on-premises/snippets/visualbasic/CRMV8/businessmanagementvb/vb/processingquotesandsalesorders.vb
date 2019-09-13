' <snippetprocessingquotesandsalesorders>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
	''' Demonstrates how to convert a quote to a sales order, and a sales order
	''' to an invoice. Also demonstrates how to lock/unlock prices on both sales orders 
	''' and invoices, win/lose opportunity, win/close quote and cancel sales order.</summary>
    ''' <remarks>
    ''' At run-time, you will be given the option to delete all the
    ''' database records created by this program.</remarks>
    Public Class ProcessingQuotesAndSalesOrders
        #Region "Class Level Members"

        Private _opportunityId As Guid
		Private _loseOpportunityId As Guid
        Private _unitGroupId As Guid
        Private _defaultUnitId As Guid
        Private _productId As Guid
        Private _priceListId As Guid
        Private _priceListItemId As Guid
        Private _accountId As Guid
        Private _quoteId As Guid
		Private _closeQuoteId As Guid
        Private _quoteDetailId As Guid
        Private _salesOrderId As Guid
		Private _closeSalesOrderId As Guid
        Private _invoiceId As Guid

        Private _serviceProxy As OrganizationServiceProxy

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' This method first connects to the Organization service. Afterwards, a 
        ''' quote is created. This quote is then converted to an order, and the pricing
        ''' is unlocked and relocked. This is followed by the order being converted
        ''' to an invoice, and the pricing is locked then unlocked.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptforDelete As Boolean)
            Try
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
                End Using

            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' Creates any entity records that this sample requires.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            ' Create a unit group
            Dim newUnitGroup As UoMSchedule = New UoMSchedule With
                                              {
                                                  .Name = "Example Unit Group",
                                                  .BaseUoMName = "Example Primary Unit"
                                              }
            _unitGroupId = _serviceProxy.Create(newUnitGroup)

            ' Retrieve the default unit id that was automatically created
            ' when we created the Unit Group
            Dim unitQuery As QueryExpression = New QueryExpression With
                                               {
                                                   .EntityName = UoM.EntityLogicalName,
                                                   .ColumnSet = New ColumnSet("uomid", "name"),
                                                   .PageInfo = New PagingInfo With
                                                               {
                                                                   .PageNumber = 1,
                                                                   .Count = 1
                                                               }
                                               }
            unitQuery.Criteria = New FilterExpression()
            unitQuery.Criteria.AddCondition("uomscheduleid", ConditionOperator.Equal, {_unitGroupId})
            ' Retrieve the unit.
            Dim unit As UoM = CType(_serviceProxy.RetrieveMultiple(unitQuery).Entities(0), UoM)
            _defaultUnitId = unit.UoMId.Value

            ' Create a few products
            Dim newProduct As Product =
                New Product With
                {
                    .ProductNumber = "1",
                    .Name = "Example Product",
                    .QuantityDecimal = 1,
                    .DefaultUoMScheduleId = New EntityReference(UoMSchedule.EntityLogicalName,
                                        _unitGroupId),
                    .DefaultUoMId = New EntityReference(UoM.EntityLogicalName,
                                                        _defaultUnitId)
                }
            _productId = _serviceProxy.Create(newProduct)
            newProduct.Id = _productId

            ' Create a price list
            Dim newPriceList As PriceLevel = New PriceLevel With
                                             {
                                                 .Name = "Example Price List"
                                             }
            _priceListId = _serviceProxy.Create(newPriceList)

            ' Create a price list item for the first product and apply volume discount
            Dim newPriceListItem As ProductPriceLevel =
                New ProductPriceLevel With
                {
                    .PriceLevelId = New EntityReference(PriceLevel.EntityLogicalName,
                                                        _priceListId),
                    .ProductId = New EntityReference(Product.EntityLogicalName,
                                                     _productId),
                    .UoMId = New EntityReference(UoM.EntityLogicalName,
                                                 _defaultUnitId),
                    .Amount = New Money(20D)
                }
            _priceListItemId = _serviceProxy.Create(newPriceListItem)

            ' Create an account record for the opportunity's potential customerid 
            Dim newAccount As Account = New Account With
                                        {
                                            .Name = "Litware, Inc.",
                                            .Address1_PostalCode = "60661"
                                        }
            _accountId = _serviceProxy.Create(newAccount)
            newAccount.Id = _accountId

        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            ' The three system users that were created by this sample will continue to 
            ' exist on your system because system users cannot be deleted in Microsoft
            ' Dynamics CRM.  They can only be enabled or disabled.

            Dim toBeDeleted As Boolean = True

            If prompt Then
                ' Ask the user if the created entities should be deleted.
                Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
            End If

            If toBeDeleted Then
                ' Delete all records created in this sample.
                _serviceProxy.Delete("invoice", _invoiceId)
                _serviceProxy.Delete("salesorder", _salesOrderId)
				_serviceProxy.Delete("salesorder", _closeSalesOrderId)
                _serviceProxy.Delete("quotedetail", _quoteDetailId)
                _serviceProxy.Delete("quote", _quoteId)
				_serviceProxy.Delete("quote", _closeQuoteId)
				_serviceProxy.Delete("opportunity", _opportunityId)
				_serviceProxy.Delete("opportunity", _loseOpportunityId)
                _serviceProxy.Delete("account", _accountId)
                _serviceProxy.Delete("productpricelevel", _priceListItemId)
                _serviceProxy.Delete("pricelevel", _priceListId)
                _serviceProxy.Delete("product", _productId)
                _serviceProxy.Delete("uomschedule", _unitGroupId)

                Console.WriteLine("Entity record(s) have been deleted.")
            End If
        End Sub

        #End Region ' How To Sample Code

        #Region "Main method"

        ''' <summary>
        ''' Standard Main() method used by most SDK samples.
        ''' </summary>
        ''' <param name="args"></param>
        Public Shared Sub Main(ByVal args() As String)
            Try
                ' Obtain the target organization's Web address and client logon 
                ' credentials from the user.
                Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

                Dim app As New ProcessingQuotesAndSalesOrders()
                app.Run(config, True)
            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
            Catch ex As TimeoutException
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Message: {0}", ex.Message)
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
            Catch ex As Exception
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine(ex.Message)

                ' Display the details of the inner exception.
                If ex.InnerException IsNot Nothing Then
                    Console.WriteLine(ex.InnerException.Message)

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) = _
                        TryCast(ex.InnerException, FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
                    If fe IsNot Nothing Then
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
                        Console.WriteLine("Message: {0}", fe.Detail.Message)
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}", If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
                    End If
                End If
            ' Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            ' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            Finally
                Console.WriteLine("Press <Enter> to exit.")
                Console.ReadLine()
            End Try
        End Sub
        #End Region ' Main method
    End Class
End Namespace

' </snippetprocessingquotesandsalesorders>