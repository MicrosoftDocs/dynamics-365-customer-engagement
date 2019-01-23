---
title: "The 5 Stages of Scheduling Adoption | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 01/23/2019
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---

# The 5 Stages of Scheduling Adoption 

Following are guidance derived from previous customers implementations. These are intended to apply to early adoption such as limited-scope pilots. The pattern also applies as implementations are rolled out to additional scope/locations.

Throughout the stages it is recommended that analytics be used to measure the extent to which scheduling is meeting business objectives. The field service system captures a rich set of information throughout the process that will help enable such measurements. For example data is available on travel time, time on the job, jobs / day… to be used as appropriate.

### Right Resources

As mentioned above having appropriate skilled schedulers and schedule analysts is a key prerequisite to adopting scheduling. These should be identified, trained and enabled early in the pilot/rollout process. Keep in mind these are “hands on” resources who will be involved on a daily basis in the scheduling process.

## Stage 1 – Manual scheduling

For the given defined scope/locations, begin by scheduling all actual work using manual scheduling. This should be done by the scheduler and schedule analyst. This will provide the learning and experience needed by all involved to understand the tools and processes. These should be actual work orders assigned and completed by actual technicians. This is also part of the change process for technicians.

Suggested period: 1-2 weeks

## Stage 2 – Assisted scheduling

For the given defined scope/locations, in addition to manual scheduling, introduce the use of the schedule assistant to schedule all actual work. This should be done by the scheduler and schedule analyst. This will provide the learning and experience needed by all involved to understand the schedule assistance and deeper capabilities of the schedule board. These should be actual work orders assigned and completed by actual technicians.

Suggested period: 1-2 weeks

## Stage 3 – Overnight scheduling

For the given defined scope/locations, introduce creating of schedules in an overnight process using RSO. Begin by creating/iterating overnight schedules using the RSO simulated mode. Also use the RSO analytics to compare the results of simulation and decide on the appropriate RSO schedule for overnight processing. This effort should be led by the schedule analyst with assistance from the scheduler. These should be actual work orders assigned and completed by actual technicians.

This period will enable experimentation and iteration on RSO schedules and allow for adjustments to scope, goals, and timing of runs.

During the day, exceptions should be handled by the scheduler using manual and assisted scheduling. This will entail creating/changing bookings for new requirements and adjusting the remaining schedule via manual/assisted scheduling.

Suggested period: 1-2 weeks

## Stage 4 – Single Resource Optimization

During the day as exceptions occur, in addition to manual and assisted scheduling, begin using SRO from the schedule board to re-optimize the schedule for individual technicians. This should be done by the scheduler with assistance from the schedule analyst.

Suggested period: 1-2 weeks

## Stage 5 – Automated Exception Handling

At this stage RSO schedules are created which will run throughout the day to re-optimize a subset of the overall schedule. Based on learnings, the system should be configured to select the correct scope for re-optimization (requirements, resources and bookings).

Another approach at this stage is for the scheduler to manually trigger re-optimization runs as appropriate.

This effort should be led by the schedule analyst with assistance from the scheduler. The scheduler will continue to use manual/assisted scheduling on a limited basis as needed.

Suggested period: 1-2 weeks

### See also

- [RSO Overview](rso-overview.md)
- [Resource Schedule Optimization Tutorials](https://1drv.ms/w/s!AhAjbOq5aB_lqUVCI3rt-4cq8oKr)
