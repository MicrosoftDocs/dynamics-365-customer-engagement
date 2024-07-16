---
title: Create optimization schedules in Resource Scheduling Optimization
description: Learn about how to use optimization schedules in the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service.
author: AnilMur
ms.author: anilmur
ms.date: 07/16/2024
ms.topic: how-to
ms.subservice: resource-scheduling-optimization
---

# Create optimization schedules in Resource Scheduling Optimization

After creating a scope and a goal, you can combine and schedule them in an optimization schedule. An optimization schedule defines when Resource Scheduling Optimization automatically starts optimizing requirements and bookings. For example, at 1:00 AM on weekdays to have schedules updated when the team starts working and minimize disruption during working hours.

:::image type="content" source="media/optimization-schedule.png" alt-text="Screenshot of an unpublished optimization schedule. ":::

1. Open Resource Scheduling Optimization and go to **Tools** > **Optimization Schedules**.
1. Provide a name for the optimization schedule.
1. Choose an [optimization scope](rso-optimization-scope.md) and an [optimization goal](rso-optimization-goal.md) for the schedule.
1. Set a **Timer** to define how often this schedule runs.
1. Choose a **Timer Mode** as a reference for the timer.

   - **Fixed**: Optimization runs after every specified time interval.
   - **After Job Completion**: Optimization run waits for the defined time interval after the last Resource Scheduling Optimization job completes.

1. Set values for **Valid From** and **Valid To** to defined the time range that this schedule is active.
1. On the **Filter** tab, you can further specify the details for when this schedule should run withing the selected time range. Filters might be helpful if you want to run optimizations only on specific days.
1. Review if all the values are correct and select **Publish** in the command bar to activate the scheudle.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
