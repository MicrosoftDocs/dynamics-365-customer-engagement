' <snippetreassignbusinessunitmembers>


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
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
	''' Demonstrates how to use the ReassignObjectsOwnerRequest and
	''' ReassignObjectsSystemUserRequest objects, as well as how to reassign
	''' business unit members and teams to other business units and teams and
	''' then delete those business units and teams.
	''' </summary>
	''' <param name="serverConfig">Contains server connection information.</param>
	''' <param name="promptforDelete">When True, the user will be prompted to delete all
	''' created entities.</param>
	Public Class ReassignBusinessUnitMembers
		#Region "Class Level Members"

		Private _serviceProxy As OrganizationServiceProxy
		Private _context As ServiceContext

		Private _users As List(Of Guid)
		Private _team As Team
		Private _leads(3) As Lead
		Private _businessUnit As BusinessUnit
		Private _rootBusinessUnit As BusinessUnit
		Private _originalRolesIds As List(Of Guid)

		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
		''' This method first creates 3 users, a team, 4 leads and a business unit. 
		''' It assigns two users to the team, and gives each user and the team a lead. 
		''' Then it reassigns all the leads from one of the users to another user using 
		''' the ReassignObjectsSystemUserRequest. Next, it reassigns all the leads from
		''' the team to a user using the ReassignObjectsOwnerRequest. Third, it reassigns
		''' one user from the root business unit to the created business unit, using the
		''' SetBusinessSystemUserRequest message. Fourth, it reassigns all users from 
		''' the created business unit to the root business unit and deletes the created 
		''' business unit. Finally, it removes all users from the created team and 
		''' deletes the team.
		''' </summary>
		''' <param name="serverConfig">Contains server connection information.</param>
		''' <param name="promptforDelete">When True, the user will be prompted to delete all
		''' created entities.</param>

        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly 
                ' disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' Using the ServiceContext class provides access to the LINQ provider
                    _context = New ServiceContext(_serviceProxy)
                    Using _context
                        ' This statement is required to enable early-bound type support.
                        _serviceProxy.EnableProxyTypes()

                        CreateRequiredRecords()

                        Console.WriteLine()
                        PrintLeads()

                        Dim users = From user In _context.SystemUserSet _
                                    Select New With {Key user.FullName, Key user.Id}
                        Dim userMapping As New Dictionary(Of Guid, String)()
                        For Each user In users
                            userMapping.Add(user.Id, user.FullName)
                        Next user

                        '					#Region "ReassignObjectsSystemUserRequest"

                        ' create the request
                        Dim reassignRequest As New ReassignObjectsSystemUserRequest() With
                            {
                                .ReassignPrincipal = New EntityReference(SystemUser.EntityLogicalName,
                                                                         _users(1)),
                                .UserId = _users(2)
                            }

                        ' execute the request
                        Console.WriteLine()
                        Console.WriteLine("  Reassigning leads from {0} to {1}",
                                          userMapping(_users(2)),
                                          userMapping(_users(1)))
                        _serviceProxy.Execute(reassignRequest)

                        ' check results
                        PrintLeads()

                        '					#End Region

                        '					#Region "ReassignObjectsOwnerRequest"

                        ' create the request
                        Dim request As New ReassignObjectsOwnerRequest() With
                            {
                                .FromPrincipal = _team.ToEntityReference(),
                                .ToPrincipal = New EntityReference(SystemUser.EntityLogicalName,
                                                                   _users(0))
                            }

                        ' execute the request
                        Console.WriteLine()
                        Console.WriteLine("  Reassigning leads from {0} to {1}",
                                          _team.Name,
                                          userMapping(_users(0)))
                        _serviceProxy.Execute(request)

                        ' check results
                        PrintLeads()

                        '					#End Region

                        '					#Region "reassign business unit members"

                        Console.WriteLine()
                        Console.WriteLine("  Adding a user to the created business unit")
                        ' track what permissions the user had before reassigning to the new
                        ' business unit so that the permissions can be restored when the
                        ' user is assigned back to the business unit
                        _originalRolesIds = New List(Of Guid)()
                        Dim roleIds = From user In _context.SystemUserSet _
                                      Join systemuserrole In _context.SystemUserRolesSet On
                                              user.SystemUserId Equals systemuserrole.SystemUserId _
                                              Join role In _context.RoleSet On
                                              systemuserrole.RoleId Equals role.RoleId _
                                              Select role.RoleId.Value

                        For Each roleId In roleIds
                            If Not _originalRolesIds.Contains(roleId) Then
                                _originalRolesIds.Add(roleId)
                            End If
                        Next roleId
                        
                        ' add user to the created business unit
                        _serviceProxy.Execute(New SetBusinessSystemUserRequest() With
                                              {
                                                  .BusinessId = _businessUnit.Id,
                                                  .ReassignPrincipal = New EntityReference(SystemUser.EntityLogicalName,
                                                                                           _users(2)),
                                                  .UserId = _users(2)
                                              })

                        '					#End Region

                        '					#Region "delete business unit"

                        Console.WriteLine()
                        Console.WriteLine("  Deleting created business unit")

                        ' remove all users from the business unit, moving them back to the
                        ' parent business unit
                        _serviceProxy.Execute(New SetBusinessSystemUserRequest() With
                                              {
                                                  .BusinessId = _rootBusinessUnit.Id,
                                                  .ReassignPrincipal = New EntityReference(SystemUser.EntityLogicalName,
                                                                                           _users(2)),
                                                  .UserId = _users(2)
                                              })

                        ' give the user back their original security roles
                        For Each roleId In _originalRolesIds
                            _serviceProxy.Associate(SystemUser.EntityLogicalName,
                                                    _users(2),
                                                    New Relationship("systemuserroles_association"),
                                                    New EntityReferenceCollection() From
                                                    {
                                                        New EntityReference(Role.EntityLogicalName, roleId)
                                                    })
                        Next roleId

                        ' deactivate business unit before deleting it
                        ' mark the state as inactive (value 1)
                        _serviceProxy.Execute(New SetStateRequest() With
                                              {
                                                  .EntityMoniker = _businessUnit.ToEntityReference(),
                                                  .State = New OptionSetValue(1),
                                                  .Status = New OptionSetValue(-1)
                                              })

                        ' delete business unit
                        _serviceProxy.Delete(BusinessUnit.EntityLogicalName, _businessUnit.Id)

                        '					#End Region

                        '					#Region "remove users from team"

                        Dim teamMembers = From team In _context.TeamSet _
                                          Join membership In _context.TeamMembershipSet On
                                          team.TeamId Equals membership.TeamId _
                                          Where team.TeamId.Equals(_team.Id) _
                                          Select membership.SystemUserId.Value

                        _serviceProxy.Execute(New RemoveMembersTeamRequest() With
                                              {
                                                  .MemberIds = teamMembers.ToArray(),
                                                  .TeamId = _team.Id
                                              })

                        '					#End Region

                        '					#Region "delete team"

                        Console.WriteLine()
                        Console.WriteLine("  Deleting the team")

                        ' Delete the team
                        _serviceProxy.Delete(Team.EntityLogicalName, _team.Id)

                        '					#End Region

                        DeleteRequiredRecords(promptforDelete)
                    End Using
                End Using
                ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

		Private Sub PrintLeads()
			Console.WriteLine("  Fetching leads from CRM")
            Dim leads = From lead In _context.LeadSet _
                        Join user In _context.SystemUserSet On
                        lead.OwningUser.Id Equals user.Id _
                        Select New With {Key .LeadName = lead.FullName,
                                         Key .OwningUserName = user.FullName}
			For Each lead In leads
                Console.WriteLine("  Lead {0} is owned by user {1}",
                                  lead.LeadName,
                                  lead.OwningUserName)
			Next lead
            leads = From lead In _context.LeadSet _
                    Join team In _context.TeamSet On
                    lead.OwnerId.Id Equals team.Id _
                    Select New With {Key .LeadName = lead.FullName,
                                     Key .OwningUserName = team.Name}
			For Each lead In leads
                Console.WriteLine("  Lead {0} is owned by user {1}",
                                  lead.LeadName,
                                  lead.OwningUserName)
			Next lead
		End Sub

		#Region "Public methods"

		''' <summary>
		''' Creates any entity records that this sample requires.
		''' </summary>
		Public Sub CreateRequiredRecords()
'			#Region "create users"

			Console.WriteLine("  Creating users")
			Dim ldapPath = ""
			_users = SystemUserProvider.RetrieveSalespersons(_serviceProxy, ldapPath)
            _users.Add(SystemUserProvider.RetrieveSystemUser("dparker",
                                                             "Darren",
                                                             "Parker",
                                                             "Salesperson",
                                                             _serviceProxy,
                                                             ldapPath))

'			#End Region

'			#Region "fetch root business unit"

			' Retrieve the root business unit to use for creating the team for the
			' sample.
            Dim businessUnitQuery = New QueryExpression With
                                    {
                                        .EntityName = BusinessUnit.EntityLogicalName,
                                        .ColumnSet = New ColumnSet("businessunitid"),
                                        .Criteria = New FilterExpression()
                                    }

            businessUnitQuery.Criteria.AddCondition("parentbusinessunitid",
                                                    ConditionOperator.Null)
			Dim businessUnitResult = _serviceProxy.RetrieveMultiple(businessUnitQuery)
			_rootBusinessUnit = businessUnitResult.Entities(0).ToEntity(Of BusinessUnit)()

'			#End Region

'			#Region "create new business unit"

			Console.WriteLine("  Creating new business unit")
            _businessUnit = New BusinessUnit() With
                            {
                                .Name = "A Sample Business Unit",
                                .ParentBusinessUnitId = _rootBusinessUnit.ToEntityReference()
                            }
			_businessUnit.Id = _serviceProxy.Create(_businessUnit)

'			#End Region

'			#Region "create team"

			Console.WriteLine("  Creating a user team")
            _team = New Team With
                    {
                        .AdministratorId = New EntityReference(SystemUser.EntityLogicalName,
                                                               _users(0)),
                        .Name = "Sample team",
                        .BusinessUnitId = _rootBusinessUnit.ToEntityReference()
                    }
			_team.Id = _serviceProxy.Create(_team)

            Dim salespersonRole = ( _
                From role In _context.RoleSet _
                Where role.Name.Equals("Salesperson") AndAlso
                role.BusinessUnitId.Id.Equals(_rootBusinessUnit.Id) _
                Select role).First()

			' assign role to the team
            _serviceProxy.Associate(Team.EntityLogicalName,
                                    _team.Id,
                                    New Relationship("teamroles_association"),
                                    New EntityReferenceCollection() From {salespersonRole.ToEntityReference()})

			' wait for the async job to finish
			For i As Integer = 1 To 30
				Console.WriteLine("  Checking to see if the async job has finished {0}/30", i)
                Dim teamPrivileges =
                    CType(_serviceProxy.Execute(
                            New RetrieveTeamPrivilegesRequest With
                            {
                                .TeamId = _team.Id
                            }), 
                    RetrieveTeamPrivilegesResponse)
                If teamPrivileges.RolePrivileges.Any(Function(rp) rp.PrivilegeId =
                                                         New Guid("A8ECAC53-09E8-4A13-B598-8D8C87BC3D33")) Then ' prvReadLead
                    Exit For
                End If
				System.Threading.Thread.Sleep(1000)
			Next i
'			#End Region

'			#Region "add users to team"

			Console.WriteLine("  Adding users to the team")
            Dim addMembers As New AddMembersTeamRequest() With
                {
                    .TeamId = _team.Id,
                    .MemberIds = New Guid() {_users(0), _users(1)}
                }
			_serviceProxy.Execute(addMembers)

'			#End Region

'			#Region "create leads"

			Console.WriteLine("  Creating leads")
            _leads(0) = New Lead With
                        {
                            .CompanyName = "A. Datum Corporation",
                            .FirstName = "Joe",
                            .LastName = "Andreshak"
                        }
			_leads(0).Id = _serviceProxy.Create(_leads(0))

            _leads(1) = New Lead With
                        {
                            .CompanyName = "Wingtip Toys",
                            .FirstName = "Diogo",
                            .LastName = "Andrade"
                        }
			_leads(1).Id = _serviceProxy.Create(_leads(1))

            _leads(2) = New Lead With
                        {
                            .CompanyName = "The Phone Company",
                            .FirstName = "Ronaldo",
                            .LastName = "Smith Jr."
                        }
			_leads(2).Id = _serviceProxy.Create(_leads(2))

            _leads(3) = New Lead With
                        {
                            .CompanyName = "Tailspin Toys",
                            .FirstName = "Andrew",
                            .LastName = "Sullivan"
                        }
			_leads(3).Id = _serviceProxy.Create(_leads(3))

'			#End Region

'			#Region "assign leads"

			Console.WriteLine("  Assigning leads to users and teams")
            _serviceProxy.Execute(New AssignRequest() With
                                  {
                                      .Assignee = New EntityReference(SystemUser.EntityLogicalName,
                                                                      _users(0)),
                                      .Target = _leads(0).ToEntityReference()
                                  })

            _serviceProxy.Execute(New AssignRequest() With
                                  {
                                      .Assignee = New EntityReference(SystemUser.EntityLogicalName,
                                                                      _users(1)),
                                      .Target = _leads(1).ToEntityReference()
                                  })

            _serviceProxy.Execute(New AssignRequest() With
                                  {
                                      .Assignee = New EntityReference(SystemUser.EntityLogicalName,
                                                                      _users(2)),
                                      .Target = _leads(2).ToEntityReference()
                                  })

			' give the team access to the record so that it can be assigned to it
            _serviceProxy.Execute(New GrantAccessRequest() With
                                  {
                                      .Target = _leads(3).ToEntityReference(),
                                      .PrincipalAccess = New PrincipalAccess() With
                                                         {
                                                             .AccessMask = AccessRights.ReadAccess Or
                                                             AccessRights.WriteAccess,
                                                             .Principal = _team.ToEntityReference()
                                                         }
                                  })

			' assign the lead to the team
            _serviceProxy.Execute(New AssignRequest() With
                                  {
                                      .Assignee = _team.ToEntityReference(),
                                      .Target = _leads(3).ToEntityReference()
                                  })

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
				' Delete the leads
				For Each lead_Renamed As Lead In _leads
					_serviceProxy.Delete(Lead.EntityLogicalName, lead_Renamed.Id)
				Next lead_Renamed
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

				Dim app As New ReassignBusinessUnitMembers()
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

' </snippetreassignbusinessunitmembers>