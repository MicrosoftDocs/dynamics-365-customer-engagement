---
title: "Sample: Custom plug-in to use Google Maps API as geospatial data provider | MicrosoftDocs"
description: "A sample that demonstrates how to use a custom plug-in use Google Maps API for geospatial operations in Dynamics 365 Field Service."
ms.custom: 
  - dyn365-developer
  - dyn365-customerservice
ms.date: 04/01/2020
searchScope: 
  - Field Service
  - Project Service
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice 
ms.topic: article
author: FieldServiceDave
ms.author: daclar
search.app: 
  - D365CE
  - D365PS
  - D365FS
---
# Sample: Custom plug-in to use Google Maps API as geospatial data provider

You can use a custom plug-in to use geospatial data from a data provider of your choice instead of using the default Bing Maps API in Field Service and Project Service.

Sample is available here: [Custom plug-in to use Google Maps API as geospatial data provider (Dynamics 365)](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/field-service/CustomPlugin-FS-Geospatial)

## Prerequisites

Internet connection is required to download the sample project and to restore the NuGet packages used in the sample project.

## Requirements

- [!INCLUDE[pn_dyn_365_field_service](../../includes/pn-dyn-365-field-service.md)] solution must be installed on your [!INCLUDE[pn_dynamics_365](../../includes/pn-dynamics-365.md)] (online) instance. More information: [Install and setup Field Service](../../field-service/install-field-service.md) 
- Provide your own Google API key in the **GoogleDataContracts.cs** file in the sample:

    `public const string GoogleApiKey = "<PROVIDE YOUR GOOGLE API KEY";` 

## Demonstrates

This sample shows how to create a custom plug-in for the **msdyn_GeocodeAddress** and **msdyn_RetrieveDistanceMatrix** actions in Universal Resource Scheduling to use Google Maps API for geospatial data instead of using the default Bing Maps API.

## Run the sample

This sample generates a plug-in assembly file: **CustomPlugin-FS-Geospatial.dll**.

