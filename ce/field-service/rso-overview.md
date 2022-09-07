---
title: Overview of Resource Scheduling Optimization for Dynamics 365 Field Service
description: Learn about Resource Scheduling Optimization for Dynamics 365 Field Service.
author: m-hartmann
ms.reviewer: mhart
manager: shellyha
ms.date: 09/07/2022
ms.topic: overview
ms.subservice: resource-scheduling-optimization
ms.author: mhart
search.app: 
  - D365CE
  - D365FS
---

# Overview of Resource Scheduling Optimization

Resource Scheduling Optimization automatically schedules jobs to the people, equipment, and facilities best equipped to complete them. Schedule work orders for field technicians or cases for customer service reps. You can cover other scenarios too, depending on how you use Dynamics 365 Field Service, Customer Service, and Project Service Automation.

Resource Scheduling Optimization is a more advanced form of scheduling for field service organizations. While the schedule board and the schedule assistant help dispatchers schedule a single job, this add-in can schedule multiple jobs at once. It maximizes resource utilization and minimizes travel time. Resource Scheduling Optimization considers the requirements of the job and the unique attributes of the resources.

 > [!div class="mx-imgBorder"]
  > ![Screenshot of Resource Scheduling Optimization and the schedule board.](media/rso-optimized-schedule-board-routes.png)

## Benefits

Automated scheduling is often required because scheduling a high volume of jobs manually takes a lot of time. Resource Scheduling Optimization assists dispatcher with job matching and helps free up their time to focus on other tasks. More reasons that organizations use the Resource Scheduling Optimization add-in:

- **Achieve scale**: Allows dispatchers to manage more resources, enabling the
business to scale to new territories or service offerings.

- **Customer satisfaction**: Improved efficiency drives more predictable arrival and completion times and seamlessly schedules technicians for urgent situations.

- **Technician efficiencies**: Fitting more appointments into working hours drives revenue and reduces overtime costs.Matching work orders and technician skills reduces inefficient time allocation.

- **Minimized travel time**: Ensuring your technicians are taking the shortest possible route with turn-by-turn directions reduces fuel consumption and wear and tear on vehicles. Savings likely surpass the cost of the add-in licenses.

- **Improved customer retention**: Giving preference to higher-priority work orders helps avoid service level agreement penalties and helps you meet customer service commitments.

## Scenarios

Configure Resource Scheduling Optimization for your business needs based on jobs, resources, and other factors. Scenarios where Resource Scheduling Optimization can help:

- **Overnight scheduling**: Resource Scheduling Optimization runs automatically each night, schedules new jobs and optimizes existing bookings for the next day.

- **Single Resource Optimization**: A dispatcher gets the schedule [optimized for a single technician](single-resource-optimization.md) for the rest of today to recalculate an optimal travel route after a cancellation.

- **Simulation**: A service manager runs a scheduling simulation to understand how many jobs could be completed with a varying number of resources in a specific geographic territory.

- **Intraday scheduling**: Runs optimizations every 30 minutes to schedule and adjust for changing business needs as new jobs are created and others are cancelled or rescheduled.

- **Emergency scheduling**: When an urgent job is created, a Resource Scheduling Optimization run schedules the high priority job as soon as possible before lower priority jobs.

## Glossary

- **Jobs**: Work that needs to be completed like work orders, cases, and projects. There's no "jobs" entity in Field Service or Resource Scheduling Optimization.
- **Resources**: Anyone or anything that needs to be scheduled to a job including people, equipment, and facilities.
- **Schedules, bookings**: Schedules and bookings are used interchangeably and refer to the appointment time slot when a resource is assigned to a job.
- **Requirements**: The entity related to a job that defines what type of resource is needed to complete the work. This is the entity that will ultimately be scheduled via Resource Scheduling Optimization.
- **Run**: When Resource Scheduling Optimization performs its scheduling and optimization functions, it's called a run. A run usually leads to to schedules on the Schedule Board.
- **Optimize**: Attempt to find the best schedules to reduce travel time and maximize utilization.
- **Scope**: The jobs and resources that Resource Scheduling Optimization considers. For example, you may not have the schedule for every job in the system to every resource. You'll most likely partition the jobs and resources into a scope.  
- **Goal**: Defines the ideal outcome of a run. For example, minimize travel time, maximize utilization, handle high priority jobs, or scheduling jobs as soon as possible. Multiple goals are ranked because sometimes there are trade-offs.

