---
title: "Single resource optimization for Resource Scheduling Optimization | MicrosoftDocs"
description: Learn about single resource optimization for Resource Scheduling Optimization in Dynamics 365 Field Service
ms.date: 09/30/2023

ms.topic: article 
author: anilmur
ms.author: anilmur
--- 

# Single resource optimization for Resource Scheduling Optimization


Resource scheduling optimization is flexible and can be configured to run optimizations based on your entire organization's scheduling needs. Sometimes you might need to optimize only a single resource's schedule, rather than a set of available resources.

Single resource optimization provides a quick way to optimize a resource's schedule and travel route, after taking into consideration the existing bookings on the resource's schedule as well as additional requirements as discussed below.

This is helpful after schedule changes have occurred during the day, when a resource:

- Has a gap in the schedule due to a cancellation.
- Is double-booked because an emergency work order was assigned.
- Has a schedule that was put together manually and needs a travel route with minimal travel.

If an individual resource's schedule needs to be reoptimized, a dispatcher can manually run single resource optimization. It can also be triggered by a workflow. 

> [!Note]
> * If using Dynamics 365 Field Service version 8.8.99.10 or newer along with Resource scheduling optimization version 3.40.0.500 or newer, single optimization runs will take into account existing bookings as well as additional requirements. As a consequence, existing bookings can be deleted in order to produce a schedule that better matches the optimization goal. If using older versions of these products, then single optimization runs will only consider existing bookings on the resource's schedule. The rest of this document assumes that the newer versions have been installed.
> * Unlike other Resource Scheduling Optimization scenarios, single resource optimization runs can't be scheduled.

## Prerequisites

- Dynamics 365 Field Service version 8.8.99.10 or newer.
- Resource scheduling optimization version 3.40.0.500 or newer.
- **Optimize Schedules** is set to **Yes** for the bookable resource you need to individually optimize.

## Step 1: Set up a goal

> [!Note]
> Single resource optimization is the only Resource Scheduling Optimization scenario that doesn't require you to first set up an optimization scope. This is because the scope is automatically defined as *bookings for the resource in the defined date range*.
 
[Goals](./rso-optimization-goal.md) define what metrics Resource Scheduling Optimization should consider and prioritize.

Go to **Resource Scheduling Optimization** > **Optimization Goals** > **+New**.

When creating a goal for single resource optimization, keep in mind that single resource optimization is typically used to clean up a schedule that was altered throughout the day. Consider the following recommendations:

1. Set **Engine Effort Level** to **Very Light**. Quicker the single resource optimization completes, the quicker dispatchers can react to scheduling needs.

1. Remove the **Schedule Within Working Hours** constraint to allow more bookings to fit in the resource's schedule. This can be helpful if a resource needs to pick up additional emergency work order(s). When this constraint is removed, the end time of a booking can spill over into non-working hours. When this constraint is added, Resource Scheduling Optimization ensures there is time, after the last booking completes, for the resource to travel back to the resource's ending location - which can lead to fewer bookings.

1. Remove constraints related to matching territory, roles, and characteristics because the scenario assumes the *dispatcher knows best*. If such constraints are enabled, it could lead to a situation where the dispatcher assigns a work order to a resource overriding the constraints (eg. an emergency), runs single resource optimization which then deletes the booking because it does not match the resource's attributes. 

1. Add **Scheduling Lock Options** and **Scheduling Windows** constraints so single resource optimization upholds time promises or SLAs with the customer.

Select **Save**.

Next, add your single resource optimization goal as the default goal.

Go to **Resource Scheduling** > **Settings** > **Administration** > **Scheduling Parameter** > **Resource Scheduling Optimization** and enter your newly created default goal. 

> [!Note]
> A default goal is created automatically when Resource Scheduling Optimization is deployed, which has different settings than the ones recommended above.

## Step 2: Run and view results

> [!Note]
> Most Resource Scheduling Optimization scenarios require that you also set up a schedule, but this isn't necessary for single resource optimizations. This is because the single resource optimization is manually run from the schedule board or through a workflow.

There are three ways to run single resource optimization:

- One click with defaults.
- Run after making changes to defaults.
- Run as simulation after making changes to defaults.

### One click with defaults

In Field Service version 8.0+, you can right-click a resource (except a [crew](./resource-crews.md), [pools](./resource-pools.md) or [facilities](./facility-scheduling.md)) from any schedule board view and select **Optimize Schedule**. This invokes single optimization with the default optimization goal configured above. 

You will now see:

1. A gray mask behind the resource on the schedule board that indicates default optimization range, from now to the end of today (12:00 AM).
1. A **Schedule Assistant** panel on the right showing the resource's name, and optimization request status. 

When the optimization completes, you will see the new set of bookings on the schedule board, and in the right panel, details about bookings that were updated, deleted, or created.

> There may be a delay before the schedule board get refreshed with the new bookings.
   
### Run after making changes to defaults

You can also change the default goal and time range before running the optimization. For instance, extending the time range to a second day means that single resource optimization might take jobs from the next day and fit them in the first day if the resource has availability. 

Select a resource's name and then go to the **Optimizations** panel.

> [!Note]
> This capability is **only** available from the schedule board view associated with the optimization scope.

> [!div class="mx-imgBorder"]
> ![Screenshot of single resource optimization pane with options.](media/rso-single-resource-4.png)


Set the optimization range to the date and time.

Select the optimization goal.

Select **Run Now** to run the optimization and schedule bookings.

  
### Run as simulation 

By running single resource optimization as a simulation, you can see the resulting optimization before committing to it. Proposed bookings appear on the schedule board in white, as seen in the following screenshot.

> [!div class="mx-imgBorder"]
> ![Screenshot of running single resource optimization with simulation mode.](media/rso-single-resource-5.png)

To run a simulation, right-click a resource and select **Optimize Schedule**. 

This time, instead of selecting **Run**, select **Run as simulation**.

Finally, go to the **Optimization Request** to **Apply** or **Discard** simulation results.

> [!Note]
> Simulated bookings don't show on maps with routes.

## Additional notes

- A default goal is required for single resource optimization to work. A default goal is automatically created when deploying the optimization.
- Single resource optimization only reoptimizes current bookings and does not create new bookings.
- Single resource optimization can reoptimize bookings that were booked manually, through resource availability search, or based on location agnostic requirements.
- This capability appears on the schedule board for all resources as long as optimization is deployed in the environment. However, single resource optimization only works if **Optimize Schedules** is set to **Yes** for the bookable resource. The single resource optimization capability can't be disabled or hidden.




[!INCLUDE[footer-include](../includes/footer-banner.md)]
