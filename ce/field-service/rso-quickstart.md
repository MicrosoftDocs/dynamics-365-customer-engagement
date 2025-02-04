---
title: Get started with the Resource Scheduling Optimization Add-in
description: Learn how to get up and running quickly with the Resource Scheduling Optimization Add-in for Field Service.
ms.date: 02/04/2025
ms.subservice: resource-scheduling-optimization
ms.topic: how-to
author: AnilMur
ms.author: anilmur
---

# Get started with the Resource Scheduling Optimization Add-in

The Resource Scheduling Optimization Add-in for Dynamics 365 Field Service automatically schedules work orders to the resources that are most available and best qualified. Many field service organizations that perform work orders at their customers' locations benefit from automatic scheduling because it optimizes the routes and travel times of field technicians as they travel from work order to work order.

This article guides you through configuration of Resource Scheduling Optimization to schedule and optimize a group of work orders to a predefined list of resources. You're going to set up a scope, goal, and schedule to assign work orders to resources in a territory to minimize travel time. Choose a few resources and work orders and a short time range for this exercise. This example shows resources and work order for the Washington State service territory.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=759eefa3-85ea-414e-8d2e-ac53e0a438de]

## Prerequisites

- Resource Scheduling Optimization is [deployed to your Field Service environment](rso-deployment.md).

- Resource Scheduling Optimization is [enabled](rso-configuration.md#enable-resource-scheduling-optimization).

- You have **Field Service-Administrator** and **Resource Scheduling Optimization** security roles and the **Field Service-Administrator** and **Resource Scheduling Optimization-Administrator** field security profiles. For more information, go to [Add required security roles](rso-configuration.md#add-required-security-roles-to-users-who-configure-and-run-resource-scheduling-optimization).

- Views are set up that filter the records you want in your [optimization scope](rso-optimization-scope.md).

## Step 1: Set resources and work orders to optimize

Choose the resources and work orders you want to optimize and enable them for optimization. For more information, go to [Prepare resources and work orders for optimizations](rso-configuration.md).  

:::image type="content" source="media/rso-quickstart-resource-field.png" alt-text="Screenshot of five bookable resources with Optimize schedule set to yes.":::

## Step 2: Verify booking statuses

Field Service uses [booking statuses](set-up-booking-statuses.md), and Resource Scheduling Optimization adds the scheduling methods **Ignore**, **Do Not Move**, or **Optimize** and maps them to the booking statuses. Make sure the highlighted booking statuses match your system.

:::image type="content" source="media/rso-quickstart-booking-statuses.png" alt-text="Screenshot of a list of booking statuses mapped to Resource Scheduling Optimization statuses.":::

For this example, if they don't match, go to **Resource Scheduling Optimization** > **Optimization Schedules** > and select **Reset**.

## Step 3: Create an optimization scope

[Create an optimization scope](rso-optimization-scope.md) that defines the resources, requirements, or bookings, and the time range to consider for optimization. Make sure you select the resource and requirement views you identified that filter the records you want. In this example, we have a resource view called **WA - Bookable Resources** and a requirement view called **WA - Work Order Requirements**. Select a booking view such as **Active Bookable Resource Bookings**.

:::image type="content" source="media/rso-quickstart-scope.png" alt-text="Screenshot of an optimization scope.":::

## Step 4: Create a goal

Create an [optimization goal](rso-optimization-goal.md) to define how bookings should be optimized. Use the following values:

- **Engine Effort Level**: Select **Very Light**, which means that the system completes the run quickly in exchange for accuracy.

- **Constraints**: Start with fewer [constraints](rso-optimization-goal.md#understand-constraints) and add more as you successfully run Resource Scheduling Optimization. This makes it easier to troubleshoot if Resource Scheduling Optimization produces unexpected results. For example:

  - **Schedule Within Working Hours** if you have working hours defined.
  - **Meets Required Characteristics** if your requirements and resources both have characteristics.
  - **Matches Territory** if your requirements and resources both belong to the same service territory.

- [Objectives](rso-optimization-goal.md#understand-objectives): Select the following order:

  1. **Maximize Total Working Hours**
  1. **Minimize Total Travel Time**
  1. **Best Matching Skill Level**

## Step 5: Create a schedule

Combine the scope and goal you created into a [schedule](rso-optimization-schedule.md). If you plan to run Resource Scheduling Optimization manually, enter dates in the past.

:::image type="content" source="media/rso-schedule.png" alt-text="Screenshot showing an optimization schedule.":::

## Step 6: Run Resource Scheduling Optimization

After the schedue is published, you can manually run Resource Scheduling Optimization by selecting **Run Now** on the optimization schedule.

Every time Resource Scheduling Optimization runs, successfully or not, an [optimization request record](rso-optimization-schedule.md#review-optimization-requests) is created.

## Step 8: Analyze results

Go to **Optimization Request**. When the status of the request is **Completed**, [go to the schedule board](work-with-schedule-board.md) to see the optimized board.

The system creates a new schedule board tab named after your optimization scope.

A simple example of Resource Scheduling Optimization optimizing travel time is when there's no travel time between two bookings. This means there were two work orders at the same location with the same service account and Resource Scheduling Optimization scheduled them back-to-back.

On the completed scheduling optimization request in the **Bookings** tab, you'll find a list of bookings created or deleted, and a graph of the total travel time and working time of the optimized bookings.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
