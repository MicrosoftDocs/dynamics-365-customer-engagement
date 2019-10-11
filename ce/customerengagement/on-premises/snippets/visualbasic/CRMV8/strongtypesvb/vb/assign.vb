' <snippetassign>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Client

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' This Sample shows how to assign an account to another user.
    ''' </summary>
    ''' <remarks>
    ''' Note: This sample expects another user to be present in 
    ''' the current business unit other than the current credentials.
    ''' </remarks>


    Public Class Assign
        #Region "Class Level Members"


        ' Define the IDs needed for this sample.
        Private _accountId As Guid
        Private _myUserId As Guid
        Private _otherUserId As Guid



        ' Declare the service proxy referring the CRUD
        Private _serviceProxy As OrganizationServiceProxy
        Private _service As IOrganizationService

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Retrieves new owner's details and creates an account record.
        ''' Assign the account to new owner.
        ''' Optionally delete any entity records that were created for this sample.
        ' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptForDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
            Try

                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    _service = CType(_serviceProxy, IOrganizationService)

                    ' Call the method to create any data that this sample requires.
                    CreateRequiredRecords()

                    ' Create the Request Object and Set the Request Object's Properties
                    Dim assign As AssignRequest = New AssignRequest With { _
                        .Assignee = New EntityReference(SystemUser.EntityLogicalName, _otherUserId), _
                        .Target = New EntityReference(Account.EntityLogicalName, _accountId)}


                    ' Execute the Request
                    _service.Execute(assign)

                    Console.WriteLine("The account is owned by new owner.")

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
        ''' Retrieves the user details.
        ''' Create an account record.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            Dim userRequest As New WhoAmIRequest()
            Dim user As WhoAmIResponse = CType(_service.Execute(userRequest), WhoAmIResponse)

            ' Current user.
            _myUserId = user.UserId

            ' Query to retrieve other users.
            Dim querySystemUser As QueryExpression = New QueryExpression With { _
                .EntityName = SystemUser.EntityLogicalName, .ColumnSet = New ColumnSet(New String() {"systemuserid", "fullname"}), _
                .Criteria = New FilterExpression()}

            querySystemUser.Criteria.AddCondition("businessunitid", ConditionOperator.Equal, user.BusinessUnitId)
            querySystemUser.Criteria.AddCondition("systemuserid", ConditionOperator.NotEqual, _myUserId)
            ' Excluding SYSTEM user.
            querySystemUser.Criteria.AddCondition("lastname", ConditionOperator.NotEqual, "SYSTEM")
            ' Excluding INTEGRATION user.
            querySystemUser.Criteria.AddCondition("lastname", ConditionOperator.NotEqual, "INTEGRATION")

            Dim otherUsers As DataCollection(Of Entity) = _service.RetrieveMultiple(querySystemUser).Entities

            Dim count As Integer = _service.RetrieveMultiple(querySystemUser).Entities.Count
            If count > 0 Then
                _otherUserId = CType(otherUsers(count-1).Attributes("systemuserid"), Guid)

                Console.WriteLine("Retrieved new owner {0} for assignment.", otherUsers(count - 1).Attributes("fullname"))
            Else
                Throw New FaultException("No other user found in the current business unit for assignment.")
            End If

            ' Create an Account record 
            Dim newAccount As Account = New Account With {.Name = "Example Account"}

            _accountId = _service.Create(newAccount)
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
                Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty)
            End If

            If deleteRecords Then
                _service.Delete(Account.EntityLogicalName, _accountId)
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

                Dim app As New Assign()
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

' </snippetassign>