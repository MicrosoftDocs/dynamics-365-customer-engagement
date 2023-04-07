---
title: Optimization schedules in Resource Scheduling Optimization for Dynamics 365 Field Service
description: Learn about how to use optimization schedules in Resource Scheduling Optimization for Dynamics 365 Field Service
author: FeifeiQiu
ms.author: feiqiu
ms.date: 09/07/2022
ms.topic: article

ms.subservice: resource-scheduling-optimization
---

# Optimization schedules in Resource Scheduling Optimization

After creating a scope and a goal, you can combine and schedule them in an optimization schedule.

You can define when Resource Scheduling Optimization should optimize requirements and bookings for selected resources - for example, at 1:00 AM on weekdays. Creating a schedule also includes creating a scope and a goal.

> [!div class="mx-imgBorder"]
> ![Screenshot showing an optimization schedule.](media/88139c6831f34eb47709a44bc6d3dd6e.png)

Provide a name for the optimization schedule. If a scope and goal haven't been created, you'll need to create them for this schedule.

> [!div class="mx-imgBorder"]
> ![Screenshot showing the schedule name.](media/rso-wa-job.png)

- **Timer**: Defines how often this schedule will run.

- **Timer Mode**: The reference moment when the schedule starts the timer. For example, if a timer is set to 30 minutes, the first run starts 30 minutes from the publish date/time.
  - **Fixed**: Optimization runs after every specified time interval.
  - **After Job Completion**: Optimization run waits for the defined time interval after the last Resource Scheduling Optimization job completes.
- **Valid From** and **Valid To**: The first and last date and time when this schedule is valid.

Filter is used to set various combinations. For example, the schedule will run at 1:00 AM and 7:00 PM every Monday through Friday.

![Screenshot showing the filter.](media/dce427070a0bc406cd407e62319887b3.png)

The Filter section of the schedule is an advanced feature:

- You can filter by month, numerical day, weekday, hour, and minute, and refer to a configured time zone.
- Leaving all filters blank means no filters are applied.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
