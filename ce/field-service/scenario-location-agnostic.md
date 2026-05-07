---
title: Schedule remote or location-agnostic work
description: Learn how to schedule work that doesn't require physical presence in Dynamics 365 Field Service.
ms.date: 03/30/2026
ms.custom: bap-template
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
---

# Schedule remote or location-agnostic work

Not all work requires a technician on-site. Use location-agnostic scheduling for remote troubleshooting or phone-based support, virtual consultations or video appointments, back-office tasks like documentation or review, or scheduling equipment that doesn't need to be transported. Location-agnostic scheduling matches resources based on availability and skills without travel time calculations.

## Prerequisites

- A [bookable resource](set-up-bookable-resources.md) with start and end location set to **Location Agnostic**. This tells the scheduling engine not to calculate travel time for this resource.
- A requirement with **Work Location** set to **Location Agnostic**.

A resource can also have a physical address but still be scheduled for location-agnostic work. The schedule assistant respects the work location on the requirement, not just the resource's location type.

Learn more in [Work locations for scheduling requirements](scheduling-requirement-locations.md).

## Schedule location-agnostic work

Use the [schedule assistant](schedule-assistant.md), [schedule board](work-with-schedule-board.md), or [quick scheduling](quick-scheduling.md) to book the requirement. The scheduling workflow is the same as standard scheduling, just without the travel component. The schedule assistant:

- Shows all matching resources regardless of their physical location.
- Doesn't calculate travel time or distance.
- Matches based on availability, [characteristics](set-up-characteristics.md), [categories](set-up-bookable-resource-categories.md), and [territories](set-up-territories.md) only.

Learn more in [Requirement types for scheduling](scheduling-requirement-types.md).

## Mix location-agnostic and on-site work

A single resource can handle both on-site and remote work. The scheduling engine uses the **requirement's** work location to determine whether to calculate travel time - not the resource's location setting.

This condition means:

- You can book a technician with a Resource Address for a location-agnostic requirement (no travel calculated).
- A location-agnostic resource can still appear for on-site requirements, but without travel time estimates.

## Related scenarios

- [Schedule a standard work order](scenario-normal-scheduling.md)
- [Work locations for scheduling requirements](scheduling-requirement-locations.md)
- [Resource types for scheduling](scheduling-resource-types.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
