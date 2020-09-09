// <snippetauthenticatewithnohelp1>


 IServiceManagement<IDiscoveryService> serviceManagement =
             ServiceConfigurationFactory.CreateManagement<IDiscoveryService>(
             new Uri(_discoveryServiceAddress));
 AuthenticationProviderType endpointType = serviceManagement.AuthenticationType;

 // Set the credentials.
 AuthenticationCredentials authCredentials = GetCredentials(serviceManagement, endpointType);


 String organizationUri = String.Empty;
 // Get the discovery service proxy.
 using (DiscoveryServiceProxy discoveryProxy =
     GetProxy<IDiscoveryService, DiscoveryServiceProxy>(serviceManagement, authCredentials))
 {
     // Obtain organization information from the Discovery service. 
     if (discoveryProxy != null)
     {
         // Obtain information about the organizations that the system user belongs to.
         OrganizationDetailCollection orgs = DiscoverOrganizations(discoveryProxy);
         // Obtains the Web address (Uri) of the target organization.
         organizationUri = FindOrganization(_organizationUniqueName,
             orgs.ToArray()).Endpoints[EndpointType.OrganizationService];

     }
 }

// </snippetauthenticatewithnohelp1>