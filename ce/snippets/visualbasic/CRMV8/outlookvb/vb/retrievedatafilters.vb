' <snippetretrievedatafilters>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

' This namespace is found in Microsoft.Crm.Outlook.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' Shows how to use the advanced capabilities of the CrmOutlookService:
    ''' filters and templates</summary>
    ''' <remarks>
    ''' NOTE: Before running this sample, you should start the Outlook client.</remarks>
    Public Class RetrieveDataFilters
        #Region "Class Level Members"

        Private _offlineFilter As Guid
        Private _offlineTemplate As Guid

        Private _serviceProxy As OrganizationServiceProxy

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' This method first connects to the Outlook service. Afterwards,
        ''' client information is retrieved and the client state is changed.
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

                    ' Create and Retrieve Offline Filter
                    ' In your Outlook client, this will appear in the System Filters tab
                    ' under File | CRM | Synchronize | Outlook Filters.
                    Console.Write("Creating offline filter")
                    Dim contactName As String = String.Format("offlineFilteredContact {0}", Date.Now.ToLongTimeString())
                    Dim fetchXml As String = String.Format("<fetch version=""1.0"" output-format=""xml-platform"" mapping=""logical"">" &amp; _
                        "<entity name=""contact""><attribute name=""contactid"" /><filter type=""and"">" &amp; _
                        "<condition attribute=""ownerid"" operator=""eq-userid"" /><condition attribute=""description"" " &amp; _
                        "operator=""eq"" value=""{0}"" />" &amp; "<condition attribute=""statecode"" operator=""eq"" value=""0"" />" &amp; _
                        "</filter></entity></fetch>", contactName)
                    Dim filter As New SavedQuery()
                    filter.FetchXml = fetchXml
                    filter.IsQuickFindQuery = False
                    filter.QueryType = SavedQueryQueryType.OfflineFilters
                    filter.ReturnedTypeCode = Contact.EntityLogicalName
                    filter.Name = "ReadOnlyFilter_" &amp; contactName
                    filter.Description = "Sample offline filter for Contact entity"
                    _offlineFilter = _serviceProxy.Create(filter)

                    Console.WriteLine(" and retrieving offline filter")
                    Dim result As SavedQuery = CType(_serviceProxy.Retrieve(SavedQuery.EntityLogicalName, _offlineFilter, _
                                                                            New ColumnSet("name", "description")), SavedQuery)
                    Console.WriteLine("Name: {0}", result.Name)
                    Console.WriteLine("Description: {0}", result.Description)
                    Console.WriteLine()

                    ' Create and Retrieve Offline Template
                    ' In your Outlook client, this will appear in the User Filters tab
                    ' under File | CRM | Synchronize | Outlook Filters.
                    Console.Write("Creating offline template")
                    Dim accountName As String = String.Format("offlineFilteredAccount {0}", Date.Now.ToLongTimeString())
                    fetchXml = String.Format("<fetch version=""1.0"" output-format=""xml-platform"" mapping=""logical"">" &amp; _
                                             "<entity name=""account""><attribute name=""accountid"" /><filter type=""and"">" &amp; _
                                             "<condition attribute=""ownerid"" operator=""eq-userid"" /><condition attribute=""name"" " &amp; _
                                             "operator=""eq"" value=""{0}"" />" &amp; _
                                             "<condition attribute=""statecode"" operator=""eq"" value=""0"" /></filter></entity></fetch>", _
                                             accountName)
                    Dim template As New SavedQuery()
                    template.FetchXml = fetchXml
                    template.IsQuickFindQuery = False
                    template.QueryType = SavedQueryQueryType.OfflineTemplate
                    template.ReturnedTypeCode = Account.EntityLogicalName
                    template.Name = "ReadOnlyFilter_" &amp; accountName
                    template.Description = "Sample offline template for Account entity"
                    _offlineTemplate = _serviceProxy.Create(template)

                    Console.WriteLine(" and retrieving offline template")
                    result = CType(_serviceProxy.Retrieve(SavedQuery.EntityLogicalName, _offlineTemplate, _
                                                          New ColumnSet("name", "description")), SavedQuery)
                    Console.WriteLine("Name: {0}", result.Name)
                    Console.WriteLine("Description: {0}", result.Description)
                    Console.WriteLine()


                    ' Call InstantiateFiltersRequest
                    Console.WriteLine("Retrieving user's ID and creating the template collection")
                    Dim whoAmI As New WhoAmIRequest()
                    Dim id As Guid = (CType(_serviceProxy.Execute(whoAmI), WhoAmIResponse)).UserId
                    Dim templates As New EntityReferenceCollection()
                    templates.Add(New EntityReference(SavedQuery.EntityLogicalName, _offlineTemplate))

                    Console.WriteLine("Activating the selected offline templates for this user")
                    Dim request As InstantiateFiltersRequest = New InstantiateFiltersRequest With {.UserId = id, .TemplateCollection = templates}
                    Dim response As InstantiateFiltersResponse = CType(_serviceProxy.Execute(request), InstantiateFiltersResponse)
                    Console.WriteLine()


                    ' Call ResetUserFiltersRequest
                    Console.WriteLine("Resetting the user's offline templates to the defaults")
                    Dim resetRequest As ResetUserFiltersRequest = New ResetUserFiltersRequest With {.QueryType = SavedQueryQueryType.OfflineFilters}
                    Dim resetResponse As ResetUserFiltersResponse = CType(_serviceProxy.Execute(resetRequest), ResetUserFiltersResponse)
                    Console.WriteLine()

                    DeleteRequiredRecords(promptforDelete)
                End Using


            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

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
                Console.WriteLine("Deleting the offline filter and offline template")
                _serviceProxy.Delete(SavedQuery.EntityLogicalName, _offlineFilter)
                _serviceProxy.Delete(SavedQuery.EntityLogicalName, _offlineTemplate)

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

                Dim app As New RetrieveDataFilters()
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

' </snippetretrievedatafilters>