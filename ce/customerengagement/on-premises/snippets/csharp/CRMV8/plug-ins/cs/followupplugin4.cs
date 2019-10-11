// <snippetfollowupplugin4>


 // Obtain the organization service reference.
 IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
 IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

// </snippetfollowupplugin4>