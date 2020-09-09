// <snippetmodernodataappauthdiscovery>


 /// <summary>
 /// Discover the authentication authority.
 /// </summary>
 /// <param name="serviceUrl">The URL of the organization's SOAP endpoint. </param>
 /// <returns>The authority URL.</returns>
 /// <remarks>The service URL must contain the SdkClient property.</remarks>
 /// <example>https://contoso.crm.dynamics.com/XRMServices/2011/Organization.svc/web?SdkClientVersion=6.1.0.533;</example>
 public static string DiscoveryAuthority(Uri serviceUrl)
 {
     // Use AuthenticationParameters to send a request to the organization's endpoint and
     // receive tenant information in the 401 challenge. 
     Microsoft.IdentityModel.Clients.ActiveDirectory.AuthenticationParameters parameters = null;
     HttpWebResponse response = null;
     try
     {
         // Create a web request where the authorization header contains the word "Bearer".
         HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(serviceUrl);

         // The response is to be encoded.
         httpWebRequest.ContentType = "application/x-www-form-urlencoded";
         response = (HttpWebResponse)httpWebRequest.GetResponse();
     }

     catch (WebException ex)
     {
         response = (HttpWebResponse)ex.Response;

         // A 401 error should be returned. Extract any parameters from the response.
         // The response should contain an authorization_uri parameter.
         parameters = Microsoft.IdentityModel.Clients.ActiveDirectory.AuthenticationParameters.
             CreateFromResponseAuthenticateHeader((response.Headers)["WWW-Authenticate"]);
     }
     finally
     {
         if (response != null)
             response.Dispose();
     }
     // Return the authority URL.
     return parameters.Authority;
 }

// </snippetmodernodataappauthdiscovery>