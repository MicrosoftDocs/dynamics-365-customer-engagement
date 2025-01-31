---
title: Get started with the Resource Scheduling Optimization Add-in
description: Learn how to get up and running quickly with the Resource Scheduling Optimization Add-in for Field Service.
ms.date: 01/29/2025
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

- Resource Scheduling Optimization is already [configured](rso-configuration.md).

- You need **Field Service-Administrator** and **Resource Scheduling Optimization** security roles and the **Field Service-Administrator** and **Resource Scheduling Optimization-Administrator** field security profiles. For more information, see [Resource Scheduling Optimization configuration](./rso-configuration.md#add-required-security-roles-to-users-who-configure-and-run-resource-scheduling-optimization).

- Views are set up that filter the records you want in your scope for optimization.

## Step 1: Set resources as eligible for optimization

Choose which resources are eligible for optimization.

1. Go to **Resource Scheduling Optimization** > **Resources**.

1. Choose the resources that you want to optimize and select **Edit**.

1. In the Resource Scheduling Optimization tab, set **Optimize Schedule** to **Yes** and **Save**.

:::image type="content" source="media/rso-quickstart-resource-field.png" alt-text="Screenshot of a bookable resource entity with Optimize schedule set to yes.":::

## Step 2: Set work orders to optimize

Choose which work orders to optimize.

1. Go to **Resource Scheduling Optimization** and select **Resource Requirements**.

1. Select the work orders that you want to optimize and select **Edit**.

   :::image type="content" source="media/rso-quickstart-requirement-view-bulk-edit.png" alt-text="Screenshot of a list of work order requirements.":::

1. Set the **Optimize Schedule** to **Yes** and **Save**.

> [!TIP]
> - The system can [automatically set work order requirements to be optimized](rso-configuration.md) when you create a work order in the **Booking Setup Metadata** settings.

## Step 3: Verify booking statuses

Field Service uses [booking statuses](set-up-booking-statuses.md), and Resource Scheduling Optimization adds the scheduling methods **Ignore**, **Do Not Move**, or **Optimize** and maps them to the booking statuses. Make sure the highlighted booking statuses match your system.  

:::image type="content" source="media/rso-quickstart-booking-statuses.png" alt-text="Screenshot of a list of booking statuses mapped to Resource Scheduling Optimization statuses.":::

For this example, if they don't match, go to **Resource Scheduling Optimization** > **Optimization Schedules** > and select **Reset**.

## Step 4: Create an optimization scope

Set up a Resource Scheduling Optimization run and start with an [optimization scope](rso-optimization-scope.md).

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

## Step 5: Create a goal

Create an [optimization goal](rso-optimization-goal.md) for the Resource Scheduling Optimization run.

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

## Step 6: Create a schedule

Combine your scope and goal into a schedule.

1. Go to **Optimization Schedules** and select **New**.

1. Choose the **Scope** and **Goal** you created.

1. Set **Timer** for how often Resource Scheduling Optimization checks if it should run based on the time filter setting.

1. Enter **Valid From** and **Valid To** dates. If you plan to run Resource Scheduling Optimization manually, enter dates in the past.

1. On the **Filter** section, enter the time it should run.

1. Select **Save** and then **Publish** the schedule.

## Step 7: Run Resource Scheduling Optimization

After the schedue is published, you can manually run Resource Scheduling Optimization by selecting **Run Now** on the optimization schedule.

Every time Resource Scheduling Optimization runs, successfully or not, an optimization request record is created.

## Step 8: Analyze results

Go to **Optimization Request**. When the status of the request is **Completed**, [go to the schedule board](work-with-schedule-board.md) to see the optimized board.

The system creates a new schedule board tab named after your optimization scope.

A simple example of Resource Scheduling Optimization optimizing travel time is when there's no travel time between two bookings. This means there were two work orders at the same location with the same service account and Resource Scheduling Optimization scheduled them back-to-back.

On the completed scheduling optimization request in the **Bookings** tab, you'll find a list of bookings created or deleted, and a graph of the total travel time and working time of the optimized bookings.

Congratulations! You have successfully run Resource Scheduling Optimization.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
