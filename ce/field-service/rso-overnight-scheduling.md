---
title: Optimize schedules during the night
description: Learn how to use overnight scheduling with the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service.
ms.date: 07/17/2024
ms.subservice: resource-scheduling-optimization
ms.topic: how-to
author: AnilMur
ms.author: anilmur
---

# Optimize schedules during the night

Resource Scheduling Optimization is flexible and can be configured to run optimizations based on your organization's scheduling needs. Some organizations prefer running the optimization during the night to provide frontline workers and dispatchers with the latest schedules when they start their days.

Yon can configure Resource Scheduling Optimization for overnight scheduling so it runs each night at a defined time and schedules work orders for the following day. This article discusses key settings to enable overnight scheduling.

## Configure the optimization scope for overnight scheduling

[Create a new optimization scope](rso-optimization-scope.md) or edit an existing scope.

- Set **Range Reference** to **Job Current Time**.

- Set **Range Offset** to **1 minute**. Because this optimization runs at night, it doesn't affect a technician's ability to respond quickly to schedule changes.

- Set **Range Duration** to **1 day**. This means that jobs are booked within a 24-hour period from when Resource Scheduling Optimization runs.

## Configure the optimization goal for overnight scheduling

[Create a new optimization goal](rso-optimization-goal.md) or edit an existing goal.

- Set **Engine Effort Level** to **Intense** or **Very Intense**. The optimization takes longer to run but returns better optimizations. Because overnight scheduling is intended to run during the night when no one is working, we prioritize quality over speed.

- Add constraints based on your business needs.

## Configure the optimization schedule for overnight scheduling

[Create a new optimization schedule](rso-optimization-schedule.md) or edit an existing schedule.

- Set **Timer** to **1 hour** so the system checks every hour if it should run.

- Set **Timer Mode** to **Fixed**.

- For **Valid From** and **Valid To**, enter the date range for which overnight scheduling is valid.

- On the **Filter** tab, define when you want Resource Scheduling Optimization to run:

  - **Filter Time Zone**: Choose your resources' time zone.
  - **Hours**: Set to **12:00 AM** or some time at the night.
  - **Days Of Week**: Choose the days of business operations. For example, Monday - Friday.

Based on the timer, the system checks the filters and stars an optimization request if there's a matching value. In our example, every hour, Resource Scheduling Optimization checks if the hour of the day is 12:00 AM and the day of the week is Monday through Friday.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
