---
title: "Best Practices for Implementing Resource Scheduling Optimization | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 11/28/2018
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

# Best Practices for Implementing Resource Scheduling Optimization

## Best practices: general

**What RSO can do:** RSO automatically matches resources and demands, by considering skills, locations, duration, promised time windows, priorities, and many other factors. For location specific work, optimization results minimizes overall travel distances and give accurate turn-by-turn travel time estimates. All of this is to improve technician productivity and customer satisfaction.

The RSO “engine” also responds to reschedules and cancellations. After automatically scheduling dispatchers still have the ability to manually override schedules as needed.

**When to do it:** When businesses grow, it’s impossible to have human dispatchers manually scheduling or using the schedule assistant one by one for all demand requirements. Even if dispatchers had the time to handle each schedule requirement, there is no easy way to ensure technician working hours are maximized or travel distances are minimized along with SLA and priority considerations.

**How to do it:** A lot of businesses schedule resource assignments one week ahead, but setting up smart schedules to help business optimize large amount of data in the most efficient way is difficult. The secret recipe is **optimization scopes**. By leveraging the power of extensible scopes to breakdown optimization schedules into smaller sets of resources and requirements allows RSO to optimize in parallel. 

There are many settings and parameters that users might not know which settings are the best fit for their scheduling scenarios. A **What-if simulation** helps users better understand how these parameters work, how to achieve better optimization results by adjusting optimization scopes (include/exclude some resources), and re-ranking optimization objectives etc.

Here are [Resource Schedule Optimization Tutorials](https://1drv.ms/w/s!AhAjbOq5aB_lqUVCI3rt-4cq8oKr) about how to setup RSO schedules

**How to measure it:**

Measure optimization results by leveraging out-of-box optimization statistics

1.  How much travel time vs working time per schedule

2.  How many high priority jobs got scheduled

3.  How much travel time, work time per tech per day

4.  How many jobs didn’t get scheduled and missed scheduling window

> [!div class="mx-imgBorder"]
![Screenshot of RSO results bar graph comparing working time to travel time of optimized requirements](media/scheduling-adoption-guide-rso-working-time-vs-travel-time.png)

> [!div class="mx-imgBorder"]
![Screenshot of RSO results stacked bar graph comparing priorities of optimized requirements](media/scheduling-adoption-guide-rso-bar-graph-priorities.png)

Measure changes/executions after optimization

1.  How many jobs were rescheduled manually after optimization and why

2.  How many jobs completed per plan

3.  How many jobs canceled

## Best practices: manually handle exceptions after RSO optimization 

**What it can do:** Using manual scheduling or scheduling assistant to handle exceptions during the day. This includes creating/changing bookings for new requirements and adjusting the remaining schedule via manual/assisted scheduling.

**When to do it:** Using manual scheduling or scheduling assistant to handle exceptions for the following scenarios:

-   A work order is canceled and the technician has idle time in the middle of day

-   Technician is delayed from previous work and can’t make next job on time

-   Technician must perform emergency work assigned by the dispatcher that is overlapping/conflicting with other jobs

**How to do it:**

-   Drag & drop emergency work to the right resource (with the right skill or most close by)

-   Use schedule assistant to query the best resource for emergency work

## Best practices: Single Resource Optimization (SRO) 

**What it can do:** Emergencies and exceptions may happen anytime, SRO is to ensure these emergencies are addressed in time so businesses can meet their SLAs while technicians continue to have an efficient day. Again, this is to practice defining smart optimization scopes to handle unique scheduling problems.

**When to do it:** Run single resource optimization to re-optimize a single resource's schedules for a specific time window (typically the remaining day). Most applicable in the following scenarios:

-   A work order is canceled and the technician has idle time in the middle of day

-   Technician is delayed from previous work and can’t make next job on time

-   Technician must perform emergency work assigned by the dispatcher that is overlapping/conflicting with other jobs

**How to do it:** In contrast to an overnight optimization scenario, the scope and goal of an SRO optimization would be different. The scope would be to the end of the current day as the purpose of SRO is to correct and re-optimize for unexpected schedule changes. Additionally, the "schedule within working hours" constraint should be removed from the associated optimization goal as it's okay to push bookings a bit further outside of working hours. Lastly, set the "High Priority Requirements" as the first objective in order to optimize emergency work first if applicable.

 Refer [here](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/single-resource-optimization) for details about how to use SRO.

**How to measure it:** Measure single resource’s schedule between manually scheduling vs automatic SRO scheduling

-   Compare Resource utilization/idle between manual scheduling vs automatic SRO scheduling

-   Compare travel time between manual scheduling vs automatic SRO scheduling

-   Compare number of high priority work scheduled by manual scheduling vs automatic SRO scheduling

## Best practices: fully automatic scheduling for both overnight and exceptions 

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
