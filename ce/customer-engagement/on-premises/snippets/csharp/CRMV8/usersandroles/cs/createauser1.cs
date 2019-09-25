// <snippetcreateauser1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy is properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                      serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     _serviceProxy.EnableProxyTypes();

     CreateRequiredRecords();

     // Retrieve the default business unit needed to create the user.
     QueryExpression businessUnitQuery = new QueryExpression
     {
         EntityName = BusinessUnit.EntityLogicalName,
         ColumnSet = new ColumnSet("businessunitid"),
         Criteria =
         {
             Conditions =
     {
         new ConditionExpression("parentbusinessunitid", 
             ConditionOperator.Null)
     }
         }
     };

     BusinessUnit defaultBusinessUnit = _serviceProxy.RetrieveMultiple(
         businessUnitQuery).Entities[0].ToEntity<BusinessUnit>();

     //Create a new system user.
     SystemUser user = new SystemUser
     {
         DomainName = _domain + _userName,
         FirstName = _firstName,
         LastName = _lastName,
         BusinessUnitId = new EntityReference
         {
             LogicalName = BusinessUnit.EntityLogicalName,
             Name = BusinessUnit.EntityLogicalName,
             Id = defaultBusinessUnit.Id
         }
     };

     Guid userId = _serviceProxy.Create(user);

     Console.WriteLine("Created a system user {0} for '{1}, {2}'", userId, _lastName, _firstName); 
 }

// </snippetcreateauser1>