// <snippetdisableorenableuser1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy is properly disposed.
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
         SetStateRequest request = new SetStateRequest() { 
             EntityMoniker = user.ToEntityReference(),
             // Sets the user to disabled.
             State = new OptionSetValue(1),
             // Required by request but always valued at -1 in this context.
             Status = new OptionSetValue(-1)
             /*
             //Sets the user to enabled.
             State = new OptionSetValue(0),
             // Required by request but always valued at -1 in this context.
             Status = new OptionSetValue(-1)    
             */
         };

         _serviceProxy.Execute(request);

         Console.WriteLine("User account is disabled.");
     }
     DeleteRequiredRecords(promptforDelete);
 }

// </snippetdisableorenableuser1>