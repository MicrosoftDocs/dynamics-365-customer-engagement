// <snippetuseraccess1>


 // Grant the team read/write access to the lead.
 var teamReference = new EntityReference(Team.EntityLogicalName, _teamId);
 var grantAccessRequest = new GrantAccessRequest
 {
     PrincipalAccess = new PrincipalAccess
     {
         AccessMask = AccessRights.ReadAccess | AccessRights.WriteAccess,
         Principal = teamReference
     },
     Target = leadReference
 };

 Console.WriteLine("Granting {0} to {1} ({2}) on the lead...\r\n",
     AccessRights.ReadAccess | AccessRights.WriteAccess, GetEntityReferenceString(teamReference), "Team");
 _serviceProxy.Execute(grantAccessRequest);

 var systemUser2Ref = new EntityReference(SystemUser.EntityLogicalName,
     _systemUserIds[1]);

// </snippetuseraccess1>