---
title: Tips and troubleshooting for the Scheduling Operations Agent (preview)
description: Learn how to troubleshoot and improve suggested results of the Scheduling Operations Agent for Dynamics 365 Field Service.
ms.date: 03/03/2025
ms.topic: how-to
ms.author: anilmur
author: anilmur
---

# Tips and troubleshooting for the Scheduling Operations Agent (preview)

## Define Resource and Requirement properties

The agent evaluates various properties of resources and requirements. Consistent use of these properties improves the suggested schedule.
Relevant properties include:

- Resources:
  - Work hours and break times
  - Start Location and End Location
  - [Territories](set-up-territories.md)
  - Characteristics
- Resource Requirements:
  - From/To Date
  - Duration
  - [Priority](set-priorities.md)
  - Time From/To Promised
  - [Territories](set-up-territories.md)
  - Time Window Start/End
  - [Characteristics](set-up-characteristics.md)
  - Resource Preferences

## Manage existing bookings

The agent treats existing bookings the same as unfulfilled requirements, which might lead to unexpected results. For example, if a dispatcher asks the agent for a suggested schedule at 10:00 am, the agent might suggest replacing the 10:20 am booking with higher priority work. You can avoid such cases:

1. Use a custom time range and set it to start an hour or two from the current time.
1. Set bookings that you want to persist to a booking status with an **Optimization Method** of *Do Not Move*.
1. Create a requirement view that contains no requirements and choose that view in the agent settings. That way, the agent suggests a schedule that only optimizes the order of existing bookings. It’s especially helpful if you simply want to optimize the travel route for the day. However, keep in mind that the agent can still remove bookings that don’t match other selected settings or where the promised time window expired.

## Limitation and known issues

We're aware of the following limitations:

- Resource of type *Account*, *Equipment*, *Pool*, and *Facility* aren't supported. The agent currently supports *User*, *Contact*, or *Crew*.
- The resource must not be part of a crew during the entire optimization range.
- The agent doesn't consider fulfillment preferences of a requirement.
- The agent doesn't consider partially fulfilled resource requirements
- The agent needs to run when the resource is available for work. They can’t be on break, off work, traveling to or working on an existing booking.
- The agent works best with Field Service environments that don’t have the Resource Scheduling Optimization add-on installed. Customers with this add-on should use the [single resource optimization for the Resource Scheduling Optimization add-in](rso-single-resource-optimization.md) instead.

## Troubleshooting FAQ

### Eligible bookings

The agent needs to have eligible bookable resource bookings and unfulfilled resource requirements to suggest a schedule. It also needs requirements with locations that aren't too far apart. For example, it doesn't return results if the resource is based in New York but bookings and requirements are in Miami.

Existing bookings which have an **Optimization Method** of *Do Not Move* are ineligible to be included in a valid suggested schedule if one or more such bookings occur outside of working hours or require travel outside of working hours.

### Set priority values and optimization method

If the agent doesn't pick up requirements or bookings at all, make sure your [priorities have a numeric priority value](soa-setup.md#create-or-update-priority-values) set and that you defined the [optimization method for the booking statuses](soa-setup.md#create-or-update-optimization-method-for-booking-status).