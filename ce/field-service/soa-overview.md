---
title: Scheduling Operations Agent overview (preview)
description: Learn about the key benefits and functionality of the Scheduling Operations Agent for Dynamics 365 Field Service.
ms.date: 03/28/2025
ms.topic: overview
ms.author: anclear
author: andrewclear-ms
---

# Scheduling Operations Agent overview (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The Scheduling Operations Agent is a new feature of Dynamics 365 Field Service that allows dispatchers to improve the schedule of a single technician quickly and efficiently. Dispatchers often spend considerable time on the schedule board adjusting technician schedules manually throughout their day. They sometimes face the following challenges:

- A technician has one or more same-day cancellations. The dispatcher needs to choose work to fill the open slots&mdash;ideally, according to the promised time, the priority, and with optimized travel time for the technician,  meaning the work is near other bookings.

- A technician is exceeding the planned time for the current booking, which leads to cascading delays for subsequent bookings. The dispatcher needs to adjust all the remaining bookings for the day.

- The work that's assigned is out of date and has bookings that are low in priority. The dispatcher needs to update the technician's schedule to front-load higher-priority work that emerged recently.

- A technician recovered from illness sooner than expected and is available again. The dispatcher wants to quickly fill the technician's schedule with work orders.

The Scheduling Operations Agent uses an optimization algorithm that considers existing bookings and requirements when scheduling work. It's available to licensed Field Service users with a dispatcher role. If your organization needs to optimize multiple schedules in batches or on a recurring basis, we recommend using the [Resource Scheduling Optimization Add-in for Field Service](rso-overview.md) instead.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Regional availability and rollout

The Scheduling Operations Agent is available in the same Azure regions as Dynamics 365 Field Service, except Azure Government and China.

The feature is rolling out gradually across the supported Azure regions. Rollout dates are listed in the release schedule for Universal Resource Scheduling. Learn more in [Universal Resource Scheduling version history](field-service-version-history-resource-scheduling.md).

## Related information

- [Set up the Scheduling Operations Agent (preview)](soa-setup.md)
- [Run the Scheduling Operations Agent (preview)](soa-run.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
