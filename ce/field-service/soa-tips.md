---
title: Tips and troubleshooting for the Scheduling Operations Agent (preview)
description: Learn how to troubleshoot and improve suggested results of the Scheduling Operations Agent for Dynamics 365 Field Service.
ms.date: 03/28/2025
ms.topic: how-to
ms.author: anilmur
author: anilmur
---

# Tips and troubleshooting for the Scheduling Operations Agent (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Define Resource and Requirement properties

The agent evaluates various properties of resources and requirements. Consistent use of these properties improves the suggested schedule.
Relevant properties include:

- Resources:
  - [Work hours and break times](set-up-bookable-resources.md#add-work-hours)
  - [Start Location and End Location](set-up-bookable-resources.md#create-other-bookable-resources)
  - [Territories](set-up-territories.md)
  - [Characteristics](set-up-characteristics.md)
- Resource Requirements:
  - [From/To Date](schedule-time-constraints.md)
  - Duration
  - [Priority](set-priorities.md)
  - [Time From/To Promised](schedule-time-constraints.md)
  - [Territories](set-up-territories.md)
  - [Time Window Start/End](schedule-time-constraints.md)
  - [Characteristics](set-up-characteristics.md)
  - [Resource Preferences](resource-preferences.md)

## Manage existing bookings

The agent treats existing bookings the same as unfulfilled requirements, which might lead to unexpected results. For example, if a dispatcher asks the agent for a suggested schedule at 10:00 am, the agent might suggest replacing the 10:20 am booking with higher priority work. In order to avoid such issues:

1. Use a custom time range and set it to start an hour or two from the current time.
1. Set bookings that you want to persist to a [booking status with an **Optimization Method** of *Do Not Move*](soa-setup.md#create-or-update-optimization-method-for-booking-status).
1. Create a requirement view that contains no requirements and choose that view in the agent settings. That way, the agent suggests a schedule that only optimizes the order of existing bookings. It’s especially helpful if you simply want to optimize the travel route for the day. However, keep in mind that the agent can still remove bookings that don’t match other selected settings or where the promised time window expired.

## Limitation and known issues

We're aware of the following limitations:

- Resource of type *Account*, *Equipment*, *Pool*, and *Facility* aren't supported. The agent currently supports *User*, *Contact*, or *Crew*.
- The resource must not be part of a crew during the entire optimization range.
- The resource can have up to three breaks during their work day/shift. With four or more breaks, the agent returns an error.
- The agent doesn't consider fulfillment preferences of a requirement.
- The agent doesn't consider partially fulfilled resource requirements
- The agent needs to run when the resource is available for work. They can’t be on break, off work, traveling to or working on an existing booking.
- The agent works best with Field Service environments that don’t have the Resource Scheduling Optimization add-on installed. Customers with the add-on should use the [single resource optimization for the Resource Scheduling Optimization add-in](rso-single-resource-optimization.md) instead.

## Troubleshooting FAQ

### Eligible bookings

The agent needs to have eligible bookable resource bookings and unfulfilled resource requirements to suggest a schedule. It also needs requirements with locations that aren't too far apart. For example, it doesn't return results if the resource is based in New York but bookings and requirements are in Miami.

Existing bookings which have an **Optimization Method** of *Do Not Move* are ineligible to be included in a valid suggested schedule if one or more such bookings occur outside of working hours or require travel outside of working hours.

### Resource availability

When launching the agent, especially via the Copilot sidecar, the time range and time zone setting might not match or overlap with the work hours of the resource. The agent returns an error message if that is the case.

### Bookings with Optimization Method set to Do Not Move

If the agent is invoked in an environment without first adjusting the [**Optimization Method** mapping](soa-setup.md#create-or-update-optimization-method-for-booking-status) for booking statuses, then by default, it treats existing bookings as *Do Not Move*, which can lead to errors:

- If there are overlapping bookings in the schedule, the agent can't create a feasible suggested schedule without overlaps if it cannot move such bookings.
- If one or more bookings overlap with the break time or off-work periods, the agent can't create a feasible schedule without moving such bookings. It always strives to accommodate all travel and booking-related work within the work hours of the resource. In addition, there should be sufficient time for the resource to drive from the location of the last booking of the day back to the [end location](set-up-bookable-resources.md#create-other-bookable-resources) of that resource.
- If the start of the travel, or the work itself, for a *Do Not Move* booking occurs before the start of the time range of the optimization request, the agent also returns an error because it tries to suggest a schedule where the travel occurs within the specified time range. Similarly, if any part of the travel or the work for a *Do Not Move* booking overlaps with the end of the time range of the optimization request, the agent fails.

To fix the above issues, either adjust the **Optimization Method** mappings, or, make sure that the start time and end time of the optimization request occur well before or well after the *Do Not Move* bookings.

### Set priority values and optimization method

If the agent doesn't pick up requirements or bookings at all, make sure your [priorities have a numeric priority value](soa-setup.md#create-or-update-priority-values) set and that you defined the [optimization method for the booking statuses](soa-setup.md#create-or-update-optimization-method-for-booking-status).
