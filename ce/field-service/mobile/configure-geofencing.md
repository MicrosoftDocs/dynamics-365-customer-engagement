---
title:  Create geofences around locations
description: Learn how to create and use geofences for the Dynamics 365 Field Service mobile app.
ms.subservice: field-service-mobile
ms.date: 09/22/2025
author: JonBaker007
ms.author: jobaker
ms.topic: how-to
---

# Create geofences around locations

A geofence is a virtual perimeter around a specific location. Geofencing lets you draw zones around places of work, customer sites, and secure areas. The system can trigger various actions when a person or an equipped vehicle crosses a geofence.

In Dynamics 365 Field Service, the default use case for geofencing is to create a circular perimeter around a service account location and compare it to the changing location of field technicians as measured by their mobile devices running the Field Service mobile app. When a field technician crosses a work order geofence, the system creates a **geofence event** record and changes the geofence status from **outside** to **inside**. This change shows the field technician is inside the geofence. The system creates another geofence event when the field technician leaves the geofenced area. Entering or leaving a geofenced area can trigger a mobile push notification or a custom workflow.

## Prerequisites

- [Connect to Bing Maps](../field-service-maps-address-locations.md#connect-to-maps) to locate service accounts

- [Set up auto geocoding for addresses](../turn-on-auto-geocoding.md) to automatically geocode accounts and work orders when addresses are entered. Geocoding an account or work order record populates latitude and longitude values, which are required to place geofences.

- [Enable location tracking, sharing, and auditing](track-technician-location.md) and test location tracking.

## Verify geofence processes are active

Geofence processes or flows can be active. If **Use Enhanced Background Processing** (Preview) is set to *Yes* in [Field Service Settings](../configure-default-settings.md#other-settings), turn on the geofence Power Automate flows. Otherwise, enable the geofence processes.

### Enable geofence processes

1. Sign in to Power Apps at [https://make.powerapps.com/](https://make.powerapps.com/) and select your solution.

1. Select **Processes** and make sure the following processes are on:

   - ```DeleteGeofenceWhenBookingIsCompletedOrCanceled```
   - ```GenerateGeofenceWhenBookingIsCreated```
   - ```Update Geofence instance coordinates```

### Enable geofence flows

1. Sign in to Power Apps at [https://make.powerapps.com/](https://make.powerapps.com/).
1. Select **Solutions** > **Geofencing for Field Service**.
1. Enable the following flows:
   - **Flow – DeleteGeofenceWhenBookingIsCompletedOrClosed**
   - **Flow – GenerateGeofenceWhenBookingIsCreated**
   - **Flow – UpdateGeofenceInstanceCoordinates**

## Configure geofencing settings

1. In the Field Service web app, go to the **Settings** area.
1. Go to **Geofencing** > **Geofencing Settings**.
1. Enter a **Unit of Measure** and **Minimum Radius**. The smallest geofence that the system supports has a radius of 25.59 feet.

## Configure geofence entities

Configure the settings for the entities that use geofences. Custom geofences using entities other than accounts and bookable resources are supported.

1. In the Field Service web app, go to the **Settings** area.
1. Go to **Geofencing** > **Entity Configurations**.
1. Select **Account entity configured for geofencing**.
1. Enter the following information:

   - **Entity:** Select **Account** because work order locations are inherited from the related service account.
   - **Latitude / Longitude:** Select the latitude and longitude fields on the account entity that holds the geocoded location. This setting sets the center of the geofence.
   - **Enabled As:** Select **Geofence** because the account is a static location that a geofence surrounds.
   - **Default Radius:** Enter a number for the radius of the geofence around the latitude and longitude of the account location. The unit of measure is the unit you chose in the geofence settings in the previous step.

1. Save your changes.
1. Select the **Bookable Resource entity configured for tracking**.
1. Enter the following information:

   - **Entity:** Select **Bookable Resource** to compare the location of field technicians relative to the service account of the work order.
   - **Latitude / Longitude:** Select the latitude and longitude fields on the bookable resource entity that hold the most recent coordinates of the location.
   - **Timestamp Field Name:** Select the location timestamp. This time stamp is the date and time when the geofence location was updated. The system updates geofence status only if the status is different from the current status and the timestamp is more recent than the timestamp for the current geofence status.
   - **Enabled As:** Select **Geo tracked** because the bookable resource has a variable location that the system compares against defined geofences.

1. Save and close.

## Understand what happens when booking a work order

Booking a work order triggers an asynchronous workflow that creates a geofence. To view the geofences that the system creates, go to **Field Service** > **Settings** > **Geofences**.

:::image type="content" source="../media/geofence-created.png" alt-text="Screenshot of Field Service showing a list of active geofences.":::

Before traveling to the work order location, the technician is outside the geofence, and the system creates an *exit geofence* event. When the technician arrives at the location and opens the Field Service mobile app, the system creates an *enter geofence* event.

Entering a geofence also changes the related geofence **Geo tracked record status** from **Outside** to **Inside**.

When the technician leaves the geofence, the system creates another "exit" event.

> [!TIP]
> For testing, if you can't physically travel to a location, expand the geofence radius to include your current location.

## Manage geofence trigger filters

Geofence trigger filters define when a geofence event triggers, based on the booking's time values.

When geofencing is on, the system creates geofences for all bookings, which can cause performance issues if there are many bookings. Geofence trigger filters let you set a time window for when the system creates geofences and triggers events. These filters improve performance and help avoid false-positive geofence events. By filtering upcoming service appointments, you avoid a scenario where a technician travels through a geofence that isn't their active engagement.

When trigger filters are on, you can set time-based filters. Filtered fields include:

- **Start Time**
- **End Time**
- **Actual Arrival Time**
- **Created On**
- **Estimated Arrival Time**
- **Modified On**
- **Offline Time Stamp**
- **Record Created On**

You then set a value in days before or after the related date for the filter.

For example, you can turn on trigger filters based on start time with a last/next days value of one. The system only creates a geofence and triggers events for bookings that start between yesterday and tomorrow.

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
