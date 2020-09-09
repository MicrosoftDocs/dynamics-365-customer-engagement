' <snippetbulkdetectduplicates>


Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' This samples shows how to issue a BulkDetectDuplicates request.
	''' </summary>
	''' <param name="serverConfig">Contains server connection information.</param>
	''' <param name="promptforDelete">When True, the user will be prompted to delete all
	''' created entities.</param>
	Public Class BulkDetectDuplicates
		#Region "Class Level Members"

		Private _serviceProxy As OrganizationServiceProxy

		Private _duplicateAccounts(1) As Account
		Private _account As Account
		Private _rule As DuplicateRule
		Private _response As BulkDetectDuplicatesResponse

		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
		''' This method first creates 3 accounts with the same name, then issues a BulkDetectDuplicates
		''' request to show the duplicate detection.
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

                    CreateRequiredRecords()

                    ' Create the BulkDetectDuplicatesRequest object
                    Console.WriteLine("  Creating the BulkDetectDuplicatesRequest object")
                    Dim request As New BulkDetectDuplicatesRequest() With
                        {
                            .JobName = "Detect Duplicate Accounts",
                            .Query = New QueryExpression() With
                                     {
                                         .EntityName = Account.EntityLogicalName,
                                         .ColumnSet = New ColumnSet(True)
                                     },
                            .RecurrencePattern = String.Empty,
                            .RecurrenceStartTime = Date.Now,
                            .ToRecipients = New Guid() {},
                            .CCRecipients = New Guid() {}
                        }

                    ' Execute the request
                    Console.WriteLine("  Executing BulkDetectDuplicatesRequest")
                    _response = CType(_serviceProxy.Execute(request), 
                        BulkDetectDuplicatesResponse)

                    '					#Region "check success"

                    Console.WriteLine("  Waiting for job to complete...")
                    WaitForAsyncJobToFinish(_response.JobId, 120)

                    Dim query As New QueryByAttribute() With
                        {
                            .ColumnSet = New ColumnSet(True),
                            .EntityName = "duplicaterecord"
                        }
                    query.Attributes.Add("asyncoperationid")
                    query.Values.Add(_response.JobId)
                    Dim results As EntityCollection = _serviceProxy.RetrieveMultiple(query)

                    ' check to make sure each id is found in the collection
                    Dim duplicateIds = results.Entities.Select(Function(entity) (CType(entity, 
                                                                                 DuplicateRecord)).BaseRecordId.Id)
                    For Each id In _duplicateAccounts.Select(Function(account) account.Id)
                        If Not duplicateIds.Contains(id) Then
                            Throw New Exception(String.Format("Account with ID {0} was not detected as a duplicate", id))
                        End If
                    Next id
                    Console.WriteLine("  All accounts detected as duplicates successfully")

                    '					#End Region

                    Console.WriteLine()

                    DeleteRequiredRecords(promptforDelete)
                End Using

                ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

		#Region "Helper methods"

		Private Sub WaitForAsyncJobToFinish(ByVal jobId As Guid, ByVal maxTimeSeconds As Integer)
			For i As Integer = 0 To maxTimeSeconds - 1
                Dim asyncJob = _serviceProxy.Retrieve(AsyncOperation.EntityLogicalName,
                                                      jobId,
                                                      New ColumnSet("statecode")
                                                      ).ToEntity(Of AsyncOperation)()
                If asyncJob.StateCode.HasValue AndAlso
                    asyncJob.StateCode.Value = AsyncOperationState.Completed Then
                    Return
                End If
				System.Threading.Thread.Sleep(1000)
			Next i
            Throw New Exception(String.Format("  Exceeded maximum time of {0} seconds waiting for asynchronous job to complete",
                                              maxTimeSeconds))
		End Sub

		#End Region

		#Region "Public methods"

		''' <summary>
		''' Creates any entity records that this sample requires.
		''' </summary>
		Public Sub CreateRequiredRecords()
'			#Region "Creating Accounts"

			Dim accountName As String = "Contoso, Ltd"
			Dim websiteUrl As String = "https://www.contoso.com/"

            Console.WriteLine("  Creating duplicate records (Account name={0}, Website URL={1})",
                              accountName, websiteUrl)
			' Create some duplicate records
			For i As Integer = 0 To 1
                Dim account_Renamed As New Account() With
                    {
                        .Name = accountName,
                        .WebSiteURL = websiteUrl
                    }
				account_Renamed.Id = _serviceProxy.Create(account_Renamed)
				_duplicateAccounts(i) = account_Renamed
			Next i

			accountName = "Contoso Pharmaceuticals"
            Console.WriteLine("  Creating a non-duplicate record (Account name={0}, Website URL={1})",
                              accountName, websiteUrl)
			' Create a record that is NOT a duplicate
            Dim distinctAccount As New Account() With
                {
                    .Name = accountName,
                    .WebSiteURL = websiteUrl
                }
			distinctAccount.Id = _serviceProxy.Create(distinctAccount)
			_account = distinctAccount

'			#End Region

'			#Region "Create and Publish duplicate detection rule"

			Console.WriteLine("  Creating a duplicate detection rule")
			' Create a duplicate detection rule
            _rule = New DuplicateRule() With
                    {
                        .Name = "Accounts with the same Account name and website url",
                        .BaseEntityName = Account.EntityLogicalName,
                        .MatchingEntityName = Account.EntityLogicalName
                    }
			_rule.Id = _serviceProxy.Create(_rule)

			' Create a duplicate detection rule condition
            Dim nameCondition As New DuplicateRuleCondition() With
                {
                    .BaseAttributeName = "name",
                    .MatchingAttributeName = "name",
                    .OperatorCode = New OptionSetValue(0),
                    .RegardingObjectId = _rule.ToEntityReference()
                }
				' set the regarding id to point to the rule created earlier,
				' associating this condition with that rule
			_serviceProxy.Create(nameCondition)

            Dim websiteCondition As New DuplicateRuleCondition() With
                {
                    .BaseAttributeName = "websiteurl",
                    .MatchingAttributeName = "websiteurl",
                    .OperatorCode = New OptionSetValue(0),
                    .RegardingObjectId = _rule.ToEntityReference()
                }
			_serviceProxy.Create(websiteCondition)

			Console.WriteLine("  Publishing duplicate detection rule")
			' Publish the rule
            Dim publishRequest As New PublishDuplicateRuleRequest() With
                {
                    .DuplicateRuleId = _rule.Id
                }
            Dim publishResponse As PublishDuplicateRuleResponse =
                CType(_serviceProxy.Execute(publishRequest), 
                    PublishDuplicateRuleResponse)

			' The PublishDuplicateRule request returns before the publish is completed,
			' so we keep retrieving the async job state until it is "Completed"
			Console.WriteLine("  Checking to see if duplicate detection rule has finished publishing")
			WaitForAsyncJobToFinish(publishResponse.JobId, 60)

'			#End Region
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
                If answer.StartsWith("y") OrElse
                    answer.StartsWith("Y") OrElse
                    answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
			End If

			If toBeDeleted Then
				' Delete the job
				Console.WriteLine("  Deleting the job")
				_serviceProxy.Delete(AsyncOperation.EntityLogicalName, _response.JobId)

				' Delete the duplicate detection rule
				Console.WriteLine("  Deleting the duplicate detection rule")
				_serviceProxy.Delete(DuplicateRule.EntityLogicalName, _rule.Id)

				' Delete the accounts
				Console.WriteLine("  Deleting the accounts")
				For Each account_Renamed As Account In _duplicateAccounts
					_serviceProxy.Delete(Account.EntityLogicalName, account_Renamed.Id)
				Next account_Renamed
                _serviceProxy.Delete(Account.EntityLogicalName, _account.Id)
                Console.WriteLine("Entity records have been deleted.")
			End If
		End Sub
		#End Region ' Public Methods

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

				Dim app As New BulkDetectDuplicates()
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

' </snippetbulkdetectduplicates>