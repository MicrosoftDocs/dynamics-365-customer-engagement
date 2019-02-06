---
title: "Single resource optimization for Resource Scheduling Optimization | MicrosoftDocs"
ms.custom: dyn365-fieldservice
ms.date: 10/19/2018
ms.reviewer: 
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
author: krbjoran
ms.author: FieldServiceDave
ms.manager: shellyhaverkamp
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
--- 

# Single resource optimization

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

The single resource optimization capability provides a quick way to re-optimize a resource's schedule and travel route after schedule changes and cancellations have occurred during the day. For example, re-optimizing a resource's schedule corrects overlapping bookings when the resource is assigned an emergency work order, or arrives at a customer location late due to traffic.

There are two ways to use the schedule board to optimize the schedule for a single resource:

- **One click with defaults**: From any schedule board view, optimize the schedule with one click by setting a time range to the end of the current day for the default goal. Optimizing with one click requires Field Service application version 8.0 or higher.

- **Advanced with edits**: Optimize the schedule for a single resource by editing the goal and time range, running the optimization as a simulation, and then applying or discarding the results. This capability is only available from the schedule board view associated with the optimization scope.

  > [!div class="mx-imgBorder"]
  > ![Screenshot of triggering single resource optimization from schedule board](media/rso-single-resource-1.png)

## Prerequisites

- Resource scheduling optimization version 2.8 or higher.

- **Optimize Schedules** is set to **Yes** for the bookable resources.

- Default goal in **Resource Scheduling Optimization** > **Optimization Goals**. A default goal is created automatically when optimization runs.

## Optimize with one click

1. From the schedule board, right-click the resource's name, and then select **Optimize Schedule**. 

   > [!div class="mx-imgBorder"]
   > ![Screenshot of triggering single resource optimization from schedule board](media/rso-single-resource-2.png)

2. Yellow line indicates default optimization range, from now to the end of today (12 AM).
3. Gray mask indicates default optimization range, from now to the end of today (12 AM).
4. Optimization panel showing resource name, default range, default goal, and optimization request status.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of single resource optimization with range and goal](media/rso-single-resource-3.png)

## Perform advanced optimization with edits

1. Set the optimization range to the date and time.

2. Select the optimization goal.

3. Select **Run Now** to run the optimization and schedule bookings.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of single resource optimization pane with options](media/rso-single-resource-4.png)


<!--from editor: Are these two bullets supposed to be numbers 4 and 5 (to go with the image)?-->


- **Run Simulation** runs the optimization and schedules simulated bookings shown as white. Apply or discard simulation results. Note that simulated bookings don't show on maps with routes.

- Optimization panel showing optimization request status.

  > [!div class="mx-imgBorder"]
  > ![Screenshot of running single resource optimization with simulation mode](media/rso-single-resource-5.png)

## Additional notes

- A default goal is required for single resource optimization to work. A default goal is automatically created when deploying the optimization.
- Single resource optimization only re-optimizes current bookings and does not create new bookings.
- Single resource optimization can re-optimize bookings that were booked manually, booked via resource availability search, or booked from location agnostic requirements.
- This capability appears on the schedule board for all resources as long as optimization is deployed in the environment. However, single resource optimization only works if **Optimize Schedules** is set to **Yes** for the bookable resource. The single resource optimization capability can't be disabled or hidden.


