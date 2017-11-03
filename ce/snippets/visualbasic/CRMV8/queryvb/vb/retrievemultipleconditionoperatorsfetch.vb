' <snippetretrievemultipleconditionoperatorsfetch>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' Demonstrates how to do use retrieve multiple condition operators for all
    ''' query types.</summary>
    ''' <remarks>
    ''' At run-time, you will be given the option to delete all the
    ''' database records created by this program.</remarks>
    Public Class RetrieveMultipleConditionOperatorsFetch
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
        ''' This method first connects to the Organization service. Afterwards,
        ''' basic Fetch queries are performed.
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

                    _service = CType(_serviceProxy, IOrganizationService)

                    CreateRequiredRecords()

'                    #Region "SQL Query Translated to Fetch"
                    ' Build the following SQL query using QueryExpression:
                    '
                    '        SELECT contact.fullname, contact.address1_telephone1
                    '        FROM contact
                    '            LEFT OUTER JOIN account
                    '                ON contact.parentcustomerid = account.accountid
                    '                AND
                    '                account.name = 'Litware, Inc.'
                    '        WHERE (contact.address1_stateorprovince = 'WA'
                    '        AND
                    '            contact.address1_city in ('Redmond', 'Bellevue', 'Kirkland', 'Seattle')
                    '        AND 
                    '            contact.address1_telephone1 like '(206)%'
                    '            OR
                    '            contact.address1_telephone1 like '(425)%'
                    '        AND
                    '            DATEDIFF(DAY, contact.createdon, GETDATE()) > 0
                    '        AND
                    '            DATEDIFF(DAY, contact.createdon, GETDATE()) < 30
                    '        AND
                    '            contact.emailaddress1 Not NULL
                    '               )

                    Dim fetchXml As String = "<fetch mapping=""logical"" count=""50"" version=""1.0"">" &amp; ControlChars.CrLf &amp; _
                        "                                            <entity name=""contact"">" &amp; ControlChars.CrLf &amp; _
                        "                                                <attribute name=""address1_telephone1"" />" &amp; ControlChars.CrLf &amp; _
                        "                                                <attribute name=""contactid"" />" &amp; ControlChars.CrLf &amp; _
                        "                                                <attribute name=""firstname"" />" &amp; ControlChars.CrLf &amp; _
                        "                                                <attribute name=""lastname"" />" &amp; ControlChars.CrLf &amp; _
                        "                                                <filter>" &amp; ControlChars.CrLf &amp; _
                        "                                                    <condition attribute=""address1_stateorprovince"" operator=""eq"" " &amp; _
                        "                                                       value=""WA"" />" &amp; ControlChars.CrLf &amp; _
                        "                                                    <condition attribute=""address1_city"" operator=""in"">" &amp; ControlChars.CrLf &amp; _
                        "                                                        <value>Redmond</value>" &amp; ControlChars.CrLf &amp; _
                        "                                                        <value>Bellevue</value>" &amp; ControlChars.CrLf &amp; _
                        "                                                        <value>Kirkland</value>" &amp; ControlChars.CrLf &amp; _
                        "                                                        <value>Seattle</value>" &amp; ControlChars.CrLf &amp; _
                        "                                                    </condition>" &amp; ControlChars.CrLf &amp; _
                        "                                                    <condition attribute=""createdon"" operator=""last-x-days"" value=""30"" />" &amp; ControlChars.CrLf &amp; _
                        "                                                    <condition attribute=""emailaddress1"" operator=""not-null"" />" &amp; ControlChars.CrLf &amp; _
                        "                                                    <filter type=""or"">" &amp; ControlChars.CrLf &amp; _
                        "                                                        <condition attribute=""address1_telephone1"" operator=""like"" value=""(206)%"" />" &amp; ControlChars.CrLf &amp; _
                        "                                                        <condition attribute=""address1_telephone1"" operator=""like"" value=""(425)%"" />" &amp; ControlChars.CrLf &amp; _
                        "                                                    </filter>" &amp; ControlChars.CrLf &amp; _
                        "                                                </filter>" &amp; ControlChars.CrLf &amp; _
                        "                                                <link-entity name=""account"" from=""accountid"" to=""parentcustomerid"">" &amp; ControlChars.CrLf &amp; _
                        "                                                    <filter>" &amp; ControlChars.CrLf &amp; _
                        "                                                        <condition attribute=""name"" operator=""eq"" value=""Litware, Inc."" />" &amp; ControlChars.CrLf &amp; _
                        "                                                    </filter>" &amp; ControlChars.CrLf &amp; _
                        "                                                </link-entity>" &amp; ControlChars.CrLf &amp; _
                        "                                            </entity>" &amp; ControlChars.CrLf &amp; _
                        "                                        </fetch>"

                    ' Build fetch request and obtain results.
                    Dim efr As New RetrieveMultipleRequest() With {.Query = New FetchExpression(fetchXml)}

                    Dim entityResults As EntityCollection = (CType(_service.Execute(efr), RetrieveMultipleResponse)).EntityCollection


                    ' Display the results.
                    Console.WriteLine("List all contacts matching specified parameters")
                    Console.WriteLine("===============================================")
                    For Each e In entityResults.Entities
                        Console.WriteLine("Contact ID: {0}", e.Id)
                    Next e


                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()
