---
title: "Schedule work for multiple days | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/12/2019
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

# Schedule work over multiple days 

Work orders for on site service and requirements for other business needs can be scheduled across multiple days and weeks. A common example is scheduling a 40 hour requirement across an entire work week where the field technician is expected to perform more detailed work at the same location each day. 

Dispatchers can schedule multi-day work in between existing bookings, double booking existing schedules, or as a continuous block of time. 

When scheduling multi-day work orders or requirements, dispatchers can choose an allocation method, also referred to as booking method, that dictates how the duration is split up throughout the days and weeks.

Allocation methods



Scenario 1: Schedule a multi-day work order

Scenario 2: Schedule a multi-day requirement

Scenario 3: Schedule a multi-day requirement to multiple resources


## Prerequisites
If the work you wish to schedule spans multiple weeks or has dependencies on previous steps and milestones, you should consider using Dynamics 365 Project Service which has [Gantt chart functionality](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/project-service/schedule-project-work-breakdown-structure). 

> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


## Scenario 1: Schedule a multi-day work order

remaining duration

end: can simply drag and drop too but this creates a continuous booking

## Scenario 2: Schedule a multi-day requirement

requirement
allocation method
requirement details
specify pattern

## Scenario 3: Schedule a multi-day requirement to multiple resources

## Configuration considerations

- full capacity uses calendar
- when scheduling 4 hours each day, they need 4 total hours, not 4 continuous hours
- manual create details when allocation method is none

## Additional Notes
- work order auto creates requirements
- cannot schedule requirement groups for multiple days, menaing you cannot break it up
- travel time?