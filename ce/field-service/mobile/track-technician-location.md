---
title: Enable location tracking for mobile technicians
description: Enable location tracking in the Field Service mobile app so dispatchers can view technician locations and history in real time.
ms.date: 03/13/2026
ms.topic: how-to
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Enable location tracking for mobile technicians

Use location tracking to help schedulers see where field technicians are throughout the workday and make faster dispatch decisions.

An administrator enables location tracking for the Dynamics 365 Field Service app, and technicians enable location sharing from the mobile app. Schedulers can visualize technicians' locations on the schedule board and see their location history.

For a guided walkthrough, check out the following video.
>
> [!VIDEO b3ba77f0-5fc9-45ce-9067-1fee29b5be3e]

## Prerequisites

- Administrator access to Dynamics 365 Field Service.
- Read access to the *msdyn_geolocationsetting* table for the security role of mobile app users. The default Field Service - Resource role includes these permissions.

## Enable tracking

To send a technician's location information to Field Service, enable location tracking in the web application.

1. In the Field Service web app, change to the **Settings** area.

1. Go to **Geolocation** > **Geolocation Settings**.

1. Select the current setting or create a new one.

1. Set **Enable Location Tracking** to **Yes**.

1. Enter a **Refresh interval** in seconds to define how often the system checks the location information. We recommend values between 60 and 300 seconds.

1. Set the **Tracking Times** by day for when you want the system to track location data. Set the start time to occur before the end time. For 24 hours, select 12:00 AM to 11:59 PM.

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

Location tracking isn't currently available in the Dynamics 365 Field Service Windows app that you get from the Microsoft Store.

---

## Verify that location tracking works

In the Field Service web application, open the schedule board and select a resource that has location tracking enabled. The current location of the resource appears on the schedule board map.

:::image type="content" source="../media/schedule-board-current-location.png" alt-text="Screenshot of the Schedule Board map showing a technician's current location.":::

> [!NOTE]
> Dispatchers can use current locations for schedule assistant travel time calculations by selecting **Real time mode** in the schedule assistant filter pane. For more information, see [Advanced filters for the schedule assistant](../schedule-assistant-advanced-filters.md).

### Location tracking events

The *Geolocation Tracking (msdyn_geolocationtracking)* table stores location information. The app captures each user's location at the frequency set in the **Refresh interval**. The app sends and stores each user's location on the server only during the set **Tracking Times**. You can [view the table in Power Apps](/power-apps/maker/data-platform/create-edit-entities-portal?tabs=excel#view-tables).

> [!NOTE]
> Based on the mobile device operating system, the app might send location tracking events less frequently. Battery savings settings, device battery charge status, and other applications running on the device that might consume device resources can influence the frequency.

You can configure how far back in time a geolocation is valid. This setting is important for scenarios when a mobile device loses internet connection, making dispatchers unaware of the true location. Configure the time threshold:

1. In Field Service, select the **Resources** area and then **Scheduling Parameters**.

1. Open the Resource Scheduling record and select the **Geo Data** tab.

1. Select **Geo Location Expires After X Minutes** and enter the time.

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
