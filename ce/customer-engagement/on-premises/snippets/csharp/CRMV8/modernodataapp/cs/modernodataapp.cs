// <snippetmodernodataapp>


using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.Security.Authentication.Web;
using System.Net;
using System.Threading;
using System.IO;
using System.Text;

namespace ModernOdataApp
{
    /// <summary>
    /// Manages authentication with the organization web service.
    /// </summary>
    public static class CurrentEnvironment
    {
        # region Class Level Members

        private static AuthenticationContext _authenticationContext;

        // TODO Set these string values as approppriate for your app registration and organization.
        // For more information, see the SDK topic "Walkthrough: Register an app with Active Directory".
        private const string _clientID = "893262be-fbdc-4556-9325-9f863b69495b";
        public const string CrmServiceUrl = "https://my-domain.crm.dynamics.com/";

        # endregion

        // <summary>
        /// Perform any required app initialization.
        /// This is where authentication with Active Directory is performed.
        public static async Task<string> Initialize()
        {
            Uri serviceUrl = new System.Uri(CrmServiceUrl + "/XRMServices/2011/Organization.svc/web?SdkClientVersion=6.1.0000.0000");

            // Dyamics CRM Online OAuth URL.
            string _oauthUrl = DiscoveryAuthority(serviceUrl);

            // Obtain the redirect URL for the app. This is only needed for app registration.
            Uri redirectUri = WebAuthenticationBroker.GetCurrentApplicationCallbackUri();

            // Obtain an authentication token to access the web service. 
            _authenticationContext = new AuthenticationContext(_oauthUrl, false);
            AuthenticationResult result = await _authenticationContext.AcquireTokenAsync(CrmServiceUrl, _clientID, redirectUri);

            // Verify that an access token was successfully acquired.
            if (result.Status != AuthenticationStatus.Success)
            {
                if (result.Error == "authentication_failed")
                {
                    // Try again.
                    _authenticationContext = new AuthenticationContext(_oauthUrl, false);
                    result = await _authenticationContext.AcquireTokenAsync(CrmServiceUrl, _clientID, redirectUri);
                }
                else
                {
                    DisplayErrorWhenAcquireTokenFails(result);
                }
            }
            return result.AccessToken;
        }

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

        /// <summary>
        /// Returns a response from an Internet resource. 
        /// </summary>       
        public static WebResponse GetResponse(this WebRequest request)
        {
            AutoResetEvent autoResetEvent = new AutoResetEvent(false);
            IAsyncResult asyncResult = request.BeginGetResponse(r => autoResetEvent.Set(), null);

            // Wait until the call is finished
            autoResetEvent.WaitOne(DefaultRequestTimeout);
            return request.EndGetResponse(asyncResult);
        }

        /// <summary>
        /// Get the DefaultRequestTimeout from the server.
        /// </summary>
        public static TimeSpan DefaultRequestTimeout { get; set; }

        /// <summary>
        /// Display an error message to the user.
        /// </summary>
        /// <param name="result">The authentication result returned from AcquireTokenAsync().</param>
        private static async void DisplayErrorWhenAcquireTokenFails(AuthenticationResult result)
        {
            MessageDialog dialog;

            switch (result.Error)
            {
                case "authentication_canceled":
                    // User cancelled, so no need to display a message.
                    break;
                case "temporarily_unavailable":
                case "server_error":
                    dialog = new MessageDialog("Please retry the operation. If the error continues, please contact your administrator.",
                        "Sorry, an error has occurred.");
                    await dialog.ShowAsync();
                    break;
                default:
                    // An error occurred when acquiring a token so show the error description in a MessageDialog.
                    dialog = new MessageDialog(string.Format(
                        "If the error continues, please contact your administrator.\n\nError: {0}\n\nError Description:\n\n{1}",
                        result.Error, result.ErrorDescription), "Sorry, an error has occurred.");
                    await dialog.ShowAsync();
                    break;
            }
        }
    }
}

// </snippetmodernodataapp>