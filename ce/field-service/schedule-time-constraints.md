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

This is done by entering date and time values on the Work Order form in the preference section, or similar fields on the requirement form if you're scheduling entities other than work orders.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-time-constraint-work-order-fields.png)

### Schedule between two dates
- Example: 9/10/2019 - 9/15/2019
- Enter **Date window start** and **Date window end**
- Considered by Schedule Assistant and Resource Scheduling Optimization

### Schedule between two times of day
- Example: 9AM - 5PM
- Enter **Time window start** and **Time window end**
- Considered by Resource Scheduling Optimization

### Schedule between two dates and times
- Example: 9/10/2019 9AM - 9/11/2019 5PM
- Enter **Time from promised** and **Time to promised**
- Considered by Schedule Board, Schedule Assistant and Resource Scheduling Optimization


## Instructions 

Let's configure three scenarios to understand how dispatchers can schedule work orders within time constraints. 

**Scenario 1:** An installation work order must be scheduled and is expected to be completed this week.

**Scenario 2:** A diagnosis and repair work order must be scheduled before the end of the day tomorrow.

**Scenario 3:** An inspection work order should be automatically scheduled for completion in the afternoon one of the days within the next two weeks.

## Prerequisites

- Date and time parameters apply to all versions of Field Service

- Understand that Resource Scheduling Optimization considers all date and time parameters but the Schedule Board and Schedule Assistant do not. See above to understand which scheduling methods consider which date and time parameters.


## Scenario 1: date windows

Scenario 1: An installation work order must be scheduled and is expected to be completed this week.

From the work order, enter **Date window start** and **Date window end** fields to represent the week the work order should be scheduled and completed within.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-time-constraint-work-order-date-window.png)

Doing so will automatically populate the **From Date** and **To Date** on the related work order Resource Requirement and vice versa. This is true for the other fields in the Preferences section as well such as Time Promised and TIme Window. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-time-constraint-requirement-start-end.png)

When attempting to schedule this work order via the schedule assistant, from both the Book button on the form or from the Find Availability search on the schedule board, these date values will populate the **Search Start** and **Search End** filters. Resources who are available for the entire duration of the work order within the date range will display as options.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-time-constraint-schedule-assistant-search.png)


> [!Note]
> If the current time (time of scheduling) is later than the Search Start, Search Start will become the current time because you cannot schedule a work order in the past.


## Scenario 2: promised date and time windows

Scenario 2: A diagnosis and repair work order must be scheduled before the end of the day tomorrow.


To schedule based on a date **and** time, simply enter a **Time from promised** and **Time to promised** on the work order.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-time-constraint-work-order-promised.png)

These values will be passed to the related requirement and appear as new filters when the schedule assistant is triggered.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-time-constraint-schedule-assistant-promised.png)

**Time from promised** and **Time to promised** imply that the estimated arrival time of the work order must fall within the time range, but not necessarily completed before the end of **Time to promised**.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-time-constraint-schedule-board-promised.png)

> [!Note]
> it is continuous time range, limited by resources working hours, not the customers hours of operation

- [SLAs](./sla-work-orders.md)

## Scenario 3: automated scheduling with time parameters (RSO)

Scenario 3: An inspection work order should be automatically scheduled in the afternoon within date range.

RSO has more powerful time constraints

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-time-constraint-work-order-rso-window.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-time-constraint-work-order-rso-goal.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-time-constraint-work-order-rso-schedule-board.png)

## Configuration considerations

### Modify calendar
- modify calendar for time zone

### Booking rules

### Booking lock options

### Fulfillment preferences

- [Fulfillment preferences](/set-up-time-groups.md)

### Booking Setup Metadata

- From date and to date on booking setup metadata

## Additional Notes

> [!Note]
> Using Date Window Start and End implies the work order must be completed during the date range based on the total duration of the requirement. As an example, if a work order is expected to take 25 hours, but the date range is 1 day (24 hours) then no resources will return as results because no one can complete the 25 hour work order in 1 day, even if he or she works 24 hours each day as working hours.

- **Current limitation: variable calendars** Out of the box the solution cannot consider variable calendars where certain days and times are restricted or required for scheduling. As an example, imagine a customer who requires on site service would like the work order to be scheduled on Mondays, Wednesdays, or Fridays between 12pm and 5pm each day. This cannot be achieved with the out of the box date and time preference fields or calendar. Possible remedies are to use notes to inform the dispatcher of the customer's time preferences, or to use Booking Rules to create custom logic with JavaScript, however as mentioned earlier Booking Rules only apply to manual scheduling on the Schedule Board.

- Scheduling entities other than work orders? These fields exist on the requirement form too, so you can utilize them when scheduling entities other than work orders such as cases, quotes, and custom entities. 

- could have date window start/end mon-fri and use time windows for 9-5. if not scheduled by end of the week use workflow to make it next week.