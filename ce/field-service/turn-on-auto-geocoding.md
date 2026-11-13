---
title: Enable automatic address geocoding
description: Automatic address geocoding in Dynamics 365 Field Service generates coordinates for service accounts and resources. Follow these steps to enable and use it.
ms.custom: 
  - dyn365-fieldservice
ms.date: 11/12/2026
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
ms.reviewer: v-wesmith
---

# Enable automatic address geocoding

Geocoding is the process of transforming text-based address descriptions into geographical coordinates. Dynamics 365 Field Service uses coordinates to estimate travel times when scheduling a work order to a resource.
  
The **Auto Geo Code Addresses** setting enables the system to automatically get coordinates (latitude and longitude) based on the address of a service account or a resource.  
  
## Prerequisites

To use geocoding or location services, [connect to maps](field-service-maps-address-locations.md#connect-to-maps).

## Enable automatic geocoding  
  
1. In Field Service, change to the **Settings** area and then choose **Field Service Settings**.  
  
1. In the **Other** tab, set **Auto Geo Code Addresses** to **Yes**.  

   :::image type="content" source="media/auto-geo-code-addresses-setting.png" alt-text="Screenshot of Field Service Settings with Auto Geo Code Addresses setting enabled.":::
  
1. Select **Save & Close**.  

The geocoding process in Field Service uses only one street field (**Street1**). The process ignores additional information like apartment number in **Street2** and **Street3**. Don't add the extended information to **Street1**. The string length could be too long to process.

> [!TIP]
> When the system finds no geocode match, it returns the value (0,0). Any custom logic that uses geocoding should ignore these results to avoid incorrect locations and travel routes.

## Get coordinates for an address on a record  
  
1. Open a [service account](accounts.md#create-a-service-account) or a [functional location](functional-locations.md).  
  
1. Ensure the service address is accurate.  
  
1. Select **Geo Code** on the command bar.

   :::image type="content" source="media/geo-code-control.png" alt-text="Screenshot of the Geo Code option on an Account form.":::
  
1. On the map dialog box, ensure you have the correct address, and then select **Ok**.
  
[!INCLUDE[footer-include](../includes/footer-banner.md)]
