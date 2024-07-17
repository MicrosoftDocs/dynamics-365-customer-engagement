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

## Create an optimization schedule

1. In Resource Scheduling Optimization, go to **Tools** > **Optimization Schedules**.
1. Provide a name for the optimization schedule.
1. Choose an [optimization scope](rso-optimization-scope.md) and an [optimization goal](rso-optimization-goal.md) for the schedule.
1. Set a **Timer** to define how often this schedule runs.
1. Choose a **Timer Mode** as a reference for the timer.

   - **Fixed**: Optimization runs after every specified time interval.
   - **After Job Completion**: Optimization run waits for the defined time interval after the last Resource Scheduling Optimization job completes.

1. Set values for **Valid From** and **Valid To** to define the time range that this schedule is active.
1. On the **Filter** tab, you can further specify the details for when this schedule should run withing the selected time range. Filters might be helpful if you want to run optimizations only on specific days.
1. Review if all the values are correct and select **Publish** in the command bar to activate the schedule.

### Optimization schedule statuses

- **Unpublished**: Default status when a schedule is created or after a reset.
- **Publishing**: The system is trying to publish schedules.
- **Published**: The system published a schedule and it's good to run.
- **Out of Sync**: Changes made against the schedule require it to be published again.
- **Under Maintenance**: Indicates someone is upgrading the Resource Scheduling Optimization to a newer version.
- **Failed**: System failed to publish schedules. You find error details on schedule form. If you see the error `A SASKey has not been configured for ServiceEndpoint RSO Data Sync`, Resource Scheduling Optimization Azure resources aren't set up correctly.

## Reset an optimization schedule

To unpublish a schedule and cancel all pending jobs related to that schedule, you can reset the schedule.

1. In Resource Scheduling Optimization, go to **Tools** > **Optimization Schedules**.
1. Open a published schedule.
1. Select **Reset Resource Scheduling Optimization** in the command bar.

## Review optimization requests

Every time a schedule triggers an optimization job, it creates a *scheduling optimization request* record. You can open these records to review details about the associated resources and bookings.

You can see which resources are being optimized, and which aren't along with the reason.
You can view booking details and charts that compare travel time to the scheduled work hours for this run.

> [!TIP]
> If your schedule has been running for a long time and seems stuck, [reset it](#reset-an-optimization-schedule). When resetting a single optimization schedule doesn't work or gets blocked either, reset all schedules and republish them.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
