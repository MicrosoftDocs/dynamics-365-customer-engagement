---
title: Configure scheduling parameters
description: Learn about settings related to resource scheduling in Dynamics 365 Field Service.
ms.date: 06/28/2024
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
---

# Configure scheduling parameters

Define settings for scheduling your resources.

1. In Field Service, change to the **Resources** area. Then under **Administration**, select **Scheduling Parameters**.

1. Select **Resource Scheduling** from the list.

1. Select the tab for the settings you want to change and fill in the information, as required. Refer to the following sections for a description of the settings.

1. Select **Save** to apply your changes.

## General

| Options | Descriptions |
| --- | --- |
| Schedule Board Refresh Interval Seconds | Define how often the schedule board refreshes. |
| Auto Update Booking Travel | Enable or disable automatic updates to travel time and distance on the hourly view of the schedule board. |
| Include Appointments | Enable [tracking of appointments for resources](./appointment-scheduling.md) on the schedule board. |
| Connect to Maps | Enable a [mapping service](./field-service-maps-address-locations.md) to calculate travel and display maps. Enter the map API key if you want to use a particular map. Microsoft Bing is the default. |

## Schedule assistant

| Options | Descriptions |
| --- | --- |
| Default Radius Unit     | Select miles or kilometers.      |
| Default Radius Value    | Select a default radius FOR the schedule assistant TO use when searching for resources for work orders. For example, if you choose a 20-mile radius, then the schedule assistant finds resources within 20 miles of the work order booking location. |
| Include Outlook Free/Busy in Search Resource Availability API | Select whether the system should include the resource's Microsoft Outlook schedule when searching for resource availability in the scheduling API. |

## Geo data

Field Service integrates with third-party providers to allow the real-time location of resources or vehicles on schedule maps. These settings allow you to map the integrated location data to the Field Service system.
  
|  Options  |  Description   |  
|-------------|-----------------|  
| Enable Custom Geolocation | Select whether the system should use a custom entity for its source of geolocations for resources on the map view.|  
| Custom Geo Location Entity | Shows the logical name of customer entity for geolocations.|  
| Custom Geo Resource Field | Shows the logical name of the resource for geolocations.|
| Geo Location Refresh Interval Seconds | How often the system checks for the updated geolocation of frontline workers mobile device (Field Service (Dynamics 365 mobile app)) or custom GPS device.   |
| Custom Geo Latitude Field | Shows the logical name of the latitude for geolocations.|  
| Custom Geo Longitude Field | Show the logical name of the longitude for geolocations.|
| Custom Geo Timestamp Field | Shows the logical name of the timestamp or geolocations.|
| Geo Location Expires After X Minutes | The time threshold for how long the geolocation of a previous sync persists. As an example, if set to 60 minutes, the geolocation of a frontline worker synced 60 minutes persists and shows as their current location on the schedule board. After 61 minutes, the location reverts to the location of the previous work order or the resource's starting location. |

## Resource Scheduling Optimization

This section shows only if your organization uses [Resource Scheduling Optimization](rso-overview.md).

| Options | Descriptions |
| --- | --- |
|  Enable Resource Scheduling Optimization    | Enable or disable automated scheduling in the environment.   |
|  Default Goal   | An [Optimization Goal](rso-optimization-goal.md) is what the Resource Scheduling Optimization solution aims to optimize. An example of a goal is to maximize working hours or minimize travel time. A default goal helps speed up interactions with Resource Scheduling Optimization within the schedule board by predefining how the engine optimizes data. [Single Resource Optimization](rso-single-resource-optimization.md) is the default goal.  |