## System requirements

- Dynamics 365 online
- Resource Scheduling Optimization is a paid add-on to [Universal Resource Scheduling (URS)](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md) and is built on top of its entities. Organizations that use either Dynamics 365 Field Service, Customer Service, and Project Service Automation are entitled to URS. If you want to use Resource Scheduling Optimization to automatically schedule Dynamics 365 Sales opportunities to sales reps, you need Dynamics 365 Field Service, Customer Service, or Project Service Automation too.

## How it works

Resource Scheduling Optimization is an enhanced application of the famous "traveling salesperson problem" that asks the following question: "Given a list of cities and the distances between each pair of cities, what is the shortest possible route that visits each city and returns to the origin city?". It's a mathematical problem and the solution is a large part of the Resource Scheduling Optimization computation. Nevertheless, Resource Scheduling Optimization goes beyond finding the shortest routes because it also considers things like skills, territory, roles, priorities, resource preferences, promised time windows, and more.

Here's how it works.

1. You create a list of jobs that need to be completed. These are generally work orders for onsite service, cases for remote service, and project tasks.

2. For each job, you list what kind of resource is needed and when it needs to be completed. For example, for a work order you may need someone nearby with repair skills and the work order needs to be completed by the end of this week. Much of this information is automatically populated based on the job details.

3. Next you pick a list of resources that are eligible to be considered for your list of jobs, and each resource has different attributes like where they're located, what role the resource has, what type of resource they are (employee, contractor, facility, equipment), and what skills they have.

4. After that you run Resource Scheduling Optimization, which can be run manually by pushing a button, based on a predefined schedule or timetable, or triggered by a workflow. Also, Resource Scheduling Optimization can run differently depending on what it's scheduling. It can run differently for US jobs compared to Canadian jobs or differently for work orders compared to cases.

5. When Resource Scheduling Optimization runs, the job requirements and the list of resources are sent to Azure and Resource Scheduling Optimization computes an optimal schedule that is displayed on the schedule board.

6. After Resource Scheduling Optimization runs, dispatchers can use the interactive schedule board and schedule assistant to makes changes as needed.

## Optimized schedules

Resource Scheduling Optimization optimizes schedules in addition to automatically scheduling bookings. After running Resource Scheduling Optimization, it's important to understand the optimized results. Lets look at a three examples.

### 1. Clustered routes

In the following screenshot is an optimized schedule board. In the left pane, you'll see a map view of the optimized bookings.

  > [!div class="mx-imgBorder"]
  > ![Screenshot of an optimized schedule board.](media/rso-optimized-schedule-board-routes-with-annotation.png)

  One way you can see Resource Scheduling Optimization working effectively is the travel routes are clustered around each resource's starting location where each color represents a different technician's route. When dispatchers manually schedule jobs without using Resource Scheduling Optimization, the travel routes are often spread across the map zigzagging in different directions.

### 2. Sequential bookings at the same location

In the previous image, you can see some bookings are scheduled back-to-back with no travel time in between. This means Resource Scheduling Optimization scheduled a job and understood there was another job at the same location for the same customer and decided to schedule them together. Simple types of optimization can be harder for dispatchers to do manually across many jobs.

### 3. Travel time vs working time

Every time Resource Scheduling Optimization runs, it keeps track of the total travel time compared to working time in a graph as seen in the image below. This helps you understand how Resource Scheduling Optimization will reduce the total travel time across all of your field technicians compared to manual or semi-automated scheduling (schedule assistant).

> [!div class="mx-imgBorder"]
> ![Screenshot of active optimization request bookings.](media/rso-working-vs-travel-time.png)

## Get started

- [Get Resource Scheduling Optimization](rso-get-install.md)

- [Deploy Resource Scheduling Optimization](rso-deployment.md)

- [Resource Scheduling Optimization quickstart guide](rso-quickstart.md)

- ![Video symbol](../field-service/media/video-icon.png "Video symbol") [Resource Scheduling Optimization quickstart video](https://youtu.be/oJ-3HTJWRMo)

- [Five stages of scheduling adoption](5-stages-scheduling-adoption.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