'                    #End Region

'                    #Region "Find all orders fulfilled in the last fiscal period"
                    fetchXml = "<fetch>" &amp; ControlChars.CrLf &amp; _
                        "                                    <entity name='salesorder'>" &amp; ControlChars.CrLf &amp; _
                        "                                        <attribute name='name'/>" &amp; ControlChars.CrLf &amp; _
                        "                                        <filter type='and'>" &amp; ControlChars.CrLf &amp; _
                        "                                            <condition attribute='datefulfilled' " &amp; ControlChars.CrLf &amp; _
                        "                                                operator='last-fiscal-period'/>" &amp; ControlChars.CrLf &amp; _
                        "                                        </filter>" &amp; ControlChars.CrLf &amp; _
                        "                                    </entity>" &amp; ControlChars.CrLf &amp; _
                        "                                </fetch>"

                    ' Build fetch request and obtain results.
                    efr = New RetrieveMultipleRequest() With {.Query = New FetchExpression(fetchXml)}
                    entityResults = (CType(_service.Execute(efr), RetrieveMultipleResponse)).EntityCollection

                    ' Display results.
                    Console.WriteLine("List all orders fulfilled in the last fiscal period")
                    Console.WriteLine("===================================================")
                    For Each e In entityResults.Entities
                        Console.WriteLine("Fetch Retrieved: {0}", e.Attributes("name"))
                    Next e

                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()
'                    #End Region

'                    #Region "Find all Opportunities with estimated close date in next 3 fiscal years"
                    fetchXml = "<fetch>" &amp; ControlChars.CrLf &amp; _
                        "                                    <entity name='opportunity'>" &amp; ControlChars.CrLf &amp; _
                        "                                            <attribute name='name'/>" &amp; ControlChars.CrLf &amp; _
                        "                                            <filter type='and'>" &amp; ControlChars.CrLf &amp; _
                        "                                                    <condition attribute='estimatedclosedate'" &amp; ControlChars.CrLf &amp; _
                        "                                                               operator='next-x-fiscal-years'" &amp; ControlChars.CrLf &amp; _
                        "                                                               value='3'/>" &amp; ControlChars.CrLf &amp; _
                        "                                            </filter>" &amp; ControlChars.CrLf &amp; _
                        "                                    </entity>" &amp; ControlChars.CrLf &amp; _
                        "                                </fetch>"

                    ' Build fetch request and obtain results.
                    efr = New RetrieveMultipleRequest() With {.Query = New FetchExpression(fetchXml)}
                    entityResults = (CType(_service.Execute(efr), RetrieveMultipleResponse)).EntityCollection

                                        ' Display results.
                    Console.WriteLine("List all opportunities with estimated close date in next 3 fiscal years")
                    Console.WriteLine("=======================================================================")
                    For Each e In entityResults.Entities
                        Console.WriteLine("Fetch Retrieved: {0}", e.Attributes("name"))
                    Next e

                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()
'                    #End Region

