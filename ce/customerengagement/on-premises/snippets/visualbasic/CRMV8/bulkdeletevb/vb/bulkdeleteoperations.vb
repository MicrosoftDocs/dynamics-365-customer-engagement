' <snippetbulkdeleteoperations>


Imports Microsoft.VisualBasic
Imports System
Imports System.ServiceModel
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' This sample shows how to perform a bulk delete request to remove the records in
    ''' Microsoft Dynamics CRM that match certain criteria.
	''' </summary>
	Public Class BulkDeleteOperations
		#Region "Class Level Members"
		Private _serviceProxy As OrganizationServiceProxy
		Private _bulkDeleteOperationId As Guid
		Private _asyncOperationId As Guid
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

                CreateRequiredRecords()

                ' Perform the bulk delete.  If you want to perform a recurring delete
                ' operation, leave this as it is.  Otherwise, pass in false as the
                ' first parameter.
                PerformBulkDelete(True, promptToDelete)
            End Using
        End Sub

		''' <summary>
        ''' Create an account that will be deleted in the main portion of the sample.
		''' </summary>
		Private Sub CreateRequiredRecords()
            Dim account = New Account With {.Name = "Fourth Coffee",
                                            .WebSiteURL = "https://www.fourthcoffee.com/"}
			_serviceProxy.Create(account)
		End Sub

		''' <summary>
		''' Perform the main action of the sample - issuing a BulkDeleteRequest.
		''' </summary>
		''' <param name="useRecurrence">
		''' whether or not to create a recurring BulkDeleteRequest.
		''' </param>
        Private Sub PerformBulkDelete(ByVal useRecurrence As Boolean,
                                      ByVal promptToDelete As Boolean)
            Try
                Console.WriteLine("Performing Bulk Delete Operation")

                ' Query for a system user to send an email to after the bulk delete
                ' operation completes.
                Dim userRequest = New WhoAmIRequest()
                Dim userResponse = CType(_serviceProxy.Execute(userRequest), 
                    WhoAmIResponse)
                Dim currentUserId As Guid = userResponse.UserId

                Console.WriteLine("  Requesting user retrieved.")

                ' Create a condition for a bulk delete request.
                ' NOTE: If no records are found matching this condition, the bulk delete
                ' will not fail.  It will succeed with 0 successes and 0 failures.
                Dim deleteCondition =
                    New ConditionExpression("name",
                                            ConditionOperator.Equal,
                                            "Fourth Coffee")

                ' Create a fiter expression for the bulk delete request.
                Dim deleteFilter = New FilterExpression()
                deleteFilter.Conditions.Add(deleteCondition)

                ' Create the bulk delete query set.
                Dim bulkDeleteQuery = New QueryExpression With
                                      {
                                          .EntityName = Account.EntityLogicalName,
                                          .Distinct = False,
                                          .Criteria = deleteFilter
                                      }

                ' Create the bulk delete request.
                Dim bulkDeleteRequest = New BulkDeleteRequest With
                                        {
                                            .JobName = "Sample Bulk Delete",
                                            .QuerySet = {bulkDeleteQuery},
                                            .StartDateTime = Date.Now,
                                            .ToRecipients = {currentUserId},
                                            .CCRecipients = New Guid() {},
                                            .SendEmailNotification = True,
                                            .RecurrencePattern = String.Empty
                                        }

                ' Create a recurring BulkDeleteOperation.
                If useRecurrence Then
                    bulkDeleteRequest.RecurrencePattern = "FREQ=DAILY;INTERVAL=1;"
                End If

                ' Submit the bulk delete job.
                ' NOTE: Because this is an asynchronous operation, the response will be
                ' immediate.
                Dim bulkDeleteResponse = CType(_serviceProxy.Execute(bulkDeleteRequest), 
                    BulkDeleteResponse)
                _asyncOperationId = bulkDeleteResponse.JobId

                Console.WriteLine("  The Bulk Delete Request was made and the Bulk" _
                                  &amp; vbLf &amp; "    Delete Operation should be created.")

                ' To monitor the asynchronous operation, we must retrieve the
                ' bulkdeleteoperation object.
                ' NOTE: There will be a period of time from when the async operation
                ' request was sumbitted to the time when a successful query for that
                ' async operation can be made.  When using plug-ins, events can be
                ' subscribed to that will fire when the async operation status changes.
                Dim bulkQuery = New QueryByAttribute()
                bulkQuery.ColumnSet = New ColumnSet(True)
                bulkQuery.EntityName = BulkDeleteOperation.EntityLogicalName

                ' NOTE: When the bulk delete operation was submitted, the GUID that was
                ' returned was the asyncoperationid, not the bulkdeleteoperationid.
                bulkQuery.Attributes.Add("asyncoperationid")
                bulkQuery.Values.Add(bulkDeleteResponse.JobId)

                ' With only the asyncoperationid at this point, a RetrieveMultiple is
                ' required to get the bulk delete operation created above.
                Dim entityCollection = _serviceProxy.RetrieveMultiple(bulkQuery)
                Dim createdBulkDeleteOperation As BulkDeleteOperation = Nothing

                ' When creating a recurring BulkDeleteOperation, the BulkDeleteOperation
                ' will be in suspended status after the current instance has completed.
                ' When creating a non-recurring BulkDeleteOperation, it will be in
                ' Completed status when it is finished.
                Dim bulkOperationEnded = If(useRecurrence,
                                            BulkDeleteOperationState.Suspended,
                                            BulkDeleteOperationState.Completed)

                createdBulkDeleteOperation = RetrieveBulkDeleteOperation(bulkQuery,
                                                                         entityCollection,
                                                                         bulkOperationEnded)
                _bulkDeleteOperationId = createdBulkDeleteOperation.Id

                If createdBulkDeleteOperation IsNot Nothing Then
                    ' If the BulkDeleteOperation is recurring, the status will be
                    ' "Waiting" after the operation completes this instance.  If it is
                    ' non-recurring, the status will be "Succeeded".
                    Dim bulkOperationSuccess = If(useRecurrence,
                                                  bulkdeleteoperation_statuscode.Waiting,
                                                  bulkdeleteoperation_statuscode.Succeeded)

                    InspectBulkDeleteOperation(createdBulkDeleteOperation,
                                               bulkOperationEnded,
                                               bulkOperationSuccess,
                                               useRecurrence)

                    DeleteRecords(promptToDelete)
                Else
                    Console.WriteLine("  The Bulk Delete Operation could not be retrieved.")
                End If
            Catch e1 As System.Web.Services.Protocols.SoapException
                ' Perform error handling here.
                Throw
            End Try
        End Sub

		''' <summary>
		''' Inspect and display information about the created BulkDeleteOperation.
		''' </summary>
		''' <param name="createdBulkDeleteOperation">
		''' the BulkDeleteOperation to inspect.
		''' </param>
		''' <param name="bulkOperationEnded">
		''' the statecode that will tell us if the BulkDeleteOperation is ended.
		''' </param>
		''' <param name="bulkOperationSuccess">
		''' the statuscode that will tell us if the BulkDeleteOperation was successful.
		''' </param>
		''' <param name="useRecurrence">
		''' whether or not the BulkDeleteOperation is a recurring operation.
		''' </param>
        Private Sub InspectBulkDeleteOperation(ByVal createdBulkDeleteOperation As BulkDeleteOperation,
                                               ByVal bulkOperationEnded As BulkDeleteOperationState,
                                               ByVal bulkOperationSuccess As bulkdeleteoperation_statuscode,
                                               ByVal useRecurrence As Boolean)
            ' Validate that the operation was completed.
            If createdBulkDeleteOperation.StateCode <> bulkOperationEnded Then
                ' This will happen if it took longer than the polling time allowed 
                ' for this operation to complete.
                Console.WriteLine("  Completion of the Bulk Delete took longer" _
                                  &amp; vbLf &amp; "    than the polling time allotted.")
            ElseIf createdBulkDeleteOperation.StatusCode.Value <> CInt(Fix(bulkOperationSuccess)) Then
                Console.WriteLine("  The Bulk Delete operation failed.")
            ElseIf Not useRecurrence Then
                ' Check for number of successful deletes.
                Dim successfulDeletes = If(createdBulkDeleteOperation.SuccessCount, 0)
                Console.WriteLine("  {0} records were successfully deleted",
                                  successfulDeletes)

                ' Check for any failures that may have occurred during the bulk
                ' delete operation.
                If createdBulkDeleteOperation.FailureCount > 0 Then
                    Console.WriteLine("  {0} records failed to be deleted:",
                                      createdBulkDeleteOperation.FailureCount)

                    ' Query for all the failures.
                    Dim failureQuery = New QueryByAttribute()
                    failureQuery.ColumnSet = New ColumnSet(True)
                    failureQuery.EntityName = BulkDeleteFailure.EntityLogicalName
                    failureQuery.Attributes.Add("bulkdeleteoperationid")
                    Dim bulkDeleteOperationId = If(createdBulkDeleteOperation.BulkDeleteOperationId,
                                                   Guid.Empty)
                    failureQuery.Values.Add(bulkDeleteOperationId)

                    ' Retrieve the bulkdeletefailure objects.
                    Dim entityCollection As EntityCollection = _serviceProxy.RetrieveMultiple(failureQuery)

                    ' Examine each failure for information regarding the failure.
                    For Each failureOperation As BulkDeleteFailure In entityCollection.Entities
                        ' Process failure information.
                        Console.WriteLine(String.Format("    {0}, {1}",
                                                        failureOperation.RegardingObjectId.Name,
                                                        failureOperation.RegardingObjectId.Id))
                    Next failureOperation
                End If
            Else
                ' NOTE: If recurrence is used, we cannot reliably retrieve data
                ' about the records that were deleted, since a sub-BulkDeleteOperation
                ' is created by Microsoft Dynamics CRM that does not have any fields tying it back to the
                ' Asynchronous operation or the BulkDeleteOperation. This makes it
                ' unreliable to know which subprocess to retrieve.
                Console.WriteLine("  The recurring Bulk Delete Operation was created successfully.")
            End If
        End Sub

		''' <summary>
		''' Retrieves the BulkDeleteOperation, but it's not necessarily created
		''' immediately, so this method uses polling.
		''' </summary>
		''' <param name="bulkQuery">the query to find the BulkDeleteOperation.</param>
		''' <param name="entityCollection">the initial results of the query.</param>
		''' <param name="operationEndedStatus">
		''' the statecode that will indicate that the operation has ended.
		''' </param>
        Private Function RetrieveBulkDeleteOperation(ByVal bulkQuery As QueryByAttribute,
                                                     ByVal entityCollection As EntityCollection,
                                                     ByVal operationEndedStatus As BulkDeleteOperationState) As BulkDeleteOperation
            Dim createdBulkDeleteOperation As BulkDeleteOperation = Nothing
            ' Monitor the async operation via polling until it is complete or max
            ' polling time expires.
            Const ARBITRARY_MAX_POLLING_TIME As Integer = 60
            Dim secondsTicker As Integer = ARBITRARY_MAX_POLLING_TIME
            Do While secondsTicker > 0
                ' Make sure the async operation was retrieved
                If entityCollection.Entities.Count > 0 Then
                    ' Grab the one bulk operation that has been created
                    createdBulkDeleteOperation = CType(entityCollection.Entities(0), 
                        BulkDeleteOperation)

                    ' Check the operation's state
                    ' NOTE: If a recurrence for the BulkDeleteOperation was
                    ' specified, then the state of the operation will be Suspended,
                    ' not Completed, since the operation will run again in the
                    ' future.
                    If createdBulkDeleteOperation.StateCode <> operationEndedStatus Then
                        ' The operation has not yet completed.  Wait a second for
                        ' the status to change.
                        System.Threading.Thread.Sleep(1000)
                        secondsTicker -= 1

                        ' Retrieve a fresh version of the bulk delete operation.
                        entityCollection = _serviceProxy.RetrieveMultiple(bulkQuery)
                    Else
                        ' Stop polling as the operation's state is now complete.
                        secondsTicker = 0
                        Console.WriteLine("  The BulkDeleteOperation record has been retrieved.")
                    End If
                Else
                    ' Wait a second for async operation to activate.
                    System.Threading.Thread.Sleep(1000)
                    secondsTicker -= 1

                    ' Retrieve the entity again.
                    entityCollection = _serviceProxy.RetrieveMultiple(bulkQuery)
                End If
            Loop
            Return createdBulkDeleteOperation
        End Function

		''' <summary>
		''' Deletes records that were created in the sample.
		''' </summary>
		''' <param name="prompt">whether or not to prompt the user for deletion.</param>
		Private Sub DeleteRecords(ByVal prompt As Boolean)
			Dim toBeDeleted = True
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
				' Delete the bulk delete operation so that it won't clutter the
				' database.
                _serviceProxy.Delete(BulkDeleteOperation.EntityLogicalName,
                                     _bulkDeleteOperationId)

                Dim asyncOperationEntity =
                    _serviceProxy.Retrieve(AsyncOperation.EntityLogicalName,
                                           _asyncOperationId,
                                           New ColumnSet("statecode", "asyncoperationid"))
                Dim asyncOperation_renamed =
                    asyncOperationEntity.ToEntity(Of AsyncOperation)()

                If asyncOperation_renamed.StateCode <> AsyncOperationState.Completed Then
                    ' We have to update the AsyncOperation to be in a Completed state
                    ' before we can delete it.
                    asyncOperation_renamed.StateCode = AsyncOperationState.Completed
                    _serviceProxy.Update(asyncOperation_renamed)
                End If

                _serviceProxy.Delete(AsyncOperation.EntityLogicalName, _asyncOperationId)

				Console.WriteLine("  The AsyncOperation and BulkDeleteOperation have been deleted.")
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
                ' Obtain the target organization's web address and client logon 
				' credentials from the user.
				Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

				Dim app = New BulkDeleteOperations()
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

' </snippetbulkdeleteoperations>