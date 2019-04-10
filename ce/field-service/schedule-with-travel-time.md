---
title: "Schedule with travel time | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 04/08/2019
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

# Schedule with travel time

Field Service organizations often perform preventative maintenance, inspections, repairs, and other types of service at their customers' locations by having field technicians travel to multiple customer sites each day, and rely on Dynamics 365 for Field Service to manage locations and routes. This makes understanding and minimizing travel time crucial for the field service organization's success.

Using Bing Maps API by default, Field Service calculates the driving travel time and distance as field technicians travel:

1. from their personal address to a work order location
2. from a company address to a work order location
3. from their current work order location to the next work order location
4. from their current location to a work order location (typically for high priority emergencies)

In this article, let's explore how travel time and distance is calculated and visualized for dispatchers during manual scheduling, semi-automated scheduling with the schedule assistant, and automated scheduling with resource scheduling optimization (RSO).

## Prerequisites
1. [Connect your Dynamics 365 environment to Bing Maps](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/perform-initial-configurations-setup#step-1-resource-scheduling) in order to locate resources (field technicians) and work orders, and later calculate the travel time and distances between them.
   
2. [Set auto geo code addresses to **yes**](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/perform-initial-configurations-setup#step-2-field-service-settings) in order to automatically geo code accounts and work orders when addresses are entered. Geo coding an account or work order record populates latitude and longitude values, which are required for travel time and distance calculations.

3. After you have connected your environment to Bing Maps, ensure your resources (field technicians) have defined starting and ending locations. Resources (field technicians) must have geo coded starting/ending locations in order to calculate travel times and distances from their starting location to work orders and all on site requirements generally for their first job of the day. See the topics on [setting up bookable resources](./set-up-bookable-resources.md) and [using resource types to locate resources](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/set-up-bookable-resources#configuration-considerations).

4. Understand that only requirements where **Work Location = Onsite** and have **latitude and longitude values** are eligible for travel time calculations. A work location of **Location Agnostic** implies the location of the requirement should not be considered and a work location of **Facility** implies the customer will travel to the organization's location and thus the location of the resource (field technician) should not be considered. By default, work order requirements have a work location of onsite, but default work location can be edited for each scheduleable entity in **Resource Scheduling > Settings > Enable Resource Scheduling for Entities >** then double click an **Enabled Entity**.

In the image below a work order has Work Location set to Onsite and this is passed to the related work order requirement. When that work order requirement is scheduled to a resource, the system will look at the work location field along with the location of the requirement and the resource to calculate travel time.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-work-order-location-onsite.png)

> [!Note]
>



## Visualize travel time on the schedule board

After a requirement is scheduled to a resource, the booking appears on the schedule board and if applicable, travel time is displayed as a line before.

In the image below, the travel time to the customer's location is 23 minutes and the estimated duration of the work order is 2 hours giving the booking a total duration of 2 hours and 23 minutes.
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-booking-travel-time.png)


If you do not want travel time displayed differently than the working duration, then you can deselect **Show Travel Duration** in the schedule board configuration and the travel time and working duration will appear as one solid block with the same total time (in this case 2 hours and 23 minutes). 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-board-show-travel-duration.png)

As a field technician completes work, he or she may update the booking status as traveling in which case the system will track the time the booking status = traveling and update the **Actual Travel Duration** accordingly, though this will not be displayed on the schedule board.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-board-travel-status.png)

However when the booking is completed the working duration is updated.



## Add travel time with manual scheduling



## Add travel time with schedule assistant


## Add travel time with resource scheduling optimization (RSO)

  - leave time to travel home
  - graph showing travel to work chart
  - 

## Consider traffic when scheduling

  - display traffic on the schedule board
  - real time traffic is not supported
  - bing maps api can use historical information

## Configuration considerations

- travel charge
- real time location travel time
- can use other map services for travel time calculations

## Additional notes

- travel time is only driving time, not walking or flying
- historical travel time is currently not included
- consider processes to support what happens if travel time is long and technician is running late
