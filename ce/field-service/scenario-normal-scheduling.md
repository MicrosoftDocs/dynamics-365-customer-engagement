---
title: Schedule a standard work order
description: End-to-end walkthrough of the most common scheduling workflow in Dynamics 365 Field Service - one technician, one work order.
ms.date: 03/30/2026
ms.custom: bap-template
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
---

# Schedule a standard work order

This scenario walks through the most common scheduling workflow - a single technician dispatched to a single work order at a customer location. Use this scenario as a starting point if you're new to scheduling in Field Service.

## Prerequisites

Before you can schedule, make sure you set up the following prerequisites:

- At least one [bookable resource](set-up-bookable-resources.md) with [work hours configured](calendar-resource.md).
- [Geocoding enabled](turn-on-auto-geocoding.md) for travel time calculations.
- A work order with a valid service address (latitude/longitude).

Learn more about what's needed in [The scheduling process](universal-resource-scheduling-for-field-service.md#the-scheduling-process).

## Step 1: Review the requirement

When you create a work order, the system automatically generates a resource requirement. Open the work order and check the related requirement to verify the following details:

- **Duration** - How long the job takes
- **Location** - The customer's address (latitude/longitude)
- **Date range** - The From Date and To Date within which the job can be scheduled
- **Promise window** - If you committed to a specific arrival window for the customer

Learn more in [Requirement types](scheduling-requirement-types.md) and [Time constraints and promise windows](schedule-time-constraints.md).

## Step 2: Find the right resource

You have several options to match the requirement to a resource:

| Method | Best for |
|---|---|---|
| [**Schedule assistant**](schedule-assistant.md) | Most scheduling - matches resources based on availability, skills, and travel time | 
| [**Schedule board drag-drop**](schedule-board-drag-drop.md)  | Quick assignments when you can see the right resource | 
| [**Manual booking**](schedule-board-manual-scheduling.md) | Emergency work or overrides | 
| [**Quick scheduling**](quick-scheduling.md) | Fast booking with minimal interaction | 

If the requirement has constraints, such as [characteristics](set-up-characteristics.md), [territories](set-up-territories.md), or preferred resources, the schedule assistant automatically filters to show only matching resources.

## Step 3: Create the booking

When you select a resource and time slot, the system creates a **Bookable Resource Booking** record that tracks all of the following information:

- Which resource is assigned
- Start and end time
- Travel time estimate
- Booking status (starts as **Scheduled**)

The requirement status stays **Active** until the booking is complete.

Learn more in [Use the schedule board](work-with-schedule-board.md).

## Step 4: Track progress

As the technician works through the job, the booking status flows through its lifecycle:

**Scheduled** → **Traveling** → **In Progress** → **Completed**

Each status change creates a booking timestamp. When the booking is completed, the system generates [booking journals](booking-timestamps.md) for travel, working hours, overtime, and other related activities.

Learn more in [How booking statuses relate to requirement statuses](booking-requirement-status-relationship.md).

## Next steps

Ready for more complex scenarios?

- [Schedule work over multiple days](schedule-multi-day-work.md)
- [Schedule crews](resource-crews.md)
- [Schedule a facility](facility-scheduling.md)
- [Schedule multiple resources with requirement groups](multi-resource-scheduling-requirement-groups.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
