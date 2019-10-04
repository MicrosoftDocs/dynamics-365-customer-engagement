' <snippetenableduplicatedetectionandretrieveduplicates>


Imports System
Imports System.Collections.Generic
Imports System.ServiceModel
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' This sample shows how to enable duplicate detection and retrieve duplicate
	''' records based on the active duplicate detection rule(s).
	''' </summary>
	''' <remarks>
	''' At run-time, you will be given the option to delete all the
	''' database records created by this program.
	''' </remarks>
	Public Class EnableDuplicateDetectionAndRetrieveDuplicates
		#Region "Class Level Members"
		Private _serviceProxy As OrganizationServiceProxy
		Private _accountId1? As Guid
		Private _accountId2? As Guid
		#End Region

		#Region "How To Sample Code"

		''' <summary>
		''' Enables dupe detection and retrieves duplicates. 
		''' </summary>
		''' <param name="serverConfig">Contains server connection information.</param>
		''' <param name="promptforDelete">When True, the user will be prompted to delete all
		''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
            Using _serviceProxy
                ' This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes()
                EnableDuplicateDetectionForOrg()
                EnableDuplicateDetectionForEntity(Account.EntityLogicalName)
                PublishRulesForEntity(Account.EntityLogicalName)
                CreateAccountRecords()
                RetrieveDuplicates()
                DeleteRequiredRecords(promptforDelete)
            End Using
        End Sub

		''' <summary>
		''' Create some account records to retrieve duplicates
		''' </summary>
		Private Sub CreateAccountRecords()
			Dim crmAccount = New Account With {.Name="Microsoft"}

			_accountId1 = _serviceProxy.Create(crmAccount)
			_accountId2 = _serviceProxy.Create(crmAccount)
            Console.WriteLine(String.Concat("Creating duplicate records:" _
                                            &amp; vbLf &amp; vbTab &amp; "account 1 - ",
                                            _accountId1.Value,
                                            vbLf &amp; vbTab &amp; "account 2 - ",
                                            _accountId2.Value))
		End Sub

		''' <summary>
		''' Call the method to retrieve duplicate records.  
		''' </summary>
		Private Sub RetrieveDuplicates()
			' PagingInfo is Required. 
            Dim request = New RetrieveDuplicatesRequest With
                          {
                              .BusinessEntity = New Account() With
                                                {
                                                    .Name = "Microsoft"
                                                }.ToEntity(Of Entity)(),
                              .MatchingEntityName = Account.EntityLogicalName,
                              .PagingInfo = New PagingInfo() With
                                            {
                                                .PageNumber = 1,
                                                .Count = 50
                                            }
                          }

			Console.WriteLine("Retrieving duplicates")
            Dim response = CType(_serviceProxy.Execute(request), 
                RetrieveDuplicatesResponse)

			For i As Integer = 0 To response.DuplicateCollection.Entities.Count - 1
                Dim crmAccount =
                    response.DuplicateCollection.Entities(i).ToEntity(Of Account)()
                Console.WriteLine(crmAccount.Name &amp; ", " _
                                  &amp; crmAccount.AccountId.Value.ToString())
			Next i
		End Sub

		''' <summary>
		''' Enables duplicate detection for the organization
		''' </summary>
		Private Sub EnableDuplicateDetectionForOrg()
			' Retrieve the org ID
			Dim orgId = RetrieveOrganizationId()
			If Not orgId.HasValue Then
				Return
			End If

            Console.WriteLine(
                String.Concat("Enabling duplicate detection for organization: ",
                              orgId.Value))

			' Enable dupe detection for each type
            Dim crmOrganization = New Organization With
                                  {
                                      .Id = orgId.Value,
                                      .IsDuplicateDetectionEnabled = True,
                                      .IsDuplicateDetectionEnabledForImport = True,
                                      .IsDuplicateDetectionEnabledForOfflineSync = True,
                                      .IsDuplicateDetectionEnabledForOnlineCreateUpdate = True
                                  }

			_serviceProxy.Update(crmOrganization)
		End Sub

		''' <summary>
		''' Enabling the dupe detection unpublishes the rules.  
		''' This will publish them, and wait for them to complete publishing.
		''' </summary>
		''' <param name="entityName"></param>
		Private Sub PublishRulesForEntity(ByVal entityName As String)
            ' Retrieve all rules for the entity
            Dim myQueryByAttribute As QueryByAttribute =
                New QueryByAttribute With
                {
                    .EntityName = DuplicateRule.EntityLogicalName,
                    .ColumnSet = New ColumnSet("duplicateruleid")
                }
            myQueryByAttribute.Attributes.Add("matchingentityname")
            myQueryByAttribute.Values.Add(entityName)
            Dim rules = _serviceProxy.RetrieveMultiple(myQueryByAttribute)
			Dim crmAsyncOperationIds As New List(Of Guid)()
			For Each item In rules.Entities
				Console.WriteLine(String.Concat("Publishing duplicate rule: ", item.Id))

				' Publish each rule and get the job id since it is async
                Dim response = CType(
                    _serviceProxy.Execute(New PublishDuplicateRuleRequest With
                                          {
                                              .DuplicateRuleId = item.Id
                                          }), 
                                  PublishDuplicateRuleResponse)

				crmAsyncOperationIds.Add(response.JobId)
			Next item

			' Wait until all the rules are published before testing the dupe detection
			WaitForAsyncJobCompletion(crmAsyncOperationIds)
		End Sub

		''' <summary>
		''' Updates the entity customizations and publishes the entity 
		''' </summary>
		''' <param name="entityName"></param>
		Private Sub EnableDuplicateDetectionForEntity(ByVal entityName As String)
			Console.WriteLine(String.Format("Retrieving entity metadata for {0}", entityName))

			' Retrieve the entity metadata
            Dim crmEntity = (CType(
                             _serviceProxy.Execute(
                                 New RetrieveEntityRequest With
                                 {
                                     .RetrieveAsIfPublished = True,
                                     .LogicalName = entityName
                                 }), 
                         RetrieveEntityResponse)).EntityMetadata

			Console.WriteLine(String.Concat("Enabling duplicate for ", entityName))

			' Update the duplicate detection flag
			crmEntity.IsDuplicateDetectionEnabled = New BooleanManagedProperty(True)

			' Update the entity metadata
			_serviceProxy.Execute(New UpdateEntityRequest With {.Entity = crmEntity})

			Console.WriteLine(String.Concat("Publishing ", entityName, " entity"))

			' Publish the entity 
            Dim publishRequest = New PublishXmlRequest With
                                 {
                                     .ParameterXml = String.Concat("<importexportxml><entities><entity>",
                                                                   entityName,
                                                                   "</entity></entities></importexportxml>")
                                 }

			_serviceProxy.Execute(publishRequest)
		End Sub

		''' <summary>
		''' There should only be one organization record per Crm Org
		''' </summary>
		''' <returns></returns>
		Private Function RetrieveOrganizationId() As Guid?
			' Retrieve the first record in the organization table.  
			' There should only be one organization record. 
            Dim entities = _serviceProxy.RetrieveMultiple(
                New QueryExpression(Organization.EntityLogicalName) With
                {
                    .ColumnSet = New ColumnSet("organizationid"),
                    .PageInfo = New PagingInfo With
                                {
                                    .PageNumber = 1,
                                    .Count = 1
                                }
                })

			If entities IsNot Nothing AndAlso entities.Entities.Count > 0 Then
				Return entities.Entities(0).Id
			End If

			Return Nothing
		End Function

		''' <summary>
		''' 
		''' </summary>
		''' <param name="prompt"></param>
		Private Sub DeleteRequiredRecords(ByVal prompt As Boolean)
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
				' Delete records created in this sample.
				If _accountId1.HasValue Then
                    Console.WriteLine(String.Concat("Deleting account: ",
                                                    _accountId1.Value))
                    _serviceProxy.Delete(Account.EntityLogicalName,
                                         _accountId1.Value)
				End If
				If _accountId2.HasValue Then
                    Console.WriteLine(String.Concat("Deleting account: ",
                                                    _accountId2.Value))
                    _serviceProxy.Delete(Account.EntityLogicalName,
                                         _accountId2.Value)
				End If
				Console.WriteLine("Entity records have been deleted.")
			End If
		End Sub

		''' <summary>
		''' Waits for async job to complete
		''' </summary>
		''' <param name="asyncJobId"></param>
		Public Sub WaitForAsyncJobCompletion(ByVal asyncJobIds As IEnumerable(Of Guid))
			Dim asyncJobList As New List(Of Guid)(asyncJobIds)
			Dim cs As New ColumnSet("statecode", "asyncoperationid")
			Dim retryCount As Integer = 100

			Do While asyncJobList.Count <> 0 AndAlso retryCount > 0
                ' Retrieve the async operations based on the ids
                Dim myQueryExpression As QueryExpression = New QueryExpression With
                                                           {
                                                               .ColumnSet = cs,
                                                               .EntityName = AsyncOperation.EntityLogicalName
                                                           }
                myQueryExpression.Criteria.AddCondition(
                    New ConditionExpression("asyncoperationid",
                                            ConditionOperator.In,
                                            asyncJobList.ToArray()))

                Dim crmAsyncJobs = _serviceProxy.RetrieveMultiple(myQueryExpression)

				' Check to see if the operations are completed and if so remove them from the Async Guid list
				For Each item In crmAsyncJobs.Entities
					Dim crmAsyncJob = item.ToEntity(Of AsyncOperation)()
                    If crmAsyncJob.StateCode.HasValue AndAlso
                        crmAsyncJob.StateCode.Value = AsyncOperationState.Completed Then
                        asyncJobList.Remove(crmAsyncJob.AsyncOperationId.Value)
                    End If

                    Console.WriteLine(String.Concat("Async operation state is ",
                                                    crmAsyncJob.StateCode.Value.ToString(),
                                                    ", async operation id: ",
                                                    crmAsyncJob.AsyncOperationId.Value.ToString()))
				Next item

				' If there are still jobs remaining, sleep the thread.
				If asyncJobList.Count > 0 Then
					System.Threading.Thread.Sleep(2000)
				End If

				retryCount -= 1
			Loop

			If retryCount = 0 AndAlso asyncJobList.Count > 0 Then
				For i As Integer = 0 To asyncJobList.Count - 1
                    Console.WriteLine(
                        String.Concat("The following async operation has not completed: ",
                                      asyncJobList(i).ToString()))
				Next i
			End If
		End Sub

		#End Region

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

				Dim app = New EnableDuplicateDetectionAndRetrieveDuplicates()
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
		#End Region
	End Class
End Namespace

' </snippetenableduplicatedetectionandretrieveduplicates>