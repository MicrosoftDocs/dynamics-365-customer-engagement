// <snippetassignrecordtoteam2>


 // Add the prvReadAccount privilege to the example roles to assure the
 // team can read accounts.
 AddPrivilegesRoleRequest addPrivilegesRequest = new AddPrivilegesRoleRequest
 {
     RoleId = _roleId,
     Privileges = new[] 
     {
         // Grant prvReadAccount privilege.
         new RolePrivilege
         { 
             PrivilegeId = readAccountPrivilege.Id 
         }
     }
 };
 _service.Execute(addPrivilegesRequest);

// </snippetassignrecordtoteam2>