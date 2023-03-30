---
title: Enable location and map settings
description: Learn all about location and map settings and how to enable them in Dynamics 365 Field Service.
ms.date: 03/29/2023
ms.topic: article
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: clearab
ms.author: anclear
search.app:
- D365CE
- D365FS
---

# Enable location and map settings

Locations and maps are important for getting the most value out of Field Service. For example, knowing the location of work orders and resources allows the solution to effectively route the closest technician (resource) to the service request (work order).

> [!IMPORTANT]
> By connecting to a mapping service, you are allowing the system to share your data. Data includes - but is not limited to - addresses and coordinates, with external systems outside of your Microsoft Dynamics 365 environment. ("Mapping service" refers to Bing Maps or other third-party mapping service designated by you or your operating system). This also applies to Government Cloud environments. Your use of the mapping service will also be subject to their separate terms of use. Data imported from such external systems into Microsoft Dynamics 365 are subject to the [Microsoft privacy statement](https://privacy.microsoft.com/privacystatement).

## Enable Bing Maps (Show Bing Maps on forms)

Enabling maps lets dispatchers and technicians see a map view on work orders, accounts, and other records. They can also use address recommendations for quick and accurate data entry, get directions, and view real-time traffic.

Bing Maps is enabled by default for new environments outside the EU. EU customers can opt in to use Bing Maps with the privacy notice and consent to share data with an external system.

1. Go to **Advanced Settings** > **Settings** > **Administration** > **System Settings** > **General**.

1. In the **Enable Bing Maps** section, choose your option.

For more information, go to [Manage Bing Maps for your organization](/power-platform/admin/manage-bing-maps-organization).

## Connect to maps

Connecting to maps is enabled by default for new environments. To validate or change the setting, review the following steps.

1. Open the **Resource Scheduling** app.

1. Change to the **Settings** area and go to **Administration** > **Scheduling Parameters**.

1. Set **Connect to Maps** to **Yes**.

   :::image type="content" source="media/settings-connect-maps.png" alt-text="Screenshot of connect maps set to yes.":::  

1. Select **Save & Close**.

## Enable auto geocoding for addresses

Geocoding is associating a latitude and longitude to an address. It allows dispatchers to locate work orders more effectively than providing only an address.

For more information, see [Turn on auto geocoding to calculate estimated travel time](turn-on-auto-geocoding.md).

## Enable address suggestions

Address recommendations on account, work order, and booking forms let you quickly enter addresses. Recommendations help ensure accuracy and reduce errors. You can [enable address recommendations](configure-default-settings.md#other-settings) in the settings. Address recommendations are for use on account, work order, and booking forms. It's not available for customization or use on other forms and is hidden during form editing.

:::image type="content" source="media/address-suggestion.png" alt-text="Screenshot of a new work order in Field Service, showing address suggestions in a dropdown menu.":::

> [!NOTE]
> By default, the _Field Service - Resource_ security role has read-only privileges and cannot edit addresses.

## Enable booking maps

Booking maps is a feature that allows frontline workers to see their scheduled jobs on a map.

> [!div class="mx-imgBorder"]
> ![Screenshot of bookings on a map in the Field Service mobile app.](./media/mobile-2020-booking-maps.png)

For more information, see [Enable geospatial features in your environment](/powerapps/maker/canvas-apps/geospatial-overview#enable-the-geospatial-features-for-the-environment).

## Location tracking

Frontline workers often travel to various locations throughout their work day, and it's helpful for schedulers to know where frontline workers are at any given time. Frontline workers using the Field Service mobile app can enable location sharing from the app, allowing schedulers to visualize their location on the schedule board, and also audit a list showing a frontline worker's location history. For more information, see [location tracking](mobile-powerapp-location-auditing.md).

## Geofencing

A geofence is a virtual perimeter around a specific location. Geofencing allows users to draw zones around places of work, customer sites, and secure areas. You can configure the system to trigger various actions when geofences are crossed by a person or an equipped vehicle. For more information, see [Geofencing](mobile-powerapp-geofence.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
