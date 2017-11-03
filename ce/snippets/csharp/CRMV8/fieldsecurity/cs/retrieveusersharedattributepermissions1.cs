// <snippetretrieveusersharedattributepermissions1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early bound type support.
     _serviceProxy.EnableProxyTypes();

     CreateRequiredRecords();


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
     #region Create an account record

     // Create an account record
     Account accountRecord = new Account();
     accountRecord.Name = "Ane";
     accountRecord["secret_phone"] = "123456";
     _accountRecordId = _serviceProxy.Create(accountRecord);
     Console.WriteLine("Account record created.");

     #endregion Create an account record

     #region Create POAA entity for field #1

     // Create POAA entity for field #1
     PrincipalObjectAttributeAccess poaa = new PrincipalObjectAttributeAccess
     {
         AttributeId = _secretHomeId,
         ObjectId = new EntityReference
             (Account.EntityLogicalName, _accountRecordId),
         PrincipalId = new EntityReference
             (SystemUser.EntityLogicalName, userLoggedId),
         ReadAccess = true,
         UpdateAccess = true
     };

     _serviceProxy.Create(poaa);
     Console.WriteLine("POAA record for custom field Secret_Home created.");

     #endregion Create POAA entity for field #1

     #region Create POAA entity for field #2

     // Create POAA entity for field #2
     poaa = new PrincipalObjectAttributeAccess
     {
         AttributeId = _secretPhoneId,
         ObjectId = new EntityReference
             (Account.EntityLogicalName, _accountRecordId), 
         PrincipalId = new EntityReference
             (SystemUser.EntityLogicalName, userLoggedId),
         ReadAccess = true,
         UpdateAccess = true
     };

     _serviceProxy.Create(poaa);
     Console.WriteLine("POAA record for custom field Secret_Phone created.");

     #endregion Create POAA entity for field #2

     #region Retrieve User Shared Attribute Permissions
     // Create the query for retrieve User Shared Attribute permissions.
     QueryExpression queryPOAA =
         new QueryExpression("principalobjectattributeaccess");
     queryPOAA.ColumnSet = new ColumnSet
         (new string[] { "attributeid", "readaccess", "updateaccess", "principalid" });
     queryPOAA.Criteria.FilterOperator = LogicalOperator.And;
     queryPOAA.Criteria.Conditions.Add
         (new ConditionExpression("objectid", ConditionOperator.Equal, _accountRecordId));
     queryPOAA.Criteria.Conditions.Add
         (new ConditionExpression("principalid", ConditionOperator.EqualUserId));

     Console.WriteLine();
     Console.WriteLine("POAA for user: " + userLoggedId.ToString());
     Console.WriteLine();

     try
     {
         // Execute the query.
         EntityCollection responsePOAA = _serviceProxy.RetrieveMultiple(queryPOAA);

         foreach (var entity in responsePOAA.Entities)
         {
             Console.WriteLine("  principalid: " + ((EntityReference)entity["principalid"]).Id);
             Console.WriteLine("  attributeid: " + entity["attributeid"].ToString());
             Console.WriteLine("  readaccess: " + entity["readaccess"].ToString());
             Console.WriteLine("  updateaccess: " + entity["updateaccess"].ToString());
             Console.WriteLine();
         }
     }
     catch (Exception exc)
     {
         Console.WriteLine("Error: " + exc.Message);
     }

     #endregion Retrieve User Shared Attribute Permissions

     DeleteRequiredRecords(promptforDelete);
    
 }

// </snippetretrieveusersharedattributepermissions1>