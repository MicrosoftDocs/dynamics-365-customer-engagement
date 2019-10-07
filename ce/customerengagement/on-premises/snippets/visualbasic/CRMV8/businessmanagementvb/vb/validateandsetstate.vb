' <snippetvalidateandsetstate>



Imports System
Imports System.ServiceModel
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
    '''  This sample shows how to validate an intended state change on an entity record.
    '''  This sample will also show how to set the state on the entity record. 
	''' </summary>
	''' <remarks>
	''' At run-time, you will be given the option to delete all the
	''' database records created by this program.
	''' </remarks>
	Public Class ValidateAndSetState
		#Region "Class Level Members"
		Private _serviceProxy As OrganizationServiceProxy
		Private _caseCustomerId As Guid
		Private _caseIncidentId As Guid
		#End Region

		#Region "How To Sample Code"
		''' <summary>
		''' This method first connects to the Organization service. Afterwards, a 
		''' case is created. The IsValidStateTransition is used to test if a state change
		''' is valid. The case is closed, re-opened and then closed with SetState.
		''' </summary>
		''' <param name="serverConfig">Contains server connection information.</param>
		''' <param name="promptforDelete">When True, the user will be prompted to delete all
		''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptForDelete As Boolean)
            _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
            Using _serviceProxy
                ' This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes()

                'Create the Contact and Incident required for this sample.
                CreateRequiredRecords()

                ' Create an EntityReference to represent an open case
                Dim caseReference As New EntityReference() With
                    {
                        .LogicalName = Incident.EntityLogicalName,
                        .Id = _caseIncidentId
                    }

                Dim checkState As New IsValidStateTransitionRequest()

                ' Set the transition request to an open case
                checkState.Entity = caseReference

                ' Check to see if a new state of "resolved" and 
                ' a new status of "problem solved" are valid
                checkState.NewState = IncidentState.Resolved.ToString()
                checkState.NewStatus = CInt(Fix(incident_statuscode.ProblemSolved))

                ' Execute the request
                Dim checkStateResponse As IsValidStateTransitionResponse =
                    CType(_serviceProxy.Execute(checkState), 
                        IsValidStateTransitionResponse)

                ' Handle the response
                If checkStateResponse.IsValid Then
                    Dim changeAnswer As String = "y" ' default to "y" unless prompting for delete
                    If promptForDelete Then
                        ' The case can be closed
                        Console.WriteLine("Validate State Request returned that the case " &amp; "can be closed.")
                        Console.Write(vbLf &amp; "Do you want to change the record state? " &amp; "(y/n) [y]: ")
                        changeAnswer = Console.ReadLine()
                        Console.WriteLine()
                    End If

                    If changeAnswer.StartsWith("y") OrElse
                        changeAnswer.StartsWith("Y") OrElse
                        changeAnswer = String.Empty Then
                        ' Call function to change the incident to the closed state
                        CloseIncident(caseReference)
                        ' Re-open the incident and change its state
                        SetState(caseReference)
                    End If
                Else
                    ' The case cannot be closed
                    Console.WriteLine("Validate State Request returned that the " _
                                      &amp; "change is not valid.")
                End If

                DeleteRequiredRecords(promptForDelete)
            End Using
        End Sub

		Private Sub CloseIncident(ByVal caseReference As EntityReference)
			' First close the Incident

			' Create resolution for the closing incident
            Dim resolution As IncidentResolution = New IncidentResolution With
                                                   {
                                                       .Subject = "Case Closed"
                                                   }

			resolution.IncidentId = caseReference

			' Create the request to close the incident, and set its resolution to the 
			' resolution created above
			Dim closeRequest As New CloseIncidentRequest()
			closeRequest.IncidentResolution = resolution

			' Set the requested new status for the closed Incident
            closeRequest.Status =
                New OptionSetValue(CInt(Fix(incident_statuscode.ProblemSolved)))

			' Execute the close request
            Dim closeResponse As CloseIncidentResponse =
                CType(_serviceProxy.Execute(closeRequest), CloseIncidentResponse)

			'Check if the incident was successfully closed
            Dim incident As Incident =
                _serviceProxy.Retrieve(incident.EntityLogicalName,
                                       _caseIncidentId,
                                       New ColumnSet(allColumns:=True)).ToEntity(Of Incident)()

            If incident.StateCode.HasValue AndAlso incident.StateCode =
                IncidentState.Resolved Then
                Console.WriteLine("The incident was closed out as Resolved.")
            Else
                Console.WriteLine("The incident's state was not changed.")
            End If
		End Sub

		Private Sub SetState(ByVal caseReference As EntityReference)
			' Create the Request Object
			Dim state As New SetStateRequest()

			' Set the Request Object's Properties
			state.State = New OptionSetValue(CInt(Fix(IncidentState.Active)))
			state.Status = New OptionSetValue(CInt(Fix(incident_statuscode.WaitingforDetails)))

			' Point the Request to the case whose state is being changed
			state.EntityMoniker = caseReference

			' Execute the Request
            Dim stateSet As SetStateResponse = CType(_serviceProxy.Execute(state), 
                SetStateResponse)

			' Check if the state was successfully set
            Dim incident As Incident =
                _serviceProxy.Retrieve(incident.EntityLogicalName,
                                       _caseIncidentId,
                                       New ColumnSet(allColumns:=True)).ToEntity(Of Incident)()

			If incident.StatusCode.Value = CInt(Fix(incident_statuscode.WaitingforDetails)) Then
				Console.WriteLine("Record state set successfully.")
			Else
				Console.WriteLine("The request to set the record state failed.")
			End If
		End Sub

		''' <summary>
		''' Creates any entity records that this sample requires.
		''' </summary>
		Public Sub CreateRequiredRecords()
			' Create a customer for a new incident
			Dim caseCustomer As New Contact()

			' Set the contact properties
			caseCustomer.FirstName = "Christen"
			caseCustomer.LastName = "Anderson"

			' Create the contact in CRM
			_caseCustomerId = _serviceProxy.Create(caseCustomer)
			NotifyEntityCreated(Contact.EntityLogicalName, _caseCustomerId)

			' Retrieve the default subject for a new incident\case
            Dim query = New QueryExpression() With
                        {
                            .EntityName = Subject.EntityLogicalName,
                            .ColumnSet = New ColumnSet(allColumns:=True),
                            .Criteria = New FilterExpression()}
            query.Criteria.AddCondition("title", ConditionOperator.Equal,
                                        "Default Subject")

			Dim subjectRecords = _serviceProxy.RetrieveMultiple(query)
			Dim defaultSubject As Entity = subjectRecords(0)
			NotifyEntityRetrieved(Subject.EntityLogicalName, defaultSubject.Id)

			' Create a new incident
			Dim newCase As New Incident()

			' Set the incident properties
			newCase.SubjectId = New EntityReference()
			newCase.SubjectId.LogicalName = Subject.EntityLogicalName
			newCase.SubjectId.Id = defaultSubject.Id
			newCase.CustomerId = New EntityReference()
			newCase.CustomerId.LogicalName = Contact.EntityLogicalName
			newCase.CustomerId.Id = _caseCustomerId
			newCase.Title = "New Case from SDK"

			_caseIncidentId = _serviceProxy.Create(newCase)
			NotifyEntityCreated(Incident.EntityLogicalName, _caseIncidentId)

		End Sub

		''' <summary>
		''' Deletes any entity records that were created for this sample.
		''' <param name="prompt">Indicates whether to prompt the user 
		''' to delete the records created in this sample.</param>
		''' </summary>
		Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
			Dim deleteRecords As Boolean = True

			If prompt Then
				Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
				Dim answer As String = Console.ReadLine()
				Console.WriteLine()

                deleteRecords = (answer.StartsWith("y") OrElse
                                 answer.StartsWith("Y") OrElse
                                 answer = String.Empty)
			End If

			If deleteRecords Then
				_serviceProxy.Delete(Incident.EntityLogicalName, _caseIncidentId)
				_serviceProxy.Delete(Contact.EntityLogicalName, _caseCustomerId)
				Console.WriteLine("Entity records have been deleted.")
			End If
		End Sub

		Private Sub NotifyEntityCreated(ByVal entityName As String, ByVal entityId As Guid)
			Console.WriteLine("  {0} created with GUID {{{1}}}", entityName, entityId)
		End Sub

		Private Sub NotifyEntityRetrieved(ByVal entityName As String, ByVal entityId As Guid)
			Console.WriteLine("  Retrieved {0} with GUID {{{1}}}", entityName, entityId)
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

				Dim app = New ValidateAndSetState()
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
			' Additional exceptions to catch: SecurityTokenValidationException, 
			' ExpiredSecurityTokenException, SecurityAccessDeniedException, 
			' MessageSecurityException, and SecurityNegotiationException.

			Finally
				Console.WriteLine("Press <Enter> to exit.")
				Console.ReadLine()
			End Try
		End Sub
		#End Region ' Main method
	End Class
End Namespace

' </snippetvalidateandsetstate>