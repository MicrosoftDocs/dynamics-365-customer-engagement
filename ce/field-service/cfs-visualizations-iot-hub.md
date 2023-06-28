---
title: Visualize IoT device readings
description: Learn how to better understand the state of a device and its repair history with visualized device readings in Connected Field Service.
ms.date: 02/17/2023
ms.subservice: connected-field-service
ms.topic: how-to
ms.custom: bap-template
ms.author: vhorvath
author: vhorvathms
---

# Visualize IoT device readings

To help you understand the current state of a device, its repair history, and the effect of performed work orders, Connected Field Service displays near real-time device readings and historical sensor measurements in a chart alongside the service history.

The device readings chart is available on the IoT alert, work order, case, device, and asset forms. It supports Azure IoT Hub and [custom IoT providers](cfs-custom-iot-provider.md).

:::image type="content" source="media/cfs-device-readings-history.png" alt-text="Screenshot of an IoT alert with device readings in Connected Field Service.":::

## Prerequisites

To enable the device readings chart, deploy [Azure Time Series Insights](https://azure.microsoft.com/pricing/details/time-series-insights/) to your Azure subscription. Administrators can deploy the required services with an ARM template using the [IoT Deployment app](https://aka.ms/deploycfs) for Connected Field Service with Azure IoT Hub. Make sure you select **Deploy Time Series Insights** when choosing which services to deploy.

[Learn how to deploy the ARM template for for Connected Field Service with IoT Hub](installation-setup-iothub.md).

> [!NOTE]
> Time Series Insights (TSI) will be deprecated after March 2025. We'll transition Connected Field Service to a new platform and announce it when the deprecation takes place. More information: [Migrate to Azure Data Explorer](/azure/time-series-insights/migration-to-adx).

<!-- what about custom providers?-->

## Enable the device readings chart

After successfully deploying Time Series Insights, the **Device Readings** tab shows on the IoT alert, work order, case, device, and asset forms.  

To view device readings, ensure the following data is in place:

|Form |Required data|
|--|--|
|IoT Device  |Device ID has a value.  |
|IoT alert|The alert has a related IoT device.|
| Work order|The work order has a related IoT alert and the IoT alert has a related IoT device. |
| Case| The case has a related IoT alert and the IoT alert has a related IoT device. |
| Asset| The device readings chart is for the device ID set in Connected Device Attributes section of the asset form. |

## Use the device readings chart

Open the **Device Readings** tab on IoT alert, work order, case, device, or asset form. If the device sends device measurements to Time Series Insights, and the device measurement data exists for the selected time period, the chart loads.  

   > [!NOTE]
   > If you select a **Custom** time period, limit your time range to no more than 90 days.

:::image type="content" source="media/cfs-device-readings-hover-history.png" alt-text="Screenshot of a device history chart with callouts on the main controls.":::

- Select the eye icon next to a measurement to show or hide the measurement on the chart.

- Hover over a line in the chart to see a tooltip with measurement details.

- The service history (cases and work orders) related to the IoT alert show as pins on the device readings chart. Select a pin to open service history with a link directly to the work order or case. If there's no related service history in the selected time period, this information won't show.

## View device readings on the mobile app

Device readings and summary tiles work on the mobile app when connected to the internet. For more information, see [Connected Field Service on Field Service (Dynamics 365) mobile app](./cfs-mobile-powerapp.md#view-summary-tiles-and-device-readings)  

## Error codes

<!-- Valerie to validate table land error codes. -->

Use the following table to troubleshoot error codes related to device readings.

| Error code	| Possible root cause	| Suggested corrective action |
| --- | --- | --- |
| 5000101	 |	Local Config Store isn't available |	Contact Microsoft Support to investigate |
| 4001002	 |	Value for the Search Span parameter passed to the custom action *msdyn_IoTHubQueryDeviceReadings* is Null	 |	Verify that the system passes valid values for all the required arguments to the custom action *msdyn_IoTHubQueryDeviceReadings* |
| 4000103	 |	Value for the From or To date argument passed to the custom action *msdyn_IoTHubQueryDeviceReadings* isn't a valid DateTime |	Verify that the system passes valid values for all the required arguments to the custom action *msdyn_IoTHubQueryDeviceReadings* | 
| 4000104	 |	Value for the Interval argument passed to the custom action *msdyn_IoTHubQueryDeviceReadings* isn't a valid Duration	 |	Verify that the system passes valid values for all the required arguments to the custom action *msdyn_IoTHubQueryDeviceReadings*. For interval, the format should be in the [ISO 8601 Duration Format](https://wikipedia.org/wiki/ISO_8601#Durations). For example: PT1H |
| 4000201	 |	Value for the IotDeviceId argument passed to the custom action *msdyn_IoTHubQueryDeviceReadings* isn't a valid Guid	 |	Verify that the system passes valid values for all the required arguments to the custom action *msdyn_IoTHubQueryDeviceReadings*. For IotDeviceId, the value should be the *msdyn_iotdeviceid*, which is a global unique identifier (GUID). |
| 4010202 |		The user doesn't have permission to query Device Entity (*msdyn_iotdevice*)	 |	Ensure the user can query Device entity (*msdyn_iotdevice*) |
| 5000203 |		Unable to get msdyn_DeviceId for the given *msdyn_iotdeviceid* in the Device Entity (*msdyn_iotdevice*) |		Make sure device has the attribute *msdyn_DeviceId* |
| 5000204	 |	Unable to get Time Series Insights Url for the given *msdyn_iotdeviceid* |		Make sure that Connected Field Service Deployment App has deployed Time Series Insights for this CRM Org and the device is linked to the correct IoT Provider |
| 5000205 |		Client ID used to get Azure AD token for TSI Authorization is invalid or an empty GUID (global unique identifier) |		Make sure that the system uses a valid Client ID  in the Connected Field Service Deployment App |
| 5000206 |		Client Secret used to get Azure AD token for TSI Authorization has expired |		Update the Client Secret in Azure AD and rerun Connected Field Service Deployment App to update the new Client ID and Client Secret |
| 5000207 |		Unable to get the access token to query Time Series Insights |		Retry your request, and if the problem persists, try updating new Client ID and Client Secret by rerunning the Connected Field Service Deployment App |
| 5000603	 |	Request to Time Series Insights API returned with a failure	 |	Retry your request. If the problem persists, contact Microsoft Support to investigate |
| 5000604	 |	Response from Time Series Insights API isn't in an expected format	 |	Retry your request. If the problem persists, contact Microsoft Support to investigate |

## Next steps

- [Create IoT alerts and convert IoT alerts into work orders](cfs-iot-alerts.md)
- [Send commands to devices in Connected Field Service](cfs-commands.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
