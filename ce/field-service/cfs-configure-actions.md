---
title: Set up IoT provider actions
description: Learn how to set up IoT provider actions to automate various aspects of Dynamics 365 Connected Field Service operations.
ms.date: 09/04/2024
ms.subservice: connected-field-service
ms.topic: how-to
ms.author: vhorvath
author: vhorvathms
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:09/21/2023
---

# Set up IoT provider actions

After [you set up an IoT (Internet of Things) provider](./cfs-custom-iot-provider.md), you can specify a set of actions to trigger based on the captured data from your organization's IoT devices. Along with five predefined actions, you can create [custom actions](/power-apps/developer/data-platform/custom-actions) that are associated with your provider to automate various aspects of your Connected Field Service operations.

The following actions come with Connected Field Service:

- [Pull device data](#pull-device-data)
- [Register device](#register-device)
- [Aggregated device readings](#aggregated-device-readings)
- [Query device readings](#query-device-readings)
- [Get device events](#get-device-events)

## Pull device data

The [Pull device data action](cfs-pull-device-data.md) fetches the latest data for one device or a collection of devices from the IoT provider. It appears in the **Device Data History** tab.

Because data can come from multiple devices, the Pull device data action requires an EntityCollection as input. The following table describes the parameters of the EntityCollection.

| Parameter | Type | Details |
| --- | --- | --- |
| msdyn_iotdeviceid | string | The GUID device ID (msdyn_iotdevice) in Connected Field Service, converted to a string |
| msdyn_name | string | The name of the device |
| @odata.type | string | The entity's OData type |

Sample input:

```json
{
  "EntityCollection":[
      {
    "msdyn_iotdeviceid":"B25B5E21-326E-4C36-9296-C195286DGEC9",
    "msdyn_name":" HVAC 32443",
    "@odata.type":"Microsoft.Dynamics.CRM.msdyn_iotdevice"
      },
      {
    "msdyn_iotdeviceid":"B25B5E21-326E-4C36-9296-C195286DGEE9",
    "msdyn_name":" HVAC 92232",
    "@odata.type":"Microsoft.Dynamics.CRM.msdyn_iotdevice"
      }
  ]
}

```

The Pull device data action returns the fetched data in serialized JSON format. The following table describes the parameters of the PullDeviceDataResultsJSON output.

| JSON property | Type | Details |
| --- | --- | --- |
| ID | string | The GUID device ID (msdyn_iotdevice) in Connected Field Service, converted to a string |
| ConnectionState | boolean | Whether the device is disconnected (false) or connected (true) |
| ConnectionStateUpdatedTime | datetime | The timestamp of the last connection state update from the IoT provider |
| DeviceReportedProperties | string | The device's reported properties, formatted as a JSON string |
| LastActivityTime | datetime | The timestamp of the device's last reported activity |

Sample output:

```json
{
  "PullDeviceDataResultsJSON":[
     {
    "Id":"B25B5E21-326E-4C36-9296-C195286DGEC9",
    "ConnectionState":true,
    "ConnectionStateUpdatedTime":"2019-08-2911:00:00",
    "DeviceReportedProperties":{
      "temperature":65.6366305680316,
      "humidity":21.3333366666
      },
    "LastActivityTime": "2019-08-2011:00:00"
    },
    {
    "Id":"B25B5E21-326E-4C36-9296-C195286DGEE9",
    "ConnectionState":true,
    "ConnectionStateUpdatedTime":"2019-08-2911:00:00",
    "DeviceReportedProperties":{
      "temperature":62.8366305680316,
      "humidity":19.5333366666
    },
    "LastActivityTime": "2019-08-2011:00:00"
     }
  ]
}
```

## Register device

The Register device action creates an association between a device or a collection of devices and the IoT provider. New devices and devices or components that a technician swaps out can be registered. After you register a device, it appears in the **Registration History** tab of the IoT Device record.

Because multiple devices can be registered at one time, the Register device action requires an EntityCollection as input. The following table describes the parameters of the EntityCollection.

| Parameter | Type | Details |
| --- | --- | --- |
| msdyn_iotdeviceid | string | The GUID device ID (msdyn_iotdevice) in Connected Field Service, converted to a string |
| msdyn_name | string | The name of the device |
| @odata.type | string | The entity's OData type |

Sample input:

```json
{
  "EntityCollection": [
    {
      "msdyn_iotdeviceid": "5754578D-1F9A-4720-BC21-3C3042C05B2F",
      "msdyn_name": "Coffee maker 1",
      "@odata.type": "Microsoft.Dynamics.CRM.msdyn_iotdevice"
    },
    {
      "msdyn_iotdeviceid": "5754578D-1F9A-4720-BC21-3C3042C06C5F",
      "msdyn_name": "Coffee maker 2",
      "@odata.type": "Microsoft.Dynamics.CRM.msdyn_iotdevice"
    }
  ]
}
```

The Register device action returns the registration results in serialized JSON format. The following table describes the parameters of the RegistrationResultsJSON output.

| JSON property | Type | Details |
| --- | --- | --- |
| ID | string | The GUID device ID (msdyn_iotdevice) in Connected Field Service, converted to a string |
| RegistrationStatus | OptionSetValue | The status of the registration from the IoT provider back to Connected Field Service<br/>Values and labels:<br/>- 192350000: Unknown<br/>- 192350001: Unregistered<br/>- 192350002: In progress<br/>- 192350003: Registered<br/>- 192350004: Error<br/>Note: An OptionSet is a list of options with label-value mapping, like a drop-down list control.  |
| DeviceId | string | The ID of the device in the IoT provider system |
| Message  | string | A detailed message to the Connected Field Service user regarding the registration |

Sample output:

```json
{
   "RegistrationResultsJSON":[
      {
         "Id":"5754578D-1F9A-4720-BC21-3C3042C05B2F",
         "RegistrationStatus":{"Value":192350003},
         "DeviceId":"DeviceIdFromThirdPartyOrUserDefined",
         "Message":"Registration info/warning/error message"   
      },
      {
         "Id":"5754578D-1F9A-4720-BC21-3C3042C06C5F",
         "RegistrationStatus":{"Value":192350003},
         "DeviceId":"DeviceIdFromThirdPartyOrUserDefined",
         "Message":"Registration info/warning/error message"   
      }   
  ]
}
```

## Aggregated device readings

The Aggregated device readings action fetches aggregated device data from the IoT provider. Aggregate data provides a quick snapshot of the condition of the device on summary tiles in Connected Field Service.

:::image type="content" source="./media/custom-iot-aggregate-readings.png" alt-text="Screenshot of an IoT device in Field Service, showing aggregate readings.":::

The following table describes the input parameters of the Aggregated device readings action.

| Parameter | Type | Details |
| --- | --- | --- |
| deviceId | string | The GUID device ID (msdyn_iotdevice) in Connected Field Service, converted to a string |
| measures | string | A list of measurements in JSON format; see the following code snippet for examples |

Sample input:

```json
[
    {
        "Measure":"Humidity",
        "Aggregate":"Min",
        "TimeRangeType":"Days",
        "TimeRangeValue":7
    },
    {
        "Measure":"Temperature",
        "Aggregate":"Avg",
        "TimeRangeType":"Days",
        "TimeRangeValue":14
    }
]
```

The Aggregated device readings action returns the measurements in serialized JSON format. The following table displays the output parameters.

| JSON property | Type | Details |
| --- | --- | --- |
| measuresOutput | string | The values of the returned measurements in JSON format; see the following code snippet for examples |

Sample output:

```json
[
    {
        "Name":"Humidity",
        "Aggregate":"Min",
        "Unit":"F",
        "TimeRangeValue":7,
        "TimeRangeType":"Days",
        "Position":1,
        "Value":"39.13334"
    },
    {
        "Name":"Temperature",
        "Aggregate":"Avg",
        "Unit":"F",
        "TimeRangeValue":14,
        "TimeRangeType":"Days",
        "Position":2,
        "Value":"65.13334"
    }
]
```

Aggregated device readings are based on the device data history entity if you aren't using the Aggregated device readings action.

## Query device readings

The Query device readings action fetches historical device data, such as temperature and humidity, from the IoT provider and displays it as a time series chart.

:::image type="content" source="./media/custom-iot-query-device-readings.png" alt-text="Screenshot of device temperature and humidity over time.":::

The following table describes the input parameters of the Query device readings action.

| Parameter | Type | Details |
| --- | --- | --- |
| From | datetime | The starting time of the reading (measurement) in ISO format; for example, "2020-04-10T13:51:55.781Z" |
| To | datetime | The ending time of the reading (measurement) in ISO format|
| IoTDeviceId | string | The GUID device ID (msdyn_iotdevice) in Connected Field Service, converted to a string |
| Interval | string | The interval size of the plotting point specified in ISO-8601 duration format; for example, 1 minute is "PT1M," 1 millisecond is "PT0.001S"<br/>All intervals are the same size. One month is always converted to 30 days and one year is always 365 days. |

Sample input:

```json
{
    "From":"2023-04-01T18:05:37.661Z", 

    "To":"2023-05-31T18:05:37.661Z", 

    "IotDeviceId":"50fce36f-9e3e-ed11-bba3-000d3a8b1de9", 

    "Interval":"P1D"
} 
```

The Query device readings action returns the data in serialized JSON format. The following table displays the output parameters.

| JSON property | Type | Details |
| --- | --- | --- |
| AggregatedDeviceReadings | String | The values of the returned measurements in JSON format; see the following code snippet for examples

Sample output:

```json
{
  "HVAC Unit 123": {
    "Temperature": {
      "2017-04-01T06:00:00Z": {
        "min": -29,
        "max": 62.59,
        "avg": 16.89,
        "sum": 4054.14,
        "count": 240
      },
      "2017-04-01T08:00:00Z": {
        "min": -29,
        "max": 62.59,
        "avg": 16.89,
        "sum": 4054.14,
        "count": 480
      }
    },
    "Humidity": {
      "2017-04-01T06:00:00Z": {
        "min": 10,
        "max": 48.3,
        "avg": 29.25,
        "sum": 7020.62,
        "count": 240
      },
      "2017-04-01T08:00:00Z": {
        "min": 10,
        "max": 48.3,
        "avg": 29.25,
        "sum": 7020.62,
        "count": 480
      }
    }
  }
}    
```

## Get device events

The Get device events action fetches events from the device [service history](service-history.md) and displays them as pins at the bottom of the chart that's created by the Query device readings action. You can include any custom entities such as the last time you performed an asset upgrade.

:::image type="content" source="./media/custom-iot-device-events.png" alt-text="Screenshot of events shown as pins under the device temperature and humidity over time chart.":::

> [!NOTE]
> You don't need to create a new action. Register a custom plug-in on the `msdyn_IoTGetDeviceEvents` action, like plug-ins for create events.

The following table describes the input parameters of the Get device events action.

| JSON property | Type | Details |
| --- | --- | --- |
| From | datetime | The starting time of the reading (measurement) in ISO format; for example, "2020-04-10T13:51:55.781Z" |
| To | datetime | The ending time of the reading (measurement) in ISO format |
| IoTDeviceId | string | The GUID device ID (msdyn_iotdevice) in Connected Field Service, converted to a string |

Sample input:

```json
{ 
    "IotDeviceId": "50fce36f-9e3e-ed11-bba3-000d3a8b1de9", 
    "From": "2023-06-12T18:57:54.864Z", 
    "To": "2023-06-12T19:57:54.864Z" 
} 
```

The Get device events action returns the data in serialized JSON format. The following table displays the output parameters.

| JSON property | Type | Details |
| --- | --- | --- |
| EventsName | string | Short description of the category of the event; use it to show or hide all events in that category |
| Timestamp | string | The timestamp of the event formatted as a string in ISO format; the x-axis timestamp for the event pin |
| Color | string | The color of the event pin, provided as a hex-code string |
| Description | string | A short description of the event, displayed when the user hovers over the pin or selects the pin to view details |
| ID | string | The ID of the event; can be a name or another user-friendly value, like the work order number or booking confirmation code |
| Entity | string | The Dataverse entity name related to the event; for example, "msdyn_workorder" |
| URL | string | The URL of the details page for the event, like a link to the work order form<br/>If you pass an entity and GUID, the system automatically generates a hyperlink. |
| GUID | string | The GUID, converted to a string, of the entity record in Dataverse |

Sample output:

```json
{
  "Service History": {
    "2019-08-07T19:14:53Z": {
      "color": "#FF6300",
      "description": "Work Order Created",
      "id": "00001",
      "entity": "msdyn_workorder",
      "url": "",
      "guid": "952a7592-8818-ea11-a811-000d3a5466d7"
    },
    "2019-08-08T19:14:53Z": {
      "color": "#ECC5AC",
      "description": "Work Order Created",
      "id": "00002",
      "entity": "msdyn_workorder",
      "url": "",
      "guid": "952a7592-8818-ea11-a811-000d3a5466d9"
    },
    "2019-09-21T09:34:53Z": {
      "color": "#ECC5AC",
      "description": "Case Created",
      "id": "000121",
      "entity": "msdyn_incident",
      "url": "",
      "guid": "952a7592-8818-ea11-a811-000d3a5466d0"
    }
  },
  "Asset History": {
    "2019-08-07T19:14:53Z": {
      "color": "#FF6400",
      "description": "Asset Model Upgraded",
      "id": "001223",
      "entity": "new_assetupgraded",
      "url": "",
      "guid": "952a7592-8818-ea11-a811-000d3a5466d7"
    }
  }
}
```

## Next steps

- [Send commands in Connected Field Service](cfs-commands.md)
- [IoT provider for custom IoT solutions](cfs-custom-iot-provider.md)
- [IoT integration with Connected Field Service](cfs-connect-data-overview.md)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
