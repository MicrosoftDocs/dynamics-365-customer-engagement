---
title: Requirement types for scheduling
description: Learn about the different types of resource requirements in Dynamics 365 Field Service and how they drive scheduling.
ms.date: 03/30/2026
ms.custom: bap-template
ms.topic: concept-article
author: mkelleher-msft
ms.author: mkelleher
---

# Requirement types for scheduling

Requirements define what needs to be done and what kind of resource can do the work. The scheduling engine uses requirements to match resources to jobs. Understanding how requirements are created and what shapes them helps you get better scheduling results.

## Requirement creation

| Method | When it happens | Details |
|---|---|---|
| **Auto-generated from a work order** | When a work order is created | The system creates one requirement per work order by default. The requirement inherits attributes like name, location, duration, and characteristics from the work order. |
| **From an incident type** | When a work order uses an incident type with multiple requirements | Incident types can generate multiple requirements or a requirement group. Learn more in [Create incident types](configure-incident-types.md). |
| **Manually created** | When you need a requirement not tied to a work order | Create a resource requirement record directly. Useful for non-work-order scheduling scenarios. |
| **From agreements** | When an agreement generates recurring work orders | Each generated work order creates its own requirement. Learn more in [Agreements overview](agreements-overview.md). |

> [!CAUTION]
> Manually created requirements for a work order don't synchronize automatically with the work order. Changes to the work order don't update the manual requirement.

## Single requirements verses requirement groups

| | Single requirement | Requirement group |
|---|---|---|
| **Resources needed** | One | Multiple (for example, two technicians + equipment) |
| **Scheduling** | Book one resource to one time slot | All resources booked to the same time slot |
| **How to create** | Default for each work order | Configure via incident types or create manually |
| **Schedule assistant** | Standard resource search | Shows combinations of resources that can fulfill all requirements together |

Learn more about requirement groups in [Multi-resource scheduling](multi-resource-scheduling-requirement-groups.md).

## Key fields on a requirement

These fields on the resource requirement record determine how the scheduling engine finds matching resources:

| Field | What it controls |
|---|---|
| **Duration** | How long the job takes |
| **From Date / To Date** | Date range in which the job can be scheduled |
| **Time From Promised / Time To Promised** | Time window when the resource must arrive |
| **Work Location** | [On-site, Facility, or Location Agnostic](scheduling-requirement-locations.md) |
| **Latitude / Longitude** | Job location for travel time calculations |
| **Territory** | Geographic constraint for resource matching |
| **Characteristics** | [Required skills or certifications](set-up-characteristics.md) |
| **Resource Type** | What kind of resource is needed (User, Equipment, Facility, etc.) |
| **Priority** | Relative priority for scheduling decisions |

## Work order changes and requirements

When you update a work order, the system automatically updates the related requirement's attributes - including name, location, duration, and more. This synchronization ensures the requirement always reflects the latest work order details.

However, if you manually edit a requirement field, that field stops syncing from the work order. Manual edits take precedence.

## Next steps

- [Work locations for scheduling requirements](scheduling-requirement-locations.md)
- [Time constraints and promise windows](schedule-time-constraints.md)
- [Fulfillment preferences](set-up-time-groups.md)
- [Resource types for scheduling](scheduling-resource-types.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
