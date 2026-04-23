---
title: Work locations for scheduling requirements
description: Learn about on-site, facility, and location-agnostic work locations for scheduling requirements in Dynamics 365 Field Service.
ms.date: 03/30/2026
ms.custom: bap-template
ms.topic: concept-article
author: mkelleher-msft
ms.author: mkelleher
---

# Work locations for scheduling requirements

The **Work Location** field on a requirement tells the scheduling engine where the work happens. This location affects whether the scheduling engine calculates travel time and which resources it shows as available.

## Work location types

| Work location | Who travels | Travel time calculated? | Example |
|---|---|---|---|
| **On-site** | Resource travels to the customer | Yes - from resource location to job location | Technician drives to customer's home for a repair |
| **Facility** | Customer travels to your location | Yes - from customer to facility location | Customer brings device to a repair center |
| **Location Agnostic** | Nobody travels | No | Remote troubleshooting, virtual consultation |

## Work location impact on scheduling

### On-site (default)

The requirement uses the work order's location (latitude/longitude). The schedule assistant calculates travel time from each resource's current or home location to the job site and factors it into availability.

- You must set a start and end location for resources (Resource Address or Organizational Unit Address).
- Resources set to "Location Agnostic" still appear but without travel time estimates.

### Facility

Set the requirement's **Work Location** to **Facility** when customers come to your location. The schedule assistant automatically filters to show only Facility-type resources and calculates travel time from the customer's location to the facility.

Facility scheduling supports several variations:

- **Single facility with capacity** - One facility resource handles multiple concurrent bookings.
- **Multiple facilities** - Individual facility resources under the same organizational unit.
- **Facility pool** - A pool of facilities for deferred allocation.

Learn more in [Schedule a facility](facility-scheduling.md).

### Location agnostic

Set the requirement's **Work Location** to **Location Agnostic** for remote or virtual work. The schedule assistant shows all matching resources regardless of location, and it doesn't calculate travel time.

This setting is useful for:

- Remote support or virtual consultations
- Back-office tasks that don't require physical presence
- Scheduling equipment that doesn't need to be transported

## Set the work location

Set the work location in several places:

- **On the work order** - Flows to the auto-generated requirement.
- **On the requirement** - Set or override directly on the resource requirement record.
- **On the [incident type](configure-incident-types.md)** - Preconfigures the work location for all work orders using that template.

## Next steps

- [Resource types for scheduling](scheduling-resource-types.md)
- [Travel time and distance](schedule-with-travel-time.md)
- [Geocoding for travel time](turn-on-auto-geocoding.md)
- [Schedule a facility](facility-scheduling.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
