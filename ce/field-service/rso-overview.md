---
title: Overview of Resource Scheduling Optimization for Dynamics 365 Field Service
description: Learn about Resource Scheduling Optimization for Dynamics 365 Field Service.
author: andrewclear-ms
ms.author: anclear
ms.date: 03/20/2026
ms.topic: overview
ms.subservice: resource-scheduling-optimization
---

# Overview of Resource Scheduling Optimization

The Resource Scheduling Optimization Add-in for Dynamics 365 Field Service automatically schedules jobs to the resources that are best equipped to complete them. For example, it schedules work orders for field technicians or cases for customer service reps. While the [schedule board](./schedule-board-manual-scheduling.md#create-a-manual-booking) and the [schedule assistant](./schedule-assistant.md) help schedule a single job, this add-in can schedule multiple jobs at once. It maximizes resource use and minimizes travel time. Resource Scheduling Optimization considers the requirements of the job and the unique attributes of the resources.

Resource Scheduling Optimization is a paid add-in to Dynamics 365 Field Service and is built on top of the entities of the [Universal Resource Scheduling solution](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md). The price of Resource Scheduling Optimization is based on the number of resources whose schedules are optimized. Learn more in [Get Resource Scheduling Optimization](rso-get-install.md).

## Key benefits

Automated scheduling is often required because scheduling a high volume of jobs manually takes time. Resource Scheduling Optimization assists dispatchers with job matching and helps free up their time to focus on other tasks. Benefits of the Resource Scheduling Optimization add-in include:

- **Achieve scale**: By managing more resources, dispatchers can help the business scale to new territories or service offerings.

- **Improve customer satisfaction**: By improving efficiency, the add-in drives more predictable arrival and completion times and seamlessly schedules technicians for urgent situations.

- **Increase technician efficiencies**: By fitting more appointments into working hours, the add-in drives revenue and reduces overtime costs. Matching jobs and technician characteristics reduces inefficient time allocation.

- **Minimize travel time**: By ensuring your technicians take the shortest possible route with turn-by-turn directions, the add-in reduces fuel consumption and wear and tear on vehicles—savings that can easily surpass the cost of the add-in.

- **Improve customer retention**: By giving preference to higher-priority work orders, the add-in helps avoid service level agreement penalties and helps you meet customer service commitments.

## Glossary

You need to know the following key terms:

- **Jobs**: Work that needs to be completed, such as work orders, cases, or projects.
- **Resources**: Anyone or anything that needs to be scheduled to a job, including people, equipment, and facilities.
- **Schedules, bookings**: Schedules and bookings are used interchangeably and refer to the appointment time slot when a resource is assigned to a job.
- **Requirements**: The entity related to a job that defines what type of resource is needed to complete the work and gets scheduled.
- **Run**: The process when Resource Scheduling Optimization performs its scheduling and optimization functions.
- **Optimize**: Attempt to find the best schedules to reduce travel time and maximize usage.
- **Scope**: The jobs and resources that Resource Scheduling Optimization considers for optimization.
- **Goal**: Defines the ideal outcome of a run. For example, minimize travel time, maximize usage, handle high-priority jobs, or schedule jobs as soon as possible. Multiple goals are ranked because sometimes there are trade-offs.

## Address common scheduling scenarios

You can configure Resource Scheduling Optimization for your business needs based on jobs, resources, and other factors. Here are some scenarios where Resource Scheduling Optimization can help:

- **Overnight scheduling**: Resource Scheduling Optimization runs automatically each night. It schedules new jobs and optimizes existing bookings for the next day.

- **Single resource optimization**: A dispatcher gets the schedule [optimized for a single technician](rso-single-resource-optimization.md) over a couple of days, for example to account for cancellations.

- **Simulation**: A service manager runs a scheduling simulation to understand how many jobs could be completed with a varying number of resources in a specific geographic territory.

- **Intraday scheduling**: Runs optimizations every 30 minutes to schedule and adjust for changing business needs as new jobs are created and others are canceled or rescheduled.

- **Emergency scheduling**: When a user creates an urgent job, a Resource Scheduling Optimization run schedules the high-priority job as soon as possible before lower priority jobs.

## Geographical availability

The [Resource Scheduling Optimization Add-in is available](field-service-version-history-resource-scheduling-optimization.md) in most [regions where Dynamics 365 Field Service is offered](https://dynamics.microsoft.com/availability-reports/).

## Understand how it works

Resource Scheduling Optimization helps solve the common *traveling salesperson problem*, a classic optimization challenge to find the shortest possible route that visits a set of cities and returns to the origin city, visiting each city only once. However, the add-in goes beyond finding the shortest routes. It also considers other parameters like characteristics, territory, promised time windows, and more.

Here's how it works:

1. Create a list of jobs that need to be completed. Jobs are generally work orders for onsite service, cases for remote service, or project tasks.

1. List the required resources for each job and when it needs to be completed. For example, a work order needs someone nearby with repair skills to complete the job by the end of the week.

1. Choose which resources can be considered for the jobs. Each resource has different attributes like location, role, type, and characteristics.

1. Run Resource Scheduling Optimization on a predefined schedule, or triggered by a workflow. After the system completes the optimization, dispatchers can [use the schedule board](../common-scheduler/schedule-board-utilization.md) to make changes as needed.

## Get periodic updates

Microsoft releases new versions of Resource Scheduling Optimization periodically. The [version history](./field-service-version-history-resource-scheduling-optimization.md#release-schedule) lists changes and updates. The product rolls out some releases to all stations on a set schedule.

## Next steps

- [Get Resource Scheduling Optimization](rso-get-install.md)

- [Deploy Resource Scheduling Optimization](rso-deployment.md)

- [Review the Resource Scheduling Optimization quickstart guide](rso-quickstart.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
