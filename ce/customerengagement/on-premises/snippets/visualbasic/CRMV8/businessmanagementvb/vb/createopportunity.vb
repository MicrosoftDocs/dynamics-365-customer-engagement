' <snippetcreateopportunity>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' This Sample shows how to create an opportunity with 
    ''' one catalog and one write-in product.
    ''' </summary>
    Public Class CreateOpportunity
        #Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy

        ' Define the IDs needed for this sample.
        Public _unitGroupId As Guid
        Public _defaultUnitId As Guid
        Public _product1Id As Guid
        Public _product2Id As Guid
        Public _discountTypeId As Guid
        Public _discountId As Guid
        Public _priceListId As Guid
        Public _priceListItem1Id As Guid
        Public _priceListItem2Id As Guid
        Public _accountId As Guid
        Public _opportunityId As Guid
        Public _catalogProductId As Guid
        Public _catalogProductPriceOverrideId As Guid
        Public _writeInProductId As Guid

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Initiate method to create any data that this sample requires.
        ''' Create a new opportunity and few opportunity product 
        ''' including write-in product.
        ''' Optionally delete any entity records that were created for this sample.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    CreateRequiredRecords()


                    ' Create a new opportunity with user specified estimated revenue
                    Dim newOpportunity As Opportunity = New Opportunity With { _
                        .Name = "Example Opportunity", .CustomerId = New EntityReference(Account.EntityLogicalName, _accountId), _
                        .PriceLevelId = New EntityReference(PriceLevel.EntityLogicalName, _priceListId), _
                        .IsRevenueSystemCalculated = False, .EstimatedValue = New Money(400D), _
                        .FreightAmount = New Money(10D), .DiscountAmount = New Money(0.1D), .DiscountPercentage = 0.2D}

                    _opportunityId = _serviceProxy.Create(newOpportunity)
                    Console.WriteLine("Created {0} with user specified estimated revenue.", newOpportunity.Name)

                    ' Create a new opportunity product from the catalog

                    ' Create a catalog product
                    Dim catalogProduct As OpportunityProduct = New OpportunityProduct With { _
                        .OpportunityId = New EntityReference(Opportunity.EntityLogicalName, _opportunityId), _
                        .ProductId = New EntityReference(Product.EntityLogicalName, _product1Id), _
                        .UoMId = New EntityReference(UoM.EntityLogicalName, _defaultUnitId), .Quantity = 8, .Tax = New Money(12.42D)}

                    _catalogProductId = _serviceProxy.Create(catalogProduct)
                    Console.WriteLine("Created the catalog product.")

                    ' Create anothter catalog product and override the list price
                    Dim catalogProductPriceOverride As OpportunityProduct = New OpportunityProduct With { _
                        .OpportunityId = New EntityReference(Opportunity.EntityLogicalName, _opportunityId), _
                        .ProductId = New EntityReference(Product.EntityLogicalName, _product2Id), _
                        .UoMId = New EntityReference(UoM.EntityLogicalName, _defaultUnitId), .Quantity = 3, _
                        .Tax = New Money(2.88D), .IsPriceOverridden = True, .PricePerUnit = New Money(12)}

                    _catalogProductPriceOverrideId = _serviceProxy.Create(catalogProductPriceOverride)
                    Console.WriteLine("Created another catalog product and " &amp; _
                                      ControlChars.CrLf &amp; "                    overriden the list price.")

                    ' create a new write-in opportunity product with a manual discount applied
                    Dim writeInProduct As OpportunityProduct = New OpportunityProduct With { _
                        .OpportunityId = New EntityReference(Opportunity.EntityLogicalName, _opportunityId), _
                        .IsProductOverridden = True, .ProductDescription = "Example Write-in Product", _
                        .PricePerUnit = New Money(20D), .Quantity = 5, _
                        .ManualDiscountAmount = New Money(10.5D), .Tax = New Money(7.16D)}

                    _writeInProductId = _serviceProxy.Create(writeInProduct)
                    Console.WriteLine("Created {0}.", writeInProduct.ProductDescription)

                    DeleteRequiredRecords(promptForDelete)
                End Using
            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub


        ''' <summary>
        ''' This method creates any entity records that this sample requires.
        ''' Create a unit group.
        ''' Retrieve the default unit.
        ''' Create few products.
        ''' Create new discount list and discount.
        ''' Create new price list and few price list items.
        ''' Create an account record.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            ' Create a unit group
            Dim newUnitGroup As UoMSchedule = New UoMSchedule With {.Name = "Example Unit Group", .BaseUoMName = "Example Primary Unit"}

            _unitGroupId = _serviceProxy.Create(newUnitGroup)
            Console.WriteLine("Created {0}", newUnitGroup.Name)

            ' Retrieve the default unit id that was automatically created
            ' when we created the Unit Group
            Dim unitQuery As QueryExpression = New QueryExpression With { _
                .EntityName = UoM.EntityLogicalName, .ColumnSet = New ColumnSet("uomid", "name"), _
                .PageInfo = New PagingInfo With {.PageNumber = 1, .Count = 1}}
            unitQuery.Criteria = New FilterExpression()
            unitQuery.Criteria.AddCondition("uomscheduleid", ConditionOperator.Equal, {_unitGroupId})
            ' Retrieve the unit.
            Dim unit As UoM = CType(_serviceProxy.RetrieveMultiple(unitQuery).Entities(0), UoM)

            _defaultUnitId = unit.UoMId.Value

            Console.WriteLine("Retrieved {0}", unit.Name)

            ' Create a few products
            Dim newProduct1 As Product = New Product With {.ProductNumber = "1", .Name = "Example Product 1", .QuantityDecimal = 2, _
                                                .DefaultUoMScheduleId = New EntityReference(UoMSchedule.EntityLogicalName, _unitGroupId), _
                                                .DefaultUoMId = New EntityReference(UoM.EntityLogicalName, _defaultUnitId)}

            _product1Id = _serviceProxy.Create(newProduct1)
            Console.WriteLine("Created {0}", newProduct1.Name)

            Dim newProduct2 As Product = New Product With {.ProductNumber = "2", .Name = "Example Product 2", .QuantityDecimal = 3, _
                                                .DefaultUoMScheduleId = New EntityReference(UoMSchedule.EntityLogicalName, _unitGroupId), _
                                                .DefaultUoMId = New EntityReference(UoM.EntityLogicalName, _defaultUnitId)}

            _product2Id = _serviceProxy.Create(newProduct2)
            Console.WriteLine("Created {0}", newProduct2.Name)

            ' Create a new discount list
            Dim newDiscountType As DiscountType = New DiscountType With {.Name = "Example Discount List", .IsAmountType = False}

            _discountTypeId = _serviceProxy.Create(newDiscountType)
            Console.WriteLine("Created {0}", newDiscountType.Name)

            ' Create a new discount
            Dim newDiscount As Discount = New Discount With {.DiscountTypeId = _
                New EntityReference(DiscountType.EntityLogicalName, _discountTypeId), .LowQuantity = 5, .HighQuantity = 10, .Percentage = 3}

            _discountId = _serviceProxy.Create(newDiscount)

            Console.WriteLine("Created new discount for the {0}.", newDiscountType.Name)

            ' Create a price list
            Dim newPriceList As PriceLevel = New PriceLevel With {.Name = "Example Price List"}

            _priceListId = _serviceProxy.Create(newPriceList)
            Console.WriteLine("Created {0}", newPriceList.Name)

            ' Create a price list item for the first product and apply volume discount
            Dim newPriceListItem1 As ProductPriceLevel = New ProductPriceLevel With { _
                .PriceLevelId = New EntityReference(PriceLevel.EntityLogicalName, _priceListId), _
                .ProductId = New EntityReference(Product.EntityLogicalName, _product1Id), _
                .UoMId = New EntityReference(UoM.EntityLogicalName, _defaultUnitId), .Amount = New Money(20), _
                .DiscountTypeId = New EntityReference(DiscountType.EntityLogicalName, _discountTypeId)}

            _priceListItem1Id = _serviceProxy.Create(newPriceListItem1)
            Console.WriteLine("Created price list item for the {0} and applied " &amp; _
                              ControlChars.CrLf &amp; "                volume discount.", newProduct1.Name)

            ' Create a price list item for the second product
            Dim newPriceListItem2 As ProductPriceLevel = New ProductPriceLevel With { _
                .PriceLevelId = New EntityReference(PriceLevel.EntityLogicalName, _priceListId), _
                .ProductId = New EntityReference(Product.EntityLogicalName, _product2Id), _
                .UoMId = New EntityReference(UoM.EntityLogicalName, _defaultUnitId), .Amount = New Money(15)}

            _priceListItem2Id = _serviceProxy.Create(newPriceListItem2)
            Console.WriteLine("Created price list item for the {0}.", newProduct1.Name)

            ' Create an account record for the opporutnity's potential customerid 
            Dim newAccount As Account = New Account With {.Name = "Example Account"}
            _accountId = _serviceProxy.Create(newAccount)

            Console.WriteLine("Created {0}", newAccount.Name)

            Return
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user to delete 
        ''' the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n)")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
            End If

            If deleteRecords Then
                _serviceProxy.Delete("opportunityproduct", _writeInProductId)
                _serviceProxy.Delete("opportunityproduct", _catalogProductPriceOverrideId)
                _serviceProxy.Delete("opportunityproduct", _catalogProductId)
                _serviceProxy.Delete("opportunity", _opportunityId)
                _serviceProxy.Delete("account", _accountId)
                _serviceProxy.Delete("productpricelevel", _priceListItem1Id)
                _serviceProxy.Delete("productpricelevel", _priceListItem2Id)
                _serviceProxy.Delete("pricelevel", _priceListId)
                _serviceProxy.Delete("product", _product1Id)
                _serviceProxy.Delete("product", _product2Id)
                _serviceProxy.Delete("discount", _discountId)
                _serviceProxy.Delete("discounttype", _discountTypeId)
                _serviceProxy.Delete("uomschedule", _unitGroupId)

                Console.WriteLine("Entity records have been deleted.")
            End If
        End Sub

        #End Region ' How To Sample Code

        #Region "Main"
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

                Dim app As New CreateOpportunity()
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
        #End Region ' Main
    End Class
End Namespace

' </snippetcreateopportunity>