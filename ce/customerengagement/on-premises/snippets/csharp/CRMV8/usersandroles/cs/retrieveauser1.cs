// <snippetretrieveauser1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy is properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     _serviceProxy.EnableProxyTypes();

     CreateRequiredRecords();

     // Find a user using domain\username or first and last name details.
     QueryExpression userQuery = new QueryExpression
     {
         EntityName = "systemuser",
         // Retrieve all columns.
         ColumnSet = new ColumnSet(new String[] { "systemuserid", "domainname", "fullname" }),

         Criteria =
         {
             FilterOperator = LogicalOperator.Or,
             Filters =
             {   
                 new FilterExpression
                 {
                     FilterOperator = LogicalOperator.And,
                     Conditions =
                     {
                         new ConditionExpression("domainname", ConditionOperator.Equal, _domain + _userName)
                     }
                 },
                 new FilterExpression
                 {
                     FilterOperator = LogicalOperator.And,
                     Conditions = 
                     {
                         new ConditionExpression("firstname", ConditionOperator.Equal, _firstName),
                         new ConditionExpression("lastname", ConditionOperator.Equal, _lastName)
                     }
                 }
             }

         }
     };


     EntityCollection entities = _serviceProxy.RetrieveMultiple(userQuery);

     if (entities.Entities.Count > 0)
     {
         SystemUser user = entities[0].ToEntity<SystemUser>();

         // Write out some key user properties.
         Console.WriteLine("Id: {0}", user.Id);
         Console.WriteLine("DomainName: {0}", user.DomainName);
         Console.WriteLine("FullName: {0}", user.FullName);
     }
 }

// </snippetretrieveauser1>