---
title: "Schedule assistant advanced filters | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 07/06/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Advanced filters for the schedule assistant

Beyond the standard filters exposed within the schedule assistant's filter panel, you'll find a few advanced filters that provide additional granularity for scheduling needs.

> [!div class="mx-imgBorder"]
> ![Screenshot of the advanced filters exposed in the schedule assistant](./media/scheduling-schedule-assistant-advanced-filters.png)

In this article, we'll take a look at the schedule assistant's advanced filters:

- Real-time mode
- Ignore travel time
- Allow overlapping
- Ignore duration
- Ignore proposed bookings

## Prerequisites

The schedule assistant is a part Universal Resource Scheduling, which is included and installed with Dynamics 365 Field Service, Project Service Automation, and Customer Service.

## Real-time mode

The schedule assistant will use the location of the technician's mobile device when calculating the estimated travel time to arrive at the work order location. The "real time" location is displayed on the schedule board map as a truck icon.

Filtering by real-time mode can be useful in emergency scenarios where a dispatcher needs to book the closest possible resource, so that they can arrive onsite more quickly.

> [!div class="mx-imgBorder"]
> ![Screenshot of the hourly view of the filter and map view, showing a truck icon on the map.](./media/scheduling-schedule-assistant-real-time-mode.png)

The mobile device's location is collected from the time of the last sync to a defined threshold in the past. The time threshold for when the acceptable location of a previous sync is defined in the **Geo Location Expires After X Minutes**. You can find this setting in scheduling parameters by going to **Resource Scheduling app** > **Settings** > **Administration**.

See the article on [geofencing](geofencing.md) to learn how to set up location auditing and sharing.

## Ignore travel time

Sometimes, a dispatcher may want to book another job when they know the proposed technician is good to work overtime, and may not mind additional travel time to get to another booking.

For cases when the calculated travel time is not needed, selecting **Ignore travel time** in the schedule assistant's advanced filters will produce results that ignore the estimated travel time when determining if a resource has enough time available in their schedule.

## Ignore duration

The schedule assistant will ignore the requirement duration when determining if a resource has enough time available in their schedule.

> [!div class="mx-imgBorder"]
> ![Screenshot of the schedule assistant filter view with "ignore duration" selected.](./media/scheduling-schedule-assistant-ignore-duration.png)

## Ignore proposed bookings

Many organizations will mark their bookings as **Proposed** until a customer or client commits to the work. In such cases, dispatchers may want to see available resources that are not yet fully committed to the proposed work in their schedules.

With the **Ignore proposed bookings** advanced filter, the schedule assistant will ignore bookings where the Booking status is **Proposed**, and will treat that time slot as available.

> [!div class="mx-imgBorder"]
> ![Screenshot of the schedule assistant filter view, with "ignore proposed bookings" selected.](./media/scheduling-schedule-assistant-ignore-proposed.png)

## Allow overlapping

The schedule assistant will double book in addition to bookings where the **Allow Overlap** field is set to **Yes**.

> [!div class="mx-imgBorder"]
> ![Screenshot of a bookable resource booking, where "allow overlapping" is set to "yes."](./media/scheduling-schedule-assistant-allow-overlapping.png)

## Configuration considerations

### Default values and sorting

When the schedule assistant is triggered, you'll see that some fields have default values. These default values can be changed in the **Schedules Assistant Retrieve Constraints Query**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Schedules Assistant Retrieve Constraints Query. ](./media/scheduling-schedule-assistant-retreive-resources-query.png)

To get there, double-click on the schedule board. Open default settings. Under the schedule types section, select the gear icon next to **Default Retrieve Constraints Query**.

From here, you can edit the XML to define how the schedule assistant searches for each entity that is available for scheduling.