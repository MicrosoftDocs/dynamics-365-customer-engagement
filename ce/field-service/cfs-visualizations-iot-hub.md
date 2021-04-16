---
title: "Visualizing device readings with Connected Field Service| MicrosoftDocs"
description: Learn how to better understand the state of a device and its repair history with visualized device readings in Connected Field Service.
ms.custom: 
  - dyn365-fieldservice
ms.date: 01/19/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Visualizing device readings

To help you understand the current state of a device, its repair history, and the effect of performed work orders, Connected Field Service displays near realtime device readings and historical sensor measurements in a chart alongside work order details.

The device readings chart is available on the IoT alert, work order, case, device, and asset forms.

To enable the device readings chart, administrators need to deploy Azure Time Series into the Azure subscription when deploying or upgrading Connected Field Service with Azure IoT Hub for their organization. Administrators do the deployment through the [IoT Deployment app (aka.ms/deploycfs).](https://aka.ms/deploycfs)  


> [!div class="mx-imgBorder"]
> ![Screenshot of an IoT alert in Connected Field Service](./media/cfs-device-readings-hover-history.png)

## Prerequisites

- Field Service version 8.8.2 or higher

> [!Important]
> If you are deploying this feature for the first time, there are changes to our underlying service, Azure Time Series Insights.
>
> If you are on **Field Service version 8.8.24 or higher**, ignore this message.
> If you are on a **Field Service version lower than 8.8.24**:
> - If you are only sending the data type “doubles,” there will be no impact. If you are sending other data types, these other data types will not appear in your device readings chart until you upgrade to Field Service version 8.8.24.
> For more information about the Azure changes, [see this article](/azure/time-series-insights/time-series-insights-long-data-type).

- The device readings chart is available for Connected Field Service with either Azure IoT Hub or using a [custom IoT provider](cfs-custom-iot-provider.md).

## Enable the device readings chart

1. Open the Connected Field Service [IoT Deployment app (aka.ms/deploycfs).](https://aka.ms/deploycfs) 
2. Select the Dynamics 365 organization where the IoT solution will be deployed. 
3. Select the Azure subscription and the Azure Resource Group. (Note: Select **Upgrade deployment** if  you're updating an existing Connected Field Service for IoT Hub deployment.)
4. Select the **Deploy Time Series Insight** checkbox.
5. Select **Deploy**.


> [!div class="mx-imgBorder"]
> ![Screenshot of the deployment screen showing configuration of Azure resources](./media/connected-field-service-IoT-hub-device-measurements-deployment1-2.png)

6. Follow the remaining steps in the IoT Deployment app to complete the Time Series Insights deployment.
- Create the application (client) ID: Follow the steps in [Create an Azure Active Directory application](/azure/active-directory/develop/howto-create-service-principal-portal#create-an-azure-active-directory-application
).
- Create the client secret: Follow the steps in [Create a new application secret](/azure/active-directory/develop/howto-create-service-principal-portal#create-a-new-application-secret
). 

> [!div class="mx-imgBorder"]
> ![Screenshot showing fields on the Time Series Insights screen](./media/connected-field-service-IoT-hub-device-measurements-deployment2-2.png)

> [!Note]
> - Storage account selection is only available when you're upgrading an existing deployment.
> - The IoT Deployment app adds timeseriesinsightsconsumergroup into IoT Hub Consumer Group.


7. After deployment, the **Device Readings** tab is displayed on the IoT alert, work order, case, device, and asset forms.  

## Use the device readings chart

To view device readings, the following data must be in place:

|Form |Required data
--|--|
|Device  |Device ID is not empty.  
 Work order|The work order has a related IoT alert and the IoT alert has a related IoT device. The device ID in the IoT device is not empty.
| Case| The case has a related IoT alert and the IoT alert has a related IoT device. The Device ID in the IoT device is not empty. |
| Asset|The device ID is not empty. The device readings chart is for the device ID set in Connected Device Attributes section of the asset form. |
|IoT alert|The alert has a related IoT device. The device ID in the IoT device is not empty. |

 1. Open the **Device Readings** tab on IoT alert, work order, case, device, or asset form.


> [!div class="mx-imgBorder"]
> ![Screenshot of standard device readings.](./media/cfs-device-readings-standard.png)


2. Choose the time period from the drop-down list. If the device sends device measurements to TSI, and the device measurement data exists for the selected time period, a chart is loaded.  

> [!Note]
> If you select a **Custom** time period, limit your time range to no more than 90 days. 

3. Select the eye icon next to the measurement to show or hide the measurement on the chart.

4. Hover over the chart to see tooltip with measurement details. 

> [!div class="mx-imgBorder"]
> ![Screenshot of an IoT alert device reading, showing information on hover.](./media/cfs-device-readings-select.png)


5. Cases and work orders related to the IoT alert are displayed as pins on the device readings chart. Select a pin to open service history with a link directly to the work order or case. 
> [!div class="mx-imgBorder"]
> ![Screenshot of an IoT alert showing service history.](./media/cfs-device-readings-click-history.png)

6. Select the eye icon next to **Work Orders** to show or hide any work orders created and closed during the selected time period. 


> [!div class="mx-imgBorder"]
> ![Screenshot of device readings chart showing toolip for work orders](./media/connected-field-service-IoT-hub-device-measurements-workorder.png)

> [!Note]
> If there are no work orders in the selected time period, work order selection will not be displayed.


## View device readings on the mobile app

Device readings and summary tiles are viewable on the mobile app when connected to the internet. For more information, see the article: [Connected Field Service on Field Service (Dynamics 365) mobile app](./cfs-mobile-powerapp.md#view-summary-tiles-and-device-readings)  

## Error codes

Use the following table to troubleshoot error codes related to device readings. 

| Error code	| Possible root cause	| Suggested corrective action |
| --- | --- | --- |
| 5000101	 |	Local Config Store is not available |	Contact Microsoft Support to investigate |
| 4001002	 |	Value for the Search Span parameter passed to the custom action msdyn_IoTHubQueryDeviceReadings is Null	 |	Verify that valid values for all the required arguments are passed to the custom action msdyn_IoTHubQueryDeviceReadings |
| 4000103	 |	Value for the From or To date argument passed to the custom action msdyn_IoTHubQueryDeviceReadings is not a valid DateTime |		Verify that valid values for all the required arguments are passed to the custom action msdyn_IoTHubQueryDeviceReadings | 
| 4000104	 |	Value for the Interval argument passed to the custom action msdyn_IoTHubQueryDeviceReadings is not a valid Duration	 |	Verify that valid values for all the required arguments are passed to the custom action msdyn_IoTHubQueryDeviceReadings. For interval, the format should be in the [ISO 8601 Duration Format](https://wikipedia.org/wiki/ISO_8601#Durations). For example: PT1H |
| 4000201	 |	Value for the IotDeviceId argument passed to the custom action msdyn_IoTHubQueryDeviceReadings is not a valid Guid	 |	Verify that valid values for all the required arguments are passed to the custom action msdyn_IoTHubQueryDeviceReadings. For IotDeviceId, the value should be the msdyn_iotdeviceid, which is a global unique identifier (GUID). |
| 4010202 |		The user doesn't have permission to query Device Entity (msdyn_iotdevice)	 |	Ensure the user can query Device entity (msdyn_iotdevice) |
| 5000203 |		Unable to get msdyn_DeviceId for the given msdyn_iotdeviceid in the Device Entity (msdyn_iotdevice) |		Make sure the attribute msdyn_DeviceId is populated for the device |
| 5000204	 |	Unable to get Time Series Insights Url for the given msdyn_iotdeviceid |		Make sure that Connected Field Service Deployment App has deployed Time Series Insights for this CRM Org and the device is linked to the correct IoT Provider |
| 5000205 |		Client ID used to get Azure AD token for TSI Authorization is invalid or an empty GUID (global unique identifier) |		Make sure that valid Client ID is provided in the Connected Field Service Deployment App when it was executed |
| 5000206 |		Client Secret used to get Azure AD token for TSI Authorization has expired |		Update the Client Secret in Azure AD and rerun Connected Field Service Deployment App to update the new Client ID and Client Secret |
| 5000207 |		Unable to get the access token to query Time Series Insights |		Retry your request, and if the problem persists, try updating new Client ID and Client Secret by rerunning the Connected Field Service Deployment App |
| 5000603	 |	Request to Time Series Insights API returned with a failure	 |	Retry your request. If the problem persists, contact Microsoft Support to investigate |
| 5000604	 |	Response from Time Series Insights API is not in an expected format	 |	Retry your request. If the problem persists, contact Microsoft Support to investigate |


## Additional notes
- Available only in United States English (en-US)
- **Known issues:** 
  - In custom time settings, the time zone is always set as UTC even when another time zone is selected. The time period displayed after applying the setting is always local time. 
  - When deploying immediately after creating a new application (client) ID with the IoT Deployment app, you may see an **unable to deploy TSI with credential** error. Try again after one minute.
- Azure Time Series Insights uses a pay-as-you-go pricing model. The pricing and cost estimate calculator is available at https://azure.microsoft.com/pricing/details/time-series-insights. Select the region where you are planning to deploy TSI to understand the storage and query cost. (TSI uses Azure blob to store the data.) 






 





[!INCLUDE[footer-include](../includes/footer-banner.md)]