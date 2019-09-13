' <snippetinvokeduplicatedetectionforcreateandupdate>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages

Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' Demonstrates how to do basic entity operations like create, and
    ''' update, using Duplicate Detection attribute.</summary>
    ''' <remarks>
    ''' At run-time, you will be given the option to delete all the
    ''' database records created by this program.</remarks>
    Public Class InvokeDuplicateDetectionForCreateAndUpdate
        #Region "Class Level Members"

        Private _accountId As Guid
        Private _ruleId As Guid
        Private _dupAccountId As Guid
        Private _serviceProxy As OrganizationServiceProxy
        Private _service As IOrganizationService

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

                    ' Create and account record with the named Proseware, Inc. and already existing Account Number.
                    Dim account As Account = New Account With {.Name = "Proseware, Inc.", .AccountNumber = "ACC005"}

                    ' Create operation by suppressing duplicate detection
                    Dim reqCreate As New CreateRequest()
                    reqCreate.Target = account
                    reqCreate.Parameters.Add("SuppressDuplicateDetection", True) ' Change to false to activate the duplicate detection.
                    Dim createResponse As CreateResponse = CType(_service.Execute(reqCreate), CreateResponse)
                    _dupAccountId = createResponse.id
                    Console.Write("Account: {0} {1} created with SuppressDuplicateDetection to true, ", account.Name, account.AccountNumber)

                    ' Retrieve the account containing with its few attributes.
                    Dim cols As New ColumnSet(New String() { "name", "accountnumber"})

                    Dim retrievedAccount As Account = CType(_service.Retrieve("account", _dupAccountId, cols), Account)
                    Console.Write("retrieved, ")

                    ' Update the existing account with new account number.
                    retrievedAccount.AccountNumber = "ACC006"

                    ' Update operation – update record, if a duplicate is not found.
                    Dim reqUpdate As New UpdateRequest()
                    reqUpdate.Target = retrievedAccount
                    reqUpdate("SuppressDuplicateDetection") = False ' Duplicate detection is activated.

                    ' Update the account record.
                    Dim updateResponse As UpdateResponse = CType(_service.Execute(reqUpdate), UpdateResponse)
                    Console.WriteLine("and updated.")

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
            ' Create an account record named Fourth Coffee.
            Dim account As Account = New Account With {.Name = "Fourth Coffee", .AccountNumber = "ACC005"}
            _accountId = _service.Create(account)
            Console.Write("Account {0} {1} created, ", account.Name, account.AccountNumber)

            ' Create a duplicate detection rule
            Dim accountDuplicateRule As DuplicateRule = New DuplicateRule With { _
                .Name = "DuplicateRule: Accounts with the same Account Number", .BaseEntityName = "account", _
                .MatchingEntityName = "account"}
            _ruleId = _service.Create(accountDuplicateRule)

            ' Create a duplicate detection rule condition
            Dim accountDupCondition As DuplicateRuleCondition = New DuplicateRuleCondition With { _
                .BaseAttributeName = "accountnumber", .MatchingAttributeName = "accountnumber", .OperatorCode = New OptionSetValue(0), _
                .RegardingObjectId = New EntityReference(DuplicateRule.EntityLogicalName, _ruleId)}
            Dim conditionId As Guid = _service.Create(accountDupCondition)

            Console.Write("'{0}' created, ", accountDuplicateRule.Name)

            ' Execute the publish request.
            Dim response As PublishDuplicateRuleResponse = CType(_service.Execute(New PublishDuplicateRuleRequest() With { _
                                                                    .DuplicateRuleId = _ruleId}), PublishDuplicateRuleResponse)

            ' When the publishDuplicateRule request returns, the state of the rule will still be "Publishing" (StatusCode = 1).
            ' we need to wait for the publishing operation to complete, so we keep polling the state of the
            ' rule until it becomes "Published" (StatusCode = 2).
            Dim i As Integer = 0
            Dim retrievedRule As DuplicateRule = CType(_service.Retrieve(DuplicateRule.EntityLogicalName, _ruleId, _
                                                            New ColumnSet(New String() {"statuscode"})), DuplicateRule)
            Do While retrievedRule.StatusCode.Value = 1 AndAlso i < 20
                i += 1
                System.Threading.Thread.Sleep(1000)
                retrievedRule = CType(_service.Retrieve(DuplicateRule.EntityLogicalName, _ruleId, _
                                                        New ColumnSet(New String() {"statuscode"})), DuplicateRule)
            Loop

            Console.Write("published." &amp; vbLf)
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty)
            End If

            If deleteRecords Then
                _service.Delete(Account.EntityLogicalName, _accountId)
                Dim unpublishRequest As UnpublishDuplicateRuleRequest = New UnpublishDuplicateRuleRequest With {.DuplicateRuleId = _ruleId}
                _service.Execute(unpublishRequest)
                _service.Delete(DuplicateRule.EntityLogicalName, _ruleId)
                _service.Delete(Account.EntityLogicalName, _dupAccountId)
                Console.WriteLine("Entity records have been deleted.")
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

                Dim app As New InvokeDuplicateDetectionForCreateAndUpdate()
                app.Run(config, True)
            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
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
                        Console.WriteLine("Trace: {0}", fe.Detail.TraceText)
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

' </snippetinvokeduplicatedetectionforcreateandupdate>