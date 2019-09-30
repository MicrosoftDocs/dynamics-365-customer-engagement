' <snippetquickcampaign>


Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' This sample shows how to distribute a quick campaign to 
    ''' the marketing list members or to the accounts selected by a query.
    ''' </summary>
    Public Class QuickCampaign
#Region "Class Level Members"

        ' Define the IDs as well as strings needed for this sample.
        'private static string _uniqStringForThisRun;
        Private _accountIdArray() As Guid
        Private _templateEmailActivity As Email
        Private _templateLetterActivity As Letter
        Private _newListId As Guid
        Private _currentUser As Guid
        Private _qcBOId As Guid
        Private _serviceProxy As OrganizationServiceProxy

#End Region ' Class Level Members

#Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Initiate the method to create any data that this sample requires.
        ''' Delete a new queue instance.
        ''' Optionally delete any entity records that were created for this sample.
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

                    ' Call the method to create any data that this sample requires.
                    CreateRequiredRecords()

                    '					#Region "Run a QC with marketing list as input"


                    Dim newList As New List() With
                        {
                            .ListName = "TestList",
                            .CreatedFromCode =
                            New OptionSetValue(CInt(Fix(ListCreatedFromCode.Account)))
                        }

                    _newListId = _serviceProxy.Create(newList)

                    For j As Integer = 0 To 4
                        Dim addMemberListRequest As New AddMemberListRequest()
                        addMemberListRequest.EntityId = _accountIdArray(j)
                        addMemberListRequest.ListId = _newListId
                        Dim addMemberListResponse As AddMemberListResponse =
                            TryCast(_serviceProxy.Execute(addMemberListRequest), 
                                AddMemberListResponse)
                    Next j

                    Dim BOId As Guid = CreateAndRetrieveQuickCampaignForMarketingList(
                        _templateLetterActivity,
                        _newListId,
                        PropagationOwnershipOptions.ListMemberOwner,
                        True)


                    '					#End Region

                    '					#Region "Run a QC with a list of accounts as input"

                    ' Construct a Query Expression(QE) which specifies which records QC should include                
                    Dim query As New QueryExpression("account")
                    query.ColumnSet = New ColumnSet("accountid")
                    query.Criteria = New FilterExpression()
                    Dim filter As FilterExpression =
                        query.Criteria.AddFilter(LogicalOperator.Or)
                    For j As Integer = 0 To 4
                        filter.AddCondition("accountid",
                                            ConditionOperator.Equal,
                                            _accountIdArray(j))
                    Next j
                    _qcBOId = CreateAndRetrieveQuickCampaignForQueryExpression(
                        _templateEmailActivity,
                        query,
                        PropagationOwnershipOptions.ListMemberOwner,
                        True)

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
        ''' This method creates a Quick Campaign for a set of accounts selected by a query
        ''' </summary>
        ''' <param name="activityEntity">
        ''' An object that indicates activity type for the quick campaign and 
        ''' contains values for each of activity that will be created
        ''' </param>
        ''' <param name="query">
        ''' A query that provides a list of accounts for which 
        ''' the quick campaign is distributed.
        ''' </param>
        ''' <param name="ownershipOption">
        ''' Specifies who will own the activities created by the Quick Campaign
        '''	The PropagationOwnershipOptions enum is used to specify value for this parameter
        '''	</param>
        ''' <param name="isPropagate">
        ''' Specifies whether the operation is to be executed. 
        ''' This input is often 'true' for Quick Campaign
        ''' </param>        
        ''' <returns></returns>
        Public Function CreateAndRetrieveQuickCampaignForQueryExpression _
            (ByVal emailActivityEntity As Entity,
             ByVal query As QueryExpression,
             ByVal ownershipOption As PropagationOwnershipOptions,
             ByVal isPropagate As Boolean) As Guid

            ' create the bulkoperation
            Dim request As New PropagateByExpressionRequest() With
                {
                    .Activity = emailActivityEntity,
                    .ExecuteImmediately = False,
                    .FriendlyName = "Query Based Quick Campaign",
                    .OwnershipOptions = ownershipOption,
                    .QueryExpression = query,
                    .Owner = New EntityReference("systemuser", _currentUser),
                    .PostWorkflowEvent = True,
                    .SendEmail = False,
                    .TemplateId = Guid.Empty
                }

            Dim response As PropagateByExpressionResponse =
                CType(_serviceProxy.Execute(request), PropagateByExpressionResponse)

            Dim bulkOpId As Guid = response.BulkOperationId
            System.Console.WriteLine(
                "Quick Campaign with following name has been created. " _
                &amp; "Please verify in Web app manually: " _
                &amp; vbLf &amp; request.FriendlyName &amp; vbLf _
                &amp; "Press enter to continue....")
            System.Console.ReadLine()
            Return bulkOpId

        End Function

        ''' <summary>
        ''' This method creates Quick Campaign for a given Marketing List and retruns the 
        ''' Guid of the Quich Campaign which is modelled as bulk operation in CRM
        ''' </summary>
        ''' <param name="activityEntity">
        ''' An object that indicates activity type for the quick campaign and 
        ''' contains values for each activity that will be created
        ''' </param>
        ''' <param name="marketingListId">
        ''' The ID of the marketing list to which quick campaign is distributed
        ''' </param>
        ''' <param name="ownershipOption">
        ''' Specifies who will own the activities created by the Quick Campaign
        '''	The PropagationOwnershipOptions enum is used to specify value for this parameter
        '''	</param>
        ''' <param name="isPropagate">
        ''' Specifies whether the operation is to be executed. 
        ''' This input is often 'true' for Quick Campaign
        ''' </param>				
        Public Function CreateAndRetrieveQuickCampaignForMarketingList _
            (ByVal letterActivityEntity As Entity,
             ByVal marketingListId As Guid,
             ByVal ownershipOption As PropagationOwnershipOptions,
             ByVal isPropagate As Boolean) As Guid
            'Create the request object from input parameters
            Dim request As New CreateActivitiesListRequest() With
                {
                    .Activity = letterActivityEntity,
                    .ListId = marketingListId,
                    .OwnershipOptions = ownershipOption,
                    .Propagate = isPropagate, .TemplateId = Guid.Empty,
                    .FriendlyName = "Quick Campaign for My List",
                    .Owner = New EntityReference("systemuser", _currentUser),
                    .PostWorkflowEvent = True
                }

            'Execute the request
            Dim response As CreateActivitiesListResponse =
                CType(_serviceProxy.Execute(request), CreateActivitiesListResponse)

            'On executing the request a BulkOperation record would be created in CRM. 
            'If isPropagate is true, a corresponding Async job is also created which runs and creates the required activities 
            'The response has BulkOperationId. This is the Id of the bulkoperation that mimics QuickCampaign in CRM
            Dim BOId As Guid = response.BulkOperationId
            System.Console.WriteLine(
                "Quick Campaign with following name has been created. " _
                &amp; "Please verify in Web app manually: " _
                &amp; vbLf &amp; request.FriendlyName &amp; vbLf _
                &amp; "Press enter to continue....")
            System.Console.ReadLine()

            Return BOId

        End Function

        ''' <summary>
        ''' This method creates any entity records that this sample requires.
        ''' Create a new queue instance.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            Dim whoRequest As New WhoAmIRequest()
            _currentUser = (CType(_serviceProxy.Execute(whoRequest), 
                            WhoAmIResponse)).UserId

            'Create an activity object which will act like a template during QC distrbution. 
            'The activities created by QC will create activities with content that this activity has
            _templateEmailActivity = New Email() With {.Subject = "qcCreatedEmailActivity"}

            _templateLetterActivity = New Letter() With {.Subject = "qcCreatedLetterActivity"}

            ' Create accounts on which we want to run QC
            _accountIdArray = New Guid(4) {}
            For i As Integer = 0 To 4
                Dim acct As New Account() With
                    {
                        .Name = "Account For Quick Campaign " &amp; i.ToString()
                    }
                _accountIdArray(i) = _serviceProxy.Create(acct)
                Console.WriteLine("Created {0}.", acct.Name)
            Next i
        End Sub

        ''' <summary>
        ''' Deletes/Reverts the record that was created/changed for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user to delete 
        ''' the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim toBeDeleted As Boolean = True

            If prompt Then
                ' Ask the user if the created entities should be deleted.
                Console.Write(vbLf &amp;
                              "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") _
                    OrElse answer.StartsWith("Y") _
                    OrElse answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
            End If

            If toBeDeleted Then
                ' Delete all records created in this sample.
                For i As Integer = 0 To _accountIdArray.Length - 1
                    _serviceProxy.Delete(Account.EntityLogicalName, _accountIdArray(i))
                Next i
                _serviceProxy.Delete(List.EntityLogicalName, _newListId)
                _serviceProxy.Delete(BulkOperation.EntityLogicalName, _qcBOId)
                Console.WriteLine("Entity record(s) have been deleted.")
            End If
        End Sub

#End Region ' How To Sample Code

#Region "Main method"
        ''' <summary>
        ''' Main. Runs the sample and provides error output.
        ''' <param name="args">Array of arguments to Main method.</param>
        ''' </summary>
        Public Shared Sub Main(ByVal args() As String)
            Try
                ' Obtain the target organization's Web address and client logon 
                ' credentials from the user.
                Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

                Dim app As New QuickCampaign()
                app.Run(config, True)

            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
            Catch ex As System.TimeoutException
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Message: {0}", ex.Message)
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
            Catch ex As System.Exception
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
                ' Additonal exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
                ' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            Finally
                Console.WriteLine("Press <Enter> to exit.")
                Console.ReadLine()
            End Try

        End Sub
#End Region ' Main method
    End Class
End Namespace

' </snippetquickcampaign>