// <snippetauthenticatewithnohelp3>


 IServiceManagement<IOrganizationService> orgServiceManagement =
     ServiceConfigurationFactory.CreateManagement<IOrganizationService>(
     new Uri(organizationUri));

 // Set the credentials.
 AuthenticationCredentials credentials = GetCredentials(orgServiceManagement, endpointType);

 // Get the organization service proxy.
 using (OrganizationServiceProxy organizationProxy =
     GetProxy<IOrganizationService, OrganizationServiceProxy>(orgServiceManagement, credentials))
 {
     // This statement is required to enable early-bound type support.
     organizationProxy.EnableProxyTypes();

     // Now make an SDK call with the organization service proxy.
     // Display information about the logged on user.
     Guid userid = ((WhoAmIResponse)organizationProxy.Execute(
         new WhoAmIRequest())).UserId;
     SystemUser systemUser = organizationProxy.Retrieve("systemuser", userid,
         new ColumnSet(new string[] { "firstname", "lastname" })).ToEntity<SystemUser>();
     Console.WriteLine("Logged on user is {0} {1}.",
         systemUser.FirstName, systemUser.LastName);
 }

// </snippetauthenticatewithnohelp3>