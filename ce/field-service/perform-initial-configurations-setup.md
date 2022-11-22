---
title: "Perform initial configurations (Dynamics 365 Field Service) | MicrosoftDocs"
description: Learn about how to perform initial configurations for Dynamics 365 Field Service.
ms.date: 09/08/2022
ms.reviewer: mhart

ms.topic: article
author: jshotts
ms.author: jasonshotts
ms.manager: shellyhaverkamp
search.app: 
  - D365CE
  - D365FS
---

# Perform initial configurations in Dynamics 365 Field Service

After installing Dynamics 365 Field Service, there are a few important initial configurations, whether you're using the application for learning, development, testing, demonstrations, or live usage.

Estimated Duration: 10 minutes

## Prerequisites

1. A Dynamics 365 environment with the Field Service app installed.  
2. Verify you can sign into Dynamics 365 with a **system administrator** security role.

## Make sure the Field Service application is installed

Sign in as a system administrator and verify that you can select the Field Service application from the published apps. Try [installing Field Service](install-field-service.md) again if you don't see it listed.

:::image type="content" source="media/admin-apps.png" alt-text="Screenshot of the Dynamics 365 apps list.":::

## Step 1: Field Service settings

Review Field Service settings.

1. In the **Field Service** app, open the **Settings** area.

1. Go to **General** > **Field Service Settings** > **Work Order / Booking** tab.

1. Optionally, enter a Work Order Prefix and Work Order Starting Number.

## Step 2: Resource scheduling

### Scheduling parameters

Field Service needs latitude and longitude values for service account records to estimate travel times when scheduling a work order to a resource.

First, make sure the environment us connected to the Bing Maps service. For more information, see [Connect to maps](field-service-maps-address-locations.md#connect-to-maps).

Then, enable **Auto Geo Code Addresses** to let the system help assign coordinates to an address. For more information, see [Turn on auto geocoding to calculate estimated travel time](turn-on-auto-geocoding.md).

Later in this article, we'll test geocoding and location services to make sure they're working properly.

### Enable resource scheduling for entities

Next up, navigate to **Resource Scheduling > Administration > Enable Resource Scheduling for Entities**.

> [!div class="mx-imgBorder"]
> ![Screenshot of Enabling entities for scheduling.](media/Perform-Initial-Configurations-image8.png)  

Administrators decide which entities can be scheduled to resources. A solution called [Universal Resource Scheduling](universal-resource-scheduling.md) adds scheduling capabilities to entities and provides the schedule board. Any entity (including custom entities) can be enabled for scheduling; typical examples include cases, opportunities, and orders.

Verify that work orders are enabled for resource scheduling.

### Enable map and location settings

To enable maps and location settings on work orders and other relevant records:

1. Connect to map service.
2. Enable auto geocoding of addresses.
3. Enable address suggestions.
4. Enable Bing Maps (Show Bing Maps on forms).

For more information, see [Location and map settings](field-service-maps-address-locations.md).

## Step 3: Test geocoding

Finally, let’s test geocoding.

Geocoding is associating a latitude and longitude to an address. Coordinates allow dispatchers to locate work orders more effectively than an address.

1. In the **Field Service** app, open the **Service** area.

1. Go to **Scheduling** > **Work Orders** and select **+New**.

1. In the **Location** tab, begin typing an address to see suggestions.

   :::image type="content" source="media/address-suggestion.png" alt-text="Screenshot of suggested addresses on a work order form.":::

Choose a suggested address and the system fills in the rest of the details in the form, including the latitude and longitude,

>[!TIP]
> It's more common to provide addresses for service account records than on work orders directly. If you create a work order for a service account, the address is pulled automatically.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