'                    #Region "Find all Orders fulfilled in fiscal year 2008"
                    fetchXml = "<fetch>" &amp; ControlChars.CrLf &amp; _
                        "                                    <entity name='salesorder'>" &amp; ControlChars.CrLf &amp; _
                        "                                            <attribute name='name'/>" &amp; ControlChars.CrLf &amp; _
                        "                                            <filter type='and'>" &amp; ControlChars.CrLf &amp; "                                                    <condition attribute='datefulfilled'" &amp; ControlChars.CrLf &amp; "                                                               operator='in-fiscal-year'" &amp; ControlChars.CrLf &amp; "                                                               value='2008'/>" &amp; ControlChars.CrLf &amp; "                                            </filter>" &amp; ControlChars.CrLf &amp; "                                    </entity>" &amp; ControlChars.CrLf &amp; "                                </fetch>"

                    ' Build fetch request and obtain results.
                    efr = New RetrieveMultipleRequest() With {.Query = New FetchExpression(fetchXml)}
                    entityResults = (CType(_service.Execute(efr), RetrieveMultipleResponse)).EntityCollection


                    ' Display results.
                    Console.WriteLine("List all orders fulfilled in fiscal year 2008")
                    Console.WriteLine("=============================================")
                    For Each e In entityResults.Entities
                        Console.WriteLine("Fetch Retrieved: {0}", e.Attributes("name"))
                    Next e
                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()
'                    #End Region

'                    #Region "Find all Orders fulfilled in period 3 of any fiscal year"
                    fetchXml = "<fetch>" &amp; ControlChars.CrLf &amp; _
                        "                                    <entity name='salesorder'>" &amp; ControlChars.CrLf &amp; _
                        "                                            <attribute name='name'/>" &amp; ControlChars.CrLf &amp; _
                        "                                            <filter type='and'>" &amp; ControlChars.CrLf &amp; _
                        "                                                    <condition attribute='datefulfilled'" &amp; ControlChars.CrLf &amp; _
                        "                                                               operator='in-fiscal-period'" &amp; ControlChars.CrLf &amp; _
                        "                                                               value='3'/>" &amp; ControlChars.CrLf &amp; _
                        "                                            </filter>" &amp; ControlChars.CrLf &amp; _
                        "                                    </entity>" &amp; ControlChars.CrLf &amp; _
                        "                                </fetch>"

                    ' Build fetch request and obtain results.
                    efr = New RetrieveMultipleRequest() With {.Query = New FetchExpression(fetchXml)}
                    entityResults = (CType(_service.Execute(efr), RetrieveMultipleResponse)).EntityCollection


                    ' Display results.
                    Console.WriteLine("List all orders fulfilled in period 3 of any fiscal year")
                    Console.WriteLine("========================================================")
                    For Each e In entityResults.Entities
                        Console.WriteLine("Fetch Retrieved: {0}", e.Attributes("name"))
                    Next e
                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()
'                    #End Region

'                    #Region "Find all Orders fulfilled in period 3 of fiscal year 2008"
                    fetchXml = "<fetch>" &amp; ControlChars.CrLf &amp; _
                        "                                    <entity name='salesorder'>" &amp; ControlChars.CrLf &amp; _
                        "                                            <attribute name='name'/>" &amp; ControlChars.CrLf &amp; _
                        "                                            <filter type='and'>" &amp; ControlChars.CrLf &amp; _
                        "                                                    <condition attribute='datefulfilled' operator='in-fiscal-period-and-year'>" &amp; ControlChars.CrLf &amp; _
                        "                                                            <value>3</value>" &amp; ControlChars.CrLf &amp; _
                        "                                                            <value>2008</value>" &amp; ControlChars.CrLf &amp; _
                        "                                                    </condition>" &amp; ControlChars.CrLf &amp; _
                        "                                            </filter>" &amp; ControlChars.CrLf &amp; _
                        "                                    </entity>" &amp; ControlChars.CrLf &amp; _
                        "                                </fetch>"

                    ' Build fetch request and obtain results.
                    efr = New RetrieveMultipleRequest() With {.Query = New FetchExpression(fetchXml)}
                    entityResults = (CType(_service.Execute(efr), RetrieveMultipleResponse)).EntityCollection


                    ' Display results.
                    Console.WriteLine("List all orders fulfilled in period 3 of fiscal year 2008")
                    Console.WriteLine("=========================================================")
                    For Each e In entityResults.Entities
                        Console.WriteLine("Fetch Retrieved: {0}", e.Attributes("name"))
                    Next e
                    Console.WriteLine("<End of Listing>")
                    Console.WriteLine()
