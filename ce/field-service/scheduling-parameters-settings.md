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

1. In Dynamics 365 Field Service, select the **Resources** area.
1. Under **Administration**, select **Scheduling Parameters**.
1. Select **Resource Scheduling** in the list.
1. Select the tab for the settings that you want to change, and then fill in the information as required. The following sections describe the settings on each tab.
1. Select **Save** to apply your changes.

## General

| Field | Description |
| --- | --- |
| Schedule Board Refresh Interval Seconds | Define how often the schedule board is refreshed. |
| Auto Update Booking Travel | Enable or disable automatic updates to travel time and distance in the hourly view of the schedule board. |
| Include Appointments | Enable [tracking of appointments for resources](./appointment-scheduling.md) on the schedule board. |
| Connect to Maps | Enable a [mapping service](./field-service-maps-address-locations.md) to calculate travel and show maps. If you want to use a specific map, enter the map API key. By default, Bing is used. |

## Schedule assistant

| Field | Description |
| --- | --- |
| Default Radius Unit | Select *miles* or *kilometers*. |
| Default Radius Value | Select the default radius that the schedule assistant uses when it searches for resources for work orders. For example, if you select a 20-mile radius, the schedule assistant finds resources within 20 miles of the work order booking location. |
| Include Outlook Free/Busy in Search Resource Availability API | Select whether the system should include the resource's Outlook schedule when it searches for resource availability in the scheduling API. |

## Geo data

Field Service integrates with third-party providers to enable the real-time location of resources or vehicles to appear on schedule maps. Use these settings to map the integrated location data to the Field Service system.

| Field | Description |
| --- | --- |
| Enable Custom Geolocation | Select whether the system should use a custom entity for its source of geolocations for resources in the map view. |
| Custom Geo Location Entity | The logical name of the customer entity for geolocations. |
| Custom Geo Resource Field | The logical name of the resource for geolocations. |
| Geo Location Refresh Interval Seconds | Define how often, in seconds, the system checks for the updated geolocation of a frontline worker's mobile device that runs Field Service (Dynamics 365 mobile app) or a custom GPS device. |
| Custom Geo Latitude Field | The logical name of the latitude for geolocations. |
| Custom Geo Longitude Field | The logical name of the longitude for geolocations. |
| Custom Geo Timestamp Field | The logical name of the timestamp for geolocations. |
| Geo Location Expires After X Minutes | Define how long, in minutes, the geolocation from a previous synchronization persists. For example, if you set the value to 60 minutes, the geolocation of a frontline worker persists for 60 minutes after synchronization and is shown as the worker's current location on the schedule board. After 61 minutes, the location reverts to either the location of the previous work order or the resource's starting location. |

## Resource Scheduling Optimization

This tab appears only if your organization uses [Resource Scheduling Optimization](rso-overview.md).

| Field | Description |
| --- | --- |
| Enable Resource Scheduling Optimization | Enable or disable automated scheduling in the environment. |
| Default Goal | An [optimization goal](rso-optimization-goal.md) is what the Resource Scheduling Optimization solution aims to optimize. Examples of optimization goals include maximizing working hours and minimizing travel time. A default goal helps speed up interactions with Resource Scheduling Optimization within the schedule board by predefining how the engine optimizes data. [Single Resource Optimization](rso-single-resource-optimization.md) is the default goal. |
