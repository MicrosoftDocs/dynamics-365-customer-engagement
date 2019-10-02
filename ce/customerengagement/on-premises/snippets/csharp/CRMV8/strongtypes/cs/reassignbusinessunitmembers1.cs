// <snippetreassignbusinessunitmembers1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly 
 // disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 // Using the ServiceContext class provides access to the LINQ provider
 using (_context = new ServiceContext(_serviceProxy))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     CreateRequiredRecords();

     Console.WriteLine();
     PrintLeads();

     var users = from user in _context.SystemUserSet
                     select new { user.FullName, user.Id };
     Dictionary<Guid, String> userMapping = new Dictionary<Guid,String>();
     foreach (var user in users)
         userMapping.Add(user.Id, user.FullName);

     #region ReassignObjectsSystemUserRequest
     
     // create the request
     ReassignObjectsSystemUserRequest reassignRequest = 
         new ReassignObjectsSystemUserRequest()
     {
         ReassignPrincipal = 
             new EntityReference(SystemUser.EntityLogicalName, _users[1]),
         UserId = _users[2]
     };

     // execute the request
     Console.WriteLine();
     Console.WriteLine(
         "  Reassigning leads from {0} to {1}", 
         userMapping[_users[2]],
         userMapping[_users[1]]);
     _serviceProxy.Execute(reassignRequest);
     
     // check results
     PrintLeads();

     #endregion

     #region ReassignObjectsOwnerRequest

     // create the request
     ReassignObjectsOwnerRequest request = 
         new ReassignObjectsOwnerRequest()
     {
         FromPrincipal = _team.ToEntityReference(),
         ToPrincipal = 
             new EntityReference(SystemUser.EntityLogicalName, _users[0])
     };

     // execute the request
     Console.WriteLine();
     Console.WriteLine(
         "  Reassigning leads from {0} to {1}", 
         _team.Name, userMapping[_users[0]]);
     _serviceProxy.Execute(request);

     // check results
     PrintLeads();

     #endregion

     #region reassign business unit members

     Console.WriteLine();
     Console.WriteLine("  Adding a user to the created business unit");
     // track what permissions the user had before reassigning to the new
     // business unit so that the permissions can be restored when the
     // user is assigned back to the business unit
     _originalRolesIds = new List<Guid>();
     var roleIds = from user in _context.SystemUserSet
                   join systemuserrole in _context.SystemUserRolesSet 
                     on user.SystemUserId equals systemuserrole.SystemUserId
                   join role in _context.RoleSet 
                     on systemuserrole.RoleId equals role.RoleId
                   where user.SystemUserId.Value == _users[2]
                   select role.RoleId.Value;

     foreach (var roleId in roleIds)
         _originalRolesIds.Add(roleId);

     // add user to the created business unit
     _serviceProxy.Execute(new SetBusinessSystemUserRequest()
     {
         BusinessId = _businessUnit.Id,
         ReassignPrincipal = new EntityReference(
             SystemUser.EntityLogicalName,
             _users[2]),
         UserId = _users[2]
     });

     #endregion

     #region delete business unit

     Console.WriteLine();
     Console.WriteLine("  Deleting created business unit");

     // remove all users from the business unit, moving them back to the
     // parent business unit
     _serviceProxy.Execute(new SetBusinessSystemUserRequest()
     {
         BusinessId = _rootBusinessUnit.Id,
         ReassignPrincipal = new EntityReference(
             SystemUser.EntityLogicalName, _users[2]),
         UserId = _users[2]
     });

     // give the user back their original security roles
     foreach (var roleId in roleIds)
     {
         _serviceProxy.Associate(
              SystemUser.EntityLogicalName,
              _users[2],
              new Relationship("systemuserroles_association"),
              new EntityReferenceCollection() { 
                 new EntityReference(
                     Role.EntityLogicalName,
                     roleId
                 )
             }
          );
     }

     // deactivate business unit before deleting it
     _serviceProxy.Execute(new SetStateRequest()
     {
         EntityMoniker = _businessUnit.ToEntityReference(),
         // mark the state as inactive (value 1)
         State = new OptionSetValue(1),
         Status = new OptionSetValue(-1)
     });

     // delete business unit
     _serviceProxy.Delete(BusinessUnit.EntityLogicalName,
         _businessUnit.Id);

     #endregion

     #region remove users from team

     var teamMembers = from team in _context.TeamSet
                       join membership in _context.TeamMembershipSet
                       on team.TeamId equals membership.TeamId
                       where team.TeamId == _team.Id
                       select membership.SystemUserId.Value;

     _serviceProxy.Execute(new RemoveMembersTeamRequest()
     {
         MemberIds = teamMembers.ToArray(),
         TeamId = _team.Id
     });

     #endregion

     #region delete team

     Console.WriteLine();
     Console.WriteLine("  Deleting the team");

     // Delete the team
     _serviceProxy.Delete(Team.EntityLogicalName, _team.Id);

     #endregion

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetreassignbusinessunitmembers1>