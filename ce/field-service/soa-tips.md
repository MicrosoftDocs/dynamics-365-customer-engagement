---
title: Improve the Scheduling Operations Agent's suggestions (preview)
description: Learn how to troubleshoot and improve suggested results of the Scheduling Operations Agent for Dynamics 365 Field Service.
ms.date: 03/28/2025
ms.topic: how-to
ms.author: anilmur
author: anilmur
---

# Improve the Scheduling Operations Agent's suggestions (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

This article offers tips for improving the Scheduling Operations Agent's suggestions for optimized resource schedules.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Define resource and requirement properties

The agent evaluates properties of resources and requirements when it optimizes a schedule. To get the best results, use the following properties consistently:

- Resource properties:

  - [Work hours and breaks](set-up-bookable-resources.md#add-work-hours)
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
  - [Resource preferences](resource-preferences.md)

## Manage existing bookings

The agent treats existing bookings the same as unfulfilled requirements, which might lead to unexpected results. For example, if a dispatcher asks the agent for a suggested schedule at 10:00 AM, the agent might suggest replacing the 10:20 AM booking with higher-priority work. The following suggestions can help you avoid these issues:

1. Use a custom time range and set it to start an hour or two from the current time.

1. For bookings that you want to persist, apply a booking status that has an optimization method of *Do Not Move*. Learn more in [Select an optimization method for booking statuses](soa-setup.md#select-an-optimization-method-for-booking-statuses).

1. Create a requirement view that contains no requirements and choose that view in the agent settings. The agent suggests a schedule that only optimizes the order of existing bookings. This approach is especially helpful if you simply want to optimize the travel route for the day. However, keep in mind that the agent can still remove bookings that don't match other settings or for which the promised time window has expired.

## Eligible bookings

The agent needs to have eligible bookable resource bookings and unfulfilled resource requirements to suggest a schedule. It also needs requirements with locations that aren't too far apart. For example, it doesn't return results if the resource is based in New York but bookings and requirements are in Miami.

Bookings that have an optimization method of *Do Not Move* and occur outside of working hours or require travel outside of working hours are ineligible to be included in a suggested schedule.

### Bookings with Optimization Method set to Do Not Move

Bookings that have an optimization method of *Do Not Move*&mdash;or that don't have an optimization method set&mdash;can present a challenge for the agent. If an optimization method isn't set for booking statuses, the agent treats the bookings as *Do Not Move* by default. In either case, the agent can't move these bookings, which can lead to the following issues:

- If the schedule includes overlapping bookings, the agent can't suggest a better schedule.

- If one or more bookings overlap the resource's breaks or off-work periods, the agent can't suggest a better schedule. It always tries to accommodate all travel and booking-related work within the resource's working hours. It also tries to allow time for the resource to drive from the location of the last booking of the day back to the resource's [end location](set-up-bookable-resources.md#create-other-bookable-resources).

- If travel starts or the work occurs before the start of the optimization time range, the agent returns an error. It can't suggest a schedule where the travel or work occurs within the specified time range. Similarly, if any part of the travel or work overlaps the end of the optimization time range, the agent fails.

To avoid these issues, select an optimization method for all booking statuses, or make sure that the start and end of the optimization time range occur well before or well after the *Do Not Move* bookings. Learn more in [Select an optimization method for booking statuses](soa-setup.md#select-an-optimization-method-for-booking-statuses) and [Time range](soa-run.md#time-range).

### Set priority values and optimization method

If the agent doesn't pick up requirements or bookings at all, make sure that priorities have a priority value set and booking statuses have an optimization method set. Learn more in [Set priority values](soa-setup.md#set-priority-values) and [Select an optimization method for booking statuses](soa-setup.md#select-an-optimization-method-for-booking-statuses).

## Limitations and known issues

The Scheduling Operations Agent has some limitations:

- It doesn't support resources of type *Account*, *Equipment*, *Pool*, and *Facility*. The agent supports *User*, *Contact*, or *Crew* resources only.

- The resource must not be part of a crew during the entire optimization range.

- The resource can have up to three breaks during their work day or shift. With four or more breaks, the agent returns an error.

- The agent doesn't consider a requirement's fulfillment preferences or partially fulfilled resource requirements.

- The agent needs to run when the resource is available for work. The resource can't be on break, off work, or traveling to or working on a booking.

- The agent works best with Field Service environments that don't have the Resource Scheduling Optimization Add-in for Microsoft Dynamics 365 Field Service installed. If you have the add-in, use [single resource optimization for Resource Scheduling Optimization](rso-single-resource-optimization.md) instead.

## Related information

- [Scheduling Operations Agent FAQ (preview)](faqs-soa.md)
