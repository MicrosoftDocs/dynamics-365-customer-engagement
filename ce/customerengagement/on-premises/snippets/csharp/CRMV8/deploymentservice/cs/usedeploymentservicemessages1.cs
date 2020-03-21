// <snippetusedeploymentservicemessages1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     // Instantiate DeploymentServiceClient for calling the service.
     DeploymentServiceClient serviceClient = 
         Deployment.Proxy.ProxyClientHelper.CreateClient(
         new Uri(serverConfig.DiscoveryUri.ToString()
             .Replace("Services", "Deployment")
             .Replace("Discovery", "Deployment")));

     // Setting credentials from the current security context. 
     if (serverConfig.Credentials == null)
     {
         serviceClient.ClientCredentials.Windows.ClientCredential =
             CredentialCache.DefaultNetworkCredentials; 
     }
     else
     {
         serviceClient.ClientCredentials.Windows.ClientCredential =
             serverConfig.Credentials.Windows.ClientCredential;
     }

     // Retrieve all deployed instances of Microsoft Dynamics CRM.
     var organizations =
         serviceClient.RetrieveAll(DeploymentEntityType.Organization);

     // Print list of all retrieved organizations.
     Console.WriteLine("Organizations in your deployment");
     Console.WriteLine("================================");
     foreach (var organization in organizations)
     {
         Console.WriteLine(organization.Name);
     }
     Console.WriteLine("<End of Listing>");
     Console.WriteLine();


     // Retrieve details of first organization from previous call.
     Deployment.Organization deployment =
         (Deployment.Organization)serviceClient.Retrieve(
             DeploymentEntityType.Organization,
             organizations[0]);

     // Print out retrieved details about your organization.
     Console.WriteLine(String.Format(
         "Selected deployment details for {0}",
         serverConfig.OrganizationName));
     Console.WriteLine("=========================================");
     Console.Write("Friendly Name: ");
     Console.WriteLine(deployment.FriendlyName);
     Console.Write("Unique Name: ");
     Console.WriteLine(deployment.UniqueName);
     Console.Write("Organization Version: ");
     Console.WriteLine(deployment.Version);
     Console.Write("SQL Server Name: ");
     Console.WriteLine(deployment.SqlServerName);
     Console.Write("SRS URL: ");
     Console.WriteLine(deployment.SrsUrl);
     Console.WriteLine("<End of Listing>");
     Console.WriteLine();

     // Retrieve license and user information for your organization.
     TrackLicenseRequest licenseRequest = new TrackLicenseRequest();
     TrackLicenseResponse licenseResponse =
         (TrackLicenseResponse)serviceClient.Execute(licenseRequest);

     // Print out the number of servers and the user list.
     Console.WriteLine(String.Format(
         "License and user information for {0}",
         serverConfig.OrganizationName));
     Console.WriteLine("=========================================");
     Console.Write("Number of servers: ");
     Console.WriteLine(licenseResponse.Servers != null
         ? licenseResponse.Servers.Count.ToString()
         : "null");
     Console.WriteLine("Users:");
     foreach (OrganizationUserInfo user in licenseResponse.Users.ToArray())
     {
         Console.WriteLine(user.FullName);
     }
     Console.WriteLine("<End of Listing>");
     Console.WriteLine();

     // Retrieve advanced settings for your organization.
     // Note that the columnset must contain at least one column. Setting
     // AllColumns to true results in an error.
     RetrieveAdvancedSettingsRequest request =
         new RetrieveAdvancedSettingsRequest
         {
             ConfigurationEntityName = "Server",
             ColumnSet = new ColumnSet(
                 new string[] { "Id", "FullName", "Name", "Roles", "State", "Version" })
         };
     ConfigurationEntity configuration =
         ((RetrieveAdvancedSettingsResponse)serviceClient.Execute(request)).Entity;

     // Print out all advanced settings where IsWritable==true.
     Console.WriteLine("Advanced deployment settings that can be updated");
     Console.WriteLine("================================================");
     foreach (var setting in configuration.Attributes)
     {
         if (setting.Key != "Id")
         {
             Console.WriteLine(
                 String.Format("{0}: {1}",
                     setting.Key,
                     setting.Value));
         }
     }
     Console.WriteLine("<End of Listing>");
     Console.WriteLine();

 }

// </snippetusedeploymentservicemessages1>