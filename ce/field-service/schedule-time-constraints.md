---
title: "Schedule with time constraints | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 08/29/2019
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

# Schedule within time constraints

When scheduling a work order, case, quote, or any entity enabled for scheduling, you can set date and time parameters to control when the requirement is booked.

This includes scheduling the requirement:
- between two defined dates. Example: between 9/10/2019 and 9/15/2019

On the Work Order form you can add date and time values in the preference section:

**Time from promised** and **Time to promised** -

**Date window start** and **Date window end** - 

**Time window start** and **Time window end** 

These fields are passed along to the related resource requirement 

Let's configure three scenarios to understand how dispatchers can schedule work orders within time constraints. 

Scenario 1: An installation work order must be scheduled and is expected to be completed this week.

Scenario 2: A diagnosis and repair work order must be scheduled before the end of the day tomorrow.

Scenario 3: An inspection work order should be automatically scheduled for completion in the afternoon one of the days within the next two weeks.

## Prerequisites
> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Scenario 1: Date windows

Scenario 1: An installation work order must be scheduled and is expected to be completed this week.

scheduling-time-constraint-work-order-date-window

scheduling-time-constraint-requirement-start-end

scheduling-time-constraint-schedule-assistant-search

must be completed during time range
if current time is later than start time, start time will become current time. because you cant schedule in the past via schedule assistant

updating values on work order will update requirement and vice versa

## Scenario 2: Promised date and time windows

Scenario 2: A diagnosis and repair work order must be scheduled before the end of the day tomorrow.

scheduling-time-constraint-work-order-promised

scheduling-time-constraint-schedule-assistant-promised

scheduling-time-constraint-schedule-board-promised

it is continuous time range, limited by resources working hours, not the customers hours of operation

- [SLAs](./sla-work-orders.md)
- 

## Scenario 3: Automated scheduling with time parameters (RSO)

Scenario 3: An inspection work order should be automatically scheduled in the afternoon within date range.

scheduling-time-constraint-work-order-rso-window

scheduling-time-constraint-work-order-rso-goal

scheduling-time-constraint-work-order-rso-schedule-board

- RSO has more powerful time constraints


## Configuration considerations
- Booking rules
- modify calendar for time zone
- booking lock options
- [Fulfillment preferences](/set-up-time-groups.md)
- From date and to date on booking setup metadata

## Additional Notes
- cannot handle scenario where customer is only available mon, wed, fri 9-12pm. can add this as a note or use a booking rule, but this only applies to Schedule board
- could have date window start/end mon-fri and use time windows for 9-5. if not scheduled by end of the week use workflow to make it next week.