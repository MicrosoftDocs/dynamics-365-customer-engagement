---
title: "The 5 stages of scheduling adoption | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 01/28/2019
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---

# The 5 stages of scheduling adoption 

Given existing customer implementations, we've discovered that there are typically 5 stages of scheduling adoption with Dynamics 365 for Field Service. In this topic, we'll explore these 5 typical stages. They apply mostly to early Field Service adoption (for instance, with limited-scope projects), but the stages also apply as implementations are rolled out to cover additional scope or locations. 

We recommend using Field Service tracking analytics throughout these stages to measure how scheduling is meeting your defined business objectives. For example, Field Service provides data on travel time, time on the job, and jobs per day for use as needed.

## Choosing the right resources

It's important to note that having schedulers and schedule analysts **with the right skills** is a key prerequisite for this process. Identify, train, and empower these resources early in the pilot or roll-out process. Keep in mind these are your resources who will be involved daily in scheduling. For more information on these types of resources, visit [our topic on scheduling personas](scheduling-roles-personas.md). 

## Stage 1: Manual scheduling

For defined scope and locations, the scheduler and schedule assistant begin by manually scheduling all actual work. This helps all actively involved resources understand the scheduling tools and processes. The scheduled work should be actual work orders assigned and completed by actual technicians. This also helps technicians adjust to process changes.

Recommended time for this stage: 1-2 weeks

## Stage 2: Assisted scheduling

The next stage sees the introduction of the schedule assistant for scheduling work. This work should be done by the scheduler and schedule analyst. Like with manual scheduling, schedulers will learn how to work with the schedule assistant, along with the deeper capabilities of the schedule board. Work scheduled with the schedule assistant should be actual work orders assigned to and completed by actual technicians.

Recommended time for this stage: 1-2 weeks

## Stage 3: Overnight scheduling (RSO)

Next we often see the introduction of overnight schedule creation using the Resource Scheduling Optimization (RSO) simulated mode. RSO analytics allow schedule analysts to compare the simulation results and decide on the best RSO schedule for overnight processing. Like with the other adoption stages, all scheduled work should be actual work orders assigned to and completed by actual technicians.

During this period, shedulers and schedule analysts can experiment and iterate on RSO schedules, allowing for adjustments to scope, goals, and timing of runs.

During the day, exceptions are handled by the scheduler using manual and assisted scheduling. This means creating or changing bookings for new requirements, and adjusting the remaining schedule.

### Best practices: manually handle exceptions after RSO optimization 

**What it can do:** Using manual scheduling or scheduling assistant to handle exceptions during the day. This includes creating/changing bookings for new requirements and adjusting the remaining schedule via manual/assisted scheduling.

**When to do it:** Using manual scheduling or scheduling assistant to handle exceptions for the following scenarios:

-   A work order is canceled and the technician has idle time in the middle of day

-   Technician is delayed from previous work and can’t make next job on time

-   Technician must perform emergency work assigned by the dispatcher that is overlapping/conflicting with other jobs

**How to do it:**

-   Drag & drop emergency work to the right resource (with the right skill or most close by)

-   Use schedule assistant to query the best resource for emergency work

For more information on overnight scheduling, visit our topic on [types of scheduling](scheduling-capabilities.md).

Recommended time for this stage: 1-2 weeks

## Stage 4: Single resource optimization (RSO)

As exceptions occur, using single resource optimization (SRO) from the schedule board allows schedulers to re-optimize the schedule for individual technicians. SRO should be done by the scheduler, with assistance from the schedule analyst if needed.

### Best practices: Single Resource Optimization (SRO) 

**What it can do:** Emergencies and exceptions may happen anytime, SRO is to ensure these emergencies are addressed in time so businesses can meet their SLAs while technicians continue to have an efficient day. Again, this is to practice defining smart optimization scopes to handle unique scheduling problems.

**When to do it:** Run single resource optimization to re-optimize a single resource's schedules for a specific time window (typically the remaining day). Most applicable in the following scenarios:

-   A work order is canceled and the technician has idle time in the middle of day

-   Technician is delayed from previous work and can’t make next job on time

-   Technician must perform emergency work assigned by the dispatcher that is overlapping/conflicting with other jobs

**How to do it:** In contrast to an overnight optimization scenario, the scope and goal of an SRO optimization would be different. The scope would be to the end of the current day as the purpose of SRO is to correct and re-optimize for unexpected schedule changes. Additionally, the "schedule within working hours" constraint should be removed from the associated optimization goal as it's okay to push bookings a bit further outside of working hours. Lastly, set the "High Priority Requirements" as the first objective in order to optimize emergency work first if applicable.

Refer [here](single-resource-optimization.md) for details about how to use SRO.

**How to measure it:** Measure single resource’s schedule between manually scheduling vs automatic SRO scheduling

-   Compare Resource utilization/idle between manual scheduling vs automatic SRO scheduling

-   Compare travel time between manual scheduling vs automatic SRO scheduling

-   Compare number of high priority work scheduled by manual scheduling vs automatic SRO scheduling

Recommended time for this stage: 1-2 weeks

## Stage 5: Automated exception handling (RSO)

In this late stage of adoption, RSO schedules run throughout the day to re-optimize subsets of the overall schedule. Based on what you've learned, the system should be configured to select the correct scope for re-optimization (for instance, optimizations based on requirements, resources, or bookings).

Alternatively, schedulers may manually trigger re-optimization runs as needed.

The schedule analyst typically leads this effort, with assistance from the scheduler. The scheduler will continue to use manual and assisted scheduling on a limited basis as needed.

### Best practices: fully automatic scheduling for both overnight and exceptions 

**What it can do:** Emergencies and exceptions might happen anytime, how can we ensure these emergencies get addressed in time while also ensuring SLAs are met and technician efficicency remains high? Again, this is to practice defining smart optimization scopes to handle unique scheduling problems.

**When to do it:** When emergencies or exceptions happen during the day and need to be addressed at the same day.

**How to do it:**

1.  Define a small schedule with a few resources who normally handle emergencies, pre-define a resource view with a fixed number of resources, or pre-define a resource view that can be dynamically changed based on business logic (e.g. an emergency flag on the resource entity that is toggled to on/off with a workflow).

2. Set "Emergency" schedule to run every hour to pick up new emergency requirements and re-shuffle existing booking

    OR

Leverage Dynamics workflow capability: when an emergency/exception happens, use a workflow to call the RSO **run now** action trigger optimization. This is only applicable if emergencies do not happen often each day for a given scope.

**How to measure it:**

-   Verify if all of your new emergency requirements get scheduled as expected

-   Verify if resources have reasonable routes based on travel time and schedule board map

Recommended time for this stage: 1-2 weeks

## See also

- [RSO Overview](rso-overview.md)
