---
title: Location auditing for the mobile app
description: Learn how to enable and set up location auditing for the Dynamics 365 Field Service mobile app.
ms.date: 10/25/2024
ms.topic: how-to
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Share the location from the mobile app

Field technicians often travel to various locations throughout their workday, and it's helpful for schedulers to know where technicians are at any given time.

Technicians using the Dynamics 365 Field Service mobile app can enable location sharing from the app, allowing schedulers to visualize their location on the schedule board and see their location history.

For a guided walkthrough, check out the following video. Some features have changed since this video was produced. Refer to the written documentation for accurate feature descriptions and requirements.
>
> [!VIDEO https://learn-video.azurefd.net/vod/player?id=9370c86c-629e-4979-ab82-de3724fa1a1f]

## Prerequisites

- Administrator access to Dynamics 365 Field Service.
- Read access to the *msdyn_geolocationsetting* table for the security role of mobile app users. These permissions are included with the default Field Service - Resource role.
- Field Service mobile app version 3.2501.1 or higher.

## Enable location tracking

To send a technician's location information to Field Service, enable location tracking in the web application.

1. In the Field Service web app, change to the **Settings** area.
1. Go to **Geolocation** > **Geolocation Settings**.
1. Set **Enable Location Tracking** to **Yes**.
1. Enter a **Refresh Interval (seconds)** to define how often the system checks the location information. We recommend values between 60 and 300 seconds.
1. Set the **Tracking Times** by date for when you want the system to track location data. 

### Location tracking events

The *Geolocation Tracking (msdyn_geolocationtracking)* table stores location information. Users location is captured at the frequency in the Refresh Interval. The users location is send to the server and stored only during the Tracking Times as set in configuration.  

> [!NOTE]
> Location tracking events might be sent less frequently based on the mobile device operating system. This frequency can be influenced by battery savings settings, device battery charge status, and other applications running on the device that might consume device resources.

You can audit location information with other Field Service tables. For more information, see [Auditing overview](/power-platform/admin/audit-data-user-activity).

You can configure how far back in time a geolocation is valid. This is important for scenarios when a mobile device loses internet connection, making dispatchers unaware of the true location. The time threshold can be configured in **Resource Scheduling** > **Settings** > **Administration** > **Scheduling Parameter** > **Geo Data** > **Geo Location Expires After X Minutes**.

## Ask users to allow Field Service mobile to access their location

The app prompts users to allow location access after signing in to the app. The app requests permissions for precise location that are required to update the location consistently. Revoking the listed permissions or not allowing them in the first place will keep the location tracking disabled. To change the permissions retroactively, open the app permissions settings on your mobile device and allow the permissions listed below.

## [iOS app](#tab/iOS)

To have location tracking work properly, allow the app to use **Precise Location** and set the location tracking to **Always allow** in the device settings.

## [Android app](#tab/Android)

To have location tracking work properly, complete all the following steps when prompted. Depending on the Android OS version, some steps might not appear or might look slightly different.

1. In the Field Service mobile app, select **Start location tracking** or **Update settings**.
1. Select **Precise Location** and then **Allow all the time** to ensure the app uses the accurate location.
1. Set **Battery optimization** to **Don't optimize** to allow the Field Service app to update the location consistently.

## [Windows app](#tab/Windows)

Location tracking is currently not available in the Dynamics 365 Field Service Windows app that you can get from the Microsoft Store.

---

## Verify that location tracking works

In the Field Service web application, open the schedule board and select a resource that has location tracking enabled. The current location of the resource appears on the schedule board map. Select the map pin icon next to see the resource's detailed location.

> [!NOTE]
> Dispatchers can use current locations for schedule assistant travel time calculations by selecting **Real time mode** in the schedule assistant filter pane. For more information, see [Advanced filters for the schedule assistant](../schedule-assistant-advanced-filters.md).
> Field Service mobile apps for iOS and Android below version 3.2501.1 no longer support location tracking after March 17, 2025. Users with older apps should upgrade their Field Service mobile app to continue sending location data. 

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
