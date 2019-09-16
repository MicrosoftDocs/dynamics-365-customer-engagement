' <snippetconvertopportunitytoquote>


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
    ''' This sample shows how to convert an opporutnity to a quote.
    ''' </summary>
    Public Class ConvertOpportunityToQuote
        #Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy

        ' Define the IDs needed for this sample.
        Public _unitGroupId As Guid
        Public _product1Id As Guid
        Public _product2Id As Guid
        Public _priceListId As Guid
        Public _priceListItem1Id As Guid
        Public _priceListItem2Id As Guid
        Public _accountId As Guid
        Public _opportunityId As Guid
        Public _opportunityProduct1Id As Guid
        Public _opportunityProduct2Id As Guid
        Public _writeInProductId As Guid
        Public _quoteId As Guid

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Initiate creating all entity records that this sample requires.
        ''' Convert an opportunity to quote
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

                    ' Call the method to create any data that this sample requires.
                    CreateRequiredRecords()

                    ' Convert an opportunity to quote.
                    Dim quoteRequest As New GenerateQuoteFromOpportunityRequest() With { _
                        .ColumnSet = New ColumnSet("name", "customerid"), .OpportunityId = _opportunityId}
                        ' Columns that will be transferred

                    Dim quoteResponse As GenerateQuoteFromOpportunityResponse = _
                        CType(_serviceProxy.Execute(quoteRequest), GenerateQuoteFromOpportunityResponse)

                    _quoteId = quoteResponse.Entity.Id
                    Console.WriteLine("Created the quote from an opportunity.")

                    DeleteRequiredRecords(promptForDelete)
                End Using
            Catch
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' This method creates any entity records that this sample requires.
        ''' Create a unit group, few products, price list and price list items.
        ''' Create an account record.
        ''' Create few opportunities, opportunity products and a write-in product.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            ' Create a unit group.
            Dim newUnitGroup As UoMSchedule = New UoMSchedule With {.Name = "Example Unit Group", .BaseUoMName = "Example Primary Unit"}

            _unitGroupId = _serviceProxy.Create(newUnitGroup)

            Console.WriteLine("Created {0}", newUnitGroup.Name)

            ' retrieve the unit id.
            Dim unitQuery As QueryExpression = New QueryExpression With { _
                .EntityName = UoM.EntityLogicalName, .ColumnSet = New ColumnSet("uomid", "name"), _
                .Criteria = New FilterExpression(), .PageInfo = New PagingInfo With {.PageNumber = 1, .Count = 1}}
            unitQuery.Criteria.AddCondition("uomscheduleid", ConditionOperator.Equal, _unitGroupId)

            ' Retrieve the unit.
            Dim unit As UoM = CType(_serviceProxy.RetrieveMultiple(unitQuery).Entities(0), UoM)

            Console.WriteLine("Retrieved {0}", unit.Name)


            ' Create a few products
            Dim newProduct1 As Product = New Product With { _
                .ProductNumber = "1", .Name = "Example Product 1", .QuantityDecimal = 2, _
                .DefaultUoMScheduleId = New EntityReference(UoMSchedule.EntityLogicalName, _unitGroupId), _
                .DefaultUoMId = New EntityReference(UoM.EntityLogicalName, unit.Id)}
           _product1Id = _serviceProxy.Create(newProduct1)

           Console.WriteLine("Created {0}", newProduct1.Name)

            Dim newProduct2 As Product = New Product With { _
                .ProductNumber = "2", .Name = "Example Product 2", .QuantityDecimal = 2, _
                .DefaultUoMScheduleId = New EntityReference(UoMSchedule.EntityLogicalName, _unitGroupId), _
                .DefaultUoMId = New EntityReference(UoM.EntityLogicalName, unit.Id)}
            _product2Id = _serviceProxy.Create(newProduct2)

            Console.WriteLine("Created {0}", newProduct2.Name)

            ' Create a price list
            Dim newPriceList As PriceLevel = New PriceLevel With {.Name = "Example Price List"}
            _priceListId = _serviceProxy.Create(newPriceList)

            Console.WriteLine("Created {0}", newPriceList.Name)

            ' Create a price list items for the products
            Dim newPriceListItem1 As ProductPriceLevel = New ProductPriceLevel With { _
                .PriceLevelId = New EntityReference(PriceLevel.EntityLogicalName, _priceListId), _
                .ProductId = New EntityReference(Product.EntityLogicalName, _product1Id), _
                .UoMId = New EntityReference(UoM.EntityLogicalName, unit.Id), .Amount = New Money(20)}
            _priceListItem1Id = _serviceProxy.Create(newPriceListItem1)

            Console.WriteLine("Created price list for {0}", newProduct1.Name)

            Dim newPriceListItem2 As ProductPriceLevel = New ProductPriceLevel With { _
                .PriceLevelId = New EntityReference(PriceLevel.EntityLogicalName, _priceListId), _
                .ProductId = New EntityReference(Product.EntityLogicalName, _product2Id), _
                .UoMId = New EntityReference(UoM.EntityLogicalName, unit.Id), .Amount = New Money(20)}
            _priceListItem2Id = _serviceProxy.Create(newPriceListItem2)

            Console.WriteLine("Created price list for {0}", newProduct2.Name)

            ' Create an account record for the opportunity's potential customerid
            Dim newAccount As Account = New Account With {.Name = "Example Account"}
            _accountId = _serviceProxy.Create(newAccount)

            Console.WriteLine("Created {0}", newAccount.Name)

            ' Create a new opportunity
            Dim newOpportunity As Opportunity = New Opportunity With { _
                .Name = "Example Opportunity", .CustomerId = New EntityReference(Account.EntityLogicalName, _accountId), _
                .PriceLevelId = New EntityReference(PriceLevel.EntityLogicalName, _priceListId), .FreightAmount = New Money(10D)}
            _opportunityId = _serviceProxy.Create(newOpportunity)

            Console.WriteLine("Created {0}", newOpportunity.Name)

            ' Create an opportunity product 
            Dim newOpportunityProduct1 As OpportunityProduct = New OpportunityProduct With { _
                .OpportunityId = New EntityReference(Opportunity.EntityLogicalName, _opportunityId), _
                .ProductId = New EntityReference(Product.EntityLogicalName, _product1Id), _
                .UoMId = New EntityReference(UoM.EntityLogicalName, unit.Id), .Quantity = 3, .Tax = New Money(4.8D)}
            _opportunityProduct1Id = _serviceProxy.Create(newOpportunityProduct1)

            Console.WriteLine("Created opportunity product for {0} and {1}", newOpportunity.Name, newProduct1.Name)

            ' Create a catalog product and override the price per unit
            Dim newOpportunityProduct2 As OpportunityProduct = New OpportunityProduct With { _
                .OpportunityId = New EntityReference(Opportunity.EntityLogicalName, _opportunityId), _
                .ProductId = New EntityReference(Product.EntityLogicalName, _product2Id), _
                .UoMId = New EntityReference(UoM.EntityLogicalName, unit.Id), .Quantity = 1, .IsPriceOverridden = True, _
                .PricePerUnit = New Money(12), .Tax = New Money(0.96D)}
            _opportunityProduct2Id = _serviceProxy.Create(newOpportunityProduct2)

            Console.WriteLine("Created opportunity product for {0} and {1}", newOpportunity.Name, newProduct2.Name)

            ' Create a write-in product with a manual discount
            Dim newWriteInProduct As OpportunityProduct = New OpportunityProduct With { _
                .OpportunityId = New EntityReference(Opportunity.EntityLogicalName, _opportunityId), .IsProductOverridden = True, _
                .ProductDescription = "Example Write-in Product", .PricePerUnit = New Money(20D), .Quantity = 5, _
                .ManualDiscountAmount = New Money(10.5D), .Tax = New Money(7.16D)}
                ' set this attribute to make it a write-in product
            _writeInProductId = _serviceProxy.Create(newWriteInProduct)

            Console.WriteLine("Created {0}", newWriteInProduct.ProductDescription)

            Return
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n)")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
            End If

            If deleteRecords Then
                _serviceProxy.Delete(Quote.EntityLogicalName, _quoteId)
                _serviceProxy.Delete(OpportunityProduct.EntityLogicalName, _writeInProductId)
                _serviceProxy.Delete(OpportunityProduct.EntityLogicalName, _opportunityProduct1Id)
                _serviceProxy.Delete(OpportunityProduct.EntityLogicalName, _opportunityProduct2Id)
                _serviceProxy.Delete(Opportunity.EntityLogicalName, _opportunityId)
                _serviceProxy.Delete(Account.EntityLogicalName, _accountId)
                _serviceProxy.Delete(ProductPriceLevel.EntityLogicalName, _priceListItem1Id)
                _serviceProxy.Delete(ProductPriceLevel.EntityLogicalName, _priceListItem2Id)
                _serviceProxy.Delete(Product.EntityLogicalName, _product1Id)
                _serviceProxy.Delete(Product.EntityLogicalName, _product2Id)
                _serviceProxy.Delete(PriceLevel.EntityLogicalName, _priceListId)
                _serviceProxy.Delete(UoMSchedule.EntityLogicalName, _unitGroupId)

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

                Dim app As New ConvertOpportunityToQuote()
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

' </snippetconvertopportunitytoquote>