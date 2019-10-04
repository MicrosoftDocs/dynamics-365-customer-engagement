' <snippetdiscoveryservice1>


                ' Connect to the Discovery service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = New DiscoveryServiceProxy(serverConfig.DiscoveryUri, serverConfig.HomeRealmUri, _
                                                          serverConfig.Credentials, serverConfig.DeviceCredentials)
                Using _serviceProxy
                    ' You can choose to use the interface instead of the proxy.
                    Dim service As IDiscoveryService = _serviceProxy

'                    #Region "RetrieveOrganizations Message"

                    ' Retrieve details about all organizations discoverable via the
                    ' Discovery service.
                    Dim orgsRequest As New RetrieveOrganizationsRequest() With { _
                        .AccessType = EndpointAccessType.Default, .Release = OrganizationRelease.Current}
                    Dim organizations As RetrieveOrganizationsResponse = _
                        CType(service.Execute(orgsRequest), RetrieveOrganizationsResponse)

                    ' Print each organization's friendly name, unique name and URLs
                    ' for each of its endpoints.
                    Console.WriteLine()
                    Console.WriteLine("Retrieving details of each organization:")
                    For Each organization As OrganizationDetail In organizations.Details
                        Console.WriteLine("Organization Name: {0}", organization.FriendlyName)
                        Console.WriteLine("Unique Name: {0}", organization.UniqueName)
                        Console.WriteLine("Endpoints:")
                        For Each endpoint In organization.Endpoints
                            Console.WriteLine("  Name: {0}", endpoint.Key)
                            Console.WriteLine("  URL: {0}", endpoint.Value)
                        Next endpoint
                    Next organization
                    Console.WriteLine("End of listing")
                    Console.WriteLine()

'                    #End Region ' RetrieveOrganizations Message

'                    #Region "RetrieveOrganization Message"

                    ' Retrieve details about a single organization discoverable via the
                    ' Discovery service.
                    Dim orgRequest As New RetrieveOrganizationRequest() With { _
                        .UniqueName = organizations.Details(organizations.Details.Count - 1).UniqueName, _
                        .AccessType = EndpointAccessType.Default, .Release = OrganizationRelease.Current}
                    Dim org As RetrieveOrganizationResponse = CType(service.Execute(orgRequest), RetrieveOrganizationResponse)

                    ' Print the organization's friendly name, unique name and URLs
                    ' for each of its endpoints.
                    Console.WriteLine()
                    Console.WriteLine("Retrieving details of specific organization:")
                    Console.WriteLine("Organization Name: {0}", org.Detail.FriendlyName)
                    Console.WriteLine("Unique Name: {0}", org.Detail.UniqueName)
                    Console.WriteLine("Endpoints:")
                    For Each endpoint As KeyValuePair(Of EndpointType, String) In org.Detail.Endpoints
                        Console.WriteLine("  Name: {0}", endpoint.Key)
                        Console.WriteLine("  URL: {0}", endpoint.Value)
                    Next endpoint
                    Console.WriteLine("End of listing")
                    Console.WriteLine()

'                    #End Region ' RetrieveOrganization Message

                End Using

' </snippetdiscoveryservice1>