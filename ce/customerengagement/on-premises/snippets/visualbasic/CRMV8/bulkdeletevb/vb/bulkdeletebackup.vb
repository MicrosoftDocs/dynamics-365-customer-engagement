' <snippetbulkdeletebackup>


Imports Microsoft.VisualBasic
Imports System
Imports System.ServiceModel
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' This sample shows how to perform a bulk delete asynchronous 
	''' operation on the records that have been manually exported 
	''' from Microsoft Dynamics CRM by using Export to Excel in a grid's view.
	''' </summary>
	Public Class BulkDeleteBackup
		#Region "Class Level Members"
		Private _serviceProxy As OrganizationServiceProxy
		Private _bulkDeleteResponse As BulkDeleteResponse
		Private _asyncOperationId? As Guid
		Private _bulkDeleteOperationId? As Guid
		#End Region

		#Region "How To Sample Code"

		''' <summary>
		''' Run the sample.
		''' </summary>
		''' <param name="serverConfig">configuration for the server.</param>
		''' <param name="promptToDelete">
		''' whether or not to prompt the user to delete created records.
		''' </param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptToDelete As Boolean)
            _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
            Using _serviceProxy
                ' This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes()

                PerformBulkDeleteBackup()
                DeleteRequiredRecords(promptToDelete)
            End Using
        End Sub

		''' <summary>
		''' Performs the main operation of the sample - performs a bulk delete on inactive
		''' opportunities and activities to remove them from the system.
		''' </summary>
		Private Sub PerformBulkDeleteBackup()
			Try
				' Query for a system user to send an email to after the bulk delete
				' operation completes.
				Dim userRequest = New WhoAmIRequest()
                Dim userResponse = CType(_serviceProxy.Execute(userRequest), 
                    WhoAmIResponse)
				Dim currentUserId As Guid = userResponse.UserId

                ' Create a condition for a bulk delete request.
				' NOTE: This sample uses very specific queries for deleting records
				' that have been manually exported in order to free space.
				Dim opportunitiesQuery As QueryExpression = BuildOpportunityQuery()

				' Create the bulk delete request.
				Dim bulkDeleteRequest As New BulkDeleteRequest()

				' Set the request properties.
				bulkDeleteRequest.JobName = "Backup Bulk Delete"

				' Querying activities
                bulkDeleteRequest.QuerySet = New QueryExpression() {
                    opportunitiesQuery,
                    BuildActivityQuery(Task.EntityLogicalName),
                    BuildActivityQuery(Fax.EntityLogicalName),
                    BuildActivityQuery(PhoneCall.EntityLogicalName),
                    BuildActivityQuery(Email.EntityLogicalName),
                    BuildActivityQuery(Letter.EntityLogicalName),
                    BuildActivityQuery(Appointment.EntityLogicalName),
                    BuildActivityQuery(ServiceAppointment.EntityLogicalName),
                    BuildActivityQuery(CampaignResponse.EntityLogicalName),
                    BuildActivityQuery(RecurringAppointmentMaster.EntityLogicalName)
                }

				' Set the start time for the bulk delete.
				bulkDeleteRequest.StartDateTime = Date.Now

				' Set the required recurrence pattern.
				bulkDeleteRequest.RecurrencePattern = String.Empty

				' Set email activity properties.
				bulkDeleteRequest.SendEmailNotification = False
				bulkDeleteRequest.ToRecipients = New Guid() { currentUserId }
				bulkDeleteRequest.CCRecipients = New Guid() { }

				' Submit the bulk delete job.
				' NOTE: Because this is an asynchronous operation, the response will be immediate.
                _bulkDeleteResponse = CType(_serviceProxy.Execute(bulkDeleteRequest), 
                    BulkDeleteResponse)
				Console.WriteLine("The bulk delete operation has been requested.")

				CheckSuccess()
			Catch e1 As System.Web.Services.Protocols.SoapException
				' Perform error handling here.
				Throw
			Catch e2 As Exception
				Throw
			End Try
		End Sub

		''' <summary>
		''' This method will query for the BulkDeleteOperation until it has been
		''' completed or until the designated time runs out.  It then checks to see if
		''' the operation was successful.
		''' </summary>
		Private Sub CheckSuccess()
			' Query for bulk delete operation and check for status.
			Dim bulkQuery As New QueryByAttribute(BulkDeleteOperation.EntityLogicalName)
			bulkQuery.ColumnSet = New ColumnSet(True)

			' NOTE: When the bulk delete operation was submitted, the GUID that was
			' returned was the asyncoperationid, not the bulkdeleteoperationid.
			bulkQuery.Attributes.Add("asyncoperationid")
			_asyncOperationId = _bulkDeleteResponse.JobId
			bulkQuery.Values.Add(_asyncOperationId)

			' With only the asyncoperationid at this point, a RetrieveMultiple is
			' required to get the
			' bulk delete operation created above.
            Dim entityCollection As EntityCollection =
                _serviceProxy.RetrieveMultiple(bulkQuery)
			Dim createdBulkDeleteOperation As BulkDeleteOperation = Nothing

			' Monitor the async operation via polling until it is complete or max
			' polling time expires.
			Const ARBITRARY_MAX_POLLING_TIME As Integer = 60
			Dim secondsTicker As Integer = ARBITRARY_MAX_POLLING_TIME
			Do While secondsTicker > 0
				' Make sure the async operation was retrieved.
				If entityCollection.Entities.Count > 0 Then
					' Grab the one bulk operation that has been created.
                    createdBulkDeleteOperation = CType(entityCollection.Entities(0), 
                        BulkDeleteOperation)

					' Check the operation's state.
                    If createdBulkDeleteOperation.StateCode.Value <>
                        BulkDeleteOperationState.Completed Then
                        ' The operation has not yet completed.  Wait a second for the
                        ' status to change.
                        System.Threading.Thread.Sleep(1000)
                        secondsTicker -= 1

                        ' Retrieve a fresh version of the bulk delete operation.
                        entityCollection = _serviceProxy.RetrieveMultiple(bulkQuery)
                    Else
                        ' Stop polling as the operation's state is now complete.
                        secondsTicker = 0
                    End If
				Else
					' Wait a second for async operation to activate.
					System.Threading.Thread.Sleep(1000)
					secondsTicker -= 1

					' Retrieve the entity again.
					entityCollection = _serviceProxy.RetrieveMultiple(bulkQuery)
				End If
			Loop

			' Validate that the operation was completed.
			If createdBulkDeleteOperation IsNot Nothing Then
				_bulkDeleteOperationId = createdBulkDeleteOperation.BulkDeleteOperationId
                If createdBulkDeleteOperation.StateCode.Value <>
                    BulkDeleteOperationState.Completed Then
                    Console.WriteLine("Polling for the BulkDeleteOperation took longer than allowed ({0} seconds).",
                                      ARBITRARY_MAX_POLLING_TIME)
                Else
                    Console.WriteLine("The BulkDeleteOperation succeeded." _
                                      &amp; vbCrLf &amp; "  Successes: {0}, Failures: {1}",
                                      createdBulkDeleteOperation.SuccessCount,
                                      createdBulkDeleteOperation.FailureCount)
                End If
			Else
				Console.WriteLine("The BulkDeleteOperation could not be retrieved.")
			End If
		End Sub

		''' <summary>
		''' Builds a query that matches all opportunities that are not in the open state.
		''' </summary>
		Private Shared Function BuildOpportunityQuery() As QueryExpression
			' Create a query that will match all opportunities that do not have a state
			' of open.
            Dim closedCondition = New ConditionExpression("statecode",
                                                          ConditionOperator.NotEqual,
                                                          CInt(Fix(OpportunityState.Open)))

			' Create a filter expression for a bulk delete request.
			Dim closedFilter = New FilterExpression()
			closedFilter.Conditions.Add(closedCondition)

			Dim queryExpression = New QueryExpression()

			queryExpression.EntityName = Opportunity.EntityLogicalName
			queryExpression.Criteria = closedFilter

			' Return all records
			queryExpression.Distinct = False

			Return queryExpression
		End Function

		''' <summary>
		''' Builds a query which will match all activities that are in the canceled or
		''' completed state.
		''' </summary>
		Private Shared Function BuildActivityQuery(ByVal entityName As String) As QueryExpression
            Dim canceledCondition =
                New ConditionExpression("statecode",
                                        ConditionOperator.Equal,
                                        CInt(Fix(ActivityPointerState.Canceled)))
            Dim completedCondition =
                New ConditionExpression("statecode",
                                        ConditionOperator.Equal,
                                        CInt(Fix(ActivityPointerState.Completed)))

			Dim closedFilter = New FilterExpression(LogicalOperator.Or)
			closedFilter.Conditions.AddRange(canceledCondition, completedCondition)

			Dim queryExpression = New QueryExpression()

			queryExpression.EntityName = entityName
			queryExpression.Criteria = closedFilter

			queryExpression.Distinct = False

			Return queryExpression
		End Function

		''' <summary>
		''' This method deletes the AsyncOperation and BulkDeleteOperation that were
		''' created in the database, if the user confirms that deleting these is
		''' desired.
		''' </summary>
		Private Sub DeleteRequiredRecords(ByVal promptToDelete As Boolean)
			Dim toBeDeleted = True
			If promptToDelete Then
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
				' Delete the bulk delete operation so that it won't clutter the
				' database.
				If _bulkDeleteOperationId.HasValue Then
                    _serviceProxy.Delete(BulkDeleteOperation.EntityLogicalName,
                                         _bulkDeleteOperationId.Value)
				End If

				If _asyncOperationId.HasValue Then
                    _serviceProxy.Delete(AsyncOperation.EntityLogicalName,
                                         _asyncOperationId.Value)
				End If

				Console.WriteLine("The AsyncOperation and BulkDeleteOperation have been deleted.")
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

				Dim app = New BulkDeleteBackup()
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

' </snippetbulkdeletebackup>