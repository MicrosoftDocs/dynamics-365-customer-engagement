' <snippetquerybyattribute>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' Demonstrates how to do basic entity operations like create, retrieve,
    ''' update, and delete.</summary>

    Public Class QueryByAttributeSample
        #Region "Class Level Members"

        Private _serviceProxy As OrganizationServiceProxy
        Private _service As IOrganizationService
        Private _accountIds As New List(Of Guid)()

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' This method first connects to the Organization service. Afterwards,
        ''' basic create, retrieve, update, and delete entity operations are performed.
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

                    '  Create query using QueryByAttribute.
                    Dim querybyattribute As New QueryByAttribute("account")
                    querybyattribute.ColumnSet = New ColumnSet("name", "address1_city", "emailaddress1")

                    '  Attribute to query.
                    querybyattribute.Attributes.AddRange("address1_city")

                    '  Value of queried attribute to return.
                    querybyattribute.Values.AddRange("Redmond")

                    '  Query passed to service proxy.
                    Dim retrieved As EntityCollection = _service.RetrieveMultiple(querybyattribute)

                    Console.WriteLine("Query Using QueryByAttribute")
                    Console.WriteLine("===============================")

                    '  Iterate through returned collection.
                    For Each c In retrieved.Entities
                        Console.WriteLine("Name: " &amp; c.Attributes("name").ToString())

                        If c.Attributes.Contains("address1_city") Then
                            Console.WriteLine("Address: " &amp; c.Attributes("address1_city").ToString())
                        End If

                        If c.Attributes.Contains("emailaddress1") Then
                            Console.WriteLine("E-mail: " &amp; c.Attributes("emailaddress1").ToString())
                        End If
                    Next c
                    Console.WriteLine("===============================")

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
            ' Create two accounts.
            Dim account As Account = New Account With { _
                .Name = "A. Datum Corporation", .Address1_StateOrProvince = "Colorado", .Address1_Telephone1 = "(206)555-5555", _
                .EMailAddress1 = "info@datum.com"}
            _accountIds.Add(_service.Create(account))

            account = New Account With { _
                .Name = "Adventure Works Cycle", .Address1_StateOrProvince = "Washington", .Address1_City = "Redmond", _
                .Address1_Telephone1 = "(206)555-5555", .EMailAddress1 = "contactus@adventureworkscycle.com"}
            _accountIds.Add(_service.Create(account))
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
                For Each accountId As Guid In _accountIds
                    _service.Delete(Account.EntityLogicalName, accountId)
                Next accountId
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

                Dim app As New QueryByAttributeSample()
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

' </snippetquerybyattribute>