'                    #End Region

                    ' Note: the following two queries use aggregation which is only
                    ' possible to perform in Fetch, not in QueryExpression or LINQ.

'                    #Region "Sum the total amount of all orders, grouped by year"
                    fetchXml = "<fetch aggregate='true'>" &amp; ControlChars.CrLf &amp; _
                        "                                    <entity name='salesorder'>" &amp; ControlChars.CrLf &amp; _
                        "                                        <attribute name='totalamount' aggregate='sum' alias='total'/>" &amp; ControlChars.CrLf &amp; _
                        "                                        <attribute name='datefulfilled' groupby='true' dategrouping='fiscal-year' alias='datefulfilled'/>" &amp; ControlChars.CrLf &amp; _
                        "                                    </entity>" &amp; ControlChars.CrLf &amp; _
                        "                                 </fetch>"

                    ' Build fetch request and obtain results.
                    efr = New RetrieveMultipleRequest() With {.Query = New FetchExpression(fetchXml)}
                    entityResults = (CType(_service.Execute(efr), RetrieveMultipleResponse)).EntityCollection

                    ' Display results.
                    Console.WriteLine("List totals of all orders grouped by year")
                    Console.WriteLine("=========================================")
                    For Each e In entityResults.Entities
                        Console.WriteLine("Fetch Retrieved Total: {0}", e.FormattedValues("total"))
                    Next e

                     Console.WriteLine("<End of Listing>")
                    Console.WriteLine()
'                    #End Region

