---
title: Booking and requirement status relationship
description: Learn how booking statuses and requirement statuses work together in the scheduling lifecycle in Dynamics 365 Field Service.
ms.date: 03/30/2026
ms.custom: bap-template
ms.topic: concept-article
author: mkelleher-msft
ms.author: mkelleher
---

# Booking and requirement status relationship

When you schedule a requirement to a resource, the system creates a booking. From that point, the booking status and the requirement status work together to track progress through the scheduling lifecycle.

## Scheduling lifecycle

The typical flow from requirement to completed booking:

1. **Requirement created** - Requirement status: Active. No booking exists yet.
1. **Booking created (scheduled)** - Booking status: Scheduled. Requirement status remains Active.
1. **Technician traveling** - Booking status: Traveling.
1. **Work in progress** - Booking status: In Progress.
1. **Work completed** - Booking status: Completed. Requirement status: Completed.

## Booking statuses

Booking statuses track where a booking is in its lifecycle. Field Service provides default statuses that map to parent system statuses:

| Default booking status | Parent Field Service status | Meaning |
|---|---|---|
| Scheduled | Scheduled | Resource is assigned but hasn't started |
| Traveling | Traveling | Resource is on the way to the job site |
| In Progress | In Progress | Resource is actively working |
| On Break | On Break | Resource is on a break during the job |
| Completed | Completed | Work is done |
| Canceled | Canceled | Booking was canceled |

You can create custom booking statuses and map them to these parent statuses. Custom statuses let you track more granular stages (for example, "Waiting for Parts" mapped to In Progress). Learn more in [Booking statuses](set-up-booking-statuses.md).

### Booking status display

- The schedule board shows booking statuses with a configurable **color** for quick visual identification.
- The display shows statuses alphabetically, grouped by parent status.
- Set default statuses for new and canceled bookings through **[Booking Setup Metadata](set-up-booking-statuses.md)**.

## Requirement statuses

Requirement statuses track whether a requirement still needs to be fulfilled:

| Status | Meaning |
|---|---|
| **Active** | The requirement still needs scheduling or the booking is in progress |
| **Completed** | The requirement is fulfilled |
| **Canceled** | The requirement is canceled |

## Connection between statuses

| When this happens... | Booking status | Requirement status |
|---|---|---|
| Requirement is created (no booking yet) | N/A | Active |
| Dispatcher schedules the requirement | Scheduled | Active |
| Technician starts traveling | Traveling | Active |
| Technician starts work | In Progress | Active |
| Technician completes work | Completed | Completed |
| Booking is canceled | Canceled | Reverts to Active (can be rescheduled) |

> [!NOTE]
> A requirement can have multiple bookings (for example, when the same work order is booked to multiple resources). The requirement status stays Active until all related bookings are completed.

## Booking timestamps and journals

Each time a booking status changes, the system can automatically create a **booking timestamp** to record the date, time, and source of the change. When a booking is completed, the system generates **booking journals** that break down the time into categories:

| Journal type | What it records |
|---|---|
| **Travel** | Duration traveling to the job site |
| **Working Hours** | Duration during the resource's work hours |
| **Break** | Duration on break |
| **Overtime** | Duration outside the resource's work hours |
| **Business Closure** | Duration during business closure hours |

Learn more in [Booking timestamps and journals](booking-timestamps.md).

## Next steps

- [Booking statuses](set-up-booking-statuses.md)
- [Booking timestamps and journals](booking-timestamps.md)
- [Work order lifecycle and system statuses](work-order-status-booking-status.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
