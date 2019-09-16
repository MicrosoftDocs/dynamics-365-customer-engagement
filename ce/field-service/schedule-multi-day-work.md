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

Dispatchers can schedule multi-day work in between existing bookings, by double booking existing schedules, or as a continuous block of time. 

When scheduling multi-day work orders or requirements, dispatchers can choose an allocation method that dictates how the duration is split up throughout the days and weeks.

### Allocation methods 
- Full capacity
- Percentage capacity
- Distribute evenly
- Front load

Let's explore multi-day scheduling and allocation methods by configuring three scenarios:

**Scenario 1:** Schedule a 30-hour installation work order manually from the schedule board.

**Scenario 2:** Schedule a 30 hour requirement with the schedule assistant.

**Scenario 3:** Schedule and divide a 30 hour requirement among two resources with the schedule assistant.


## Prerequisites
If the work you wish to schedule spans multiple weeks or has dependencies on previous steps and milestones, you should consider using Dynamics 365 Project Service which has [Gantt chart functionality](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/project-service/schedule-project-work-breakdown-structure). 


## Scenario 1: Schedule a multi-day work order


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-work-order-30.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-requirement-30.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-work-order-30-schedule-board.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-work-order-30-schedule-board-booked.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-work-order-30-schedule-board-booked-wrapped.png)

remaining duration

end: can simply drag and drop too but this creates a continuous booking

can drag onto days/weeks view


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-drag-schedule-board.png)

## Scenario 2: Schedule a multi-day requirement


> [!Note]
> need to set an allocation method before saving

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-requirement-allocation-method.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-requirement-30-no-work-order.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-requirement-30-requirement-details.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-requirement-30-modify-calendar.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-requirement-30-schedule-assistant.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-requirement-30-schedule-assistant-booked.png)


> [!Note]
> to create a multiday work order, create a new requirement related to the work order


## Scenario 3: Schedule a multi-day requirement to multiple resources


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-2-person-requirement.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-requirement-2-resource-specify-pattern2.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-2-person-requirement-book-1.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-2-person-requirement-book-2.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-2-person-requirement-book-final.png)

## Configuration considerations

- full capacity uses calendar
- when scheduling 4 hours each day, they need 4 total hours, not 4 continuous hours
- manual create details when allocation method is none
- cannot schedule greater than calendar

## Additional Notes
- work order auto creates requirements
- cannot schedule requirement groups for multiple days, meaning you cannot break it up
- travel time? does not include travel time, books as location agnostic