' <snippetdiscoveryservice3>


 ' Retrieve details about a single organization discoverable via the
 ' Discovery service.
 Dim orgRequest As New RetrieveOrganizationRequest() With { _
     .UniqueName = organizations.Details(organizations.Details.Count - 1).UniqueName, _
     .AccessType = EndpointAccessType.Default, .Release = OrganizationRelease.Current}
 Dim org As RetrieveOrganizationResponse = CType(service.Execute(orgRequest), RetrieveOrganizationResponse)

' </snippetdiscoveryservice3>