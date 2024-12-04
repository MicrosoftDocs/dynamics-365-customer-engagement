---
title: Enable automatic address geocoding
description: Learn how to enable auto geocoding to generate coordinates for addresses in Dynamics 365 Field Service.
ms.custom: 
  - dyn365-fieldservice
ms.date: 11/04/2024
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
---

# Enable automatic address geocoding

Geocoding is the process of transforming text-based address descriptions into geographical coordinates. Dynamics 365 Field Service coordinate to estimate travel times when scheduling a work order to a resource.
  
The **Auto Geo Code Addresses** setting enables the system to automatically get coordinates (latitude and longitude) based on the address of a service account or a resource.  
  
## Prerequisites

To use geocoding or location services, you need to enable on maps. For more information, see [Connect to maps](field-service-maps-address-locations.md#connect-to-maps).

## Enable automatic geocoding  
  
1. Open the **Field Service** app.

1. Change to the **Settings** area and then choose **Field Service Settings**.  
  
1. In **Other** tab, set **Auto Geo Code Addresses** to **Yes**.  

   :::image type="content" source="media/auto-geo-code-addresses-setting.png" alt-text="Screenshot of Field Service Settings with Auto Geo Code Addresses setting enabled.":::
  
1. Select **Save**.  

The geocoding process in Field Service uses only one street field (**Street1**). Additional information like apartment number in **Street2** and **Street3** is ignored. Don't add the extended information to **Street1**. The string length could be too long to process.

> [!TIP]
> When the system finds no geocode match, it returns the value (0,0). Any custom logic that uses geocoding should ignore these results to avoid incorrect locations and travel routes.

## Get coordinates for an address on a record  
  
1. Open a work order or a service account.  
  
2. Ensure the address is accurate.  
  
3. On the command bar, select **Geo Code**.

   :::image type="content" source="media/geo-code-control.png" alt-text="Screenshot of the Geo Code option on an Account form.":::
  
4. On the map dialog box, make sure you have the correct address, and then select **Change**.
  
[!INCLUDE[footer-include](../includes/footer-banner.md)]
