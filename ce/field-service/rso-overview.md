---
title: Overview of Resource Scheduling Optimization for Dynamics 365 Field Service
description: Learn about Resource Scheduling Optimization for Dynamics 365 Field Service.
author: FeifeiQiu
ms.author: feiqiu
ms.date: 05/30/2024
ms.topic: overview
ms.subservice: resource-scheduling-optimization
---

# Overview of Resource Scheduling Optimization

The Resource Scheduling Optimization Add-in automatically schedules jobs to the resources that are best equipped to complete them. For example, schedule work orders for field technicians or cases for customer service reps. While the schedule board and the schedule assistant help schedule a single job, this add-in can schedule multiple jobs at once. It maximizes resource utilization and minimizes travel time. Resource Scheduling Optimization considers the requirements of the job and the unique attributes of the resources.

:::image type="content" source="media/rso-optimized-schedule-board-routes.png" alt-text="Screenshot of Resource Scheduling Optimization and the schedule board.":::

Resource Scheduling Optimization is a paid add-in to the [Universal Resource Scheduling solution](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md) and is built on top of its entities. Organizations that use Dynamics 365 Field Service, Customer Service, and Project Service Automation have Universal Resource Scheduling built into their applications.

## Get to know the key benefits

Automated scheduling is often required because scheduling a high volume of jobs manually takes much time. Resource Scheduling Optimization assists dispatcher with job matching and helps free up their time to focus on other tasks. More reasons that organizations use the Resource Scheduling Optimization add-in:

- **Achieve scale**: Allows dispatchers to manage more resources, enabling the business to scale to new territories or service offerings.

- **Customer satisfaction**: Improved efficiency drives more predictable arrival and completion times and seamlessly schedules technicians for urgent situations.

- **Technician efficiencies**: Fitting more appointments into working hours drives revenue and reduces overtime costs. Matching jobs and technician skills reduces inefficient time allocation.

- **Minimized travel time**: Ensuring your technicians are taking the shortest possible route with turn-by-turn directions reduces fuel consumption and wear and tear on vehicles. Savings that can easily surpass the cost of the add-in.

- **Improved customer retention**: Giving preference to higher-priority work orders helps avoid service level agreement penalties and helps you meet customer service commitments.

## Address common scheduling scenarios

You can configure Resource Scheduling Optimization for your business needs based on jobs, resources, and other factors. Scenarios where Resource Scheduling Optimization can help:

- **Overnight scheduling**: Resource Scheduling Optimization runs automatically each night. It schedules new jobs and optimizes existing bookings for the next day.

- **Single Resource Optimization**: A dispatcher gets the schedule [optimized for a single technician](rso-single-resource-optimization.md) for the rest of today to recalculate an optimal travel route after a cancellation.

- **Simulation**: A service manager runs a scheduling simulation to understand how many jobs could be completed with a varying number of resources in a specific geographic territory.

- **Intraday scheduling**: Runs optimizations every 30 minutes to schedule and adjust for changing business needs as new jobs are created and others are canceled or rescheduled.

- **Emergency scheduling**: When an urgent job is created, a Resource Scheduling Optimization run schedules the high priority job as soon as possible before lower priority jobs.

## Understand how it works

Resource Scheduling Optimization helps solve the common *traveling salesperson problem*, a classic optimization challenge to find the shortest possible route that visits a set of cities and returns to the origin city, visiting each city only once. However, the add-in goes beyond finding the shortest routes. It also considers other parameters like skills, territory, promised time windows, and more.

Here's how it works:

1. Create a list of jobs that need to be completed. Jobs are generally work orders for onsite service, cases for remote service, or project tasks.

1. List the required resources for each job and when it needs to be completed. For example, a work order needs someone nearby with repair skills to complete the job by the end of the week.

1. Choose which resources can be considered for the jobs. Each resource has different attributes like location, role, type, and skills.

1. Run Resource Scheduling Optimization, ad-hoc, on a predefined schedule, or triggered by a workflow. After the system completes the optimization, dispatchers can [use the schedule board](../common-scheduler/schedule-board-utilization.md) to make changes as needed.

## Get started

- [Get Resource Scheduling Optimization](rso-get-install.md)

- [Deploy Resource Scheduling Optimization](rso-deployment.md)

- [Review the Resource Scheduling Optimization quickstart guide](rso-quickstart.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
