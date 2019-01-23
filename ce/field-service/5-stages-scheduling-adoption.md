---
title: "The 5 stages of scheduling adoption | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 01/23/2019
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

Throughout these stages, we recommended using Field Service tracking analytics to measure the extent to which scheduling is meeting your defined business objectives. For example, Field Service provides data on travel time, time on the job, jobs per day, etc. for use as needed.

## Choosing the right resources

Before exploring the 5 typical stages to scheduling adoption, it's important to mention that having schedulers and schedule analysts **with the right skills** is a key prerequisite for this process. These resources should be identified, trained, and empowered early in the pilot or rollout process. Keep in mind these are your resources who will be involved in scheduling on a daily basis.

## Stage 1: Manual scheduling

For any defined scope and locations, the scheduler and schedule assistant begin by manually scheduling all actual work. This will help all actively involved resources understand the scheduling tools and processes. The scheduled work should be actual work orders assigned and completed by actual technicians. This will also help technicians adjust to process changes.

Recommended time for this stage: 1-2 weeks

## Stage 2: Assisted scheduling

The next stage sees the introduction of the schedule assistant for scheduling work, in addition to manual scheduling. This work should be done by the scheduler and schedule analyst. Like with manual scheduling, schedulers will learn how to work with the schedule assistant, along with the deeper capabilities of the schedule board. Work scheduled with the schedule assistant should be actual work orders assigned to and completed by actual technicians.

Recommended time for this stage: 1-2 weeks

## Stage 3: Overnight scheduling

After introducing the schedule assistant, we often see the introduction of overnight schedule creation or iteration using the Resource Scheduling Optimization (RSO) simulated mode. The RSO analytics allow schedule analysts to compare the simulation results and decide on the best RSO schedule for overnight processing. Like with the other adoption stages, all scheduled work should be actual work orders assigned to and completed by actual technicians.

During this period, shedulers and schedule analysts can experiment and iterate on RSO schedules, allowing for adjustments to scope, goals, and timing of runs.

During the day, exceptions should be handled by the scheduler using manual and assisted scheduling. This means creating or changing bookings for new requirements, and adjusting the remaining schedule through manual or assisted scheduling.

Recommended time for this stage: 1-2 weeks

## Stage 4: Single resource optimization

As exceptions occur, using single resource optimization (SRO) from the schedule board allows schedulers to re-optimize the schedule for individual technicians. SRO should be done by the scheduler, with assistance from the schedule analyst if needed.

Recommended time for this stage: 1-2 weeks

## Stage 5: Automated exception handling

In this late stage of adoption, RSO schedules run throughout the day to re-optimize subsets of the overall schedule. Based on learnings, the system should be configured to select the correct scope for re-optimization (for instance, optimizations based on requirements, resources, or bookings).

Alternatively, schedulers may manually trigger re-optimization runs as needed.

This effort is typically led by the schedule analyst with assistance from the scheduler. The scheduler will continue to use manual/assisted scheduling on a limited basis as needed.

Recommended time for this stage: 1-2 weeks

## See also

- [RSO Overview](rso-overview.md)
- [Resource Schedule Optimization Tutorials](https://1drv.ms/w/s!AhAjbOq5aB_lqUVCI3rt-4cq8oKr)
