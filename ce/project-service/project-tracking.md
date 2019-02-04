---
title: Tracking project progress and cost consumption
description: This topic provides information about tracking project progress and cost consumption.
author: ruhercul
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 2/04/2019
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: ruhercul
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---
    
# Tracking project progress and cost consumption

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

The need to track progress against a schedule varies across different industries. Some industries track at a granular level, while others track at a higher level. This topics shows how to scheduling in Project Service Automation (PSA) to meet your organization's requirements.

## Effort tracking view

The Effort tracking view tracks the progress of tasks in the schedule. The view compares the actual effort hours spent against a task to the planned effort hours on a task. PSA uses the following formulas to show the tracking metrics:

- Progress percentage = actual effort spent to date/planned effort for the task 
- Estimate to complete (ETC) = planned effort - actual effort spent till date 
- Estimate at complete (EAC) = remaining effort + actual effort spent till date 
- Projected effort variance = planned effort - EAC 

PSA shows a projection of the effort variance on the task. If the EAC is more than the planned effort, the task is projected to take more time than originally planned and is behind schedule. If the EAC is less than the planned effort, the task is projected to take less time than originally planned and is ahead of schedule.

## Re-projecting effort

It’s common for a project manager to revise the original estimates on a task. Project re-projections are a project manager’s perception of estimates given the current state of a project. However, changing the baseline numbers isn’t recommended because the project baseline represents the established source of truth for the project’s schedule and cost estimate which all stakeholders on the project have agreed to.

There are two ways the project manager can re-project effort on tasks:

- Override the default ETC with a new estimate of the actual remaining effort on the task. 
- Override the default progress percentage with a new estimate of the true progress on the task.

Each of these approaches cause a recalculation of the task’s ETC, EAC, progress percentage, and the projected effort variance on a task. The EAC, ETC, and progress percentage on the summary tasks are also recalculated and produce a new projection of effort variance.

## Re-projection of effort on summary tasks

The re-projection of effort on summary tasks or container tasks is allowed. Whether the user re-projects by using the remaining effort or the progress percentage on the summary tasks, the following set of calculations begin:

- EAC, ETC, and progress percentage on the task are calculated.
- The new EAC is distributed down to the child tasks in the same proportion as the original EAC was on the task.
- The new EAC on each of the individualt tasks down to the leaf node tasks is calculated. 
- The affected child tasks down to the leaf nodes have their ETC and progress percentage recalculated based on the EAC value. This results in a new projection for the effort variance of the task. 
- The EACs of the summary tasks all the way to the root node are recalculated.

### Cost tracking view 

The **Cost tracking** view compares the actual cost spent against a task to the planned cost on a task. 
> [!NOTE]
> This view shows only labor costs and doesn’t include costs from the expense estimates. 

PSA uses the following formulas to show the tracking metrics:

- Percent of cost consumed = actual cost spent till date/planned cost for the task 
- Cost to complete (CTC) = planned cost – actual cost spent till date 
- EAC = CTC + actual cost spent till date 
- Projected cost variance = planned cost – EAC

A projection of the cost variance is shown on the task. If EAC is more than planned cost, the task is projected to cost more than originally planned and is trending over budget. If EAC is less than planned cost, the task is projected to cost less than originally planned for and is trending under budget.

## Project manager’s re-projection of cost

When effort is re-projected, the elements CTC, EAC, percent of cost consumed, and the projected cost variance are all recalculated on the **Cost tracking** view.

## Project status summary

Tracking data in the **Effort tracking** and **Cost tracking** views show the progress and cost consumption at the project root node, summary, and down to the leaf node tasks. The **Status** section on the **Project entity** page shows a summary of project-level status.

## Status summary fields

The **Overall project status** field is a user-controlled field that shows the overall status of the project wtih color coding, such as green, yellow, and red to indicate increasing order of risk. The **Comments** field allows the project manager to enter specific comments about the status. The **Status updated on** field is a system-driven field that shows a timestamp of when the status was last updated.

The default **Schedule performance** and **Cost performance** fields are set from the tracking date. You can set them to **Ahead** when the schedule and cost variance for the root node in **Effort tracking** view is positive, and you can set them to **Behind** when the variance at the root node is negative.
