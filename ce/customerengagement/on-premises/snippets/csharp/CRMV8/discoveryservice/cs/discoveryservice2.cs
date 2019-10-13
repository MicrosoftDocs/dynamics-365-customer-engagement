// <snippetdiscoveryservice2>


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

// </snippetdiscoveryservice2>