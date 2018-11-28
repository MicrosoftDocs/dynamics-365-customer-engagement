---
title: "Implementing Field Service Scheduling Capabilities | MicrosoftDocs"
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

# The when and why of scheduling capabilities  

### Purpose 

The Field Service solution includes a comprehensive set of capabilities which comprise the “scheduling system”. The capabilities are intended (and proven in practice) to be used in combination for successful scheduling. This guidance is based on the design of the scheduling system and learnings from actual customers implementations.

Following are the set of capabilities and why/when they are used.

### Audience 

Partner and customer team members who are defining pilots, rollouts, and change management.


## Step 1: Manual scheduling 

### What

Manual service scheduling is based on using the schedule board to select requirements and individually create bookings (matching the requirement to a resource in a time slot).

### When/why 

Manual scheduling is applicable in the following situations:

-   As part of a broader adoption to drive learning/understanding/ramp-up during a pilot or proof of concept

-   To handle exceptions such as emergency work (in conjunction with assisted or automated scheduling)

-   It makes business sense to do largely manual scheduling based on less complex requirements or a less mature scheduling process

### Capabilities

The schedule board is a key capability of the scheduling system and is used across the various types of scheduling (manual, assisted, automated/optimized). The schedule board is very configurable and extensible to meet specific scheduling requirements.

## Step 2: Scheduling Assistant 

### What

Scheduling assistant uses the details of a requirement (e.g. distance, dates, skills, territory) to apply smart filtering and provides recommended times and resources to create a booking. It also enables meeting business objectives such as reducing travel time and increasing effective work time.

### When/why

Schedule assistant is applicable in the following situations:

-   As part of a broader adoption to drive learning/understanding/ramp-up during a pilot or proof of concept

-   To handle exceptions such as emergency work (in conjunction with assisted or automated scheduling)

-   To expose scheduling via case or customer portal

-   To schedule a subset of requirements that may be less effective for optimization/automated scheduling

-   It makes business sense to do largely manual scheduling based on less complex requirements or a less mature scheduling process

### Capabilities

The schedule assistant is very configurable and extensible. It can be used from within the schedule board, or from within a work order. It can also be embedded on others forms,such as the case form. Schedule assistant can be used from a work order, or the schedule board. In addition the schedule assistant actions can be available via the portal to offer customer self-service scheduling.

## Optimized / Automated scheduling 

Field service includes a set of optimized/automated capabilities called Resource Scheduling Optimization (RSO) that can be used in various combinations, including in combination with manual and schedule assistant.

### What

RSO provides optimized and automated scheduling capabilities. It is designed to be used in conjunction with manual and assisted scheduling to provide a comprehensive scheduling solution.

### When/Why

In practice RSO is used in the following ways:

-   **Overnight scheduling** – for a given subset of requirements and resources, schedule for the following 1 to 2 days. 

-   **Single resource optimization (SRO)** – during the work day, as changes occur (emergency work, cancellations, delays) the remaining schedule for a resource can be re-optimized by the scheduler. This will commonly be done by the scheduler via the schedule board. Another approach is to use SRO in combination with manual and schedule assistant to optimize individual resources as needed.

-   **Inter-day optimization** – during the work day, as changes occur subsets of the overall schedule can be re-optimized. For example a schedule can run every 30 minutes to re-schedule those requirements and resources marked for re-schedule

In practice optimized/automated scheduling is used in combination with manual and assisted scheduling to achieve the desired results.

### Capabilities

In order to achieve the right optimized/automated scheduling outcomes, the following capabilities are used in combination.

-   **Optimization scope** – this determines which requirements, resources and bookings are considered for a given RSO run. 

-   **Optimization goals** – this specifies the objectives and constraints that RSO uses to evaluate and determine the best schedule given the above scope.

-   **Schedule** – this specifies the timing and pattern of RSO runs for a particular scope and goal.

-   **Simulated runs** – this is a tool that can be used by schedule analysts to evaluate the results of an optimization run with the ability to apply or discard results.

-   **Analytics** – this provides numerical measures for RSO runs and helps to determine the extent to which business objectives are being met.

-   **Workflow** – this is a general Dynamics 365 capability that is used to change data values or trigger actions based on events. For example it could be used to set a “needs re-optimization” attribute on a resource given some business event (e.g. emergency booking)

-   **Views** – this is a general Dynamics 365 capability that is used to select a subset of rows and fields for a given entity (e.g. requirement/resource). Dynamics 365 views ar used to provide flexibility for expressing optimization scope-the list of resources and requirements to be optimized.

Successful implementations use these capabilities with a high degree of iteration to achieve desired results.