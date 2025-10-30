---
title: "Create plug-in to use preferred geospatial data provider in Universal Resource Scheduling"
description: "Learn how to create a custom plug-in for Universal Resource Scheduling in order to use the geospatial data provider of your choice instead of Bing Maps."
ms.date: 07/28/2025
searchScope: 
  - Field Service
  - Project Service
ms.reviewer: puneet-singh1
ms.subservice: common-scheduler
ms.topic: concept-article
author: mkelleher-msft
ms.author: mkelleher
---

# Create custom plug-in to use your preferred geospatial data provider

This article explains the two geospatial actions in Universal Resource Scheduling, shows you how to create a custom plug-in for these actions, and gives examples from a sample custom plug-in that uses Google Maps API for geospatial data.

## Input and output parameters for geospatial actions

When writing your custom plug-in, consider the input and output parameters for the geospatial actions to understand what data to pass in and the expected output data in your plug-in code.

You can view the input and output parameters for the two geospatial actions in two ways:

- **Web API action reference content**: View reference information about the geospatial actions in Universal Resource Scheduling.
  - `Microsoft.Dynamics.CRM.msdyn_RetrieveDistanceMatrix`
- **Action definition**: View the action definition in Dynamics 365 for information about the input/output parameters, including information whether a parameter is required or optional.

> [!NOTE]
> The Web API types and operations mentioned in this article are available in your environment. You can explore them using your environment's service document or Insomnia. Learn more in [Web API Service Documents](/power-apps/developer/data-platform/webapi/web-api-service-documents) and [Use Insomnia with Microsoft Dataverse Web API](/power-apps/developer/data-platform/webapi/insomnia).

### View an action definition

1. Go to [Power Apps](https://make.powerapps.com/) and select your solution.

1. Open **Processes** and search for the action name, such as **Resource Scheduling - Geocode Address** or **Resource Scheduling - Retrieve Distance Matrix**.

1. Open the action name. For example, the screenshot shows the definition of the **Resource Scheduling - Geocode Address** (**msdyn_GeocodeAddress**) action where the highlighted area provides information about the input and output parameters:

   :::image type="content" source="../media/FS-ActionDefinition.png" alt-text="Power Apps screenshot showing the Resource Scheduling - Geocode Address process.":::

## Write your custom plug-in

Plug-ins are custom classes that implement the <xref:Microsoft.Xrm.Sdk.IPlugin> interface. To create a plug-in, go to [Plug-in development](../../customerengagement/on-premises/developer/plugin-development.md)

A custom plug-in sample is provided for your reference that demonstrates how to use the Google Maps API to provide geospatial data for field operations instead of the default Bing Maps API. Learn more in [Sample: Custom plug-in to use Google Maps API as geospatial data provider](sample-custom-plugin-google-geospatial-data-provider.md).

The following code in each sample plug-in uses data from the Google API:

### ExecuteGeocodeAddress method in the msdyn_GeocodeAddress.cs plug-in file

```csharp
public void ExecuteGeocodeAddress(IPluginExecutionContext pluginExecutionContext, IOrganizationService organizationService, ITracingService tracingService)
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
```

### ExecuteDistanceMatrix method in the msdyn_RetrieveDistanceMatrix.cs plug-in file

```csharp
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
```

After you write your custom plug-in code, build the project to generate a plug-in assembly (.dll). Use this assembly to register the plug-in on the Universal Resource Scheduling geospatial actions.

## Next steps

[Register and deploy custom plug-in to use your preferred geospatial data provider](register-deploy-custom-plugin-preferred-geospatial-data-provider.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
