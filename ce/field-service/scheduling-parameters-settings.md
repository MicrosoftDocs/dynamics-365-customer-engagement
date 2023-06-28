---
title: Configure scheduling parameters
description: Learn about settings related to resource scheduling in Dynamics 365 Field Service.
ms.date: 02/23/2023
ms.topic: conceptual
author: clearab
ms.author: anclear
---

# Configure scheduling parameters

In Dynamics 365 Field Service, open the **Resources** area. Under **Administration**, select **Scheduling Parameters** and select **Resource Scheduling** from the list.

## General

| Options | Descriptions |
| --- | --- |
| Schedule board refresh interval | Defines how often the schedule board will refresh. |
| Auto update booking travel | Enable or disable automatic updates to travel time and distance on the hourly view of the schedule board. |
| Include Appointments | Enable [tracking of appointments for resources](./appointment-scheduling.md) on the schedule board. |
| Disable sanitizing HTML templates | Disables sanitizing of custom [HTML template for bookings](./booking-template.md). May cause the schedule board to not load or behavior unexpectedly if invalid HTML templates are used. |
| Connect to Maps | Determines if a [mapping service](./field-service-maps-address-locations.md) will be used to calculate travel and display maps. |

## Schedule assistant

| Options | Descriptions |
| --- | --- |
| Default radius value    |   Select a default radius the schedule assistant will use when searching for resources for  work orders. For example, if you choose a 20-mile radius, then the schedule assistant will find resources within 20 miles of the work order  booking location.   |
| Default radius unit     |    Select miles or kilometers.      |

## Geo data

Field Service integrates with third-party providers to allow the real-time location of resources or vehicles on schedule maps. These settings allow you to map the integrated location data to the Field Service system.
  
|  Options  |  Description   |  
|-------------|-----------------|  
| Custom GPS data | Select whether the system will use a custom entity for its source of geo locations for resources on the map view.|  
| Custom GPS resource field | Shows the logical name of the resource for geo locations.|  
| Custom GPS latitude field | Shows the logical name of the latitude for geo locations.|  
| GPS location expires after X minutes | Enter the number of minutes after which the GPS location expires.|  
| Custom GPS location entity | Shows the logical name of customer entity for geo locations.|  
| Custom GPS timestamp field | Shows the logical name of the timestamp or geo locations.|  
| Custom GPS longitude field | Show the logical name of the longitude for geo locations.|  
|  Geolocation refresh interval seconds    |   How often the system checks for updated geolocation of frontline workers mobile device (Field Service (Dynamics 365 mobile app)) or custom GPS device.   |
|  Geolocation expires after X minutes   |   The time threshold for how long the geolocation of a previous sync persists. As an example, if set to 60 minutes, the geolocation of a frontline worker synced 60 minutes persists and shows as their current location on the schedule board. After 61 minutes, the location reverts to the location of the previous work order or the resource's starting location.    |

## Resource Scheduling Optimization

This section shows only if your organization uses [Resource Scheduling Optimization](rso-overview.md).

| Options | Descriptions |
| --- | --- |
|  Enable Resource Scheduling Optimization    |   Enables or disables automated scheduling in the environment.   |
|  Default Goal   |   An [Optimization Goal](rso-optimization-goal.md) is what the Resource Scheduling Optimization solution aims to optimize. An example of a goal is to maximize working hours or minimize travel time. A default goal helps speed up interactions with Resource Scheduling Optimization within the schedule board by predefining how the engine optimizes data. [Single Resource Optimization](single-resource-optimization.md) is the default goal.  |
