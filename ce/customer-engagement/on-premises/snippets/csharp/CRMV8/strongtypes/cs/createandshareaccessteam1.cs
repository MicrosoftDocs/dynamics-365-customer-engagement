// <snippetcreateandshareaccessteam1>


 // Create a access team.
 var team = new Team
 {
     AdministratorId = new EntityReference(
         "systemuser", _currentUserId),
     Name = "UserAccess Test Team",
     BusinessUnitId = new EntityReference(
         "businessunit", businessUnitId),
     TeamType = new OptionSetValue((int)TeamTeamType.Access),
 };

 _teamId = _serviceProxy.Create(team);
 Console.WriteLine("Created an access team named '{0}'.", team.Name);

 // Add two sales people to the access team.
 var addToTeamRequest = new AddMembersTeamRequest
 {
     TeamId = _teamId,
     MemberIds = new[] { salesPersons[0], salesPersons[1] }
 };
 _serviceProxy.Execute(addToTeamRequest);
 Console.WriteLine("Added two sales people to the team.");
 
 // Grant the team read/write access to an account.
 var accountReference = new EntityReference(Account.EntityLogicalName, _accountId);
 var teamReference = new EntityReference(Team.EntityLogicalName, _teamId);
 var grantAccessRequest = new GrantAccessRequest
 {
     PrincipalAccess = new PrincipalAccess
     {
         AccessMask = AccessRights.ReadAccess | AccessRights.WriteAccess,
         Principal = teamReference
     },
     Target = accountReference
 };
 _serviceProxy.Execute(grantAccessRequest);
 Console.WriteLine("Granted read/write access on the account record to the team.");

// </snippetcreateandshareaccessteam1>