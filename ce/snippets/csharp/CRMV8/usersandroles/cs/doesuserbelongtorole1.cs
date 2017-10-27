// <snippetdoesuserbelongtorole1>


             // Connect to the Organization service. 
             // The using statement assures that the service proxy will be properly disposed.
             using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
             {
                 _serviceProxy.EnableProxyTypes();

                 CreateRequiredRecords();

                 
                 // Retrieve a user.
                 SystemUser user = _serviceProxy.Retrieve(SystemUser.EntityLogicalName,
                     _userId, new ColumnSet(new String [] {"systemuserid", "firstname", "lastname"})).ToEntity<SystemUser>();

                 if (user != null)
                 {
                     Console.WriteLine("{1} {0} user account is retrieved.", user.LastName, user.FirstName);
                     // Find a role.
                     QueryExpression query = new QueryExpression
                     {
                         EntityName = Role.EntityLogicalName,
                         ColumnSet = new ColumnSet("roleid"),
                         Criteria = new FilterExpression
                         {
                             Conditions =
                             {
 
                                 new ConditionExpression
                                 {
                                     AttributeName = "name",
                                     Operator = ConditionOperator.Equal,
                                     Values = {_givenRole}
                                 }
                             }
                         }
                     };

                     // Get the role.
                     EntityCollection givenRoles = _serviceProxy.RetrieveMultiple(query);

                     if (givenRoles.Entities.Count > 0)
                     {
                         Role givenRole = givenRoles.Entities[0].ToEntity<Role>();

                         Console.WriteLine("Role {0} is retrieved.", _givenRole);

                         Console.WriteLine("Checking association between user and role.");
                         // Establish a SystemUser link for a query.
                         LinkEntity systemUserLink = new LinkEntity()
                         {
                             LinkFromEntityName = SystemUserRoles.EntityLogicalName,
                             LinkFromAttributeName = "systemuserid",
                             LinkToEntityName = SystemUser.EntityLogicalName,
                             LinkToAttributeName = "systemuserid",
                             LinkCriteria =
                             {
                                 Conditions =
                                 {
                                     new ConditionExpression(
                                         "systemuserid", ConditionOperator.Equal, user.Id)
                                 }
                             }
                         };

                         // Build the query.
                         QueryExpression linkQuery = new QueryExpression()
                         {
                             EntityName = Role.EntityLogicalName,
                             ColumnSet = new ColumnSet("roleid"),
                             LinkEntities =
                             {
                                 new LinkEntity()
                                 {
                                     LinkFromEntityName = Role.EntityLogicalName,
                                     LinkFromAttributeName = "roleid",
                                     LinkToEntityName = SystemUserRoles.EntityLogicalName,
                                     LinkToAttributeName = "roleid",
                                     LinkEntities = {systemUserLink}
                                 }
                             },
                             Criteria =
                             {
                                 Conditions =
                                 {
                                     new ConditionExpression("roleid", ConditionOperator.Equal, givenRole.Id)
                                 }
                             }
                         };
                         
                         // Retrieve matching roles.
                         EntityCollection matchEntities = _serviceProxy.RetrieveMultiple(linkQuery);

                         // if an entity is returned then the user is a member
                         // of the role
                         Boolean isUserInRole = (matchEntities.Entities.Count > 0);

                         if(isUserInRole)
                             Console.WriteLine("User do not belong to the role.");
                         else
                             Console.WriteLine("User belong to this role.");

                     }
                 }
             }

// </snippetdoesuserbelongtorole1>