' <snippetretrievemultipleconditionoperatorsfetch1>


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

' </snippetretrievemultipleconditionoperatorsfetch1>