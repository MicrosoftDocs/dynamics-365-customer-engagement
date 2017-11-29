' <snippetauthenticatewithnohelp3>


 Dim orgServiceManagement As IServiceManagement(Of IOrganizationService) =
     ServiceConfigurationFactory.CreateManagement(Of IOrganizationService)(New Uri(organizationUri))

 ' Set the credentials.
 Dim credentials As AuthenticationCredentials = GetCredentials(endpointType_renamed)

 ' Get the organization service proxy.
 Using organizationProxy As OrganizationServiceProxy =
     GetProxy(Of IOrganizationService, OrganizationServiceProxy)(orgServiceManagement, credentials)
     ' This statement is required to enable early-bound type support.
     organizationProxy.EnableProxyTypes()

     ' Now make an SDK call with the organization service proxy.
     ' Display information about the logged on user.
     Dim userid As Guid = (CType(organizationProxy.Execute(New WhoAmIRequest()), 
                           WhoAmIResponse)).UserId
     Dim systemUser_renamed As SystemUser =
         organizationProxy.Retrieve("systemuser",
                                    userid,
                                    New ColumnSet(New String() {"firstname",
                                                                "lastname"})).ToEntity(Of SystemUser)()
     Console.WriteLine("Logged on user is {0} {1}.",
                       systemUser_renamed.FirstName, systemUser_renamed.LastName)
 End Using

' </snippetauthenticatewithnohelp3>