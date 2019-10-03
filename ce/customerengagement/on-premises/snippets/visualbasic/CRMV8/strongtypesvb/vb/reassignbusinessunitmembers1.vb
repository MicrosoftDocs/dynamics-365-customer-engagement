' <snippetreassignbusinessunitmembers1>


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

' </snippetreassignbusinessunitmembers1>