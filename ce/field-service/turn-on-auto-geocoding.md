---
title: "Turn on auto geocoding (Dynamics 365 Field Service) | MicrosoftDocs"
description: Learn how to turn on auto geocoding in Dynamics 365 Field Service
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/08/2022
ms.topic: article
author: jshotts
ms.author: jasonshotts
search.app: 
  - D365CE
  - D365FS
---

# Turn on auto geocoding to calculate estimated travel time

Dynamics 365 Field Service needs latitude and longitude values for service account records to estimate travel times when scheduling a work order to a resource.
  
With the **Auto Geo Code Addresses** setting, the system attempts to automatically add the coordinates based on the address provided for the service account.  
  
> [!IMPORTANT]
> To use the schedule board booking functionality, geocoding, and location services, you need to turn on maps.  
>
> For more information, see [Connect to maps](field-service-maps-address-locations.md#connect-to-maps).  

## Enable on automatic geocoding  
  
1. Open the **Field Service** app.

1. Change to the **Settings** area and go to **Administration**, and then choose **Field Service Settings**.  
  
1. In **Other** tab, set **Auto Geo Code Addresses** to **Yes**.  

   :::image type="content" source="media/auto-geo-code-addresses-setting.png" alt-text="Screenshot of Field Service Settings with Auto Geo Code Addresses setting enabled.":::
  
1. Select **Save**.  

> [!NOTE]
> When geocoding an address, the only street field used is **Street1**. Additional information like apartment number in **Street2** and **Street3** will be ignored.

## Geocode the address on a record  
  
1. Open a work order or a service account.  
  
2. Ensure the address is accurate.  
  
3. On the top command bar, select **Geo Code**.

   :::image type="content" source="media/geo-code-control.png" alt-text="Screenshot of the Geo Code control on an Account view.":::
  
4. On the map dialog box, make sure you have the correct address, and then select **Change**.
  
[!INCLUDE[footer-include](../includes/footer-banner.md)]
