// <snippetdiscoveryservice1>


 // Connect to the Discovery service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new DiscoveryServiceProxy(serverConfig.DiscoveryUri,
                                                     serverConfig.HomeRealmUri,
                                                     serverConfig.Credentials,
                                                     serverConfig.DeviceCredentials))
 {
     // You can choose to use the interface instead of the proxy.
     IDiscoveryService service = _serviceProxy;

     #region RetrieveOrganizations Message

     // Retrieve details about all organizations discoverable via the
     // Discovery service.
     RetrieveOrganizationsRequest orgsRequest =
         new RetrieveOrganizationsRequest()
         {
             AccessType = EndpointAccessType.Default,
             Release = OrganizationRelease.Current
         };
     RetrieveOrganizationsResponse organizations =
         (RetrieveOrganizationsResponse)service.Execute(orgsRequest);

     // Print each organization's friendly name, unique name and URLs
     // for each of its endpoints.
     Console.WriteLine();
     Console.WriteLine("Retrieving details of each organization:");
     foreach (OrganizationDetail organization in organizations.Details)
     {
         Console.WriteLine("Organization Name: {0}", organization.FriendlyName);
         Console.WriteLine("Unique Name: {0}", organization.UniqueName);
         Console.WriteLine("Endpoints:");
         foreach (var endpoint in organization.Endpoints)
         {
             Console.WriteLine("  Name: {0}", endpoint.Key);
             Console.WriteLine("  URL: {0}", endpoint.Value);
         }
     }
     Console.WriteLine("End of listing");
     Console.WriteLine();

     #endregion RetrieveOrganizations Message

     #region RetrieveOrganization Message

     // Retrieve details about a single organization discoverable via the Discovery service.
     //
     RetrieveOrganizationRequest orgRequest =
         new RetrieveOrganizationRequest()
         {
             UniqueName = organizations.Details[organizations.Details.Count -1].UniqueName,
             AccessType = EndpointAccessType.Default,
             Release = OrganizationRelease.Current
         };
     RetrieveOrganizationResponse org =
         (RetrieveOrganizationResponse)service.Execute(orgRequest);

     // Print the organization's friendly name, unique name and URLs
     // for each of its endpoints.
     Console.WriteLine();
     Console.WriteLine("Retrieving details of specific organization:");
     Console.WriteLine("Organization Name: {0}", org.Detail.FriendlyName);
     Console.WriteLine("Unique Name: {0}", org.Detail.UniqueName);
     Console.WriteLine("Endpoints:");
     foreach (KeyValuePair<EndpointType, string> endpoint in org.Detail.Endpoints)
     {
         Console.WriteLine("  Name: {0}", endpoint.Key);
         Console.WriteLine("  URL: {0}", endpoint.Value);
     }
     Console.WriteLine("End of listing");
     Console.WriteLine();

     #endregion RetrieveOrganization Message

 }

// </snippetdiscoveryservice1>