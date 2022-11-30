---
title: "Perform initial configurations (Dynamics 365 Field Service) | MicrosoftDocs"
description: Learn about how to perform initial configurations for Dynamics 365 Field Service.
ms.date: 10/13/2022
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

After [installing Dynamics 365 Field Service](install-field-service.md), set up the initial configurations from this article.

## Prerequisites

- A Dynamics 365 environment with the Field Service app installed.  
- A **system administrator** security role in the Dynamics 365 environment.

## Configure Field Service settings

Review default settings for the Field Service app.

1. In the **Field Service** app, open the **Settings** area.

1. Go to **General** > **Field Service Settings** > **Work Order / Booking**.

1. Review the all mandatory values and set optional values for your organization. For more information, go to [Set defaults for work orders, bookings, the schedule board, and agreements](configure-default-settings.md)

## Set up resource scheduling

Field Service needs latitude and longitude values for service account records to estimate travel times when scheduling a work order to a resource.

1. Make sure the environment is connected to the Bing Maps service. For more information, go to [Connect to maps](field-service-maps-address-locations.md#connect-to-maps).

1. Enable **Auto Geo Code Addresses** to let the system help assign coordinates to an address. For more information, go to [Turn on auto geocoding to calculate estimated travel time](turn-on-auto-geocoding.md).

1. Enable map and location settings on work orders and other relevant records. For more information, see [Location and map settings](field-service-maps-address-locations.md).

1. Enable resource scheduling for entities. Go to **Resource Scheduling > Administration > Enable Resource Scheduling for Entities**. Verify that work orders are enabled for resource scheduling. For more information, go to [Enable an entity for scheduling in Dynamics 365 Field Service](schedule-new-entity.md).

   Administrators decide which entities can be scheduled to resources. A solution called [Universal Resource Scheduling](universal-resource-scheduling.md) adds scheduling capabilities to entities and provides the schedule board. Any entity (including custom entities) can be enabled for scheduling; typical examples include cases, opportunities, and orders.

## Test geocoding

Geocoding maps a latitude and longitude to an address. Coordinates allow dispatchers to locate work orders more effectively than an address.

1. In the **Field Service** app, open the **Service** area.

1. Go to **Scheduling** > **Work Orders** and select **+New**.

1. In the **Location** tab, begin typing an address to see suggestions.

   :::image type="content" source="media/address-suggestion.png" alt-text="Screenshot of suggested addresses on a work order form.":::

Choose a suggested address and the system fills in the rest of the details in the form, including the latitude and longitude.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
