// <snippetassignrecordtoteam3>


 // It takes some time for the privileges to propagate to the team. Delay the
 // application until the privilege has been assigned.
 bool teamLacksPrivilege = true;
 while (teamLacksPrivilege)
 {
     RetrieveTeamPrivilegesRequest retrieveTeamPrivilegesRequest = 
         new RetrieveTeamPrivilegesRequest
     {
         TeamId = _teamId
     };

     RetrieveTeamPrivilegesResponse retrieveTeamPrivilegesResponse =
         (RetrieveTeamPrivilegesResponse)_service.Execute(
         retrieveTeamPrivilegesRequest);

     foreach (RolePrivilege rp in 
         retrieveTeamPrivilegesResponse.RolePrivileges)
     {
         if (rp.PrivilegeId == readAccountPrivilege.Id)
         {
             teamLacksPrivilege = false;
             break;
         }
         else
         {
             System.Threading.Thread.CurrentThread.Join(500);
         }
     }
 }

// </snippetassignrecordtoteam3>