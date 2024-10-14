---
title: Single resource optimization for Resource Scheduling Optimization
description: Learn about single resource optimization for Resource Scheduling Optimization in Dynamics 365 Field Service
ms.date: 07/16/2024
ms.topic: how-to
author: anilmur
ms.author: anilmur
ms.custom: bap-template
ms.subservice: resource-scheduling-optimization
--- 

# Single resource optimization for Resource Scheduling Optimization

You can configure the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service to [run optimizations based on your entire organization's scheduling needs](rso-overview.md). Sometimes you might need to optimize only a single resource's schedule, rather than for a set of available resources. Single resource optimization provides a quick way to optimize a resource's schedule and travel route. It considers the existing bookings on the resource's schedule and more requirements.

It helps accommodate schedule changes that occurred during the day, when a resource:

- Has a gap in the schedule due to a cancellation.
- Is double-booked because emergency work order was assigned.
- Has a schedule that was put together manually and needs a route with minimal travel.

To optimize an individual resource's schedule, a dispatcher can manually run single resource optimization. Workflows can also trigger single resource optimization. Unlike other Resource Scheduling Optimization scenarios, you can't schedule single resource optimization runs.

> [!NOTE]
> Starting with Field Service version 8.8.99.10 and Resource Scheduling Optimization version 3.4.0.623, single resource optimization runs take requirements and existing bookings into account. As a consequence, the system can delete existing bookings to create a schedule that better matches the optimization goal. In earlier versions, single optimization runs only considered existing bookings.

## Prerequisites

- Dynamics 365 Field Service version 8.8.99.10 or newer.
- Resource scheduling optimization version 3.4.0.623 or newer.
- **Optimize Schedules** is set to **Yes** for the bookable resource you want to run single resource optimization for.

## Step 1: Set up a goal

Single resource optimization is the only Resource Scheduling Optimization scenario that doesn't require an optimization scope. The scope is automatically defined as *bookings for the resource in the defined date range*. [Optimization goals](rso-optimization-goal.md) define what metrics Resource Scheduling Optimization should consider and prioritize.

First, [create a new optimization goal](rso-optimization-goal.md#create-a-scheduling-optimization-goal).

Single resource optimization typically cleans up a schedule that changed throughout the day. Consider the following recommendations:

- Set **Engine Effort Level** to **Very Light**. The faster single resource optimization completes, the better dispatchers can react to scheduling needs.

- Remove the **Schedule Within Working Hours** constraint to allow more bookings to fit in the resource's schedule. This setting can be helpful if a resource needs to pick up urgent work. Removing this constraint allows the end time of a booking to spill over into nonworking hours. Using the constraint, the system ensures there's time after completing the last booking  to travel back to the resource's end location.

- Remove the travel time calculation option for historical traffic if it's enabled on the optimization goal.

- Remove constraints related to matching territory, roles, and characteristics because the scenario assumes the *dispatcher knows best*. Keeping constraints enabled could lead to a situation where the dispatcher assigns a work order to a resource overriding the constraints, then runs single resource optimization, which deletes the booking because it doesn't match the resource's attributes.

- Add **Scheduling Lock Options** and **Scheduling Windows** constraints so single resource optimization upholds time promises or SLAs with the customer.

> [!TIP]
> A location agnostic resource can only have bookings for which the *Resource Requirement* is also set to location agnostic. Resource Scheduling Optimization treats that resource like a remote worker who only gets scheduled for work that doesn't involve travel. Alternatively, you can [Enable a resource for scheduling outside of working hours](rso-travel-outside-working-hours.md#enable-a-resource-for-scheduling-outside-of-working-hours) to work around this constraint.

Next, [add your single resource optimization goal as the default goal](rso-optimization-goal.md#default-optimization-goal).

## Step 2: Run and view results

There are three ways to run single resource optimization:

- [Run with defaults](#run-with-defaults)
- [Run after making changes to defaults](#run-after-making-changes-to-defaults)
- [Run as simulation after making changes to defaults](#run-as-simulation-after-making-changes-to-defaults)

### Run with defaults

On the schedule board, right-click a resource (except a [crew](./resource-crews.md), [pools](./resource-pools.md) or [facilities](./facility-scheduling.md)) and select **Optimize Schedule** to optimize with:

- The default optimization goal
- The default optimization range, which is from now to the end of today (12:00 AM)
- The existing bookings on the resource's schedule in that optimization range
- Requirements from the active view of requirements at the bottom of the schedule board, ordered according to any sorting or filtering that have been applied to that view

When the optimization completes, you see the new set of bookings on the schedule board. In the right pane, you find details about bookings that were updated, deleted, or created.

### Run after making changes to defaults

You can change the default goal and time range before running the optimization. For example, if you extend the time range to the next day, the system considers all existing bookings and requirements between now and the end of the next day to create a schedule.

1. Select a resource's name and open the **Optimizations** pane.

    > [!NOTE]
    > This capability is only available from the schedule board view associated with the optimization scope.

1. Select **Single resource**.
1. Set the optimization range to the desired values.
1. For **Requirements**, choose the view from which to consider requirements for optimization. Filters and sorting settings of the selected view determine the order of requirements. Select **None** to optimize only the existing bookings.
1. Select the desired optimization goal.
1. Select **Run** > **Run now** to start a single resource optimization request.

You can see the request status in the **Optimization requests history** section on the **Optimizations** pane. When completed, the schedule board updates with the optimized set of bookings. Double-click the optimization request to view the details about which bookings were deleted, updated, or created.

### Run as simulation after making changes to defaults

By running single resource optimization as a simulation, you can see the resulting optimization before committing to it. To run a simulation, follow the steps in [Run after making changes to defaults](#run-after-making-changes-to-defaults). This time, instead of selecting **Run now** in the drop-down, select **Run as simulation**. After the optimization request completes, bring up the details to **Apply** or **Discard** the results.

> [!NOTE]
> Simulated bookings don't show on maps with routes.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
