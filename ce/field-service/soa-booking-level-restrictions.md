---
title: Booking-level restrictions in the Scheduling Operations Agent (preview)
description: Set per-booking optimization behavior and restrictions in Dynamics 365 Field Service to control how the Scheduling Operations Agent treats individual bookings.
ms.date: 09/03/2026
ms.topic: concept-article
ms.collection: bap-ai-copilot
ms.author: anclear
author: andrewclear-ms
ms.custom:
 - ai-gen-docs-bap
 - ai-seo-date: 09/03/2026
ai-usage: ai-assisted
---

# Booking-level restrictions in the Scheduling Operations Agent (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Booking-level settings let a dispatcher override how the Scheduling Operations Agent treats a single booking. They provide fine-grained control in addition to the goal, scope, and optimization method that apply to a booking's status. Two settings work together: **Optimization behavior** controls how the agent handles the existing booking, and **Restrict to** adds constraints that keep parts of the booking in place. Use them when one booking needs to behave differently from the rest of an optimization run.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## How booking-level settings relate to booking status

Each booking status has an optimization method that the agent applies globally to every booking in that status. Learn more about status-level optimization methods in [Select an optimization method for booking statuses](soa-setup.md#select-an-optimization-method-for-booking-statuses).

Booking-level settings override that behavior for a specific booking. When you set **Optimization behavior** on an individual booking, the agent uses that setting for the booking instead of the behavior that the booking's status optimization method implies. Everything else in the run still follows the goal, the scope, and the status-level methods.

These settings apply to both [interactive optimizations](soa-interactive-optimizations.md) and [batch optimizations](soa-batch-optimizations.md).

## Optimization behavior

**Optimization behavior** controls how the agent handles the existing booking.

| Option | Description |
| --- | --- |
| **Ignore** | The agent doesn't include the booking in the optimization. It can schedule other work over the booking, but it never deletes or changes the booking. |
| **Optimize** | The default. The agent can optimize the booking freely, within its constraints. |
| **Schedule if feasible** | The agent guarantees that the booking stays on the schedule if it can generate a feasible solution that includes it, within the booking's constraints. |
| **Do not move** | The agent doesn't remove or reassign the booking or change its arrival time, even if the booking's placement violates constraints. |

When you set **Optimization behavior** to **Do not move**, the restriction is effectively **Resource + Arrival time**.

## Restrict to settings

The **Restrict to** setting adds extra constraints to an individual booking. These constraints override constraints defined elsewhere, such as on the requirement. For example, if a requirement has a **Must choose from** constraint for resource A, but you manually assign a booking for that requirement to resource B and set its **Restrict to** value to **Resource**, the agent keeps the booking on resource B.

| Option | Description |
| --- | --- |
| **None** | The default. No extra restriction. |
| **Arrival time** | The agent doesn't change the booking's arrival time. |
| **Shift** | The agent doesn't move the booking outside the currently assigned resource's shift. The booking must already sit completely within a shift for this restriction to apply. |
| **Resource** | The agent doesn't change the assigned resource. |
| **Resource + Arrival time** | The agent changes neither the assigned resource nor the arrival time. |

## Use booking-level settings

You can use **Optimization behavior** and **Restrict to** only when the Scheduling Operations Agent is enabled. Set them from two places:

- From the bookable resource booking form, open the booking, go to the scheduling area of the form, set the **Optimization behavior** or **Restrict to** value, and save the booking.
- From the schedule board, right-click the booking, select **Optimization behavior** or **Restrict to**, and choose a value.

## Next steps

- [Set up the Scheduling Operations Agent (preview)](soa-setup.md)
- [Run interactive optimizations (preview)](soa-interactive-optimizations.md)
- [Run batch optimizations (preview)](soa-batch-optimizations.md)
- [Goals and objectives (preview)](soa-goals.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
