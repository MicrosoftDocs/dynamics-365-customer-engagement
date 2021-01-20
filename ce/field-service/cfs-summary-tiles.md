---
title: "Summary tiles in Connected Field Service | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 01/05/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
ms.suite: ""
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

# Summary tiles in Connected Field Service

Summary tiles give a numeric overview of important metrics related to IoT devices. Users can see an average of recent device readings or the number of work orders generated from an IoT alert as just two examples. Summary tiles are visible on IoT device, Iot alert, and customer asset records. 


> [!div class="mx-imgBorder"]
> ![Screenshot of device readings on an IoT device, with attention to work orders](./media/cfs-device-readings-history.png)



## Prerequisites

- Field Service version 8.8.2+


## Default summary tiles

3 summary tiles exist by default after a new IoT device is created: 

- New IoT alerts related to the IoT device in the last day
- New cases related to the IoT device in the Last 30 days
- New Work Orders related to the IoT device in the Last 30 days

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-summary-tiles-default.png)

If an IoT device is registered with Azure IoT (or a custom IoT provider) and has successfully pulled device data into Field Service, summary tiles for the first 2 device properties are automatically created. In the example image below this refers to average temperature and average humidity for the last 7 days. Temperature and humidity are the first 2 device properties in the first device data pull. 

> [!div class="mx-imgBorder"]
> ![Screenshot of device readings on an IoT device, with attention to work orders](./media/cfs-device-readings-history-edited.png)


## Edit summary tiles

Edit existing summary tiles or create new ones.

cfs-summary-tiles-edit

When creating new summary tiles choose if it should relate to a device property (like temperature or humidity as examples) or 

cfs-summary-tiles-edit2

Save to device

## Add summary tiles via Device Categories


		○ Configure ones based on category otherwise use default 
New IoT device visualization configuration 

## View summary tiles on the mobile app

Summary tiles and device readings are viewable on the mobile app when connected to the internet. See the topic on [Connected Field Service on Field Service (Dynamics 365) mobile app](https://docs.microsoft.com/dynamics365/field-service/cfs-mobile-powerapp#view-summary-tiles-and-device-readings) for more details. 

## Additional notes

> [!Note]
> The device summaries use the device data history information on the device record, which updates with a slight delay (30-60min); however, you can use the **Pull Device Data** option to get the latest data from AzureIoT. The device summary is only displayed on customer assets if there is one related device, even though multiple devices can be related to one customer asset. Device summary calculations respect security roles, so will change based on the nuber of alerts, work orders, and so on that the logged-in user has access to.