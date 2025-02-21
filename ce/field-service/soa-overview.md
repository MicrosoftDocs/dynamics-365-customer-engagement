---
title: Scheduling Operations Agent (preview) overview
description: Learn about the key benefits and functionality of the Scheduling Operations Agent for Dynamics 365 Field Service.
ms.date: 03/03/2025
ms.topic: overview
ms.author: anilmur
author: anilmur
---

# Scheduling Operations Agent (preview) overview

The Scheduling Operations Agent is a new functionality for Dynamics 365 Field Service that allows dispatchers to improve the schedule of a single technician quickly and efficiently. Often, dispatchers spend considerable time on the Schedule Board adjusting technician schedules manually throughout their day. They sometimes face the following situations and challenges:

- A technician has one or more same-day cancellations. Dispatchers need to choose work fill the open slots. Ideally, they choose work according to the promised time, the priority, and with optimized travel time for the technician – meaning work is near the other bookings.
- A technician is exceeding the planned time for the current bookable resource booking, which leads to cascading delays for subsequent bookings. Dispatchers need to adjust all the remaining bookings for the day.
- The work that is currently assigned is out of date and scheduled bookings from a few days ago that are low in priority. Dispatchers want to reorganize the technician’s schedule to front-load higher priority work that emerged recently.
- A technician recovered from illness sooner than expected and is available again. Dispatchers want to quickly fill the technician’s schedule with relevant work orders.

The Scheduling Operations Agent uses an optimization algorithm that considers existing bookings and requirements. It’s available to licensed Field Service users with a dispatcher role  to optimize the schedule for a resource from time to time. If an organization needs to optimize multiple schedules in batches or on a recurring basis, we recommend using the [Resource Scheduling Optimization Add-in for Field Service](rso-overview.md) instead.

## Next steps

1. [Set up the Scheduling Operations Agent (preview)](soa-setup.md)
1. [Run the Scheduling Operations Agent (preview)](soa-run.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]