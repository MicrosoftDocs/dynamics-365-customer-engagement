' <snippetuseraccessauditing>


Imports Microsoft.VisualBasic
Imports System
Imports System.ServiceModel
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Metadata
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
	Public Class UserAccessAuditing
		#Region "Class Level Members"
		Private _serviceProxy As OrganizationServiceProxy

		Private _newAccountId As Guid
		Private _systemUserId As Guid
		Private Shared _sampleStartTime As Date

		#End Region

		#Region "How To Sample Code"

		''' <summary>
		''' This sample demonstrates how to audit user access to Microsoft Dynamics CRM.
		''' The sample first enables user access auditing on an organization. Next, it
		''' creates and modifies an entity. Finally, the sample displays a report of the
		''' audited information.
		''' </summary>
		''' <param name="serverConfig">Contains server connection information.</param>
		''' <param name="promptforDelete">When True, the user will be prompted to delete all
		''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            _sampleStartTime = Date.Now
            _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
            Using _serviceProxy
                ' This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes()

                '				#Region "Enable Auditing"

                ' Enable auditing on the organization and for user access by editing the
                ' organization's settings.
                ' First, get the organization's ID from the system user record.
                Dim whoAmIReq = New WhoAmIRequest()
                Dim whoAmIRes = CType(_serviceProxy.Execute(whoAmIReq), WhoAmIResponse)
                Dim orgId As Guid = whoAmIRes.OrganizationId
                _systemUserId = whoAmIRes.UserId

                ' Next, retrieve the organization's record.
                Dim org = _serviceProxy.Retrieve(
                    Organization.EntityLogicalName,
                    orgId,
                    New ColumnSet("organizationid",
                                  "isauditenabled",
                                  "isuseraccessauditenabled",
                                  "useraccessauditinginterval")).ToEntity(Of Organization)()

                ' Finally, enable auditing on the organization, including auditing for
                ' user access.
                Dim organizationAuditingFlag As Boolean = org.IsAuditEnabled.Value
                Dim userAccessAuditingFlag As Boolean = org.IsUserAccessAuditEnabled.Value
                If (Not organizationAuditingFlag) OrElse (Not userAccessAuditingFlag) Then
                    org.IsAuditEnabled = True
                    org.IsUserAccessAuditEnabled = True
                    _serviceProxy.Update(org)
                    Console.WriteLine("Enabled auditing for the organization and for user access.")
                    Console.WriteLine("Auditing interval is set to {0} hours.", org.UserAccessAuditingInterval)
                Else
                    Console.WriteLine("Auditing was enabled before the sample began, so no auditing settings were changed.")
                End If

                ' Enable auditing on the account entity, since no audits will be created
                ' when we create/update an account entity, otherwise.
                Dim oldAccountAuditing = EnableEntityAuditing(Account.EntityLogicalName, True)

                '				#End Region ' Enable Auditing

                '				#Region "Make Audited Service Calls"

                CreateRequiredRecords()

                ' Make an update request to the Account entity to be tracked by auditing.
                Dim newAccount = New Account()
                newAccount.AccountId = _newAccountId
                newAccount.AccountNumber = "1-A"
                newAccount.AccountCategoryCode =
                    New OptionSetValue(CInt(Fix(AccountAccountCategoryCode.PreferredCustomer)))
                newAccount.Telephone1 = "555-555-5555"

                _serviceProxy.Update(newAccount)

                Console.WriteLine("Created an account and made updates which should be captured by auditing.")

                '				#End Region ' Make Audited Service Calls

                '				#Region "Revert auditing"

                ' Set the organization and account auditing flags back to the old values
                If (Not organizationAuditingFlag) OrElse (Not userAccessAuditingFlag) Then
                    ' Only revert them if they were actually changed to begin with.
                    org.IsAuditEnabled = organizationAuditingFlag
                    org.IsUserAccessAuditEnabled = userAccessAuditingFlag
                    _serviceProxy.Update(org)
                    Console.WriteLine("Reverted organization and user access auditing to their previous values.")
                Else
                    Console.WriteLine("Auditing was enabled before the sample began, so no auditing settings were reverted.")
                End If

                ' Revert the account entity auditing.
                EnableEntityAuditing(Account.EntityLogicalName, oldAccountAuditing)

                '				#End Region ' Revert auditing

                '				#Region "Show Audited Records"

                ' Select all columns for convenience.
                Dim query = New QueryExpression(Audit.EntityLogicalName) With
                            {
                                .ColumnSet = New ColumnSet(True),
                                .Criteria = New FilterExpression(LogicalOperator.And)
                            }

                ' Only retrieve audit records that track user access.
                query.Criteria.AddCondition("action",
                                            ConditionOperator.In,
                                            CInt(Fix(AuditAction.UserAccessAuditStarted)),
                                            CInt(Fix(AuditAction.UserAccessAuditStopped)),
                                            CInt(Fix(AuditAction.UserAccessviaWebServices)),
                                            CInt(Fix(AuditAction.UserAccessviaWeb)))

                ' Change this to false in order to retrieve audit records for all users
                ' when running the sample.
                Dim filterAuditsRetrievedByUser = True
                If filterAuditsRetrievedByUser Then
                    ' Only retrieve audit records for the current user or the "SYSTEM"
                    ' user.
                    Dim userFilter = New FilterExpression(LogicalOperator.Or)
                    userFilter.AddCondition("userid",
                                            ConditionOperator.Equal,
                                            _systemUserId)
                    userFilter.AddCondition("useridname",
                                            ConditionOperator.Equal,
                                            "SYSTEM")
                End If
                ' Only retrieve records for this sample run, so that we don't get too
                ' many results if auditing was enabled previously.
                query.Criteria.AddCondition("createdon",
                                            ConditionOperator.GreaterEqual,
                                            _sampleStartTime)

                Dim results = _serviceProxy.RetrieveMultiple(query)
                Console.WriteLine("Retrieved audit records:")
                For Each audit As Audit In results.Entities
                    Console.Write(vbCrLf &amp; "  Action: {0},  User: {1}," _
                                  &amp; vbCrLf &amp; "    Created On: {2}, Operation: {3}",
                                  CType(audit.Action.Value, AuditAction),
                                  audit.UserId.Name,
                                  audit.CreatedOn.Value.ToLocalTime(),
                                  CType(audit.Operation.Value, AuditOperation))

                    ' Display the name of the related object (which will be the user
                    ' for audit records with Action UserAccessviaWebServices.
                    If Not String.IsNullOrEmpty(audit.ObjectId.Name) Then
                        Console.WriteLine("," &amp; vbCrLf &amp; "    Related Record: {0}",
                                          audit.ObjectId.Name)
                    Else
                        Console.WriteLine()
                    End If
                Next audit

                '				#End Region ' Show Audited Records

                DeleteRequiredRecords(promptforDelete)
            End Using
        End Sub

		''' <summary>
		''' Creates any entity records that this sample requires.
		''' </summary>
		Public Sub CreateRequiredRecords()
			' Create a new account entity. 
			Dim newAccount As Account = New Account With {.Name = "Example Account"}
			_newAccountId = _serviceProxy.Create(newAccount)
		End Sub

        Private Function EnableEntityAuditing(ByVal entityLogicalName As String,
                                              ByVal flag As Boolean) As Boolean
            ' Retrieve the entity metadata.
            Dim entityRequest As RetrieveEntityRequest =
                New RetrieveEntityRequest With
                {
                    .LogicalName = entityLogicalName,
                    .EntityFilters = EntityFilters.Attributes
                }

            Dim entityResponse As RetrieveEntityResponse = CType(_serviceProxy.Execute(entityRequest), 
                RetrieveEntityResponse)

            ' Enable auditing on the entity. By default, this also enables auditing
            ' on all the entity's attributes.
            Dim entityMetadata As EntityMetadata = entityResponse.EntityMetadata

            Dim oldValue As Boolean = entityMetadata.IsAuditEnabled.Value
            entityMetadata.IsAuditEnabled = New BooleanManagedProperty(flag)

            Dim updateEntityRequest As UpdateEntityRequest = New UpdateEntityRequest With
                                                             {
                                                                 .Entity = entityMetadata
                                                             }

            Dim updateEntityResponse As UpdateEntityResponse =
                CType(_serviceProxy.Execute(updateEntityRequest), UpdateEntityResponse)

            Return oldValue
        End Function

		''' <summary>
		''' Deletes any entity records that were created for this sample.
		''' <param name="prompt">Indicates whether to prompt the user 
		''' to delete the records created in this sample.</param>
		''' </summary>
		Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
			Dim deleteRecords As Boolean = True

			If prompt Then
				Console.WriteLine(vbLf &amp; "Do you want to delete the account record? (y/n) [y]: ")
				Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse
                                 answer.StartsWith("Y") OrElse
                                 answer = String.Empty)
			End If

			If deleteRecords Then
				_serviceProxy.Delete(Account.EntityLogicalName, _newAccountId)
				Console.WriteLine("The account record has been deleted.")
			End If

			If prompt Then
				Console.WriteLine(vbLf &amp; "Do you want to delete ALL audit records? (y/n) [n]: ")
				Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse
                                 answer.StartsWith("Y"))
			End If

			If deleteRecords Then
				' Get the list of audit partitions.
                Dim partitionRequest As RetrieveAuditPartitionListResponse =
                    CType(_serviceProxy.Execute(New RetrieveAuditPartitionListRequest()), 
                        RetrieveAuditPartitionListResponse)
                Dim partitions As AuditPartitionDetailCollection =
                    partitionRequest.AuditPartitionDetailCollection

				' Create a delete request with an end date earlier than possible.
				Dim deleteRequest As New DeleteAuditDataRequest()
				deleteRequest.EndDate = New Date(2000, 1, 1)

				' Check if partitions are not supported as is the case with SQL Server Standard edition.
				If partitions.IsLogicalCollection Then
					' Delete all audit records created up until now.
					deleteRequest.EndDate = Date.Now

				' Otherwise, delete all partitions that are older than the current partition.
				' Hint: The partitions in the collection are returned in sorted order where the 
				' partition with the oldest end date is at index 0.  Also, if the partition's
				' end date is greater than the current date, neither the partition nor any
				' audit records contained in the partition can be deleted.
				Else
					For n As Integer = partitions.Count - 1 To 0 Step -1
                        If partitions(n).EndDate <= Date.Now AndAlso
                            partitions(n).EndDate > deleteRequest.EndDate Then
                            deleteRequest.EndDate = CDate(partitions(n).EndDate)
                            Exit For
                        End If
					Next n
				End If

				' Delete the audit records.
				If deleteRequest.EndDate <> New Date(2000, 1, 1) Then
					_serviceProxy.Execute(deleteRequest)
					Console.WriteLine("Audit records have been deleted.")
				Else
					Console.WriteLine("There were no audit records that could be deleted.")
				End If
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
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

				Dim app = New UserAccessAuditing()
				app.Run(config, True)

			Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
				Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
				Console.WriteLine("Message: {0}", ex.Detail.Message)
				Console.WriteLine("Trace: {0}", ex.Detail.TraceText)
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
						Console.WriteLine("Trace: {0}", fe.Detail.TraceText)
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

' </snippetuseraccessauditing>