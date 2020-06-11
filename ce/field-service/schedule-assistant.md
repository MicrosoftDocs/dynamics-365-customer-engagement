---
title: "Schedule assistant in Dynamics 365 Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 06/11/2020
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

# Introduction to Schedule Assistant

// Please use this video to write this doc: https://youtu.be/QOrePYZ9fds i dont expect everything in the video to be in the doc nor does the doc need to follow the video structure

- what is the schedule assistant
  - semi automated
  - makes recommendations
- how does it help dispatchers
- how does it help organizations

// link to video https://youtu.be/QOrePYZ9fds


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant1.png)


## Prerequisites
The Schedule Assistant is a capability of the Universal Resource Scheduling solution that is included and installed with Dynamics 365 Field Service, Dynamics 365 Project Service Automation, Dynamics 365 Customer Service

> [!Note]
>



## Matching requirements and resources

- a work order will have things like location, time, territory, and time windows. when a work order is created, a resource requirement is automatically created and you can add more details like characteristics, roles, business units, and resource preferences.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant2.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant3.png)

those details will be used to match resources who have many of the same attributes

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant4.png)

## Trigger schedule assistant

you can run the schedule assistant from the schedule board, the top of the work order form, the top of the requirement form, and from the list after selecting one work order record

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant7.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant8.png)


## Filters

details from the work order and requirment appear in the schedule assistant filter and can be edited at the time of scheduling

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant9.png)


### Location

based on the work order location and location of resources, schedule assistant filters resources outside defined radius and then displays estimated driving time to get to the work order location

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant-schedule-board.png)

The same travel time calculations are diplayed in the grid view of the schedule assistant


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant-travel-times.png)

## Reschedule


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant-rebook.png)

## Book the same work order again

In addition, you can schedule the same job to multiple resources with the schedule assistant too.

Simply trigger the schedule assistant and book it to a resources time slot. But before selecting exist search, simply select another resources time slot and select book again.


## Book entities other than work orders


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant-book-leads.png)

for more info [Enable an entity for scheduling](../field-service/schedule-new-entity.md)   

## Multi-resource scheduling (Requirement groups)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant-requirement-group.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-schedule-assistant-requirement-group-assistant.png)

for more info [Multi-resource scheduling with Requirement groups](../field-service/multi-resource-scheduling-requirement-groups.md)   


## Learn more about the schedule assistant

There are many ways to use the schedule assistant for many scenarios see the following topics:

Title: https://docs.microsoft.com/en-us/dynamics365/field-service/schedule-with-travel-time
Short description:

Title: https://docs.microsoft.com/en-us/dynamics365/field-service/schedule-time-constraints
Short description:

Title: https://docs.microsoft.com/en-us/dynamics365/field-service/resource-preferences
Short description:

Title: https://docs.microsoft.com/en-us/dynamics365/field-service/quick-scheduling
Short description:

Title: https://docs.microsoft.com/en-us/dynamics365/field-service/schedule-multi-day-work
Short description:

Title: https://docs.microsoft.com/en-us/dynamics365/field-service/resource-crews
Short description:

Title: https://docs.microsoft.com/en-us/dynamics365/field-service/resource-pools
Short description:

Title: https://docs.microsoft.com/en-us/dynamics365/field-service/facility-scheduling
Short description:

## Configuration considerations
## Additional Notes