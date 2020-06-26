---
title: "Schedule assistant advanced filters | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 06/25/2020
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Schedule assistant advanced filters

// use video https://youtu.be/s6yvVv99Bnw


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant-advanced-filters.png)

## Prerequisites

The schedule assistant is a part of the Universal Resource Scheduling solution, which is included and installed with Dynamics 365 Field Service, Project Service Automation, and Customer Service.

> [!Note]
>



## Real time mode

The schedule assistant will use the location of the technician's mobile device when calculating the estimated travel time to arrive at the work order location. The "real time" location is displayed on the schedule board map as a truck icon.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant-real-time-mode.png)

The location of the mobile device is collected from the time of the last sync up to a defined threshold in the past. The time threshold for when the location of a previous sync is acceptable is defined in the **Geo Location Expires After X Minutes** in scheduling paramters (**Resource Scheduling app > Settings > Administration**)

See the topic on [geofencing]() to learn how to set up location auditing and sharing.



## Ignore travel time

Schedule assistant will ignore the estimated travel time when determining if a resource has enough time available in his or her schedule.

## Ignore duration

Schedule assistant will ignore the requirement duration when determining if a resource has enough time available in his or her schedule.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant-ignore-duration.png)


## Ignore proposed bookings

Schedule assistant will ignore bookings where the Booking status is Proposed and treat that time slot as available.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant-ignore-proposed.png)

## Allow overlapping

The schedule assistant will double book in addition to bookings where the Allow Overlap field is set to Yes.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant-allow-overlapping.png)


## Configuration considerations

### Default values and sorting

Schedule assistant retreive constraints query


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant-retreive-resources-query.png)


## Additional Notes