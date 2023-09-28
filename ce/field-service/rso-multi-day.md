---
title: Schedule optimization in Resource Scheduling Optimization with Dynamics 365 Field Service
description: Learn about scheduling optimization using Resource Scheduling Optimization with Dynamics 365 Field Service
author: FeifeiQiu
ms.author: feiqiu
ms.date: 06/08/2018
ms.topic: article

ms.subservice: resource-scheduling-optimization
---

# Optimize multi-day service requests (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

A [service requirement can be scheduled across multiple days and weeks](schedule-multi-day-work.md). For example, a 40-hour work order across an entire work week where the same field technician is expected to perform more detailed work at the same location each day.

With the Resource Scheduling Optimization add-in version 3.40.X.Y, you can optimize multi-day service requests to improve scheduling efficiency and accuracy for dispatchers.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Multi-day requirements for a single resource

For multi-day requirements, the booking method set for the requirement informs the add-in which logic to use when scheduling the requirement. The system then uses the duration of the requirement details to optimize the schedule. Resource Scheduling Optimization add-in assigns all bookings of a multi-day requirement to the same resource within the defined optimization range. If no there's no resource available or resources don't have enough capacity to fulfill the multi-day requirement, the system leaves it unscheduled. Scheduling takes break times defined in resource calendar into account and schedules multi-day bookings around break time. The add-in also calculates travel time from/to start/end location just like other onsite bookings.

## Multi-day requirements special cases

Resource Scheduling Optimization add-in can schedule multi-day requirements to different resource if [the defined optimization range](rso-optimization-scope.md) is less than the length of multi-day requirement. E,g: 5-day multi-day requirement, 3-day optimization range, RSO will assign 3-day bookings within optimization range to the same resource, next time RSO runs, may assign the remaining bookings to another resource. To prevent RSO from assigning remaining bookings to different resource, you can lock any of these multi-day bookings to a resource, next time RSO runs and that locked booking still in the optimization range, RSO will assign the remaining bookings to the same resource  

RSO might fulfill part of multiday requirement when optimization ranges less than multiday length. For example: 40-hour multi-day requirement with From date as March 1st and To date as March 5th, while optimization range is March 1st to March 2nd, in this situation, RSO will create bookings for March 1st and 2nd to the same resource, if no resource within these 2 dates can take this work, RSO will leave it unscheduled.  Next time RSO runs for March 2nd and March 3rd, RSO will fulfill the booking for March 3rd. To prevent RSO from partial fulfill multiday requirement, make sure optimization range matches multiday requirement date range.  

RSO will calculate travel time from/to start/end location just like other onsite bookings if it’s onsite multi-day requirement,. Customer can configure travel outside working hours as needed to address the scenario: 8 hr long multi-day booking for 3 days and technician working 8 hrs per day, need to travel at their own expense/outside working hour in order to take multi-day bookings. 