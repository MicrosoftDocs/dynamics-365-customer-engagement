' <snippetauthenticatewithnohelp1>


 Dim serviceManagement As IServiceManagement(Of IDiscoveryService) =
     ServiceConfigurationFactory.CreateManagement(Of IDiscoveryService)(New Uri(_discoveryServiceAddress))
 Dim endpointType_renamed As AuthenticationProviderType = serviceManagement.AuthenticationType

 ' Set the credentials.
 Dim authCredentials As AuthenticationCredentials = GetCredentials(endpointType_renamed)


 Dim organizationUri As String = String.Empty
 ' Get the discovery service proxy.
 Using discoveryProxy As DiscoveryServiceProxy =
     GetProxy(Of IDiscoveryService, DiscoveryServiceProxy)(serviceManagement, authCredentials)
     ' Obtain organization information from the Discovery service. 
     If discoveryProxy IsNot Nothing Then
         ' Obtain information about the organizations that the system user belongs to.
         Dim orgs As OrganizationDetailCollection = DiscoverOrganizations(discoveryProxy)
         ' Obtains the Web address (Uri) of the target organization.
         organizationUri = FindOrganization(_organizationUniqueName,
                                            orgs.ToArray()).Endpoints(EndpointType.OrganizationService)

     End If
 End Using

' </snippetauthenticatewithnohelp1>