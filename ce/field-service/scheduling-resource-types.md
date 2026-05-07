---
title: Resource types for scheduling
description: Learn about the different resource types available for scheduling in Dynamics 365 Field Service and when to use each one.
ms.date: 03/30/2026
ms.custom: bap-template
ms.topic: concept-article
author: mkelleher-msft
ms.author: mkelleher
---

# Resource types for scheduling

When you [set up resources](set-up-bookable-resources.md) for scheduling, assign each resource a resource type. The type determines how the resource is scheduled and how it interacts with the schedule board and schedule assistant.

## Available resource types

| Type | What it represents | Example |
|---|---|---|
| **User** | A person in your organization with system access | Technician, dispatcher |
| **Account / Contact** | An external person or vendor without system access | Subcontractor, partner technician |
| **Equipment** | A physical asset that you can schedule | Truck, crane, diagnostic tool |
| **Facility** | A physical space where work happens | Repair bay, conference room, clinic |
| **Crew** | A group of resources scheduled together as one unit | Two-person installation team |
| **Pool** | A group of interchangeable resources for deferred allocation | Pool of 10 general technicians |

For detailed setup steps, see [Create bookable resources](set-up-bookable-resources.md).

## Resource location types

Each resource has a start and end location that determines how the system calculates travel time when scheduling.

| Location type | Travel time calculated? | Use when |
|---|---|---|
| **Resource Address** | Yes - from the resource's latitude and longitude | Resource starts from a unique home or office location |
| **Organizational Unit Address** | Yes - from the organizational unit's address | Resource starts from a company branch or depot |
| **Location Agnostic** | No | Resource works remotely or location doesn't matter |

## Resource type impact on scheduling

- **Schedule assistant** filters results by resource type. When you search for a [facility requirement](facility-scheduling.md), only Facility-type resources appear.
- **Crews** are scheduled as a single unit - booking the crew books all its members. Learn more in [Crews](resource-crews.md).
- **Pools** support deferred allocation - you book the pool first, then assign a specific member later. Learn more in [Pools](resource-pools.md).
- **Equipment** resources don't have user accounts and can't access the mobile app. Dispatchers manage these resources on the schedule board.

## Key properties that affect scheduling

Beyond resource type and location, these properties shape how a resource is matched to requirements:

- **Work hours** - When the resource is available. Learn more in [Apply a calendar to a bookable resource](calendar-resource.md).
- **Characteristics** - Skills and certifications the resource has. Learn more in [Characteristics](set-up-characteristics.md).
- **Categories** - Role or job title classification. Learn more in [Bookable resource categories](set-up-bookable-resource-categories.md).
- **Territories** - Geographic regions the resource serves. Learn more in [Territories](set-up-territories.md).

## Next steps

- [Create bookable resources](set-up-bookable-resources.md)
- [Requirement types for scheduling](scheduling-requirement-types.md)
- [Constraints for scheduling](set-up-characteristics.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
