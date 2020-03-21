// <snippetauthenticatewithnohelp4>


 private TProxy GetProxy<TService, TProxy>(
     IServiceManagement<TService> serviceManagement,
     AuthenticationCredentials authCredentials)
     where TService : class
     where TProxy : ServiceProxy<TService>
 {
     Type classType = typeof(TProxy);

     if (serviceManagement.AuthenticationType !=
         AuthenticationProviderType.ActiveDirectory)
     {
         AuthenticationCredentials tokenCredentials =
             serviceManagement.Authenticate(authCredentials);
         // Obtain discovery/organization service proxy for Federated, LiveId and OnlineFederated environments. 
         // Instantiate a new class of type using the 2 parameter constructor of type IServiceManagement and SecurityTokenResponse.
         return (TProxy)classType
             .GetConstructor(new Type[] { typeof(IServiceManagement<TService>), typeof(SecurityTokenResponse) })
             .Invoke(new object[] { serviceManagement, tokenCredentials.SecurityTokenResponse });
     }

     // Obtain discovery/organization service proxy for ActiveDirectory environment.
     // Instantiate a new class of type using the 2 parameter constructor of type IServiceManagement and ClientCredentials.
     return (TProxy)classType
         .GetConstructor(new Type[] { typeof(IServiceManagement<TService>), typeof(ClientCredentials) })
         .Invoke(new object[] { serviceManagement, authCredentials.ClientCredentials });
 }

// </snippetauthenticatewithnohelp4>