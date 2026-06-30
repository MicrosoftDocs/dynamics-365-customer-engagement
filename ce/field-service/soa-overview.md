---
title: Scheduling Operations Agent overview (preview)
description: Discover how the Scheduling Operations Agent optimizes one or more technicians' schedules with interactive or batch runs in Dynamics 365 Field Service.
ms.date: 06/25/2026
ms.topic: overview
ms.collection: bap-ai-copilot
ms.author: anclear
author: andrewclear-ms
ai-usage: ai-assisted
---

# Scheduling Operations Agent overview (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The Scheduling Operations Agent in Dynamics 365 Field Service optimizes the schedules of one or more technicians at the same time. Dispatchers spend much of their day on the schedule board adjusting technician schedules manually, and these adjustments get harder to make as the number of technicians grows. Dispatchers often face the following challenges:

- A technician has one or more same-day cancellations. The dispatcher needs to choose work to fill the open slots - ideally, according to the promised time, the priority, and with optimized travel time for the technician, meaning the work is near other bookings.

- A technician is exceeding the planned time for the current booking, which leads to cascading delays for subsequent bookings. The dispatcher needs to adjust all the remaining bookings for the day.

- The work that's assigned is out of date and has bookings that are low in priority. The dispatcher needs to update the technician's schedule to front-load higher-priority work that emerged recently.

- A technician recovered from illness sooner than expected and is available again. The dispatcher wants to quickly fill the technician's schedule with work orders.

- A team of technicians has an uneven workload. The dispatcher needs to balance the bookings across several technicians at once while minimizing travel time.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Ways to optimize schedules

The Scheduling Operations Agent supports two ways to optimize schedules:

- **Interactive optimizations** let a dispatcher select one or more resources from the schedule board, a resource list, or Copilot, and then review a suggested schedule before applying it. Use interactive optimizations for in-the-moment adjustments to one or more technicians' schedules. Learn more in [Run interactive optimizations (preview)](soa-interactive-optimizations.md).

- **Batch optimizations** run larger, asynchronous optimizations across a defined set of resources, requirements, and bookings. You configure the work to optimize by using a [scope](soa-scopes.md), a [goal](soa-goals.md), and a [plan](soa-plans.md). You can review results before you apply them or apply them automatically. Learn more in [Run batch optimizations (preview)](soa-batch-optimizations.md).

## How the agent works

Whichever way you run an optimization, the agent works from the same building blocks:

- A [goal](soa-goals.md) tells the agent what to optimize for. It combines *objectives*, which describe the trade-offs the agent makes, such as completing more high-priority work or reducing travel time, with *constraints*, which determine whether a resource is eligible for a requirement, such as required characteristics or territories.

- The agent evaluates the resources you choose, the unfulfilled requirements that match your criteria, and the existing bookings that it's allowed to change.

- The agent generates a suggested schedule that you review and apply, so a person is always in control of the changes. The agent never moves bookings that are marked **Do Not Move**, and it respects each technician's working hours and breaks.

## Regional availability and rollout

The Scheduling Operations Agent is available in the same Azure regions as Dynamics 365 Field Service, except Azure Government and China.

The feature is rolling out gradually across the supported Azure regions. Rollout dates are listed in the release schedule for Universal Resource Scheduling. Learn more in [Universal Resource Scheduling version history](field-service-version-history-resource-scheduling.md).

## Next steps

- [Set up the Scheduling Operations Agent (preview)](soa-setup.md)
- [Run interactive optimizations (preview)](soa-interactive-optimizations.md)
- [Run batch optimizations (preview)](soa-batch-optimizations.md)
- [Goals and objectives (preview)](soa-goals.md)
- [Scheduling Operations Agent FAQ (preview)](faqs-soa.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
