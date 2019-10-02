---
title: "Overnight scheduling with Resource Scheduling Optimization (RSO) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/02/2019
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
search.app: 
  - D365CE
  - D365FS
---

# Automated Overnight Scheduling

How and when Resource Scheduling Optimization (RSO) runs is flexible based on your organization's scheduling needs. RSO can be run manually, based on a schedule, or triggered from a workflow action (CreateScheduledOptimizationRequest); and every run can optimize a specific set of resources, requirements, and bookings that are defined with system views.

Common scenarios include:

- Manual Run  
- Overnight scheduling
- Single resource optimization
- Intraday scheduling
- Condition based workflow
- Simulation 

When it comes to adopting Resource Scheduling tools there is a recommended progression from manual to fully automatic, see the topic on [The 5 stages of scheduling adoption](./5-stages-scheduling-adoption.md).

In this article let's explore overnight scheduling and understand why an organization may choose to optimize work orders this way and how to configure it.

Overnight scheduling means RSO runs each night at a defined time and schedules jobs (typically work orders) for the next day. The next morning, a dispatcher arrives to work to find a full optimized schedule board for that day where jobs are scheduled to the appropriate resources based on skills, promised time windows, preferred resources, roles, and more. For the rst of the day, RSO will not run and the dispatcher will make changes as needed with manual scheduling or the schedule assistant to deal with delays, cancellations, and special customer requests.

## Scope

## Goal

## Schedule

## Results

## Prerequisites
> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Configuration considerations
## Additional Notes
