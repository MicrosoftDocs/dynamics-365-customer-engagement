// <snippetretrieveusersharedattributepermissions2>



 #region Check if this user has prvReadPOAA
 // Get the GUID of the current user.
 WhoAmIRequest whoAmI = new WhoAmIRequest();
 Guid userLoggedId = 
     ((WhoAmIResponse)_serviceProxy.Execute(whoAmI)).UserId;
 Console.WriteLine("User logged: " + userLoggedId);

 // Check if this user has prvReadPOAA.
 RetrieveUserPrivilegesRequest userPrivilegesRequest = 
     new RetrieveUserPrivilegesRequest();
 userPrivilegesRequest.UserId = userLoggedId;
 RetrieveUserPrivilegesResponse userPrivilegesResponse =
     (RetrieveUserPrivilegesResponse)_serviceProxy.Execute(userPrivilegesRequest);

 // Fixed the GUID for prvReadPOAA.
 Guid prvReadPOAA = new Guid("{68564CD5-2B2E-11DF-80A6-00137299E1C2}");

 if (userPrivilegesResponse.RolePrivileges.Any(r => r.PrivilegeId.Equals(prvReadPOAA)))
 {
     Console.WriteLine("This user DOES have prvReadPOAA");
 }
 else
 {
     Console.WriteLine("This user DOESN'T have prvReadPOAA");
 }
 Console.WriteLine();
 #endregion Check if this user has prvReadPOAA

// </snippetretrieveusersharedattributepermissions2>