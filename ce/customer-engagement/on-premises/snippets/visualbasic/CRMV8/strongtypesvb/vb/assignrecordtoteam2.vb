' <snippetassignrecordtoteam2>


 ' Add the prvReadAccount privilege to the example roles to assure the
 ' team can read accounts.
 Dim addPrivilegesRequest As AddPrivilegesRoleRequest = New AddPrivilegesRoleRequest With { _
     .RoleId = _roleId, .Privileges = {New RolePrivilege With {.PrivilegeId = readAccountPrivilege.Id}}}
         ' Grant prvReadAccount privilege.
 _service.Execute(addPrivilegesRequest)

' </snippetassignrecordtoteam2>