' <snippetsharingrecords1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     _service = CType(_serviceProxy, IOrganizationService)

     CreateRequiredRecords()

     '					#Region "GrantAccess Message"

     ' Create the request object and set the target and principal access
     ' object.
     Dim grantRequest As New GrantAccessRequest() With
         {
             .Target = New EntityReference(Account.EntityLogicalName,
                                           _accountId),
             .PrincipalAccess =
             New PrincipalAccess() With
             {
                 .Principal =
                 New EntityReference(SystemUser.EntityLogicalName,
                                     _userId),
                 .AccessMask = AccessRights.WriteAccess _
                                 Or AccessRights.ReadAccess _
                                 Or AccessRights.ShareAccess
             }
         }

     ' Execute the request.
     Dim grantResponse As GrantAccessResponse =
         CType(_service.Execute(grantRequest), GrantAccessResponse)

     Console.Write("Access Granted ")

     '					#End Region

     '					#Region "ModifyAccess Message"

     ' Create the request object and set the target and principal access
     ' object.
     Dim modifyRequest As New ModifyAccessRequest() With
         {
             .Target = New EntityReference(Account.EntityLogicalName,
                                           _accountId),
             .PrincipalAccess =
             New PrincipalAccess() With
             {
                 .Principal =
                 New EntityReference(SystemUser.EntityLogicalName,
                                     _userId),
                 .AccessMask = AccessRights.ReadAccess _
                                 Or AccessRights.ShareAccess
             }
         }

     ' Execute the request.
     Dim modifyResponse As ModifyAccessResponse =
         CType(_service.Execute(modifyRequest), ModifyAccessResponse)

     Console.Write("and Modified. ")

     '					#End Region

     '					#Region "RetrievePrincipalAccess Message"

     ' Create the request object and set the target and principal.
     Dim retrieveRequest As New RetrievePrincipalAccessRequest() With
         {
             .Target = New EntityReference(Account.EntityLogicalName,
                                           _accountId),
             .Principal = New EntityReference(SystemUser.EntityLogicalName,
                                              _userId)
         }

     ' Execute the request.
     Dim retrieveResponse As RetrievePrincipalAccessResponse =
         CType(_service.Execute(retrieveRequest), 
             RetrievePrincipalAccessResponse)

     Console.Write("Retrieved principal access. ")

     '					#End Region

     '					#Region "RetrieveSharedPrincipalsAndAccess Message"

     ' Create the request object and set the target.
     Dim retrieveSharedRequest As _
         New RetrieveSharedPrincipalsAndAccessRequest() With
         {
             .Target = New EntityReference(Account.EntityLogicalName,
                                           _accountId)
         }

     ' Execute the request.
     Dim retrieveSharedResponse As  _
         RetrieveSharedPrincipalsAndAccessResponse =
         CType(_service.Execute(retrieveSharedRequest), 
             RetrieveSharedPrincipalsAndAccessResponse)

     Console.Write("Retrieved principals and access. ")

     '					#End Region

     '					#Region "RevokeAccess Message"

     ' Create the request object and set the target and revokee.
     Dim revokeRequest As _
         New RevokeAccessRequest() With
         {
             .Target = New EntityReference(Account.EntityLogicalName,
                                           _accountId),
             .Revokee = New EntityReference(SystemUser.EntityLogicalName,
                                            _userId)
         }

     ' Execute the request.
     Dim revokeResponse As RevokeAccessResponse =
         CType(_service.Execute(revokeRequest), 
             RevokeAccessResponse)

     Console.Write("Revoked Access.")

     '					#End Region

     DeleteRequiredRecords(promptforDelete)
 End Using

' </snippetsharingrecords1>