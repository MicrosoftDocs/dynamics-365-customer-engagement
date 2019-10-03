---
title: "Single resource optimization for Resource Scheduling Optimization | MicrosoftDocs"
ms.custom: dyn365-fieldservice
ms.date: 10/03/2019
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

How and when Resource Scheduling Optimization (RSO) runs is flexible based on your organization's scheduling needs. RSO can generally be run manually, based on a schedule, or triggered from a workflow; and every run can optimize a specific set of resources, requirements, and bookings that are defined with system views.

Common scenarios include:

- Manual Run  
- Overnight scheduling
- **Single resource optimization**
- Intraday scheduling
- Condition based workflow action (CreateScheduledOptimizationRequest)
- Simulation 

When it comes to adopting Resource Scheduling tools there is a recommended progression from manual to fully automatic, see the topic on [The 5 stages of scheduling adoption](./5-stages-scheduling-adoption.md).

In this article let's explore Single resource optimization (SRO) and understand why an organization may choose to optimize work orders this way and how to configure it.

Single resource optimization provides a quick way to re-optimize a resource's schedule and travel route after schedule changes have occurred during the day. 

This is helpful for when a resource:

1. has a gap in his or her schedule due to a cancellation
2. is double booked because an emergency work order was assigned
3. is running late due to traffic or previous work
4. has a schedule that was put together manually and wants a travel route with minimal travel
   

If there is a scenario where an individual resource's schedule needs to be re-optimized, a dispatcher can manually run single resource optimization or it can even be triggered via a workflow. Unlike other RSO scenarios, **SRO cannot be run via a schedule**.


Setting up this RSO scenario as well as other scenarios involves creating a scope, goal, and schedule. To learn more about these three components of RSO, see the topic on [RSO configuration](./rso-configuration.md).


## Prerequisites

- Resource scheduling optimization version 2.8 or higher.

- **Optimize Schedules** is set to **Yes** for the bookable resource you will individually optimize the schedules of.

- Default goal in **Resource Scheduling Optimization** > **Optimization Goals**. A default goal is created automatically when optimization runs.

## Scope

Unlike running RSO for other scenarios, you do not need to create an Optimization Scope to run SRO for a resource. this is because the scope is automatically defined as the bookings for the resource in the defined date range (the rest of the current day by default).

## Goal

Goals define what RSO should consider and prioritize.

Go to **Resource Scheduling Optimization app > Optimization Goals > +New**


## Schedule

## Run and view results



There are two ways to use the schedule board to optimize the schedule for a single resource:

- **One click with defaults**: From any schedule board view, optimize the schedule with one click by setting a time range to the end of the current day for the default goal. Optimizing with one click requires Field Service application version 8.0 or higher.

- **Advanced with edits**: Optimize the schedule for a single resource by editing the goal and time range, running the optimization as a simulation, and then applying or discarding the results. This capability is only available from the schedule board view associated with the optimization scope.

  > [!div class="mx-imgBorder"]
  > ![Screenshot of triggering single resource optimization from schedule board](media/rso-single-resource-1.png)



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


