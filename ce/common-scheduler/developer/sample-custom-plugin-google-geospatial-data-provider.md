---
title: "Sample: Custom plug-in to use Google Maps API as geospatial data provider | MicrosoftDocs"
description: "Provides information on how to create a  geospatial data providers other than the default Bing Maps in Dynamics 365 for Field Service and Dynamics 365 for Project Service."
ms.custom: ""
ms.date: 01/05/2018
searchScope:
  - Field Service
  - Project Service
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.technology: 
  - "field-service"
  - "project-service"
ms.tgt_pltfrm: ""
ms.topic: "sample"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 1773e012-dbad-4320-95fe-40877adfdabb
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Sample: Custom plug-in to use Google Maps API as geospatial data provider

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

You can use a custom plug-in to use geospatial data from a data provider of your choice instead of using the default Bing Maps API in Field Service and Project Service.

Download the sample: [TODO: Add the download location from https://code.msdn.microsoft.com]

## Prerequisites

Internet connection is required to download the sample project and to restore the NuGet packages used in the sample project.

## Requirements

- [!INCLUDE[pn_dyn_365_field_service](../../includes/pn-dyn-365-field-service.md)] solution must be installed on your [!INCLUDE[pn_dynamics_365](../../includes/pn-dynamics-365.md)] (online) instance. More information: [Install and setup Field Service](../../field-service/install-field-service.md) 
- Provide your own Google API key in the **GoogleDataContracts.cs** file in the sample:

    `public const string GoogleApiKey = "<PROVIDE YOUR GOOGLE API KEY";` 

## Demonstrates

This sample shows how to create a custom plug-in for the **msdyn_GeocodeAddress** and **msdyn_RetrieveDistanceMatrix** actions in Field Service to use Google Maps API for geospatial data instead of using the default Bing Maps API.

## After running the sample

After you have succesfully run (build) the sample, a custom plug-in assembly file, **CustomPlugin-FS-Geospatial.dll**, will become available in the `<Project>\bin\debug` folder. You must register the sample custom plug-in assembly on your [!INCLUDE[pn_dynamics_365](../../includes/pn-dynamics-365.md)] (online) instance to be able to use the plug-in to use the Google Maps API instead of the default Bing Maps API. More information: [Register and deploy your custom plug-in](register-deploy-custom-plugin-preferred-geospatial-data-provider.md#register-and-deploy-your-custom-plug-in) 

## Plug-in sample code for msdyn_GeocodeAddress action

```csharp
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using Microsoft.Crm.Sdk.Samples.GoogleDataContracts;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{

    /// <summary>
    /// msdyn_GeocodeAddress Plugin.
    /// </summary>    
    public class msdyn_GeocodeAddress : PluginBase
    {
        const string PluginStatusCodeKey = "PluginStatus";
        const string Address1Key = "Line1";
        const string CityKey = "City";
        const string StateKey = "StateOrProvince";
        const string PostalCodeKey = "PostalCode";
        const string CountryKey = "Country";
        const string LatitudeKey = "Latitude";
        const string LongitudeKey = "Longitude";
        const string LcidKey = "Lcid";

        /// <summary>
        /// Initializes a new instance of the <see cref="msdyn_GeocodeAddress"/> class.
        /// </summary>
        /// <param name="unsecure">Contains public (unsecured) configuration information.</param>
        /// <param name="secure">Contains non-public (secured) configuration information. 
        /// When using Microsoft Dynamics 365 for Outlook with Offline Access, 
        /// the secure string is not passed to a plug-in that executes while the client is offline.</param>
        public msdyn_GeocodeAddress(string unsecure, string secure)
            : base(typeof(msdyn_GeocodeAddress))
        {

            // TODO: Implement your custom configuration handling.
        }


        /// <summary>
        /// Main entry point: Google Geocoding plugin for Field Service
        /// </summary>
        /// <param name="localContext">The <see cref="LocalPluginContext"/> which contains the
        /// <see cref="IPluginExecutionContext"/>,
        /// <see cref="IOrganizationService"/>
        /// and <see cref="ITracingService"/>
        /// </param>
        /// <remarks>
        /// For improved performance, Microsoft Dynamics 365 caches plug-in instances.
        /// The plug-in's Execute method should be written to be stateless as the constructor
        /// is not called for every invocation of the plug-in. Also, multiple system threads
        /// could execute the plug-in at the same time. All per invocation state information
        /// is stored in the context. This means that you should not use global variables in plug-ins.
        /// </remarks>
        protected override void ExecuteCrmPlugin(LocalPluginContext localContext)
        {
            // This is the CRM runtime entrypoint
            if (localContext == null) throw new InvalidPluginExecutionException("localContext");
            // Call the common entry point that also works for testing outside of CRM
            ExecuteGeocodeAddress(localContext, localContext.PluginExecutionContext.InputParameters, localContext.PluginExecutionContext.OutputParameters, localContext.PluginExecutionContext.SharedVariables);
        }

        /// <summary>
        /// Retrieve geocode address using Google Api
        /// </summary>
        /// <param name="InputParameters">Contains 5 fields (string) for individual parts of an address</param>
        /// <param name="OutputParameters">Contains 2 fields (double) for resultant geolocation</param>
        /// <param name="SharedVariables">Contains 1 field (int) for status of previous and this plugin</param>
        public void ExecuteGeocodeAddress(LocalPluginContext localContext, ParameterCollection InputParameters, ParameterCollection OutputParameters, ParameterCollection SharedVariables)
        {
            localContext.Trace($"{nameof(msdyn_GeocodeAddress)} started. InputParameters = {InputParameters.Count().ToString()}, OutputParameters = {OutputParameters.Count().ToString()}");

            try
            {
                // If a plugin earlier in the pipeline has already geocoded successfully, quit 
                if ((double)OutputParameters[LatitudeKey] != 0d || (double)OutputParameters[LongitudeKey] != 0d) return;

                // Get user Lcid if request did not include it
                int Lcid = (int)InputParameters[LcidKey];
                string _address = string.Empty;
                if (Lcid == 0)
                {
                    var userSettingsQuery = new QueryExpression("usersettings");
                    userSettingsQuery.ColumnSet.AddColumns("uilanguageid", "systemuserid");
                    userSettingsQuery.Criteria.AddCondition("systemuserid", ConditionOperator.Equal, localContext.PluginExecutionContext.InitiatingUserId);
                    var userSettings = localContext.OrganizationService.RetrieveMultiple(userSettingsQuery);
                    if (userSettings.Entities.Count > 0)
                        Lcid = (int)userSettings.Entities[0]["uilanguageid"];
                }

                // Arrange the address components in a single comma-separated string, according to LCID
                _address = GisUtility.FormatInternationalAddress(Lcid,
                    (string)InputParameters[Address1Key], (string)InputParameters[PostalCodeKey], (string)InputParameters[CityKey], (string)InputParameters[StateKey], (string)InputParameters[CountryKey]);

                // Make Geocoding call to Google API
                WebClient client = new WebClient();
                var url = $"https://{GoogleConstants.GoogleApiServer}{GoogleConstants.GoogleGeocodePath}/json?address={_address}&key={GoogleConstants.GoogleApiKey}";
                localContext.Trace($"Calling {url}\n");
                string response = client.DownloadString(url);   // Post ...

                localContext.Trace("Parsing response ...\n");
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(GeocodeResponse));    // Deserialize response json
                object objResponse = jsonSerializer.ReadObject(new MemoryStream(Encoding.UTF8.GetBytes(response)));     // Get response as an object
                GeocodeResponse geocodeResponse = objResponse as GeocodeResponse;       // Unbox into our data contracted class for response

                localContext.Trace("Response Status = " + geocodeResponse.Status + "\n");
                if (geocodeResponse.Status != "OK")
                    throw new ApplicationException($"Server {GoogleConstants.GoogleApiServer} application error (Status {geocodeResponse.Status}).");

                localContext.Trace("Checking geocodeResponse.Result...\n");
                if (geocodeResponse.Results != null)
                {
                    if (geocodeResponse.Results.Count() == 1)
                    {
                        localContext.Trace("Checking geocodeResponse.Result.Geometry.Location...\n");
                        if (geocodeResponse.Results.First()?.Geometry?.Location != null)
                        {
                            localContext.Trace("Setting Latitude, Longitude in OutputParameters...\n");

                            // update output parameters
                            OutputParameters[LatitudeKey] = geocodeResponse.Results.First().Geometry.Location.Lat;
                            OutputParameters[LongitudeKey] = geocodeResponse.Results.First().Geometry.Location.Lng;

                        }
                        else throw new ApplicationException($"Server {GoogleConstants.GoogleApiServer} application error (missing Results[0].Geometry.Location)");
                    }
                    else throw new ApplicationException($"Server {GoogleConstants.GoogleApiServer} application error (more than 1 result returned)");
                }
                else throw new ApplicationException($"Server {GoogleConstants.GoogleApiServer} application error (missing Results)");
            }
            catch (Exception ex)
            {
                // Signal to subsequent plugins in this message pipeline that geocoding failed here.
                OutputParameters[LatitudeKey] = 0d;
                OutputParameters[LongitudeKey] = 0d;

                //TODO: You may need to decide which caught exceptions will rethrow and which ones will simply signal geocoding did not complete.
                throw new InvalidPluginExecutionException(string.Format("Geocoding failed at {0} with exception -- {1}: {2}"
                    , GoogleConstants.GoogleApiServer, ex.GetType().ToString(), ex.Message), ex);
            }

            // For debugging purposes, throw an exception to see the details of the parameters
            //CreateExceptionWithDetails("Debugging...", InputParameters, OutputParameters, SharedVariables);
        }

        private void CreateExceptionWithDetails(string message, ParameterCollection inputs, ParameterCollection outputs, ParameterCollection shareds)
        {
            StringBuilder sb = new StringBuilder(message + "\n");
            sb.AppendLine("InputParameters -- ");
            foreach (var item in inputs) sb.AppendLine(item.Key + " : '" + item.Value + "' ");
            sb.AppendLine("OutputParameters -- ");
            foreach (var item in outputs) sb.AppendLine(item.Key + " : '" + item.Value + "' ");
            sb.AppendLine("SharedVariables -- ");
            foreach (var item in shareds) sb.AppendLine(item.Key + " : '" + item.Value + "' ");
            throw new InvalidPluginExecutionException(sb.ToString());
        }
    }
}
```

## Plug-in sample code for msdyn_RetrieveDistanceMatrix action

```csharp
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using Microsoft.Crm.Sdk.Samples.GoogleDataContracts;
using Microsoft.Xrm.Sdk;
using static Microsoft.Crm.Sdk.Samples.GoogleDataContracts.DistanceMatrixResponse.CResult.CElement;

namespace Microsoft.Crm.Sdk.Samples
{

    /// <summary>
    /// msdyn_RetrieveDistanceMatrix Plugin.
    /// </summary>    
    public class msdyn_RetrieveDistanceMatrix : PluginBase
    {
        const string PluginStatusCodeKey = "PluginStatus";
        const string SourcesKey = "Sources";
        const string TargetsKey = "Targets";
        const string MatrixKey = "Result";

        /// <summary>
        /// Initializes a new instance of the <see cref="msdyn_RetrieveDistanceMatrix"/> class.
        /// </summary>
        /// <param name="unsecure">Contains public (unsecured) configuration information.</param>
        /// <param name="secure">Contains non-public (secured) configuration information. 
        /// When using Microsoft Dynamics 365 for Outlook with Offline Access, 
        /// the secure string is not passed to a plug-in that executes while the client is offline.</param>
        public msdyn_RetrieveDistanceMatrix(string unsecure, string secure)
            : base(typeof(msdyn_RetrieveDistanceMatrix))
        {
            // TODO: Implement your custom configuration handling.
        }


        /// <summary>
        /// Main entry point: Customer-implemented Google Distance Matrix plugin for Field Service
        /// </summary>
        /// <param name="localContext">The <see cref="LocalPluginContext"/> which contains the
        /// <see cref="IPluginExecutionContext"/>,
        /// <see cref="IOrganizationService"/>
        /// and <see cref="ITracingService"/>
        /// </param>
        /// <remarks>
        /// For improved performance, Microsoft Dynamics 365 caches plug-in instances.
        /// The plug-in's Execute method should be written to be stateless as the constructor
        /// is not called for every invocation of the plug-in. Also, multiple system threads
        /// could execute the plug-in at the same time. All per invocation state information
        /// is stored in the context. This means that you should not use global variables in plug-ins.
        /// </remarks>
        protected override void ExecuteCrmPlugin(LocalPluginContext localContext)
        {
            // This is the CRM runtime entrypoint
            if (localContext == null) throw new InvalidPluginExecutionException("localContext");
            // Call the common entry point that also works for testing outside of CRM
            ExecuteDistanceMatrix(localContext, localContext.PluginExecutionContext.InputParameters, localContext.PluginExecutionContext.OutputParameters, localContext.PluginExecutionContext.SharedVariables);
        }

        /// <summary>
        /// Retrieve distance matrix using Google Api
        /// </summary>
        /// <param name="InputParameters">Contains 2 fields (EntityCollection) for sources and targets</param>
        /// <param name="OutputParameters">Contains 1 field (EntityCollection) for results</param>
        /// <param name="SharedVariables">Contains 1 field (int) for status of previous and this plugin</param>
        public void ExecuteDistanceMatrix(LocalPluginContext localContext, ParameterCollection InputParameters, ParameterCollection OutputParameters, ParameterCollection SharedVariables)
        {
            localContext.Trace($"{nameof(msdyn_RetrieveDistanceMatrix)} started. InputParameters = {InputParameters.Count().ToString()}, OutputParameters = {OutputParameters.Count().ToString()}");

            try
            {
                // If a plugin earlier in the pipeline has already retrieved a distance matrix successfully, quit 
                if (OutputParameters[MatrixKey] != null)
                    if (((EntityCollection)OutputParameters[MatrixKey]).Entities != null)
                        if (((EntityCollection)OutputParameters[MatrixKey]).Entities.Count > 0) return;

                // Make Distance Matrix call to Google API
                WebClient client = new WebClient();
                var url = String.Format($"https://{GoogleConstants.GoogleApiServer}{GoogleConstants.GoogleDistanceMatrixPath}/json"
                    + "?units=imperial"
                    + $"&origins={string.Join("|", ((EntityCollection)InputParameters[SourcesKey]).Entities.Select(e => e.GetAttributeValue<double?>("latitude") + "," + e.GetAttributeValue<double?>("longitude")))}"
                    + $"&destinations={string.Join("|", ((EntityCollection)InputParameters[TargetsKey]).Entities.Select(e => e.GetAttributeValue<double?>("latitude") + "," + e.GetAttributeValue<double?>("longitude")))}"
                    + $"&key={GoogleConstants.GoogleApiKey}");
                localContext.Trace($"Calling {url}\n");
                string response = client.DownloadString(url);   // Post ...

                localContext.Trace("Parsing response ...\n");
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(DistanceMatrixResponse));    // Deserialize response json
                object objResponse = jsonSerializer.ReadObject(new MemoryStream(Encoding.UTF8.GetBytes(response)));     // Get response as an object
                DistanceMatrixResponse distancematrixResponse = objResponse as DistanceMatrixResponse;       // Unbox as our data contracted class for response

                localContext.Trace("Response Status = " + distancematrixResponse.Status + "\n");
                if (distancematrixResponse.Status != "OK")
                    throw new ApplicationException($"Server {GoogleConstants.GoogleApiServer} application error (Status={distancematrixResponse.Status}). {distancematrixResponse.ErrorMessage}");

                localContext.Trace("Checking distancematrixResponse.Results...\n");
                if (distancematrixResponse.Rows != null)
                {
                    localContext.Trace("Parsing distancematrixResponse.Results.Elements...\n");

                    // build and update output parameter
                    var result = new EntityCollection();
                    result.Entities.AddRange(distancematrixResponse.Rows.Select(r => ToEntity(r.Columns.Select(c => ToEntity(c.Status, c.Duration, c.Distance)).ToArray())));
                    OutputParameters[MatrixKey] = result;

                }
                else throw new ApplicationException($"Server {GoogleConstants.GoogleApiServer} application error (missing Rows)");
            }
            catch (Exception ex)
            {
                // Signal to subsequent plugins in this message pipeline that retrieval of distance matrix failed here.
                OutputParameters[MatrixKey] = null;

                //TODO: You may need to decide which caught exceptions will rethrow and which ones will simply signal geocoding did not complete.
                throw new InvalidPluginExecutionException(string.Format("Geocoding failed at {0} with exception -- {1}: {2}"
                    , GoogleConstants.GoogleApiServer, ex.GetType().ToString(), ex.Message), ex);
            }

            // For debugging purposes, throw an exception to see the details of the parameters
            //CreateExceptionWithDetails("Debugging...", InputParameters, OutputParameters, SharedVariables);
        }

        private Entity ToEntity(string status, CProperty duration, CProperty meters)
        {
            var e = new Entity("organization");
            e["status"] = status;
            if (status.ToUpper() == "OK")
            {
                e["miles"] = meters.Value * 0.000621371d;      // Convert to miles
                e["duration"] = duration.Value;
            }
            else
            {                                        // either NOT_FOUND or ZERO_RESULTS
                e["miles"] = 0d;
                e["duration"] = 0d;
            }
            return e;
        }

        private Entity ToEntity(params Entity[] entities)
        {
            var c = new EntityCollection();
            c.Entities.AddRange(entities);
            var e = new Entity("organization");
            e[MatrixKey] = c;
            return e;
        }

        private void CreateExceptionWithDetails(string message, ParameterCollection inputs, ParameterCollection outputs, ParameterCollection shareds)
        {
            StringBuilder sb = new StringBuilder(message + "\n");
            sb.AppendLine("InputParameters -- ");
            foreach (var item in inputs)
            {
                sb.AppendLine("\t" + item.Key + " : '" + item.Value + "' ");
                if (((EntityCollection)item.Value).Entities != null)
                    ((EntityCollection)item.Value).Entities.ToList().ForEach(e => sb.AppendLine("\t\t" + e.GetAttributeValue<double>("latitude").ToString() + "," + e.GetAttributeValue<double>("longitude").ToString()));
            }
            if (outputs != null)
            {
                sb.AppendLine("OutputParameters -- ");
                foreach (var item in outputs)
                {
                    sb.AppendLine("\t" + item.Key + " : '" + item.Value + "' ");
                    if (item.Value != null)
                        if (((EntityCollection)item.Value).Entities != null)
                            ((EntityCollection)item.Value).Entities.ToList().ForEach(r => {
                                sb.AppendLine("\t\t" + r.GetAttributeValue<EntityCollection>(MatrixKey).ToString());
                                if (r.GetAttributeValue<EntityCollection>(MatrixKey).Entities != null)
                                    r.GetAttributeValue<EntityCollection>(MatrixKey).Entities.ToList().ForEach(e => sb.AppendLine("\t\t" + e.GetAttributeValue<double>("distance").ToString() + "," + e.GetAttributeValue<double>("duration").ToString()));

                            });
                }
            }
            sb.AppendLine("SharedVariables -- ");
            foreach (var item in shareds) sb.AppendLine("\t" + item.Key + " : '" + item.Value + "' ");
            throw new InvalidPluginExecutionException(sb.ToString());
        }
    }
}
```

### See also

[Create custom plug-in to use your preferred geospatial data provider](create-custom-plugin-preferred-geospatial-data-provider.md)

[Register and deploy custom plug-in to use your preferred geospatial data provider](register-deploy-custom-plugin-preferred-geospatial-data-provider.md)    