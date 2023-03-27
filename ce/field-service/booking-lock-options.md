---
title: Understand the booking lock option in Resource Scheduling Optimization
description: Learn about the booking lock options in Resource Scheduling Optimization for Dynamics 365 Field Service.
ms.date: 11/02/2022
ms.topic: article
ms.author: chenryan
author: ryanchen8
search.app: 
  - D365CE
  - D365FS
--- 

# Understand the booking lock option in Resource Scheduling Optimization

Once a booking is created, a lock can be set on the **Scheduling Lock Options** field in the **Resource Scheduling Optimization** tab of the *Bookable Resource Booking* record. Resource Scheduling Optimization will always include locked bookings as part of the optimized schedule.

:::image type="content" source="media/scheduling-lock-options.png" alt-text="Screenshot of the Scheduling Lock Options on a Bookable Resource Booking record.":::

## Booking lock options

There are four options:

- **Time Range**: Resource Scheduling Optimization can move bookings within certain time ranges to ensure the *Estimated Arrival Time* falls into this time range but not the booking end time. Resource Scheduling Optimization can assign bookings to other resources by respecting the time range and the following time-related fields.

  - **Date Window Start** and **Date Window End** are set to the same day: Resource Scheduling Optimization schedules the booking on that day but the time of day doesn't matter.
  - **Time Window Start** and **Time Window End** define a time frame: Resource Scheduling Optimization schedules the booking in that time frame but the date doesn't matter.
  - **Time From Promised** and **Time To Promised** are set to a date and a time frame: Resource Scheduling Optimization schedules a booking on the selected date in the selected time range.
  - **Date Window Start/End** and **Time Window Start/End** are set to a time frame on the same day: Resource Scheduling Optimization schedules a booking on the selected date in the selected time range.

  > [!NOTE]
  > If time and date fields contain conflicting information, Resource Scheduling Optimization uses **Time From/To Promised** first.

- **Resource**: Resource Scheduling Optimization can move bookings to other time frames, but has to keep the same resource.

- **Time**: Resource Scheduling Optimization can move bookings to other resources but has to keep the estimated arrival time.

- **Resource and Time**: Resource Scheduling Optimization can’t move bookings to any other resource or any other time frame. The booking’s start time and estimated travel duration may be changed if Resource Scheduling Optimization schedules a booking in a new location before the booking becomes a locked booking.

## Example

The resource Bernadette has a booking that starts at 9:15 AM. This booking is locked to time. When Resource Scheduling Optimization runs, the system detects a 15-minute idle time for Bernadette in the morning. No other requirement duration fits into that slot with the locked booking next to it.

:::image type="content" source="media/scheduling-lock-options-sample-timeline.png" alt-text="Screenshot of a locked booking in a schedule board.":::

To respect the defined lock option, Resource Scheduling Optimization keeps the locked booking in the schedule. However, as part of the schedule optimization, the booking gets assigned to Ashley. This change frees up time for Bernadette to complete other jobs.

:::image type="content" source="media/scheduling-lock-options-sample-timeline-optimized.png" alt-text="Screenshot of a locked booking in an optimized schedule board.":::

## Excessive use of lock constraints

Excessive use of lock constraints may result in poor optimization of the final schedule. Booking lock options should be used wisely to maximize Resource Scheduling Optimization results and minimize interference with other Resource Scheduling Optimization objectives.

For example, there are two requirements, A (one hour) and B (eight hours). We have one resource (Jeff) that works eight hours per day. When Resource Scheduling Optimization is run with the objective to maximize total working hours, requirement B (8 hours) should be assigned to the resource Jeff.

If you book requirement A (1 hour) to the resource Jeff and lock that booking to the resource, Resource Scheduling Optimization makes sure that requirement A remains on the schedule. On the other hand, it won't schedule the requirement B (eight hours) on the same day and leaves Jeff with only one hour of scheduled work.

## Error handling and troubleshooting

Excessive use of lock constraints may result in poor optimization of the final schedule. Booking lock options should be used wisely to maximize Resource Scheduling Optimization results.

If a locked booking can't respect all defined constraints, the optimization request will continue, skipping over the identified resources that have violations. The following error message will be generated to assist with troubleshooting.

**System failed to optimize some records. Inner error(s): Locked booking is infeasible, reason: `Violation`. Tracing data points: `RequirementId`, `RequirementName`, `BookingId`, `BookingName`, `ScheduledTimeWindow`, `FullTimeWindow`, `ArrivalTime`, `Lock Type`**

The tracing data points help you identify what went wrong. Try updating the booking settings to address the violation reason before running Resource Scheduling Optimization again.

### Violation types

- The locked booking cannot fulfill the time window filter.

  - **LockBookingTimeWindowFilter**. Potential scenarios:
    - Locked booking is outside of resource working hours
    - Invalid promised time window
    - Invalid travel time

  - **ResourceBreakTimeWindowFilter**. A locked booking conflicts with a [scheduled break time](set-work-hours-resource.md).

- The eligibility check failed with constraint.

  - **MeetsRequiredSkills**. A locked booking has an invalid match of the [resource skill characteristics](set-up-characteristics.md).

  - **MeetsRequiredRoles**. A locked booking has an invalid [resource role match](/training/modules/configure-bookable-resources-urs-dynamics-field-service/).

  - **MeetsResourcePreferences**. A locked booking has an invalid [“must choose from” or “restricted” resource](resource-preferences.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
