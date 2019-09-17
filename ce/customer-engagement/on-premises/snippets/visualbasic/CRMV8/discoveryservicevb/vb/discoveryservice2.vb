' <snippetdiscoveryservice2>


 ' Retrieve details about all organizations discoverable via the
 ' Discovery service.
 Dim orgsRequest As New RetrieveOrganizationsRequest() With { _
     .AccessType = EndpointAccessType.Default, .Release = OrganizationRelease.Current}
 Dim organizations As RetrieveOrganizationsResponse = _
     CType(service.Execute(orgsRequest), RetrieveOrganizationsResponse)

' </snippetdiscoveryservice2>