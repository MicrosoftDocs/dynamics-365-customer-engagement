// <snippetremoverolefromuser1>


             // Connect to the Organization service. 
             // The using statement assures that the service proxy is properly disposed.
             using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
             {
                 _serviceProxy.EnableProxyTypes();

                 CreateRequiredRecords();

                 // Retrieve a user.
                 SystemUser user = _serviceProxy.Retrieve(SystemUser.EntityLogicalName,
                     _userId, new ColumnSet(new String[] { "systemuserid", "firstname", "lastname" })).ToEntity<SystemUser>();

                 if (user != null)
                 {
                     Console.WriteLine("{1} {0} user account is retrieved.", user.FirstName, user.LastName);
                     // Find the role.
                     QueryExpression query = new QueryExpression
                     {
                         EntityName = "role",
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
                     EntityCollection roles = _serviceProxy.RetrieveMultiple(query);

                     // Disassociate the role.
                     if (roles.Entities.Count > 0)
                     {
                         Role salesRole = _serviceProxy.RetrieveMultiple(query).Entities[0].ToEntity<Role>();

                         Console.WriteLine("Role {0} is retrieved.", _givenRole);

                         _serviceProxy.Disassociate(
                                     "systemuser",
                                     user.Id,
                                     new Relationship("systemuserroles_association"),
                                     new EntityReferenceCollection() { new EntityReference("role", salesRole.Id) });
                         Console.WriteLine("Role {0} is disassociated from user {1} {2}.", _givenRole, user.FirstName, user.LastName);
                     }
                 }

             }

// </snippetremoverolefromuser1>