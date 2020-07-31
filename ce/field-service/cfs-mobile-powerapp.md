---
title: "Connected Field Service on Field Service (Dynamics 365) mobile app | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 07/31/2020
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Connected Field Service on Field Service (Dynamics 365) mobile app

Organizations that are using Connected Field Service to create work orders from IoT data can provide technicians with IoT data and Connected Field Service actions to improve onsite service delivery.

Most often technicians will use Connected Field Service to

1) **view IoT data** related to assets to better understadn the context of a repair
2) **register new IoT devices** when installing and asset to connect it to Azure IoT or a custom IoT provider
3) **send commands** to troubleshoot issues

// use for more details https://msit.microsoftstream.com/video/45cca3ff-0400-a521-d802-f1ead10982ec?list=studio

With the latest version of Field Service and the Field Service (Dynamics 365) mobile app technicians will find Connected Field Service entities in the sitemap. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-fsm-powerapp-site-map.png)

## Prerequisites

Connected Field Service is included with Field Service

Set up Connected Field Service

Set up Field Service (Dynamics 365) mobile app - latest mobile app and latest Field Service version

Internet connection, not offline
> [!Note]
>

## View summary tiles and device readings

While performing a work order for an asset, technicians may want to view recent IoT data for devices related to that asset. 

Go to the customer asset record and on the summary tab you will find summary tiles.

Summary tiles give an overview of recent IoT activity related to the asset.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-fsm-powerapp-summary-tiles.png)

Furthermore, go to the Device Readings section to view the most recent IoT measurements plotted on a graph.

Summary tiles and device readings are only visible after an asset is related to a connected device. Otherwise this information is displayed on the IoT device.

## Register new IoT Devices


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-fsm-powerapp-commands.png)

## Troubleshoot by sending commands



## Configuration considerations
## Additional Notes