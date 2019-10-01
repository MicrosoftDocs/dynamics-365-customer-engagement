' <snippetworkingwithnegativeprices>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	'''  Show how to set negative values for amount and number attributes in 
	'''  opportunities, quotes, sales orders.
	''' </summary>
	''' <remarks>
	''' At run-time, you will be given the option to delete all the
	''' database records created by this program.</remarks>
	Public Class WorkingWithNegativePrices
		#Region "Class Level Members"

		Private _salesManagerId As Guid
		Private _unitGroupId As Guid
		Private _defaultUnitId As Guid
		Private _product1Id As Guid
		Private _product2Id As Guid
		Private _priceListId As Guid
		Private _priceListItem1Id As Guid
		Private _priceListItem2Id As Guid
		Private _catalogProductId As Guid
		Private _quoteId As Guid
		Private _quoteDetailId As Guid
		Private _orderId As Guid
		Private _orderDetailId As Guid
		Private _opportunityId As Guid
		Private _accountId As Guid
		Private _salesRepresentativeIds As New List(Of Guid)()
		Private _serviceProxy As OrganizationServiceProxy

		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
		''' This method first connects to the Organization service. Afterwards, an 
		''' opportunity is created to demonstrate a negative estimated value. This is
		''' followed by the creation of a quote with a negative product quantity. 
		''' Finally, a sales order with a negative product price is shown.
		''' </summary>
		''' <param name="serverConfig">Contains server connection information.</param>
		''' <param name="promptforDelete">When True, the user will be prompted to delete all
		''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            Try
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
'			#Region "Create or Retrieve the necessary system users"

			' Retrieve the ldapPath
			Dim ldapPath As String = String.Empty
			' Retrieve the sales team - 1 sales manager and 2 sales representatives.
            _salesManagerId = SystemUserProvider.RetrieveSalesManager(_serviceProxy,
                                                                      ldapPath)
            _salesRepresentativeIds = SystemUserProvider.RetrieveSalespersons(
                _serviceProxy, ldapPath)

'			#End Region

'			#Region "Create records to support Opportunity records"
			' Create a unit group
            Dim newUnitGroup As UoMSchedule =
                New UoMSchedule With
                {
                    .Name = "Example Unit Group",
                    .BaseUoMName = "Example Primary Unit"
                }
			_unitGroupId = _serviceProxy.Create(newUnitGroup)

			' Retrieve the default unit id that was automatically created
			' when we created the Unit Group
            Dim unitQuery As QueryExpression =
                New QueryExpression With
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
            unitQuery.Criteria.AddCondition("uomscheduleid",
                                            ConditionOperator.Equal,
                                            {_unitGroupId})

			' Retrieve the unit.
            Dim unit As UoM =
                CType(_serviceProxy.RetrieveMultiple(unitQuery).Entities(0), 
                    UoM)
			_defaultUnitId = unit.UoMId.Value

			' Create a few products
            Dim newProduct1 As Product =
                New Product With
                {
                    .ProductNumber = "1",
                    .Name = "Example Product 1",
                    .QuantityDecimal = 2,
                    .DefaultUoMScheduleId =
                    New EntityReference(UoMSchedule.EntityLogicalName,
                                        _unitGroupId),
                    .DefaultUoMId =
                    New EntityReference(UoM.EntityLogicalName, _defaultUnitId)
                }
			_product1Id = _serviceProxy.Create(newProduct1)

            Dim newProduct2 As Product =
                New Product With
                {
                    .ProductNumber = "2",
                    .Name = "Example Product 2",
                    .QuantityDecimal = 3,
                    .DefaultUoMScheduleId =
                    New EntityReference(UoMSchedule.EntityLogicalName,
                                        _unitGroupId),
                    .DefaultUoMId =
                    New EntityReference(UoM.EntityLogicalName,
                                        _defaultUnitId)
                }
			_product2Id = _serviceProxy.Create(newProduct2)

			' Create a price list
            Dim newPriceList As PriceLevel =
                New PriceLevel With
                {
                    .Name = "Example Price List"
                }
			_priceListId = _serviceProxy.Create(newPriceList)

			' Create a price list item for the first product and apply volume discount
            Dim newPriceListItem1 As ProductPriceLevel =
                New ProductPriceLevel With
                {
                    .PriceLevelId =
                    New EntityReference(PriceLevel.EntityLogicalName,
                                        _priceListId),
                    .ProductId =
                    New EntityReference(Product.EntityLogicalName,
                                        _product1Id),
                    .UoMId =
                    New EntityReference(UoM.EntityLogicalName,
                                        _defaultUnitId),
                    .Amount = New Money(20)
                }
			_priceListItem1Id = _serviceProxy.Create(newPriceListItem1)

			' Create a price list item for the second product
            Dim newPriceListItem2 As ProductPriceLevel =
                New ProductPriceLevel With
                {
                    .PriceLevelId =
                    New EntityReference(PriceLevel.EntityLogicalName,
                                        _priceListId),
                    .ProductId =
                    New EntityReference(Product.EntityLogicalName,
                                        _product2Id),
                    .UoMId =
                    New EntityReference(UoM.EntityLogicalName,
                                        _defaultUnitId),
                    .Amount = New Money(15)
                }
			_priceListItem2Id = _serviceProxy.Create(newPriceListItem2)

			' Create an account record for the opportunity's potential customerid
            Dim newAccount As Account = New Account With
                                        {
                                            .Name = "Margie's Travel",
                                            .Address1_PostalCode = "99999"
                                        }
			_accountId = (_serviceProxy.Create(newAccount))

