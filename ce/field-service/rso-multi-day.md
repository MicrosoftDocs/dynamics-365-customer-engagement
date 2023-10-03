---
title: Optimize multi-day service requests (preview)
description: Understand how the Resource Scheduling Optimization add-in for Dynamics 365 Field Service handles multi-day requirements.
author: FeifeiQiu
ms.author: feiqiu
ms.date: 09/28/2023
ms.topic: conceptual
ms.subservice: resource-scheduling-optimization
---

# Optimize multi-day service requests (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

A [service requirement can be scheduled across multiple days and weeks](schedule-multi-day-work.md). For example, a 40-hour work order across an entire work week where the same field technician is expected to perform more detailed work at the same location each day.

With the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service version 3.40.X.Y, you can optimize multi-day service requests to improve scheduling efficiency and accuracy for dispatchers.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Multi-day requirements for a single resource

For multi-day requirements, the booking method set for the requirement determines which logic to use when scheduling the requirement. The system then uses the duration of the requirement details to optimize the schedule. Resource Scheduling Optimization assigns all bookings of a multi-day requirement to the same resource within the defined optimization range. If no there's no resource available or resources don't have enough capacity to fulfill the multi-day requirement, the system leaves it unscheduled. Scheduling takes break times defined in resource calendar into account and schedules multi-day bookings around break time.

Resource Scheduling Optimization also calculates travel time from/to start/end location just like other onsite bookings. You can configure travel outside working hours as needed to have technicians travel at their own expense or outside of working hours.

## Special cases for multi-day requirements

Resource Scheduling Optimization can schedule multi-day requirements to different resources if [the defined optimization range](rso-optimization-scope.md) is less than the length of multi-day requirement. For example, a five-day requirement for a three-day optimization range. The system assigns three-day bookings within the optimization range to the same resource. During the next optimization run, it may assign the remaining bookings to another resource. To prevent Resource Scheduling Optimization from assigning remaining bookings to a different resource, you can lock any of these multi-day bookings to a resource. With the next optimization run, the system assigns the remaining bookings to the same resource.

Resource Scheduling Optimization fulfills multi-day requirements partially when the defined optimization range doesn't fully overlap with the multi-day requirement. For example a 40-hour multi-day requirement between March 1 and March 5 while the optimization range is two days, March 1 to March 2. In this situation, the system creates bookings for March 1 and 2 for the same resource. If no resource is available on these two days, the bookings remain unscheduled. For the subsequent optimization run for March 2 and March 3, Resource Scheduling Optimization assigns the booking for March 3. To prevent the system from partial fulfilling multi-day requirements, make sure the optimization range matches the multi-day requirement date range.  
