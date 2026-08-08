---
title: Enable location and map settings
description: Location and map settings in Field Service power routing, geocoding, and address suggestions. Learn how to enable maps, booking maps, and geofencing.
ms.date: 07/31/2026
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
ms.reviewer: v-wendysmith
ms.custom:
 - ai-gen-docs-bap
 - ai-seo-date: 08/07/2026
ai-usage: ai-assisted
---

# Enable location and map settings

Locations and maps are important for getting the most value out of Field Service. For example, knowing the location of work orders and resources allows the solution to effectively route the closest technician (resource) to the service request (work order).

> [!IMPORTANT]
> By connecting to a mapping service, you allow the system to share your data. Data includes, but isn't limited to, addresses and coordinates, with external systems outside of your Microsoft Dynamics 365 environment. "Mapping service" refers to the default first-party provider or other third-party mapping service designated by you or your operating system. This sharing also applies to Government Cloud environments. Your use of the mapping service is subject to their separate terms of use. Data imported from such external systems into Microsoft Dynamics 365 are subject to the [Microsoft privacy statement](https://privacy.microsoft.com/privacystatement).

## Enable maps (show maps on forms)

Enable maps so dispatchers and technicians see a map view on work orders, accounts, and other records. They can also use address recommendations for quick and accurate data entry, get directions, and view real-time traffic.

Maps are enabled by default for new environments outside the EU. EU customers can opt in to use maps with the privacy notice and consent to share data with an external system.

## Connect to maps

Connecting to maps is enabled by default for new environments. To validate or change the setting, review the following steps.

1. In Field Service, open the **Resource Scheduling** app.

1. Change to the **Settings** area and select **Administration** > **Scheduling Parameters**.

1. Set **Connect to Maps** to **Yes**.

   :::image type="content" source="media/settings-connect-maps.png" alt-text="Screenshot of the Connect to Maps setting set to Yes in Scheduling Parameters.":::  

1. Select **Save & Close**.

Enable the connection to the mapping provider to get service enhancements, such as location information for work orders and resources. When you leave the Map API field blank, Field Service pulls location and travel time information from the Mapping API on your behalf. However, admins can specify their own API key to [use custom implementations](/bingmaps/spatial-data-services/data-source-management-api). Using a custom API key incurs the costs of usage on the Azure service.

## Enable auto geocoding for addresses

Enable geocoding to associate a latitude and longitude with an address. It helps dispatchers locate work orders more effectively than by using only an address.

Go to [Turn on auto geocoding to calculate estimated travel time](turn-on-auto-geocoding.md).

## Enable address suggestions

Address recommendations on account, work order, and booking forms let users quickly enter addresses. Recommendations help ensure accuracy and reduce errors. You can [enable address recommendations](configure-default-settings.md#other-settings) in the settings. Address recommendations are for use on account, work order, and booking forms. They're not available for customization or use on other forms and are hidden during form editing.

:::image type="content" source="media/address-suggestion.png" alt-text="Screenshot of an account in Field Service, showing address suggestions in a dropdown menu.":::

> [!NOTE]
> By default, the _Field Service - Resource_ security role has read-only privileges and can't edit addresses.

## Enable booking maps

Enable booking maps so that frontline workers can see their scheduled jobs on a map.

:::image type="content" source="media/mobile-2020-booking-maps.png" alt-text="Screenshot of bookings on a map in the Field Service mobile app.":::

Go to [Enable geospatial features in your environment](/powerapps/maker/canvas-apps/geospatial-overview#enable-geospatial-features-for-the-environment).

## Location tracking

Frontline workers often travel to various locations throughout their work day, and it's helpful for schedulers to know where frontline workers are at any given time. Frontline workers using the Field Service mobile app can enable location sharing from the app, allowing schedulers to visualize their location on the schedule board, and also audit a list showing a frontline worker's location history. Learn more in [location tracking](mobile/track-technician-location.md).

## Geofencing

A geofence is a virtual perimeter around a specific location. When you enable geofencing, frontline workers can draw zones around places of work, customer sites, and secure areas. You can configure the system to trigger various actions when a person or an equipped vehicle crosses a geofence. Go to [Create geofences around locations](mobile/configure-geofencing.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
