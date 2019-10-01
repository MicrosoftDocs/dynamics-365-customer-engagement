// <snippetmodernodataapp2>


using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ModernOdataApp
{
    public static class HttpRequestBuilder
    {
        /// <summary>
        /// Retrieve entity record data from the organization web service. 
        /// </summary>
        /// <param name="accessToken">The web service authentication access token.</param>
        /// <param name="Columns">The entity attributes to retrieve.</param>
        /// <param name="entity">The target entity for which the data should be retreived.</param>
        /// <returns>Response from the web service.</returns>
        /// <remarks>Builds an OData HTTP request using passed parameters and sends the request to the server.</remarks>
        public static async Task<string> Retrieve(string accessToken, string[] Columns, string entity)
        {
            // Build a list of entity attributes to retrieve as a string.
            string columnsSet = "";
            foreach (string Column in Columns)
            {
                columnsSet += "," + Column;
            }

            // The URL for the OData organization web service.
            string url = CurrentEnvironment.CrmServiceUrl + "/XRMServices/2011/OrganizationData.svc/" + entity + "?$select=" + columnsSet.Remove(0, 1) + "";

            // Build and send the HTTP request.
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, url);
            req.Method = HttpMethod.Get;

            // Wait for the web service response.
            HttpResponseMessage response;
            response = await httpClient.SendAsync(req);
            var responseBodyAsText = await response.Content.ReadAsStringAsync();

            return responseBodyAsText;
        }
    }
}

// </snippetmodernodataapp2>