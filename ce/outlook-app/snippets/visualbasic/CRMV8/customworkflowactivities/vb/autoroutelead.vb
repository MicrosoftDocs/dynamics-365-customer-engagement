' <snippetautoroutelead>


Imports System.Activities

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Query

' These namespaces are found in the Microsoft.Xrm.Sdk.Workflow.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk.Workflow

' These namespaces are found in the Microsoft.Crm.Sdk.Proxy.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' Assigns the lead to the user with the fewest lead records assigned.
	''' Input arguments:
	'''   "Lead". Type: EntityReference. Is the lead entity.
	''' Output argument:
	'''   None.
	''' </summary>
	Public NotInheritable Partial Class AutoRouteLead
		Inherits CodeActivity
		''' <summary>
		''' This method first retrieves the lead. Afterwards, it checks the value of
		''' the new_autoroute field, and if it is True, it retrieves all the users 
		''' with 'Customer Service Representative' role, and assigns this lead to
		''' the user with the fewest lead records assigned.
		''' </summary>
		Protected Overrides Sub Execute(ByVal executionContext As CodeActivityContext)
			Dim context As IWorkflowContext = executionContext.GetExtension(Of IWorkflowContext)()
			Dim serviceFactory As IOrganizationServiceFactory = executionContext.GetExtension(Of IOrganizationServiceFactory)()
			Dim service As IOrganizationService = serviceFactory.CreateOrganizationService(context.UserId)

'			#Region "Retrieve the lead"

			' Get the lead ID
			Dim leadId As Guid = Me.lead_input.Get(executionContext).Id

			'Request for Entity
			Dim request As New RetrieveRequest()
			request.ColumnSet = New ColumnSet(True)
			request.Target = New EntityReference("lead", leadId)

			'Execute request
			Dim targetRequest As Entity = CType((CType(service.Execute(request), RetrieveResponse)).Entity, Entity)

'			#End Region ' Retrieve the lead

			Dim autoroute As Boolean = False
			autoroute = CBool(targetRequest.Attributes("new_autoroute"))

			If autoroute Then
				' Get user's BusinessUnit
				Dim userrequest As New RetrieveRequest()
				userrequest.ColumnSet = New ColumnSet("businessunitid")
				userrequest.Target = New EntityReference("systemuser", context.UserId)

				Dim userEntity As Entity = CType((CType(service.Execute(userrequest), RetrieveResponse)).Entity, Entity)
				Dim bu As EntityReference = CType(userEntity("businessunitid"), EntityReference)

				' Get roleid for 'Customer Service Representative' with that BU
				Dim queryRole As New QueryExpression()
				queryRole.ColumnSet = New ColumnSet("roleid")
                queryRole.EntityName = "role"
                queryRole.Criteria.AddCondition("name", ConditionOperator.Equal, {"Customer Service Representative"})
                queryRole.Criteria.AddCondition("name", ConditionOperator.Equal, {bu.Id})

				Dim roles = service.RetrieveMultiple(queryRole)

				If roles.Entities.Count > 0 Then
					Dim roleId As Guid = CType(roles.Entities(0)("roleid"), Guid)

					' Create the query to get all the users with that role
					Dim queryUsers As New QueryExpression()

					' Set the properties of the query.
					queryUsers.EntityName = "systemuserroles"
					queryUsers.ColumnSet = New ColumnSet("systemuserid")
					queryUsers.Criteria.AddCondition ("roleid", ConditionOperator.Equal, roleId)

					' Get the list of users.
					Dim users = service.RetrieveMultiple(queryUsers)

					If users.Entities.Count > 0 Then
'						#Region "Get User with lowest number of leads assigned"

						' Initialize variables
						Dim lowLeadCount As Integer = -1
						Dim currentLeadCount As Integer = 0
						Dim lowUserId As New Guid()

						' Create the query to find out how many leads 
						' each retrieved user has
						Dim queryUsersLeads As New QueryExpression()

						' Set the properties of the query.
						queryUsersLeads.EntityName = "lead"
						queryUsersLeads.ColumnSet = New ColumnSet("leadid", "ownerid")

						For Each user In users.Entities
							queryUsersLeads.Criteria.AddCondition ("ownerid", ConditionOperator.Equal, user("systemuserid"))
							Dim currentUserLeads As EntityCollection = service.RetrieveMultiple(queryUsersLeads)
							currentLeadCount = currentUserLeads.Entities.Count

							' If is the first time or the number of leads is lowest, 
							' the current User is marked lowest.
							If (lowLeadCount = -1) OrElse (currentLeadCount < lowLeadCount) Then
								lowLeadCount = currentLeadCount
								lowUserId = CType(user("systemuserid"), Guid)
							End If

						Next user
'						#End Region ' Get User with Lowest Number of leads assigned

'						#Region "Assign new lead to identified user"

						' Assign the lead to the user 
						' with the fewest lead records assigned
						Dim assignRequest As New AssignRequest() With {.Target = New EntityReference("lead", leadId), .Assignee = New EntityReference("systemuser", lowUserId)}
						service.Execute(assignRequest)

'						#End Region ' Assign new lead to identified user
					End If
				End If
			End If
		End Sub

		<RequiredArgument, Input("Lead"), ReferenceTarget("lead")> _
		Public Property lead_input() As InArgument(Of EntityReference)
	End Class
End Namespace

' </snippetautoroutelead>