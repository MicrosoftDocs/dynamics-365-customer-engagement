---
title:  Create geofences around locations
description: Learn how to create and use geofences for the Dynamics 365 Field Service mobile app.
ms.subservice: field-service-mobile
ms.date: 08/28/2024
author: JonBaker007
ms.author: jobaker
ms.topic: how-to
---

# Create geofences around locations

A geofence is a virtual perimeter around a specific location. Geofencing allows users to draw zones around places of work, customer sites, and secure areas. You can configure the system to trigger various actions when geofences are crossed by a person or an equipped vehicle.

In Dynamics 365 Field Service, the default use case for geofencing is to create a circular perimeter around a service account location and compare it to the changing location of field technicians as measured by their mobile devices running the Field Service mobile app. When a work order geofence is crossed by a field technician, a **geofence event** record is created and the geofence status is changed from **outside** to **inside**, indicating the field technician is inside the geofence. Another geofence event is created as the field technician leaves the geofenced area. Based on entering or leaving a geofenced area, a mobile push notification or custom workflow can be triggered.

## Prerequisites

- [Connect to Bing Maps](../field-service-maps-address-locations.md#connect-to-maps) to locate service accounts.

- [Set up auto geocoding for addresses](../turn-on-auto-geocoding.md) to automatically geocode accounts and work orders when addresses are entered. Geocoding an account or work order record populates latitude and longitude values, which are required to place geofences.

- [Enable location tracking, sharing, and auditing](track-technician-location.md) and test location tracking.

## Verify geofence processes are active

Go to **Advanced settings** in the legacy settings area and open **Processes** to ensure the following processes are in an *Active* state:

- ```DeleteGeofenceWhenBookingIsCompletedOrCanceled```
- ```GenerateGeofenceWhenBookingIsCreated```
- ```Update Geofence instance coordinates```

If you have **Enhanced Background Processing** (Preview) set to _Yes_ in [Field Service Settings](../configure-default-settings.md#other-settings), enable the geofence Power Automate flows. In this case, you don't need these processes.

1. Go to https://make.powerapps.com/ and select your environment.
1. Go to **Solutions** > **Geofencing for Field Service**.
1. Enable the following flows:
   - **Flow – DeleteGeofenceWhenBookingIsCompletedOrClosed**
   - **Flow – GenerateGeofenceWhenBookingIsCreated**
   - **Flow – UpdateGeofenceInstanceCoordinates**

## Configure geofencing settings

1. In the Field Service web app, change to the **Settings** area.
1. Go to **Geofencing** > **Geofencing Settings**.
1. Enter a **Unit of Measure** and **Minimum Radius**. The smallest geofence that the system supports has a radius of 25.59 feet.

## Configure geofence entities

Configure the settings for the entities that use geofences. Custom geofences using entities other than accounts and bookable resources are supported.

1. In the Field Service web app, change to the **Settings** area.
1. Go to **Geofencing** > **Entity Configurations**.
1. Select **Account entity configured for tracking**.
1. Enter the following information:

   - **Entity:** Select **Account** because work order locations are inherited from the related service account.
   - **Latitude / Longitude:** Choose the latitude and longitude fields on the account entity that holds the geo coded location; this setting will determine the center of the geofence.
   - **Enabled As:** Select **Geofence** because the account serves as a static location that a geofence will surround.
   - **Default Radius:** Enter a number to represent the radius of the geofence around the latitude and longitude of the account location. The unit of measure will be the unit chosen in the geofence settings in the previous step.

1. Save your changes and select the **Bookable resource entity configured for tracking**.
1. Enter the following information:

   - **Entity:** Select **Bookable Resource** to compare the location of field technicians relative to the service account of the work order.
   - **Latitude / Longitude:** Choose the latitude and longitude fields on the bookable resource entity that hold the most recent coordinates of the location.
   - **Timestamp Field Name:** Choose the location time stamp. This time stamp represents the date and time when the geofence location was updated. Geofence status will be updated only if the status is different than the current status and the time stamp is more recent than the time stamp associated with the current geofence status.
   - **Enabled As:** Select **Geo tracked** because the bookable resource has a variable location that is compared against defined geofences.

## Understand what happens when booking a work order

Booking a work order now triggers an asynchronous workflow that creates a geofence. To view the geofences that the system created, go to **Field Service** > **Settings** > **Geofences**.

:::image type="content" source="../media/geofence-created.png" alt-text="Screenshot of Field Service showing a list of active geofences.":::

Before traveling to the work order location, the technician is outside the geofence and the system creates an *exit geofence* event. When a technician arrives at the location and opens the Field Service mobile app, an *enter geofence* event is created.

Entering a geofence also changes the related geofence **Geo tracked record status** from **Outside** to **Inside**.

When the technician leaves the geofence, another "exit" event will be created.

> [!TIP]
> For testing purposes, if you can't physically travel to a location, expand the geofence radius to include your current location.

## Manage geofence trigger filters

Geofence trigger filters define when a geofence event will trigger, relative to time values of the booking.

When geofencing is enabled, the system creates geofences for all bookings, which can result in performance issues if there are many bookings. Geofence trigger filters allow you to define a time window within which the geofence will be created and events can be triggered. Along with performance improvements, these filters can help avoid false-positive geofence events. By filtering upcoming service appointments, you can avoid a scenario where a technician inadvertently travels through a geofence that isn't currently their active engagement.  

When trigger filters are enabled, you can set time-based filters. Filtered fields include:

- **Start Time**
- **End Time**
- **Actual Arrival Time**
- **Created On**
- **Estimated Arrival Time**
- **Modified On**
- **Offline Time Stamp**
- **Record Created On**

You can then set a value in days before or after the related date for the filter.

For example, it could enable trigger filters based on start time with last/next days value of one. The system now only creates a geofence and triggers events for bookings that start between yesterday and tomorrow.

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