'                    #Region "Sum the total amount of all Orders grouped by period and year"
                    fetchXml = "<fetch aggregate='true'>" &amp; ControlChars.CrLf &amp; _
                        "                                    <entity name='salesorder'>" &amp; ControlChars.CrLf &amp; _
                        "                                        <attribute name='totalamount' aggregate='sum' alias='total'/>" &amp; ControlChars.CrLf &amp; _
                        "                                        <attribute name='datefulfilled' groupby='true' dategrouping='fiscal-period' alias='datefulfilled'/>" &amp; ControlChars.CrLf &amp; _
                        "                                    </entity>" &amp; ControlChars.CrLf &amp; _
                        "                                 </fetch>"

                    ' Build fetch request and obtain results.
                    efr = New RetrieveMultipleRequest() With {.Query = New FetchExpression(fetchXml)}
                    entityResults = (CType(_service.Execute(efr), RetrieveMultipleResponse)).EntityCollection


                    ' Display results.
                    Console.WriteLine("List total of all orders grouped by period and year")
                    Console.WriteLine("===================================================")
                    For Each e In entityResults.Entities
                        Console.WriteLine("Fetch Retrieved: {0}", e.FormattedValues("total"))
                    Next e
                    Console.WriteLine("<End of Listing>")
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
            ' Create a unit group.
            Dim unitGroup As UoMSchedule = New UoMSchedule With {.Name = "Example Unit Group", .BaseUoMName = "Example Primary Unit"}
            _unitGroupId = _service.Create(unitGroup)

            ' Retrieve the unit.
            Dim unitQuery As New QueryExpression() With { _
                .EntityName = UoM.EntityLogicalName, .ColumnSet = New ColumnSet("uomid", "name"), _
                .PageInfo = New PagingInfo With {.PageNumber = 1, .Count = 1}}
            unitQuery.Criteria.AddCondition(New ConditionExpression("uomscheduleid", ConditionOperator.Equal, _unitGroupId))
            Dim unit As UoM = CType(_service.RetrieveMultiple(unitQuery).Entities(0), UoM)

            ' Create an account.
            Dim account As Account = New Account With {.Name = "Litware, Inc.", .Address1_StateOrProvince = "Colorado"}
            _accountId = (_service.Create(account))

            ' Create the 2 contacts.
            Dim contact As New Contact() With { _
                .FirstName = "Ben", .LastName = "Andrews", .EMailAddress1 = "sample@example.com", .Address1_City = "Redmond", _
                .Address1_StateOrProvince = "WA", .Address1_Telephone1 = "(206)555-5555", _
                .ParentCustomerId = New EntityReference With {.Id = _accountId, .LogicalName = account.LogicalName}}
            _contactIdList.Add(_service.Create(contact))

            contact = New Contact() With {.FirstName = "Colin", .LastName = "Wilcox", .EMailAddress1 = "sample@example.com", _
                      .Address1_City = "Bellevue", .Address1_StateOrProvince = "WA", .Address1_Telephone1 = "(425)555-5555", _
                      .ParentCustomerId = New EntityReference With {.Id = _accountId, .LogicalName = account.LogicalName}}
            _contactIdList.Add(_service.Create(contact))

            ' Create pricing and product objects.
            Dim priceLevel As New PriceLevel() With {.Name = "Faux Price List"}
            _priceLevelId = _service.Create(priceLevel)

            Dim product As New Product() With { _
                .ProductNumber = "1", .QuantityDecimal = 4, .Name = "Faux Product", .Price = New Money(20D), _
                .DefaultUoMId = New EntityReference With {.Id = unit.Id, .LogicalName = UoM.EntityLogicalName}, _
                .DefaultUoMScheduleId = New EntityReference With {.Id = _unitGroupId, .LogicalName = UoMSchedule.EntityLogicalName}}
            _productId = _service.Create(product)

            Dim productPrice As New ProductPriceLevel() With {.PriceLevelId = New EntityReference() With { _
                    .Id = _priceLevelId, .LogicalName = priceLevel.EntityLogicalName}, _
                    .ProductId = New EntityReference() With {.Id = _productId, .LogicalName = product.EntityLogicalName}, _
                    .UoMId = New EntityReference With {.Id = unit.Id, .LogicalName = UoM.EntityLogicalName}, .Amount = New Money(20D)}
            _productPriceId = _service.Create(productPrice)

            ' Create 3 orders.
            Dim order As New SalesOrder() With { _
                .Name = "Faux Order", .DateFulfilled = New Date(2010, 8, 1), .PriceLevelId = New EntityReference With { _
                    .Id = _priceLevelId, .LogicalName = priceLevel.EntityLogicalName}, .CustomerId = New EntityReference With { _
                    .Id = _accountId, .LogicalName = account.LogicalName}, .FreightAmount = New Money(20D)}
            _orderIdList.Add(_service.Create(order))

            order = New SalesOrder() With { _
                .Name = "Old Faux Order", .DateFulfilled = New Date(2010, 4, 1), .PriceLevelId = New EntityReference With { _
                    .Id = _priceLevelId, .LogicalName = priceLevel.EntityLogicalName}, .CustomerId = New EntityReference With { _
                    .Id = _accountId, .LogicalName = account.LogicalName}, .FreightAmount = New Money(20D)}
            _orderIdList.Add(_service.Create(order))

            order = New SalesOrder() With {.Name = "Oldest Faux Order", .DateFulfilled = New Date(2008, 8, 1), _
                                            .PriceLevelId = New EntityReference With { _
                                                .Id = _priceLevelId, .LogicalName = priceLevel.EntityLogicalName}, _
                                           .CustomerId = New EntityReference With {.Id = _accountId, .LogicalName = account.LogicalName}, _
                                           .FreightAmount = New Money(20D)}
            _orderIdList.Add(_service.Create(order))

            ' Create 2 opportunities.
            Dim opportunity As New Opportunity() With {.Name = "Litware, Inc. Opportunity 1", _
                                                       .EstimatedCloseDate = New Date(2011, 1, 1), .CustomerId = New EntityReference With { _
                                                           .Id = _accountId, .LogicalName = account.LogicalName}}
            _opportunityIdList.Add(_service.Create(opportunity))

            opportunity = New Opportunity() With {.Name = "Litware, Inc. Opportunity 2", .EstimatedCloseDate = New Date(2020, 1, 1), _
                                                  .CustomerId = New EntityReference With {.Id = _accountId, .LogicalName = account.LogicalName}}
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
                If answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty Then
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
                Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

                Dim app As New RetrieveMultipleConditionOperatorsFetch()
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

' </snippetretrievemultipleconditionoperatorsfetch>