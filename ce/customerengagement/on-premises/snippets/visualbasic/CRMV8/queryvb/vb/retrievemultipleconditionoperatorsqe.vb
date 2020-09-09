' <snippetretrievemultipleconditionoperatorsqe>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' Demonstrates how to do use retrieve multiple condition operators for all
	''' query types.</summary>
	''' <remarks>
	''' At run-time, you will be given the option to delete all the
	''' database records created by this program.</remarks>
	Public Class RetrieveMultipleConditionOperatorsQE
		#Region "Class Level Members"

		Private _accountId As Guid
		Private _productId As Guid
		Private _priceLevelId As Guid
		Private _productPriceId As Guid
		Private _unitGroupId As Guid
		Private _contactIdList As New List(Of Guid)()
		Private _opportunityIdList As New List(Of Guid)()
		Private _orderIdList As New List(Of Guid)()
		Private _serviceProxy As OrganizationServiceProxy
		Private _service As IOrganizationService

		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
		''' This method first connects to the Organization service. Afterwards, various
		''' QueryExpressions are performed that demonstrate the use of special
		''' condition operators.
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

                    _service = CType(_serviceProxy, IOrganizationService)

                    CreateRequiredRecords()

                    '					#Region "SQL Query Translated to QueryExpression"
                    ' Build the following SQL query using QueryExpression:
                    '
                    '		SELECT contact.fullname, contact.address1_telephone1
                    '		FROM contact
                    '			LEFT OUTER JOIN account
                    '				ON contact.parentcustomerid = account.accountid
                    '				AND
                    '				account.name = 'Litware, Inc.'
                    '		WHERE (contact.address1_stateorprovince = 'WA'
                    '		AND
                    '			contact.address1_city in ('Redmond', 'Bellevue', 'Kirkland', 'Seattle')
                    '		AND 
                    '			contact.address1_telephone1 like '(206)%'
                    '			OR
                    '			contact.address1_telephone1 like '(425)%'
                    '		AND
                    '			DATEDIFF(DAY, contact.createdon, GETDATE()) > 0
                    '		AND
                    '			DATEDIFF(DAY, contact.createdon, GETDATE()) < 30
                    '		AND
                    '			contact.emailaddress1 Not NULL
                    '			   )

                    Dim query As New QueryExpression() With
                        {
                            .Distinct = False,
                            .EntityName = Contact.EntityLogicalName,
                            .ColumnSet = New ColumnSet("fullname", "address1_telephone1")
                        }

                    Dim queryLink As New LinkEntity With
                        {
                            .LinkToEntityName = Account.EntityLogicalName,
                            .LinkFromAttributeName = "parentcustomerid",
                            .LinkToAttributeName = "accountid",
                            .JoinOperator = JoinOperator.LeftOuter
                        }
                    queryLink.LinkCriteria().AddCondition("name",
                                                          ConditionOperator.Equal,
                                                          "Litware, Inc.")
                    query.LinkEntities().Add(queryLink)
                    Dim queryCriteraFilter1 As New FilterExpression()
                    queryCriteraFilter1.FilterOperator = LogicalOperator.And
                    queryCriteraFilter1.AddCondition(
                        New ConditionExpression("address1_stateorprovince",
                                                ConditionOperator.Equal, "WA"))
                    queryCriteraFilter1.AddCondition(
                        New ConditionExpression("address1_city",
                                                ConditionOperator.In,
                                                New String() {"Redmond",
                                                              "Bellevue",
                                                              "Kirkland",
                                                              "Seattle"}))
                    queryCriteraFilter1.AddCondition(
                        New ConditionExpression("createdon",
                                                ConditionOperator.LastXDays,
                                                30))
                    queryCriteraFilter1.AddCondition(
                        New ConditionExpression("emailaddress1",
                                                ConditionOperator.NotNull))
                    Dim queryCriteraFilter2 As New FilterExpression()
                    queryCriteraFilter2.FilterOperator = LogicalOperator.Or
                    queryCriteraFilter2.AddCondition(
                        New ConditionExpression("address1_telephone1",
                                                ConditionOperator.Like,
                                                "(206)%"))
                    queryCriteraFilter2.AddCondition(
                        New ConditionExpression("address1_telephone1",
                                                ConditionOperator.Like,
                                                "(425)%"))
                    query.Criteria.Filters.AddRange(queryCriteraFilter1,
                                                    queryCriteraFilter2)

                    Dim entityCollection As DataCollection(Of Entity) =
                        _service.RetrieveMultiple(query).Entities

                    ' Display the results.
                    Console.WriteLine("List all contacts matching specified parameters")
                    Console.WriteLine("===============================================")
                    For Each contact As Contact In entityCollection
                        Console.WriteLine("Contact ID: {0}", contact.Id)
                        Console.WriteLine("Contact Name: {0}", contact.FullName)
                        Console.WriteLine("Contact Phone: {0}", contact.Address1_Telephone1)
                    Next contact
                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()
                    '					#End Region

                    '					#Region "Find all orders fulfilled in the last fiscal period"
                    query = New QueryExpression() With
                            {
                                .EntityName = SalesOrder.EntityLogicalName,
                                .ColumnSet = New ColumnSet("name")
                            }
                    query.Criteria.AddCondition(
                        New ConditionExpression("datefulfilled",
                                                ConditionOperator.LastFiscalPeriod))

                    entityCollection = _service.RetrieveMultiple(query).Entities

                    ' Display the results.
                    Console.WriteLine("List all orders fulfilled in the last fiscal period")
                    Console.WriteLine("===================================================")
                    For Each order As SalesOrder In entityCollection
                        Console.WriteLine("Order ID: {0}", order.Id)
                        Console.WriteLine("Order Name: {0}", order.Name)
                    Next order
                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()
                    '					#End Region

                    '					#Region "Find all Opportunities with estimated close date in next 3 fiscal years"
                    query = New QueryExpression() With
                            {
                                .EntityName = Opportunity.EntityLogicalName,
                                .ColumnSet = New ColumnSet("name")
                            }
                    query.Criteria.AddCondition(
                        New ConditionExpression("estimatedclosedate",
                                                ConditionOperator.NextXFiscalYears,
                                                3))

                    entityCollection = _service.RetrieveMultiple(query).Entities

                    ' Display the results.
                    Console.WriteLine("List all opportunities with estimated close date in the next 3 fiscal years")
                    Console.WriteLine("===========================================================================")
                    For Each opportunity As Opportunity In entityCollection
                        Console.WriteLine("Opportunity ID: {0}", opportunity.Id)
                        Console.WriteLine("Opportunity: {0}", opportunity.Name)
                    Next opportunity
                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()
                    '					#End Region

                    '					#Region "Find all Orders fulfilled in fiscal year 2008"
                    query = New QueryExpression() With
                            {
                                .EntityName = SalesOrder.EntityLogicalName,
                                .ColumnSet = New ColumnSet("name")
                            }
                    query.Criteria.AddCondition(
                        New ConditionExpression("datefulfilled",
                                                ConditionOperator.InFiscalYear,
                                                2008))

                    entityCollection = _service.RetrieveMultiple(query).Entities

                    ' Display the results.
                    Console.WriteLine("List all orders fulfilled in fiscal year 2008")
                    Console.WriteLine("=============================================")
                    For Each order As SalesOrder In entityCollection
                        Console.WriteLine("Order ID: {0}", order.Id)
                        Console.WriteLine("Order Name: {0}", order.Name)
                    Next order
                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()
                    '					#End Region

                    '					#Region "Find all Orders fulfilled in period 3 of any fiscal year"
                    query = New QueryExpression() With
                            {
                                .EntityName = SalesOrder.EntityLogicalName,
                                .ColumnSet = New ColumnSet("name")}
                    query.Criteria.AddCondition(
                        New ConditionExpression("datefulfilled",
                                                ConditionOperator.InFiscalPeriod,
                                                3))

                    entityCollection = _service.RetrieveMultiple(query).Entities

                    ' Display the results.
                    Console.WriteLine("List all orders fulfilled in period 3 of any fiscal year")
                    Console.WriteLine("========================================================")
                    For Each order As SalesOrder In entityCollection
                        Console.WriteLine("Order ID: {0}", order.Id)
                        Console.WriteLine("Order Name: {0}", order.Name)
                    Next order
                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()
                    '					#End Region

                    '					#Region "Find all Orders fulfilled in period 3 of fiscal year 2008"
                    query = New QueryExpression() With
                            {
                                .EntityName = SalesOrder.EntityLogicalName,
                                .ColumnSet = New ColumnSet("name")
                            }
                    query.Criteria.AddCondition(
                        New ConditionExpression("datefulfilled",
                                                ConditionOperator.InFiscalPeriodAndYear,
                                                New Integer() {3, 2008}))

                    entityCollection = _service.RetrieveMultiple(query).Entities

                    ' Display the results.
                    Console.WriteLine("List all orders fulfilled in period 3 of fiscal year 2008")
                    Console.WriteLine("=========================================================")
                    For Each order As SalesOrder In entityCollection
                        Console.WriteLine("Order ID: {0}", order.Id)
                        Console.WriteLine("Order Name: {0}", order.Name)
                    Next order
                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()
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
			' Create a unit group.
            Dim unitGroup As UoMSchedule = New UoMSchedule With
                                           {
                                               .Name = "Example Unit Group",
                                               .BaseUoMName = "Example Primary Unit"
                                           }
			_unitGroupId = _service.Create(unitGroup)

			' Retrieve the unit.
            Dim unitQuery As New QueryExpression() With
                {
                    .EntityName = UoM.EntityLogicalName,
                    .ColumnSet = New ColumnSet("uomid", "name"),
                    .PageInfo = New PagingInfo With
                                {
                                    .PageNumber = 1,
                                    .Count = 1
                                }
                }
            unitQuery.Criteria.AddCondition(
                New ConditionExpression("uomscheduleid",
                                        ConditionOperator.Equal,
                                        _unitGroupId))
            Dim unit As UoM =
                CType(_service.RetrieveMultiple(unitQuery).Entities(0), UoM)

			' Create an account.
            Dim account As Account = New Account With
                                     {
                                         .Name = "Litware, Inc.",
                                         .Address1_StateOrProvince = "Colorado"
                                     }
			_accountId = (_service.Create(account))

			' Create the 2 contacts.
            Dim contact As New Contact() With
                {
                    .FirstName = "Ben",
                    .LastName = "Andrews",
                    .EMailAddress1 = "sample@example.com",
                    .Address1_City = "Redmond",
                    .Address1_StateOrProvince = "WA",
                    .Address1_Telephone1 = "(206)555-5555",
                    .ParentCustomerId = New EntityReference With
                                        {
                                            .Id = _accountId,
                                            .LogicalName = account.LogicalName
                                        }
                }
			_contactIdList.Add(_service.Create(contact))

            contact = New Contact() With
                      {
                          .FirstName = "Colin",
                          .LastName = "Wilcox",
                          .EMailAddress1 = "sample@example.com",
                          .Address1_City = "Bellevue",
                          .Address1_StateOrProvince = "WA",
                          .Address1_Telephone1 = "(425)555-5555",
                          .ParentCustomerId = New EntityReference With
                                              {
                                                  .Id = _accountId,
                                                  .LogicalName = account.LogicalName
                                              }
                      }
			_contactIdList.Add(_service.Create(contact))

			' Create pricing and product objects.
			Dim priceLevel As New PriceLevel() With {.Name = "Faux Price List"}
			_priceLevelId = _service.Create(priceLevel)

            Dim product As New Product() With
                {
                    .ProductNumber = "1",
                    .QuantityDecimal = 4,
                    .Name = "Faux Product",
                    .DefaultUoMId = New EntityReference With
                                    {
                                        .Id = unit.Id,
                                        .LogicalName = UoM.EntityLogicalName
                                    },
                    .DefaultUoMScheduleId =
                    New EntityReference With
                    {
                        .Id = _unitGroupId,
                        .LogicalName = UoMSchedule.EntityLogicalName
                    }
                }
			_productId = _service.Create(product)

            Dim productPrice As New ProductPriceLevel() With
                {
                    .PriceLevelId = New EntityReference() With
                                    {
                                        .Id = _priceLevelId,
                                        .LogicalName = priceLevel.EntityLogicalName
                                    },
                    .ProductId = New EntityReference() With
                                 {
                                     .Id = _productId,
                                     .LogicalName = product.EntityLogicalName
                                 },
                    .UoMId = New EntityReference With
                             {
                                 .Id = unit.Id,
                                 .LogicalName = UoM.EntityLogicalName
                             },
                    .Amount = New Money(20)
                }
			_productPriceId = _service.Create(productPrice)

			' Create 3 orders.
            Dim order As New SalesOrder() With
                {
                    .Name = "Faux Order",
                    .DateFulfilled = New Date(2010, 8, 1),
                    .PriceLevelId = New EntityReference With
                                    {
                                        .Id = _priceLevelId,
                                        .LogicalName = priceLevel.EntityLogicalName
                                    },
                    .CustomerId = New EntityReference With
                                  {
                                      .Id = _accountId,
                                      .LogicalName = account.LogicalName
                                  }
                }
			_orderIdList.Add(_service.Create(order))

            order = New SalesOrder() With
                    {
                        .Name = "Old Faux Order",
                        .DateFulfilled = New Date(2010, 4, 1),
                        .PriceLevelId = New EntityReference With
                                        {
                                            .Id = _priceLevelId,
                                            .LogicalName = priceLevel.EntityLogicalName
                                        },
                        .CustomerId = New EntityReference With
                                      {
                                          .Id = _accountId,
                                          .LogicalName = account.LogicalName
                                      }
                    }
			_orderIdList.Add(_service.Create(order))

            order = New SalesOrder() With
                    {
                        .Name = "Oldest Faux Order",
                        .DateFulfilled = New Date(2008, 8, 1),
                        .PriceLevelId = New EntityReference With
                                        {
                                            .Id = _priceLevelId,
                                            .LogicalName = priceLevel.EntityLogicalName
                                        },
                        .CustomerId = New EntityReference With
                                      {
                                          .Id = _accountId,
                                          .LogicalName = account.LogicalName
                                      }
                    }
			_orderIdList.Add(_service.Create(order))

			' Create 2 opportunities.
            Dim opportunity As New Opportunity() With
                {
                    .Name = "Litware, Inc. Opportunity 1",
                    .EstimatedCloseDate = New Date(2011, 1, 1),
                    .CustomerId = New EntityReference With
                                  {
                                      .Id = _accountId,
                                      .LogicalName = account.LogicalName
                                  }
                }
			_opportunityIdList.Add(_service.Create(opportunity))

            opportunity = New Opportunity() With
                          {
                              .Name = "Litware, Inc. Opportunity 2",
                              .EstimatedCloseDate = New Date(2020, 1, 1),
                              .CustomerId = New EntityReference With
                                            {
                                                .Id = _accountId,
                                                .LogicalName = account.LogicalName
                                            }
                          }
			_opportunityIdList.Add(_service.Create(opportunity))
		End Sub

		''' <summary>
		''' Deletes any entity records that were created for this sample.
		''' <param name="prompt">Indicates whether to prompt the user 
		''' to delete the records created in this sample.</param>
		''' </summary>
		Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
			Dim toBeDeleted As Boolean = True

			If prompt Then
				' Ask the user if the created entities should be deleted.
				Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
				Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse answer.StartsWith("Y") _
                    OrElse answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
			End If

			If toBeDeleted Then
				' Delete all records created in this sample.
				For Each contactId As Guid In _contactIdList
					_service.Delete(Contact.EntityLogicalName, contactId)
				Next contactId

				For Each opportunityId As Guid In _opportunityIdList
					_service.Delete(Opportunity.EntityLogicalName, opportunityId)
				Next opportunityId

				For Each orderId As Guid In _orderIdList
					_service.Delete(SalesOrder.EntityLogicalName, orderId)
				Next orderId

				_service.Delete(Account.EntityLogicalName, _accountId)

				_service.Delete(Product.EntityLogicalName, _productId)

				_service.Delete(PriceLevel.EntityLogicalName, _priceLevelId)

				_service.Delete(UoMSchedule.EntityLogicalName, _unitGroupId)

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

				Dim app As New RetrieveMultipleConditionOperatorsQE()
				app.Run(config, True)
			Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
				Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
				Console.WriteLine("Message: {0}", ex.Detail.Message)
				Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
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

' </snippetretrievemultipleconditionoperatorsqe>