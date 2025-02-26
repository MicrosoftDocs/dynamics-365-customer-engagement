---
title: Track location data
description: Learn how to enable and set up location tracking for the Dynamics 365 Field Service mobile app.
ms.date: 02/26/2025
ms.topic: how-to
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Track location data

Field technicians often travel to various locations throughout their workday, and it's helpful for schedulers to know where technicians are at any given time.

An administrator enables location tracking for the Dynamics 365 Field Service app and technicians enable location sharing from the mobile app. Schedulers can visualize technician's locations on the schedule board and see their location history.

For a guided walkthrough, check out the following video.
>
> [!VIDEO https://learn-video.azurefd.net/vod/player?id=9370c86c-629e-4979-ab82-de3724fa1a1f]

## Prerequisites

- Administrator access to Dynamics 365 Field Service.
- Read access to the *msdyn_geolocationsetting* table for the security role of mobile app users. These permissions are included with the default Field Service - Resource role.

## Enable location tracking

To send a technician's location information to Field Service, enable location tracking in the web application.

1. In the Field Service web app, change to the **Settings** area.

1. Go to **Geolocation** > **Geolocation Settings**.

1. Select the current setting or create a new one.

1. Set **Enable Location Tracking** to **Yes**.

1. Enter a **Refresh interval** in seconds to define how often the system checks the location information. We recommend values between 60 and 300 seconds.

1. Set the **Tracking Times** by date for when you want the system to track location data. For 24 hours, select 12:00 am to 12:00 am.

1. Select **Save & Close**.

## Share location from the mobile app

The app prompts users to allow location access after signing in to the app. The app requests permissions for precise location that are required to update the location consistently. Revoking the listed permissions or not allowing them in the first place keeps the location tracking disabled. To change the permissions retroactively, open the app permissions settings on your mobile device and allow the permissions.

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

In the Field Service web application, open the schedule board and select a resource that has location tracking enabled. The current location of the resource appears on the schedule board map.

> [!NOTE]
> Dispatchers can use current locations for schedule assistant travel time calculations by selecting **Real time mode** in the schedule assistant filter pane. For more information, see [Advanced filters for the schedule assistant](../schedule-assistant-advanced-filters.md).

### Location tracking events

The *Geolocation Tracking (msdyn_geolocationtracking)* table stores location information. Users location is captured at the frequency in the **Refresh interval**. The users location is sent to the server and stored only during the set **Tracking Times**. You can view the table in Power Apps.

> [!NOTE]
> Location tracking events might be sent less frequently based on the mobile device operating system. The frequency might be influenced by battery savings settings, device battery charge status, and other applications running on the device that might consume device resources.

<!--- According to Eric Dipple from FastTrack, you can't audit this table.
You can audit the location information. Turn on auditing for your environment and then for the *Geolocation Tracking (msdyn_geolocationtracking)* table. For more information, go to [Manage Dataverse auditing](/power-platform/admin/manage-dataverse-auditing).--->

You can configure how far back in time a geolocation is valid. This setting is important for scenarios when a mobile device loses internet connection, making dispatchers unaware of the true location. The time threshold can be configured in **Resource Scheduling**  **Settings** area. Select **Administration** > **Scheduling Parameter**. On the **Geo Data** tab, select **Geo Location Expires After X Minutes**.

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
