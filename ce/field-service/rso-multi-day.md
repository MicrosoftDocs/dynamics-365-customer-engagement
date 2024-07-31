---
title: Optimize multi-day service requests (preview)
description: Learn how the Resource Scheduling Optimization add-in for Dynamics 365 Field Service handles multi-day requirements.
author: AnilMur
ms.author: anilmur
ms.date: 06/11/2024
ms.topic: conceptual
ms.subservice: resource-scheduling-optimization
---

# Optimize multi-day service requests (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

A [service requirement can be manually scheduled across multiple days and weeks](schedule-multi-day-work.md). An example is a 40-hour work order across an entire work week, where the same field technician is expected to perform more detailed work at the same location each day. You can now use Resource Scheduling Optimization to optimize multi-day service requests of this type.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Multi-day requirements for a single resource

For multi-day requirements, the booking method that is set for the requirement determines what logic is used when the requirement is scheduled. The system then uses the duration of the requirement details to optimize the schedule.

Resource Scheduling Optimization assigns all bookings of a multi-day requirement to the same resource within the defined optimization range. If no resource is available, or if available resources don't have enough capacity to fulfill the multi-day requirement, the system leaves the requirement unscheduled.

Scheduling considers break times that are defined in the resource calendar. Multi-day bookings are scheduled around break times.

Resource Scheduling Optimization also calculates travel time from and to the start and end locations, just as it does for other onsite bookings. If you want technicians to travel at their own expense or outside of working hours, you can configure travel outside of working hours as required.

## Special cases for multi-day requirements

### The optimization range is shorter than the multi-day requirement

If [the defined optimization range](rso-optimization-scope.md) is less than the length of a multi-day requirement, Resource Scheduling Optimization can schedule the multi-day requirement to different resources.

For example, there is a five-day requirement for a three-day optimization range. In this case, the system assigns three-day bookings within the optimization range to the same resource. Then, during the next optimization run, it might assign the remaining bookings to a different resource.

To prevent Resource Scheduling Optimization from assigning the remaining bookings to a different resource, you can lock any of the multi-day bookings to a resource. Then, during the next optimization run, the system assigns the remaining bookings to the same resource.

### The optimization range doesn't fully overlap the multi-day requirement

If [the defined optimization range](rso-optimization-scope.md) doesn't fully overlap a multi-day requirement, Resource Scheduling Optimization partially fulfills the multi-day requirement.

For example, there is a 40-hour multi-day requirement between March 1 and March 5, but the optimization range is two days, March 1 through March 2. In this case, the system creates bookings for March 1 and 2 for the same resource. If no resource is available on those two days, the bookings remain unscheduled. For the subsequent optimization run for March 2 and March 3, Resource Scheduling Optimization assigns the booking for March 3.

To prevent the system from partially fulfilling multi-day requirements, ensure that the optimization range matches the date range of the multi-day requirement.

## Known issues

Optimization runs might create an extra booking for multi-day requirements if one existing booking has a status of *Completed*.

If you lock multiple bookings to different resources, optimization runs might delete multi-day bookings instead of optimizing them.

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
