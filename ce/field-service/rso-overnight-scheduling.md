---
title: Optimize schedules during the night
description: Learn how to use overnight scheduling with the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service.
ms.date: 09/15/2025
ms.subservice: resource-scheduling-optimization
ms.topic: how-to
author: andrewclear-ms
ms.author: anclear
---

# Optimize schedules during the night

Resource Scheduling Optimization is flexible and lets you set it up to run optimizations based on your organization's scheduling needs. Some organizations prefer running the optimization at night, so frontline workers and dispatchers have the latest schedules when they start their day.  

You can set up Resource Scheduling Optimization for overnight scheduling, so it runs each night at a defined time and schedules work orders for the next day. This article explains the key settings to enable overnight scheduling.  

## Configure the optimization scope for overnight scheduling

[Create a new optimization scope](rso-optimization-scope.md) or edit an existing scope.

- Set **Range Reference** to **Job Current Time**.

- Set **Range Offset** to **1 minute**. Because this optimization runs at night, it doesn't affect a technician's ability to respond quickly to schedule changes.

- Set **Range Duration** to **1 day**. This means that jobs are booked within a 24-hour period from when Resource Scheduling Optimization runs.

## Configure the optimization goal for overnight scheduling

[Create a new optimization goal](rso-optimization-goal.md) or edit an existing goal.

- Set **Engine Effort Level** to **Intense** or **Very Intense**. Optimization takes longer to run but returns better results. Overnight scheduling runs during the night when no one is working, so quality is prioritized over speed.

- Add constraints based on your business needs.

## Configure the optimization schedule for overnight scheduling

[Create a new optimization schedule](rso-optimization-schedule.md) or edit an existing schedule.

- Set **Timer** to **1 hour** so the system checks every hour if it should run.

- Set **Timer Mode** to **Fixed**.

- For **Valid From** and **Valid To**, specify the date range when overnight scheduling is valid.

- On the **Filter** tab, define when you want Resource Scheduling Optimization to run:

  - **Filter Time Zone**: Choose your resources' time zone.
  - **Hours**: Set to **12:00 AM** or some time at the night.
  - **Days Of Week**: Choose the days of business operations. For example, Monday - Friday.

Based on the timer, the system checks the filters and starts an optimization request if it finds a matching value. For example, every hour, Resource Scheduling Optimization checks whether the hour of the day is 12:00 AM and the day of the week is Monday through Friday.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
