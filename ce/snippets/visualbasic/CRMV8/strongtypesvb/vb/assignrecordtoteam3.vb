' <snippetassignrecordtoteam3>


 ' It takes some time for the privileges to propagate to the team. Delay the
 ' application until the privilege has been assigned.
 Dim teamLacksPrivilege As Boolean = True
 Do While teamLacksPrivilege
     Dim retrieveTeamPrivilegesRequest As RetrieveTeamPrivilegesRequest = _
         New RetrieveTeamPrivilegesRequest With {.TeamId = _teamId}

     Dim retrieveTeamPrivilegesResponse As RetrieveTeamPrivilegesResponse = _
         CType(_service.Execute(retrieveTeamPrivilegesRequest), RetrieveTeamPrivilegesResponse)

     For Each rp As RolePrivilege In retrieveTeamPrivilegesResponse.RolePrivileges
         If rp.PrivilegeId = readAccountPrivilege.Id Then
             teamLacksPrivilege = False
             Exit For
         Else
             System.Threading.Thread.CurrentThread.Join(500)
         End If
     Next rp
 Loop

' </snippetassignrecordtoteam3>