'			#End Region ' Create records to support Opportunity records

		End Sub

		''' <summary>
		''' Deletes any entity records that were created for this sample.
		''' <param name="prompt">Indicates whether to prompt the user 
		''' to delete the records created in this sample.</param>
		''' </summary>
		Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
			' Two of the contracts, their associated account and the contract template
			' records that were created and used in this sample will continue to exist 
			' on your system because contracts that have been invoiced cannot be deleted 
			' in Microsoft Dynamics CRM. They can only be put on hold or canceled.

			Dim toBeDeleted As Boolean = True

			If prompt Then
				' Ask the user if the created entities should be deleted.
                Console.Write(vbLf _
                              &amp; "Do you want these entity records deleted? (y/n) [y]: ")
				Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse answer.StartsWith("Y") _
                    OrElse answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
			End If

			If toBeDeleted Then
				_serviceProxy.Delete(SalesOrderDetail.EntityLogicalName, _orderDetailId)
				_serviceProxy.Delete(SalesOrder.EntityLogicalName, _orderId)
				_serviceProxy.Delete(QuoteDetail.EntityLogicalName, _quoteDetailId)
				_serviceProxy.Delete(Quote.EntityLogicalName, _quoteId)
				_serviceProxy.Delete(Opportunity.EntityLogicalName, _opportunityId)
                _serviceProxy.Delete(ProductPriceLevel.EntityLogicalName,
                                     _priceListItem1Id)
                _serviceProxy.Delete(ProductPriceLevel.EntityLogicalName,
                                     _priceListItem2Id)
				_serviceProxy.Delete(PriceLevel.EntityLogicalName, _priceListId)
				_serviceProxy.Delete(Product.EntityLogicalName, _product1Id)
				_serviceProxy.Delete(Product.EntityLogicalName, _product2Id)
				_serviceProxy.Delete(UoMSchedule.EntityLogicalName, _unitGroupId)
				_serviceProxy.Delete(Account.EntityLogicalName, _accountId)
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
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

				Dim app As New WorkingWithNegativePrices()
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
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
			Catch ex As Exception
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine(ex.Message)

				' Display the details of the inner exception.
				If ex.InnerException IsNot Nothing Then
					Console.WriteLine(ex.InnerException.Message)

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) =
                        TryCast(ex.InnerException, 
                            FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
					If fe IsNot Nothing Then
						Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
						Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
						Console.WriteLine("Message: {0}", fe.Detail.Message)
						Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}",
                                          If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
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

' </snippetworkingwithnegativeprices>