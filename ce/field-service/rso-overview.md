---
title: Overview of Resource Scheduling Optimization for Dynamics 365 Field Service
description: Learn about Resource Scheduling Optimization for Dynamics 365 Field Service.
author: AnilMur
ms.author: anilmur
ms.date: 06/04/2024
ms.topic: overview
ms.subservice: resource-scheduling-optimization
---

# Overview of Resource Scheduling Optimization

The Resource Scheduling Optimization Add-in for Dynamics 365 Field Service automatically schedules jobs to the resources that are best equipped to complete them. For example, schedule work orders for field technicians or cases for customer service reps. While the [schedule board](./work-with-schedule-board.md#book) and the [schedule assistant](./schedule-assistant.md) help schedule a single job, this add-in can schedule multiple jobs at once. It maximizes resource use and minimizes travel time. Resource Scheduling Optimization considers the requirements of the job and the unique attributes of the resources.

Resource Scheduling Optimization is a paid add-in to Dynamics 365 Field Service and is built on top of the entities of the [Universal Resource Scheduling solution](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md).

## Get to know the key benefits

Automated scheduling is often required because scheduling a high volume of jobs manually takes time. Resource Scheduling Optimization assists dispatchers with job matching and helps free up their time to focus on other tasks. Benefits of the Resource Scheduling Optimization add-in include:

- **Achieve scale**: Allowing dispatchers to manage more resources enables the business to scale to new territories or service offerings.

- **Improve customer satisfaction**: Improving efficiency drives more predictable arrival and completion times and seamlessly schedules technicians for urgent situations.

- **Increase technician efficiencies**: Fitting more appointments into working hours drives revenue and reduces overtime costs. Matching jobs and technician skills reduces inefficient time allocation.

- **Minimize travel time**: Ensuring your technicians are taking the shortest possible route with turn-by-turn directions reduces fuel consumption and wear and tear on vehicles—savings that can easily surpass the cost of the add-in.

- **Improve customer retention**: Giving preference to higher-priority work orders helps avoid service level agreement penalties and helps you meet customer service commitments.

## Address common scheduling scenarios

You can configure Resource Scheduling Optimization for your business needs based on jobs, resources, and other factors. Scenarios where Resource Scheduling Optimization can help:

- **Overnight scheduling**: Resource Scheduling Optimization runs automatically each night. It schedules new jobs and optimizes existing bookings for the next day.

- **Single resource optimization**: A dispatcher gets the schedule [optimized for a single technician](rso-single-resource-optimization.md) over a couple of days, for example to account for cancellations.

- **Simulation**: A service manager runs a scheduling simulation to understand how many jobs could be completed with a varying number of resources in a specific geographic territory.

- **Intraday scheduling**: Runs optimizations every 30 minutes to schedule and adjust for changing business needs as new jobs are created and others are canceled or rescheduled.

- **Emergency scheduling**: When an urgent job is created, a Resource Scheduling Optimization run schedules the high-priority job as soon as possible before lower priority jobs.

## Understand how it works

Resource Scheduling Optimization helps solve the common *traveling salesperson problem*, a classic optimization challenge to find the shortest possible route that visits a set of cities and returns to the origin city, visiting each city only once. However, the add-in goes beyond finding the shortest routes. It also considers other parameters like skills, territory, promised time windows, and more.

Here's how it works:

1. Create a list of jobs that need to be completed. Jobs are generally work orders for onsite service, cases for remote service, or project tasks.

1. List the required resources for each job and when it needs to be completed. For example, a work order needs someone nearby with repair skills to complete the job by the end of the week.

1. Choose which resources can be considered for the jobs. Each resource has different attributes like location, role, type, and skills.

1. Run Resource Scheduling Optimization on a predefined schedule, or triggered by a workflow. After the system completes the optimization, dispatchers can [use the schedule board](../common-scheduler/schedule-board-utilization.md) to make changes as needed.

## Get periodic updates

Microsoft releases new versions of Resource Scheduling Optimization periodically. The [version history](./field-service-version-history-resource-scheduling-optimization.md#release-schedule) lists changes and updates. Some releases are rolled out to all stations on a set schedule. However, you can [selectively deploy a release](./rso-deployment.md#manage-the-resource-scheduling-optimization-instance) in your environment.

## Next steps

- [Get Resource Scheduling Optimization](rso-get-install.md)

- [Deploy Resource Scheduling Optimization](rso-deployment.md)

- [Review the Resource Scheduling Optimization quickstart guide](rso-quickstart.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
