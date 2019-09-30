// <snippetaddroletouser1>


             // Connect to the Organization service. 
             // The using statement assures that the service proxy is properly disposed.
             using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                                  serverConfig.Credentials, serverConfig.DeviceCredentials))
             {
                 _serviceProxy.EnableProxyTypes();

                 CreateRequiredRecords();

                 // Find the role.
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
                 EntityCollection roles = _serviceProxy.RetrieveMultiple(query);
                 if (roles.Entities.Count > 0)
                 {
                     Role salesRole = _serviceProxy.RetrieveMultiple(query).Entities[0].ToEntity<Role>();

                     Console.WriteLine("Role {0} is retrieved for the role assignment.", _givenRole);

                     _roleId = salesRole.Id;

                     // Associate the user with the role.
                     if (_roleId != Guid.Empty && _userId != Guid.Empty)
                     {
                         _serviceProxy.Associate(
                                     "systemuser",
                                     _userId,
                                     new Relationship("systemuserroles_association"),
                                     new EntityReferenceCollection() { new EntityReference(Role.EntityLogicalName, _roleId) });

                         Console.WriteLine("Role is associated with the user.");
                     }
                 }

                 DeleteRequiredRecords(promptforDelete);
             }

// </snippetaddroletouser1>