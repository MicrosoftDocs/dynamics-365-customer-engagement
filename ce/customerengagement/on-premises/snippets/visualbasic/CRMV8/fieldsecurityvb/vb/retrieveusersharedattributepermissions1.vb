' <snippetretrieveusersharedattributepermissions1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     CreateRequiredRecords()

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

     '					#Region "Create an account record"

     ' Create an account record.
     Dim accountRecord As New Account()
     accountRecord.Name = "Ane"
     accountRecord("secret_phone") = "123456"
     _accountRecordId = _serviceProxy.Create(accountRecord)
     Console.WriteLine("Account record created.")

     '					#End Region ' Create an account record

     '					#Region "Create POAA entity for field #1"

     ' Create the POAA entity for field #1.
     Dim poaa As PrincipalObjectAttributeAccess =
         New PrincipalObjectAttributeAccess With
         {
             .AttributeId = _secretHomeId,
             .ObjectId = New EntityReference(Account.EntityLogicalName, _accountRecordId),
             .PrincipalId = New EntityReference(SystemUser.EntityLogicalName, userLoggedId),
             .ReadAccess = True,
             .UpdateAccess = True
         }

     _serviceProxy.Create(poaa)
     Console.WriteLine("POAA record for custom field Secret_Home created.")

     '					#End Region ' Create POAA entity for field #1

     '					#Region "Create POAA entity for field #2"

     ' Create the POAA entity for field #2.
     poaa = New PrincipalObjectAttributeAccess With
            {
                .AttributeId = _secretPhoneId,
                .ObjectId = New EntityReference(Account.EntityLogicalName, _accountRecordId),
                .PrincipalId = New EntityReference(SystemUser.EntityLogicalName, userLoggedId),
                .ReadAccess = True,
                .UpdateAccess = True
            }

     _serviceProxy.Create(poaa)
     Console.WriteLine("POAA record for custom field Secret_Phone created.")

     '					#End Region ' Create POAA entity for field #2

     '					#Region "Retrieve User Shared Attribute Permissions"
     ' Create the query for retrieve User Shared Attribute permissions.
     Dim queryPOAA As New QueryExpression("principalobjectattributeaccess")
     queryPOAA.ColumnSet = New ColumnSet(New String() {"attributeid", "readaccess",
                                                       "updateaccess", "principalid"})
     queryPOAA.Criteria.FilterOperator = LogicalOperator.And
     queryPOAA.Criteria.Conditions.Add(New ConditionExpression("objectid",
                                                               ConditionOperator.Equal,
                                                               _accountRecordId))
     queryPOAA.Criteria.Conditions.Add(New ConditionExpression("principalid",
                                                               ConditionOperator.EqualUserId))

     Console.WriteLine()
     Console.WriteLine("POAA for user: " &amp; userLoggedId.ToString())
     Console.WriteLine()

     Try
         ' Execute the query.
         Dim responsePOAA As EntityCollection = _serviceProxy.RetrieveMultiple(queryPOAA)

         For Each entity In responsePOAA.Entities
             Console.WriteLine("  principalid: " &amp; _
                               (CType(entity("principalid"), EntityReference)).Id.ToString())
             Console.WriteLine("  attributeid: " &amp; _
                               entity("attributeid").ToString())
             Console.WriteLine("  readaccess: " &amp; entity("readaccess").ToString())
             Console.WriteLine("  updateaccess: " &amp; entity("updateaccess").ToString())
             Console.WriteLine()
         Next entity
     Catch exc As Exception
         Console.WriteLine("Error: " &amp; exc.Message)
     End Try

     '					#End Region ' Retrieve User Shared Attribute Permissions

     DeleteRequiredRecords(promptforDelete)

 End Using

' </snippetretrieveusersharedattributepermissions1>