' <snippetretrieveusersharedattributepermissions2>



 '					#Region "Check if this user has prvReadPOAA"
 ' Get the GUID of the current user.
 Dim whoAmI As New WhoAmIRequest()
 Dim userLoggedId As Guid = (CType(_serviceProxy.Execute(whoAmI), 
                             WhoAmIResponse)).UserId
 Console.WriteLine("User logged: " &amp; userLoggedId.ToString())

 ' Check if this user has prvReadPOAA.
 Dim userPrivilegesRequest As New RetrieveUserPrivilegesRequest()
 userPrivilegesRequest.UserId = userLoggedId
 Dim userPrivilegesResponse As RetrieveUserPrivilegesResponse =
     CType(_serviceProxy.Execute(userPrivilegesRequest), RetrieveUserPrivilegesResponse)

 ' Fixed the GUID for prvReadPOAA.
 Dim prvReadPOAA As New Guid("{68564CD5-2B2E-11DF-80A6-00137299E1C2}")

 If userPrivilegesResponse.RolePrivileges.Any(Function(r) r.PrivilegeId.Equals(prvReadPOAA)) Then
     Console.WriteLine("This user DOES have prvReadPOAA")
 Else
     Console.WriteLine("This user DOESN'T have prvReadPOAA")
 End If
 Console.WriteLine()
 '					#End Region ' Check if this user has prvReadPOAA

' </snippetretrieveusersharedattributepermissions2>