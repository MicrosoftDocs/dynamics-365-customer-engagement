' <snippetfollowupplugin4>


 ' Obtain the organization service reference.
 Dim serviceFactory As IOrganizationServiceFactory =
     CType(serviceProvider.GetService(GetType(IOrganizationServiceFactory)), 
         IOrganizationServiceFactory)
 Dim service As IOrganizationService =
     serviceFactory.CreateOrganizationService(context.UserId)

' </snippetfollowupplugin4>