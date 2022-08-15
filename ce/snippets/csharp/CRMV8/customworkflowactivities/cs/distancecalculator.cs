// <snippetdistancecalculator>


using System;
using System.Activities;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;

// These namespaces are found in the Microsoft.Xrm.Sdk.Workflow.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk.Workflow;

// These namespace is used to deserialize to JSON object
using Microsoft.Crm.Sdk.Samples.BingMapsRestV1;

namespace Microsoft.Crm.Sdk.Samples
{

    /// <summary>
    /// Calculates the shortest distance between two points based on their zipcodes,
    /// and returns the value.
    /// Input arguments:
    ///   "Starting Zip Code". Type: String. Is the start point.
    ///   "Ending Zip Code". Type: String. Is the end point.
    /// Output argument:
    ///   "Total Distance". Type: Double. Is the total distance measured in km.
    /// </summary>
    public sealed partial class DistanceCalculator : CodeActivity
    {
        /// <summary>
        /// Calculates the shortest distance between two points based on their zipcodes,
        /// and returns the value.
        /// </summary>
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory =
                executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service =
                serviceFactory.CreateOrganizationService(context.UserId);

            // Calculate the distance between those two points
            // based on the Zip Codes
            double distance = CalculateDistance(
                this.startingZipCode.Get(executionContext),
                this.endingZipCode.Get(executionContext));

            // Set the result in the output parameter
            this.totalDistance.Set(executionContext, distance);
        }

        /// <summary>
        /// Calculates the shortest distance between two points based on their zipcodes,
        /// and returns the value.
        /// </summary> 
        private double CalculateDistance(string startPoint, string endPoint)
        {
            double distance = 0.0;

            // Required start and end waypoint parameters (location string 
            // or a pair of latitude and longitude coordinates). 
            string fromAddress = startPoint;
            string toAddress = endPoint;

            // Optional route calculation parameters: 
            // Optimize route for the shortest distance. 
            string optimize = "distance";

            // Driving travel mode: driving/walking/transit
            string travelMode = "driving";

            // Measure distance: km/mi
            string distanceUnit = "km";

            // User needs to put here his/her Bing Maps Key 
            string BingMapsKey = "Au9tmAwIDZ2XAQVedm85L51EujHtSfgvdFBLpLXBvH-p94kNrokavf00POMu74Xz";

            // Create a REST request for the route's details. 
            string requestUrl = "https://dev.virtualearth.net/REST/v1/Routes" +
                "?output=json" + "&amp;key=" + BingMapsKey + "&amp;wp.0=" + fromAddress +
                "&amp;wp.1=" + toAddress + "&amp;optimize=" + optimize +
                "&amp;travelMode=" + travelMode + "&amp;distanceUnit=" + distanceUnit;

            // Send the request and parse the response. 
            BingMapsRestV1.Response jsonResponse = GetJsonResponse(requestUrl);

            // Get the shortest distance
            distance = (from Route r in jsonResponse.ResourceSets[0].Resources
                        orderby r.TravelDistance ascending
                        select r.TravelDistance).First();

            return distance;
        }
        
        /// <summary>
        /// Send the request to the Bing Maps REST API 
        /// and deserialize the JSON response. 
        /// </summary> 
        private Response GetJsonResponse(string requestUrl)
        {
            HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception(String.Format(
                        "Server error (HTTP {0}: {1}).", 
                        response.StatusCode, response.StatusDescription));
                DataContractJsonSerializer jsonSerializer = 
                    new DataContractJsonSerializer(typeof(BingMapsRestV1.Response));
                object objResponse = 
                    jsonSerializer.ReadObject(response.GetResponseStream());
                BingMapsRestV1.Response jsonResponse = 
                    objResponse as BingMapsRestV1.Response;
                return jsonResponse;
            }
        }

        // Define Input/Output Arguments
        [RequiredArgument]
        [Input("Starting Zip Code")]
        public InArgument<string> startingZipCode { get; set; }

        [RequiredArgument]
        [Input("Ending Zip Code")]
        public InArgument<string> endingZipCode { get; set; }

        [Output("Total Distance")]
        public OutArgument<double> totalDistance { get; set; }
    }
}

// </snippetdistancecalculator>