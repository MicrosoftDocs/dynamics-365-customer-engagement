// <snippetdiscoveryservice3>


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

// </snippetdiscoveryservice3>