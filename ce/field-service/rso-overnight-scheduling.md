---
title: Optimize schedules during the night
description: Learn how to use overnight scheduling with the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service.
ms.date: 09/25/2026
ms.subservice: resource-scheduling-optimization
ms.topic: how-to
author: andrewclear-ms
ms.author: anclear
---

# Optimize schedules during the night

You can set up Resource Scheduling Optimization to run optimizations based on your organization's scheduling needs. Some organizations prefer to run optimization at night so that frontline workers and dispatchers have the latest schedules when they start their day.

With overnight scheduling, Resource Scheduling Optimization runs each night at a defined time and schedules work orders for the next day. This article explains the key settings to enable overnight scheduling.

## Configure the optimization scope for overnight scheduling

[Create an optimization scope](rso-optimization-scope.md) or edit an existing scope.

- Set **Range Reference** to **Job Current Time**.

- Set **Range Offset** to **1 minute**. Because this optimization runs at night, it doesn't affect a technician's ability to respond quickly to schedule changes.

- Set **Range Duration** to **1 day**. Resource Scheduling Optimization books jobs within the 24-hour period that starts when it runs.

## Configure the optimization goal for overnight scheduling

[Create an optimization goal](rso-optimization-goal.md) or edit an existing goal.

- Set **Engine Effort Level** to **Intense** or **Very Intense**. Optimization takes longer to run but returns better results. Overnight scheduling runs during the night when no one is working, so these settings prioritize quality over speed.

- Add constraints based on your business needs.

## Configure the optimization schedule for overnight scheduling

[Create an optimization schedule](rso-optimization-schedule.md) or edit an existing schedule.

- Set **Timer** to **1 hour** so the system checks every hour whether it should run.

- Set **Timer Mode** to **Fixed**.

- For **Valid From** and **Valid To**, specify the date range when overnight scheduling is valid.

- On the **Filter** tab, define when you want Resource Scheduling Optimization to run:

  - **Filter Time Zone**: Select your resources' time zone.
  - **Hours**: Select **12:00 AM** or another time during the night.
  - **Days Of Week**: Select the days your business operates, for example, Monday through Friday.

Based on the timer, the system checks the filters and starts an optimization request if it finds a matching value. For example, every hour, Resource Scheduling Optimization checks whether the hour of the day is 12:00 AM and the day of the week is Monday through Friday.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