1. Download or clone the [samples repo](https://github.com/microsoft/Dynamics365-Apps-Samples).
2. Navigate to the location where you downloaded or cloned the repo on your computer, go to the **field-service/CustomPlugin-FS-Geospatial** folder, and double-click the **CustomPlugin-FS-Geospatial.sln** file to open the solution in Visual Studio.
3. In Visual Studio, select **Build** > **Build Solution**. The NuGet packages used in the solution will download automatically if the option to restore NuGet packages automatically on building a project is enabled in Visual Studio. More information: [Enabling and disabling package restore](https://docs.microsoft.com/nuget/consume-packages/package-restore#enabling-and-disabling-package-restore) 

## After running the sample

After you have successfully run (build) the sample, a custom plug-in assembly file, **CustomPlugin-FS-Geospatial.dll**, will become available in the `<Project>\bin\debug` folder. Register the sample custom plug-in assembly on your [!INCLUDE[pn_dynamics_365](../../includes/pn-dynamics-365.md)] (online) instance to be able to use the plug-in to use the Google Maps API instead of the default Bing Maps API. More information: [Register and deploy your custom plug-in](register-deploy-custom-plugin-preferred-geospatial-data-provider.md#register-and-deploy-your-custom-plug-in) 

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
    public class msdyn_GeocodeAddress : IPlugin
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

        public void Execute(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
            {
                throw new InvalidPluginExecutionException("serviceProvider");
            }

            // Obtain the execution context service from the service provider.
            IPluginExecutionContext PluginExecutionContext = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            // Obtain the organization factory service from the service provider.
            IOrganizationServiceFactory factory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));

            // Use the factory to generate the organization service.
            IOrganizationService OrganizationService = factory.CreateOrganizationService(PluginExecutionContext.UserId);

            // Obtain the tracing service from the service provider.
            ITracingService TracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));

            ExecuteGeocodeAddress(PluginExecutionContext, OrganizationService, TracingService);

        }


        /// <summary>
        /// Retrieve geocode address using Google Api
        /// </summary>
        /// <param name="pluginExecutionContext">Execution context</param>
        /// <param name="organizationService">Organization service</param>
        /// <param name="tracingService">Tracing service</param>
        /// <param name="notificationService">Notification service</param>
        public void ExecuteGeocodeAddress(IPluginExecutionContext pluginExecutionContext, IOrganizationService organizationService,  ITracingService tracingService)
        {
            //Contains 5 fields (string) for individual parts of an address
            ParameterCollection InputParameters = pluginExecutionContext.InputParameters;
            // Contains 2 fields (double) for resultant geolocation
            ParameterCollection OutputParameters = pluginExecutionContext.OutputParameters;
            //Contains 1 field (int) for status of previous and this plugin
            ParameterCollection SharedVariables = pluginExecutionContext.SharedVariables;

            tracingService.Trace("ExecuteGeocodeAddress started. InputParameters = {0}, OutputParameters = {1}", InputParameters.Count().ToString(), OutputParameters.Count().ToString());
            

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
                    userSettingsQuery.Criteria.AddCondition("systemuserid", ConditionOperator.Equal, pluginExecutionContext.InitiatingUserId);
                    var userSettings = organizationService.RetrieveMultiple(userSettingsQuery);
                    if (userSettings.Entities.Count > 0)
                        Lcid = (int)userSettings.Entities[0]["uilanguageid"];
                }

                // Arrange the address components in a single comma-separated string, according to LCID
                _address = GisUtility.FormatInternationalAddress(Lcid,
                    (string)InputParameters[Address1Key], 
                    (string)InputParameters[PostalCodeKey], 
                    (string)InputParameters[CityKey], 
                    (string)InputParameters[StateKey], 
                    (string)InputParameters[CountryKey]);

                // Make Geocoding call to Google API
                WebClient client = new WebClient();
                var url = $"https://{GoogleConstants.GoogleApiServer}{GoogleConstants.GoogleGeocodePath}/json?address={_address}&key={GoogleConstants.GoogleApiKey}";
                tracingService.Trace($"Calling {url}\n");
                string response = client.DownloadString(url);   // Post ...

                tracingService.Trace("Parsing response ...\n");
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(GeocodeResponse));    // Deserialize response json
                object objResponse = jsonSerializer.ReadObject(new MemoryStream(Encoding.UTF8.GetBytes(response)));     // Get response as an object
                GeocodeResponse geocodeResponse = objResponse as GeocodeResponse;       // Unbox into our data contracted class for response

                tracingService.Trace("Response Status = " + geocodeResponse.Status + "\n");
                if (geocodeResponse.Status != "OK")
                    throw new ApplicationException($"Server {GoogleConstants.GoogleApiServer} application error (Status {geocodeResponse.Status}).");

                tracingService.Trace("Checking geocodeResponse.Result...\n");
                if (geocodeResponse.Results != null)
                {
                    if (geocodeResponse.Results.Count() == 1)
                    {
                        tracingService.Trace("Checking geocodeResponse.Result.Geometry.Location...\n");
                        if (geocodeResponse.Results.First()?.Geometry?.Location != null)
                        {
                            tracingService.Trace("Setting Latitude, Longitude in OutputParameters...\n");

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
    public class msdyn_RetrieveDistance : IPlugin
    {
        const string PluginStatusCodeKey = "PluginStatus";
        const string SourcesKey = "Sources";
        const string TargetsKey = "Targets";
        const string MatrixKey = "Result";

        /// <summary>
        /// Initializes a new instance of the msdyn_RetrieveDistance class
        /// </summary>
        /// <param name="unsecure"></param>
        /// <param name="secure"></param>
        public msdyn_RetrieveDistance(string unsecure, string secure)
        {
            // TODO: Implement your custom configuration handling.
        }

        /// <summary>
        /// Execute the plugin
        /// </summary>
        /// <param name="serviceProvider"></param>
        public void Execute(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
            {
                throw new InvalidPluginExecutionException("serviceProvider");
            }

            // Obtain the execution context service from the service provider.
            IPluginExecutionContext PluginExecutionContext = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            // Obtain the organization factory service from the service provider.
            IOrganizationServiceFactory factory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));

            // Use the factory to generate the organization service.
            IOrganizationService OrganizationService = factory.CreateOrganizationService(PluginExecutionContext.UserId);

            // Obtain the tracing service from the service provider.
            ITracingService TracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));

            ExecuteDistanceMatrix(PluginExecutionContext, OrganizationService, TracingService);

        }

        public void ExecuteDistanceMatrix(IPluginExecutionContext pluginExecutionContext, IOrganizationService organizationService, ITracingService tracingService)
        {
            //Contains 2 fields (EntityCollection) for sources and targets
            ParameterCollection InputParameters = pluginExecutionContext.InputParameters;
            // Contains 1 field (EntityCollection) for results
            ParameterCollection OutputParameters = pluginExecutionContext.OutputParameters;
            //Contains 1 field (int) for status of previous and this plugin
            ParameterCollection SharedVariables = pluginExecutionContext.SharedVariables;

            tracingService.Trace("ExecuteDistanceMatrix started.  InputParameters = {0},OutputParameters = {1}", InputParameters.Count().ToString(), OutputParameters.Count().ToString());

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
                tracingService.Trace($"Calling {url}\n");
                string response = client.DownloadString(url);   // Post ...

                tracingService.Trace("Parsing response ...\n");
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(DistanceMatrixResponse));    // Deserialize response json
                object objResponse = jsonSerializer.ReadObject(new MemoryStream(Encoding.UTF8.GetBytes(response)));     // Get response as an object
                DistanceMatrixResponse distancematrixResponse = objResponse as DistanceMatrixResponse;       // Unbox as our data contracted class for response

                tracingService.Trace("Response Status = " + distancematrixResponse.Status + "\n");
                if (distancematrixResponse.Status != "OK")
                    throw new ApplicationException($"Server {GoogleConstants.GoogleApiServer} application error (Status={distancematrixResponse.Status}). {distancematrixResponse.ErrorMessage}");

                tracingService.Trace("Checking distancematrixResponse.Results...\n");
                if (distancematrixResponse.Rows != null)
                {
                    tracingService.Trace("Parsing distancematrixResponse.Results.Elements...\n");

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
            CreateExceptionWithDetails("Debugging...", InputParameters, OutputParameters, SharedVariables);
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

## Privacy notice disclaimer

You may use sample code to interact with third-party services whose privacy and security practices may differ from those of Microsoft Dynamics 365. IF YOU SUBMIT DATA TO THIRD PARTY SERVICES, SUCH DATA IS GOVERNED BY THEIR RESPECTIVE PRIVACY STATEMENTS. For the avoidance of doubt, data shared outside of Microsoft Dynamics 365 is not covered by your Microsoft Dynamics 365 agreement(s) or the Microsoft Dynamics 365 Trust Center. We encourage you to review these other privacy statements.

### See also

[Create custom plug-in to use your preferred geospatial data provider](create-custom-plugin-preferred-geospatial-data-provider.md)

[Register and deploy custom plug-in to use your preferred geospatial data provider](register-deploy-custom-plugin-preferred-geospatial-data-provider.md)    


[!INCLUDE[footer-include](../../includes/footer-banner.md)]