---
title: "The five stages of scheduling adoption | MicrosoftDocs"
description: Learn about the different stages of scheduling adoption for field service organizations.
ms.date: 09/17/2022

ms.topic: conceptual
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: Deana-Fuller
ms.author: drfuller
search.app: 
  - D365CE
  - D365FS
---

# Five stages of scheduling adoption

There are typically five stages of adoption for scheduling capabilities in Dynamics 365 Field Service. These stages mostly apply to early Field Service adoption. Sometimes, we also see them when implementations start to cover more scope or locations.

We recommend to [look at relevant KPIs](reports.md) throughout these stages to measure how scheduling affects your defined business objectives. For example, Field Service provides data on travel time, time on the job, and jobs per day for use as needed.

It's important to have people **with the right skills** dispatching work and analyze the process. Identify, train, and empower these people early in the roll-out process. For more information, see [our article on scheduling personas](scheduling-roles-personas.md).

We suggest you take 1-2 weeks for every stage to apply learnings and optimize processes.

## Stage 1: Manual scheduling

For defined scope and locations, dispatchers manually schedule all actual work. All involved resources learn to understand the scheduling tools and processes. The scheduled work should be actual work orders assigned and completed by field technicians. This adoption stage also helps technicians adjust to process changes.

## Stage 2: Schedule assistant

The next stage sees the introduction of the [schedule assistant capability](schedule-assistant.md). This work should be done by the scheduler and schedule analyst. Like with manual scheduling, schedulers learn how to work with the schedule assistant and details of the schedule board.

## Stage 3: Automated overnight scheduling and manual exception handling

As businesses grow, so do scheduling needs. It’s difficult to have human dispatchers manually scheduling all requirements. During this stage, schedulers and schedule analysts can experiment and iterate on automated schedules, allowing for adjustments to scope, goals, and timing of runs.

[Resource Scheduling Optimization](rso-overview.md) is an add-in solution that automatically matches resources and demands by considering skills, locations, priorities, and other factors. For location-specific work, optimization results minimize overall travel distances and give accurate turn-by-turn travel time estimates to improve productivity and customer satisfaction.

Resource Scheduling Optimization also responds to rescheduling and cancellations while dispatchers can manually override schedules as needed.

Many businesses schedule resource assignments one week in advance. Resource Scheduling Optimization works with **optimization scopes** to break down optimization schedules into smaller sets of resources and requirements optimize in parallel.

### Measure successful optimizations

What organizations choose to measure and track depends on their business goals. With out-of-the-box optimization statistics, schedule analysts can measure:

- Travel time versus working time, per schedule

  >[!div class="mx-imgBorder"]
  >![Screenshot of Resource Scheduling Optimization results bar graph comparing working time to travel time of optimized requirements.](media/scheduling-adoption-guide-rso-working-time-vs-travel-time.png)

- How many high priority jobs were scheduled

  > [!div class="mx-imgBorder"]
  >![Screenshot of Resource Scheduling Optimization results stacked bar graph comparing priorities of optimized requirements.](media/scheduling-adoption-guide-rso-bar-graph-priorities.png)

- Travel time and work time per technician, per day

- How many jobs weren't scheduled

Resource Scheduling Optimization analytics allow schedule analysts to compare simulation results and decide on the best Resource Scheduling Optimization schedule for overnight processing. Like with the other adoption stages, all scheduled work should be actual work orders assigned to and completed by actual technicians.

### Best practice: manually handle exceptions after optimization

Exceptions are handled by the scheduler using manual and assisted scheduling. They create or change bookings for new requirements and adjust the remaining schedule.

Exception handling is useful in the following scenarios:

- A work order is canceled and the technician has availability in the middle of day

- The technician is delayed from previous work and can’t make next job on time

- The technician must perform emergency work assigned by the dispatcher that conflicts with other jobs

To manually handle exceptions in cases like these:

1. Drag and drop emergency work to the best resource (matched either by skill or by proximity to job).

2. Use the schedule assistant to query the best resource for emergency work.

For more information on overnight scheduling, visit our article on [types of scheduling](scheduling-capabilities.md).

## Stage 4: Single resource optimization

The next stage uses Resource Scheduling Optimization for schedule changes and exceptions. This is accomplished with [single resource optimization](rso-single-resource-optimization.md) from the schedule board. Instead of processing the entire workforce schedule, single resource optimization allows you to target the specific field technician's schedule as changes occur.

In contrast to an overnight optimization scenario, the scope is different for a single resource optimization and typically ends when the current day ends. Additionally, the **Schedule within working hours** constraint should be removed from the associated optimization goal, as it's okay to push bookings a bit further outside of working hours. Lastly, set the **High Priority Requirements** as the first objective in order to optimize emergency work first.

During this adoption stage, analysts can see whether manual scheduling or single resource optimization is working better by:

- Compare resource utilization between manual scheduling versus automatic single resource optimization scheduling

- Compare travel time between manual scheduling versus automatic single resource optimization scheduling

- Compare the high priority work scheduled by manual scheduling versus automatic single resource optimization scheduling

For more information, see [Single Resource Optimizations](single-resource-optimization.md).

## Stage 5: Fully automated resource scheduling

[Resource Scheduling Optimization](rso-overview.md) schedules optimization runs throughout the day to optimize subsets of the overall schedule. Based on what you've learned, the system should be configured to select the correct optimization scope.

Alternatively, dispatchers may manually trigger runs as needed.

The schedule analyst typically leads this effort, with assistance from the dispatcher who continues to use manual and assisted scheduling on a limited basis as needed.

### Best practice: fully automatic scheduling for both overnight and exceptions

Emergencies and exceptions might happen anytime. Endure these emergencies are addressed in time to ensure SLAs are met and technician are productive. Define smart optimization scopes to handle your unique scheduling problems:

1. Define a small schedule with a few resources who normally handle emergencies.
2. Create a resource view with a fixed number of resources, or one that can be dynamically changed based on business logic. For example, an emergency flag on the resource entity that is toggled to on/off with a workflow.
3. Set the emergency schedule to run every hour and pick up new emergency requirements. You can also use a workflow to call the Resource Scheduling Optimization **Run now** action trigger when emergencies occur.
4. Verify that your new emergency requirements get scheduled as expected.
5. Verify that resources have reasonable routes based on travel time and schedule board map.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
