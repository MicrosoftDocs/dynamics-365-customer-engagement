---
title: "Best practices for implementing Resource Scheduling Optimization | MicrosoftDocs"
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

# Best practices for implementing Resource Scheduling Optimization
To get the most out of Resource Scheduling Optimization (RSO), we recommend a few key best practices as you ramp up scheduling adoption, automation, and optimization across your field service organization. In this topic, you'll find information on the following best practices: 

- General best practices for RSO
- Manually handling exceptions after optimization runs
- Single resource optimization
- Fully automatic scheduling

## General 
Resource Scheduling Optimization (RSO) automatically matches resources and demands by considering skills, locations, duration, promised time windows, priorities, and many other factors. For location-specific work, optimization results minimizes overall travel distances and give accurate turn-by-turn travel time estimates. All of this is to improve technician productivity and customer satisfaction.

The RSO “engine” also responds to reschedules and cancellations. After automatically scheduling dispatchers still have the ability to manually override schedules as needed.

**When to do it:** When businesses grow, it’s impossible to have human dispatchers manually scheduling or using the schedule assistant one by one for all demand requirements. Even if dispatchers had the time to handle each schedule requirement, there is no easy way to ensure technician working hours are maximized or travel distances are minimized along with SLA and priority considerations.

**How to do it:** A lot of businesses schedule resource assignments one week ahead, but setting up smart schedules to help business optimize large amount of data in the most efficient way is difficult. The secret recipe is **optimization scopes**. By leveraging the power of extensible scopes to breakdown optimization schedules into smaller sets of resources and requirements allows RSO to optimize in parallel. 

There are many settings and parameters that users might not know which settings are the best fit for their scheduling scenarios. A **What-if simulation** helps users better understand how these parameters work, how to achieve better optimization results by adjusting optimization scopes (include/exclude some resources), and re-ranking optimization objectives etc.


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






