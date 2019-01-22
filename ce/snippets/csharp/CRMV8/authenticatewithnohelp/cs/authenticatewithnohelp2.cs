// <snippetauthenticatewithnohelp2>


 /// <summary>
 /// Obtain the AuthenticationCredentials based on AuthenticationProviderType.
 /// </summary>
 /// <param name="service">A service management object.</param>
 /// <param name="endpointType">An AuthenticationProviderType of the CRM environment.</param>
 /// <returns>Get filled credentials.</returns>
 private AuthenticationCredentials GetCredentials<TService>(IServiceManagement<TService> service, AuthenticationProviderType endpointType)
 {
     AuthenticationCredentials authCredentials = new AuthenticationCredentials();

     switch (endpointType)
     {
         case AuthenticationProviderType.ActiveDirectory:
             authCredentials.ClientCredentials.Windows.ClientCredential =
                 new System.Net.NetworkCredential(_userName,
                     _password,
                     _domain);
             break;
         case AuthenticationProviderType.LiveId:
             authCredentials.ClientCredentials.UserName.UserName = _userName;
             authCredentials.ClientCredentials.UserName.Password = _password;
             authCredentials.SupportingCredentials = new AuthenticationCredentials();
             authCredentials.SupportingCredentials.ClientCredentials =
                 Microsoft.Crm.Services.Utility.DeviceIdManager.LoadOrRegisterDevice();
             break;
         default: // For Federated and OnlineFederated environments.                    
             authCredentials.ClientCredentials.UserName.UserName = _userName;
             authCredentials.ClientCredentials.UserName.Password = _password;
             // For OnlineFederated single-sign on, you could just use current UserPrincipalName instead of passing user name and password.
             // authCredentials.UserPrincipalName = UserPrincipal.Current.UserPrincipalName;  // Windows Kerberos

             // The service is configured for User Id authentication, but the user might provide Microsoft
             // account credentials. If so, the supporting credentials must contain the device credentials.
             if (endpointType == AuthenticationProviderType.OnlineFederation)
             {
                 IdentityProvider provider = service.GetIdentityProvider(authCredentials.ClientCredentials.UserName.UserName);
                 if (provider != null && provider.IdentityProviderType == IdentityProviderType.LiveId)
                 {
                     authCredentials.SupportingCredentials = new AuthenticationCredentials();
                     authCredentials.SupportingCredentials.ClientCredentials =
                         Microsoft.Crm.Services.Utility.DeviceIdManager.LoadOrRegisterDevice();
                 }
             }

             break;
     }

     return authCredentials;
 }

// </snippetauthenticatewithnohelp2>