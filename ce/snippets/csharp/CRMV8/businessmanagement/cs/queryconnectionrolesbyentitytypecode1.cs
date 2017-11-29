// <snippetqueryconnectionrolesbyentitytypecode1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     // Define some anonymous types to define the range 
     // of possible connection property values.
     var Categories = new
     {
         Business = 1,
         Family = 2,
         Social = 3,
         Sales = 4,
         Other = 5
     };

     // Create a Connection Role.
     ConnectionRole setupConnectionRole = new ConnectionRole
     {
         Name = "Example Connection Role",
         Category = new OptionSetValue(Categories.Business),
     };

     _connectionRoleId = _serviceProxy.Create(setupConnectionRole);
     setupConnectionRole.Id = _connectionRoleId;

     Console.WriteLine("Created {0}.", setupConnectionRole.Name);

     // Query for all Connection Roles.
     QueryExpression allQuery = new QueryExpression
     {
         EntityName = ConnectionRole.EntityLogicalName,
         ColumnSet = new ColumnSet("connectionroleid", "name"),
         Distinct = true,
         LinkEntities = 
         {
             new LinkEntity
             {
                 LinkToEntityName = 
                 ConnectionRoleObjectTypeCode.EntityLogicalName,
                 LinkToAttributeName = "connectionroleid",
                 LinkFromEntityName = ConnectionRole.EntityLogicalName,
                 LinkFromAttributeName = "connectionroleid",
                 LinkCriteria = new FilterExpression
                 {
                     FilterOperator = LogicalOperator.And,
                     // Set a condition to only get connection roles  
                     // related to all entities (object type code = 0).
                     Conditions = 
                     {
                         new ConditionExpression 
                         {
                              AttributeName = "associatedobjecttypecode",
                              Operator = ConditionOperator.Equal,
                              Values = { 0 }
                         }
                     }
                 }
             }
         }
     };

     EntityCollection results = _serviceProxy.RetrieveMultiple(allQuery);

     // Here you could perform operations on all of 
     // the connectionroles found by the query.

     Console.WriteLine("Retrieved {0} unassociated connectionrole instance(s).",
         results.Entities.Count);

     // Query to find roles which apply only to accounts.
     QueryExpression accountQuery = new QueryExpression
     {
         EntityName = ConnectionRole.EntityLogicalName,
         ColumnSet = new ColumnSet("connectionroleid", "name"),
         Distinct = true,
         LinkEntities = 
         {
             new LinkEntity
             {
                 LinkToEntityName = 
                 ConnectionRoleObjectTypeCode.EntityLogicalName,
                 LinkToAttributeName = "connectionroleid",
                 LinkFromEntityName = ConnectionRole.EntityLogicalName,
                 LinkFromAttributeName = "connectionroleid",
                 LinkCriteria = new FilterExpression
                 {
                     FilterOperator = LogicalOperator.And,
                     // Set a condition to only get connection roles  
                     // related to accounts (object type code = 1).
                     Conditions = 
                     {
                         new ConditionExpression 
                         {
                              AttributeName = "associatedobjecttypecode",
                              Operator = ConditionOperator.In,
                              Values = { Account.EntityLogicalName }
                         }
                     }
                 }
             }
         }
     };

     results = _serviceProxy.RetrieveMultiple(accountQuery);

     Console.WriteLine("Retrieved {0} account-only connectionrole instance(s).",
         results.Entities.Count);

     // Create a related Connection Role Object Type Code record for 
     // Account.
     ConnectionRoleObjectTypeCode setupAccountConnectionRoleTypeCode
         = new ConnectionRoleObjectTypeCode
         {
             ConnectionRoleId = new EntityReference(
                 ConnectionRole.EntityLogicalName, _connectionRoleId),
             AssociatedObjectTypeCode = Account.EntityLogicalName
         };

     setupAccountConnectionRoleTypeCode.Id = 
         _serviceProxy.Create(setupAccountConnectionRoleTypeCode);

     Console.Write("Created a related Connection Role Object Type Code");
     Console.Write(" record for Account.");

     // Run the query to find unassociated connectionroles again.
     results = _serviceProxy.RetrieveMultiple(allQuery);
     
     Console.WriteLine(@"Retrieved {0} unassociated connectionrole instance(s).",
         results.Entities.Count);

     // Run the account-only query again.
     results = _serviceProxy.RetrieveMultiple(accountQuery);

     Console.WriteLine("Retrieved {0} account-only connectionrole instance(s).",
         results.Entities.Count);

     // Remove the link from account entity.
     _serviceProxy.Delete(ConnectionRoleObjectTypeCode.EntityLogicalName, 
         setupAccountConnectionRoleTypeCode.Id);

     Console.WriteLine("Removed link from connectionrole to account entity.");

     // Run the query to find unassociated connectionroles again.
     results = _serviceProxy.RetrieveMultiple(allQuery);

     Console.WriteLine("Retrieved {0} unassociated connectionrole instance(s).",
         results.Entities.Count);

     // Run the account-only query again.
     results = _serviceProxy.RetrieveMultiple(accountQuery);

     Console.WriteLine("Retrieved {0} account-only connectionrole instance(s).",
         results.Entities.Count);

     DeleteRequiredRecords(promptForDelete);
 }

// </snippetqueryconnectionrolesbyentitytypecode1>