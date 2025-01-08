---
title: Get started with the Resource Scheduling Optimization Add-in
description: Learn how to get up and running quickly with the Resource Scheduling Optimization Add-in for Field Service.
ms.date: 06/04/2024
ms.subservice: resource-scheduling-optimization
ms.topic: how-to
author: AnilMur
ms.author: anilmur
---

# Get started with the Resource Scheduling Optimization Add-in

The Resource Scheduling Optimization Add-in for Dynamics 365 Field Service automatically schedules work orders to the resources that are most available and best qualified. Many field service organizations that perform work orders at their customers' locations benefit from automatic scheduling because it optimizes the routes and travel times of field technicians as they travel from work order to work order.

This article guides you through configuration of Resource Scheduling Optimization to schedule and optimize a group of work orders to a predefined list of resources. You're going to set up a scope, goal, and schedule to assign work orders to resources in a territory to minimize travel time.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=759eefa3-85ea-414e-8d2e-ac53e0a438de]

For more Field Service videos, see [this full playlist](https://aka.ms/fs-videos).

## Prerequisites

- Resource Scheduling Optimization is already [deployed to your Field Service environment](rso-deployment.md).

- You need **Field Service-Administrator** and **Resource Scheduling Optimization** security roles and the **Field Service-Administrator** and **Resource Scheduling Optimization-Administrator** field security profiles. For more information, see [Resource Scheduling Optimization configuration](./rso-configuration.md).

- Resource Scheduling Optimization uses [Universal Resource Scheduling](universal-resource-scheduling-for-field-service.md) to schedule field service work orders.

## Glossary

You'll need to know the following key terms:

- **Jobs**: Work that needs to be completed like work orders, cases, or projects.
- **Resources**: Anyone or anything that needs to be scheduled to a job including people, equipment, and facilities.
- **Schedules, bookings**: Schedules and bookings are used interchangeably and refer to the appointment time slot when a resource is assigned to a job.
- **Requirements**: The entity related to a job that defines what type of resource is needed to complete the work and gets scheduled.
- **Run**: The process when Resource Scheduling Optimization performs its scheduling and optimization functions.
- **Optimize**: Attempt to find the best schedules to reduce travel time and maximize usage.
- **Scope**: The jobs and resources that Resource Scheduling Optimization considers for optimization.
- **Goal**: Defines the ideal outcome of a run. For example, minimize travel time, maximize usage, handle high-priority jobs, or schedule jobs as soon as possible. Multiple goals are ranked because sometimes there are trade-offs.

## Step 1: Enable Resource Scheduling Optimization

After deploying Resource Scheduling Optimization into your environment, enable the add-in.

1. Open **Resource Scheduling** and change to the **Settings** area.
1. Go to **Administration** > **Scheduling Parameters** > **Resource Scheduling Optimization**.
1. Set **Enable Resource Scheduling Optimization** to **Yes**.
1. Select a **Default Goal**.

   Among other uses, a default goal tells Resource Scheduling Optimization what to prioritize by default and it's relevant for [single resource optimization](rso-single-resource-optimization.md). If no default goal exists, [create an optimization goal](rso-optimization-goal.md).

## Step 2: Verify booking statuses

Field Service uses [booking statuses](set-up-booking-statuses.md), and Resource Scheduling Optimization adds the scheduling methods **Ignore**, **Do Not Move**, or **Optimize** and maps them to the booking statuses. Make sure the highlighted booking statuses match your system.  

:::image type="content" source="media/rso-quickstart-booking-statuses.png" alt-text="Screenshot of a list of booking statuses mapped to Resource Scheduling Optimization statuses.":::

If they don't match, go to **Resource Scheduling Optimization** > **Optimization Schedules** > and select **Reset**.

## Step 3: Set work orders to optimize

In this step, you choose which work orders to optimize.

1. Go to **Resource Scheduling** > **Resource Requirements** and select the records to optimize. Select **Edit** to change them in bulk.

   :::image type="content" source="media/rso-quickstart-requirement-view-bulk-edit.png" alt-text="Screenshot of a list of work order requirements.":::

1. Set the **Scheduling Method** to **Optimize**.

> [!TIP]
> - The system can [automatically set work order requirements to be optimized](rso-configuration.md) when you create a work order in the **Booking Setup Metadata** settings.
> - You also can change the optimization method individually for a resource requirement record on the **Resource Scheduling Optimization** tab.

## Step 4: Set resources as eligible for optimization

Let's define the resources that are eligible for optimization.

1. In the **Resources** list, choose the resources that you want to enable and select **Edit**.

1. Set the **Optimize Schedule** field to **Yes**.

Similar to requirements, this can be done individually or with a bulk edit.

:::image type="content" source="media/rso-quickstart-resource-field.png" alt-text="Screenshot of a bookable resource entity with Optimize schedule set to yes.":::

## Step 5: Create an optimization scope

In the following steps, we set up a Resource Scheduling Optimization run and start with an [optimization scope](rso-optimization-scope.md).

1. In the list of apps, select **Resource Scheduling Optimization**.

1. Go to **Optimization Scopes** and select **New**.

1. Enter a **Name** and choose a **Resource View** and a **Requirement View** for the optimization scope.

1. In the **Bookings for the Optimization** section, select the **Active Bookable Resource Bookings** view or a similar view for bookings.

    > [!NOTE]
    > By entering a view for unscheduled requirements *and* bookings, we are configuring Resource Scheduling Optimization to optimize both unscheduled and scheduled jobs. If you only select a booking view, then Resource Scheduling Optimization will only optimize existing bookings and you must schedule the unscheduled jobs manually or with the schedule assistant. By only selecting an unscheduled requirement view, Resource Scheduling Optimization will not move existing bookings and simply attempt to schedule the unscheduled jobs to available time slots.

1. For **Optimization Range Settings**, enter the following values:

   - **Range Reference**: Job Current Time

   - **Range Offset**: This value defines when the first booking after running the optimization can start. Some organizations prefer to schedule jobs starting tomorrow, in which case you'd set it to one day.

   - **Range Duration**: This value defines how far into the future the add-in schedules requirements.

:::image type="content" source="media/rso-quickstart-scope.png" alt-text="Screenshot of an optimization scope.":::

## Step 6: Create a goal

Now we need to create an [optimization goal](rso-optimization-goal.md) for the Resource Scheduling Optimization run.

1. Go to **Optimization Goals** and select **New**.

1. Set the **Engine Effort Level** for this proof of concept to **Very Light**, which means that the system completes the run quickly in exchange for accuracy.

1. Select constraints, for example:

    - **Schedule Within Working Hours** if you have working hours defined.
    - **Meets Required Characteristics** if your requirements and resources both have characteristics.
    - **Matches Territory** if your requirements and resources both belong to the same service territory.

   Start with fewer constraints and add more as you successfully run Resource Scheduling Optimization. This makes it easier to troubleshoot if Resource Scheduling Optimization produces unexpected results.

1. For objectives, select the following order:

    1. **Maximize Total Working Hours**
    2. **Minimize Total Travel Time**
    3. **Best Matching Skill Level**

## Step 7: Create a schedule

The last configuration step is to combine your scope and goal into a schedule.

1. Go to **Optimization Schedules** and select **New**.

1. Choose the **Scope** and **Goal** you created.

1. Set **Timer** for how often Resource Scheduling Optimization checks if it should run based on the time filter setting.

1. Enter **Valid From** and **Valid To** dates. If you plan to run Resource Scheduling Optimization manually, enter dates in the past.

1. On the **Filter** section, enter the time it should run.

1. **Save and Publish** the schedule.

## Step 8: Run Resource Scheduling Optimization

You can manually run Resource Scheduling Optimization by selecting **Run Now** on the optimization schedule.

Every time Resource Scheduling Optimization runs, successfully or not, an optimization request record is created.

## Step 9: Analyze results

Once the **Optimization Request** status is **Completed**, [go to the schedule board](work-with-schedule-board.md) to see the optimized board.

The system creates a new schedule board tab named after your optimization scope.

A simple example of Resource Scheduling Optimization optimizing travel time is when there's no travel time between two bookings. This means there were two work orders at the same location with the same service account and Resource Scheduling Optimization scheduled them back-to-back.

On the completed scheduling optimization request in the **Bookings** tab, you'll find a list of bookings created or deleted, and a graph of the total travel time and working time of the optimized bookings.

Congratulations! You have successfully run Resource Scheduling Optimization.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
