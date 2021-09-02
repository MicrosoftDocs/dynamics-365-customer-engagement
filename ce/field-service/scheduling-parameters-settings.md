---
title: "Scheduling Paramters in Resource Scheduling (Settings) | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 09/02/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
ms.suite: ""
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app:
- D365CE
- D365FS
---

# Scheduling Paramters in Resource Scheduling (Settings)

## General


| Options | Descriptions |
| --- | --- |
|  Default radius value    |   Select a default radius the schedule assistant will use when searching for resources for  work orders. For example, if you choose a 20 mile radius, then the schedule assistant will find resources within 20 miles of the work order  booking location.   |
|  Default radius unit     |    Select miles or kilometers.      |

## Geo Data

 [!INCLUDE[pn_field_service](../includes/pn-field-service.md)] can be integrated with third-party GPS providers to allow the real-time location of resources or vehicles on schedule maps. These settings allow you to map the integrated GPS data to the [!INCLUDE[pn_field_service](../includes/pn-field-service.md)] system.  
  
|  Options  |  Description   |  
|-------------|-----------------|  
| Custom GPS data | Select whether the system will use  a custom entity for its source  of geo locations for resources to be displayed on the map view.|  
| Custom GPS resource field | Shows the logical name of the resource to be used for geo locations.|  
| Custom GPS latitude field | Shows the logical name of the latitude to be used for geo locations.|  
| GPS location expires after X minutes | Enter when GPS location expires.|  
| Custom GPS location entity | Shows the logical name of customer entity to use for geo locations.|  
| Custom GPS timestamp field | Shows the logical name of the timestamp to use for geo locations.|  
| Custom GPS longitude field | Show the logical name of the longitude to be used for geo locations.|  
|  Geoloaction refresh interval seconds    |   How often the system checks for updated geolocation of fronltine workers mobile device (Field Service (Dynamics 365 mobile app)) or custom GPS device.   |
|  Geolocation expires after X minutes   |   The time threshold for how long the geolocation of a previous sync should be considered acceptable. As an example, if set to 60 minutes, the geolocation of a fronltine worker synced 60 minutes ago will be considered acceptable and will show as his or her current location on the schedule board. At 61 minutes the frontline worker location will revert back to the location of the previous work order or the Resource's starting location if no work order has been scheduled.    |

## Resource Scheduling Optimization

This section is displayed if Resource Scheduling Optimization is installed in your environment.

| Options | Descriptions |
| --- | --- |
|  Enable Resource Scheduling Optimization    |   Enables or disables automated scheduling in the environment.   |
|  Default Goal   |   An [Optimization Goal](rso-optimization-goal.md) is what the resource scheduling optimization solution aims to optimize. An example of a goal is to maximize working hours or minimize travel time. A default goal helps speed up interactions with Resource Scheduling Optimization within the schedule board by predefining how the engine optimizes data. The default goal is used for [Single Resource Optimization](single-resource-optimization.md) by default.  |


