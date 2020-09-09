// <snippetretrieverolesfororg1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy is properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     QueryExpression query = new QueryExpression
     {
         EntityName = Role.EntityLogicalName,
         ColumnSet = new ColumnSet("name", "roleid")

     };

     EntityCollection entities = _serviceProxy.RetrieveMultiple(query);
     // Write the name and ID of each role to the console.
     foreach (Entity item in entities.Entities)
     {
         Role role = item.ToEntity<Role>();
         Console.WriteLine("Name: {0}. Id: {1}", role.Name, role.Id);
     }
     
 }

// </snippetretrieverolesfororg1>